#region HEADER
// File: resume.cs
// Project: CV_Analyser
// Description: CV processing engine with keyword matching and scoring
#endregion

#region LIBRARIES
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
#endregion

namespace CV_Analyser.Backend.Resume
{
    #region CLASSES
    // Holds the result of a single CV analysis pass
    internal class C_Analyze_Result
    {
        #region VARIABLES
        public int Score { get; set; }
        public string Found_Keywords { get; set; }
        #endregion
    }

    // CV processing engine for PDF extraction, scoring, and keyword analysis
    internal class C_Resume
    {
        #region CONSTANTS
        private static readonly HashSet<char> INVALID_CHARS = new HashSet<char>(
            "\"*,<é!'^%&/()=?;>:£$½{[]}\\|@€₺¨~æß´`-_ ".ToCharArray());
        #endregion

        #region UTILITIES
        // Removes invalid characters from a word for clean comparison
        private static string F_Clean_Word(string p_word)
        {
            var sb = new StringBuilder(p_word.Length);
            foreach (char c in p_word)
            {
                if (!INVALID_CHARS.Contains(c)) { sb.Append(c); }
            }
            return sb.ToString();
        }

        // Extracts text content from a PDF file
        public static string F_Pdf_To_String(string p_folder_path, string p_pdf_name)
        {
            using (var reader = new PdfReader(System.IO.Path.Combine(p_folder_path, p_pdf_name)))
            {
                using (var output = new StringWriter())
                {
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        output.WriteLine(PdfTextExtractor.GetTextFromPage(reader, i));
                    }
                    return output.ToString();
                }
            }
        }
        #endregion

        #region FUNCTIONS
        // Single-pass analysis computing score and found keywords using HashSet lookups
        public static C_Analyze_Result F_Analyze(string p_cv_text, string p_keywords)
        {
            string[] cv_words = p_cv_text.Split(' ');
            string[] keywords = p_keywords.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var keyword_set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var original_keyword_map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (string key in keywords)
            {
                string clean_key = F_Clean_Word(key);
                if (!string.IsNullOrEmpty(clean_key))
                {
                    keyword_set.Add(clean_key);
                    if (!original_keyword_map.ContainsKey(clean_key))
                    {
                        original_keyword_map[clean_key] = key;
                    }
                }
            }

            int score = 0;
            var found_keywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (string word in cv_words)
            {
                string clean_word = F_Clean_Word(word).ToLowerInvariant();
                if (!string.IsNullOrEmpty(clean_word) && keyword_set.Contains(clean_word))
                {
                    score++;
                    found_keywords.Add(clean_word);
                }
            }

            var found_list = new List<string>();
            foreach (string found in found_keywords)
            {
                if (original_keyword_map.ContainsKey(found))
                {
                    found_list.Add(original_keyword_map[found]);
                }
            }

            return new C_Analyze_Result { Score = score, Found_Keywords = string.Join(" ", found_list) };
        }

        // Returns only the score from CV analysis
        public static int F_Get_Score(string p_cv_text, string p_keywords)
        {
            return F_Analyze(p_cv_text, p_keywords).Score;
        }

        // Returns only the found keywords from CV analysis
        public static string F_Get_Found_Keywords(string p_cv_text, string p_keywords)
        {
            return F_Analyze(p_cv_text, p_keywords).Found_Keywords;
        }

        // Returns keywords that were not found in any resume
        public static string F_Get_Not_Found_Keywords(string p_folder_path, List<string> p_resume_names, string p_keywords)
        {
            string[] keywords = p_keywords.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var all_keywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var original_map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (string key in keywords)
            {
                string clean = F_Clean_Word(key);
                if (!string.IsNullOrEmpty(clean))
                {
                    all_keywords.Add(clean);
                    if (!original_map.ContainsKey(clean)) { original_map[clean] = key; }
                }
            }

            var global_found = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (string resume_name in p_resume_names)
            {
                if (resume_name.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    string cv_text = F_Pdf_To_String(p_folder_path, resume_name);
                    var result = F_Analyze(cv_text, p_keywords);
                    foreach (string found in result.Found_Keywords.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        global_found.Add(F_Clean_Word(found));
                    }
                }
            }

            var not_found = new List<string>();
            foreach (string key in all_keywords)
            {
                if (!global_found.Contains(key) && original_map.ContainsKey(key))
                {
                    not_found.Add(original_map[key]);
                }
            }

            return string.Join(" ", not_found);
        }

        // Processes all resumes and stores results in data layer
        public static void F_Get_Result(string p_folder_path, List<string> p_resume_names, string p_keywords)
        {
            Backend.Resume.C_Query_Resume.F_Delete_Resumes();
            foreach (string resume_name in p_resume_names)
            {
                if (resume_name.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    string cv_text = F_Pdf_To_String(p_folder_path, resume_name);
                    var result = F_Analyze(cv_text, p_keywords);
                    Backend.Resume.C_Query_Resume.F_Insert_Resume(resume_name, result.Score, result.Found_Keywords);
                }
            }
        }
        #endregion
    }
    #endregion
}

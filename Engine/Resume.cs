using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region iTextSharp Library
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
#endregion

namespace CV_Analyser.Engine
{
    internal class Resume
    {
        #region Constants
        private static readonly HashSet<char> InvalidChars = new HashSet<char>(
            "\"*,<é!'^%&/()=?;>:£$½{[]}\\|@€₺¨~æß´`-_ ".ToCharArray());
        #endregion

        #region Result Class
        /// <summary>
        /// Holds the result of a single CV analysis pass.
        /// </summary>
        internal class AnalyzeResult
        {
            public int Score { get; set; }
            public string FoundKeywords { get; set; }
        }
        #endregion

        #region Helper Methods
        private static string CleanWord(string word)
        {
            var sb = new StringBuilder(word.Length);
            foreach (char c in word)
            {
                if (!InvalidChars.Contains(c)) { sb.Append(c); }
            }
            return sb.ToString();
        }

        public static string PDF_To_String(string Folder_Path, string PDF_Name)
        {
            using (var reader = new PdfReader(System.IO.Path.Combine(Folder_Path, PDF_Name)))
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

        #region Analysis Methods
        /// <summary>
        /// Single-pass analysis: computes score and found keywords in one iteration.
        /// Uses HashSet for O(1) keyword lookups instead of nested loops.
        /// </summary>
        public static AnalyzeResult Analyze(string CV_Text, string Keywords)
        {
            string[] cv_words = CV_Text.Split(' ');
            string[] keywords = Keywords.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Pre-clean keywords into a lookup set — O(m)
            var keywordSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var originalKeywordMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (string key in keywords)
            {
                string cleanKey = CleanWord(key);
                if (!string.IsNullOrEmpty(cleanKey))
                {
                    keywordSet.Add(cleanKey);
                    if (!originalKeywordMap.ContainsKey(cleanKey))
                    {
                        originalKeywordMap[cleanKey] = key;
                    }
                }
            }

            int score = 0;
            var foundKeywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Single pass through CV words — O(n) with O(1) lookups
            foreach (string word in cv_words)
            {
                string cleanWord = CleanWord(word).ToLowerInvariant();
                if (!string.IsNullOrEmpty(cleanWord) && keywordSet.Contains(cleanWord))
                {
                    score++;
                    foundKeywords.Add(cleanWord);
                }
            }

            // Build found keywords string using original keyword forms
            var foundList = new List<string>();
            foreach (string found in foundKeywords)
            {
                if (originalKeywordMap.ContainsKey(found))
                {
                    foundList.Add(originalKeywordMap[found]);
                }
            }

            return new AnalyzeResult { Score = score, FoundKeywords = string.Join(" ", foundList) };
        }

        // Backward-compatible wrappers
        public static int Get_Score(string CV_Text, string Keywords)
        {
            return Analyze(CV_Text, Keywords).Score;
        }

        public static string Get_Found_Keywords(string CV_Text, string Keywords)
        {
            return Analyze(CV_Text, Keywords).FoundKeywords;
        }
        #endregion

        #region Batch Processing
        public static string Get_Not_Found_Keywords(string Folder_Path, List<string> Resume_Names, string Keywords)
        {
            string[] keywords = Keywords.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Pre-clean all keywords
            var allKeywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var originalMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (string key in keywords)
            {
                string clean = CleanWord(key);
                if (!string.IsNullOrEmpty(clean))
                {
                    allKeywords.Add(clean);
                    if (!originalMap.ContainsKey(clean)) { originalMap[clean] = key; }
                }
            }

            // Collect all found keywords across all resumes
            var globalFound = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (string resume_name in Resume_Names)
            {
                if (resume_name.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    string cv_text = PDF_To_String(Folder_Path, resume_name);
                    var result = Analyze(cv_text, Keywords);
                    foreach (string found in result.FoundKeywords.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        globalFound.Add(CleanWord(found));
                    }
                }
            }

            // Set difference: all keywords minus found keywords
            var notFound = new List<string>();
            foreach (string key in allKeywords)
            {
                if (!globalFound.Contains(key) && originalMap.ContainsKey(key))
                {
                    notFound.Add(originalMap[key]);
                }
            }

            return string.Join(" ", notFound);
        }

        public static void Get_Result(string Folder_Path, List<string> Resume_Names, string Keywords)
        {
            Data.Query_Resume.Delete_Resumes();
            foreach (string resume_name in Resume_Names)
            {
                if (resume_name.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    string cv_text = PDF_To_String(Folder_Path, resume_name);

                    // Single-pass: get both score and found keywords at once
                    var result = Analyze(cv_text, Keywords);

                    Data.Query_Resume.Insert_Resume(resume_name, result.Score, result.FoundKeywords);
                }
            }
        }
        #endregion
    }
}

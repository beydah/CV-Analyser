using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

#region iTextSharp Library
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
#endregion

namespace CV_Analyser.Engine
{
    internal class Resume
    {
        public static string PDF_To_String(string Folder_Path, string PDF_Name)
        {
            using (var reader = new PdfReader(Folder_Path + "\\" + PDF_Name))
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

        public static int Get_Score(string CV_Text, string Keywords)
        {
            string[] cv_words = CV_Text.Split(' ');
            string[] keywords = Keywords.Split(' ');
            string wrong_chars = "\"*,<é!'^%&/()=?;>:£$½{[]}\\|@€₺¨~æß´`-_ ";

            int score = 0;
            foreach (string word in cv_words)
            {
                foreach (string key in keywords)
                {
                    string clean_word = "";
                    foreach (char c in word) { if (!wrong_chars.Contains(c)) { clean_word += c; } }

                    string clean_key = "";
                    foreach (char c in key) { if (!wrong_chars.Contains(c)) { clean_key += c; } }

                    if (clean_key != null || clean_key != "" || clean_key != " ")
                    { 
                        if (clean_word.ToLower().Equals(clean_key)) { score++; } 
                    }
                }
            }
            return score;
        }

        public static string Get_Found_Keywords(string CV_Text, string Keywords)
        {
            string[] cv_words = CV_Text.Split(' ');
            string[] keywords = Keywords.Split(' ');
            string wrong_chars = "\"*,<é!'^%&/()=?;>:£$½{[]}\\|@€₺¨~æß´`-_ ";

            string found_keywords = " ";
            foreach (string word in cv_words)
            {
                foreach (string key in keywords)
                {
                    string clean_word = "";
                    foreach (char c in word) { if (!wrong_chars.Contains(c)) { clean_word += c; } }

                    string clean_key = "";
                    foreach (char c in key) { if (!wrong_chars.Contains(c)) { clean_key += c; } }

                    if (clean_key != null || clean_key != "" || clean_key != " ")
                    {
                        if (clean_word.ToLower().Equals(clean_key) && !found_keywords.Contains(clean_key)) 
                        { 
                            found_keywords += key + " "; 
                        }
                    }
                }
            }
            return found_keywords;
        }

        public static string Get_Not_Found_Keywords(string Path, List<string> Resume_Names, string Keywords)
        {
            string not_found_keywords = Keywords;
            string wrong_chars = "\"*,<é!'^%&/()=?;>:£$½{[]}\\|@€₺¨~æß´`-_ ";

            foreach (string resume_name in Resume_Names)
            {
                if (resume_name.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    string cv_text = PDF_To_String(Path, resume_name);
                    string found_keywords = Get_Found_Keywords(cv_text, Keywords);

                    string[] not_found_keywords_arr = not_found_keywords.Split(' ');

                    HashSet<string> found_keywords_set = new HashSet<string>(found_keywords.Split(' '));
                    List<string> filtered_not_found_keywords = new List<string>();

                    foreach (string key in not_found_keywords_arr)
                    {
                        string clean_key = "";
                        foreach (char c in key) { if (!wrong_chars.Contains(c)) { clean_key += c; } }

                        if (!found_keywords_set.Contains(clean_key)) 
                        { 
                            filtered_not_found_keywords.Add(clean_key); 
                        }
                    }

                    not_found_keywords = string.Join(" ", filtered_not_found_keywords);
                }
            }
            return not_found_keywords;
        }

        public static void Get_Result(string Path, List<string> Resume_Names, string Keywords)
        {
            Data.Query_Resume.Delete_Resumes();
            foreach (string resume_name in Resume_Names)
            {
                if (resume_name.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    string cv_text = PDF_To_String(Path, resume_name);
                    int cv_score = Get_Score(cv_text, Keywords) - Get_Score(cv_text, "");
                    string found_keywords = Get_Found_Keywords(cv_text, Keywords);

                    Data.Query_Resume.Insert_Resume(resume_name, cv_score, found_keywords);
                }
            }
        }
    }
}
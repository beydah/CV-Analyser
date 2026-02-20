#region HEADER
// File: query_resume.cs
// Project: CV_Analyser
// Description: JSON-based data operations for resume records
#endregion

#region LIBRARIES
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
#endregion

namespace CV_Analyser.Backend.Resume
{
    #region CLASSES
    // Data model for a resume record
    public class C_Resume_Model
    {
        #region VARIABLES
        public string Name { get; set; }
        public int Score { get; set; }
        public string Keywords { get; set; }
        #endregion
    }

    // Handles CRUD operations for resume data stored in JSON
    internal class C_Query_Resume
    {
        #region VARIABLES
        private static string Resume_Db_Path = "resumes.json";
        #endregion

        #region UTILITIES
        // Loads all resumes from the JSON file
        private static List<C_Resume_Model> F_Load_Resumes()
        {
            if (!File.Exists(Resume_Db_Path)) return new List<C_Resume_Model>();
            var json = File.ReadAllText(Resume_Db_Path);
            return JsonConvert.DeserializeObject<List<C_Resume_Model>>(json) ?? new List<C_Resume_Model>();
        }

        // Persists all resumes to the JSON file
        private static void F_Save_Resumes(List<C_Resume_Model> p_resumes)
        {
            var json = JsonConvert.SerializeObject(p_resumes, Formatting.Indented);
            File.WriteAllText(Resume_Db_Path, json);
        }
        #endregion

        #region FUNCTIONS
        // Selects top resumes ordered by score descending
        public static DataTable F_Select_Resumes(int p_limit)
        {
            var resumes = F_Load_Resumes().OrderByDescending(r => r.Score).Take(p_limit).ToList();
            var table = new DataTable();
            table.Columns.Add("Que", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Score", typeof(int));
            table.Columns.Add("Keywords", typeof(string));
            for (int i = 0; i < resumes.Count; i++)
            {
                table.Rows.Add(i + 1, resumes[i].Name, resumes[i].Score, resumes[i].Keywords);
            }
            return table;
        }

        // Returns keywords for a specific resume by name
        public static string F_Select_Keywords(string p_name)
        {
            var resume = F_Load_Resumes().FirstOrDefault(r => r.Name == p_name);
            return resume?.Keywords ?? string.Empty;
        }

        // Returns total count of stored resumes
        public static int F_Select_Resume_Count()
        {
            return F_Load_Resumes().Count;
        }

        // Inserts a new resume record
        public static void F_Insert_Resume(string p_resume_name, int p_score, string p_keywords)
        {
            var resumes = F_Load_Resumes();
            resumes.Add(new C_Resume_Model { Name = p_resume_name, Score = p_score, Keywords = p_keywords });
            F_Save_Resumes(resumes);
        }

        // Deletes all resume records
        public static void F_Delete_Resumes()
        {
            F_Save_Resumes(new List<C_Resume_Model>());
        }
        #endregion
    }
    #endregion
}

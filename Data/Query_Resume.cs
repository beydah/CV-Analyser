using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace CV_Analyser.Data
{
    public class ResumeModel
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string Keywords { get; set; }
    }

    internal class Query_Resume
    {
        private static string ResumeDbPath = "resumes.json";

        private static List<ResumeModel> LoadResumes()
        {
            if (!File.Exists(ResumeDbPath)) return new List<ResumeModel>();
            var json = File.ReadAllText(ResumeDbPath);
            return JsonConvert.DeserializeObject<List<ResumeModel>>(json) ?? new List<ResumeModel>();
        }

        private static void SaveResumes(List<ResumeModel> resumes)
        {
            var json = JsonConvert.SerializeObject(resumes, Formatting.Indented);
            File.WriteAllText(ResumeDbPath, json);
        }

        public static DataTable Select_Resumes(int Limit)
        {
            var resumes = LoadResumes().OrderByDescending(r => r.Score).Take(Limit).ToList();
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

        public static string Select_Keywords(string Name)
        {
            var resume = LoadResumes().FirstOrDefault(r => r.Name == Name);
            return resume?.Keywords ?? string.Empty;
        }

        public static int Select_Resume_Count()
        {
            return LoadResumes().Count;
        }

        public static void Insert_Resume(string Resume_Name, int Score, string Keywords)
        {
            var resumes = LoadResumes();
            resumes.Add(new ResumeModel { Name = Resume_Name, Score = Score, Keywords = Keywords });
            SaveResumes(resumes);
        }

        public static void Delete_Resumes()
        {
            SaveResumes(new List<ResumeModel>());
        }
    }
}

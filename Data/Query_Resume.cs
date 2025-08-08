using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Analyser.Data
{
    internal class Query_Resume
    {
        #region Global Variables
        static string Connection_String = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\CV_Analyser\\Data\\Analyser_DB.mdf;Integrated Security=True";
        #endregion

        public static DataTable Select_Resumes(int Limit)
        {
            DataTable data_table = new DataTable();
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                string query =
                    "SELECT TOP (@Limit) ROW_NUMBER() OVER (ORDER BY Score DESC) AS Que, Name, Score, Keywords FROM Resume ORDER BY Score DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Limit", Limit);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data_table);
                    }
                }
                connection.Close();
            }
            return data_table;
        }

        public static string Select_Keywords(string Name)
        {
            string keywords = null;
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                string query = "SELECT Keywords FROM Resume WHERE Name = @Name";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read()) { keywords = reader["Keywords"].ToString(); }
                        }
                    }
                }
                connection.Close();
            }
            return keywords;
        }

        public static int Select_Resume_Count()
        {
            int cv_num = 0;
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Resume";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read()) { cv_num = Convert.ToInt32(reader[0]); }
                        }
                    }
                }
                connection.Close();
            }
            return cv_num;
        }

        public static void Insert_Resume(string Resume_Name, int Score, string Keywords)
        {
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                string query = "INSERT INTO Resume (Name, Score, Keywords) VALUES (@Resume_Name, @Score, @Keywords)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Resume_Name", Resume_Name);
                    command.Parameters.AddWithValue("@Score", Score);
                    command.Parameters.AddWithValue("@Keywords", Keywords);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static void Delete_Resumes()
        {
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                string query = "DELETE FROM Resume";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}

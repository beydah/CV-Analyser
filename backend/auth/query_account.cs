#region HEADER
// File: query_account.cs
// Project: CV_Analyser
// Description: Database operations for the Account table
#endregion

#region LIBRARIES
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace CV_Analyser.Backend.Auth
{
    #region CLASSES
    // Handles CRUD operations for user accounts in SQL Server LocalDB
    internal class C_Query_Account
    {
        #region VARIABLES
        static string Connection_String = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Analyser_DB.mdf")};Integrated Security=True";
        #endregion

        #region FUNCTIONS
        // Finds an account by username, mail, or phone with password verification
        public static int F_Select_Find_Account_Basic(string p_user_info, string p_password)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Account WHERE (Username = @User_Info OR Mail = @User_Info OR Phone = @User_Info) AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@User_Info", p_user_info);
                    command.Parameters.AddWithValue("@Password", p_password);

                    count = (int)command.ExecuteScalar();
                }
                connection.Close();
            }
            return count;
        }

        // Checks if an account exists by username, mail, or phone
        public static int F_Select_Find_Account(string p_username, string p_mail, string p_phone)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Account WHERE Username = @Username OR Mail = @Mail OR Phone = @Phone";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", p_username);
                    command.Parameters.AddWithValue("@Mail", p_mail);
                    command.Parameters.AddWithValue("@Phone", p_phone);
                    count = (int)command.ExecuteScalar();
                }
                connection.Close();
            }
            return count;
        }

        // Inserts a new account record
        public static void F_Insert_Account(string p_username, string p_mail, string p_phone, string p_password)
        {
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                string query = "INSERT INTO Account (Username, Mail, Phone, Password) VALUES (@Username, @Mail, @Phone, @Password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", p_username);
                    command.Parameters.AddWithValue("@Mail", p_mail);
                    command.Parameters.AddWithValue("@Phone", p_phone);
                    command.Parameters.AddWithValue("@Password", p_password);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        #endregion
    }
    #endregion
}

using CV_Analyser.Interface.Password;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CV_Analyser.Data
{
    internal class Query_Account
    {
        #region Global Variables
        static string Connection_String = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\CV_Analyser\\Data\\Analyser_DB.mdf;Integrated Security=True";
        #endregion

        #region Select Functions
        public static int Select_Find_Account_Basic(string User_Info, string Password)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Account WHERE Username = @User_Info OR Mail = @User_Info OR Phone = @User_Info AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@User_Info", User_Info);
                    command.Parameters.AddWithValue("@Password", Password);

                    count = (int)command.ExecuteScalar();
                }
                connection.Close();
            }
            return count;
        }

        public static int Select_Find_Account(string Username, string Mail, string Phone)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Account WHERE Username = @Username OR Mail = @Mail OR Phone = @Phone";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Mail", Mail);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    count = (int)command.ExecuteScalar();
                }
                connection.Close();
            }
            return count;
        }
        #endregion

        #region Insert Functions
        public static void Insert_Account(string Username, string Mail, string Phone, string Password)
        {
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                string query = "INSERT INTO Account (Username, Mail, Phone, Password) VALUES (@Username, @Mail, @Phone, @Password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", Username);
                    command.Parameters.AddWithValue("@Mail", Mail);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@password", Password);
                    int affectedRows = command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        #endregion
    }
}

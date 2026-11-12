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
        // Ensures the added hash field exists on databases created by earlier versions.
        private static void F_Ensure_Password_Hash_Column(SqlConnection p_connection)
        {
            const string query = @"
IF COL_LENGTH('dbo.Account', 'PasswordHash') IS NULL
    ALTER TABLE dbo.Account ADD PasswordHash NVARCHAR(MAX) NULL;";
            using (SqlCommand command = new SqlCommand(query, p_connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private static void F_Upgrade_Legacy_Password(
            SqlConnection p_connection, string p_username, string p_mail,
            string p_phone, string p_legacy_password, string p_password_hash)
        {
            const string query = @"
UPDATE dbo.Account
SET PasswordHash = @PasswordHash, Password = ''
WHERE Username = @Username AND Mail = @Mail AND Phone = @Phone
  AND PasswordHash IS NULL AND Password = @LegacyPassword;";
            using (SqlCommand command = new SqlCommand(query, p_connection))
            {
                command.Parameters.AddWithValue("@PasswordHash", p_password_hash);
                command.Parameters.AddWithValue("@Username", p_username);
                command.Parameters.AddWithValue("@Mail", p_mail);
                command.Parameters.AddWithValue("@Phone", p_phone);
                command.Parameters.AddWithValue("@LegacyPassword", p_legacy_password);
                command.ExecuteNonQuery();
            }
        }

        // Finds an account and upgrades a matching legacy plaintext password on successful login.
        public static int F_Select_Find_Account_Basic(string p_user_info, string p_password)
        {
            if (string.IsNullOrEmpty(p_password)) return 0;

            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                connection.Open();
                F_Ensure_Password_Hash_Column(connection);
                const string query = @"
SELECT Username, Mail, Phone, Password, PasswordHash
FROM dbo.Account
WHERE Username = @User_Info OR Mail = @User_Info OR Phone = @User_Info;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@User_Info", p_user_info);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string password_hash = reader["PasswordHash"] == DBNull.Value
                                ? null : Convert.ToString(reader["PasswordHash"]);
                            if (!string.IsNullOrEmpty(password_hash))
                            {
                                if (C_Password_Hasher.F_Verify(p_password, password_hash)) return 1;
                                continue;
                            }

                            string legacy_password = reader["Password"] == DBNull.Value
                                ? null : Convert.ToString(reader["Password"]);
                            if (!string.Equals(legacy_password, p_password, StringComparison.Ordinal)) continue;

                            string username = Convert.ToString(reader["Username"]);
                            string mail = Convert.ToString(reader["Mail"]);
                            string phone = Convert.ToString(reader["Phone"]);
                            reader.Close();
                            string upgraded_hash = C_Password_Hasher.F_Hash(p_password);
                            F_Upgrade_Legacy_Password(connection, username, mail, phone,
                                legacy_password, upgraded_hash);
                            return 1;
                        }
                    }
                }
            }
            return 0;
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
                F_Ensure_Password_Hash_Column(connection);
                string query = @"INSERT INTO dbo.Account (Username, Mail, Phone, Password, PasswordHash)
VALUES (@Username, @Mail, @Phone, @Password, @PasswordHash);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", p_username);
                    command.Parameters.AddWithValue("@Mail", p_mail);
                    command.Parameters.AddWithValue("@Phone", p_phone);
                    command.Parameters.AddWithValue("@Password", string.Empty);
                    command.Parameters.AddWithValue("@PasswordHash", C_Password_Hasher.F_Hash(p_password));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        #endregion
    }
    #endregion
}

#region HEADER
// File: password_hasher.cs
// Project: CV_Analyser
// Description: Salted PBKDF2 password hashing for account credentials
#endregion

#region LIBRARIES
using System;
using System.Security.Cryptography;
#endregion

namespace CV_Analyser.Backend.Auth
{
    internal static class C_Password_Hasher
    {
        private const int Iterations = 600000;
        private const int Salt_Size = 16;
        private const int Hash_Size = 32;
        private const string Algorithm = "pbkdf2-sha256";

        public static string F_Hash(string p_password)
        {
            if (string.IsNullOrEmpty(p_password))
            {
                throw new ArgumentException("Password cannot be empty", "p_password");
            }

            byte[] salt = new byte[Salt_Size];
            using (RandomNumberGenerator generator = RandomNumberGenerator.Create())
            {
                generator.GetBytes(salt);
            }

            byte[] hash;
            using (Rfc2898DeriveBytes derive = new Rfc2898DeriveBytes(
                p_password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                hash = derive.GetBytes(Hash_Size);
            }

            return string.Join("$", Algorithm, Iterations.ToString(),
                Convert.ToBase64String(salt), Convert.ToBase64String(hash));
        }

        public static bool F_Verify(string p_password, string p_encoded_hash)
        {
            if (string.IsNullOrEmpty(p_password) || string.IsNullOrEmpty(p_encoded_hash))
            {
                return false;
            }

            string[] parts = p_encoded_hash.Split('$');
            int iterations;
            byte[] salt;
            byte[] expected_hash;
            if (parts.Length != 4 || parts[0] != Algorithm ||
                !int.TryParse(parts[1], out iterations) || iterations != Iterations)
            {
                return false;
            }

            try
            {
                salt = Convert.FromBase64String(parts[2]);
                expected_hash = Convert.FromBase64String(parts[3]);
            }
            catch (FormatException)
            {
                return false;
            }

            if (salt.Length != Salt_Size || expected_hash.Length != Hash_Size)
            {
                return false;
            }

            byte[] actual_hash;
            using (Rfc2898DeriveBytes derive = new Rfc2898DeriveBytes(
                p_password, salt, iterations, HashAlgorithmName.SHA256))
            {
                actual_hash = derive.GetBytes(Hash_Size);
            }

            int difference = 0;
            for (int i = 0; i < expected_hash.Length; i++)
            {
                difference |= expected_hash[i] ^ actual_hash[i];
            }
            return difference == 0;
        }
    }
}

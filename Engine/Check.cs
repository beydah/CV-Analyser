using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CV_Analyser.Engine
{
    /// <summary>
    /// Centralized input validation methods.
    /// </summary>
    internal static class Check
    {
        /// <summary>
        /// Validates email format using a standard regex pattern.
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Validates phone number: must contain at least 10 digits.
        /// </summary>
        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            int digitCount = phone.Count(c => char.IsDigit(c));
            return digitCount >= 10;
        }

        /// <summary>
        /// Validates password: minimum 5 characters, at least one letter and one digit.
        /// </summary>
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 5) return false;
            return password.Any(char.IsLetter) && password.Any(char.IsDigit);
        }

        /// <summary>
        /// Validates username: minimum 4 characters, only letters, digits, underscores, and dots.
        /// </summary>
        public static bool IsValidUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 4) return false;
            return Regex.IsMatch(username, @"^[a-zA-Z0-9_.]+$");
        }
    }
}

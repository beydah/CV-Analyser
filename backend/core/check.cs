#region HEADER
// File: check.cs
// Project: CV_Analyser
// Description: Centralized input validation methods
#endregion

#region LIBRARIES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
#endregion

namespace CV_Analyser.Backend.Core
{
    #region CLASSES
    // Provides reusable validation for user inputs
    internal static class C_Check
    {
        #region FUNCTIONS
        // Validates email format using a standard regex
        public static bool F_Is_Valid_Email(string p_email)
        {
            if (string.IsNullOrWhiteSpace(p_email)) return false;
            return Regex.IsMatch(p_email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
        }

        // Validates phone number contains at least 10 digits
        public static bool F_Is_Valid_Phone(string p_phone)
        {
            if (string.IsNullOrWhiteSpace(p_phone)) return false;
            int digit_count = p_phone.Count(c => char.IsDigit(c));
            return digit_count >= 10;
        }

        // Validates password has minimum 5 chars with at least one letter and one digit
        public static bool F_Is_Valid_Password(string p_password)
        {
            if (string.IsNullOrWhiteSpace(p_password) || p_password.Length < 5) return false;
            return p_password.Any(char.IsLetter) && p_password.Any(char.IsDigit);
        }

        // Validates username has minimum 4 chars with only alphanumeric, underscore, dot
        public static bool F_Is_Valid_Username(string p_username)
        {
            if (string.IsNullOrWhiteSpace(p_username) || p_username.Length < 4) return false;
            return Regex.IsMatch(p_username, @"^[a-zA-Z0-9_.]+$");
        }
        #endregion
    }
    #endregion
}

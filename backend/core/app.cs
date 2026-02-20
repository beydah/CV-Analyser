#region HEADER
// File: app.cs
// Project: CV_Analyser
// Description: Application-level utility functions and centralized error handling
#endregion

#region LIBRARIES
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
#endregion

namespace CV_Analyser.Backend.Core
{
    #region CONSTANTS
    // Application-level constants
    internal static class C_Constants
    {
        public static readonly string APP_NAME = ConfigurationManager.AppSettings["AppName"] ?? "CV Analyser";
        public static readonly string APP_VERSION = ConfigurationManager.AppSettings["AppVersion"] ?? "1.0.0";
        public static readonly bool ENABLE_LOGGING = bool.TryParse(ConfigurationManager.AppSettings["EnableLogging"], out bool v) && v;
        public static readonly string LOG_DIRECTORY = ConfigurationManager.AppSettings["LogDirectory"] ?? "logs";
    }
    #endregion

    #region CLASSES
    // Application utility class with error handling and browser launch
    internal class C_App
    {
        #region FUNCTIONS
        // Opens a URL in the default system browser securely
        public static void F_Browser_Start(string p_url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(p_url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                F_Log_Error("F_Browser_Start", ex);
                F_Show_Error("Could not open the link. Please try again.");
            }
        }

        // Displays a user-friendly error message dialog
        public static void F_Show_Error(string p_message)
        {
            MessageBox.Show(
                p_message,
                C_Constants.APP_NAME + " — Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        // Displays a user-friendly information message dialog
        public static void F_Show_Info(string p_message)
        {
            MessageBox.Show(
                p_message,
                C_Constants.APP_NAME,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Logs an error to the log file with timestamp and method context
        public static void F_Log_Error(string p_method, Exception p_exception)
        {
            if (!C_Constants.ENABLE_LOGGING) return;

            try
            {
                string base_path = AppDomain.CurrentDomain.BaseDirectory;
                string log_dir = System.IO.Path.Combine(base_path, C_Constants.LOG_DIRECTORY);
                Directory.CreateDirectory(log_dir);

                string log_file = System.IO.Path.Combine(log_dir, $"error_{DateTime.Now:yyyy-MM-dd}.log");
                string log_entry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{p_method}] {p_exception.Message}{Environment.NewLine}{p_exception.StackTrace}{Environment.NewLine}";

                File.AppendAllText(log_file, log_entry);
            }
            catch
            {
                // Logging should never crash the application
            }
        }

        // Logs an informational message to the log file
        public static void F_Log_Info(string p_method, string p_message)
        {
            if (!C_Constants.ENABLE_LOGGING) return;

            try
            {
                string base_path = AppDomain.CurrentDomain.BaseDirectory;
                string log_dir = System.IO.Path.Combine(base_path, C_Constants.LOG_DIRECTORY);
                Directory.CreateDirectory(log_dir);

                string log_file = System.IO.Path.Combine(log_dir, $"info_{DateTime.Now:yyyy-MM-dd}.log");
                string log_entry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{p_method}] {p_message}{Environment.NewLine}";

                File.AppendAllText(log_file, log_entry);
            }
            catch
            {
                // Logging should never crash the application
            }
        }
        #endregion
    }
    #endregion
}

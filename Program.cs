#region HEADER
// File: Program.cs
// Project: CV_Analyser
// Description: Application entry point
#endregion

#region LIBRARIES
using System;
using System.Windows.Forms;
#endregion

namespace CV_Analyser
{
    #region CLASSES
    // Application entry point class
    internal static class C_Program
    {
        #region FUNCTIONS
        // Main entry point for the application
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frontend.Pages.C_Analyser());
        }
        #endregion
    }
    #endregion
}

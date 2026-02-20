#region HEADER
// File: app.cs
// Project: CV_Analyser
// Description: Application-level utility functions
#endregion

#region LIBRARIES
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace CV_Analyser.Backend.Core
{
    #region CLASSES
    // Application utility class
    internal class C_App
    {
        #region FUNCTIONS
        // Opens a URL in the default system browser securely
        public static void F_Browser_Start(string p_url)
        {
            Process.Start(new ProcessStartInfo(p_url) { UseShellExecute = true });
        }
        #endregion
    }
    #endregion
}

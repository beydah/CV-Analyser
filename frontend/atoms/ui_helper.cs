#region HEADER
// File: ui_helper.cs
// Project: CV_Analyser
// Description: Reusable atomic UI helper methods for common form interactions
#endregion

#region LIBRARIES
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
#endregion

namespace CV_Analyser.Frontend.Atoms
{
    #region CLASSES
    // Provides reusable UI interaction patterns shared across forms
    internal static class C_Ui_Helper
    {
        #region FUNCTIONS
        // Toggles password visibility on a textbox and updates the eye icon
        public static bool F_Toggle_Password_Visibility(TextBox p_text_box, PictureBox p_picture_box, bool p_is_active)
        {
            string base_path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Asset", "Icon");

            if (p_is_active)
            {
                p_text_box.PasswordChar = '*';
                p_picture_box.Image = Image.FromFile(System.IO.Path.Combine(base_path, "eye_black_passive.png"));
                return false;
            }
            else
            {
                p_text_box.PasswordChar = '\0';
                p_picture_box.Image = Image.FromFile(System.IO.Path.Combine(base_path, "eye_black_active.png"));
                return true;
            }
        }
        #endregion
    }
    #endregion
}

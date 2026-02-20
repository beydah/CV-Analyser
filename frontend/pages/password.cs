#region HEADER
// File: password.cs
// Project: CV_Analyser
// Description: Password reset form with verification flow
#endregion

#region LIBRARIES
using CV_Analyser.Frontend.Atoms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace CV_Analyser.Frontend.Pages
{
    #region CLASSES
    // Password reset form with multi-step verification workflow
    public partial class C_Password : Form
    {
        #region VARIABLES
        bool Eye1_Active = false;
        bool Eye2_Active = false;
        #endregion

        #region FUNCTIONS
        // Initializes the password reset form
        public C_Password()
        {
            InitializeComponent();
        }

        // Hides verification and password sections on initial load
        private void F_Password_Load(object p_sender, EventArgs p_e)
        {
            groupBox_Verification_Code.Visible = false;
            groupBox_Password.Visible = false;
            groupBox_Password_Again.Visible = false;
            tableLayoutPanel_Change.Visible = false;
        }

        // Navigates back to login form
        private void F_Picture_Box_Back_Click(object p_sender, EventArgs p_e)
        {
            C_Entry entry = new C_Entry();
            entry.FormClosed += (s, args) => this.Close();
            this.Hide();
            entry.Show();
        }

        // Validates and highlights email/phone field on text change
        private void F_Text_Box_Mail_Phone_Text_Changed(object p_sender, EventArgs p_e)
        {
            var text_box = textBox_Mail_Phone;
            if (text_box.TextLength < 9) { text_box.BackColor = Color.MistyRose; }
            else { text_box.BackColor = Color.Honeydew; }
        }

        // Checks if the email/phone field is empty
        private bool F_Mail_Phone_Is_Null()
        {
            if (textBox_Mail_Phone.TextLength < 9)
            {
                MessageBox.Show
                        ("Mail / Phone cannot be left empty\n", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        // Sends verification code after checking if user exists
        private void F_Button_Send_Code_Click(object p_sender, EventArgs p_e)
        {
            if (!F_Mail_Phone_Is_Null())
            {
                string user_info = textBox_Mail_Phone.Text;
                if (Backend.Auth.C_Query_Account.F_Select_Find_Account(user_info, user_info, user_info) == 0)
                {
                    MessageBox.Show
                        ("No such user found", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    groupBox_Verification_Code.Visible = true;
                }
            }
        }

        // Shows password fields after verification code is entered
        private void F_Button_Verification_Code_Click(object p_sender, EventArgs p_e)
        {
            groupBox_Password.Visible = true;
            groupBox_Password_Again.Visible = true;
            tableLayoutPanel_Change.Visible = true;
        }

        // Toggles password visibility for the main password field
        private void F_Picture_Box_Eye_Click(object p_sender, EventArgs p_e)
        {
            Eye1_Active = C_Ui_Helper.F_Toggle_Password_Visibility(textBox_Password, pictureBox_Eye, Eye1_Active);
        }

        // Toggles password visibility for the confirmation field
        private void F_Picture_Box_Eye_Again_Click(object p_sender, EventArgs p_e)
        {
            Eye2_Active = C_Ui_Helper.F_Toggle_Password_Visibility(textBox_Password_Again, pictureBox_Eye_Again, Eye2_Active);
        }
        #endregion
    }
    #endregion
}

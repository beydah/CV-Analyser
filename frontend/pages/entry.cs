#region HEADER
// File: entry.cs
// Project: CV_Analyser
// Description: Login form handling user authentication
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
    // Login form for user authentication
    public partial class C_Entry : Form
    {
        #region VARIABLES
        bool Eye_Active = false;
        #endregion

        #region FUNCTIONS
        // Initializes the login form
        public C_Entry()
        {
            InitializeComponent();
        }

        // Highlights username field on text change
        private void F_Text_Box_Username_Mail_Phone_Text_Changed(object p_sender, EventArgs p_e)
        {
            textBox_Username_Mail_Phone.BackColor = Color.White;
        }

        // Highlights password field on text change
        private void F_Text_Box_Password_Text_Changed(object p_sender, EventArgs p_e)
        {
            textBox_Password.BackColor = Color.White;
        }

        // Toggles password visibility using shared atom helper
        private void F_Picture_Box_Eye_Click(object p_sender, EventArgs p_e)
        {
            Eye_Active = C_Ui_Helper.F_Toggle_Password_Visibility(textBox_Password, pictureBox_Eye, Eye_Active);
        }

        // Checks if required login fields are empty
        private bool F_Textbox_Is_Null()
        {
            string warning_message = "";
            if (textBox_Username_Mail_Phone.Text == "" || textBox_Password.Text == "")
            {
                if (textBox_Username_Mail_Phone.Text == "" || textBox_Username_Mail_Phone.Text == null)
                {
                    warning_message += "Username / Mail / Phone cannot be left empty\n";
                }
                if (textBox_Password.Text == "" || textBox_Password.Text == null)
                {
                    warning_message += "Password cannot be left empty\n";
                }
                MessageBox.Show
                        (warning_message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        // Handles login button click with credential verification
        private void F_Button_Sign_Click(object p_sender, EventArgs p_e)
        {
            if (!F_Textbox_Is_Null())
            {
                if (Backend.Auth.C_Query_Account.F_Select_Find_Account_Basic(textBox_Username_Mail_Phone.Text, textBox_Password.Text) > 0)
                {
                    C_Analyser analyser = new C_Analyser();
                    analyser.FormClosed += (s, args) => this.Close();
                    this.Hide();
                    analyser.Show();
                }
                else
                {
                    MessageBox.Show
                        ("Username or Password is wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Username_Mail_Phone.BackColor = Color.MistyRose;
                    textBox_Password.BackColor = Color.MistyRose;
                }
            }
        }

        // Navigates to account creation form
        private void F_Button_Create_Click(object p_sender, EventArgs p_e)
        {
            C_Account account = new C_Account();
            account.FormClosed += (s, args) => this.Close();
            this.Hide();
            account.Show();
        }

        // Navigates to password reset form
        private void F_Link_Label_Password_Link_Clicked(object p_sender, LinkLabelLinkClickedEventArgs p_e)
        {
            C_Password password = new C_Password();
            password.FormClosed += (s, args) => this.Close();
            this.Hide();
            password.Show();
        }
        #endregion
    }
    #endregion
}

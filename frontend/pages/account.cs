#region HEADER
// File: account.cs
// Project: CV_Analyser
// Description: Account registration form with input validation
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace CV_Analyser.Frontend.Pages
{
    #region CLASSES
    // Registration form for creating new user accounts
    public partial class C_Account : Form
    {
        #region VARIABLES
        bool Eye1_Active = false;
        bool Eye2_Active = false;
        #endregion

        #region FUNCTIONS
        // Initializes the registration form
        public C_Account()
        {
            InitializeComponent();
        }

        // Validates all input fields and enables create button
        private void F_Text_Control()
        {
            if
                (
                    textBox_Mail.TextLength > 3 &&
                    textBox_Username.TextLength > 3 &&
                    textBox_Password.TextLength > 4 &&
                    textBox_Password_Again.TextLength > 4 &&
                    textBox_Password.Text == textBox_Password_Again.Text &&
                    textBox_Mail.Text.Contains("@")
                )
            {
                button_Create.Enabled = true;
            }
            else { button_Create.Enabled = false; }
        }

        // Navigates back to login form
        private void F_Picture_Box_Back_Click(object p_sender, EventArgs p_e)
        {
            C_Entry entry = new C_Entry();
            entry.FormClosed += (s, args) => this.Close();
            this.Hide();
            entry.Show();
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

        // Validates and highlights email field on text change
        private void F_Text_Box_Mail_Text_Changed(object p_sender, EventArgs p_e)
        {
            if (textBox_Mail.TextLength < 9 || !textBox_Mail.Text.Contains("@")) { textBox_Mail.BackColor = Color.MistyRose; }
            else { textBox_Mail.BackColor = Color.Honeydew; }
        }

        // Validates and highlights phone field on text change
        private void F_Masked_Text_Box_Phone_Text_Changed(object p_sender, EventArgs p_e)
        {
            int num_length = 0;
            foreach (char c in maskedTextBox_Phone.Text) { if (char.IsDigit(c)) { num_length++; }}

            if (num_length == 0) { maskedTextBox_Phone.BackColor = Color.White; }
            else if (num_length > 0 && num_length < 10) { maskedTextBox_Phone.BackColor = Color.MistyRose; }
            else { maskedTextBox_Phone.BackColor = Color.Honeydew; }
        }

        // Validates username and strips invalid characters on text change
        private void F_Text_Box_Username_Text_Changed(object p_sender, EventArgs p_e)
        {
            if (textBox_Username.Text != null || textBox_Username.Text != "")
            {
                string text = textBox_Username.Text;
                string wrong_chars = "\"*-,<é!'^%&/()=?;>:£$½{[]}\\|@€₺¨~æß´`.#+";
                if (text.Any(c => wrong_chars.Contains(c)))
                {
                    textBox_Username.Text = text.Substring(0, text.Length - 1);
                    textBox_Username.SelectionStart = textBox_Username.Text.Length;
                }
            }
            if (textBox_Username.TextLength < 3) { textBox_Username.BackColor = Color.MistyRose; }
            else { textBox_Username.BackColor = Color.Honeydew; }
        }

        // Validates and highlights password field on text change
        private void F_Text_Box_Password_Text_Changed(object p_sender, EventArgs p_e)
        {
            if (textBox_Password.TextLength < 4) { textBox_Password.BackColor = Color.MistyRose; }
            else { textBox_Password.BackColor = Color.Honeydew; }
        }

        // Validates password confirmation field on text change
        private void F_Text_Box_Password_Again_Text_Changed(object p_sender, EventArgs p_e)
        {
            if (textBox_Password.Text != textBox_Password.Text || textBox_Password.TextLength < 4) { textBox_Password.BackColor = Color.MistyRose; }
            else { textBox_Password.BackColor = Color.Honeydew; }
        }

        // Checks if required registration fields are empty or invalid
        private bool F_Textbox_Is_Null()
        {
            string warning_message = "";
            if (textBox_Mail.TextLength < 9 || textBox_Username.TextLength < 3 ||
                textBox_Password.TextLength < 4 || textBox_Password_Again.TextLength < 4)
            {
                if (textBox_Mail.TextLength < 9)
                {
                    warning_message += "Mail cannot be left empty\n";
                }

                int num_length = 0;
                foreach (char c in maskedTextBox_Phone.Text) { if (char.IsDigit(c)) { num_length++; } }
                if (num_length > 0 && num_length < 10)
                {
                    warning_message += "Phone number should not be missing\n";
                }

                if (textBox_Username.TextLength < 4)
                {
                    warning_message += "Username cannot be left empty\n";
                }

                if (textBox_Password.TextLength < 4)
                {
                    warning_message += "Password cannot be left empty\n";
                }

                MessageBox.Show
                        (warning_message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        // Checks if both password fields match
        private bool F_Password_Is_Same()
        {
            if (textBox_Password.Text != textBox_Password_Again.Text)
            {
                MessageBox.Show
                    ("Passwords is not same", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Handles account creation with validation and duplicate check
        private void F_Button_Create_Click(object p_sender, EventArgs p_e)
        {
            string username = textBox_Username.Text;
            string mail = textBox_Mail.Text;
            string phone = Regex.Replace(maskedTextBox_Phone.Text, @"\D", "");
            string password = textBox_Password.Text;

            if (!F_Textbox_Is_Null())
            {
                if (F_Password_Is_Same())
                {
                    if (Backend.Auth.C_Query_Account.F_Select_Find_Account(username, mail, phone) > 0)
                    {
                        MessageBox.Show
                            ("This user already exists", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Backend.Auth.C_Query_Account.F_Insert_Account(textBox_Username.Text, textBox_Mail.Text, maskedTextBox_Phone.Text, textBox_Password.Text);
                        MessageBox.Show
                            ("Your User Registration has been Created", "Successful",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        C_Entry entry = new C_Entry();
                        entry.FormClosed += (s, args) => this.Close();
                        this.Hide();
                        entry.Show();
                    }
                }
            }
        }
        #endregion
    }
    #endregion
}

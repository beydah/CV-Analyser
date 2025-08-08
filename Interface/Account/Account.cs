using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Analyser.Interface.Account
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        #region Global Variables
        bool Eye1_Active = false;
        bool Eye2_Active = false;
        #endregion

        #region Global Functions
        private void Text_Control()
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
        #endregion

        #region Back Function
        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            Entry.Entry entry = new Entry.Entry();
            entry.FormClosed += (s, args) => this.Close();
            this.Hide();
            entry.Show();
        }
        #endregion

        #region Password Functions
        private void pictureBox_Eye_Click(object sender, EventArgs e)
        {
            if (Eye1_Active)
            {
                textBox_Password.PasswordChar = '*';
                pictureBox_Eye.Image = Image.FromFile("F:\\CV_Analyser\\Asset\\Icon\\eye_black_passive.png");
                Eye1_Active = false;
            }
            else
            {
                textBox_Password.PasswordChar = '\0';
                pictureBox_Eye.Image = Image.FromFile("F:\\CV_Analyser\\Asset\\Icon\\eye_black_active.png");
                Eye1_Active = true;
            }
        }

        private void pictureBox_Eye_Again_Click(object sender, EventArgs e)
        {
            if (Eye2_Active)
            {
                textBox_Password_Again.PasswordChar = '*';
                pictureBox_Eye.Image = Image.FromFile("F:\\CV_Analyser\\Asset\\Icon\\eye_black_passive.png");
                Eye2_Active = false;
            }
            else
            {
                textBox_Password_Again.PasswordChar = '\0';
                pictureBox_Eye_Again.Image = Image.FromFile("F:\\CV_Analyser\\Asset\\Icon\\eye_black_active.png");
                Eye2_Active = true;
            }
        }
        #endregion

        #region Text Changed Functions
        private void textBox_Mail_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Mail.TextLength < 9 || !textBox_Mail.Text.Contains("@")) { textBox_Mail.BackColor = Color.MistyRose; }
            else { textBox_Mail.BackColor = Color.Honeydew; }
        }

        private void maskedTextBox_Phone_TextChanged(object sender, EventArgs e)
        {
            int num_length = 0;
            foreach (char c in maskedTextBox_Phone.Text) { if (char.IsDigit(c)) { num_length++; }}

            if (num_length == 0) { maskedTextBox_Phone.BackColor = Color.White; }
            else if (num_length > 0 && num_length < 10) { maskedTextBox_Phone.BackColor = Color.MistyRose; }
            else { maskedTextBox_Phone.BackColor = Color.Honeydew; }
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
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

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Password.TextLength < 4) { textBox_Password.BackColor = Color.MistyRose; }
            else { textBox_Password.BackColor = Color.Honeydew; }
        }

        private void textBox_Password_Again_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Password.Text != textBox_Password.Text || textBox_Password.TextLength < 4) { textBox_Password.BackColor = Color.MistyRose; }
            else { textBox_Password.BackColor = Color.Honeydew; }
        }
        #endregion

        #region Button Functions
        private bool Textbox_Is_Null()
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

        private bool Password_Is_Same()
        {
            if (textBox_Password.Text != textBox_Password_Again.Text)
            {
                MessageBox.Show
                    ("Passwords is not same", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string mail = textBox_Mail.Text;
            string phone = Regex.Replace(maskedTextBox_Phone.Text, @"\D", "");
            string password = textBox_Password.Text;

            if (!Textbox_Is_Null())
            {
                if (Password_Is_Same())
                {
                    if(Data.Query_Account.Select_Find_Account(username, mail, phone) > 0)
                    {
                        MessageBox.Show
                            ("Böyle bir kullanıcı zaten var", "Hata",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        Data.Query_Account.Insert_Account(textBox_Username.Text, textBox_Mail.Text, maskedTextBox_Phone.Text, textBox_Password.Text);
                        MessageBox.Show
                            ("Your User Registration has been Created", "Successful",
                             MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Entry.Entry entry = new Entry.Entry();
                        entry.FormClosed += (s, args) => this.Close();
                        this.Hide();
                        entry.Show();
                    }
                }
            }

        }

        #endregion

    }
}

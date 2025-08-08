using CV_Analyser.Interface.Password;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Analyser.Interface.Entry
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        #region Global Variables
        bool Eye_Active = false;
        #endregion

        #region Text Box Functions
        private void textBox_Username_Mail_Phone_TextChanged(object sender, EventArgs e)
        {
            textBox_Username_Mail_Phone.BackColor = Color.White;
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            textBox_Password.BackColor = Color.White;
        }
        #endregion

        #region Password Show Function
        private void pictureBox_Eye_Click(object sender, EventArgs e)
        {
            if (Eye_Active)
            {
                textBox_Password.PasswordChar = '*';
                pictureBox_Eye.Image = Image.FromFile("F:\\CV_Analyser\\Asset\\Icon\\eye_black_passive.png");
                Eye_Active = false;
            }
            else
            {
                textBox_Password.PasswordChar = '\0';
                pictureBox_Eye.Image = Image.FromFile("F:\\CV_Analyser\\Asset\\Icon\\eye_black_active.png");
                Eye_Active = true;
            }
        }
        #endregion

        #region Main Button Functions
        private bool Textbox_Is_Null()
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

        private void button_Sign_Click(object sender, EventArgs e)
        {
            if (!Textbox_Is_Null())
            {
                if (Data.Query_Account.Select_Find_Account_Basic(textBox_Username_Mail_Phone.Text, textBox_Password.Text) > 0)
                {
                    Analyser.Analyser analyser = new Analyser.Analyser();
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
        #endregion

        #region Other Button Functions
        private void button_Create_Click(object sender, EventArgs e)
        {
            Account.Account account = new Account.Account();
            account.FormClosed += (s, args) => this.Close();
            this.Hide();
            account.Show();
        }

        private void linkLabel_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password.Password password = new Password.Password();
            password.FormClosed += (s, args) => this.Close();
            this.Hide();
            password.Show();
        }
        #endregion
    }
}

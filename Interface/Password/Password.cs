using CV_Analyser.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CV_Analyser.Interface.Password
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        #region Global Variables
        bool Eye1_Active = false;
        bool Eye2_Active = false;
        #endregion


        #region Page Functions
        private void Password_Load(object sender, EventArgs e)
        {
            groupBox_Verification_Code.Visible = false;
            groupBox_Password.Visible = false;
            groupBox_Password_Again.Visible = false;
            tableLayoutPanel_Change.Visible = false;
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            Entry.Entry entry = new Entry.Entry();
            entry.FormClosed += (s, args) => this.Close();
            this.Hide();
            entry.Show();
        }
        #endregion

        private void textBox_Mail_Phone_TextChanged(object sender, EventArgs e)
        {
            var text_box = textBox_Mail_Phone;
            if (text_box.TextLength < 9) { text_box.BackColor = Color.MistyRose; }
            else { text_box.BackColor = Color.Honeydew; }
        }

        private bool Mail_Phone_Is_Null()
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

        private void button_Send_Code_Click(object sender, EventArgs e)
        {
            if (!Mail_Phone_Is_Null())
            {
                string user_info = textBox_Mail_Phone.Text;
                if (Data.Query_Account.Select_Find_Account(user_info, user_info, user_info) == 0)
                {
                    MessageBox.Show
                        ("Böyle bir kullanıcı yok", "Hata",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    groupBox_Verification_Code.Visible = true;
                }
            }
        }

        private void button_Verification_Code_Click(object sender, EventArgs e)
        {
            groupBox_Password.Visible = true;
            groupBox_Password_Again.Visible = true;
            tableLayoutPanel_Change.Visible = true;
        }

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


    }
}

#region Default Namespace
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

#region Application Namespace
using CV_Analyser.Data;
using CV_Analyser.Engine;
using iTextSharp.text.pdf.parser;
#endregion

namespace CV_Analyser.Interface.Analyser
{
    public partial class Analyser : Form
    {
        public Analyser()
        {
            InitializeComponent();
        }

        #region Global Variables
        string Core_Path;
        List<string> Resume_Names = new List<string>();
        DataTable Data_Table;
        DataTable No_Keywords_Table;
        #endregion

        #region Global Functions
        private int Resume_Limit()
        {
            int limit = trackBar_CV_Rank.Value;
            if (limit < 1) { limit = 5; }
            else { limit *= 10; }
            return limit;
        }

        private void Save_Result()
        {
            if (folderBrowserDialog_Open.ShowDialog() == DialogResult.OK)
            {
                string save_path = folderBrowserDialog_Open.SelectedPath;
                string full_path = System.IO.Path.Combine(save_path, textBox_Folder_Name.Text);

                try { Directory.CreateDirectory(full_path); }
                catch (Exception ex)
                {
                    MessageBox.Show
                        ("Could not create folder: " + ex.Message, "Warning",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                int limit = Resume_Limit();
                for (int i = 0; i < limit; i++)
                {
                    string cv_name = dataGridView_Resumes.Rows[i].Cells["Name"].Value.ToString();
                    string cv_path = Core_Path + "\\" + cv_name;

                    string new_cv_name = (i + 1).ToString() + "_" + cv_name;
                    string target_path = System.IO.Path.Combine(full_path, new_cv_name);

                    if (!File.Exists(target_path)) { File.Copy(cv_path, target_path); }

                }

                MessageBox.Show
                    ("CVs Saved Successfully.", "Successfully",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Form Functions
        private void Analyser_Load(object sender, EventArgs e)
        {
            Form_Clear(sender, e);
        }

        private void Form_Clear(object sender, EventArgs e)
        {
            tableLayoutPanel_Left.Visible = false;
            tableLayoutPanel_Mid.Visible = false;
            tableLayoutPanel_Right.Visible = false;

            toolStripLabel_Message.Text = "Welcome to CV Analyser. Please open folder for start.";

            textBox_Keyword.Text = "";
            textBox_Folder_Name.Text = "";

            radioButton_False.Checked = true;
            radioButton_True.Checked = false;

            listBox_Keywords.DataSource = null;
            listBox_Keywords.Items.Clear();

            listBox_Mismatched_Keywords.DataSource = null;
            listBox_Mismatched_Keywords.Items.Clear();

            listBox_Mathces_Keywords.DataSource = null;
            listBox_Mathces_Keywords.Items.Clear();

            dataGridView_Resumes.DataSource = null;
            dataGridView_Resumes.Rows.Clear();

            Resume_Names.Clear();
        }

        private void Analyser_FormClosing(object sender, FormClosingEventArgs e) { }

        private void Form_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Tool Strip Menu Functions
        private void ToolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_Open.ShowDialog() == DialogResult.OK)
            {
                Core_Path = folderBrowserDialog_Open.SelectedPath;

                DirectoryInfo resumes_folder_info = new DirectoryInfo(Core_Path);
                FileInfo[] resumes_info = resumes_folder_info.GetFiles("*.pdf");

                if (resumes_info.Length == 0)
                {
                    MessageBox.Show
                        ("No PDF file found in the selected folder.", "Warning", 
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (FileInfo resume in resumes_info) { Resume_Names.Add(resume.Name); }

                    toolStripLabel_Message.Text = "Folder Path: " + Core_Path;
                    tableLayoutPanel_Left.Visible = true;
                }
            }
        }

        private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel_Left.Visible && 
                tableLayoutPanel_Right.Visible && 
                !string.IsNullOrWhiteSpace(textBox_Folder_Name.Text))
            {
                Save_Result();
            }
        }

        private void ToolStripMenuItem_Feedback_Click(object sender, EventArgs e)
        {
            App.Browser_Start("https://forms.gle/g5EeNw6S2DhqqVAY9");
        }

        private void ToolStripMenuItem_Support_Click(object sender, EventArgs e)
        {
            App.Browser_Start("https://github.com/beydah");
        }
        #endregion

        #region Group Box Keywords Functions
        private void textBox_Keyword_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Keyword.Text != null || textBox_Keyword.Text != "")
            {
                string text = textBox_Keyword.Text;
                string wrong_chars = "\"*-,<é!'^%&/()=?_;>:£$½{[]}\\|@€₺¨~æß´`";
                if (text.Any(c => wrong_chars.Contains(c)))
                {
                    textBox_Keyword.Text = text.Substring(0, text.Length - 1);
                    textBox_Keyword.SelectionStart = textBox_Keyword.Text.Length;
                }
            }
        }

        private void Keywords_Add(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Keyword.Text))
            {
                listBox_Keywords.Items.Add(textBox_Keyword.Text);
                textBox_Keyword.Text = "";
                button_Delete.Enabled = true;
            }
        }

        private void textBox_Keyword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Keywords_Add(sender, e); }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Keywords.SelectedItem != null)
            {
                listBox_Keywords.Items.Remove(listBox_Keywords.SelectedItem);
                if (listBox_Keywords.Items.Count == 0) { button_Delete.Enabled = false; }
            }
        }
        #endregion

        #region Group Box Sorter Functions
        private void Progress_Step(int Step)
        {
            toolStripProgressBar_Long_Process.Value = Step * 10;
            if (Step * 10 == 100) { toolStripProgressBar_Long_Process.Value = 0; }
        }

        private string Keyword_Que()
        {
            string keywords_que = "";
            foreach (string keyword in listBox_Keywords.Items) { keywords_que += keyword + " "; }
            if (radioButton_True.Checked) { keywords_que += "university "; }
            return keywords_que;
        }

        private void Change_Top_CVs_Score()
        {
            DataRow row = Data_Table.Rows[1 - 1];
            label_CV1_Score.Text = "Score: " + row["Score"].ToString();

            row = Data_Table.Rows[2 - 1];
            label_CV2_Score.Text = "Score: " + row["Score"].ToString();

            row = Data_Table.Rows[3 - 1];
            label_CV3_Score.Text = "Score: " + row["Score"].ToString();
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            Progress_Step(1);
            string keyword_que = Keyword_Que();
            Resume.Get_Result(Core_Path, Resume_Names, keyword_que);

            Progress_Step(2);
            int limit = Resume_Limit();
            Data_Table = Query_Resume.Select_Resumes(limit);

            Progress_Step(3);
            No_Keywords_Table = Data_Table;
            No_Keywords_Table.Columns.Remove("Keywords");

            Progress_Step(4);
            dataGridView_Resumes.DataSource = No_Keywords_Table;
            Change_Top_CVs_Score();

            Progress_Step(5);
            int resume_num = Query_Resume.Select_Resume_Count();
            label_Checked_CVs_Num.Text = resume_num.ToString();

            Progress_Step(6);
            if (limit < resume_num) { label_Eliminated_CVs_Num.Text = (resume_num - limit).ToString(); }
            else { label_Eliminated_CVs_Num.Text = "0"; }

            Progress_Step(7);
            string not_found_keywords_string = Resume.Get_Not_Found_Keywords(Core_Path, Resume_Names, keyword_que);

            if (!string.IsNullOrEmpty(not_found_keywords_string) && !string.IsNullOrWhiteSpace(not_found_keywords_string))
            {
                string[] not_found_keywords = not_found_keywords_string.Split(' ');
                listBox_Mismatched_Keywords.DataSource = not_found_keywords;
                label_Mismatched_Keywords_Num.Text = listBox_Mismatched_Keywords.Items.Count.ToString();
            }

            else 
            { 
                label_Mismatched_Keywords_Num.Text = "0";
                listBox_Mismatched_Keywords.DataSource = null;
                listBox_Mismatched_Keywords.Items.Clear();
            }

            Progress_Step(8);
            tableLayoutPanel_Mid.Visible = true;
            tableLayoutPanel_Right.Visible = true;

            Progress_Step(9);

            Progress_Step(10);
        }
        #endregion

        #region Panel Top CVs
        private void button_CV1_Open_Click(object sender, EventArgs e)
        {
            DataRow row = Data_Table.Rows[1 - 1];
            Process.Start(Core_Path + "\\" + row["Name"].ToString());
        }

        private void button_CV2_Open_Click(object sender, EventArgs e)
        {
            DataRow row = Data_Table.Rows[2 - 1];
            Process.Start(Core_Path + "\\" + row["Name"].ToString());
        }

        private void button_CV3_Open_Click(object sender, EventArgs e)
        {
            DataRow row = Data_Table.Rows[3 - 1];
            Process.Start(Core_Path + "\\" + row["Name"].ToString());
        }
        #endregion

        #region Group Box Resumes
        private void dataGridView_Resumes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Resumes.SelectedRows.Count > 0)
            {
                string cv_name = dataGridView_Resumes.SelectedRows[0].Cells["Name"].Value.ToString();
                int score = int.Parse(dataGridView_Resumes.SelectedRows[0].Cells["Score"].Value.ToString());
                string[] keywords = Query_Resume.Select_Keywords(cv_name).Split(' ');

                label_CV_Score.Text = "Score: " + score;
                label_CV_Name.Text = cv_name;
                listBox_Mathces_Keywords.DataSource = keywords.Where(x => !string.IsNullOrEmpty(x)).ToList();
                label_Matches_Num.Text = listBox_Mathces_Keywords.Items.Count.ToString();
            }
        }

        private void button_CV_Open_Click(object sender, EventArgs e)
        {
            string cv_name = dataGridView_Resumes.SelectedRows[0].Cells["Name"].Value.ToString();
            Process.Start(Core_Path + "\\" + cv_name);
        }
        #endregion

        #region Group Box Save
        private void textBox_Folder_Name_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Folder_Name.Text != null || textBox_Folder_Name.Text != "")
            {
                string text = textBox_Folder_Name.Text;
                string wrong_chars = "\"*,<é!'^%&/()=?;>:£$½{[]}\\|@€₺¨~æß´`.#";
                if (text.Any(c => wrong_chars.Contains(c)))
                {
                    textBox_Folder_Name.Text = text.Substring(0, text.Length - 1);
                    textBox_Folder_Name.SelectionStart = textBox_Folder_Name.Text.Length;
                }
            }

            button_Save.Enabled = !string.IsNullOrWhiteSpace(textBox_Folder_Name.Text);
        }
        private void button_Save_Click(object sender, EventArgs e) { Save_Result(); }
        #endregion


    }
}
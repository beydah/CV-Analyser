#region HEADER
// File: analyser.cs
// Project: CV_Analyser
// Description: Main application form for CV analysis and ranking
#endregion

#region LIBRARIES
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
using CV_Analyser.Backend.Resume;
using CV_Analyser.Backend.Core;
#endregion

namespace CV_Analyser.Frontend.Pages
{
    #region CLASSES
    // Main application form for loading, analyzing, and exporting CVs
    public partial class C_Analyser : Form
    {
        #region VARIABLES
        string Core_Path;
        List<string> Resume_Names = new List<string>();
        DataTable Data_Table;
        DataTable No_Keywords_Table;
        #endregion

        #region FUNCTIONS
        // Initializes the analyser form
        public C_Analyser()
        {
            InitializeComponent();
        }

        // Calculates the resume display limit from trackbar value
        private int F_Resume_Limit()
        {
            int limit = trackBar_CV_Rank.Value;
            if (limit < 1) { limit = 5; }
            else { limit *= 10; }
            return limit;
        }

        // Copies top-ranked CVs to a user-selected directory
        private void F_Save_Result()
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

                int limit = F_Resume_Limit();
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

        // Resets all form elements to initial state
        private void F_Form_Clear(object p_sender, EventArgs p_e)
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

        // Handles form load event
        private void F_Analyser_Load(object p_sender, EventArgs p_e)
        {
            F_Form_Clear(p_sender, p_e);
        }

        // Empty handler for form closing event
        private void F_Analyser_Form_Closing(object p_sender, FormClosingEventArgs p_e) { }

        // Exits the application
        private void F_Form_Exit(object p_sender, EventArgs p_e)
        {
            Application.Exit();
        }

        // Opens a folder dialog to select CV directory
        private void F_Tool_Strip_Menu_Item_Open_Click(object p_sender, EventArgs p_e)
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

        // Saves analysis results to selected directory
        private void F_Tool_Strip_Menu_Item_Save_Click(object p_sender, EventArgs p_e)
        {
            if (tableLayoutPanel_Left.Visible &&
                tableLayoutPanel_Right.Visible &&
                !string.IsNullOrWhiteSpace(textBox_Folder_Name.Text))
            {
                F_Save_Result();
            }
        }

        // Opens feedback form in browser
        private void F_Tool_Strip_Menu_Item_Feedback_Click(object p_sender, EventArgs p_e)
        {
            C_App.F_Browser_Start("https://forms.gle/g5EeNw6S2DhqqVAY9");
        }

        // Opens support page in browser
        private void F_Tool_Strip_Menu_Item_Support_Click(object p_sender, EventArgs p_e)
        {
            C_App.F_Browser_Start("https://github.com/beydah");
        }

        // Strips invalid characters from keyword input
        private void F_Text_Box_Keyword_Text_Changed(object p_sender, EventArgs p_e)
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

        // Adds keyword to the keywords list
        private void F_Keywords_Add(object p_sender, EventArgs p_e)
        {
            if (!string.IsNullOrEmpty(textBox_Keyword.Text))
            {
                listBox_Keywords.Items.Add(textBox_Keyword.Text);
                textBox_Keyword.Text = "";
                button_Delete.Enabled = true;
            }
        }

        // Adds keyword on Enter key press
        private void F_Text_Box_Keyword_Key_Up(object p_sender, KeyEventArgs p_e)
        {
            if (p_e.KeyCode == Keys.Enter) { F_Keywords_Add(p_sender, p_e); }
        }

        // Removes selected keyword from the list
        private void F_Button_Delete_Click(object p_sender, EventArgs p_e)
        {
            if (listBox_Keywords.SelectedItem != null)
            {
                listBox_Keywords.Items.Remove(listBox_Keywords.SelectedItem);
                if (listBox_Keywords.Items.Count == 0) { button_Delete.Enabled = false; }
            }
        }

        // Updates progress bar by step
        private void F_Progress_Step(int p_step)
        {
            toolStripProgressBar_Long_Process.Value = p_step * 10;
            if (p_step * 10 == 100) { toolStripProgressBar_Long_Process.Value = 0; }
        }

        // Builds a space-separated keyword query string
        private string F_Keyword_Que()
        {
            string keywords_que = "";
            foreach (string keyword in listBox_Keywords.Items) { keywords_que += keyword + " "; }
            if (radioButton_True.Checked) { keywords_que += "university "; }
            return keywords_que;
        }

        // Updates top 3 CV score labels
        private void F_Change_Top_Cvs_Score()
        {
            DataRow row = Data_Table.Rows[1 - 1];
            label_CV1_Score.Text = "Score: " + row["Score"].ToString();

            row = Data_Table.Rows[2 - 1];
            label_CV2_Score.Text = "Score: " + row["Score"].ToString();

            row = Data_Table.Rows[3 - 1];
            label_CV3_Score.Text = "Score: " + row["Score"].ToString();
        }

        // Executes CV sorting and analysis pipeline
        private void F_Button_Sort_Click(object p_sender, EventArgs p_e)
        {
            F_Progress_Step(1);
            string keyword_que = F_Keyword_Que();
            C_Resume.F_Get_Result(Core_Path, Resume_Names, keyword_que);

            F_Progress_Step(2);
            int limit = F_Resume_Limit();
            Data_Table = C_Query_Resume.F_Select_Resumes(limit);

            F_Progress_Step(3);
            No_Keywords_Table = Data_Table;
            No_Keywords_Table.Columns.Remove("Keywords");

            F_Progress_Step(4);
            dataGridView_Resumes.DataSource = No_Keywords_Table;
            F_Change_Top_Cvs_Score();

            F_Progress_Step(5);
            int resume_num = C_Query_Resume.F_Select_Resume_Count();
            label_Checked_CVs_Num.Text = resume_num.ToString();

            F_Progress_Step(6);
            if (limit < resume_num) { label_Eliminated_CVs_Num.Text = (resume_num - limit).ToString(); }
            else { label_Eliminated_CVs_Num.Text = "0"; }

            F_Progress_Step(7);
            string not_found_keywords_string = C_Resume.F_Get_Not_Found_Keywords(Core_Path, Resume_Names, keyword_que);

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

            F_Progress_Step(8);
            tableLayoutPanel_Mid.Visible = true;
            tableLayoutPanel_Right.Visible = true;

            F_Progress_Step(9);
            F_Progress_Step(10);
        }

        // Opens the first ranked CV file
        private void F_Button_Cv1_Open_Click(object p_sender, EventArgs p_e)
        {
            DataRow row = Data_Table.Rows[1 - 1];
            Process.Start(Core_Path + "\\" + row["Name"].ToString());
        }

        // Opens the second ranked CV file
        private void F_Button_Cv2_Open_Click(object p_sender, EventArgs p_e)
        {
            DataRow row = Data_Table.Rows[2 - 1];
            Process.Start(Core_Path + "\\" + row["Name"].ToString());
        }

        // Opens the third ranked CV file
        private void F_Button_Cv3_Open_Click(object p_sender, EventArgs p_e)
        {
            DataRow row = Data_Table.Rows[3 - 1];
            Process.Start(Core_Path + "\\" + row["Name"].ToString());
        }

        // Updates keyword details when a resume row is selected
        private void F_Data_Grid_View_Resumes_Selection_Changed(object p_sender, EventArgs p_e)
        {
            if (dataGridView_Resumes.SelectedRows.Count > 0)
            {
                string cv_name = dataGridView_Resumes.SelectedRows[0].Cells["Name"].Value.ToString();
                int score = int.Parse(dataGridView_Resumes.SelectedRows[0].Cells["Score"].Value.ToString());
                string[] keywords = C_Query_Resume.F_Select_Keywords(cv_name).Split(' ');

                label_CV_Score.Text = "Score: " + score;
                label_CV_Name.Text = cv_name;
                listBox_Mathces_Keywords.DataSource = keywords.Where(x => !string.IsNullOrEmpty(x)).ToList();
                label_Matches_Num.Text = listBox_Mathces_Keywords.Items.Count.ToString();
            }
        }

        // Opens the currently selected CV file
        private void F_Button_Cv_Open_Click(object p_sender, EventArgs p_e)
        {
            string cv_name = dataGridView_Resumes.SelectedRows[0].Cells["Name"].Value.ToString();
            Process.Start(Core_Path + "\\" + cv_name);
        }

        // Strips invalid characters from folder name input
        private void F_Text_Box_Folder_Name_Text_Changed(object p_sender, EventArgs p_e)
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

        // Triggers save result workflow
        private void F_Button_Save_Click(object p_sender, EventArgs p_e) { F_Save_Result(); }
        #endregion
    }
    #endregion
}

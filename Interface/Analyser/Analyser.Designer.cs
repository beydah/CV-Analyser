using System.Drawing;
using System.Windows.Forms;
using System;

namespace CV_Analyser.Interface.Analyser
{
    partial class Analyser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analyser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel_Window = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Right = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Save = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Save = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Save_Result = new System.Windows.Forms.TableLayoutPanel();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox_Folder = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Folder = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Folder_Name = new System.Windows.Forms.TextBox();
            this.groupBox_Analysis = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Analysis = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Not_Founded = new System.Windows.Forms.GroupBox();
            this.listBox_Mismatched_Keywords = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel_Analysis_Top = new System.Windows.Forms.TableLayoutPanel();
            this.label_Mismatched_Keywords = new System.Windows.Forms.Label();
            this.label_Checked_CVs_Num = new System.Windows.Forms.Label();
            this.label_Eliminated_CVs_Num = new System.Windows.Forms.Label();
            this.label_Mismatched_Keywords_Num = new System.Windows.Forms.Label();
            this.label_Checked_CVs = new System.Windows.Forms.Label();
            this.label_Eliminated_CVs = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Mid = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Resumes_Out = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Resumes = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Resumes_In = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Resume = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_CV_Open = new System.Windows.Forms.TableLayoutPanel();
            this.button_CV_Open = new System.Windows.Forms.Button();
            this.groupBox_CV_Name = new System.Windows.Forms.GroupBox();
            this.label_CV_Name = new System.Windows.Forms.Label();
            this.groupBox_Mathches_Keywords = new System.Windows.Forms.GroupBox();
            this.listBox_Mathces_Keywords = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel_Other_Resume_Top = new System.Windows.Forms.TableLayoutPanel();
            this.label_CV_Score = new System.Windows.Forms.Label();
            this.pictureBox_CV_Photo = new System.Windows.Forms.PictureBox();
            this.groupBox_Matches_Num = new System.Windows.Forms.GroupBox();
            this.label_Matches_Num = new System.Windows.Forms.Label();
            this.dataGridView_Resumes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_Top_CVs = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_CV3_Out = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Top3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_CV3_In = new System.Windows.Forms.TableLayoutPanel();
            this.button_CV3_Open = new System.Windows.Forms.Button();
            this.tableLayoutPanel_CV3_Top = new System.Windows.Forms.TableLayoutPanel();
            this.label_CV3_Score = new System.Windows.Forms.Label();
            this.pictureBox_CV3_Photo = new System.Windows.Forms.PictureBox();
            this.pictureBox_CV3_Text = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_CV1_Out = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Top1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_CV1_In = new System.Windows.Forms.TableLayoutPanel();
            this.button_CV1_Open = new System.Windows.Forms.Button();
            this.tableLayoutPanel_CV1_Top = new System.Windows.Forms.TableLayoutPanel();
            this.label_CV1_Score = new System.Windows.Forms.Label();
            this.pictureBox_CV1_Photo = new System.Windows.Forms.PictureBox();
            this.pictureBox_CV1_Text = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_CV2_Out = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Top2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_CV2_In = new System.Windows.Forms.TableLayoutPanel();
            this.button_CV2_Open = new System.Windows.Forms.Button();
            this.tableLayoutPanel_CV2_Top = new System.Windows.Forms.TableLayoutPanel();
            this.label_CV2_Score = new System.Windows.Forms.Label();
            this.pictureBox_CV2_Photo = new System.Windows.Forms.PictureBox();
            this.pictureBox_CV2_Text = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_Left = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Sorter = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Sorter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_CV_Sort_Button = new System.Windows.Forms.TableLayoutPanel();
            this.button_Sort = new System.Windows.Forms.Button();
            this.groupBox_Univesity_Option = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_University_Option = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_True = new System.Windows.Forms.RadioButton();
            this.radioButton_False = new System.Windows.Forms.RadioButton();
            this.groupBox_Get_Size = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_CV_Rank = new System.Windows.Forms.TableLayoutPanel();
            this.label_Overline_Max = new System.Windows.Forms.Label();
            this.label_Overline_Min = new System.Windows.Forms.Label();
            this.trackBar_CV_Rank = new System.Windows.Forms.TrackBar();
            this.groupBox_Keywords = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Keyword = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Keywords = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_Keywords = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel_Delete = new System.Windows.Forms.TableLayoutPanel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Keyword_Input = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Icon_Enter = new System.Windows.Forms.PictureBox();
            this.textBox_Keyword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Top_Out = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Top_In = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip_Top = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Logo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator_Left = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton_Help = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_Tips = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Started = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Feedback = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Support = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton_Account = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_Change_Mail = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Change_Phone = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Change_Password = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Change_Username = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Delete_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_Right = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Message = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar_Long_Process = new System.Windows.Forms.ToolStripProgressBar();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownMenu();
            this.folderBrowserDialog_Open = new System.Windows.Forms.FolderBrowserDialog();
            this.resumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel_Window.SuspendLayout();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel_Right.SuspendLayout();
            this.groupBox_Save.SuspendLayout();
            this.tableLayoutPanel_Save.SuspendLayout();
            this.tableLayoutPanel_Save_Result.SuspendLayout();
            this.groupBox_Folder.SuspendLayout();
            this.tableLayoutPanel_Folder.SuspendLayout();
            this.groupBox_Analysis.SuspendLayout();
            this.tableLayoutPanel_Analysis.SuspendLayout();
            this.groupBox_Not_Founded.SuspendLayout();
            this.tableLayoutPanel_Analysis_Top.SuspendLayout();
            this.tableLayoutPanel_Mid.SuspendLayout();
            this.tableLayoutPanel_Resumes_Out.SuspendLayout();
            this.groupBox_Resumes.SuspendLayout();
            this.tableLayoutPanel_Resumes_In.SuspendLayout();
            this.tableLayoutPanel_Resume.SuspendLayout();
            this.tableLayoutPanel_CV_Open.SuspendLayout();
            this.groupBox_CV_Name.SuspendLayout();
            this.groupBox_Mathches_Keywords.SuspendLayout();
            this.tableLayoutPanel_Other_Resume_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV_Photo)).BeginInit();
            this.groupBox_Matches_Num.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resumes)).BeginInit();
            this.tableLayoutPanel_Top_CVs.SuspendLayout();
            this.tableLayoutPanel_CV3_Out.SuspendLayout();
            this.groupBox_Top3.SuspendLayout();
            this.tableLayoutPanel_CV3_In.SuspendLayout();
            this.tableLayoutPanel_CV3_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV3_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV3_Text)).BeginInit();
            this.tableLayoutPanel_CV1_Out.SuspendLayout();
            this.groupBox_Top1.SuspendLayout();
            this.tableLayoutPanel_CV1_In.SuspendLayout();
            this.tableLayoutPanel_CV1_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV1_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV1_Text)).BeginInit();
            this.tableLayoutPanel_CV2_Out.SuspendLayout();
            this.groupBox_Top2.SuspendLayout();
            this.tableLayoutPanel_CV2_In.SuspendLayout();
            this.tableLayoutPanel_CV2_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV2_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV2_Text)).BeginInit();
            this.tableLayoutPanel_Left.SuspendLayout();
            this.groupBox_Sorter.SuspendLayout();
            this.tableLayoutPanel_Sorter.SuspendLayout();
            this.tableLayoutPanel_CV_Sort_Button.SuspendLayout();
            this.groupBox_Univesity_Option.SuspendLayout();
            this.tableLayoutPanel_University_Option.SuspendLayout();
            this.groupBox_Get_Size.SuspendLayout();
            this.tableLayoutPanel_CV_Rank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CV_Rank)).BeginInit();
            this.groupBox_Keywords.SuspendLayout();
            this.tableLayoutPanel_Keyword.SuspendLayout();
            this.tableLayoutPanel_Keywords.SuspendLayout();
            this.tableLayoutPanel_Delete.SuspendLayout();
            this.tableLayoutPanel_Keyword_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon_Enter)).BeginInit();
            this.tableLayoutPanel_Top_Out.SuspendLayout();
            this.tableLayoutPanel_Top_In.SuspendLayout();
            this.toolStrip_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resumeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Window
            // 
            this.tableLayoutPanel_Window.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Window.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Window.ColumnCount = 3;
            this.tableLayoutPanel_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Window.Controls.Add(this.tableLayoutPanel_Main, 1, 2);
            this.tableLayoutPanel_Window.Controls.Add(this.tableLayoutPanel_Top_Out, 1, 1);
            this.tableLayoutPanel_Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Window.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Window.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel_Window.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Window.Name = "tableLayoutPanel_Window";
            this.tableLayoutPanel_Window.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Window.RowCount = 4;
            this.tableLayoutPanel_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.5F));
            this.tableLayoutPanel_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Window.Size = new System.Drawing.Size(1258, 781);
            this.tableLayoutPanel_Window.TabIndex = 0;
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Main.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Main.ColumnCount = 3;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Right, 2, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Mid, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Left, 0, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(66, 100);
            this.tableLayoutPanel_Main.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Main.RowCount = 1;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1124, 637);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // tableLayoutPanel_Right
            // 
            this.tableLayoutPanel_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Right.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Right.ColumnCount = 1;
            this.tableLayoutPanel_Right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Right.Controls.Add(this.groupBox_Save, 0, 2);
            this.tableLayoutPanel_Right.Controls.Add(this.groupBox_Analysis, 0, 0);
            this.tableLayoutPanel_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Right.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Right.Location = new System.Drawing.Point(844, 4);
            this.tableLayoutPanel_Right.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Right.Name = "tableLayoutPanel_Right";
            this.tableLayoutPanel_Right.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Right.RowCount = 3;
            this.tableLayoutPanel_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_Right.Size = new System.Drawing.Size(276, 629);
            this.tableLayoutPanel_Right.TabIndex = 0;
            this.tableLayoutPanel_Right.Visible = false;
            // 
            // groupBox_Save
            // 
            this.groupBox_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.groupBox_Save.Controls.Add(this.tableLayoutPanel_Save);
            this.groupBox_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Save.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Save.Location = new System.Drawing.Point(4, 410);
            this.groupBox_Save.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Save.Name = "groupBox_Save";
            this.groupBox_Save.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Save.Size = new System.Drawing.Size(268, 215);
            this.groupBox_Save.TabIndex = 0;
            this.groupBox_Save.TabStop = false;
            this.groupBox_Save.Text = "Save";
            // 
            // tableLayoutPanel_Save
            // 
            this.tableLayoutPanel_Save.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Save.ColumnCount = 1;
            this.tableLayoutPanel_Save.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Save.Controls.Add(this.tableLayoutPanel_Save_Result, 0, 2);
            this.tableLayoutPanel_Save.Controls.Add(this.groupBox_Folder, 0, 0);
            this.tableLayoutPanel_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Save.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Save.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Save.Name = "tableLayoutPanel_Save";
            this.tableLayoutPanel_Save.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Save.RowCount = 3;
            this.tableLayoutPanel_Save.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_Save.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Save.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_Save.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Save.Size = new System.Drawing.Size(264, 188);
            this.tableLayoutPanel_Save.TabIndex = 0;
            // 
            // tableLayoutPanel_Save_Result
            // 
            this.tableLayoutPanel_Save_Result.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Save_Result.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Save_Result.ColumnCount = 1;
            this.tableLayoutPanel_Save_Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Save_Result.Controls.Add(this.button_Save, 0, 0);
            this.tableLayoutPanel_Save_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Save_Result.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Save_Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Save_Result.Location = new System.Drawing.Point(4, 113);
            this.tableLayoutPanel_Save_Result.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Save_Result.Name = "tableLayoutPanel_Save_Result";
            this.tableLayoutPanel_Save_Result.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Save_Result.RowCount = 1;
            this.tableLayoutPanel_Save_Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Save_Result.Size = new System.Drawing.Size(256, 71);
            this.tableLayoutPanel_Save_Result.TabIndex = 0;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Save.Enabled = false;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_Save.Location = new System.Drawing.Point(4, 4);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Padding = new System.Windows.Forms.Padding(2);
            this.button_Save.Size = new System.Drawing.Size(248, 63);
            this.button_Save.TabIndex = 13;
            this.button_Save.Text = "Save Result";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // groupBox_Folder
            // 
            this.groupBox_Folder.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Folder.Controls.Add(this.tableLayoutPanel_Folder);
            this.groupBox_Folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Folder.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Folder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Folder.Location = new System.Drawing.Point(4, 4);
            this.groupBox_Folder.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Folder.Name = "groupBox_Folder";
            this.groupBox_Folder.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Folder.Size = new System.Drawing.Size(256, 69);
            this.groupBox_Folder.TabIndex = 0;
            this.groupBox_Folder.TabStop = false;
            this.groupBox_Folder.Text = "Enter Folder Name";
            // 
            // tableLayoutPanel_Folder
            // 
            this.tableLayoutPanel_Folder.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Folder.ColumnCount = 2;
            this.tableLayoutPanel_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Folder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Folder.Controls.Add(this.textBox_Folder_Name, 0, 0);
            this.tableLayoutPanel_Folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Folder.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Folder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Folder.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Folder.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Folder.Name = "tableLayoutPanel_Folder";
            this.tableLayoutPanel_Folder.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Folder.RowCount = 1;
            this.tableLayoutPanel_Folder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Folder.Size = new System.Drawing.Size(252, 42);
            this.tableLayoutPanel_Folder.TabIndex = 12;
            // 
            // textBox_Folder_Name
            // 
            this.textBox_Folder_Name.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox_Folder_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.textBox_Folder_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_Folder_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Folder_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Folder_Name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Folder_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.textBox_Folder_Name.Location = new System.Drawing.Point(4, 4);
            this.textBox_Folder_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Folder_Name.Name = "textBox_Folder_Name";
            this.textBox_Folder_Name.Size = new System.Drawing.Size(194, 34);
            this.textBox_Folder_Name.TabIndex = 0;
            this.textBox_Folder_Name.TextChanged += new System.EventHandler(this.textBox_Folder_Name_TextChanged);
            // 
            // groupBox_Analysis
            // 
            this.groupBox_Analysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.groupBox_Analysis.Controls.Add(this.tableLayoutPanel_Analysis);
            this.groupBox_Analysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Analysis.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Analysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Analysis.Location = new System.Drawing.Point(4, 4);
            this.groupBox_Analysis.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Analysis.Name = "groupBox_Analysis";
            this.groupBox_Analysis.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Analysis.Size = new System.Drawing.Size(268, 371);
            this.groupBox_Analysis.TabIndex = 0;
            this.groupBox_Analysis.TabStop = false;
            this.groupBox_Analysis.Text = "Analysis";
            // 
            // tableLayoutPanel_Analysis
            // 
            this.tableLayoutPanel_Analysis.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Analysis.ColumnCount = 1;
            this.tableLayoutPanel_Analysis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Analysis.Controls.Add(this.groupBox_Not_Founded, 0, 1);
            this.tableLayoutPanel_Analysis.Controls.Add(this.tableLayoutPanel_Analysis_Top, 0, 0);
            this.tableLayoutPanel_Analysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Analysis.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Analysis.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Analysis.Name = "tableLayoutPanel_Analysis";
            this.tableLayoutPanel_Analysis.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Analysis.RowCount = 2;
            this.tableLayoutPanel_Analysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Analysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Analysis.Size = new System.Drawing.Size(264, 344);
            this.tableLayoutPanel_Analysis.TabIndex = 0;
            // 
            // groupBox_Not_Founded
            // 
            this.groupBox_Not_Founded.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Not_Founded.Controls.Add(this.listBox_Mismatched_Keywords);
            this.groupBox_Not_Founded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Not_Founded.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Not_Founded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Not_Founded.Location = new System.Drawing.Point(4, 174);
            this.groupBox_Not_Founded.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Not_Founded.Name = "groupBox_Not_Founded";
            this.groupBox_Not_Founded.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Not_Founded.Size = new System.Drawing.Size(256, 166);
            this.groupBox_Not_Founded.TabIndex = 0;
            this.groupBox_Not_Founded.TabStop = false;
            this.groupBox_Not_Founded.Text = "Mismatched Keywords";
            // 
            // listBox_Mismatched_Keywords
            // 
            this.listBox_Mismatched_Keywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.listBox_Mismatched_Keywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Mismatched_Keywords.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.listBox_Mismatched_Keywords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.listBox_Mismatched_Keywords.FormattingEnabled = true;
            this.listBox_Mismatched_Keywords.ItemHeight = 23;
            this.listBox_Mismatched_Keywords.Location = new System.Drawing.Point(2, 25);
            this.listBox_Mismatched_Keywords.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Mismatched_Keywords.Name = "listBox_Mismatched_Keywords";
            this.listBox_Mismatched_Keywords.Size = new System.Drawing.Size(252, 139);
            this.listBox_Mismatched_Keywords.TabIndex = 0;
            // 
            // tableLayoutPanel_Analysis_Top
            // 
            this.tableLayoutPanel_Analysis_Top.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Analysis_Top.ColumnCount = 2;
            this.tableLayoutPanel_Analysis_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel_Analysis_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Analysis_Top.Controls.Add(this.label_Mismatched_Keywords, 0, 2);
            this.tableLayoutPanel_Analysis_Top.Controls.Add(this.label_Checked_CVs_Num, 1, 0);
            this.tableLayoutPanel_Analysis_Top.Controls.Add(this.label_Eliminated_CVs_Num, 1, 1);
            this.tableLayoutPanel_Analysis_Top.Controls.Add(this.label_Mismatched_Keywords_Num, 1, 2);
            this.tableLayoutPanel_Analysis_Top.Controls.Add(this.label_Checked_CVs, 0, 0);
            this.tableLayoutPanel_Analysis_Top.Controls.Add(this.label_Eliminated_CVs, 0, 1);
            this.tableLayoutPanel_Analysis_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Analysis_Top.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_Analysis_Top.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Analysis_Top.Name = "tableLayoutPanel_Analysis_Top";
            this.tableLayoutPanel_Analysis_Top.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Analysis_Top.RowCount = 3;
            this.tableLayoutPanel_Analysis_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Analysis_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Analysis_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Analysis_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Analysis_Top.Size = new System.Drawing.Size(256, 166);
            this.tableLayoutPanel_Analysis_Top.TabIndex = 0;
            // 
            // label_Mismatched_Keywords
            // 
            this.label_Mismatched_Keywords.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_Mismatched_Keywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Mismatched_Keywords.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mismatched_Keywords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Mismatched_Keywords.Location = new System.Drawing.Point(4, 112);
            this.label_Mismatched_Keywords.Margin = new System.Windows.Forms.Padding(2);
            this.label_Mismatched_Keywords.Name = "label_Mismatched_Keywords";
            this.label_Mismatched_Keywords.Padding = new System.Windows.Forms.Padding(2);
            this.label_Mismatched_Keywords.Size = new System.Drawing.Size(185, 50);
            this.label_Mismatched_Keywords.TabIndex = 0;
            this.label_Mismatched_Keywords.Text = "Mismatched Keywords Number";
            // 
            // label_Checked_CVs_Num
            // 
            this.label_Checked_CVs_Num.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_Checked_CVs_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Checked_CVs_Num.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.label_Checked_CVs_Num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_Checked_CVs_Num.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Checked_CVs_Num.Location = new System.Drawing.Point(193, 4);
            this.label_Checked_CVs_Num.Margin = new System.Windows.Forms.Padding(2);
            this.label_Checked_CVs_Num.Name = "label_Checked_CVs_Num";
            this.label_Checked_CVs_Num.Padding = new System.Windows.Forms.Padding(2);
            this.label_Checked_CVs_Num.Size = new System.Drawing.Size(59, 50);
            this.label_Checked_CVs_Num.TabIndex = 0;
            this.label_Checked_CVs_Num.Text = "Num";
            // 
            // label_Eliminated_CVs_Num
            // 
            this.label_Eliminated_CVs_Num.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_Eliminated_CVs_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Eliminated_CVs_Num.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.label_Eliminated_CVs_Num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_Eliminated_CVs_Num.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Eliminated_CVs_Num.Location = new System.Drawing.Point(193, 58);
            this.label_Eliminated_CVs_Num.Margin = new System.Windows.Forms.Padding(2);
            this.label_Eliminated_CVs_Num.Name = "label_Eliminated_CVs_Num";
            this.label_Eliminated_CVs_Num.Padding = new System.Windows.Forms.Padding(2);
            this.label_Eliminated_CVs_Num.Size = new System.Drawing.Size(59, 50);
            this.label_Eliminated_CVs_Num.TabIndex = 0;
            this.label_Eliminated_CVs_Num.Text = "Num";
            // 
            // label_Mismatched_Keywords_Num
            // 
            this.label_Mismatched_Keywords_Num.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_Mismatched_Keywords_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Mismatched_Keywords_Num.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.label_Mismatched_Keywords_Num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_Mismatched_Keywords_Num.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Mismatched_Keywords_Num.Location = new System.Drawing.Point(193, 112);
            this.label_Mismatched_Keywords_Num.Margin = new System.Windows.Forms.Padding(2);
            this.label_Mismatched_Keywords_Num.Name = "label_Mismatched_Keywords_Num";
            this.label_Mismatched_Keywords_Num.Padding = new System.Windows.Forms.Padding(2);
            this.label_Mismatched_Keywords_Num.Size = new System.Drawing.Size(59, 50);
            this.label_Mismatched_Keywords_Num.TabIndex = 0;
            this.label_Mismatched_Keywords_Num.Text = "Num";
            // 
            // label_Checked_CVs
            // 
            this.label_Checked_CVs.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_Checked_CVs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Checked_CVs.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Checked_CVs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Checked_CVs.Location = new System.Drawing.Point(4, 4);
            this.label_Checked_CVs.Margin = new System.Windows.Forms.Padding(2);
            this.label_Checked_CVs.Name = "label_Checked_CVs";
            this.label_Checked_CVs.Padding = new System.Windows.Forms.Padding(2);
            this.label_Checked_CVs.Size = new System.Drawing.Size(185, 50);
            this.label_Checked_CVs.TabIndex = 0;
            this.label_Checked_CVs.Text = "Checked CVs Number";
            // 
            // label_Eliminated_CVs
            // 
            this.label_Eliminated_CVs.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_Eliminated_CVs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Eliminated_CVs.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Eliminated_CVs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Eliminated_CVs.Location = new System.Drawing.Point(4, 58);
            this.label_Eliminated_CVs.Margin = new System.Windows.Forms.Padding(2);
            this.label_Eliminated_CVs.Name = "label_Eliminated_CVs";
            this.label_Eliminated_CVs.Padding = new System.Windows.Forms.Padding(2);
            this.label_Eliminated_CVs.Size = new System.Drawing.Size(185, 50);
            this.label_Eliminated_CVs.TabIndex = 0;
            this.label_Eliminated_CVs.Text = "Eliminated CVs Number";
            // 
            // tableLayoutPanel_Mid
            // 
            this.tableLayoutPanel_Mid.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Mid.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Mid.ColumnCount = 1;
            this.tableLayoutPanel_Mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Mid.Controls.Add(this.tableLayoutPanel_Resumes_Out, 0, 1);
            this.tableLayoutPanel_Mid.Controls.Add(this.tableLayoutPanel_Top_CVs, 0, 0);
            this.tableLayoutPanel_Mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Mid.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Mid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Mid.Location = new System.Drawing.Point(284, 4);
            this.tableLayoutPanel_Mid.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Mid.Name = "tableLayoutPanel_Mid";
            this.tableLayoutPanel_Mid.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Mid.RowCount = 2;
            this.tableLayoutPanel_Mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_Mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_Mid.Size = new System.Drawing.Size(556, 629);
            this.tableLayoutPanel_Mid.TabIndex = 0;
            this.tableLayoutPanel_Mid.Visible = false;
            // 
            // tableLayoutPanel_Resumes_Out
            // 
            this.tableLayoutPanel_Resumes_Out.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Resumes_Out.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Resumes_Out.ColumnCount = 3;
            this.tableLayoutPanel_Resumes_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel_Resumes_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel_Resumes_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel_Resumes_Out.Controls.Add(this.groupBox_Resumes, 1, 0);
            this.tableLayoutPanel_Resumes_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Resumes_Out.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Resumes_Out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Resumes_Out.Location = new System.Drawing.Point(4, 254);
            this.tableLayoutPanel_Resumes_Out.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Resumes_Out.Name = "tableLayoutPanel_Resumes_Out";
            this.tableLayoutPanel_Resumes_Out.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Resumes_Out.RowCount = 1;
            this.tableLayoutPanel_Resumes_Out.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Resumes_Out.Size = new System.Drawing.Size(548, 371);
            this.tableLayoutPanel_Resumes_Out.TabIndex = 0;
            // 
            // groupBox_Resumes
            // 
            this.groupBox_Resumes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.groupBox_Resumes.Controls.Add(this.tableLayoutPanel_Resumes_In);
            this.groupBox_Resumes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Resumes.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Resumes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Resumes.Location = new System.Drawing.Point(20, 4);
            this.groupBox_Resumes.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Resumes.Name = "groupBox_Resumes";
            this.groupBox_Resumes.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Resumes.Size = new System.Drawing.Size(507, 363);
            this.groupBox_Resumes.TabIndex = 0;
            this.groupBox_Resumes.TabStop = false;
            this.groupBox_Resumes.Text = "Resumes";
            // 
            // tableLayoutPanel_Resumes_In
            // 
            this.tableLayoutPanel_Resumes_In.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Resumes_In.ColumnCount = 2;
            this.tableLayoutPanel_Resumes_In.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_Resumes_In.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_Resumes_In.Controls.Add(this.tableLayoutPanel_Resume, 0, 0);
            this.tableLayoutPanel_Resumes_In.Controls.Add(this.dataGridView_Resumes, 0, 0);
            this.tableLayoutPanel_Resumes_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Resumes_In.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Resumes_In.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Resumes_In.Name = "tableLayoutPanel_Resumes_In";
            this.tableLayoutPanel_Resumes_In.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Resumes_In.RowCount = 1;
            this.tableLayoutPanel_Resumes_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Resumes_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Resumes_In.Size = new System.Drawing.Size(503, 336);
            this.tableLayoutPanel_Resumes_In.TabIndex = 0;
            // 
            // tableLayoutPanel_Resume
            // 
            this.tableLayoutPanel_Resume.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Resume.ColumnCount = 1;
            this.tableLayoutPanel_Resume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Resume.Controls.Add(this.tableLayoutPanel_CV_Open, 0, 4);
            this.tableLayoutPanel_Resume.Controls.Add(this.groupBox_CV_Name, 0, 1);
            this.tableLayoutPanel_Resume.Controls.Add(this.groupBox_Mathches_Keywords, 0, 3);
            this.tableLayoutPanel_Resume.Controls.Add(this.tableLayoutPanel_Other_Resume_Top, 0, 0);
            this.tableLayoutPanel_Resume.Controls.Add(this.groupBox_Matches_Num, 0, 2);
            this.tableLayoutPanel_Resume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Resume.Location = new System.Drawing.Point(303, 4);
            this.tableLayoutPanel_Resume.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Resume.Name = "tableLayoutPanel_Resume";
            this.tableLayoutPanel_Resume.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Resume.RowCount = 5;
            this.tableLayoutPanel_Resume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Resume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.59259F));
            this.tableLayoutPanel_Resume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Resume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.49383F));
            this.tableLayoutPanel_Resume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Resume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Resume.Size = new System.Drawing.Size(196, 328);
            this.tableLayoutPanel_Resume.TabIndex = 0;
            // 
            // tableLayoutPanel_CV_Open
            // 
            this.tableLayoutPanel_CV_Open.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_CV_Open.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_CV_Open.ColumnCount = 1;
            this.tableLayoutPanel_CV_Open.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CV_Open.Controls.Add(this.button_CV_Open, 0, 0);
            this.tableLayoutPanel_CV_Open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV_Open.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_CV_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_CV_Open.Location = new System.Drawing.Point(4, 278);
            this.tableLayoutPanel_CV_Open.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV_Open.Name = "tableLayoutPanel_CV_Open";
            this.tableLayoutPanel_CV_Open.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV_Open.RowCount = 1;
            this.tableLayoutPanel_CV_Open.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CV_Open.Size = new System.Drawing.Size(188, 46);
            this.tableLayoutPanel_CV_Open.TabIndex = 0;
            // 
            // button_CV_Open
            // 
            this.button_CV_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(113)))));
            this.button_CV_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CV_Open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CV_Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CV_Open.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_CV_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_CV_Open.Location = new System.Drawing.Point(4, 4);
            this.button_CV_Open.Margin = new System.Windows.Forms.Padding(2);
            this.button_CV_Open.Name = "button_CV_Open";
            this.button_CV_Open.Padding = new System.Windows.Forms.Padding(2);
            this.button_CV_Open.Size = new System.Drawing.Size(180, 38);
            this.button_CV_Open.TabIndex = 11;
            this.button_CV_Open.Text = "Open CV";
            this.button_CV_Open.UseVisualStyleBackColor = false;
            this.button_CV_Open.Click += new System.EventHandler(this.button_CV_Open_Click);
            // 
            // groupBox_CV_Name
            // 
            this.groupBox_CV_Name.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_CV_Name.Controls.Add(this.label_CV_Name);
            this.groupBox_CV_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_CV_Name.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_CV_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_CV_Name.Location = new System.Drawing.Point(4, 52);
            this.groupBox_CV_Name.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_CV_Name.Name = "groupBox_CV_Name";
            this.groupBox_CV_Name.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_CV_Name.Size = new System.Drawing.Size(188, 53);
            this.groupBox_CV_Name.TabIndex = 0;
            this.groupBox_CV_Name.TabStop = false;
            this.groupBox_CV_Name.Text = "CV Name";
            // 
            // label_CV_Name
            // 
            this.label_CV_Name.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_CV_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CV_Name.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.label_CV_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_CV_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_CV_Name.Location = new System.Drawing.Point(2, 25);
            this.label_CV_Name.Margin = new System.Windows.Forms.Padding(2);
            this.label_CV_Name.Name = "label_CV_Name";
            this.label_CV_Name.Padding = new System.Windows.Forms.Padding(2);
            this.label_CV_Name.Size = new System.Drawing.Size(184, 26);
            this.label_CV_Name.TabIndex = 0;
            this.label_CV_Name.Text = "Name";
            // 
            // groupBox_Mathches_Keywords
            // 
            this.groupBox_Mathches_Keywords.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Mathches_Keywords.Controls.Add(this.listBox_Mathces_Keywords);
            this.groupBox_Mathches_Keywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Mathches_Keywords.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Mathches_Keywords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Mathches_Keywords.Location = new System.Drawing.Point(4, 163);
            this.groupBox_Mathches_Keywords.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Mathches_Keywords.Name = "groupBox_Mathches_Keywords";
            this.groupBox_Mathches_Keywords.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Mathches_Keywords.Size = new System.Drawing.Size(188, 111);
            this.groupBox_Mathches_Keywords.TabIndex = 0;
            this.groupBox_Mathches_Keywords.TabStop = false;
            this.groupBox_Mathches_Keywords.Text = "Mathches Keywords";
            // 
            // listBox_Mathces_Keywords
            // 
            this.listBox_Mathces_Keywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.listBox_Mathces_Keywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Mathces_Keywords.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.listBox_Mathces_Keywords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.listBox_Mathces_Keywords.FormattingEnabled = true;
            this.listBox_Mathces_Keywords.ItemHeight = 23;
            this.listBox_Mathces_Keywords.Location = new System.Drawing.Point(2, 25);
            this.listBox_Mathces_Keywords.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Mathces_Keywords.Name = "listBox_Mathces_Keywords";
            this.listBox_Mathces_Keywords.Size = new System.Drawing.Size(184, 84);
            this.listBox_Mathces_Keywords.TabIndex = 0;
            // 
            // tableLayoutPanel_Other_Resume_Top
            // 
            this.tableLayoutPanel_Other_Resume_Top.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Other_Resume_Top.ColumnCount = 2;
            this.tableLayoutPanel_Other_Resume_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Other_Resume_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel_Other_Resume_Top.Controls.Add(this.label_CV_Score, 0, 0);
            this.tableLayoutPanel_Other_Resume_Top.Controls.Add(this.pictureBox_CV_Photo, 0, 0);
            this.tableLayoutPanel_Other_Resume_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Other_Resume_Top.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_Other_Resume_Top.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Other_Resume_Top.Name = "tableLayoutPanel_Other_Resume_Top";
            this.tableLayoutPanel_Other_Resume_Top.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Other_Resume_Top.RowCount = 1;
            this.tableLayoutPanel_Other_Resume_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Other_Resume_Top.Size = new System.Drawing.Size(188, 44);
            this.tableLayoutPanel_Other_Resume_Top.TabIndex = 0;
            // 
            // label_CV_Score
            // 
            this.label_CV_Score.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_CV_Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CV_Score.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.label_CV_Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_CV_Score.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_CV_Score.Location = new System.Drawing.Point(50, 4);
            this.label_CV_Score.Margin = new System.Windows.Forms.Padding(2);
            this.label_CV_Score.Name = "label_CV_Score";
            this.label_CV_Score.Padding = new System.Windows.Forms.Padding(2);
            this.label_CV_Score.Size = new System.Drawing.Size(134, 36);
            this.label_CV_Score.TabIndex = 0;
            this.label_CV_Score.Text = "Score: ";
            this.label_CV_Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_CV_Photo
            // 
            this.pictureBox_CV_Photo.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox_CV_Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CV_Photo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CV_Photo.Image")));
            this.pictureBox_CV_Photo.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_CV_Photo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV_Photo.Name = "pictureBox_CV_Photo";
            this.pictureBox_CV_Photo.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV_Photo.Size = new System.Drawing.Size(42, 36);
            this.pictureBox_CV_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CV_Photo.TabIndex = 0;
            this.pictureBox_CV_Photo.TabStop = false;
            // 
            // groupBox_Matches_Num
            // 
            this.groupBox_Matches_Num.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Matches_Num.Controls.Add(this.label_Matches_Num);
            this.groupBox_Matches_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Matches_Num.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Matches_Num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Matches_Num.Location = new System.Drawing.Point(4, 109);
            this.groupBox_Matches_Num.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Matches_Num.Name = "groupBox_Matches_Num";
            this.groupBox_Matches_Num.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Matches_Num.Size = new System.Drawing.Size(188, 50);
            this.groupBox_Matches_Num.TabIndex = 0;
            this.groupBox_Matches_Num.TabStop = false;
            this.groupBox_Matches_Num.Text = "Number of Matches";
            // 
            // label_Matches_Num
            // 
            this.label_Matches_Num.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_Matches_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Matches_Num.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.label_Matches_Num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_Matches_Num.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Matches_Num.Location = new System.Drawing.Point(2, 25);
            this.label_Matches_Num.Margin = new System.Windows.Forms.Padding(2);
            this.label_Matches_Num.Name = "label_Matches_Num";
            this.label_Matches_Num.Padding = new System.Windows.Forms.Padding(2);
            this.label_Matches_Num.Size = new System.Drawing.Size(184, 23);
            this.label_Matches_Num.TabIndex = 0;
            this.label_Matches_Num.Text = "Num";
            // 
            // dataGridView_Resumes
            // 
            this.dataGridView_Resumes.AllowUserToAddRows = false;
            this.dataGridView_Resumes.AllowUserToDeleteRows = false;
            this.dataGridView_Resumes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView_Resumes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Resumes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Resumes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_Resumes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Resumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Resumes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Resumes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Resumes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView_Resumes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.dataGridView_Resumes.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_Resumes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Resumes.MultiSelect = false;
            this.dataGridView_Resumes.Name = "dataGridView_Resumes";
            this.dataGridView_Resumes.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_Resumes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Resumes.RowHeadersVisible = false;
            this.dataGridView_Resumes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView_Resumes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Resumes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Resumes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Resumes.Size = new System.Drawing.Size(295, 328);
            this.dataGridView_Resumes.TabIndex = 0;
            this.dataGridView_Resumes.SelectionChanged += new System.EventHandler(this.dataGridView_Resumes_SelectionChanged);
            // 
            // tableLayoutPanel_Top_CVs
            // 
            this.tableLayoutPanel_Top_CVs.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Top_CVs.ColumnCount = 3;
            this.tableLayoutPanel_Top_CVs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Top_CVs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Top_CVs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Top_CVs.Controls.Add(this.tableLayoutPanel_CV3_Out, 0, 0);
            this.tableLayoutPanel_Top_CVs.Controls.Add(this.tableLayoutPanel_CV1_Out, 0, 0);
            this.tableLayoutPanel_Top_CVs.Controls.Add(this.tableLayoutPanel_CV2_Out, 0, 0);
            this.tableLayoutPanel_Top_CVs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Top_CVs.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_Top_CVs.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Top_CVs.Name = "tableLayoutPanel_Top_CVs";
            this.tableLayoutPanel_Top_CVs.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Top_CVs.RowCount = 1;
            this.tableLayoutPanel_Top_CVs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Top_CVs.Size = new System.Drawing.Size(548, 246);
            this.tableLayoutPanel_Top_CVs.TabIndex = 0;
            // 
            // tableLayoutPanel_CV3_Out
            // 
            this.tableLayoutPanel_CV3_Out.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_CV3_Out.ColumnCount = 3;
            this.tableLayoutPanel_CV3_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel_CV3_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_CV3_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel_CV3_Out.Controls.Add(this.groupBox_Top3, 1, 1);
            this.tableLayoutPanel_CV3_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV3_Out.Location = new System.Drawing.Point(366, 4);
            this.tableLayoutPanel_CV3_Out.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV3_Out.Name = "tableLayoutPanel_CV3_Out";
            this.tableLayoutPanel_CV3_Out.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV3_Out.RowCount = 3;
            this.tableLayoutPanel_CV3_Out.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel_CV3_Out.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_CV3_Out.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel_CV3_Out.Size = new System.Drawing.Size(178, 238);
            this.tableLayoutPanel_CV3_Out.TabIndex = 0;
            // 
            // groupBox_Top3
            // 
            this.groupBox_Top3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.groupBox_Top3.Controls.Add(this.tableLayoutPanel_CV3_In);
            this.groupBox_Top3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Top3.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Top3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Top3.Location = new System.Drawing.Point(17, 21);
            this.groupBox_Top3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Top3.Name = "groupBox_Top3";
            this.groupBox_Top3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Top3.Size = new System.Drawing.Size(143, 194);
            this.groupBox_Top3.TabIndex = 0;
            this.groupBox_Top3.TabStop = false;
            this.groupBox_Top3.Text = "Top 3";
            // 
            // tableLayoutPanel_CV3_In
            // 
            this.tableLayoutPanel_CV3_In.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_CV3_In.ColumnCount = 1;
            this.tableLayoutPanel_CV3_In.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_CV3_In.Controls.Add(this.button_CV3_Open, 0, 2);
            this.tableLayoutPanel_CV3_In.Controls.Add(this.tableLayoutPanel_CV3_Top, 0, 0);
            this.tableLayoutPanel_CV3_In.Controls.Add(this.pictureBox_CV3_Text, 0, 1);
            this.tableLayoutPanel_CV3_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV3_In.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_CV3_In.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV3_In.Name = "tableLayoutPanel_CV3_In";
            this.tableLayoutPanel_CV3_In.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV3_In.RowCount = 3;
            this.tableLayoutPanel_CV3_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CV3_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CV3_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CV3_In.Size = new System.Drawing.Size(139, 167);
            this.tableLayoutPanel_CV3_In.TabIndex = 0;
            // 
            // button_CV3_Open
            // 
            this.button_CV3_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(151)))));
            this.button_CV3_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CV3_Open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CV3_Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CV3_Open.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.button_CV3_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_CV3_Open.Location = new System.Drawing.Point(4, 125);
            this.button_CV3_Open.Margin = new System.Windows.Forms.Padding(2);
            this.button_CV3_Open.Name = "button_CV3_Open";
            this.button_CV3_Open.Padding = new System.Windows.Forms.Padding(2);
            this.button_CV3_Open.Size = new System.Drawing.Size(131, 38);
            this.button_CV3_Open.TabIndex = 10;
            this.button_CV3_Open.Text = "Open CV";
            this.button_CV3_Open.UseVisualStyleBackColor = false;
            this.button_CV3_Open.Click += new System.EventHandler(this.button_CV3_Open_Click);
            // 
            // tableLayoutPanel_CV3_Top
            // 
            this.tableLayoutPanel_CV3_Top.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_CV3_Top.ColumnCount = 2;
            this.tableLayoutPanel_CV3_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CV3_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel_CV3_Top.Controls.Add(this.label_CV3_Score, 0, 0);
            this.tableLayoutPanel_CV3_Top.Controls.Add(this.pictureBox_CV3_Photo, 0, 0);
            this.tableLayoutPanel_CV3_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV3_Top.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_CV3_Top.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV3_Top.Name = "tableLayoutPanel_CV3_Top";
            this.tableLayoutPanel_CV3_Top.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV3_Top.RowCount = 1;
            this.tableLayoutPanel_CV3_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_CV3_Top.Size = new System.Drawing.Size(131, 36);
            this.tableLayoutPanel_CV3_Top.TabIndex = 0;
            // 
            // label_CV3_Score
            // 
            this.label_CV3_Score.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_CV3_Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CV3_Score.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.label_CV3_Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_CV3_Score.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_CV3_Score.Location = new System.Drawing.Point(35, 4);
            this.label_CV3_Score.Margin = new System.Windows.Forms.Padding(2);
            this.label_CV3_Score.Name = "label_CV3_Score";
            this.label_CV3_Score.Padding = new System.Windows.Forms.Padding(2);
            this.label_CV3_Score.Size = new System.Drawing.Size(92, 28);
            this.label_CV3_Score.TabIndex = 0;
            this.label_CV3_Score.Text = "Score: ";
            this.label_CV3_Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_CV3_Photo
            // 
            this.pictureBox_CV3_Photo.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox_CV3_Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CV3_Photo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CV3_Photo.Image")));
            this.pictureBox_CV3_Photo.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_CV3_Photo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV3_Photo.Name = "pictureBox_CV3_Photo";
            this.pictureBox_CV3_Photo.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV3_Photo.Size = new System.Drawing.Size(27, 28);
            this.pictureBox_CV3_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CV3_Photo.TabIndex = 0;
            this.pictureBox_CV3_Photo.TabStop = false;
            // 
            // pictureBox_CV3_Text
            // 
            this.pictureBox_CV3_Text.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox_CV3_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CV3_Text.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CV3_Text.Image")));
            this.pictureBox_CV3_Text.Location = new System.Drawing.Point(4, 44);
            this.pictureBox_CV3_Text.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV3_Text.Name = "pictureBox_CV3_Text";
            this.pictureBox_CV3_Text.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV3_Text.Size = new System.Drawing.Size(131, 77);
            this.pictureBox_CV3_Text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CV3_Text.TabIndex = 0;
            this.pictureBox_CV3_Text.TabStop = false;
            // 
            // tableLayoutPanel_CV1_Out
            // 
            this.tableLayoutPanel_CV1_Out.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_CV1_Out.ColumnCount = 3;
            this.tableLayoutPanel_CV1_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_CV1_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_CV1_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_CV1_Out.Controls.Add(this.groupBox_Top1, 1, 1);
            this.tableLayoutPanel_CV1_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV1_Out.Location = new System.Drawing.Point(185, 4);
            this.tableLayoutPanel_CV1_Out.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV1_Out.Name = "tableLayoutPanel_CV1_Out";
            this.tableLayoutPanel_CV1_Out.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV1_Out.RowCount = 3;
            this.tableLayoutPanel_CV1_Out.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_CV1_Out.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_CV1_Out.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_CV1_Out.Size = new System.Drawing.Size(177, 238);
            this.tableLayoutPanel_CV1_Out.TabIndex = 0;
            // 
            // groupBox_Top1
            // 
            this.groupBox_Top1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.groupBox_Top1.Controls.Add(this.tableLayoutPanel_CV1_In);
            this.groupBox_Top1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Top1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Top1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Top1.Location = new System.Drawing.Point(12, 15);
            this.groupBox_Top1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Top1.Name = "groupBox_Top1";
            this.groupBox_Top1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Top1.Size = new System.Drawing.Size(151, 206);
            this.groupBox_Top1.TabIndex = 0;
            this.groupBox_Top1.TabStop = false;
            this.groupBox_Top1.Text = "Top 1";
            // 
            // tableLayoutPanel_CV1_In
            // 
            this.tableLayoutPanel_CV1_In.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_CV1_In.ColumnCount = 1;
            this.tableLayoutPanel_CV1_In.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_CV1_In.Controls.Add(this.button_CV1_Open, 0, 2);
            this.tableLayoutPanel_CV1_In.Controls.Add(this.tableLayoutPanel_CV1_Top, 0, 0);
            this.tableLayoutPanel_CV1_In.Controls.Add(this.pictureBox_CV1_Text, 0, 1);
            this.tableLayoutPanel_CV1_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV1_In.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_CV1_In.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV1_In.Name = "tableLayoutPanel_CV1_In";
            this.tableLayoutPanel_CV1_In.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV1_In.RowCount = 3;
            this.tableLayoutPanel_CV1_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CV1_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CV1_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CV1_In.Size = new System.Drawing.Size(147, 179);
            this.tableLayoutPanel_CV1_In.TabIndex = 0;
            // 
            // button_CV1_Open
            // 
            this.button_CV1_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(113)))));
            this.button_CV1_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CV1_Open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CV1_Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CV1_Open.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_CV1_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_CV1_Open.Location = new System.Drawing.Point(4, 134);
            this.button_CV1_Open.Margin = new System.Windows.Forms.Padding(2);
            this.button_CV1_Open.Name = "button_CV1_Open";
            this.button_CV1_Open.Padding = new System.Windows.Forms.Padding(2);
            this.button_CV1_Open.Size = new System.Drawing.Size(139, 41);
            this.button_CV1_Open.TabIndex = 8;
            this.button_CV1_Open.Text = "Open CV";
            this.button_CV1_Open.UseVisualStyleBackColor = false;
            this.button_CV1_Open.Click += new System.EventHandler(this.button_CV1_Open_Click);
            // 
            // tableLayoutPanel_CV1_Top
            // 
            this.tableLayoutPanel_CV1_Top.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_CV1_Top.ColumnCount = 2;
            this.tableLayoutPanel_CV1_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CV1_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel_CV1_Top.Controls.Add(this.label_CV1_Score, 0, 0);
            this.tableLayoutPanel_CV1_Top.Controls.Add(this.pictureBox_CV1_Photo, 0, 0);
            this.tableLayoutPanel_CV1_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV1_Top.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_CV1_Top.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV1_Top.Name = "tableLayoutPanel_CV1_Top";
            this.tableLayoutPanel_CV1_Top.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV1_Top.RowCount = 1;
            this.tableLayoutPanel_CV1_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_CV1_Top.Size = new System.Drawing.Size(139, 39);
            this.tableLayoutPanel_CV1_Top.TabIndex = 0;
            // 
            // label_CV1_Score
            // 
            this.label_CV1_Score.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_CV1_Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CV1_Score.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_CV1_Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_CV1_Score.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_CV1_Score.Location = new System.Drawing.Point(37, 4);
            this.label_CV1_Score.Margin = new System.Windows.Forms.Padding(2);
            this.label_CV1_Score.Name = "label_CV1_Score";
            this.label_CV1_Score.Padding = new System.Windows.Forms.Padding(2);
            this.label_CV1_Score.Size = new System.Drawing.Size(98, 31);
            this.label_CV1_Score.TabIndex = 0;
            this.label_CV1_Score.Text = "Score: ";
            this.label_CV1_Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_CV1_Photo
            // 
            this.pictureBox_CV1_Photo.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox_CV1_Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CV1_Photo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CV1_Photo.Image")));
            this.pictureBox_CV1_Photo.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_CV1_Photo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV1_Photo.Name = "pictureBox_CV1_Photo";
            this.pictureBox_CV1_Photo.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV1_Photo.Size = new System.Drawing.Size(29, 31);
            this.pictureBox_CV1_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CV1_Photo.TabIndex = 0;
            this.pictureBox_CV1_Photo.TabStop = false;
            // 
            // pictureBox_CV1_Text
            // 
            this.pictureBox_CV1_Text.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox_CV1_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CV1_Text.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CV1_Text.Image")));
            this.pictureBox_CV1_Text.Location = new System.Drawing.Point(4, 47);
            this.pictureBox_CV1_Text.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV1_Text.Name = "pictureBox_CV1_Text";
            this.pictureBox_CV1_Text.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV1_Text.Size = new System.Drawing.Size(139, 83);
            this.pictureBox_CV1_Text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CV1_Text.TabIndex = 0;
            this.pictureBox_CV1_Text.TabStop = false;
            // 
            // tableLayoutPanel_CV2_Out
            // 
            this.tableLayoutPanel_CV2_Out.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_CV2_Out.ColumnCount = 3;
            this.tableLayoutPanel_CV2_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel_CV2_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_CV2_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel_CV2_Out.Controls.Add(this.groupBox_Top2, 1, 1);
            this.tableLayoutPanel_CV2_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV2_Out.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_CV2_Out.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV2_Out.Name = "tableLayoutPanel_CV2_Out";
            this.tableLayoutPanel_CV2_Out.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV2_Out.RowCount = 3;
            this.tableLayoutPanel_CV2_Out.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel_CV2_Out.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_CV2_Out.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel_CV2_Out.Size = new System.Drawing.Size(177, 238);
            this.tableLayoutPanel_CV2_Out.TabIndex = 0;
            // 
            // groupBox_Top2
            // 
            this.groupBox_Top2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.groupBox_Top2.Controls.Add(this.tableLayoutPanel_CV2_In);
            this.groupBox_Top2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Top2.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Top2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Top2.Location = new System.Drawing.Point(16, 21);
            this.groupBox_Top2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Top2.Name = "groupBox_Top2";
            this.groupBox_Top2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Top2.Size = new System.Drawing.Size(143, 194);
            this.groupBox_Top2.TabIndex = 0;
            this.groupBox_Top2.TabStop = false;
            this.groupBox_Top2.Text = "Top 2";
            // 
            // tableLayoutPanel_CV2_In
            // 
            this.tableLayoutPanel_CV2_In.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_CV2_In.ColumnCount = 1;
            this.tableLayoutPanel_CV2_In.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_CV2_In.Controls.Add(this.button_CV2_Open, 0, 2);
            this.tableLayoutPanel_CV2_In.Controls.Add(this.tableLayoutPanel_CV2_Top, 0, 0);
            this.tableLayoutPanel_CV2_In.Controls.Add(this.pictureBox_CV2_Text, 0, 1);
            this.tableLayoutPanel_CV2_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV2_In.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_CV2_In.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV2_In.Name = "tableLayoutPanel_CV2_In";
            this.tableLayoutPanel_CV2_In.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV2_In.RowCount = 3;
            this.tableLayoutPanel_CV2_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CV2_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CV2_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CV2_In.Size = new System.Drawing.Size(139, 167);
            this.tableLayoutPanel_CV2_In.TabIndex = 0;
            // 
            // button_CV2_Open
            // 
            this.button_CV2_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(151)))));
            this.button_CV2_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CV2_Open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CV2_Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CV2_Open.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.button_CV2_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_CV2_Open.Location = new System.Drawing.Point(4, 125);
            this.button_CV2_Open.Margin = new System.Windows.Forms.Padding(2);
            this.button_CV2_Open.Name = "button_CV2_Open";
            this.button_CV2_Open.Padding = new System.Windows.Forms.Padding(2);
            this.button_CV2_Open.Size = new System.Drawing.Size(131, 38);
            this.button_CV2_Open.TabIndex = 9;
            this.button_CV2_Open.Text = "Open CV";
            this.button_CV2_Open.UseVisualStyleBackColor = false;
            this.button_CV2_Open.Click += new System.EventHandler(this.button_CV2_Open_Click);
            // 
            // tableLayoutPanel_CV2_Top
            // 
            this.tableLayoutPanel_CV2_Top.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_CV2_Top.ColumnCount = 2;
            this.tableLayoutPanel_CV2_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CV2_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel_CV2_Top.Controls.Add(this.label_CV2_Score, 0, 0);
            this.tableLayoutPanel_CV2_Top.Controls.Add(this.pictureBox_CV2_Photo, 0, 0);
            this.tableLayoutPanel_CV2_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV2_Top.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_CV2_Top.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV2_Top.Name = "tableLayoutPanel_CV2_Top";
            this.tableLayoutPanel_CV2_Top.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV2_Top.RowCount = 1;
            this.tableLayoutPanel_CV2_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_CV2_Top.Size = new System.Drawing.Size(131, 36);
            this.tableLayoutPanel_CV2_Top.TabIndex = 0;
            // 
            // label_CV2_Score
            // 
            this.label_CV2_Score.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_CV2_Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CV2_Score.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.label_CV2_Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_CV2_Score.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_CV2_Score.Location = new System.Drawing.Point(35, 4);
            this.label_CV2_Score.Margin = new System.Windows.Forms.Padding(2);
            this.label_CV2_Score.Name = "label_CV2_Score";
            this.label_CV2_Score.Padding = new System.Windows.Forms.Padding(2);
            this.label_CV2_Score.Size = new System.Drawing.Size(92, 28);
            this.label_CV2_Score.TabIndex = 0;
            this.label_CV2_Score.Text = "Score: ";
            this.label_CV2_Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_CV2_Photo
            // 
            this.pictureBox_CV2_Photo.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox_CV2_Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CV2_Photo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CV2_Photo.Image")));
            this.pictureBox_CV2_Photo.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_CV2_Photo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV2_Photo.Name = "pictureBox_CV2_Photo";
            this.pictureBox_CV2_Photo.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV2_Photo.Size = new System.Drawing.Size(27, 28);
            this.pictureBox_CV2_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CV2_Photo.TabIndex = 0;
            this.pictureBox_CV2_Photo.TabStop = false;
            // 
            // pictureBox_CV2_Text
            // 
            this.pictureBox_CV2_Text.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox_CV2_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CV2_Text.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CV2_Text.Image")));
            this.pictureBox_CV2_Text.Location = new System.Drawing.Point(4, 44);
            this.pictureBox_CV2_Text.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV2_Text.Name = "pictureBox_CV2_Text";
            this.pictureBox_CV2_Text.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_CV2_Text.Size = new System.Drawing.Size(131, 77);
            this.pictureBox_CV2_Text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CV2_Text.TabIndex = 0;
            this.pictureBox_CV2_Text.TabStop = false;
            // 
            // tableLayoutPanel_Left
            // 
            this.tableLayoutPanel_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Left.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Left.ColumnCount = 1;
            this.tableLayoutPanel_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Left.Controls.Add(this.groupBox_Sorter, 0, 2);
            this.tableLayoutPanel_Left.Controls.Add(this.groupBox_Keywords, 0, 0);
            this.tableLayoutPanel_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Left.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Left.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_Left.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Left.Name = "tableLayoutPanel_Left";
            this.tableLayoutPanel_Left.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Left.RowCount = 3;
            this.tableLayoutPanel_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_Left.Size = new System.Drawing.Size(276, 629);
            this.tableLayoutPanel_Left.TabIndex = 0;
            this.tableLayoutPanel_Left.Visible = false;
            // 
            // groupBox_Sorter
            // 
            this.groupBox_Sorter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.groupBox_Sorter.Controls.Add(this.tableLayoutPanel_Sorter);
            this.groupBox_Sorter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Sorter.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Sorter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Sorter.Location = new System.Drawing.Point(4, 410);
            this.groupBox_Sorter.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Sorter.Name = "groupBox_Sorter";
            this.groupBox_Sorter.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Sorter.Size = new System.Drawing.Size(268, 215);
            this.groupBox_Sorter.TabIndex = 0;
            this.groupBox_Sorter.TabStop = false;
            this.groupBox_Sorter.Text = "Start Sorting on Resumes";
            // 
            // tableLayoutPanel_Sorter
            // 
            this.tableLayoutPanel_Sorter.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Sorter.ColumnCount = 1;
            this.tableLayoutPanel_Sorter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Sorter.Controls.Add(this.tableLayoutPanel_CV_Sort_Button, 0, 2);
            this.tableLayoutPanel_Sorter.Controls.Add(this.groupBox_Univesity_Option, 0, 0);
            this.tableLayoutPanel_Sorter.Controls.Add(this.groupBox_Get_Size, 0, 1);
            this.tableLayoutPanel_Sorter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Sorter.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Sorter.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Sorter.Name = "tableLayoutPanel_Sorter";
            this.tableLayoutPanel_Sorter.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Sorter.RowCount = 3;
            this.tableLayoutPanel_Sorter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_Sorter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_Sorter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Sorter.Size = new System.Drawing.Size(264, 188);
            this.tableLayoutPanel_Sorter.TabIndex = 0;
            // 
            // tableLayoutPanel_CV_Sort_Button
            // 
            this.tableLayoutPanel_CV_Sort_Button.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_CV_Sort_Button.ColumnCount = 2;
            this.tableLayoutPanel_CV_Sort_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CV_Sort_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CV_Sort_Button.Controls.Add(this.button_Sort, 0, 0);
            this.tableLayoutPanel_CV_Sort_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV_Sort_Button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_CV_Sort_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_CV_Sort_Button.Location = new System.Drawing.Point(4, 141);
            this.tableLayoutPanel_CV_Sort_Button.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV_Sort_Button.Name = "tableLayoutPanel_CV_Sort_Button";
            this.tableLayoutPanel_CV_Sort_Button.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV_Sort_Button.RowCount = 1;
            this.tableLayoutPanel_CV_Sort_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_CV_Sort_Button.Size = new System.Drawing.Size(256, 43);
            this.tableLayoutPanel_CV_Sort_Button.TabIndex = 0;
            // 
            // button_Sort
            // 
            this.button_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(151)))));
            this.button_Sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Sort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Sort.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.button_Sort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_Sort.Location = new System.Drawing.Point(4, 4);
            this.button_Sort.Margin = new System.Windows.Forms.Padding(2);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Padding = new System.Windows.Forms.Padding(2);
            this.button_Sort.Size = new System.Drawing.Size(122, 35);
            this.button_Sort.TabIndex = 7;
            this.button_Sort.Text = "Sort CV";
            this.button_Sort.UseVisualStyleBackColor = false;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // groupBox_Univesity_Option
            // 
            this.groupBox_Univesity_Option.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Univesity_Option.Controls.Add(this.tableLayoutPanel_University_Option);
            this.groupBox_Univesity_Option.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Univesity_Option.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Univesity_Option.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Univesity_Option.Location = new System.Drawing.Point(4, 4);
            this.groupBox_Univesity_Option.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Univesity_Option.Name = "groupBox_Univesity_Option";
            this.groupBox_Univesity_Option.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Univesity_Option.Size = new System.Drawing.Size(256, 69);
            this.groupBox_Univesity_Option.TabIndex = 0;
            this.groupBox_Univesity_Option.TabStop = false;
            this.groupBox_Univesity_Option.Text = "Is University Compulsory?";
            // 
            // tableLayoutPanel_University_Option
            // 
            this.tableLayoutPanel_University_Option.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_University_Option.ColumnCount = 2;
            this.tableLayoutPanel_University_Option.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_University_Option.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_University_Option.Controls.Add(this.radioButton_True, 0, 0);
            this.tableLayoutPanel_University_Option.Controls.Add(this.radioButton_False, 0, 0);
            this.tableLayoutPanel_University_Option.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_University_Option.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_University_Option.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_University_Option.Name = "tableLayoutPanel_University_Option";
            this.tableLayoutPanel_University_Option.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_University_Option.RowCount = 1;
            this.tableLayoutPanel_University_Option.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_University_Option.Size = new System.Drawing.Size(252, 42);
            this.tableLayoutPanel_University_Option.TabIndex = 0;
            // 
            // radioButton_True
            // 
            this.radioButton_True.AutoSize = true;
            this.radioButton_True.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_True.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_True.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.radioButton_True.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.radioButton_True.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton_True.Location = new System.Drawing.Point(128, 4);
            this.radioButton_True.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_True.Name = "radioButton_True";
            this.radioButton_True.Padding = new System.Windows.Forms.Padding(2);
            this.radioButton_True.Size = new System.Drawing.Size(120, 34);
            this.radioButton_True.TabIndex = 5;
            this.radioButton_True.Text = "True";
            this.radioButton_True.UseVisualStyleBackColor = true;
            // 
            // radioButton_False
            // 
            this.radioButton_False.AutoSize = true;
            this.radioButton_False.Checked = true;
            this.radioButton_False.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_False.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_False.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.radioButton_False.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.radioButton_False.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton_False.Location = new System.Drawing.Point(4, 4);
            this.radioButton_False.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_False.Name = "radioButton_False";
            this.radioButton_False.Padding = new System.Windows.Forms.Padding(2);
            this.radioButton_False.Size = new System.Drawing.Size(120, 34);
            this.radioButton_False.TabIndex = 4;
            this.radioButton_False.TabStop = true;
            this.radioButton_False.Text = "False";
            this.radioButton_False.UseVisualStyleBackColor = true;
            // 
            // groupBox_Get_Size
            // 
            this.groupBox_Get_Size.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Get_Size.Controls.Add(this.tableLayoutPanel_CV_Rank);
            this.groupBox_Get_Size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Get_Size.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Get_Size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Get_Size.Location = new System.Drawing.Point(4, 77);
            this.groupBox_Get_Size.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Get_Size.Name = "groupBox_Get_Size";
            this.groupBox_Get_Size.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Get_Size.Size = new System.Drawing.Size(256, 60);
            this.groupBox_Get_Size.TabIndex = 0;
            this.groupBox_Get_Size.TabStop = false;
            this.groupBox_Get_Size.Text = "Number of CVs to Sort";
            // 
            // tableLayoutPanel_CV_Rank
            // 
            this.tableLayoutPanel_CV_Rank.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_CV_Rank.ColumnCount = 3;
            this.tableLayoutPanel_CV_Rank.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_CV_Rank.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_CV_Rank.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_CV_Rank.Controls.Add(this.label_Overline_Max, 2, 0);
            this.tableLayoutPanel_CV_Rank.Controls.Add(this.label_Overline_Min, 0, 0);
            this.tableLayoutPanel_CV_Rank.Controls.Add(this.trackBar_CV_Rank, 1, 0);
            this.tableLayoutPanel_CV_Rank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CV_Rank.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_CV_Rank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_CV_Rank.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_CV_Rank.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV_Rank.Name = "tableLayoutPanel_CV_Rank";
            this.tableLayoutPanel_CV_Rank.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_CV_Rank.RowCount = 1;
            this.tableLayoutPanel_CV_Rank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_CV_Rank.Size = new System.Drawing.Size(252, 33);
            this.tableLayoutPanel_CV_Rank.TabIndex = 0;
            // 
            // label_Overline_Max
            // 
            this.label_Overline_Max.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_Overline_Max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Overline_Max.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Overline_Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_Overline_Max.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Overline_Max.Location = new System.Drawing.Point(214, 4);
            this.label_Overline_Max.Margin = new System.Windows.Forms.Padding(2);
            this.label_Overline_Max.Name = "label_Overline_Max";
            this.label_Overline_Max.Padding = new System.Windows.Forms.Padding(2);
            this.label_Overline_Max.Size = new System.Drawing.Size(34, 25);
            this.label_Overline_Max.TabIndex = 0;
            this.label_Overline_Max.Text = "Max";
            this.label_Overline_Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Overline_Min
            // 
            this.label_Overline_Min.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_Overline_Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Overline_Min.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Overline_Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_Overline_Min.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Overline_Min.Location = new System.Drawing.Point(4, 4);
            this.label_Overline_Min.Margin = new System.Windows.Forms.Padding(2);
            this.label_Overline_Min.Name = "label_Overline_Min";
            this.label_Overline_Min.Padding = new System.Windows.Forms.Padding(2);
            this.label_Overline_Min.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_Overline_Min.Size = new System.Drawing.Size(33, 25);
            this.label_Overline_Min.TabIndex = 0;
            this.label_Overline_Min.Text = "Min";
            this.label_Overline_Min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBar_CV_Rank
            // 
            this.trackBar_CV_Rank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_CV_Rank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_CV_Rank.LargeChange = 2;
            this.trackBar_CV_Rank.Location = new System.Drawing.Point(41, 4);
            this.trackBar_CV_Rank.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar_CV_Rank.Name = "trackBar_CV_Rank";
            this.trackBar_CV_Rank.Size = new System.Drawing.Size(169, 25);
            this.trackBar_CV_Rank.TabIndex = 6;
            this.trackBar_CV_Rank.Tag = "";
            this.trackBar_CV_Rank.Value = 5;
            // 
            // groupBox_Keywords
            // 
            this.groupBox_Keywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.groupBox_Keywords.Controls.Add(this.tableLayoutPanel_Keyword);
            this.groupBox_Keywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Keywords.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Keywords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Keywords.Location = new System.Drawing.Point(4, 4);
            this.groupBox_Keywords.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Keywords.Name = "groupBox_Keywords";
            this.groupBox_Keywords.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Keywords.Size = new System.Drawing.Size(268, 371);
            this.groupBox_Keywords.TabIndex = 0;
            this.groupBox_Keywords.TabStop = false;
            this.groupBox_Keywords.Text = "Enter Keywords";
            // 
            // tableLayoutPanel_Keyword
            // 
            this.tableLayoutPanel_Keyword.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Keyword.ColumnCount = 1;
            this.tableLayoutPanel_Keyword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Keyword.Controls.Add(this.tableLayoutPanel_Keywords, 0, 1);
            this.tableLayoutPanel_Keyword.Controls.Add(this.tableLayoutPanel_Delete, 0, 2);
            this.tableLayoutPanel_Keyword.Controls.Add(this.tableLayoutPanel_Keyword_Input, 0, 0);
            this.tableLayoutPanel_Keyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Keyword.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Keyword.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Keyword.Name = "tableLayoutPanel_Keyword";
            this.tableLayoutPanel_Keyword.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Keyword.RowCount = 3;
            this.tableLayoutPanel_Keyword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Keyword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Keyword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Keyword.Size = new System.Drawing.Size(264, 344);
            this.tableLayoutPanel_Keyword.TabIndex = 0;
            // 
            // tableLayoutPanel_Keywords
            // 
            this.tableLayoutPanel_Keywords.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Keywords.ColumnCount = 1;
            this.tableLayoutPanel_Keywords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Keywords.Controls.Add(this.listBox_Keywords, 0, 0);
            this.tableLayoutPanel_Keywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Keywords.Location = new System.Drawing.Point(4, 55);
            this.tableLayoutPanel_Keywords.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Keywords.Name = "tableLayoutPanel_Keywords";
            this.tableLayoutPanel_Keywords.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Keywords.RowCount = 1;
            this.tableLayoutPanel_Keywords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Keywords.Size = new System.Drawing.Size(256, 234);
            this.tableLayoutPanel_Keywords.TabIndex = 0;
            // 
            // listBox_Keywords
            // 
            this.listBox_Keywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.listBox_Keywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Keywords.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.listBox_Keywords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.listBox_Keywords.FormattingEnabled = true;
            this.listBox_Keywords.ItemHeight = 23;
            this.listBox_Keywords.Location = new System.Drawing.Point(4, 4);
            this.listBox_Keywords.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Keywords.Name = "listBox_Keywords";
            this.listBox_Keywords.Size = new System.Drawing.Size(248, 226);
            this.listBox_Keywords.TabIndex = 2;
            // 
            // tableLayoutPanel_Delete
            // 
            this.tableLayoutPanel_Delete.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Delete.ColumnCount = 2;
            this.tableLayoutPanel_Delete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_Delete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_Delete.Controls.Add(this.button_Delete, 1, 0);
            this.tableLayoutPanel_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Delete.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Delete.Location = new System.Drawing.Point(4, 293);
            this.tableLayoutPanel_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Delete.Name = "tableLayoutPanel_Delete";
            this.tableLayoutPanel_Delete.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Delete.RowCount = 1;
            this.tableLayoutPanel_Delete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Delete.Size = new System.Drawing.Size(256, 47);
            this.tableLayoutPanel_Delete.TabIndex = 0;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.DarkRed;
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Delete.Enabled = false;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Delete.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.button_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_Delete.Location = new System.Drawing.Point(155, 4);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Padding = new System.Windows.Forms.Padding(2);
            this.button_Delete.Size = new System.Drawing.Size(97, 39);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Delete Item";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // tableLayoutPanel_Keyword_Input
            // 
            this.tableLayoutPanel_Keyword_Input.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Keyword_Input.ColumnCount = 2;
            this.tableLayoutPanel_Keyword_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Keyword_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Keyword_Input.Controls.Add(this.pictureBox_Icon_Enter, 0, 0);
            this.tableLayoutPanel_Keyword_Input.Controls.Add(this.textBox_Keyword, 0, 0);
            this.tableLayoutPanel_Keyword_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Keyword_Input.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Keyword_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Keyword_Input.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_Keyword_Input.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Keyword_Input.Name = "tableLayoutPanel_Keyword_Input";
            this.tableLayoutPanel_Keyword_Input.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Keyword_Input.RowCount = 1;
            this.tableLayoutPanel_Keyword_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Keyword_Input.Size = new System.Drawing.Size(256, 47);
            this.tableLayoutPanel_Keyword_Input.TabIndex = 0;
            // 
            // pictureBox_Icon_Enter
            // 
            this.pictureBox_Icon_Enter.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox_Icon_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Icon_Enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Icon_Enter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Icon_Enter.Image")));
            this.pictureBox_Icon_Enter.Location = new System.Drawing.Point(205, 4);
            this.pictureBox_Icon_Enter.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Icon_Enter.MaximumSize = new System.Drawing.Size(47, 39);
            this.pictureBox_Icon_Enter.Name = "pictureBox_Icon_Enter";
            this.pictureBox_Icon_Enter.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_Icon_Enter.Size = new System.Drawing.Size(47, 39);
            this.pictureBox_Icon_Enter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Icon_Enter.TabIndex = 0;
            this.pictureBox_Icon_Enter.TabStop = false;
            this.pictureBox_Icon_Enter.Click += new System.EventHandler(this.Keywords_Add);
            // 
            // textBox_Keyword
            // 
            this.textBox_Keyword.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox_Keyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.textBox_Keyword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_Keyword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Keyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Keyword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Keyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.textBox_Keyword.Location = new System.Drawing.Point(4, 4);
            this.textBox_Keyword.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Keyword.Name = "textBox_Keyword";
            this.textBox_Keyword.Size = new System.Drawing.Size(197, 34);
            this.textBox_Keyword.TabIndex = 1;
            this.textBox_Keyword.TextChanged += new System.EventHandler(this.textBox_Keyword_TextChanged);
            this.textBox_Keyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Keyword_KeyUp);
            // 
            // tableLayoutPanel_Top_Out
            // 
            this.tableLayoutPanel_Top_Out.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Top_Out.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Top_Out.ColumnCount = 1;
            this.tableLayoutPanel_Top_Out.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Top_Out.Controls.Add(this.tableLayoutPanel_Top_In, 0, 0);
            this.tableLayoutPanel_Top_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Top_Out.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Top_Out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Top_Out.Location = new System.Drawing.Point(66, 42);
            this.tableLayoutPanel_Top_Out.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Top_Out.Name = "tableLayoutPanel_Top_Out";
            this.tableLayoutPanel_Top_Out.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Top_Out.RowCount = 1;
            this.tableLayoutPanel_Top_Out.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Top_Out.Size = new System.Drawing.Size(1124, 54);
            this.tableLayoutPanel_Top_Out.TabIndex = 0;
            // 
            // tableLayoutPanel_Top_In
            // 
            this.tableLayoutPanel_Top_In.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Top_In.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Top_In.ColumnCount = 1;
            this.tableLayoutPanel_Top_In.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Top_In.Controls.Add(this.toolStrip_Top, 0, 0);
            this.tableLayoutPanel_Top_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Top_In.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Top_In.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Top_In.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_Top_In.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Top_In.Name = "tableLayoutPanel_Top_In";
            this.tableLayoutPanel_Top_In.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Top_In.RowCount = 1;
            this.tableLayoutPanel_Top_In.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Top_In.Size = new System.Drawing.Size(1116, 46);
            this.tableLayoutPanel_Top_In.TabIndex = 0;
            // 
            // toolStrip_Top
            // 
            this.toolStrip_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.toolStrip_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip_Top.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.toolStrip_Top.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Logo,
            this.toolStripSeparator_Left,
            this.toolStripDropDownButton_File,
            this.toolStripDropDownButton_Help,
            this.toolStripDropDownButton_Account,
            this.toolStripSeparator_Right,
            this.toolStripLabel_Message,
            this.toolStripProgressBar_Long_Process});
            this.toolStrip_Top.Location = new System.Drawing.Point(4, 4);
            this.toolStrip_Top.Margin = new System.Windows.Forms.Padding(2);
            this.toolStrip_Top.Name = "toolStrip_Top";
            this.toolStrip_Top.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip_Top.Size = new System.Drawing.Size(1108, 38);
            this.toolStrip_Top.TabIndex = 0;
            // 
            // toolStripLabel_Logo
            // 
            this.toolStripLabel_Logo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.toolStripLabel_Logo.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel_Logo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabel_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.toolStripLabel_Logo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.toolStripLabel_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripLabel_Logo.Name = "toolStripLabel_Logo";
            this.toolStripLabel_Logo.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripLabel_Logo.Size = new System.Drawing.Size(119, 30);
            this.toolStripLabel_Logo.Text = "CV Analyser";
            this.toolStripLabel_Logo.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            // 
            // toolStripSeparator_Left
            // 
            this.toolStripSeparator_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(187)))), ((int)(((byte)(215)))));
            this.toolStripSeparator_Left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.toolStripSeparator_Left.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripSeparator_Left.Name = "toolStripSeparator_Left";
            this.toolStripSeparator_Left.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripSeparator_Left.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripDropDownButton_File
            // 
            this.toolStripDropDownButton_File.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Open,
            this.ToolStripMenuItem_Close,
            this.ToolStripMenuItem_Save,
            this.ToolStripMenuItem_Clear,
            this.ToolStripMenuItem_Exit});
            this.toolStripDropDownButton_File.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.toolStripDropDownButton_File.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.toolStripDropDownButton_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_File.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripDropDownButton_File.Name = "toolStripDropDownButton_File";
            this.toolStripDropDownButton_File.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripDropDownButton_File.Size = new System.Drawing.Size(53, 30);
            this.toolStripDropDownButton_File.Text = "File";
            this.toolStripDropDownButton_File.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ToolStripMenuItem_Open
            // 
            this.ToolStripMenuItem_Open.BackColor = System.Drawing.Color.SpringGreen;
            this.ToolStripMenuItem_Open.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Open.Name = "ToolStripMenuItem_Open";
            this.ToolStripMenuItem_Open.Size = new System.Drawing.Size(169, 26);
            this.ToolStripMenuItem_Open.Text = "Open Folder";
            this.ToolStripMenuItem_Open.Click += new System.EventHandler(this.ToolStripMenuItem_Open_Click);
            // 
            // ToolStripMenuItem_Close
            // 
            this.ToolStripMenuItem_Close.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Close.Name = "ToolStripMenuItem_Close";
            this.ToolStripMenuItem_Close.Size = new System.Drawing.Size(169, 26);
            this.ToolStripMenuItem_Close.Text = "Close Folder";
            this.ToolStripMenuItem_Close.Click += new System.EventHandler(this.Form_Clear);
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(169, 26);
            this.ToolStripMenuItem_Save.Text = "Save Project";
            this.ToolStripMenuItem_Save.Click += new System.EventHandler(this.ToolStripMenuItem_Save_Click);
            // 
            // ToolStripMenuItem_Clear
            // 
            this.ToolStripMenuItem_Clear.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Clear.Name = "ToolStripMenuItem_Clear";
            this.ToolStripMenuItem_Clear.Size = new System.Drawing.Size(169, 26);
            this.ToolStripMenuItem_Clear.Text = "Clear Window";
            this.ToolStripMenuItem_Clear.Click += new System.EventHandler(this.Form_Clear);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(169, 26);
            this.ToolStripMenuItem_Exit.Text = "Exit";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.Form_Exit);
            // 
            // toolStripDropDownButton_Help
            // 
            this.toolStripDropDownButton_Help.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton_Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Tips,
            this.ToolStripMenuItem_Started,
            this.ToolStripMenuItem_Feedback,
            this.ToolStripMenuItem_Support,
            this.ToolStripMenuItem_About});
            this.toolStripDropDownButton_Help.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.toolStripDropDownButton_Help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.toolStripDropDownButton_Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Help.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripDropDownButton_Help.Name = "toolStripDropDownButton_Help";
            this.toolStripDropDownButton_Help.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripDropDownButton_Help.Size = new System.Drawing.Size(63, 30);
            this.toolStripDropDownButton_Help.Text = "Help";
            // 
            // ToolStripMenuItem_Tips
            // 
            this.ToolStripMenuItem_Tips.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Tips.Name = "ToolStripMenuItem_Tips";
            this.ToolStripMenuItem_Tips.Size = new System.Drawing.Size(144, 26);
            this.ToolStripMenuItem_Tips.Text = "Tips";
            // 
            // ToolStripMenuItem_Started
            // 
            this.ToolStripMenuItem_Started.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Started.Name = "ToolStripMenuItem_Started";
            this.ToolStripMenuItem_Started.Size = new System.Drawing.Size(144, 26);
            this.ToolStripMenuItem_Started.Text = "Started";
            // 
            // ToolStripMenuItem_Feedback
            // 
            this.ToolStripMenuItem_Feedback.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Feedback.Name = "ToolStripMenuItem_Feedback";
            this.ToolStripMenuItem_Feedback.Size = new System.Drawing.Size(144, 26);
            this.ToolStripMenuItem_Feedback.Text = "Feedback";
            this.ToolStripMenuItem_Feedback.Click += new System.EventHandler(this.ToolStripMenuItem_Feedback_Click);
            // 
            // ToolStripMenuItem_Support
            // 
            this.ToolStripMenuItem_Support.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Support.Name = "ToolStripMenuItem_Support";
            this.ToolStripMenuItem_Support.Size = new System.Drawing.Size(144, 26);
            this.ToolStripMenuItem_Support.Text = "Support";
            this.ToolStripMenuItem_Support.Click += new System.EventHandler(this.ToolStripMenuItem_Support_Click);
            // 
            // ToolStripMenuItem_About
            // 
            this.ToolStripMenuItem_About.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
            this.ToolStripMenuItem_About.Size = new System.Drawing.Size(144, 26);
            this.ToolStripMenuItem_About.Text = "About";
            // 
            // toolStripDropDownButton_Account
            // 
            this.toolStripDropDownButton_Account.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton_Account.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton_Account.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton_Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Change_Mail,
            this.ToolStripMenuItem_Change_Phone,
            this.ToolStripMenuItem_Change_Password,
            this.ToolStripMenuItem_Change_Username,
            this.ToolStripMenuItem_Delete_Account});
            this.toolStripDropDownButton_Account.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.toolStripDropDownButton_Account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.toolStripDropDownButton_Account.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_Account.Image")));
            this.toolStripDropDownButton_Account.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Account.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripDropDownButton_Account.Name = "toolStripDropDownButton_Account";
            this.toolStripDropDownButton_Account.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripDropDownButton_Account.Size = new System.Drawing.Size(50, 30);
            this.toolStripDropDownButton_Account.Text = "Account";
            // 
            // ToolStripMenuItem_Change_Mail
            // 
            this.ToolStripMenuItem_Change_Mail.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Change_Mail.Name = "ToolStripMenuItem_Change_Mail";
            this.ToolStripMenuItem_Change_Mail.Size = new System.Drawing.Size(193, 26);
            this.ToolStripMenuItem_Change_Mail.Text = "Change Mail";
            // 
            // ToolStripMenuItem_Change_Phone
            // 
            this.ToolStripMenuItem_Change_Phone.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Change_Phone.Name = "ToolStripMenuItem_Change_Phone";
            this.ToolStripMenuItem_Change_Phone.Size = new System.Drawing.Size(193, 26);
            this.ToolStripMenuItem_Change_Phone.Text = "Change Phone";
            // 
            // ToolStripMenuItem_Change_Password
            // 
            this.ToolStripMenuItem_Change_Password.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Change_Password.Name = "ToolStripMenuItem_Change_Password";
            this.ToolStripMenuItem_Change_Password.Size = new System.Drawing.Size(193, 26);
            this.ToolStripMenuItem_Change_Password.Text = "Change Password";
            // 
            // ToolStripMenuItem_Change_Username
            // 
            this.ToolStripMenuItem_Change_Username.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Change_Username.Name = "ToolStripMenuItem_Change_Username";
            this.ToolStripMenuItem_Change_Username.Size = new System.Drawing.Size(193, 26);
            this.ToolStripMenuItem_Change_Username.Text = "Change Username";
            // 
            // ToolStripMenuItem_Delete_Account
            // 
            this.ToolStripMenuItem_Delete_Account.BackColor = System.Drawing.Color.Red;
            this.ToolStripMenuItem_Delete_Account.Font = new System.Drawing.Font("Segoe UI Light", 7.8F);
            this.ToolStripMenuItem_Delete_Account.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_Delete_Account.Name = "ToolStripMenuItem_Delete_Account";
            this.ToolStripMenuItem_Delete_Account.Size = new System.Drawing.Size(193, 26);
            this.ToolStripMenuItem_Delete_Account.Text = "Delete Account";
            // 
            // toolStripSeparator_Right
            // 
            this.toolStripSeparator_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(187)))), ((int)(((byte)(215)))));
            this.toolStripSeparator_Right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.toolStripSeparator_Right.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripSeparator_Right.Name = "toolStripSeparator_Right";
            this.toolStripSeparator_Right.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripSeparator_Right.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripLabel_Message
            // 
            this.toolStripLabel_Message.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.toolStripLabel_Message.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel_Message.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.toolStripLabel_Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.toolStripLabel_Message.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.toolStripLabel_Message.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripLabel_Message.Name = "toolStripLabel_Message";
            this.toolStripLabel_Message.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripLabel_Message.Size = new System.Drawing.Size(412, 30);
            this.toolStripLabel_Message.Text = "Welcome to CV Analyser. Please open folder for start.";
            this.toolStripLabel_Message.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            // 
            // toolStripProgressBar_Long_Process
            // 
            this.toolStripProgressBar_Long_Process.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar_Long_Process.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripProgressBar_Long_Process.Name = "toolStripProgressBar_Long_Process";
            this.toolStripProgressBar_Long_Process.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripProgressBar_Long_Process.Size = new System.Drawing.Size(154, 30);
            this.toolStripProgressBar_Long_Process.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.AutoClose = false;
            this.openFolderToolStripMenuItem.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(61, 4);
            // 
            // folderBrowserDialog_Open
            // 
            this.folderBrowserDialog_Open.Description = "Select the folder with CVs";
            this.folderBrowserDialog_Open.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog_Open.ShowNewFolderButton = false;
            // 
            // resumeBindingSource
            // 
            this.resumeBindingSource.DataMember = "Resume";
            // 
            // Analyser
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1262, 785);
            this.Controls.Add(this.tableLayoutPanel_Window);
            this.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1275, 825);
            this.Name = "Analyser";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "CV Analyser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Analyser_FormClosing);
            this.Load += new System.EventHandler(this.Analyser_Load);
            this.tableLayoutPanel_Window.ResumeLayout(false);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Right.ResumeLayout(false);
            this.groupBox_Save.ResumeLayout(false);
            this.tableLayoutPanel_Save.ResumeLayout(false);
            this.tableLayoutPanel_Save_Result.ResumeLayout(false);
            this.groupBox_Folder.ResumeLayout(false);
            this.tableLayoutPanel_Folder.ResumeLayout(false);
            this.tableLayoutPanel_Folder.PerformLayout();
            this.groupBox_Analysis.ResumeLayout(false);
            this.tableLayoutPanel_Analysis.ResumeLayout(false);
            this.groupBox_Not_Founded.ResumeLayout(false);
            this.tableLayoutPanel_Analysis_Top.ResumeLayout(false);
            this.tableLayoutPanel_Mid.ResumeLayout(false);
            this.tableLayoutPanel_Resumes_Out.ResumeLayout(false);
            this.groupBox_Resumes.ResumeLayout(false);
            this.tableLayoutPanel_Resumes_In.ResumeLayout(false);
            this.tableLayoutPanel_Resume.ResumeLayout(false);
            this.tableLayoutPanel_CV_Open.ResumeLayout(false);
            this.groupBox_CV_Name.ResumeLayout(false);
            this.groupBox_Mathches_Keywords.ResumeLayout(false);
            this.tableLayoutPanel_Other_Resume_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV_Photo)).EndInit();
            this.groupBox_Matches_Num.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resumes)).EndInit();
            this.tableLayoutPanel_Top_CVs.ResumeLayout(false);
            this.tableLayoutPanel_CV3_Out.ResumeLayout(false);
            this.groupBox_Top3.ResumeLayout(false);
            this.tableLayoutPanel_CV3_In.ResumeLayout(false);
            this.tableLayoutPanel_CV3_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV3_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV3_Text)).EndInit();
            this.tableLayoutPanel_CV1_Out.ResumeLayout(false);
            this.groupBox_Top1.ResumeLayout(false);
            this.tableLayoutPanel_CV1_In.ResumeLayout(false);
            this.tableLayoutPanel_CV1_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV1_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV1_Text)).EndInit();
            this.tableLayoutPanel_CV2_Out.ResumeLayout(false);
            this.groupBox_Top2.ResumeLayout(false);
            this.tableLayoutPanel_CV2_In.ResumeLayout(false);
            this.tableLayoutPanel_CV2_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV2_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CV2_Text)).EndInit();
            this.tableLayoutPanel_Left.ResumeLayout(false);
            this.groupBox_Sorter.ResumeLayout(false);
            this.tableLayoutPanel_Sorter.ResumeLayout(false);
            this.tableLayoutPanel_CV_Sort_Button.ResumeLayout(false);
            this.groupBox_Univesity_Option.ResumeLayout(false);
            this.tableLayoutPanel_University_Option.ResumeLayout(false);
            this.tableLayoutPanel_University_Option.PerformLayout();
            this.groupBox_Get_Size.ResumeLayout(false);
            this.tableLayoutPanel_CV_Rank.ResumeLayout(false);
            this.tableLayoutPanel_CV_Rank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CV_Rank)).EndInit();
            this.groupBox_Keywords.ResumeLayout(false);
            this.tableLayoutPanel_Keyword.ResumeLayout(false);
            this.tableLayoutPanel_Keywords.ResumeLayout(false);
            this.tableLayoutPanel_Delete.ResumeLayout(false);
            this.tableLayoutPanel_Keyword_Input.ResumeLayout(false);
            this.tableLayoutPanel_Keyword_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon_Enter)).EndInit();
            this.tableLayoutPanel_Top_Out.ResumeLayout(false);
            this.tableLayoutPanel_Top_In.ResumeLayout(false);
            this.tableLayoutPanel_Top_In.PerformLayout();
            this.toolStrip_Top.ResumeLayout(false);
            this.toolStrip_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resumeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_Window;
        private TableLayoutPanel tableLayoutPanel_Main;
        private TableLayoutPanel tableLayoutPanel_Left;
        private TableLayoutPanel tableLayoutPanel_Mid;
        private TableLayoutPanel tableLayoutPanel_Right;
        private TableLayoutPanel tableLayoutPanel_Top_Out;
        private TableLayoutPanel tableLayoutPanel_Top_In;
        private TableLayoutPanel tableLayoutPanel_Top_CVs;
        private TableLayoutPanel tableLayoutPanel_CV1_Out;
        private TableLayoutPanel tableLayoutPanel_CV1_In;
        private TableLayoutPanel tableLayoutPanel_CV1_Top;
        private TableLayoutPanel tableLayoutPanel_CV2_Out;
        private TableLayoutPanel tableLayoutPanel_CV2_In;
        private TableLayoutPanel tableLayoutPanel_CV2_Top;
        private TableLayoutPanel tableLayoutPanel_CV3_Out;
        private TableLayoutPanel tableLayoutPanel_CV3_In;
        private TableLayoutPanel tableLayoutPanel_CV3_Top;
        private TableLayoutPanel tableLayoutPanel_Keyword;
        private TableLayoutPanel tableLayoutPanel_Keyword_Input;
        private TableLayoutPanel tableLayoutPanel_Delete;
        private TableLayoutPanel tableLayoutPanel_University_Option;
        private TableLayoutPanel tableLayoutPanel_Sorter;
        private TableLayoutPanel tableLayoutPanel_CV_Sort_Button;
        private TableLayoutPanel tableLayoutPanel_Keywords;
        private TableLayoutPanel tableLayoutPanel_Resume;
        private TableLayoutPanel tableLayoutPanel_Resumes_Out;
        private TableLayoutPanel tableLayoutPanel_Resumes_In;
        private TableLayoutPanel tableLayoutPanel_CV_Rank;
        private TableLayoutPanel tableLayoutPanel_CV_Open;
        private TableLayoutPanel tableLayoutPanel_Other_Resume_Top;
        private TableLayoutPanel tableLayoutPanel_Analysis_Top;
        private TableLayoutPanel tableLayoutPanel_Folder;
        private TableLayoutPanel tableLayoutPanel_Analysis;
        private TableLayoutPanel tableLayoutPanel_Save;
        private TableLayoutPanel tableLayoutPanel_Save_Result;

        private ToolStrip toolStrip_Top;
        private ToolStripLabel toolStripLabel_Logo;
        private ToolStripButton toolStripButton_Open_File;
        private ToolStripSeparator toolStripSeparator_Left;
        private ToolStripDropDownMenu openFolderToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton_File;
        private ToolStripDropDownButton toolStripDropDownButton_Help;
        private ToolStripDropDownButton toolStripDropDownButton_Account;
        private ToolStripMenuItem ToolStripMenuItem_Open;
        private ToolStripMenuItem ToolStripMenuItem_Close;
        private ToolStripMenuItem ToolStripMenuItem_Save;
        private ToolStripMenuItem ToolStripMenuItem_Clear;
        private ToolStripMenuItem ToolStripMenuItem_Exit;
        private ToolStripMenuItem ToolStripMenuItem_Tips;
        private ToolStripMenuItem ToolStripMenuItem_Started;
        private ToolStripMenuItem ToolStripMenuItem_Feedback;
        private ToolStripMenuItem ToolStripMenuItem_Support;
        private ToolStripMenuItem ToolStripMenuItem_About;
        private ToolStripMenuItem ToolStripMenuItem_Change_Mail;
        private ToolStripMenuItem ToolStripMenuItem_Change_Phone;
        private ToolStripMenuItem ToolStripMenuItem_Change_Password;
        private ToolStripMenuItem ToolStripMenuItem_Change_Username;
        private ToolStripMenuItem ToolStripMenuItem_Delete_Account;

        private GroupBox groupBox_Keywords;
        private GroupBox groupBox_Analysis;
        private GroupBox groupBox_Top1;
        private GroupBox groupBox_Top2;
        private GroupBox groupBox_Top3;
        private GroupBox groupBox_Save;
        private GroupBox groupBox_Sorter;
        private GroupBox groupBox_Resumes;
        private GroupBox groupBox_Get_Size;
        private GroupBox groupBox_Univesity_Option;
        private GroupBox groupBox_Mathches_Keywords;
        private GroupBox groupBox_Matches_Num;
        private GroupBox groupBox_Not_Founded;
        private GroupBox groupBox_CV_Name;
        private GroupBox groupBox_Folder;

        private Label label_Overline_Max;
        private Label label_Overline_Min;
        private Label label_CV_Score;
        private Label label_CV1_Score;
        private Label label_CV2_Score;
        private Label label_CV3_Score;
        private Label label_Matches_Num;
        private Label label_Checked_CVs_Num;
        private Label label_Eliminated_CVs_Num;
        private Label label_CV_Name;
        private Label label_Mismatched_Keywords_Num;
        private Label label_Mismatched_Keywords;
        private Label label_Checked_CVs;
        private Label label_Eliminated_CVs;

        private PictureBox pictureBox_Icon_Enter;
        private PictureBox pictureBox_CV_Photo;
        private PictureBox pictureBox_CV1_Photo;
        private PictureBox pictureBox_CV2_Photo;
        private PictureBox pictureBox_CV3_Photo;
        private PictureBox pictureBox_CV1_Text;
        private PictureBox pictureBox_CV2_Text;
        private PictureBox pictureBox_CV3_Text;
        private Button button_Delete;
        private Button button_Sort;
        private Button button_CV_Open;
        private Button button_CV1_Open;
        private Button button_CV2_Open;
        private Button button_CV3_Open;
        private Button button_Save;
        private ListBox listBox_Keywords;
        private ListBox listBox_Mathces_Keywords;
        private ListBox listBox_Mismatched_Keywords;
        private TextBox textBox_Keyword;
        private TextBox textBox_Folder_Name;
        private RadioButton radioButton_True;
        private RadioButton radioButton_False;
        private TrackBar trackBar_CV_Rank;
        private DataGridView dataGridView_Resumes;
        private FolderBrowserDialog folderBrowserDialog_Open;
        private ToolStripSeparator toolStripSeparator_Right;
        private ToolStripLabel toolStripLabel_Message;
        private ToolStripProgressBar toolStripProgressBar_Long_Process;
        private BindingSource resumeBindingSource;
    }
}
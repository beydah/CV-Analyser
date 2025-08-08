using System.Drawing;
using System.Windows.Forms;

namespace CV_Analyser.Interface.Password
{
    partial class Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            this.tableLayoutPanel_Window = new System.Windows.Forms.TableLayoutPanel();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.groupBox_Panel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Verification_Code = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Verification_Code = new System.Windows.Forms.TableLayoutPanel();
            this.button_Verification_Code = new System.Windows.Forms.Button();
            this.maskedTextBox_Code = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_Mail_Phone = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Mail_Phone = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Mail_Phone = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Header = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.label_Header = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Send_Code = new System.Windows.Forms.TableLayoutPanel();
            this.button_Send_Code = new System.Windows.Forms.Button();
            this.groupBox_Password = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Password = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Eye = new System.Windows.Forms.PictureBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.groupBox_Password_Again = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Password_Again = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Eye_Again = new System.Windows.Forms.PictureBox();
            this.textBox_Password_Again = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Change = new System.Windows.Forms.TableLayoutPanel();
            this.button_Change = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Window.SuspendLayout();
            this.groupBox_Panel.SuspendLayout();
            this.tableLayoutPanel_Panel.SuspendLayout();
            this.groupBox_Verification_Code.SuspendLayout();
            this.tableLayoutPanel_Verification_Code.SuspendLayout();
            this.groupBox_Mail_Phone.SuspendLayout();
            this.tableLayoutPanel_Mail_Phone.SuspendLayout();
            this.tableLayoutPanel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.tableLayoutPanel_Send_Code.SuspendLayout();
            this.groupBox_Password.SuspendLayout();
            this.tableLayoutPanel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eye)).BeginInit();
            this.groupBox_Password_Again.SuspendLayout();
            this.tableLayoutPanel_Password_Again.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eye_Again)).BeginInit();
            this.tableLayoutPanel_Change.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Window
            // 
            this.tableLayoutPanel_Window.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Window.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Window.ColumnCount = 5;
            this.tableLayoutPanel_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanel_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Window.Controls.Add(this.label_Welcome, 1, 1);
            this.tableLayoutPanel_Window.Controls.Add(this.groupBox_Panel, 3, 1);
            this.tableLayoutPanel_Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Window.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Window.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel_Window.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Window.Name = "tableLayoutPanel_Window";
            this.tableLayoutPanel_Window.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Window.RowCount = 3;
            this.tableLayoutPanel_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Window.Size = new System.Drawing.Size(1258, 779);
            this.tableLayoutPanel_Window.TabIndex = 0;
            // 
            // label_Welcome
            // 
            this.label_Welcome.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_Welcome.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.label_Welcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Welcome.Location = new System.Drawing.Point(66, 42);
            this.label_Welcome.Margin = new System.Windows.Forms.Padding(2);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Padding = new System.Windows.Forms.Padding(2);
            this.label_Welcome.Size = new System.Drawing.Size(472, 693);
            this.label_Welcome.TabIndex = 0;
            this.label_Welcome.Text = "CV Analyser\r\nYour Shortcut to Top Talent";
            this.label_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_Panel
            // 
            this.groupBox_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.groupBox_Panel.Controls.Add(this.tableLayoutPanel_Panel);
            this.groupBox_Panel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox_Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.groupBox_Panel.Location = new System.Drawing.Point(730, 42);
            this.groupBox_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Panel.Name = "groupBox_Panel";
            this.groupBox_Panel.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Panel.Size = new System.Drawing.Size(459, 693);
            this.groupBox_Panel.TabIndex = 0;
            this.groupBox_Panel.TabStop = false;
            // 
            // tableLayoutPanel_Panel
            // 
            this.tableLayoutPanel_Panel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Panel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Panel.ColumnCount = 3;
            this.tableLayoutPanel_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Panel.Controls.Add(this.groupBox_Verification_Code, 1, 3);
            this.tableLayoutPanel_Panel.Controls.Add(this.groupBox_Mail_Phone, 1, 1);
            this.tableLayoutPanel_Panel.Controls.Add(this.tableLayoutPanel_Header, 1, 0);
            this.tableLayoutPanel_Panel.Controls.Add(this.tableLayoutPanel_Send_Code, 1, 2);
            this.tableLayoutPanel_Panel.Controls.Add(this.groupBox_Password, 1, 4);
            this.tableLayoutPanel_Panel.Controls.Add(this.groupBox_Password_Again, 1, 5);
            this.tableLayoutPanel_Panel.Controls.Add(this.tableLayoutPanel_Change, 1, 6);
            this.tableLayoutPanel_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Panel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Panel.Location = new System.Drawing.Point(2, 38);
            this.tableLayoutPanel_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Panel.Name = "tableLayoutPanel_Panel";
            this.tableLayoutPanel_Panel.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Panel.RowCount = 8;
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.Size = new System.Drawing.Size(455, 653);
            this.tableLayoutPanel_Panel.TabIndex = 0;
            // 
            // groupBox_Verification_Code
            // 
            this.groupBox_Verification_Code.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Verification_Code.Controls.Add(this.tableLayoutPanel_Verification_Code);
            this.groupBox_Verification_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Verification_Code.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Verification_Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Verification_Code.Location = new System.Drawing.Point(26, 209);
            this.groupBox_Verification_Code.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Verification_Code.Name = "groupBox_Verification_Code";
            this.groupBox_Verification_Code.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Verification_Code.Size = new System.Drawing.Size(401, 71);
            this.groupBox_Verification_Code.TabIndex = 0;
            this.groupBox_Verification_Code.TabStop = false;
            this.groupBox_Verification_Code.Text = "Enter Code";
            // 
            // tableLayoutPanel_Verification_Code
            // 
            this.tableLayoutPanel_Verification_Code.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Verification_Code.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Verification_Code.ColumnCount = 3;
            this.tableLayoutPanel_Verification_Code.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_Verification_Code.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel_Verification_Code.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Verification_Code.Controls.Add(this.button_Verification_Code, 0, 0);
            this.tableLayoutPanel_Verification_Code.Controls.Add(this.maskedTextBox_Code, 0, 0);
            this.tableLayoutPanel_Verification_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Verification_Code.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Verification_Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Verification_Code.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Verification_Code.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Verification_Code.Name = "tableLayoutPanel_Verification_Code";
            this.tableLayoutPanel_Verification_Code.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Verification_Code.RowCount = 1;
            this.tableLayoutPanel_Verification_Code.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Verification_Code.Size = new System.Drawing.Size(397, 44);
            this.tableLayoutPanel_Verification_Code.TabIndex = 0;
            // 
            // button_Verification_Code
            // 
            this.button_Verification_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(113)))));
            this.button_Verification_Code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Verification_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Verification_Code.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Verification_Code.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Verification_Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_Verification_Code.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Verification_Code.Location = new System.Drawing.Point(154, 4);
            this.button_Verification_Code.Margin = new System.Windows.Forms.Padding(2);
            this.button_Verification_Code.Name = "button_Verification_Code";
            this.button_Verification_Code.Padding = new System.Windows.Forms.Padding(2);
            this.button_Verification_Code.Size = new System.Drawing.Size(196, 36);
            this.button_Verification_Code.TabIndex = 7;
            this.button_Verification_Code.Text = "Verification Code";
            this.button_Verification_Code.UseVisualStyleBackColor = false;
            this.button_Verification_Code.Click += new System.EventHandler(this.button_Verification_Code_Click);
            // 
            // maskedTextBox_Code
            // 
            this.maskedTextBox_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.maskedTextBox_Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskedTextBox_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox_Code.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maskedTextBox_Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.maskedTextBox_Code.Location = new System.Drawing.Point(4, 4);
            this.maskedTextBox_Code.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox_Code.Mask = "000000";
            this.maskedTextBox_Code.Name = "maskedTextBox_Code";
            this.maskedTextBox_Code.Size = new System.Drawing.Size(146, 34);
            this.maskedTextBox_Code.TabIndex = 1;
            this.maskedTextBox_Code.ValidatingType = typeof(int);
            // 
            // groupBox_Mail_Phone
            // 
            this.groupBox_Mail_Phone.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Mail_Phone.Controls.Add(this.tableLayoutPanel_Mail_Phone);
            this.groupBox_Mail_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Mail_Phone.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Mail_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Mail_Phone.Location = new System.Drawing.Point(26, 79);
            this.groupBox_Mail_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Mail_Phone.Name = "groupBox_Mail_Phone";
            this.groupBox_Mail_Phone.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Mail_Phone.Size = new System.Drawing.Size(401, 71);
            this.groupBox_Mail_Phone.TabIndex = 0;
            this.groupBox_Mail_Phone.TabStop = false;
            this.groupBox_Mail_Phone.Text = "Enter Your E-Mail or Phone Number";
            // 
            // tableLayoutPanel_Mail_Phone
            // 
            this.tableLayoutPanel_Mail_Phone.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Mail_Phone.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Mail_Phone.ColumnCount = 2;
            this.tableLayoutPanel_Mail_Phone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel_Mail_Phone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Mail_Phone.Controls.Add(this.textBox_Mail_Phone, 0, 0);
            this.tableLayoutPanel_Mail_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Mail_Phone.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Mail_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Mail_Phone.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Mail_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Mail_Phone.Name = "tableLayoutPanel_Mail_Phone";
            this.tableLayoutPanel_Mail_Phone.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Mail_Phone.RowCount = 1;
            this.tableLayoutPanel_Mail_Phone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Mail_Phone.Size = new System.Drawing.Size(397, 44);
            this.tableLayoutPanel_Mail_Phone.TabIndex = 0;
            // 
            // textBox_Mail_Phone
            // 
            this.textBox_Mail_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.textBox_Mail_Phone.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_Mail_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Mail_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Mail_Phone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Mail_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.textBox_Mail_Phone.Location = new System.Drawing.Point(4, 4);
            this.textBox_Mail_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Mail_Phone.Name = "textBox_Mail_Phone";
            this.textBox_Mail_Phone.Size = new System.Drawing.Size(346, 34);
            this.textBox_Mail_Phone.TabIndex = 1;
            this.textBox_Mail_Phone.TextChanged += new System.EventHandler(this.textBox_Mail_Phone_TextChanged);
            // 
            // tableLayoutPanel_Header
            // 
            this.tableLayoutPanel_Header.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Header.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Header.ColumnCount = 2;
            this.tableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_Header.Controls.Add(this.pictureBox_Back, 0, 0);
            this.tableLayoutPanel_Header.Controls.Add(this.label_Header, 1, 0);
            this.tableLayoutPanel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Header.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Header.Location = new System.Drawing.Point(26, 4);
            this.tableLayoutPanel_Header.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Header.Name = "tableLayoutPanel_Header";
            this.tableLayoutPanel_Header.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Header.RowCount = 1;
            this.tableLayoutPanel_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Header.Size = new System.Drawing.Size(401, 71);
            this.tableLayoutPanel_Header.TabIndex = 2;
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Back.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Back.Image")));
            this.pictureBox_Back.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_Back.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_Back.Size = new System.Drawing.Size(46, 63);
            this.pictureBox_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Back.TabIndex = 2;
            this.pictureBox_Back.TabStop = false;
            this.pictureBox_Back.Click += new System.EventHandler(this.pictureBox_Back_Click);
            // 
            // label_Header
            // 
            this.label_Header.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Header.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_Header.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Header.Location = new System.Drawing.Point(54, 4);
            this.label_Header.Margin = new System.Windows.Forms.Padding(2);
            this.label_Header.Name = "label_Header";
            this.label_Header.Padding = new System.Windows.Forms.Padding(2);
            this.label_Header.Size = new System.Drawing.Size(343, 63);
            this.label_Header.TabIndex = 1;
            this.label_Header.Text = "Change Password";
            this.label_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel_Send_Code
            // 
            this.tableLayoutPanel_Send_Code.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Send_Code.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Send_Code.ColumnCount = 2;
            this.tableLayoutPanel_Send_Code.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_Send_Code.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_Send_Code.Controls.Add(this.button_Send_Code, 0, 0);
            this.tableLayoutPanel_Send_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Send_Code.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Send_Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Send_Code.Location = new System.Drawing.Point(26, 154);
            this.tableLayoutPanel_Send_Code.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Send_Code.Name = "tableLayoutPanel_Send_Code";
            this.tableLayoutPanel_Send_Code.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Send_Code.RowCount = 1;
            this.tableLayoutPanel_Send_Code.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Send_Code.Size = new System.Drawing.Size(401, 51);
            this.tableLayoutPanel_Send_Code.TabIndex = 3;
            // 
            // button_Send_Code
            // 
            this.button_Send_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(151)))));
            this.button_Send_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Send_Code.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Send_Code.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Send_Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_Send_Code.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Send_Code.Location = new System.Drawing.Point(4, 4);
            this.button_Send_Code.Margin = new System.Windows.Forms.Padding(2);
            this.button_Send_Code.Name = "button_Send_Code";
            this.button_Send_Code.Padding = new System.Windows.Forms.Padding(2);
            this.button_Send_Code.Size = new System.Drawing.Size(146, 43);
            this.button_Send_Code.TabIndex = 6;
            this.button_Send_Code.Text = "Send Code";
            this.button_Send_Code.UseVisualStyleBackColor = false;
            this.button_Send_Code.Click += new System.EventHandler(this.button_Send_Code_Click);
            // 
            // groupBox_Password
            // 
            this.groupBox_Password.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Password.Controls.Add(this.tableLayoutPanel_Password);
            this.groupBox_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Password.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Password.Location = new System.Drawing.Point(26, 284);
            this.groupBox_Password.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Password.Name = "groupBox_Password";
            this.groupBox_Password.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Password.Size = new System.Drawing.Size(401, 71);
            this.groupBox_Password.TabIndex = 0;
            this.groupBox_Password.TabStop = false;
            this.groupBox_Password.Text = "Enter New Password";
            // 
            // tableLayoutPanel_Password
            // 
            this.tableLayoutPanel_Password.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Password.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Password.ColumnCount = 3;
            this.tableLayoutPanel_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_Password.Controls.Add(this.pictureBox_Eye, 0, 0);
            this.tableLayoutPanel_Password.Controls.Add(this.textBox_Password, 0, 0);
            this.tableLayoutPanel_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Password.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Password.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Password.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Password.Name = "tableLayoutPanel_Password";
            this.tableLayoutPanel_Password.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Password.RowCount = 1;
            this.tableLayoutPanel_Password.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Password.Size = new System.Drawing.Size(397, 44);
            this.tableLayoutPanel_Password.TabIndex = 0;
            // 
            // pictureBox_Eye
            // 
            this.pictureBox_Eye.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox_Eye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Eye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Eye.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Eye.Image")));
            this.pictureBox_Eye.Location = new System.Drawing.Point(354, 4);
            this.pictureBox_Eye.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Eye.Name = "pictureBox_Eye";
            this.pictureBox_Eye.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_Eye.Size = new System.Drawing.Size(21, 36);
            this.pictureBox_Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Eye.TabIndex = 2;
            this.pictureBox_Eye.TabStop = false;
            this.pictureBox_Eye.Click += new System.EventHandler(this.pictureBox_Eye_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.textBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.textBox_Password.Location = new System.Drawing.Point(4, 4);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(346, 34);
            this.textBox_Password.TabIndex = 4;
            // 
            // groupBox_Password_Again
            // 
            this.groupBox_Password_Again.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Password_Again.Controls.Add(this.tableLayoutPanel_Password_Again);
            this.groupBox_Password_Again.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Password_Again.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Password_Again.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Password_Again.Location = new System.Drawing.Point(26, 359);
            this.groupBox_Password_Again.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Password_Again.Name = "groupBox_Password_Again";
            this.groupBox_Password_Again.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Password_Again.Size = new System.Drawing.Size(401, 71);
            this.groupBox_Password_Again.TabIndex = 0;
            this.groupBox_Password_Again.TabStop = false;
            this.groupBox_Password_Again.Text = "Password Again";
            // 
            // tableLayoutPanel_Password_Again
            // 
            this.tableLayoutPanel_Password_Again.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Password_Again.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Password_Again.ColumnCount = 3;
            this.tableLayoutPanel_Password_Again.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel_Password_Again.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_Password_Again.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Password_Again.Controls.Add(this.pictureBox_Eye_Again, 0, 0);
            this.tableLayoutPanel_Password_Again.Controls.Add(this.textBox_Password_Again, 0, 0);
            this.tableLayoutPanel_Password_Again.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Password_Again.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Password_Again.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Password_Again.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Password_Again.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Password_Again.Name = "tableLayoutPanel_Password_Again";
            this.tableLayoutPanel_Password_Again.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Password_Again.RowCount = 1;
            this.tableLayoutPanel_Password_Again.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Password_Again.Size = new System.Drawing.Size(397, 44);
            this.tableLayoutPanel_Password_Again.TabIndex = 0;
            // 
            // pictureBox_Eye_Again
            // 
            this.pictureBox_Eye_Again.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox_Eye_Again.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Eye_Again.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Eye_Again.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Eye_Again.Image")));
            this.pictureBox_Eye_Again.Location = new System.Drawing.Point(354, 4);
            this.pictureBox_Eye_Again.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Eye_Again.Name = "pictureBox_Eye_Again";
            this.pictureBox_Eye_Again.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_Eye_Again.Size = new System.Drawing.Size(21, 36);
            this.pictureBox_Eye_Again.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Eye_Again.TabIndex = 2;
            this.pictureBox_Eye_Again.TabStop = false;
            this.pictureBox_Eye_Again.Click += new System.EventHandler(this.pictureBox_Eye_Again_Click);
            // 
            // textBox_Password_Again
            // 
            this.textBox_Password_Again.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.textBox_Password_Again.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Password_Again.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Password_Again.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Password_Again.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.textBox_Password_Again.Location = new System.Drawing.Point(4, 4);
            this.textBox_Password_Again.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Password_Again.Name = "textBox_Password_Again";
            this.textBox_Password_Again.PasswordChar = '*';
            this.textBox_Password_Again.Size = new System.Drawing.Size(346, 34);
            this.textBox_Password_Again.TabIndex = 5;
            // 
            // tableLayoutPanel_Change
            // 
            this.tableLayoutPanel_Change.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Change.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Change.ColumnCount = 2;
            this.tableLayoutPanel_Change.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel_Change.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_Change.Controls.Add(this.button_Change, 0, 0);
            this.tableLayoutPanel_Change.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Change.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Change.Location = new System.Drawing.Point(26, 434);
            this.tableLayoutPanel_Change.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Change.Name = "tableLayoutPanel_Change";
            this.tableLayoutPanel_Change.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Change.RowCount = 1;
            this.tableLayoutPanel_Change.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Change.Size = new System.Drawing.Size(401, 71);
            this.tableLayoutPanel_Change.TabIndex = 0;
            // 
            // button_Change
            // 
            this.button_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.button_Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Change.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Change.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_Change.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Change.Location = new System.Drawing.Point(4, 4);
            this.button_Change.Margin = new System.Windows.Forms.Padding(2);
            this.button_Change.Name = "button_Change";
            this.button_Change.Padding = new System.Windows.Forms.Padding(2);
            this.button_Change.Size = new System.Drawing.Size(196, 63);
            this.button_Change.TabIndex = 6;
            this.button_Change.Text = "Change Password";
            this.button_Change.UseVisualStyleBackColor = false;
            // 
            // Password
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1262, 783);
            this.Controls.Add(this.tableLayoutPanel_Window);
            this.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.MinimumSize = new System.Drawing.Size(1275, 825);
            this.Name = "Password";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "CV Analyser Change Password";
            this.Load += new System.EventHandler(this.Password_Load);
            this.tableLayoutPanel_Window.ResumeLayout(false);
            this.groupBox_Panel.ResumeLayout(false);
            this.tableLayoutPanel_Panel.ResumeLayout(false);
            this.groupBox_Verification_Code.ResumeLayout(false);
            this.tableLayoutPanel_Verification_Code.ResumeLayout(false);
            this.tableLayoutPanel_Verification_Code.PerformLayout();
            this.groupBox_Mail_Phone.ResumeLayout(false);
            this.tableLayoutPanel_Mail_Phone.ResumeLayout(false);
            this.tableLayoutPanel_Mail_Phone.PerformLayout();
            this.tableLayoutPanel_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.tableLayoutPanel_Send_Code.ResumeLayout(false);
            this.groupBox_Password.ResumeLayout(false);
            this.tableLayoutPanel_Password.ResumeLayout(false);
            this.tableLayoutPanel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eye)).EndInit();
            this.groupBox_Password_Again.ResumeLayout(false);
            this.tableLayoutPanel_Password_Again.ResumeLayout(false);
            this.tableLayoutPanel_Password_Again.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eye_Again)).EndInit();
            this.tableLayoutPanel_Change.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_Window;
        private TableLayoutPanel tableLayoutPanel_Panel;
        private TableLayoutPanel tableLayoutPanel_Header;
        private TableLayoutPanel tableLayoutPanel_Mail_Phone;
        private TableLayoutPanel tableLayoutPanel_Send_Code;
        private TableLayoutPanel tableLayoutPanel_Verification_Code;
        private TableLayoutPanel tableLayoutPanel_Password;
        private TableLayoutPanel tableLayoutPanel_Password_Again;
        private TableLayoutPanel tableLayoutPanel_Change;
        private GroupBox groupBox_Panel;
        private GroupBox groupBox_Mail_Phone;
        private GroupBox groupBox_Verification_Code;
        private GroupBox groupBox_Password;
        private GroupBox groupBox_Password_Again;
        private TextBox textBox_Mail_Phone;
        private TextBox textBox_Password;
        private TextBox textBox_Password_Again;
        private MaskedTextBox maskedTextBox_Code;
        private Button button_Change;
        private Button button_Send_Code;
        private Button button_Verification_Code;
        private PictureBox pictureBox_Eye;
        private PictureBox pictureBox_Eye_Again;
        private PictureBox pictureBox_Back;
        private Label label_Welcome;
        private Label label_Header;
    }
}
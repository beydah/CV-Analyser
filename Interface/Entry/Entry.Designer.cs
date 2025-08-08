using System.Drawing;
using System.Windows.Forms;

namespace CV_Analyser.Interface.Entry
{
    partial class Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.tableLayoutPanel_Window = new System.Windows.Forms.TableLayoutPanel();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.groupBox_Panel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel_Password = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Sign = new System.Windows.Forms.Button();
            this.checkBox_Remember = new System.Windows.Forms.CheckBox();
            this.groupBox_Password = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Password = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Eye = new System.Windows.Forms.PictureBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.groupBox_Username_Mail_Phone = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Username_Mail_Phone = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Username_Mail_Phone = new System.Windows.Forms.TextBox();
            this.label_Head = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Window.SuspendLayout();
            this.groupBox_Panel.SuspendLayout();
            this.tableLayoutPanel_Panel.SuspendLayout();
            this.tableLayoutPanel_Buttons.SuspendLayout();
            this.groupBox_Password.SuspendLayout();
            this.tableLayoutPanel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eye)).BeginInit();
            this.groupBox_Username_Mail_Phone.SuspendLayout();
            this.tableLayoutPanel_Username_Mail_Phone.SuspendLayout();
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
            this.tableLayoutPanel_Window.Size = new System.Drawing.Size(1258, 781);
            this.tableLayoutPanel_Window.TabIndex = 0;
            // 
            // label_Welcome
            // 
            this.label_Welcome.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.label_Welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Welcome.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.label_Welcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Welcome.Location = new System.Drawing.Point(66, 42);
            this.label_Welcome.Margin = new System.Windows.Forms.Padding(2);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Padding = new System.Windows.Forms.Padding(2);
            this.label_Welcome.Size = new System.Drawing.Size(472, 695);
            this.label_Welcome.TabIndex = 0;
            this.label_Welcome.Text = "CV Analyser\r\nHire Smart Hire Fast";
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
            this.groupBox_Panel.Size = new System.Drawing.Size(459, 695);
            this.groupBox_Panel.TabIndex = 0;
            this.groupBox_Panel.TabStop = false;
            // 
            // tableLayoutPanel_Panel
            // 
            this.tableLayoutPanel_Panel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Panel.ColumnCount = 3;
            this.tableLayoutPanel_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Panel.Controls.Add(this.linkLabel_Password, 1, 5);
            this.tableLayoutPanel_Panel.Controls.Add(this.tableLayoutPanel_Buttons, 1, 4);
            this.tableLayoutPanel_Panel.Controls.Add(this.checkBox_Remember, 1, 3);
            this.tableLayoutPanel_Panel.Controls.Add(this.groupBox_Password, 1, 2);
            this.tableLayoutPanel_Panel.Controls.Add(this.groupBox_Username_Mail_Phone, 1, 1);
            this.tableLayoutPanel_Panel.Controls.Add(this.label_Head, 1, 0);
            this.tableLayoutPanel_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Panel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Panel.Location = new System.Drawing.Point(2, 38);
            this.tableLayoutPanel_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Panel.Name = "tableLayoutPanel_Panel";
            this.tableLayoutPanel_Panel.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Panel.RowCount = 7;
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.Size = new System.Drawing.Size(455, 655);
            this.tableLayoutPanel_Panel.TabIndex = 0;
            // 
            // linkLabel_Password
            // 
            this.linkLabel_Password.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.linkLabel_Password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_Password.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(151)))));
            this.linkLabel_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel_Password.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.linkLabel_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(151)))));
            this.linkLabel_Password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel_Password.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(151)))));
            this.linkLabel_Password.Location = new System.Drawing.Point(26, 339);
            this.linkLabel_Password.Margin = new System.Windows.Forms.Padding(2);
            this.linkLabel_Password.Name = "linkLabel_Password";
            this.linkLabel_Password.Padding = new System.Windows.Forms.Padding(2);
            this.linkLabel_Password.Size = new System.Drawing.Size(401, 51);
            this.linkLabel_Password.TabIndex = 6;
            this.linkLabel_Password.TabStop = true;
            this.linkLabel_Password.Text = "I forgot my password";
            this.linkLabel_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_Password.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(151)))));
            this.linkLabel_Password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Password_LinkClicked);
            // 
            // tableLayoutPanel_Buttons
            // 
            this.tableLayoutPanel_Buttons.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Buttons.ColumnCount = 2;
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel_Buttons.Controls.Add(this.button_Create, 0, 0);
            this.tableLayoutPanel_Buttons.Controls.Add(this.button_Sign, 0, 0);
            this.tableLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Buttons.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Buttons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Buttons.Location = new System.Drawing.Point(26, 264);
            this.tableLayoutPanel_Buttons.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Buttons.Name = "tableLayoutPanel_Buttons";
            this.tableLayoutPanel_Buttons.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Buttons.RowCount = 1;
            this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Buttons.Size = new System.Drawing.Size(401, 71);
            this.tableLayoutPanel_Buttons.TabIndex = 0;
            // 
            // button_Create
            // 
            this.button_Create.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(113)))));
            this.button_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Create.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Create.Location = new System.Drawing.Point(154, 4);
            this.button_Create.Margin = new System.Windows.Forms.Padding(2);
            this.button_Create.Name = "button_Create";
            this.button_Create.Padding = new System.Windows.Forms.Padding(2);
            this.button_Create.Size = new System.Drawing.Size(243, 63);
            this.button_Create.TabIndex = 5;
            this.button_Create.Text = "Create Account";
            this.button_Create.UseVisualStyleBackColor = false;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Sign
            // 
            this.button_Sign.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Sign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.button_Sign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Sign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Sign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Sign.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Sign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_Sign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Sign.Location = new System.Drawing.Point(4, 4);
            this.button_Sign.Margin = new System.Windows.Forms.Padding(2);
            this.button_Sign.Name = "button_Sign";
            this.button_Sign.Padding = new System.Windows.Forms.Padding(2);
            this.button_Sign.Size = new System.Drawing.Size(146, 63);
            this.button_Sign.TabIndex = 4;
            this.button_Sign.Text = "Sign In";
            this.button_Sign.UseVisualStyleBackColor = false;
            this.button_Sign.Click += new System.EventHandler(this.button_Sign_Click);
            // 
            // checkBox_Remember
            // 
            this.checkBox_Remember.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.checkBox_Remember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Remember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_Remember.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.checkBox_Remember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.checkBox_Remember.Location = new System.Drawing.Point(26, 209);
            this.checkBox_Remember.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Remember.Name = "checkBox_Remember";
            this.checkBox_Remember.Padding = new System.Windows.Forms.Padding(2);
            this.checkBox_Remember.Size = new System.Drawing.Size(401, 51);
            this.checkBox_Remember.TabIndex = 3;
            this.checkBox_Remember.Text = "Remember me";
            this.checkBox_Remember.UseVisualStyleBackColor = true;
            // 
            // groupBox_Password
            // 
            this.groupBox_Password.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Password.Controls.Add(this.tableLayoutPanel_Password);
            this.groupBox_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Password.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Password.Location = new System.Drawing.Point(26, 134);
            this.groupBox_Password.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Password.Name = "groupBox_Password";
            this.groupBox_Password.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Password.Size = new System.Drawing.Size(401, 71);
            this.groupBox_Password.TabIndex = 0;
            this.groupBox_Password.TabStop = false;
            this.groupBox_Password.Text = "Password";
            // 
            // tableLayoutPanel_Password
            // 
            this.tableLayoutPanel_Password.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Password.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Password.ColumnCount = 3;
            this.tableLayoutPanel_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
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
            this.pictureBox_Eye.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
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
            this.textBox_Password.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
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
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // groupBox_Username_Mail_Phone
            // 
            this.groupBox_Username_Mail_Phone.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Username_Mail_Phone.Controls.Add(this.tableLayoutPanel_Username_Mail_Phone);
            this.groupBox_Username_Mail_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Username_Mail_Phone.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Username_Mail_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Username_Mail_Phone.Location = new System.Drawing.Point(26, 59);
            this.groupBox_Username_Mail_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Username_Mail_Phone.Name = "groupBox_Username_Mail_Phone";
            this.groupBox_Username_Mail_Phone.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Username_Mail_Phone.Size = new System.Drawing.Size(401, 71);
            this.groupBox_Username_Mail_Phone.TabIndex = 0;
            this.groupBox_Username_Mail_Phone.TabStop = false;
            this.groupBox_Username_Mail_Phone.Text = "Username or (E-Mail / Phone)";
            // 
            // tableLayoutPanel_Username_Mail_Phone
            // 
            this.tableLayoutPanel_Username_Mail_Phone.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Username_Mail_Phone.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Username_Mail_Phone.ColumnCount = 2;
            this.tableLayoutPanel_Username_Mail_Phone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel_Username_Mail_Phone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Username_Mail_Phone.Controls.Add(this.textBox_Username_Mail_Phone, 0, 0);
            this.tableLayoutPanel_Username_Mail_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Username_Mail_Phone.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Username_Mail_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Username_Mail_Phone.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Username_Mail_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Username_Mail_Phone.Name = "tableLayoutPanel_Username_Mail_Phone";
            this.tableLayoutPanel_Username_Mail_Phone.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Username_Mail_Phone.RowCount = 1;
            this.tableLayoutPanel_Username_Mail_Phone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Username_Mail_Phone.Size = new System.Drawing.Size(397, 44);
            this.tableLayoutPanel_Username_Mail_Phone.TabIndex = 2;
            // 
            // textBox_Username_Mail_Phone
            // 
            this.textBox_Username_Mail_Phone.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox_Username_Mail_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.textBox_Username_Mail_Phone.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_Username_Mail_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Username_Mail_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Username_Mail_Phone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Username_Mail_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.textBox_Username_Mail_Phone.Location = new System.Drawing.Point(4, 4);
            this.textBox_Username_Mail_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Username_Mail_Phone.Name = "textBox_Username_Mail_Phone";
            this.textBox_Username_Mail_Phone.Size = new System.Drawing.Size(346, 34);
            this.textBox_Username_Mail_Phone.TabIndex = 1;
            this.textBox_Username_Mail_Phone.TextChanged += new System.EventHandler(this.textBox_Username_Mail_Phone_TextChanged);
            // 
            // label_Head
            // 
            this.label_Head.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.label_Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Head.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.label_Head.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Head.Location = new System.Drawing.Point(26, 4);
            this.label_Head.Margin = new System.Windows.Forms.Padding(2);
            this.label_Head.Name = "label_Head";
            this.label_Head.Padding = new System.Windows.Forms.Padding(2);
            this.label_Head.Size = new System.Drawing.Size(401, 51);
            this.label_Head.TabIndex = 0;
            this.label_Head.Text = "Sign In";
            this.label_Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Entry
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1262, 785);
            this.Controls.Add(this.tableLayoutPanel_Window);
            this.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.MinimumSize = new System.Drawing.Size(1275, 825);
            this.Name = "Entry";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "CV Analyser Sign In";
            this.tableLayoutPanel_Window.ResumeLayout(false);
            this.groupBox_Panel.ResumeLayout(false);
            this.tableLayoutPanel_Panel.ResumeLayout(false);
            this.tableLayoutPanel_Buttons.ResumeLayout(false);
            this.groupBox_Password.ResumeLayout(false);
            this.tableLayoutPanel_Password.ResumeLayout(false);
            this.tableLayoutPanel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eye)).EndInit();
            this.groupBox_Username_Mail_Phone.ResumeLayout(false);
            this.tableLayoutPanel_Username_Mail_Phone.ResumeLayout(false);
            this.tableLayoutPanel_Username_Mail_Phone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_Window;
        private TableLayoutPanel tableLayoutPanel_Panel;
        private TableLayoutPanel tableLayoutPanel_Buttons;
        private TableLayoutPanel tableLayoutPanel_Password;
        private TableLayoutPanel tableLayoutPanel_Username_Mail_Phone;
        private GroupBox groupBox_Panel;
        private GroupBox groupBox_Password;
        private GroupBox groupBox_Username_Mail_Phone;
        private Label label_Welcome;
        private Label label_Head;
        private LinkLabel linkLabel_Password;
        private TextBox textBox_Password;
        private TextBox textBox_Username_Mail_Phone;
        private Button button_Create;
        private Button button_Sign;
        private PictureBox pictureBox_Eye;
        private CheckBox checkBox_Remember;
    }
}
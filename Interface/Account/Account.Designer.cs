using System.Drawing;
using System.Windows.Forms;

namespace CV_Analyser.Interface.Account
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.tableLayoutPanel_Window = new System.Windows.Forms.TableLayoutPanel();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.groupBox_Panel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Phone = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Phone = new System.Windows.Forms.TableLayoutPanel();
            this.maskedTextBox_Phone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_Mail = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Mail = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Top = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.label_Header = new System.Windows.Forms.Label();
            this.groupBox_Username = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Username = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.groupBox_Password = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Password = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Eye = new System.Windows.Forms.PictureBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.groupBox_Password_Again = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Password_Again = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Eye_Again = new System.Windows.Forms.PictureBox();
            this.textBox_Password_Again = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Create = new System.Windows.Forms.TableLayoutPanel();
            this.button_Create = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Window.SuspendLayout();
            this.groupBox_Panel.SuspendLayout();
            this.tableLayoutPanel_Panel.SuspendLayout();
            this.groupBox_Phone.SuspendLayout();
            this.tableLayoutPanel_Phone.SuspendLayout();
            this.groupBox_Mail.SuspendLayout();
            this.tableLayoutPanel_Mail.SuspendLayout();
            this.tableLayoutPanel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.groupBox_Username.SuspendLayout();
            this.tableLayoutPanel_Username.SuspendLayout();
            this.groupBox_Password.SuspendLayout();
            this.tableLayoutPanel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eye)).BeginInit();
            this.groupBox_Password_Again.SuspendLayout();
            this.tableLayoutPanel_Password_Again.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eye_Again)).BeginInit();
            this.tableLayoutPanel_Create.SuspendLayout();
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
            this.label_Welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Welcome.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.label_Welcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Welcome.Location = new System.Drawing.Point(66, 42);
            this.label_Welcome.Margin = new System.Windows.Forms.Padding(2);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Padding = new System.Windows.Forms.Padding(2);
            this.label_Welcome.Size = new System.Drawing.Size(472, 693);
            this.label_Welcome.TabIndex = 0;
            this.label_Welcome.Text = "CV Analyser\r\nTalent Search Made Easy";
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
            this.tableLayoutPanel_Panel.Controls.Add(this.groupBox_Phone, 1, 2);
            this.tableLayoutPanel_Panel.Controls.Add(this.groupBox_Mail, 1, 1);
            this.tableLayoutPanel_Panel.Controls.Add(this.tableLayoutPanel_Top, 1, 0);
            this.tableLayoutPanel_Panel.Controls.Add(this.groupBox_Username, 1, 3);
            this.tableLayoutPanel_Panel.Controls.Add(this.groupBox_Password, 1, 4);
            this.tableLayoutPanel_Panel.Controls.Add(this.groupBox_Password_Again, 1, 5);
            this.tableLayoutPanel_Panel.Controls.Add(this.tableLayoutPanel_Create, 1, 6);
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
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_Panel.Size = new System.Drawing.Size(455, 653);
            this.tableLayoutPanel_Panel.TabIndex = 0;
            // 
            // groupBox_Phone
            // 
            this.groupBox_Phone.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Phone.Controls.Add(this.tableLayoutPanel_Phone);
            this.groupBox_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Phone.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Phone.Location = new System.Drawing.Point(26, 154);
            this.groupBox_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Phone.Name = "groupBox_Phone";
            this.groupBox_Phone.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Phone.Size = new System.Drawing.Size(401, 71);
            this.groupBox_Phone.TabIndex = 0;
            this.groupBox_Phone.TabStop = false;
            this.groupBox_Phone.Text = "Enter Your Phone Number (Optional)";
            // 
            // tableLayoutPanel_Phone
            // 
            this.tableLayoutPanel_Phone.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Phone.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Phone.ColumnCount = 2;
            this.tableLayoutPanel_Phone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel_Phone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Phone.Controls.Add(this.maskedTextBox_Phone, 0, 0);
            this.tableLayoutPanel_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Phone.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Phone.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Phone.Name = "tableLayoutPanel_Phone";
            this.tableLayoutPanel_Phone.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Phone.RowCount = 1;
            this.tableLayoutPanel_Phone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Phone.Size = new System.Drawing.Size(397, 44);
            this.tableLayoutPanel_Phone.TabIndex = 0;
            // 
            // maskedTextBox_Phone
            // 
            this.maskedTextBox_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.maskedTextBox_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskedTextBox_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox_Phone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maskedTextBox_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.maskedTextBox_Phone.Location = new System.Drawing.Point(4, 4);
            this.maskedTextBox_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox_Phone.Mask = "000-000-0000";
            this.maskedTextBox_Phone.Name = "maskedTextBox_Phone";
            this.maskedTextBox_Phone.Size = new System.Drawing.Size(346, 34);
            this.maskedTextBox_Phone.TabIndex = 2;
            this.maskedTextBox_Phone.TextChanged += new System.EventHandler(this.maskedTextBox_Phone_TextChanged);
            // 
            // groupBox_Mail
            // 
            this.groupBox_Mail.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Mail.Controls.Add(this.tableLayoutPanel_Mail);
            this.groupBox_Mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Mail.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Mail.Location = new System.Drawing.Point(26, 79);
            this.groupBox_Mail.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Mail.Name = "groupBox_Mail";
            this.groupBox_Mail.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Mail.Size = new System.Drawing.Size(401, 71);
            this.groupBox_Mail.TabIndex = 0;
            this.groupBox_Mail.TabStop = false;
            this.groupBox_Mail.Text = "Enter Your E-Mail";
            // 
            // tableLayoutPanel_Mail
            // 
            this.tableLayoutPanel_Mail.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Mail.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Mail.ColumnCount = 2;
            this.tableLayoutPanel_Mail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel_Mail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Mail.Controls.Add(this.textBox_Mail, 0, 0);
            this.tableLayoutPanel_Mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Mail.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Mail.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Mail.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Mail.Name = "tableLayoutPanel_Mail";
            this.tableLayoutPanel_Mail.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Mail.RowCount = 1;
            this.tableLayoutPanel_Mail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Mail.Size = new System.Drawing.Size(397, 44);
            this.tableLayoutPanel_Mail.TabIndex = 0;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.textBox_Mail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_Mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Mail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.textBox_Mail.Location = new System.Drawing.Point(4, 4);
            this.textBox_Mail.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(346, 34);
            this.textBox_Mail.TabIndex = 1;
            this.textBox_Mail.TextChanged += new System.EventHandler(this.textBox_Mail_TextChanged);
            // 
            // tableLayoutPanel_Top
            // 
            this.tableLayoutPanel_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Top.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Top.ColumnCount = 2;
            this.tableLayoutPanel_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_Top.Controls.Add(this.pictureBox_Back, 0, 0);
            this.tableLayoutPanel_Top.Controls.Add(this.label_Header, 1, 0);
            this.tableLayoutPanel_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Top.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Top.Location = new System.Drawing.Point(26, 4);
            this.tableLayoutPanel_Top.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Top.Name = "tableLayoutPanel_Top";
            this.tableLayoutPanel_Top.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Top.RowCount = 1;
            this.tableLayoutPanel_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Top.Size = new System.Drawing.Size(401, 71);
            this.tableLayoutPanel_Top.TabIndex = 2;
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
            this.label_Header.TabIndex = 0;
            this.label_Header.Text = "Create Account";
            this.label_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_Username
            // 
            this.groupBox_Username.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Username.Controls.Add(this.tableLayoutPanel_Username);
            this.groupBox_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Username.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Username.Location = new System.Drawing.Point(26, 229);
            this.groupBox_Username.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Username.Name = "groupBox_Username";
            this.groupBox_Username.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Username.Size = new System.Drawing.Size(401, 71);
            this.groupBox_Username.TabIndex = 0;
            this.groupBox_Username.TabStop = false;
            this.groupBox_Username.Text = "Username";
            // 
            // tableLayoutPanel_Username
            // 
            this.tableLayoutPanel_Username.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Username.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Username.ColumnCount = 2;
            this.tableLayoutPanel_Username.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel_Username.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Username.Controls.Add(this.textBox_Username, 0, 0);
            this.tableLayoutPanel_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Username.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Username.Location = new System.Drawing.Point(2, 25);
            this.tableLayoutPanel_Username.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Username.Name = "tableLayoutPanel_Username";
            this.tableLayoutPanel_Username.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Username.RowCount = 1;
            this.tableLayoutPanel_Username.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Username.Size = new System.Drawing.Size(397, 44);
            this.tableLayoutPanel_Username.TabIndex = 0;
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.textBox_Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Username.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.textBox_Username.Location = new System.Drawing.Point(4, 4);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(346, 34);
            this.textBox_Username.TabIndex = 3;
            this.textBox_Username.TextChanged += new System.EventHandler(this.textBox_Username_TextChanged);
            // 
            // groupBox_Password
            // 
            this.groupBox_Password.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Password.Controls.Add(this.tableLayoutPanel_Password);
            this.groupBox_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Password.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Password.Location = new System.Drawing.Point(26, 304);
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
            this.tableLayoutPanel_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_Password.Controls.Add(this.pictureBox_Eye, 0, 0);
            this.tableLayoutPanel_Password.Controls.Add(this.textBox_Password, 0, 0);
            this.tableLayoutPanel_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.textBox_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.textBox_Password.Location = new System.Drawing.Point(4, 4);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(346, 34);
            this.textBox_Password.TabIndex = 4;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // groupBox_Password_Again
            // 
            this.groupBox_Password_Again.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Password_Again.Controls.Add(this.tableLayoutPanel_Password_Again);
            this.groupBox_Password_Again.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Password_Again.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.groupBox_Password_Again.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.groupBox_Password_Again.Location = new System.Drawing.Point(26, 379);
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
            this.textBox_Password_Again.TextChanged += new System.EventHandler(this.textBox_Password_Again_TextChanged);
            // 
            // tableLayoutPanel_Create
            // 
            this.tableLayoutPanel_Create.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel_Create.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Create.ColumnCount = 2;
            this.tableLayoutPanel_Create.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel_Create.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_Create.Controls.Add(this.button_Create, 0, 0);
            this.tableLayoutPanel_Create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Create.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel_Create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel_Create.Location = new System.Drawing.Point(26, 454);
            this.tableLayoutPanel_Create.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Create.Name = "tableLayoutPanel_Create";
            this.tableLayoutPanel_Create.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_Create.RowCount = 1;
            this.tableLayoutPanel_Create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Create.Size = new System.Drawing.Size(401, 71);
            this.tableLayoutPanel_Create.TabIndex = 0;
            // 
            // button_Create
            // 
            this.button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.button_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Create.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.button_Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Create.Location = new System.Drawing.Point(4, 4);
            this.button_Create.Margin = new System.Windows.Forms.Padding(2);
            this.button_Create.Name = "button_Create";
            this.button_Create.Padding = new System.Windows.Forms.Padding(2);
            this.button_Create.Size = new System.Drawing.Size(196, 63);
            this.button_Create.TabIndex = 6;
            this.button_Create.Text = "Create Account";
            this.button_Create.UseVisualStyleBackColor = false;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // Account
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1262, 783);
            this.Controls.Add(this.tableLayoutPanel_Window);
            this.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.MinimumSize = new System.Drawing.Size(1275, 825);
            this.Name = "Account";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "CV Analyser Create Account";
            this.tableLayoutPanel_Window.ResumeLayout(false);
            this.groupBox_Panel.ResumeLayout(false);
            this.tableLayoutPanel_Panel.ResumeLayout(false);
            this.groupBox_Phone.ResumeLayout(false);
            this.tableLayoutPanel_Phone.ResumeLayout(false);
            this.tableLayoutPanel_Phone.PerformLayout();
            this.groupBox_Mail.ResumeLayout(false);
            this.tableLayoutPanel_Mail.ResumeLayout(false);
            this.tableLayoutPanel_Mail.PerformLayout();
            this.tableLayoutPanel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.groupBox_Username.ResumeLayout(false);
            this.tableLayoutPanel_Username.ResumeLayout(false);
            this.tableLayoutPanel_Username.PerformLayout();
            this.groupBox_Password.ResumeLayout(false);
            this.tableLayoutPanel_Password.ResumeLayout(false);
            this.tableLayoutPanel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eye)).EndInit();
            this.groupBox_Password_Again.ResumeLayout(false);
            this.tableLayoutPanel_Password_Again.ResumeLayout(false);
            this.tableLayoutPanel_Password_Again.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Eye_Again)).EndInit();
            this.tableLayoutPanel_Create.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_Window;
        private TableLayoutPanel tableLayoutPanel_Panel;
        private TableLayoutPanel tableLayoutPanel_Top;
        private TableLayoutPanel tableLayoutPanel_Mail;
        private TableLayoutPanel tableLayoutPanel_Phone;
        private TableLayoutPanel tableLayoutPanel_Username;
        private TableLayoutPanel tableLayoutPanel_Password;
        private TableLayoutPanel tableLayoutPanel_Password_Again;
        private TableLayoutPanel tableLayoutPanel_Create;
        private GroupBox groupBox_Panel;
        private GroupBox groupBox_Mail;
        private GroupBox groupBox_Phone;
        private GroupBox groupBox_Username;
        private GroupBox groupBox_Password;
        private GroupBox groupBox_Password_Again;
        private TextBox textBox_Mail;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private TextBox textBox_Password_Again;
        private MaskedTextBox maskedTextBox_Phone;
        private PictureBox pictureBox_Back;
        private PictureBox pictureBox_Eye;
        private PictureBox pictureBox_Eye_Again;
        private Label label_Welcome;
        private Label label_Header;
        private Button button_Create;
    }
}
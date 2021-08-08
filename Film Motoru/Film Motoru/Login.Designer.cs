namespace Film_Motoru
{
    partial class Login
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
            this.formSkin = new FlatUI.FormSkin();
            this.AlertBox = new FlatUI.FlatAlertBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.checkRememberMe = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.txtLoginUsername = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtLoginPassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.txtRegisterPasswordAgain = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtRegisterPassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtRegisterEmail = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtRegisterUsername = new MetroSet_UI.Controls.MetroSetTextBox();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatClose1 = new FlatUI.FlatClose();
            this.formSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin
            // 
            this.formSkin.BackColor = System.Drawing.Color.White;
            this.formSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin.Controls.Add(this.AlertBox);
            this.formSkin.Controls.Add(this.picLogo);
            this.formSkin.Controls.Add(this.pnlLogin);
            this.formSkin.Controls.Add(this.pnlRegister);
            this.formSkin.Controls.Add(this.flatMini1);
            this.formSkin.Controls.Add(this.flatClose1);
            this.formSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin.HeaderMaximize = false;
            this.formSkin.Location = new System.Drawing.Point(0, 0);
            this.formSkin.Name = "formSkin";
            this.formSkin.Size = new System.Drawing.Size(320, 425);
            this.formSkin.TabIndex = 0;
            this.formSkin.Text = "Kullanıcı Girişi";
            // 
            // AlertBox
            // 
            this.AlertBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.AlertBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlertBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AlertBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AlertBox.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.AlertBox.Location = new System.Drawing.Point(0, 383);
            this.AlertBox.Name = "AlertBox";
            this.AlertBox.Size = new System.Drawing.Size(320, 42);
            this.AlertBox.TabIndex = 10;
            this.AlertBox.Text = "Kullanıcı adı veya şifre hatalı!";
            this.AlertBox.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Enabled = false;
            this.picLogo.Image = global::Film_Motoru.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(20, 73);
            this.picLogo.Margin = new System.Windows.Forms.Padding(20);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(280, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.pnlLogin.Controls.Add(this.checkRememberMe);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.linkRegister);
            this.pnlLogin.Controls.Add(this.txtLoginUsername);
            this.pnlLogin.Controls.Add(this.txtLoginPassword);
            this.pnlLogin.Location = new System.Drawing.Point(0, 175);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(320, 250);
            this.pnlLogin.TabIndex = 8;
            // 
            // checkRememberMe
            // 
            this.checkRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.checkRememberMe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkRememberMe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.checkRememberMe.Checked = false;
            this.checkRememberMe.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.checkRememberMe.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.checkRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkRememberMe.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.checkRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkRememberMe.Location = new System.Drawing.Point(50, 186);
            this.checkRememberMe.Name = "checkRememberMe";
            this.checkRememberMe.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.checkRememberMe.Size = new System.Drawing.Size(131, 16);
            this.checkRememberMe.Style = MetroSet_UI.Design.Style.Dark;
            this.checkRememberMe.StyleManager = null;
            this.checkRememberMe.TabIndex = 3;
            this.checkRememberMe.Text = "Beni Hatırla";
            this.checkRememberMe.ThemeAuthor = "Narwin";
            this.checkRememberMe.ThemeName = "MetroDark";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 135);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 34);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkRegister
            // 
            this.linkRegister.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkRegister.AutoSize = true;
            this.linkRegister.DisabledLinkColor = System.Drawing.Color.Silver;
            this.linkRegister.ForeColor = System.Drawing.Color.Silver;
            this.linkRegister.LinkColor = System.Drawing.Color.Silver;
            this.linkRegister.Location = new System.Drawing.Point(12, 220);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(64, 21);
            this.linkRegister.TabIndex = 4;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Kayıt Ol";
            this.linkRegister.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.AutoCompleteCustomSource = null;
            this.txtLoginUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLoginUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLoginUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtLoginUsername.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtLoginUsername.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginUsername.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLoginUsername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtLoginUsername.Image = null;
            this.txtLoginUsername.Lines = null;
            this.txtLoginUsername.Location = new System.Drawing.Point(50, 25);
            this.txtLoginUsername.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.txtLoginUsername.MaxLength = 32767;
            this.txtLoginUsername.Multiline = false;
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.ReadOnly = false;
            this.txtLoginUsername.Size = new System.Drawing.Size(220, 30);
            this.txtLoginUsername.Style = MetroSet_UI.Design.Style.Dark;
            this.txtLoginUsername.StyleManager = null;
            this.txtLoginUsername.TabIndex = 0;
            this.txtLoginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginUsername.ThemeAuthor = "Narwin";
            this.txtLoginUsername.ThemeName = "MetroDark";
            this.txtLoginUsername.UseSystemPasswordChar = false;
            this.txtLoginUsername.WatermarkText = "Kullanıcı Adı";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.AutoCompleteCustomSource = null;
            this.txtLoginPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLoginPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLoginPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtLoginPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtLoginPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginPassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLoginPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtLoginPassword.Image = null;
            this.txtLoginPassword.Lines = null;
            this.txtLoginPassword.Location = new System.Drawing.Point(50, 75);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.txtLoginPassword.MaxLength = 32767;
            this.txtLoginPassword.Multiline = false;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.ReadOnly = false;
            this.txtLoginPassword.Size = new System.Drawing.Size(220, 30);
            this.txtLoginPassword.Style = MetroSet_UI.Design.Style.Dark;
            this.txtLoginPassword.StyleManager = null;
            this.txtLoginPassword.TabIndex = 1;
            this.txtLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginPassword.ThemeAuthor = "Narwin";
            this.txtLoginPassword.ThemeName = "MetroDark";
            this.txtLoginPassword.UseSystemPasswordChar = true;
            this.txtLoginPassword.WatermarkText = "Şifre";
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.linkLogin);
            this.pnlRegister.Controls.Add(this.txtRegisterPasswordAgain);
            this.pnlRegister.Controls.Add(this.txtRegisterPassword);
            this.pnlRegister.Controls.Add(this.txtRegisterEmail);
            this.pnlRegister.Controls.Add(this.txtRegisterUsername);
            this.pnlRegister.Location = new System.Drawing.Point(0, 175);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(320, 325);
            this.pnlRegister.TabIndex = 9;
            this.pnlRegister.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(50, 235);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(220, 34);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // linkLogin
            // 
            this.linkLogin.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLogin.AutoSize = true;
            this.linkLogin.DisabledLinkColor = System.Drawing.Color.Silver;
            this.linkLogin.ForeColor = System.Drawing.Color.Silver;
            this.linkLogin.LinkColor = System.Drawing.Color.Silver;
            this.linkLogin.Location = new System.Drawing.Point(12, 295);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(71, 21);
            this.linkLogin.TabIndex = 8;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Giriş Yap";
            this.linkLogin.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // txtRegisterPasswordAgain
            // 
            this.txtRegisterPasswordAgain.AutoCompleteCustomSource = null;
            this.txtRegisterPasswordAgain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRegisterPasswordAgain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRegisterPasswordAgain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtRegisterPasswordAgain.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtRegisterPasswordAgain.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegisterPasswordAgain.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegisterPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRegisterPasswordAgain.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtRegisterPasswordAgain.Image = null;
            this.txtRegisterPasswordAgain.Lines = null;
            this.txtRegisterPasswordAgain.Location = new System.Drawing.Point(50, 175);
            this.txtRegisterPasswordAgain.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.txtRegisterPasswordAgain.MaxLength = 32767;
            this.txtRegisterPasswordAgain.Multiline = false;
            this.txtRegisterPasswordAgain.Name = "txtRegisterPasswordAgain";
            this.txtRegisterPasswordAgain.ReadOnly = false;
            this.txtRegisterPasswordAgain.Size = new System.Drawing.Size(220, 30);
            this.txtRegisterPasswordAgain.Style = MetroSet_UI.Design.Style.Dark;
            this.txtRegisterPasswordAgain.StyleManager = null;
            this.txtRegisterPasswordAgain.TabIndex = 3;
            this.txtRegisterPasswordAgain.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterPasswordAgain.ThemeAuthor = "Narwin";
            this.txtRegisterPasswordAgain.ThemeName = "MetroDark";
            this.txtRegisterPasswordAgain.UseSystemPasswordChar = true;
            this.txtRegisterPasswordAgain.WatermarkText = "Şifre Tekrarı";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.AutoCompleteCustomSource = null;
            this.txtRegisterPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRegisterPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRegisterPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtRegisterPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtRegisterPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegisterPassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRegisterPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtRegisterPassword.Image = null;
            this.txtRegisterPassword.Lines = null;
            this.txtRegisterPassword.Location = new System.Drawing.Point(50, 125);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.txtRegisterPassword.MaxLength = 32767;
            this.txtRegisterPassword.Multiline = false;
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.ReadOnly = false;
            this.txtRegisterPassword.Size = new System.Drawing.Size(220, 30);
            this.txtRegisterPassword.Style = MetroSet_UI.Design.Style.Dark;
            this.txtRegisterPassword.StyleManager = null;
            this.txtRegisterPassword.TabIndex = 2;
            this.txtRegisterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterPassword.ThemeAuthor = "Narwin";
            this.txtRegisterPassword.ThemeName = "MetroDark";
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            this.txtRegisterPassword.WatermarkText = "Şifre";
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.AutoCompleteCustomSource = null;
            this.txtRegisterEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRegisterEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRegisterEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtRegisterEmail.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtRegisterEmail.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegisterEmail.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRegisterEmail.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtRegisterEmail.Image = null;
            this.txtRegisterEmail.Lines = null;
            this.txtRegisterEmail.Location = new System.Drawing.Point(50, 75);
            this.txtRegisterEmail.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.txtRegisterEmail.MaxLength = 32767;
            this.txtRegisterEmail.Multiline = false;
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.ReadOnly = false;
            this.txtRegisterEmail.Size = new System.Drawing.Size(220, 30);
            this.txtRegisterEmail.Style = MetroSet_UI.Design.Style.Dark;
            this.txtRegisterEmail.StyleManager = null;
            this.txtRegisterEmail.TabIndex = 1;
            this.txtRegisterEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterEmail.ThemeAuthor = "Narwin";
            this.txtRegisterEmail.ThemeName = "MetroDark";
            this.txtRegisterEmail.UseSystemPasswordChar = false;
            this.txtRegisterEmail.WatermarkText = "E Mail";
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.AutoCompleteCustomSource = null;
            this.txtRegisterUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRegisterUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRegisterUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtRegisterUsername.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtRegisterUsername.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegisterUsername.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRegisterUsername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtRegisterUsername.Image = null;
            this.txtRegisterUsername.Lines = null;
            this.txtRegisterUsername.Location = new System.Drawing.Point(50, 25);
            this.txtRegisterUsername.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.txtRegisterUsername.MaxLength = 32767;
            this.txtRegisterUsername.Multiline = false;
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.ReadOnly = false;
            this.txtRegisterUsername.Size = new System.Drawing.Size(220, 30);
            this.txtRegisterUsername.Style = MetroSet_UI.Design.Style.Dark;
            this.txtRegisterUsername.StyleManager = null;
            this.txtRegisterUsername.TabIndex = 0;
            this.txtRegisterUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegisterUsername.ThemeAuthor = "Narwin";
            this.txtRegisterUsername.ThemeName = "MetroDark";
            this.txtRegisterUsername.UseSystemPasswordChar = false;
            this.txtRegisterUsername.WatermarkText = "Kullanıcı Adı";
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(261, 13);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 6;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(290, 13);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 5;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 425);
            this.Controls.Add(this.formSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.formSkin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlRegister;
        private MetroSet_UI.Controls.MetroSetTextBox txtRegisterEmail;
        private MetroSet_UI.Controls.MetroSetTextBox txtRegisterUsername;
        private MetroSet_UI.Controls.MetroSetTextBox txtRegisterPasswordAgain;
        private MetroSet_UI.Controls.MetroSetTextBox txtRegisterPassword;
        private MetroSet_UI.Controls.MetroSetTextBox txtLoginUsername;
        private MetroSet_UI.Controls.MetroSetTextBox txtLoginPassword;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.LinkLabel linkLogin;
        private FlatUI.FlatAlertBox AlertBox;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private MetroSet_UI.Controls.MetroSetCheckBox checkRememberMe;
    }
}
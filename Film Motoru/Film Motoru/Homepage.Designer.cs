namespace Film_Motoru
{
    partial class Homepage
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatAlertBox = new FlatUI.FlatAlertBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlFilms = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlGenresButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTümFilmler = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnExitAccount = new System.Windows.Forms.Button();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatMax1 = new FlatUI.FlatMax();
            this.flatClose1 = new FlatUI.FlatClose();
            this.formSkin1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlGenresButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatAlertBox);
            this.formSkin1.Controls.Add(this.pnlMain);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.flatMax1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(884, 561);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "filmmotoru.com";
            // 
            // flatAlertBox
            // 
            this.flatAlertBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatAlertBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatAlertBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatAlertBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatAlertBox.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.flatAlertBox.Location = new System.Drawing.Point(0, 519);
            this.flatAlertBox.Name = "flatAlertBox";
            this.flatAlertBox.Size = new System.Drawing.Size(884, 42);
            this.flatAlertBox.TabIndex = 4;
            this.flatAlertBox.Visible = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Location = new System.Drawing.Point(0, 48);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(884, 513);
            this.pnlMain.TabIndex = 3;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlFilms);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(172, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(712, 513);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlFilms
            // 
            this.pnlFilms.AutoScroll = true;
            this.pnlFilms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilms.Location = new System.Drawing.Point(0, 0);
            this.pnlFilms.Name = "pnlFilms";
            this.pnlFilms.Size = new System.Drawing.Size(712, 513);
            this.pnlFilms.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.pnlGenresButton);
            this.pnlLeft.Controls.Add(this.btnAdminPanel);
            this.pnlLeft.Controls.Add(this.btnProfile);
            this.pnlLeft.Controls.Add(this.btnExitAccount);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(172, 513);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlGenresButton
            // 
            this.pnlGenresButton.AutoSize = true;
            this.pnlGenresButton.Controls.Add(this.btnTümFilmler);
            this.pnlGenresButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGenresButton.Location = new System.Drawing.Point(0, 0);
            this.pnlGenresButton.Name = "pnlGenresButton";
            this.pnlGenresButton.Size = new System.Drawing.Size(170, 36);
            this.pnlGenresButton.TabIndex = 4;
            // 
            // btnTümFilmler
            // 
            this.btnTümFilmler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTümFilmler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTümFilmler.FlatAppearance.BorderSize = 0;
            this.btnTümFilmler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTümFilmler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTümFilmler.ForeColor = System.Drawing.Color.White;
            this.btnTümFilmler.Location = new System.Drawing.Point(0, 0);
            this.btnTümFilmler.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnTümFilmler.Name = "btnTümFilmler";
            this.btnTümFilmler.Size = new System.Drawing.Size(172, 35);
            this.btnTümFilmler.TabIndex = 3;
            this.btnTümFilmler.Text = "Tüm Filmler";
            this.btnTümFilmler.UseVisualStyleBackColor = false;
            this.btnTümFilmler.Click += new System.EventHandler(this.btnTümFilmler_Click);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAdminPanel.Enabled = false;
            this.btnAdminPanel.FlatAppearance.BorderSize = 0;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdminPanel.ForeColor = System.Drawing.Color.White;
            this.btnAdminPanel.Location = new System.Drawing.Point(-1, 405);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(172, 35);
            this.btnAdminPanel.TabIndex = 3;
            this.btnAdminPanel.Text = "Yönetim Paneli";
            this.btnAdminPanel.UseVisualStyleBackColor = false;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(-1, 441);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(172, 35);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profil";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnExitAccount
            // 
            this.btnExitAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExitAccount.FlatAppearance.BorderSize = 0;
            this.btnExitAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExitAccount.ForeColor = System.Drawing.Color.White;
            this.btnExitAccount.Location = new System.Drawing.Point(-1, 477);
            this.btnExitAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitAccount.Name = "btnExitAccount";
            this.btnExitAccount.Size = new System.Drawing.Size(172, 35);
            this.btnExitAccount.TabIndex = 3;
            this.btnExitAccount.Text = "Çıkış Yap";
            this.btnExitAccount.UseVisualStyleBackColor = false;
            this.btnExitAccount.Click += new System.EventHandler(this.btnExitAccount_Click);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(796, 13);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 2;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(825, 13);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 1;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(854, 13);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.formSkin1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlGenresButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatClose flatClose1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.FlowLayoutPanel pnlFilms;
        private FlatUI.FlatAlertBox flatAlertBox;
        private System.Windows.Forms.Button btnExitAccount;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.FlowLayoutPanel pnlGenresButton;
        private System.Windows.Forms.Button btnTümFilmler;
    }
}
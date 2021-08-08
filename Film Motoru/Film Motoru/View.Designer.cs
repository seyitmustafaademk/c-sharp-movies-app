namespace Film_Motoru
{
    partial class View
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
            this.pnlView = new System.Windows.Forms.Panel();
            this.controlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.comboQuality = new MetroSet_UI.Controls.MetroSetComboBox();
            this.btnDüzenle = new MetroSet_UI.Controls.MetroSetButton();
            this.btnPlayFilm = new MetroSet_UI.Controls.MetroSetButton();
            this.lblPointImdb = new FlatUI.FlatLabel();
            this.lblYear = new FlatUI.FlatLabel();
            this.lblActors = new FlatUI.FlatLabel();
            this.lblDirector = new FlatUI.FlatLabel();
            this.lblFilmDescription = new FlatUI.FlatLabel();
            this.lblGenresTime = new FlatUI.FlatLabel();
            this.lblFilmName = new FlatUI.FlatLabel();
            this.picFilmImage = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.formSkin.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilmImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin
            // 
            this.formSkin.BackColor = System.Drawing.Color.White;
            this.formSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin.Controls.Add(this.pnlView);
            this.formSkin.Controls.Add(this.controlBox);
            this.formSkin.Controls.Add(this.pnlMain);
            this.formSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin.HeaderMaximize = false;
            this.formSkin.Location = new System.Drawing.Point(0, 0);
            this.formSkin.Name = "formSkin";
            this.formSkin.Size = new System.Drawing.Size(1000, 600);
            this.formSkin.TabIndex = 0;
            this.formSkin.Text = "İzle: ";
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.Transparent;
            this.pnlView.Enabled = false;
            this.pnlView.Location = new System.Drawing.Point(990, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(10, 10);
            this.pnlView.TabIndex = 10;
            this.pnlView.Visible = false;
            // 
            // controlBox
            // 
            this.controlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.controlBox.CloseHoverForeColor = System.Drawing.Color.White;
            this.controlBox.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.controlBox.DisabledForeColor = System.Drawing.Color.DimGray;
            this.controlBox.Location = new System.Drawing.Point(888, 12);
            this.controlBox.MaximizeBox = true;
            this.controlBox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.controlBox.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.controlBox.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.controlBox.MinimizeBox = true;
            this.controlBox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.controlBox.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.controlBox.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(100, 25);
            this.controlBox.Style = MetroSet_UI.Design.Style.Light;
            this.controlBox.StyleManager = null;
            this.controlBox.TabIndex = 7;
            this.controlBox.Text = "metroSetControlBox1";
            this.controlBox.ThemeAuthor = "Narwin";
            this.controlBox.ThemeName = "MetroLite";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.pnlMain.Controls.Add(this.trackBar);
            this.pnlMain.Controls.Add(this.flatLabel1);
            this.pnlMain.Controls.Add(this.comboQuality);
            this.pnlMain.Controls.Add(this.btnDüzenle);
            this.pnlMain.Controls.Add(this.btnPlayFilm);
            this.pnlMain.Controls.Add(this.lblPointImdb);
            this.pnlMain.Controls.Add(this.lblYear);
            this.pnlMain.Controls.Add(this.lblActors);
            this.pnlMain.Controls.Add(this.lblDirector);
            this.pnlMain.Controls.Add(this.lblFilmDescription);
            this.pnlMain.Controls.Add(this.lblGenresTime);
            this.pnlMain.Controls.Add(this.lblFilmName);
            this.pnlMain.Controls.Add(this.picFilmImage);
            this.pnlMain.Location = new System.Drawing.Point(0, 49);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1000, 551);
            this.pnlMain.TabIndex = 6;
            // 
            // comboQuality
            // 
            this.comboQuality.AllowDrop = true;
            this.comboQuality.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.comboQuality.BackColor = System.Drawing.Color.Transparent;
            this.comboQuality.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.comboQuality.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.comboQuality.CausesValidation = false;
            this.comboQuality.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.comboQuality.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboQuality.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comboQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboQuality.FormattingEnabled = true;
            this.comboQuality.ItemHeight = 25;
            this.comboQuality.Items.AddRange(new object[] {
            "720p",
            "1080p"});
            this.comboQuality.Location = new System.Drawing.Point(623, 432);
            this.comboQuality.Name = "comboQuality";
            this.comboQuality.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboQuality.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboQuality.Size = new System.Drawing.Size(200, 31);
            this.comboQuality.Style = MetroSet_UI.Design.Style.Dark;
            this.comboQuality.StyleManager = null;
            this.comboQuality.TabIndex = 1;
            this.comboQuality.ThemeAuthor = "Narwin";
            this.comboQuality.ThemeName = "MetroDark";
            this.comboQuality.SelectedIndexChanged += new System.EventHandler(this.comboQuality_SelectedIndexChanged);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDüzenle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDüzenle.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDüzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDüzenle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDüzenle.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDüzenle.HoverTextColor = System.Drawing.Color.White;
            this.btnDüzenle.Location = new System.Drawing.Point(384, 475);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDüzenle.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDüzenle.NormalTextColor = System.Drawing.Color.White;
            this.btnDüzenle.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDüzenle.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDüzenle.PressTextColor = System.Drawing.Color.White;
            this.btnDüzenle.Size = new System.Drawing.Size(200, 35);
            this.btnDüzenle.Style = MetroSet_UI.Design.Style.Light;
            this.btnDüzenle.StyleManager = null;
            this.btnDüzenle.TabIndex = 0;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.ThemeAuthor = "Narwin";
            this.btnDüzenle.ThemeName = "MetroLite";
            this.btnDüzenle.Visible = false;
            this.btnDüzenle.Click += new System.EventHandler(this.btnPlayFilm_Click);
            // 
            // btnPlayFilm
            // 
            this.btnPlayFilm.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPlayFilm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPlayFilm.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnPlayFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPlayFilm.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnPlayFilm.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnPlayFilm.HoverTextColor = System.Drawing.Color.White;
            this.btnPlayFilm.Location = new System.Drawing.Point(384, 432);
            this.btnPlayFilm.Name = "btnPlayFilm";
            this.btnPlayFilm.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPlayFilm.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPlayFilm.NormalTextColor = System.Drawing.Color.White;
            this.btnPlayFilm.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPlayFilm.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPlayFilm.PressTextColor = System.Drawing.Color.White;
            this.btnPlayFilm.Size = new System.Drawing.Size(200, 35);
            this.btnPlayFilm.Style = MetroSet_UI.Design.Style.Light;
            this.btnPlayFilm.StyleManager = null;
            this.btnPlayFilm.TabIndex = 0;
            this.btnPlayFilm.Text = "Filmi izle";
            this.btnPlayFilm.ThemeAuthor = "Narwin";
            this.btnPlayFilm.ThemeName = "MetroLite";
            this.btnPlayFilm.Click += new System.EventHandler(this.btnPlayFilm_Click);
            // 
            // lblPointImdb
            // 
            this.lblPointImdb.AutoEllipsis = true;
            this.lblPointImdb.AutoSize = true;
            this.lblPointImdb.BackColor = System.Drawing.Color.Transparent;
            this.lblPointImdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPointImdb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPointImdb.ForeColor = System.Drawing.Color.White;
            this.lblPointImdb.Location = new System.Drawing.Point(382, 388);
            this.lblPointImdb.Margin = new System.Windows.Forms.Padding(8);
            this.lblPointImdb.Name = "lblPointImdb";
            this.lblPointImdb.Size = new System.Drawing.Size(130, 21);
            this.lblPointImdb.TabIndex = 30;
            this.lblPointImdb.Text = "IMDB Puanı         :";
            // 
            // lblYear
            // 
            this.lblYear.AutoEllipsis = true;
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(383, 351);
            this.lblYear.Margin = new System.Windows.Forms.Padding(8);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(129, 21);
            this.lblYear.TabIndex = 31;
            this.lblYear.Text = "Yapım Yılı            :";
            // 
            // lblActors
            // 
            this.lblActors.AutoEllipsis = true;
            this.lblActors.AutoSize = true;
            this.lblActors.BackColor = System.Drawing.Color.Transparent;
            this.lblActors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblActors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblActors.ForeColor = System.Drawing.Color.White;
            this.lblActors.Location = new System.Drawing.Point(383, 314);
            this.lblActors.Margin = new System.Windows.Forms.Padding(8);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(133, 21);
            this.lblActors.TabIndex = 32;
            this.lblActors.Text = "Oyuncular           : ";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoEllipsis = true;
            this.lblDirector.AutoSize = true;
            this.lblDirector.BackColor = System.Drawing.Color.Transparent;
            this.lblDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDirector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDirector.ForeColor = System.Drawing.Color.White;
            this.lblDirector.Location = new System.Drawing.Point(383, 277);
            this.lblDirector.Margin = new System.Windows.Forms.Padding(8);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(131, 21);
            this.lblDirector.TabIndex = 33;
            this.lblDirector.Text = "Yönetmen            :";
            // 
            // lblFilmDescription
            // 
            this.lblFilmDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilmDescription.AutoEllipsis = true;
            this.lblFilmDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilmDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFilmDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmDescription.ForeColor = System.Drawing.Color.White;
            this.lblFilmDescription.Location = new System.Drawing.Point(384, 94);
            this.lblFilmDescription.Margin = new System.Windows.Forms.Padding(8);
            this.lblFilmDescription.Name = "lblFilmDescription";
            this.lblFilmDescription.Size = new System.Drawing.Size(602, 167);
            this.lblFilmDescription.TabIndex = 34;
            this.lblFilmDescription.Text = "Film Açıklaması";
            // 
            // lblGenresTime
            // 
            this.lblGenresTime.AutoSize = true;
            this.lblGenresTime.BackColor = System.Drawing.Color.Transparent;
            this.lblGenresTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenresTime.ForeColor = System.Drawing.Color.White;
            this.lblGenresTime.Location = new System.Drawing.Point(383, 50);
            this.lblGenresTime.Name = "lblGenresTime";
            this.lblGenresTime.Size = new System.Drawing.Size(221, 21);
            this.lblGenresTime.TabIndex = 35;
            this.lblGenresTime.Text = "Aksiyon, Macera     •     107 DK\r\n";
            // 
            // lblFilmName
            // 
            this.lblFilmName.AutoSize = true;
            this.lblFilmName.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmName.ForeColor = System.Drawing.Color.White;
            this.lblFilmName.Location = new System.Drawing.Point(382, 15);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(95, 30);
            this.lblFilmName.TabIndex = 29;
            this.lblFilmName.Text = "Film Adı";
            // 
            // picFilmImage
            // 
            this.picFilmImage.Location = new System.Drawing.Point(24, 15);
            this.picFilmImage.Margin = new System.Windows.Forms.Padding(15);
            this.picFilmImage.Name = "picFilmImage";
            this.picFilmImage.Size = new System.Drawing.Size(340, 495);
            this.picFilmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilmImage.TabIndex = 28;
            this.picFilmImage.TabStop = false;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(693, 473);
            this.trackBar.Maximum = 100;
            this.trackBar.Minimum = 40;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(200, 45);
            this.trackBar.TabIndex = 38;
            this.trackBar.Value = 100;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoEllipsis = true;
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(619, 479);
            this.flatLabel1.Margin = new System.Windows.Forms.Padding(8);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(63, 21);
            this.flatLabel1.TabIndex = 37;
            this.flatLabel1.Text = "Opaklık";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.formSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_FormClosing);
            this.Load += new System.EventHandler(this.View_Load);
            this.formSkin.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilmImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin;
        private System.Windows.Forms.Panel pnlMain;
        private MetroSet_UI.Controls.MetroSetButton btnPlayFilm;
        private FlatUI.FlatLabel lblPointImdb;
        private FlatUI.FlatLabel lblYear;
        private FlatUI.FlatLabel lblActors;
        private FlatUI.FlatLabel lblDirector;
        private FlatUI.FlatLabel lblFilmDescription;
        private FlatUI.FlatLabel lblGenresTime;
        private FlatUI.FlatLabel lblFilmName;
        private System.Windows.Forms.PictureBox picFilmImage;
        private MetroSet_UI.Controls.MetroSetControlBox controlBox;
        private MetroSet_UI.Controls.MetroSetComboBox comboQuality;
        private System.Windows.Forms.Panel pnlView;
        private MetroSet_UI.Controls.MetroSetButton btnDüzenle;
        private System.Windows.Forms.TrackBar trackBar;
        private FlatUI.FlatLabel flatLabel1;
    }
}
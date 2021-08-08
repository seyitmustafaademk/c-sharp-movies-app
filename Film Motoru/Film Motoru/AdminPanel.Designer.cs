namespace Film_Motoru
{
    partial class AdminPanel
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
            this.btnBack = new FlatUI.FlatButton();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini = new FlatUI.FlatMini();
            this.flatMax = new FlatUI.FlatMax();
            this.AlertBox = new FlatUI.FlatAlertBox();
            this.tabControl = new FlatUI.FlatTabControl();
            this.tabFilmList = new System.Windows.Forms.TabPage();
            this.listFilm = new System.Windows.Forms.ListView();
            this.columnFilmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilmTurkishName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilmOriginalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilmActors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilmDirector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilmGenres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilmYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilmImdbPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilmTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsFilmler = new FlatUI.FlatContextMenuStrip();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAddFilm = new System.Windows.Forms.TabPage();
            this.btnResimKontrol = new System.Windows.Forms.Button();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.txtTime = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtDescription = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtImageURL = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtGenres = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtDirector = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtActors = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtImdbPoint = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtYear = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtOriginalName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtKaynak2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtKaynak1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtTurkishName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.picFilm = new System.Windows.Forms.PictureBox();
            this.tabUyeler = new System.Windows.Forms.TabPage();
            this.listUyeler = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPermission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CmsUyeler = new FlatUI.FlatContextMenuStrip();
            this.üyeSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formSkin.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabFilmList.SuspendLayout();
            this.cmsFilmler.SuspendLayout();
            this.tabAddFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).BeginInit();
            this.tabUyeler.SuspendLayout();
            this.CmsUyeler.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin
            // 
            this.formSkin.BackColor = System.Drawing.Color.White;
            this.formSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin.Controls.Add(this.btnBack);
            this.formSkin.Controls.Add(this.flatClose1);
            this.formSkin.Controls.Add(this.flatMini);
            this.formSkin.Controls.Add(this.flatMax);
            this.formSkin.Controls.Add(this.AlertBox);
            this.formSkin.Controls.Add(this.tabControl);
            this.formSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin.HeaderMaximize = false;
            this.formSkin.Location = new System.Drawing.Point(0, 0);
            this.formSkin.Name = "formSkin";
            this.formSkin.Size = new System.Drawing.Size(1000, 650);
            this.formSkin.TabIndex = 0;
            this.formSkin.Text = "Admin Panel: ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(878, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rounded = false;
            this.btnBack.Size = new System.Drawing.Size(18, 18);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<";
            this.btnBack.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnBack.UseCustomColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(970, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 15;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini
            // 
            this.flatMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini.BackColor = System.Drawing.Color.White;
            this.flatMini.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini.Location = new System.Drawing.Point(907, 12);
            this.flatMini.Name = "flatMini";
            this.flatMini.Size = new System.Drawing.Size(18, 18);
            this.flatMini.TabIndex = 13;
            this.flatMini.Text = "flatMini1";
            this.flatMini.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMax
            // 
            this.flatMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax.BackColor = System.Drawing.Color.White;
            this.flatMax.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax.Location = new System.Drawing.Point(936, 12);
            this.flatMax.Name = "flatMax";
            this.flatMax.Size = new System.Drawing.Size(18, 18);
            this.flatMax.TabIndex = 12;
            this.flatMax.Text = "flatMax1";
            this.flatMax.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // AlertBox
            // 
            this.AlertBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.AlertBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlertBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AlertBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AlertBox.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.AlertBox.Location = new System.Drawing.Point(0, 608);
            this.AlertBox.Name = "AlertBox";
            this.AlertBox.Size = new System.Drawing.Size(1000, 42);
            this.AlertBox.TabIndex = 11;
            this.AlertBox.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.tabControl.Controls.Add(this.tabFilmList);
            this.tabControl.Controls.Add(this.tabAddFilm);
            this.tabControl.Controls.Add(this.tabUyeler);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.ItemSize = new System.Drawing.Size(120, 40);
            this.tabControl.Location = new System.Drawing.Point(0, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 600);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabFilmList
            // 
            this.tabFilmList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabFilmList.Controls.Add(this.listFilm);
            this.tabFilmList.Location = new System.Drawing.Point(4, 44);
            this.tabFilmList.Name = "tabFilmList";
            this.tabFilmList.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilmList.Size = new System.Drawing.Size(992, 552);
            this.tabFilmList.TabIndex = 1;
            this.tabFilmList.Text = "Film Listesi";
            // 
            // listFilm
            // 
            this.listFilm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFilmID,
            this.columnFilmTurkishName,
            this.columnFilmOriginalName,
            this.columnFilmActors,
            this.columnFilmDirector,
            this.columnFilmGenres,
            this.columnFilmYear,
            this.columnFilmImdbPoint,
            this.columnFilmTime});
            this.listFilm.ContextMenuStrip = this.cmsFilmler;
            this.listFilm.FullRowSelect = true;
            this.listFilm.HideSelection = false;
            this.listFilm.Location = new System.Drawing.Point(8, 10);
            this.listFilm.Name = "listFilm";
            this.listFilm.Size = new System.Drawing.Size(976, 532);
            this.listFilm.TabIndex = 1;
            this.listFilm.UseCompatibleStateImageBehavior = false;
            this.listFilm.View = System.Windows.Forms.View.Details;
            // 
            // columnFilmID
            // 
            this.columnFilmID.Text = "ID";
            this.columnFilmID.Width = 40;
            // 
            // columnFilmTurkishName
            // 
            this.columnFilmTurkishName.Text = "Türkçe Adı";
            this.columnFilmTurkishName.Width = 150;
            // 
            // columnFilmOriginalName
            // 
            this.columnFilmOriginalName.Text = "Orijinal Adı";
            this.columnFilmOriginalName.Width = 150;
            // 
            // columnFilmActors
            // 
            this.columnFilmActors.Text = "Oyuncular";
            this.columnFilmActors.Width = 100;
            // 
            // columnFilmDirector
            // 
            this.columnFilmDirector.Text = "Yönetmen";
            this.columnFilmDirector.Width = 100;
            // 
            // columnFilmGenres
            // 
            this.columnFilmGenres.Text = "Türü";
            this.columnFilmGenres.Width = 100;
            // 
            // columnFilmYear
            // 
            this.columnFilmYear.Text = "Yapım Yılı";
            this.columnFilmYear.Width = 100;
            // 
            // columnFilmImdbPoint
            // 
            this.columnFilmImdbPoint.Text = "IMDB Puanı";
            this.columnFilmImdbPoint.Width = 100;
            // 
            // columnFilmTime
            // 
            this.columnFilmTime.Text = "Süresi";
            this.columnFilmTime.Width = 100;
            // 
            // cmsFilmler
            // 
            this.cmsFilmler.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmsFilmler.ForeColor = System.Drawing.Color.White;
            this.cmsFilmler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsFilmler.Name = "CmsUyeler";
            this.cmsFilmler.ShowImageMargin = false;
            this.cmsFilmler.Size = new System.Drawing.Size(62, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // tabAddFilm
            // 
            this.tabAddFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabAddFilm.Controls.Add(this.btnResimKontrol);
            this.tabAddFilm.Controls.Add(this.btnAddFilm);
            this.tabAddFilm.Controls.Add(this.txtTime);
            this.tabAddFilm.Controls.Add(this.txtDescription);
            this.tabAddFilm.Controls.Add(this.txtImageURL);
            this.tabAddFilm.Controls.Add(this.txtGenres);
            this.tabAddFilm.Controls.Add(this.txtDirector);
            this.tabAddFilm.Controls.Add(this.txtActors);
            this.tabAddFilm.Controls.Add(this.txtImdbPoint);
            this.tabAddFilm.Controls.Add(this.txtYear);
            this.tabAddFilm.Controls.Add(this.txtOriginalName);
            this.tabAddFilm.Controls.Add(this.txtKaynak2);
            this.tabAddFilm.Controls.Add(this.txtKaynak1);
            this.tabAddFilm.Controls.Add(this.txtTurkishName);
            this.tabAddFilm.Controls.Add(this.picFilm);
            this.tabAddFilm.Location = new System.Drawing.Point(4, 44);
            this.tabAddFilm.Name = "tabAddFilm";
            this.tabAddFilm.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddFilm.Size = new System.Drawing.Size(992, 552);
            this.tabAddFilm.TabIndex = 0;
            this.tabAddFilm.Text = "Film Ekleme";
            // 
            // btnResimKontrol
            // 
            this.btnResimKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnResimKontrol.FlatAppearance.BorderSize = 0;
            this.btnResimKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResimKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnResimKontrol.ForeColor = System.Drawing.Color.White;
            this.btnResimKontrol.Location = new System.Drawing.Point(689, 192);
            this.btnResimKontrol.Name = "btnResimKontrol";
            this.btnResimKontrol.Size = new System.Drawing.Size(263, 30);
            this.btnResimKontrol.TabIndex = 11;
            this.btnResimKontrol.Text = "Resim kontrol";
            this.btnResimKontrol.UseVisualStyleBackColor = false;
            this.btnResimKontrol.Click += new System.EventHandler(this.btnResimKontrol_Click);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddFilm.FlatAppearance.BorderSize = 0;
            this.btnAddFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddFilm.ForeColor = System.Drawing.Color.White;
            this.btnAddFilm.Location = new System.Drawing.Point(689, 483);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(263, 30);
            this.btnAddFilm.TabIndex = 10;
            this.btnAddFilm.Text = "Film Ekle";
            this.btnAddFilm.UseVisualStyleBackColor = false;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // txtTime
            // 
            this.txtTime.AutoCompleteCustomSource = null;
            this.txtTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtTime.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtTime.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTime.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTime.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtTime.Image = null;
            this.txtTime.Lines = null;
            this.txtTime.Location = new System.Drawing.Point(383, 366);
            this.txtTime.Margin = new System.Windows.Forms.Padding(50, 15, 50, 10);
            this.txtTime.MaxLength = 32767;
            this.txtTime.Multiline = false;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = false;
            this.txtTime.Size = new System.Drawing.Size(263, 30);
            this.txtTime.Style = MetroSet_UI.Design.Style.Dark;
            this.txtTime.StyleManager = null;
            this.txtTime.TabIndex = 9;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTime.ThemeAuthor = "Narwin";
            this.txtTime.ThemeName = "MetroDark";
            this.txtTime.UseSystemPasswordChar = false;
            this.txtTime.WatermarkText = "Süre";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoCompleteCustomSource = null;
            this.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtDescription.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtDescription.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtDescription.Image = null;
            this.txtDescription.Lines = null;
            this.txtDescription.Location = new System.Drawing.Point(383, 482);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(50, 15, 50, 10);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.Size = new System.Drawing.Size(263, 30);
            this.txtDescription.Style = MetroSet_UI.Design.Style.Dark;
            this.txtDescription.StyleManager = null;
            this.txtDescription.TabIndex = 9;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.ThemeAuthor = "Narwin";
            this.txtDescription.ThemeName = "MetroDark";
            this.txtDescription.UseSystemPasswordChar = false;
            this.txtDescription.WatermarkText = "Açıklama";
            // 
            // txtImageURL
            // 
            this.txtImageURL.AllowDrop = true;
            this.txtImageURL.AutoCompleteCustomSource = null;
            this.txtImageURL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtImageURL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtImageURL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtImageURL.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtImageURL.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImageURL.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImageURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtImageURL.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtImageURL.Image = null;
            this.txtImageURL.Lines = null;
            this.txtImageURL.Location = new System.Drawing.Point(689, 138);
            this.txtImageURL.Margin = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.txtImageURL.MaxLength = 32767;
            this.txtImageURL.Multiline = false;
            this.txtImageURL.Name = "txtImageURL";
            this.txtImageURL.ReadOnly = false;
            this.txtImageURL.Size = new System.Drawing.Size(263, 30);
            this.txtImageURL.Style = MetroSet_UI.Design.Style.Dark;
            this.txtImageURL.StyleManager = null;
            this.txtImageURL.TabIndex = 9;
            this.txtImageURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtImageURL.ThemeAuthor = "Narwin";
            this.txtImageURL.ThemeName = "MetroDark";
            this.txtImageURL.UseSystemPasswordChar = false;
            this.txtImageURL.WatermarkText = "Resim URL";
            // 
            // txtGenres
            // 
            this.txtGenres.AutoCompleteCustomSource = null;
            this.txtGenres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtGenres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtGenres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtGenres.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtGenres.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGenres.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGenres.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtGenres.Image = null;
            this.txtGenres.Lines = null;
            this.txtGenres.Location = new System.Drawing.Point(383, 250);
            this.txtGenres.Margin = new System.Windows.Forms.Padding(50, 15, 50, 10);
            this.txtGenres.MaxLength = 32767;
            this.txtGenres.Multiline = false;
            this.txtGenres.Name = "txtGenres";
            this.txtGenres.ReadOnly = false;
            this.txtGenres.Size = new System.Drawing.Size(263, 30);
            this.txtGenres.Style = MetroSet_UI.Design.Style.Dark;
            this.txtGenres.StyleManager = null;
            this.txtGenres.TabIndex = 9;
            this.txtGenres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGenres.ThemeAuthor = "Narwin";
            this.txtGenres.ThemeName = "MetroDark";
            this.txtGenres.UseSystemPasswordChar = false;
            this.txtGenres.WatermarkText = "Tür";
            // 
            // txtDirector
            // 
            this.txtDirector.AutoCompleteCustomSource = null;
            this.txtDirector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDirector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDirector.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtDirector.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtDirector.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDirector.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDirector.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtDirector.Image = null;
            this.txtDirector.Lines = null;
            this.txtDirector.Location = new System.Drawing.Point(383, 134);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(50, 15, 50, 10);
            this.txtDirector.MaxLength = 32767;
            this.txtDirector.Multiline = false;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.ReadOnly = false;
            this.txtDirector.Size = new System.Drawing.Size(263, 30);
            this.txtDirector.Style = MetroSet_UI.Design.Style.Dark;
            this.txtDirector.StyleManager = null;
            this.txtDirector.TabIndex = 9;
            this.txtDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDirector.ThemeAuthor = "Narwin";
            this.txtDirector.ThemeName = "MetroDark";
            this.txtDirector.UseSystemPasswordChar = false;
            this.txtDirector.WatermarkText = "Yönetmen";
            // 
            // txtActors
            // 
            this.txtActors.AutoCompleteCustomSource = null;
            this.txtActors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtActors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtActors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtActors.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtActors.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtActors.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtActors.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtActors.Image = null;
            this.txtActors.Lines = null;
            this.txtActors.Location = new System.Drawing.Point(383, 192);
            this.txtActors.Margin = new System.Windows.Forms.Padding(50, 15, 50, 10);
            this.txtActors.MaxLength = 32767;
            this.txtActors.Multiline = false;
            this.txtActors.Name = "txtActors";
            this.txtActors.ReadOnly = false;
            this.txtActors.Size = new System.Drawing.Size(263, 30);
            this.txtActors.Style = MetroSet_UI.Design.Style.Dark;
            this.txtActors.StyleManager = null;
            this.txtActors.TabIndex = 9;
            this.txtActors.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtActors.ThemeAuthor = "Narwin";
            this.txtActors.ThemeName = "MetroDark";
            this.txtActors.UseSystemPasswordChar = false;
            this.txtActors.WatermarkText = "Oyuncular";
            // 
            // txtImdbPoint
            // 
            this.txtImdbPoint.AutoCompleteCustomSource = null;
            this.txtImdbPoint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtImdbPoint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtImdbPoint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtImdbPoint.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtImdbPoint.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImdbPoint.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImdbPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtImdbPoint.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtImdbPoint.Image = null;
            this.txtImdbPoint.Lines = null;
            this.txtImdbPoint.Location = new System.Drawing.Point(383, 424);
            this.txtImdbPoint.Margin = new System.Windows.Forms.Padding(50, 15, 50, 10);
            this.txtImdbPoint.MaxLength = 32767;
            this.txtImdbPoint.Multiline = false;
            this.txtImdbPoint.Name = "txtImdbPoint";
            this.txtImdbPoint.ReadOnly = false;
            this.txtImdbPoint.Size = new System.Drawing.Size(263, 30);
            this.txtImdbPoint.Style = MetroSet_UI.Design.Style.Dark;
            this.txtImdbPoint.StyleManager = null;
            this.txtImdbPoint.TabIndex = 9;
            this.txtImdbPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtImdbPoint.ThemeAuthor = "Narwin";
            this.txtImdbPoint.ThemeName = "MetroDark";
            this.txtImdbPoint.UseSystemPasswordChar = false;
            this.txtImdbPoint.WatermarkText = "IMDB Puanı";
            // 
            // txtYear
            // 
            this.txtYear.AutoCompleteCustomSource = null;
            this.txtYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtYear.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtYear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYear.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYear.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtYear.Image = null;
            this.txtYear.Lines = null;
            this.txtYear.Location = new System.Drawing.Point(383, 308);
            this.txtYear.Margin = new System.Windows.Forms.Padding(50, 15, 50, 10);
            this.txtYear.MaxLength = 32767;
            this.txtYear.Multiline = false;
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = false;
            this.txtYear.Size = new System.Drawing.Size(263, 30);
            this.txtYear.Style = MetroSet_UI.Design.Style.Dark;
            this.txtYear.StyleManager = null;
            this.txtYear.TabIndex = 9;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtYear.ThemeAuthor = "Narwin";
            this.txtYear.ThemeName = "MetroDark";
            this.txtYear.UseSystemPasswordChar = false;
            this.txtYear.WatermarkText = "Vizyon Yılı";
            // 
            // txtOriginalName
            // 
            this.txtOriginalName.AutoCompleteCustomSource = null;
            this.txtOriginalName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOriginalName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOriginalName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtOriginalName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtOriginalName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOriginalName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOriginalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOriginalName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtOriginalName.Image = null;
            this.txtOriginalName.Lines = null;
            this.txtOriginalName.Location = new System.Drawing.Point(383, 76);
            this.txtOriginalName.Margin = new System.Windows.Forms.Padding(50, 15, 50, 10);
            this.txtOriginalName.MaxLength = 32767;
            this.txtOriginalName.Multiline = false;
            this.txtOriginalName.Name = "txtOriginalName";
            this.txtOriginalName.ReadOnly = false;
            this.txtOriginalName.Size = new System.Drawing.Size(263, 30);
            this.txtOriginalName.Style = MetroSet_UI.Design.Style.Dark;
            this.txtOriginalName.StyleManager = null;
            this.txtOriginalName.TabIndex = 9;
            this.txtOriginalName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOriginalName.ThemeAuthor = "Narwin";
            this.txtOriginalName.ThemeName = "MetroDark";
            this.txtOriginalName.UseSystemPasswordChar = false;
            this.txtOriginalName.WatermarkText = "Orijinal Ad";
            // 
            // txtKaynak2
            // 
            this.txtKaynak2.AutoCompleteCustomSource = null;
            this.txtKaynak2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtKaynak2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtKaynak2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtKaynak2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtKaynak2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKaynak2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKaynak2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKaynak2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtKaynak2.Image = null;
            this.txtKaynak2.Lines = null;
            this.txtKaynak2.Location = new System.Drawing.Point(689, 78);
            this.txtKaynak2.Margin = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.txtKaynak2.MaxLength = 32767;
            this.txtKaynak2.Multiline = false;
            this.txtKaynak2.Name = "txtKaynak2";
            this.txtKaynak2.ReadOnly = false;
            this.txtKaynak2.Size = new System.Drawing.Size(263, 30);
            this.txtKaynak2.Style = MetroSet_UI.Design.Style.Dark;
            this.txtKaynak2.StyleManager = null;
            this.txtKaynak2.TabIndex = 9;
            this.txtKaynak2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKaynak2.ThemeAuthor = "Narwin";
            this.txtKaynak2.ThemeName = "MetroDark";
            this.txtKaynak2.UseSystemPasswordChar = false;
            this.txtKaynak2.WatermarkText = "Film URL: Kaynak 2";
            // 
            // txtKaynak1
            // 
            this.txtKaynak1.AutoCompleteCustomSource = null;
            this.txtKaynak1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtKaynak1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtKaynak1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtKaynak1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtKaynak1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKaynak1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKaynak1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKaynak1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtKaynak1.Image = null;
            this.txtKaynak1.Lines = null;
            this.txtKaynak1.Location = new System.Drawing.Point(689, 18);
            this.txtKaynak1.Margin = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.txtKaynak1.MaxLength = 32767;
            this.txtKaynak1.Multiline = false;
            this.txtKaynak1.Name = "txtKaynak1";
            this.txtKaynak1.ReadOnly = false;
            this.txtKaynak1.Size = new System.Drawing.Size(263, 30);
            this.txtKaynak1.Style = MetroSet_UI.Design.Style.Dark;
            this.txtKaynak1.StyleManager = null;
            this.txtKaynak1.TabIndex = 9;
            this.txtKaynak1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKaynak1.ThemeAuthor = "Narwin";
            this.txtKaynak1.ThemeName = "MetroDark";
            this.txtKaynak1.UseSystemPasswordChar = false;
            this.txtKaynak1.WatermarkText = "Film URL: Kaynak 1";
            // 
            // txtTurkishName
            // 
            this.txtTurkishName.AutoCompleteCustomSource = null;
            this.txtTurkishName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTurkishName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTurkishName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtTurkishName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtTurkishName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTurkishName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTurkishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTurkishName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtTurkishName.Image = null;
            this.txtTurkishName.Lines = null;
            this.txtTurkishName.Location = new System.Drawing.Point(383, 18);
            this.txtTurkishName.Margin = new System.Windows.Forms.Padding(50, 15, 50, 10);
            this.txtTurkishName.MaxLength = 32767;
            this.txtTurkishName.Multiline = false;
            this.txtTurkishName.Name = "txtTurkishName";
            this.txtTurkishName.ReadOnly = false;
            this.txtTurkishName.Size = new System.Drawing.Size(263, 30);
            this.txtTurkishName.Style = MetroSet_UI.Design.Style.Dark;
            this.txtTurkishName.StyleManager = null;
            this.txtTurkishName.TabIndex = 9;
            this.txtTurkishName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTurkishName.ThemeAuthor = "Narwin";
            this.txtTurkishName.ThemeName = "MetroDark";
            this.txtTurkishName.UseSystemPasswordChar = false;
            this.txtTurkishName.WatermarkText = "Türkçe Ad";
            // 
            // picFilm
            // 
            this.picFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFilm.Location = new System.Drawing.Point(20, 18);
            this.picFilm.Margin = new System.Windows.Forms.Padding(15);
            this.picFilm.Name = "picFilm";
            this.picFilm.Size = new System.Drawing.Size(340, 495);
            this.picFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilm.TabIndex = 8;
            this.picFilm.TabStop = false;
            // 
            // tabUyeler
            // 
            this.tabUyeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabUyeler.Controls.Add(this.listUyeler);
            this.tabUyeler.Location = new System.Drawing.Point(4, 44);
            this.tabUyeler.Name = "tabUyeler";
            this.tabUyeler.Size = new System.Drawing.Size(992, 552);
            this.tabUyeler.TabIndex = 2;
            this.tabUyeler.Text = "Üyeler";
            // 
            // listUyeler
            // 
            this.listUyeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnUsername,
            this.columnName,
            this.columnSurname,
            this.columnBirthday,
            this.columnPermission});
            this.listUyeler.ContextMenuStrip = this.CmsUyeler;
            this.listUyeler.FullRowSelect = true;
            this.listUyeler.HideSelection = false;
            this.listUyeler.Location = new System.Drawing.Point(8, 12);
            this.listUyeler.Name = "listUyeler";
            this.listUyeler.Size = new System.Drawing.Size(976, 532);
            this.listUyeler.TabIndex = 0;
            this.listUyeler.UseCompatibleStateImageBehavior = false;
            this.listUyeler.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 40;
            // 
            // columnUsername
            // 
            this.columnUsername.Text = "Kullanıcı Adı";
            this.columnUsername.Width = 120;
            // 
            // columnName
            // 
            this.columnName.Text = "Adı";
            this.columnName.Width = 120;
            // 
            // columnSurname
            // 
            this.columnSurname.Text = "Soyad";
            this.columnSurname.Width = 100;
            // 
            // columnBirthday
            // 
            this.columnBirthday.Text = "Doğum Tarihi";
            this.columnBirthday.Width = 100;
            // 
            // columnPermission
            // 
            this.columnPermission.Text = "İzinler";
            // 
            // CmsUyeler
            // 
            this.CmsUyeler.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CmsUyeler.ForeColor = System.Drawing.Color.White;
            this.CmsUyeler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeSilToolStripMenuItem});
            this.CmsUyeler.Name = "CmsUyeler";
            this.CmsUyeler.ShowImageMargin = false;
            this.CmsUyeler.Size = new System.Drawing.Size(62, 26);
            // 
            // üyeSilToolStripMenuItem
            // 
            this.üyeSilToolStripMenuItem.Name = "üyeSilToolStripMenuItem";
            this.üyeSilToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.üyeSilToolStripMenuItem.Text = "Sil";
            this.üyeSilToolStripMenuItem.Click += new System.EventHandler(this.üyeSilToolStripMenuItem_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.formSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.formSkin.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabFilmList.ResumeLayout(false);
            this.cmsFilmler.ResumeLayout(false);
            this.tabAddFilm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).EndInit();
            this.tabUyeler.ResumeLayout(false);
            this.CmsUyeler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin;
        private FlatUI.FlatTabControl tabControl;
        private System.Windows.Forms.TabPage tabAddFilm;
        private System.Windows.Forms.TabPage tabFilmList;
        private System.Windows.Forms.TabPage tabUyeler;
        private System.Windows.Forms.ListView listUyeler;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnUsername;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSurname;
        private System.Windows.Forms.ColumnHeader columnBirthday;
        private System.Windows.Forms.ColumnHeader columnPermission;
        private System.Windows.Forms.Button btnAddFilm;
        private MetroSet_UI.Controls.MetroSetTextBox txtTurkishName;
        private System.Windows.Forms.PictureBox picFilm;
        private MetroSet_UI.Controls.MetroSetTextBox txtTime;
        private MetroSet_UI.Controls.MetroSetTextBox txtDescription;
        private MetroSet_UI.Controls.MetroSetTextBox txtImageURL;
        private MetroSet_UI.Controls.MetroSetTextBox txtGenres;
        private MetroSet_UI.Controls.MetroSetTextBox txtDirector;
        private MetroSet_UI.Controls.MetroSetTextBox txtActors;
        private MetroSet_UI.Controls.MetroSetTextBox txtImdbPoint;
        private MetroSet_UI.Controls.MetroSetTextBox txtYear;
        private MetroSet_UI.Controls.MetroSetTextBox txtOriginalName;
        private MetroSet_UI.Controls.MetroSetTextBox txtKaynak2;
        private MetroSet_UI.Controls.MetroSetTextBox txtKaynak1;
        private FlatUI.FlatAlertBox AlertBox;
        private FlatUI.FlatContextMenuStrip CmsUyeler;
        private System.Windows.Forms.ListView listFilm;
        private System.Windows.Forms.ColumnHeader columnFilmID;
        private System.Windows.Forms.ColumnHeader columnFilmTurkishName;
        private System.Windows.Forms.ColumnHeader columnFilmOriginalName;
        private System.Windows.Forms.ColumnHeader columnFilmActors;
        private System.Windows.Forms.ColumnHeader columnFilmDirector;
        private System.Windows.Forms.ColumnHeader columnFilmGenres;
        private System.Windows.Forms.ColumnHeader columnFilmYear;
        private System.Windows.Forms.ColumnHeader columnFilmImdbPoint;
        private System.Windows.Forms.ColumnHeader columnFilmTime;
        private System.Windows.Forms.Button btnResimKontrol;
        private FlatUI.FlatMini flatMini;
        private FlatUI.FlatMax flatMax;
        private System.Windows.Forms.ToolStripMenuItem üyeSilToolStripMenuItem;
        private FlatUI.FlatContextMenuStrip cmsFilmler;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatButton btnBack;
    }
}
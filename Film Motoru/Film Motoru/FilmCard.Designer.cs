namespace Film_Motoru
{
    partial class FilmCard
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.background = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblFilmGenres = new System.Windows.Forms.Label();
            this.picFilmPicture = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFilmPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.Enabled = false;
            this.background.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.background.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.background.Location = new System.Drawing.Point(1, 300);
            this.background.Margin = new System.Windows.Forms.Padding(0);
            this.background.MaximumSize = new System.Drawing.Size(248, 68);
            this.background.MinimumSize = new System.Drawing.Size(248, 68);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(248, 68);
            this.background.TabIndex = 1;
            this.background.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.background.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFilmName
            // 
            this.lblFilmName.AutoEllipsis = true;
            this.lblFilmName.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmName.ForeColor = System.Drawing.Color.White;
            this.lblFilmName.Location = new System.Drawing.Point(1, 300);
            this.lblFilmName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilmName.MaximumSize = new System.Drawing.Size(248, 40);
            this.lblFilmName.MinimumSize = new System.Drawing.Size(248, 40);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(248, 40);
            this.lblFilmName.TabIndex = 3;
            this.lblFilmName.Text = "Film Name";
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilmGenres
            // 
            this.lblFilmGenres.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmGenres.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmGenres.ForeColor = System.Drawing.Color.White;
            this.lblFilmGenres.Location = new System.Drawing.Point(1, 340);
            this.lblFilmGenres.MaximumSize = new System.Drawing.Size(248, 27);
            this.lblFilmGenres.MinimumSize = new System.Drawing.Size(248, 27);
            this.lblFilmGenres.Name = "lblFilmGenres";
            this.lblFilmGenres.Size = new System.Drawing.Size(248, 27);
            this.lblFilmGenres.TabIndex = 4;
            this.lblFilmGenres.Text = "Aksiyon, Macera";
            // 
            // picFilmPicture
            // 
            this.picFilmPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFilmPicture.Location = new System.Drawing.Point(1, 1);
            this.picFilmPicture.Margin = new System.Windows.Forms.Padding(0);
            this.picFilmPicture.MaximumSize = new System.Drawing.Size(248, 365);
            this.picFilmPicture.MinimumSize = new System.Drawing.Size(248, 365);
            this.picFilmPicture.Name = "picFilmPicture";
            this.picFilmPicture.Size = new System.Drawing.Size(248, 365);
            this.picFilmPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFilmPicture.TabIndex = 0;
            this.picFilmPicture.TabStop = false;
            this.toolTip.SetToolTip(this.picFilmPicture, "Film Adı");
            this.picFilmPicture.Click += new System.EventHandler(this.picFilmPicture_Click);
            this.picFilmPicture.MouseLeave += new System.EventHandler(this.picFilmPicture_MouseLeave);
            this.picFilmPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picFilmPicture_MouseMove);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "Film Adı";
            // 
            // FilmCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblFilmGenres);
            this.Controls.Add(this.lblFilmName);
            this.Controls.Add(this.background);
            this.Controls.Add(this.picFilmPicture);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(15);
            this.MaximumSize = new System.Drawing.Size(250, 367);
            this.MinimumSize = new System.Drawing.Size(250, 367);
            this.Name = "FilmCard";
            this.Size = new System.Drawing.Size(250, 367);
            this.Load += new System.EventHandler(this.FilmCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFilmPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFilmPicture;
        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label lblFilmGenres;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

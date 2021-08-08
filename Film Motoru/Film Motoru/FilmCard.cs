using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Motoru
{
    public partial class FilmCard : UserControl
    {
        public FilmCard()
        {
            InitializeComponent();
        }
        int filmID;

        bool effect = false;
        int maxY = 368;
        int minY = 300;
        int currentY = 408;

        #region PROPERTY
        public int FilmID {
            get {
                return filmID;
            }
            set {
                filmID = value;
            }
        }
        public string FilmNameText { 
            get {
                return lblFilmName.Text;
            }
            set {
                lblFilmName.Text = NameControl(value);
            } 
        }
        public string FilmGenresText
        {
            get
            {
                return lblFilmGenres.Text;
            }
            set
            {
                lblFilmGenres.Text = NameControl(value);
            }
        }
        public string FilmImageURL
        {
            set
            {
                try
                {
                    picFilmPicture.Load(value);
                }
                catch (Exception)
                {
                }
            }
        }
        #endregion

        #region Methods
        string NameControl (string filmName)
        {
            int lenght = filmName.Length;
            if (lenght  > 50)
            {
                string[] txt = filmName.Trim().Split(' ');
                string temp1 = "";
                string temp2 = "";
                string temp3 = "";
                foreach (string item in txt)
                {
                    if ((temp1 + item).Length < 25)
                        temp1 += item;
                    else if ((temp2 + item).Length < 50)
                        temp2 += item;
                    else
                        temp3 = " ...";
                }
                return (temp1 + temp2 + temp3);
            }
            else if (lenght > 25)
            {
                string[] txt = filmName.Trim().Split(' ');
                string temp1 = "";
                string temp2 = "";

                foreach (string item in txt)
                {
                    if ((temp1 + item).Length < 25)
                        temp1 += item;
                    else
                        temp2 += item;
                }

                return (temp1 + temp2);
            }
            return filmName;
        }
        #endregion

        #region Card Bilgi Effecti
        // Aktifleştiğinde film bilgi ekranı aç
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (effect)
            {
                if (currentY > minY)
                {
                    currentY -= 4;
                    background.Location = new Point(0, currentY);
                }
            }
            else
            {
                if (currentY < maxY)
                {
                    currentY += 4;
                    background.Location = new Point(0, currentY);
                }
                else
                {
                    timer1.Enabled = false;
                }
            }
        }
        // Film cardının üzerine gelindiğinde timer1 aktifleştirip film bilgisini gösteriyor
        private void picFilmPicture_MouseMove(object sender, MouseEventArgs e)
        {
            effect = true;
            timer1.Enabled = true;
        }
        // Film cardının üzerinden çıktığında timer1 pasifleştirip film bilgisini gizliyor
        private void picFilmPicture_MouseLeave(object sender, EventArgs e)
        {
            effect = false;
        }
        #endregion

        private void FilmCard_Load(object sender, EventArgs e)
        {
            background.Parent = picFilmPicture;
            lblFilmName.Parent = background;
            lblFilmGenres.Parent = background;

            background.Location = new Point(0, maxY);
            lblFilmName.Location = new Point(1, 0);
            lblFilmGenres.Location = new Point(1, 40);

            background.BackColor = Color.FromArgb(175, 0, 0, 0);
            toolTip.ToolTipTitle = lblFilmName.Text;
        }

        private void picFilmPicture_Click(object sender, EventArgs e)
        {
            View view = new View(filmID, FilmNameText, "");
            view.Show();
        }
    }
}

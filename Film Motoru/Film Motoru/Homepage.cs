using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace Film_Motoru
{
    public partial class Homepage : Form
    {
        public Homepage(int _userID,string _uyelik)
        {
            InitializeComponent();
            this.userID = _userID;
            this.uyelik = _uyelik;
        }
        public string uyelik;
        public int userID;
        OleDbConnection sqlConnection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=filmmotoru.accdb");
        OleDbCommand sqlCommand;
        OleDbDataReader sqlReader;

        #region Methods
        void AlertMessage(string _message, char _type)
        {
            flatAlertBox.Text = _message;
            if (_type == 's')
                flatAlertBox.kind = FlatUI.FlatAlertBox._Kind.Success;
            else if(_type == 'i')
                flatAlertBox.kind = FlatUI.FlatAlertBox._Kind.Info;
            else if(_type == 'e')
                flatAlertBox.kind = FlatUI.FlatAlertBox._Kind.Error;
            flatAlertBox.Show();
        }
        public FilmCard AddFilmCard(int _id, string _name, string _genres, string _imageUrl)
        {
            FilmCard card = new FilmCard();
            card.Name = "film" + _id;
            card.Parent = pnlMain;
            card.FilmID = _id;
            card.FilmNameText = _name;
            card.FilmGenresText = _genres;
            card.FilmImageURL = _imageUrl;
            return card;
        }
        public Button AddGenresButton (string _genre)
        {
            string genre = sqlReader["Genres"].ToString();
            Button btnGenres = new Button();
            btnGenres.ForeColor = Color.White;
            btnGenres.BackColor = Color.FromArgb(65, 177, 225);
            btnGenres.Size = new Size(172, 35);
            btnGenres.Margin = new Padding(0, 0, 0, 1);
            btnGenres.FlatStyle = FlatStyle.Flat;
            btnGenres.FlatAppearance.BorderSize = 0;
            btnGenres.Text = _genre;
            btnGenres.Name = "btn" + _genre;
            btnGenres.Click += BtnGenres_Click;
            return btnGenres;
        }
        private void BtnGenres_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            FilmleriListele(" WHERE Genres='" + button.Text + "'");
        }
        void FilmleriListele(string _koşul)
        {
            try
            {
                pnlFilms.Controls.Clear();
                sqlConnection.Open();
                string komut = string.Format("SELECT * FROM films{0}", _koşul);
                sqlCommand = new OleDbCommand(komut, sqlConnection);
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    int id = Convert.ToInt32(sqlReader["id"].ToString());
                    string name = sqlReader["Film_Names"].ToString();
                    string genres = sqlReader["Genres"].ToString();
                    string img = sqlReader["Film_Img"].ToString();
                    pnlFilms.Controls.Add(AddFilmCard(id, name, genres, img));
                }
                sqlConnection.Close();
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                AlertMessage("Filmler yüklenirken hata oluştu. " + ex.Message, 'e');
                sqlConnection.Close();
                sqlCommand.Dispose();
            }
        }
        #endregion
        private void Homepage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (uyelik == "Yönetici")
            {
                btnAdminPanel.Visible = true;
                btnAdminPanel.Enabled = true;
            }
            try
            {
                FilmleriListele("");
                sqlConnection.Open();
                sqlCommand = new OleDbCommand("SELECT Genres FROM films GROUP BY Genres", sqlConnection);
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    pnlGenresButton.Controls.Add(AddGenresButton(sqlReader["Genres"].ToString()));
                }
                sqlConnection.Close();
                sqlCommand.Dispose();
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                AlertMessage("Film türleri listesi yüklenirken hata oluştu." + ex.Message, 'e');
                sqlConnection.Close();
                sqlCommand.Dispose();
                sqlReader.Close();
            }
        }

        private void btnTümFilmler_Click(object sender, EventArgs e)
        {
            FilmleriListele("");
        }
        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(userID);
            adminPanel.Show();
            this.Close();
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(userID);
            profile.Show();
            this.Close();
        }
        private void btnExitAccount_Click(object sender, EventArgs e)
        {
            Ayarlar.Default.Reset();
            Application.Exit();
        }
    }
}
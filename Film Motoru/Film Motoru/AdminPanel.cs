using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Film_Motoru
{
    public partial class AdminPanel : Form
    {
        public AdminPanel(int _userID)
        {
            InitializeComponent();
            this.userID = _userID;
        }
        public int userID;
        OleDbConnection sqlConnection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=filmmotoru.accdb");
        OleDbCommand sqlCommand;
        OleDbDataReader sqlReader;

        #region Methods
        void AlertMessage(string _message, char _type)
        {
            AlertBox.Text = _message;
            if (_type == 's')
                AlertBox.kind = FlatUI.FlatAlertBox._Kind.Success;
            else if (_type == 'i')
                AlertBox.kind = FlatUI.FlatAlertBox._Kind.Info;
            else if (_type == 'e')
                AlertBox.kind = FlatUI.FlatAlertBox._Kind.Error;
            AlertBox.Show();
        }
        void FilmleriListele()
        {
            try
            {
                listFilm.Items.Clear();
                sqlConnection.Open();
                sqlCommand = new OleDbCommand("SELECT * FROM films", sqlConnection);
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    ListViewItem item = new ListViewItem(sqlReader["id"].ToString());
                    item.SubItems.Add(sqlReader["Film_Names"].ToString());
                    item.SubItems.Add(sqlReader["Imdb_names"].ToString());
                    item.SubItems.Add(sqlReader["Actors"].ToString());
                    item.SubItems.Add(sqlReader["Director"].ToString());
                    item.SubItems.Add(sqlReader["Genres"].ToString());
                    item.SubItems.Add(sqlReader["Film_Year"].ToString());
                    item.SubItems.Add(sqlReader["Imdb_point"].ToString());
                    item.SubItems.Add(sqlReader["Film_Time"].ToString());
                    listFilm.Items.Add(item);
                }
                sqlConnection.Close();
                sqlCommand.Dispose();
            }
            catch
            {
                AlertMessage("Film Listeleme Başarısız", 'e');
                sqlConnection.Close();
                sqlCommand.Dispose();
            }
        }
        void UyeleriListele()
        {
            try
            {
                listUyeler.Items.Clear();
                sqlConnection.Open();
                sqlCommand = new OleDbCommand("SELECT * FROM users", sqlConnection);
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    ListViewItem item = new ListViewItem(sqlReader["id"].ToString());
                    item.SubItems.Add(sqlReader["username"].ToString());
                    item.SubItems.Add(sqlReader["adi"].ToString());
                    item.SubItems.Add(sqlReader["soyad"].ToString());
                    item.SubItems.Add(sqlReader["dogumtarihi"].ToString());
                    item.SubItems.Add(sqlReader["permission"].ToString());

                    listUyeler.Items.Add(item);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                AlertMessage("Üyeler yüklenirken hata oluştu. " + ex.Message, 'e');
            }
        }
        #endregion
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            formSkin.Text = "Admin Panel: " + Ayarlar.Default.Username;

            FilmleriListele();
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                FilmleriListele();
            }
            else if (tabControl.SelectedIndex == 2)
            {
                UyeleriListele();
            }
        }

        #region FilmEkleTab
        private void btnResimKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                picFilm.Load(txtImageURL.Text);
            }
            catch (Exception)
            {
                AlertMessage("Geçerli bir resim adresi girin!", 'i');
            }
        }
        #endregion

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            try
            {
                AlertBox.Hide();
                if (txtActors.Text == "" || txtDescription.Text == "" || txtDirector.Text == "" || txtGenres.Text == "" || txtImageURL.Text == "" || txtImdbPoint.Text == "" || txtKaynak1.Text == "" || txtKaynak2.Text == "" || txtOriginalName.Text == "" || txtTime.Text == "" || txtTurkishName.Text == "" || txtYear.Text == "")
                {
                    AlertMessage("Boş Veri Bırakmayınız", 'i');
                }
                else
                {
                    sqlConnection.Open();
                    sqlCommand = new OleDbCommand("INSERT INTO films (Film_Names,Imdb_names,Film_Year,Imdb_point,Actors,Director,Genres,Film_Img,Film_Desc,p720,p1080,Film_Time) VALUES('" + txtTurkishName.Text + "','" + txtOriginalName.Text + "','" + txtYear.Text + "','" + txtImdbPoint.Text + "','" + txtActors.Text + "','" + txtDirector.Text + "','" + txtGenres.Text + "','" + txtImageURL.Text + "','" + txtDescription.Text + "','" + txtKaynak1.Text + "','" + txtKaynak2.Text + "','" + txtTime.Text + "')", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    sqlCommand.Dispose();
                    FilmleriListele();
                    AlertMessage("Ekleme Başarılı", 's');
                }
            }
            catch (Exception ex)
            {
                AlertMessage("Film eklenirken hata oluştu." + ex.Message, 'e');
                sqlConnection.Close();
                sqlCommand.Dispose();
            }
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = -1;
                if (listUyeler.SelectedItems.Count > 0)
                {
                    id = Convert.ToInt32(listUyeler.SelectedItems[0].SubItems[0].Text);
                }
                else
                {
                    AlertMessage("Listeden bir üye seçilmedi. Lütfen bir üye seçin.", 'i');
                }
                string komut = string.Format("DELETE FROM users WHERE id={0}", id);
                sqlConnection.Open();
                sqlCommand = new OleDbCommand(komut, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                AlertMessage("Üye başarılı bir şekilde silindi.", 's');
                sqlConnection.Close();
                sqlCommand.Dispose();
                UyeleriListele();
            }
            catch (Exception ex)
            {
                AlertMessage("Üye silinirken bir hata oluştu. " + ex.Message, 'e');
                sqlConnection.Close();
                sqlCommand.Dispose();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = -1;
                if (listFilm.SelectedItems.Count > 0)
                {
                    id = Convert.ToInt32(listFilm.SelectedItems[0].SubItems[0].Text);
                }
                else
                {
                    AlertMessage("Listeden bir film seçilmedi. Lütfen bir film seçin.", 'i');
                }
                string komut = string.Format("DELETE FROM films WHERE id={0}", id);
                sqlConnection.Open();
                sqlCommand = new OleDbCommand(komut, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                AlertMessage("Film başarılı bir şekilde silindi.", 's');
                sqlConnection.Close();
                sqlCommand.Dispose();
                FilmleriListele();
            }
            catch (Exception ex)
            {
                AlertMessage("Üye silinirken bir hata oluştu. " + ex.Message, 'e');
                sqlConnection.Close();
                sqlCommand.Dispose();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(Ayarlar.Default.UserID, Ayarlar.Default.Permission);
            homepage.Show();
            this.Hide();
            this.Dispose();
        }
    }
}

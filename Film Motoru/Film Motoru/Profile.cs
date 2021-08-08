using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Motoru
{
    public partial class Profile : Form
    {
        public Profile(int _userID)
        {
            InitializeComponent();
            this.userID = _userID;
        }

        OleDbConnection sqlConnection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=filmmotoru.accdb");
        OleDbCommand sqlCommand;
        OleDbDataReader sqlReader;
        public int userID;

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

        private void Profile_Load(object sender, EventArgs e)
        {
            pnlProfile.Parent = pnlMain;
            pnlProfilAyarları.Parent = pnlMain;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == txtPasswordAgain.Text)
                {
                    sqlConnection.Open();
                    sqlCommand = new OleDbCommand("UPDATE users SET username=@user, password=@password, dogumtarih=@tarih, adi=@ad, soyad=@soyad, email=@email WHERE id=@id", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@user", txtUsername.Text);
                    sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);
                    sqlCommand.Parameters.AddWithValue("@tarih", txtDogum.Text);
                    sqlCommand.Parameters.AddWithValue("@ad", txtName.Text);
                    sqlCommand.Parameters.AddWithValue("@soyad", txtSurname.Text);
                    sqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@id", userID);

                    sqlReader = sqlCommand.ExecuteReader();

                    if (sqlReader.Read())
                    {
                        AlertMessage("İşlem başarılı.", 's');
                    }
                }
                else
                {
                    AlertMessage("Şifreler uyuşmuyor.", 'i');
                }
            }
            catch (Exception ex)
            {
                AlertMessage("Bir hata oluştu." + ex.Message, 'e');
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(Ayarlar.Default.UserID, Ayarlar.Default.Permission);
            homepage.Show();
            this.Hide();
            this.Dispose();
        }

        private void üyeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pnlProfilAyarları.Visible = false;
            pnlProfile.Visible = true;
        }

        private void amdinPanelinineGeçişToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Ayarlar.Default.Permission == "Yönetici")
            {
                AdminPanel adminPanel = new AdminPanel(Convert.ToInt32(Ayarlar.Default.UserID));
                adminPanel.Show();
                this.Hide();
                this.Dispose();
            }
        }

        private void profileAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlProfilAyarları.Visible = true;
            pnlProfile.Visible = false;
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblTrack.Text = "Trackbar Değeri: " + metroTrackBar1.Value;
        }



        private void RadiobuttonChecked(object sender)
        {
            if (flatRadioButton1.Checked)
            {
                pnlProfilAyarları.BackColor = Color.FromArgb(60, 70, 75);
            }
            else if (flatRadioButton2.Checked)
            {
                pnlProfilAyarları.BackColor = Color.White;
            }
            else if (flatRadioButton3.Checked)
            {
                pnlProfilAyarları.BackColor = Color.Blue;
            }
        }

     
    }
}

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
using System.Security.Cryptography;
using System.Threading;

namespace Film_Motoru
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
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
        public byte[] ByteDonustur(string deger)
        {
            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                return ByteConverter.GetBytes(deger);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string SifreleMD5(string strGiris)
        {
            try
            {
                if (strGiris == "" || strGiris == null)
                {
                    throw new ArgumentNullException("Şifrelenecek veri yok");
                }
                else
                {
                    MD5CryptoServiceProvider sifre = new MD5CryptoServiceProvider();
                    byte[] arySifre = ByteDonustur(strGiris);
                    byte[] aryHash = sifre.ComputeHash(arySifre);
                    return BitConverter.ToString(aryHash);
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
        #endregion

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Size = new Size(320, 500);
            pnlLogin.Visible = false;
            pnlLogin.Enabled = false;
            pnlRegister.Visible = true;
            pnlRegister.Enabled = true;
            this.AcceptButton = btnRegister;
            formSkin.Text = "Kullanıcı Kayıt";
        }
        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Size = new Size(320, 425);
            pnlLogin.Visible = true;
            pnlLogin.Enabled = true;
            pnlRegister.Visible = false;
            pnlRegister.Enabled = false;
            this.AcceptButton = btnLogin;
            formSkin.Text = "Kullanıcı Girişi";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;

            if (username != null && password.Length >= 8)
            {
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new OleDbCommand("SELECT * FROM users WHERE username=@user AND password=@pass", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@user", username);
                    sqlCommand.Parameters.AddWithValue("@pass", SifreleMD5(password));
                    sqlReader = sqlCommand.ExecuteReader();

                    if (sqlReader.Read() == true)
                    {
                        string uyelik = sqlReader["permission"].ToString();
                        int userID = Convert.ToInt32(sqlReader["id"].ToString());

                        if (checkRememberMe.Checked)
                        {
                            Ayarlar.Default.RememberMe = true;
                            Ayarlar.Default.UserID = userID;
                            Ayarlar.Default.Username = username;
                            Ayarlar.Default.Password = SifreleMD5(password);
                            Ayarlar.Default.Permission = uyelik;
                            Ayarlar.Default.Save();
                        }
                        Homepage homepage = new Homepage(userID ,uyelik);
                        homepage.Show();
                        this.Hide();
                        this.Enabled = false;
                    }
                    else
                    {
                        AlertMessage("Kullanıcı adı veya şifre hatalı!", 'e');
                    }
                    sqlConnection.Close();
                    sqlCommand.Dispose();
                    sqlReader.Close();
                }
                catch (Exception)
                {
                    AlertMessage("Giriş işlemi sürerken bir hata oluştu!", 'e');
                    sqlConnection.Close();
                    sqlCommand.Dispose();
                    sqlReader.Close();
                }
            }
            else
                AlertMessage("Girilen bilgileri kontrol edin.", 'i');
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegisterUsername.Text;
            string email = txtRegisterEmail.Text;
            string password = txtRegisterPassword.Text;
            string passwordAgain = txtRegisterPasswordAgain.Text;
            string permission = "Üye";

            if (username.Length >= 5)
            {
                if (email.Contains("@gmail.com") || email.Contains("@hotmail.com") || email.Contains("@outlook.com"))
                {
                    if (password == passwordAgain)
                    {
                        if (password.Length >= 8)
                        {
                            try
                            {
                                sqlConnection.Open();
                                string komut = string.Format("INSERT INTO users([username], [email], [password], [permission]) VALUES('{0}', '{1}', '{2}', '{3}')", username, email, SifreleMD5(password), permission);
                                sqlCommand = new OleDbCommand(komut, sqlConnection);
                                sqlCommand.ExecuteNonQuery();
                                AlertMessage("Kayıt işlemi başarılı, giriş yapabilirsiniz.", 's');
                                this.Size = new Size(320, 400);
                                pnlLogin.Visible = true;
                                pnlLogin.Enabled = true;
                                pnlRegister.Visible = false;
                                pnlRegister.Enabled = false;
                            }
                            catch (Exception ex)
                            {
                                AlertMessage("Kayıt işlemi yapılırken bir hata oluştu!", 'e');
                                MessageBox.Show(ex.Message);
                                sqlConnection.Close();
                                sqlCommand.Dispose();
                            }

                        }
                        else
                            AlertMessage("Girilen parola 8 karakterden küçük olamaz!", 'i');
                    }
                    else
                        AlertMessage("Girilen şifreler birbiriyle uyuşmuyor.", 'i');
                }
                else
                    AlertMessage("Lütfen geçerli bir email adresi giriniz.", 'i');
            }
            else
                AlertMessage("Kullanıcı adı 5 karakterden küçük olamaz!", 'i');
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            if (Ayarlar.Default.RememberMe)
            {
                Homepage homepage = new Homepage(Convert.ToInt32(Ayarlar.Default.UserID.ToString()) ,Ayarlar.Default.Permission.ToString());
                homepage.Show();
                this.Enabled = false;
                this.Hide();
            }
        }
    }
}
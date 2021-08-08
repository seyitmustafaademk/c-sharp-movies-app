using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data.OleDb;

namespace Film_Motoru
{
    public partial class View : Form
    {
        public View(int _id, string _filmName, string _üyelik)
        {
            InitializeComponent();
            formSkin.Text = " İzle: " + _filmName;
            this.id = _id;
            this.üyelik = _üyelik;
        }
        #region ÖNEMLİ
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr child, IntPtr newParent);
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int IParam);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWindowVisible(IntPtr hWnd);
        private const int WM_SYSCOMMAND = 274;
        private const int SC_MAXIMIZE = 61488;

        #endregion

        public int id;
        public string üyelik;
        OleDbConnection sqlConnection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=filmmotoru.accdb");
        OleDbCommand sqlCommand;
        OleDbDataReader sqlReader;
        string filmP1080;
        string filmP720;
        string kalite = "";

        private void View_Load(object sender, EventArgs e)
        {
            if (true)
            {

            }
            sqlConnection.Open();
            sqlCommand = new OleDbCommand("SELECT * FROM films WHERE id=@id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlReader = sqlCommand.ExecuteReader();
            sqlReader.Read();
            string filmName = sqlReader["Film_Names"].ToString();
            string filmImdbName = sqlReader["Imdb_names"].ToString();
            string filmYear = sqlReader["Film_Year"].ToString();
            string filmImdbPoint = sqlReader["Imdb_point"].ToString();
            string filmDirector = sqlReader["Director"].ToString();
            string filmActors = sqlReader["Actors"].ToString();
            string filmGenres = sqlReader["Genres"].ToString();
            string filmImage = sqlReader["Film_Img"].ToString();
            string filmDesc = sqlReader["Film_Desc"].ToString();
            string filmTime = sqlReader["Film_Time"].ToString();
            filmP1080 = sqlReader["p1080"].ToString();
            filmP720 = sqlReader["p720"].ToString();

            picFilmImage.Load(filmImage);
            lblFilmDescription.Text = "Film Açıklaması:\n" + filmDesc;
            lblFilmName.Text = string.Format("{0}   |   {1}", filmName, filmImdbName);
            lblGenresTime.Text = string.Format("{0}   •   {1}", filmGenres, filmTime);
            lblDirector.Text += "     " + filmDirector;
            lblActors.Text += "     " + filmActors;
            lblYear.Text += "     " + filmYear;
            lblPointImdb.Text += "     " + filmImdbPoint;
            comboQuality.SelectedIndex = 0;
        }
        private void btnPlayFilm_Click(object sender, EventArgs e)
        {
            if (kalite != "")
            {
                pnlMain.Visible = false;
                pnlMain.Enabled = false;

                pnlView.Visible = true;
                pnlView.Enabled = true;
                pnlView.Dock = DockStyle.Bottom;
                pnlView.Size = new Size(this.Size.Width, this.Size.Height - 48);
                pnlView.BringToFront();

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Application.StartupPath + @"\Plugin\vlc.exe";
                startInfo.Arguments = string.Format("% vlc {0} -f", kalite);
                Process calistir = Process.Start(startInfo);
                while (calistir.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(calistir.MainWindowHandle))
                {
                    Thread.Sleep(10);
                    calistir.Refresh();
                }
                SetParent(calistir.MainWindowHandle, pnlView.Handle);
                SendMessage(calistir.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
            }
        }

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Process process in Process.GetProcessesByName("vlc"))
            {
                process.Kill();
            }
        }

        private void comboQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboQuality.SelectedIndex == 0)
                kalite = filmP720;
            else if (comboQuality.SelectedIndex == 1)
                kalite = filmP1080;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            this.Opacity = (double)trackBar.Value / 100;
        }
    }
}
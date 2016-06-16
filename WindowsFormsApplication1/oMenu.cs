using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class oMenu : Form
    {
        public oMenu()
        {
            InitializeComponent();
            // ustaw nazwę pierwszego buttona w zależności od tego czy nowy czy stary użytkownik
            //axWindowsMediaPlayer1.URL = "filmy/wMenu.avi";
            //axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        public void film(){
            axWindowsMediaPlayer1.URL = "filmy/wMenu.avi";
        }

        private void bKurs_Click(object sender, EventArgs e)
        {
            status.kurs.Show();
            status.kurs.film();
            status.poziom = 1;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
        }

        private void bWybor_Click(object sender, EventArgs e)
        {
            status.wybor.Show();
            status.wybor.film();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            status.info.Show();
            status.info.film();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
        }

        private void bWyniki_Click(object sender, EventArgs e)
        {
            status.wyniki.Show();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
        }

        private void wyjdz(object sender, EventArgs e)
        {
            status.kurs.Close();
            Application.Exit();
            status.menu.Close();
        }

        private void wyjdz(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

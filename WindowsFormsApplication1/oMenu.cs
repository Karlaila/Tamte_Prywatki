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
            // axWindowsMediaPlayer1 = "filmy/wMenu.mp4"
        }

        private void bKurs_Click(object sender, EventArgs e)
        {
            status.kurs.Show();
            this.Hide();
        }

        private void bWybor_Click(object sender, EventArgs e)
        {
            status.wybor.Show();
            this.Hide();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            status.info.Show();
            this.Hide();
        }

        private void bWyniki_Click(object sender, EventArgs e)
        {
            status.wyniki.Show();
            this.Hide();
        }

        private void wyjdz(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wyjdz(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

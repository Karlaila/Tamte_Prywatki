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
    public partial class oKurs : Form
    {
        private WMPLib.IWMPControls3 kontrCale;
        private WMPLib.IWMPControls3 kontrNogi;
        public oKurs()
        {
            InitializeComponent();
            // wideo w zależności od poziomu!
            //vNogi.URL = "filmy/wlogowanie.mp4";
            //vCale.URL = "filmy/wlogowanie.mp4";
            kontrCale = (WMPLib.IWMPControls3)vCale.Ctlcontrols;
            kontrNogi = (WMPLib.IWMPControls3)vNogi.Ctlcontrols;
        }

        private void pauza()
        {
            status.czypauza = true;
            // pauzowanie video
            if (kontrCale.get_isAvailable("pause"))
            {
                kontrCale.pause();
            }
            if (kontrNogi.get_isAvailable("pause"))
            {
                kontrNogi.pause();
            }
        }

        public void uruchom()
        {   
            // włączanie wideo
            if (kontrCale.get_isAvailable("play"))
            {
                kontrCale.play();
            }
            if (kontrNogi.get_isAvailable("play"))
            {
                kontrNogi.play();
            }
        }

        //dodać zapisywanie danych?! 
        private void bPowrot_Click(object sender, EventArgs e)
        {
            pauza();
            string caption = "Powrót do menu";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wrócić do menu i skończyć kurs?", caption, button, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // DANE?!
                status.menu.Show();
                status.kurs.Hide();
            }
            else
            {
                uruchom();
            }
        }

        private void bPauza_Click(object sender, EventArgs e)
        {
            pauza();
            // włączanie okna pauzy
            status.pauza.Show();
        }

        private void bPomoc_Click(object sender, EventArgs e)
        {
            pauza();
            status.pomoc.Show();
        }

        //dodać zapisywanie danych?! 
        private void wyjdz(object sender, FormClosingEventArgs e)
        {
            pauza();
            string caption = "Wyjście z kursu.";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Czy na pewno wyjść z aplikacji?", caption, button, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
            {
                uruchom();
            }
        }

        private void oKurs_Load(object sender, EventArgs e)
        {

        }

    }
}

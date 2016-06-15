using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class oKurs : Form
    {
        private WMPLib.IWMPControls3 kontrCale;
        private WMPLib.IWMPControls3 kontrNogi;
        private bool czytaniec = false;
        private int i = 0;

        UsbReader reader = null;
        Thread readerThread = null;

        public oKurs()
        {
            InitializeComponent();
            //vCale.uiMode = "none";
            vNogi.uiMode = "none";
            vCale.settings.autoStart = false;
        }

        public void film()
        {
            int p = status.poziom;

            vCale.URL = status.zFilmu1[p];
            vNogi.URL = status.zFilmu1[p];

            vNogi.settings.volume = 0;

            kontrCale = (WMPLib.IWMPControls3)vCale.Ctlcontrols;
            kontrNogi = (WMPLib.IWMPControls3)vNogi.Ctlcontrols;
            //vCale.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(vCale_PlayStateChange);
        }

        public void stop()
        {
            vNogi.Ctlcontrols.stop();
            vCale.Ctlcontrols.stop();
            this.Hide();
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
            status.reader.stop();
        }

        private void bPomoc_Click(object sender, EventArgs e)
        {
            pauza();
            status.pomoc.Show();
        }

        //rozpoczyna etap tańca
        private void taniec()
        {
            czytaniec = true;
            vCale.settings.setMode("loop", true);
            //vCale.Ctlenabled = true;
        }

        //dodać zapisywanie danych?! 
        private void wyjdz(object sender, FormClosingEventArgs e)
        {
            pauza();
            status.reader.stop();
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

        private void vCale_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case (int)WMPLib.WMPPlayState.wmppsPlaying:
                    if (czytaniec && timer1.Enabled == false)
                        timer1.Start();
                    break;
                case 8: //media ended
                    if (!czytaniec)
                    {
                        //przechodzimy do nowego video z krokami
                        vCale.URL = status.zFilmu2[status.poziom];
                        taniec();
                    }
                    break;
                case 10:
                    if (vCale.playState == WMPLib.WMPPlayState.wmppsStopped || vCale.playState == WMPLib.WMPPlayState.wmppsPaused)
                    {
                        kontrCale.play();
                    }
                    break;
                default:
                    label1.Text += ("Unknown State: " + e.newState.ToString());
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        public void setText(string msg)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(setText), new object[] { msg });
                return;
            }
            label1.Text = msg;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            status.reader.start();
        }

    }
}

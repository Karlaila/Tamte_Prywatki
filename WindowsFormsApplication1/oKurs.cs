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
        private int licznik = 0;

        UsbReader reader = null;
        Thread readerThread = null;
        //private enum pMata = status.buttonReader.PadButton
        // mata[i] = true -> przycisk i jest naciśnięty; mata[i] = 0 -> nie jest. 14? WYPEŁNIENIE strzałki
        private bool[] mata = { false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        // strzalka[i] = true -> przycisk i ma być naciśnięty; strzalka[i] = false -> nie ma. 14? BRZEGI strzałki
        private bool[] strzalka = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private int[] tKroki;
        private int[] sKroki;

        private void zerujStrzalke(){
            for(i = 0; i<(strzalka).Length; i++)
                strzalka[i] = false;
        }

        public oKurs()
        {
            InitializeComponent();
            //vCale.uiMode = "none";
            vNogi.uiMode = "none";
            vCale.settings.autoStart = false;
        }

        #region obsługa filmu
        public void film()
        {
            int p = status.poziom;

            vCale.URL = status.zFilmu1[p];
            vNogi.URL = status.zFilmu1[p];

            vNogi.settings.volume = 0;

            kontrCale = (WMPLib.IWMPControls3)vCale.Ctlcontrols;
            kontrNogi = (WMPLib.IWMPControls3)vNogi.Ctlcontrols;
            kontrCale.play();
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

        private void vCale_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                /*case (int)WMPLib.WMPPlayState.wmppsPlaying:
                    if (czytaniec && timer1.Enabled == false)
                        
                    break;*/
                case 8: //media ended
                    if (!czytaniec)
                    {
                        //przechodzimy do nowego video z krokami
                        vCale.URL = status.zFilmu2[status.poziom];
                        label1.Text = vCale.URL;
                        taniec();
                    }
                    break;
                /*case 10:
                    if (vCale.playState == WMPLib.WMPPlayState.wmppsStopped || vCale.playState == WMPLib.WMPPlayState.wmppsPaused)
                    {
                        kontrCale.play();
                    }
                    break;*/
                default:
                    label1.Text += ("Unknown State: " + e.newState.ToString());
                    break;
            }
        }

        #endregion

        #region obsługa przycisków
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
        //dodać zapisywanie danych?! 
        private void wyjdz(object sender, FormClosingEventArgs e)
        {
            pauza();
            // to nie działa z jakiegoś powodu :( 
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

        private void startButton_Click(object sender, EventArgs e)
        {
            //status.reader.start();
            timer1.Start();
            kontrCale.play();
        }

        #endregion

        #region gra
        //rozpoczyna etap tańca
        private void taniec()
        {
            czytaniec = true;
            vCale.settings.setMode("loop", true);
            sKroki = status.sKroki[status.poziom];
            tKroki = status.tKroki[status.poziom];
            licznik = 0;
            // pozycja startowa
            switch (status.poziom)
            {
                case 1:
                    strzalka[(int)status.pMata.TRIANGLE] = true;
                    strzalka[(int)status.pMata.DOWN] = true;
                    break;
                default:
                    zerujStrzalke();
                    break;
            }
        }

        private int dsecToTick(int dsec)
        {
            int ttick = timer1.Interval;
            return dsec * 100 / ttick;
        }
        private int iKroki = 0;
        bool zmiana = true;

        // przebieg gry
        private void timer1_Tick(object sender, EventArgs e)
        {
            licznik++;
            // sprawdzanie tablicy mata - czy są nowe naciśnięcia? 
            // jeśli poprawne wciśnięcia - itKroki++

            int prog = dsecToTick(tKroki[iKroki]);
            if (licznik < prog && zmiana)
            {
                zerujStrzalke();
                strzalka[sKroki[iKroki]] = true;
                label3.Text = sKroki[iKroki].ToString();
                zmiana = false;
            }
            else if (licznik >= prog)
            {
                //kontrCale.pause();
                // będzie trzeba dodać drugi licznik, żeby ten na pauzie działał
                zmiana = true;
                iKroki++;
                if (iKroki >= sKroki.Length)
                {
                    iKroki = 0;
                    licznik = 0;
                }
            }

            // uzupełnianie tablicy strzałki - co ma być naciśnięte?
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
        #endregion


    }
}

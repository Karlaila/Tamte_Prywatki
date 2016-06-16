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
        // mata[i] = true -> przycisk i jest naciśnięty; mata[i] = 0 -> nie jest. 11? WYPEŁNIENIE strzałki
        private bool[] mata = { false, false, false, false, false, false, false, false, false, false, false, false, false, false  };
        // strzalka[i] = true -> przycisk i ma być naciśnięty; strzalka[i] = false -> nie ma. 11? BRZEGI strzałki
        private bool[] strzalka = { false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private int[] tKroki;
        private int[] sKroki;

        // tymczasowo do sprawdzenia dzialania strzalek
        private int timeToStrzalka = 0;
        private bool[] strzalkaWcisnieta = { false, false, false, false, false, false, false, false, false, false };
        private int[] timeToWygasniecie = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private void zerujStrzalke(){
            strzalka = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false };
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
                        taniec();
                    }
                    break;
               /* case 10:
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
            status.reader.start();
            timer1.Start();
            kontrCale.play();
            status.kurs.Focus();
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
            /*
            //TESTY:
            //prymitywny kod(w tym momencie zapali Ci sie krzyzyk i strzalka w prawo)
            timeToStrzalka += timer1.Interval;
            for(int i = 0; i < strzalkaWcisnieta.Length; i++)
            {
                if (strzalkaWcisnieta[i])
                {
                    timeToWygasniecie[i] += timer1.Interval;
                }
            }
          
            if (timeToStrzalka >= 5000)
            {   //random 9 if int
                this.pbP.Image = global::WindowsFormsApplication1.Properties.Resources.prawo_obwod;
                this.pbGL.Image = global::WindowsFormsApplication1.Properties.Resources.x_obwod;
                timeToStrzalka = 0;
            }
            
            if (strzalkaWcisnieta[2] && timeToWygasniecie[2] >= 500)
            {
                this.pbP.Image = global::WindowsFormsApplication1.Properties.Resources.prawo_z;
                strzalkaWcisnieta[2] = false;
                timeToWygasniecie[2] = 0;
                
            }
            if (mata[2] == true)
            {
                this.pbP.Image = global::WindowsFormsApplication1.Properties.Resources.prawo_wcisniete;
                strzalkaWcisnieta[2] = true;
                mata[2] = false;
            }
            if (strzalkaWcisnieta[4] && timeToWygasniecie[4] >= 500)
            {
                this.pbGL.Image = global::WindowsFormsApplication1.Properties.Resources.x;
                strzalkaWcisnieta[4] = false;
                timeToWygasniecie[4] = 0;

            }
            if (mata[4] == true)
            {
                this.pbGL.Image = global::WindowsFormsApplication1.Properties.Resources.x_wcisniete;
                strzalkaWcisnieta[4] = true;
                mata[4] = false;
            }
            */


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

        #region setMata
        public void setMata(List<ButtonReader.PadButton> pressed)
        {
            foreach (ButtonReader.PadButton b in pressed)
            {   //10 przycisków
                if (b.Equals(ButtonReader.PadButton.UP))
                {
                    mata[0] = true;
                }
                else if(b.Equals(ButtonReader.PadButton.DOWN))
                {
                    mata[1] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.RIGHT))
                {
                    mata[2] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.LEFT))
                {
                    mata[3] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.X))
                {
                    mata[4] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.TRIANGLE))
                {
                    mata[5] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.SQUARE))
                {
                    mata[6] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.CIRCLE))
                {
                    mata[7] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.SELECT))
                {
                    mata[8] = true;
                    //za jaki przycisk mial odpowiadac select na macie? Pauza?
                    pauza();
                    status.pauza.Show();
                    status.reader.stop();
                }
                else if (b.Equals(ButtonReader.PadButton.START))
                {
                    mata[9] = true;
                    status.reader.start();
                    timer1.Start();
                    kontrCale.play();
                    status.kurs.Focus();
                }
               
            }
        }
        #endregion
        #region vCale_KeyDownEvent
        private void vCale_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {  
            //up -W
            if (e.nKeyCode == 87)
            {
                mata[0] = true;
            }
            //down - X
            if (e.nKeyCode == 88)
            {
                mata[1] = true;
            }
            //right -D
            if (e.nKeyCode == 68)
            {
                mata[2] = true;
            }
            //left - A
            if (e.nKeyCode == 65)
            {
                mata[3] = true;
            }
            //x - Q
            if (e.nKeyCode == 81)
            {
                mata[4] = true;
            }
            //TRAINGLE - Z
            if (e.nKeyCode == 90)
            {
                mata[5] = true;
            }
            //SQAURE - C
            if (e.nKeyCode == 67)
            {
                mata[6] = true;
            }
            //CIRCLE-E
            if (e.nKeyCode == 69)
            {
                mata[7] = true;
            }
            //select - spacja
            if (e.nKeyCode == 32)
            {
                mata[8] = true;
                pauza();
                status.pauza.Show();
                status.reader.stop();
            }
            //start - S
            if (e.nKeyCode == 83)
            {
                mata[9] = true;
                status.reader.start();
                timer1.Start();
                kontrCale.play();
                status.kurs.Focus();
            }
        }
        #endregion

    }
}

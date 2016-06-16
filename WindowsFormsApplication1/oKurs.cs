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
        #region inicjacje
        private WMPLib.IWMPControls3 kontrCale;
        private WMPLib.IWMPControls3 kontrNogi;
        private bool czytaniec = false;
        private int i = 0;
        private int licznik = 0;
        private int czas = 0;
        private int licznikZP = 0;

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
        private bool[] strzalkaWcisnieta = { false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private int[] timeToWygasniecie = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0 };

        private void zerujStrzalke(){
            strzalka = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        }
        #endregion

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
            startButton.Enabled = false;

            vCale.URL = status.zFilmu1[p];
            vNogi.URL = status.zFilmu1[p];

            vNogi.settings.volume = 0;

            kontrCale = (WMPLib.IWMPControls3)vCale.Ctlcontrols;
            kontrNogi = (WMPLib.IWMPControls3)vNogi.Ctlcontrols;
            
            licznik = 0;
            czas = 0;
            iKroki = 0;
            licznikZP = 0;
            vCale.settings.setMode("loop", false);
            czytaniec = false;

            kontrCale.play();
            //vCale.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(vCale_PlayStateChange);
        }

        public void stop()
        {
            vNogi.Ctlcontrols.stop();
            vCale.Ctlcontrols.stop();
            wyjdzM();
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
                case 9:
                    licznik = 0;
                    licznikZP = 0;
                    iKroki = 0;
                    break;
                default:
                   // label1.Text += (e.newState.ToString());
                    break;
            }
        }

        #endregion

        //zamykanie po sobie
        private void wyjdzM()
        {
            // DANE?!
            timer1.Stop();
            licznik = 0;
            czas = 0;
            iKroki = 0;
            licznikZP = 0;
            vCale.settings.setMode("loop", false);
            czytaniec = false;
            this.pbG.Image = global::WindowsFormsApplication1.Properties.Resources.gora;
            this.pbD.Image = global::WindowsFormsApplication1.Properties.Resources.dol;
            this.pbP.Image = global::WindowsFormsApplication1.Properties.Resources.prawo_z;
            this.pbL.Image = global::WindowsFormsApplication1.Properties.Resources.lewo;
            this.pbGL.Image = global::WindowsFormsApplication1.Properties.Resources.x;
            this.pbDL.Image = global::WindowsFormsApplication1.Properties.Resources.t;
            this.pbDP.Image = global::WindowsFormsApplication1.Properties.Resources.k;
            this.pbGP.Image = global::WindowsFormsApplication1.Properties.Resources.o;
        }

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
                wyjdzM();
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
            // Jeśli tryb bez podpowiedzi, to nie ma muzyki
            if (status.poziom % 4 != 3)
            {
                kontrCale.play();
            }
            status.kurs.Focus();
        }

        #endregion

        #region gra
        //rozpoczyna etap tańca
        private void taniec()
        {
            startButton.Enabled = true;
            czytaniec = true;
            vCale.settings.setMode("loop", true);
            sKroki = status.sKroki[status.poziom];
            tKroki = status.tKroki[status.poziom];
            licznik = 0;
            // pozycja startowa
            /*
            if (i == 6) this.pbG.Image = global::WindowsFormsApplication1.Properties.Resources.gora_obwod;
            if (i == 5) this.pbD.Image = global::WindowsFormsApplication1.Properties.Resources.dol_obwod;
            if (i == 7) this.pbP.Image = global::WindowsFormsApplication1.Properties.Resources.prawo_obwod;
            if (i == 4) this.pbL.Image = global::WindowsFormsApplication1.Properties.Resources.lewo_obwod;
            if (i == 10) this.pbGL.Image = global::WindowsFormsApplication1.Properties.Resources.x_obwod;
            if (i == 9) this.pbDL.Image = global::WindowsFormsApplication1.Properties.Resources.t_obwod;
            if (i == 8) this.pbDP.Image = global::WindowsFormsApplication1.Properties.Resources.k_obwod;
            if (i == 11) this.pbGP.Image = global::WindowsFormsApplication1.Properties.Resources.o_obwod;*/
            switch (status.poziom)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    strzalka[(int)status.pMata.TRIANGLE] = true;
                    strzalka[(int)status.pMata.DOWN] = true;
                    this.pbD.Image = global::WindowsFormsApplication1.Properties.Resources.dol_obwod;
                    this.pbDL.Image = global::WindowsFormsApplication1.Properties.Resources.t_obwod;
                    break;
                default:
                    zerujStrzalke();
                    break;
            }

        }
        //pomocnicze
        private int dsecToTick(int dsec)
        {
            int ttick = timer1.Interval;
            return dsec * 100 / ttick;
        }
        private int tickToDsec(int tick)
        {
            int ttick = timer1.Interval;
            return tick * ttick/100;
        }
        private int iKroki = 0;
        bool zmiana = true;
        bool poprawny = false;
        bool vPauza = false;
        int prog = 0;
        int isKroki = 0;

        // przebieg gry
        private void timer1_Tick(object sender, EventArgs e)
        {
            czas++;
            prog = dsecToTick(tKroki[iKroki]);
            isKroki = iKroki % sKroki.Length;

            #region poprawność
            // Czy poprawny?
            if (mata[sKroki[isKroki]] && !poprawny)
            {
                poprawny = true;
                // zliczenie punktów
            }
            #endregion

            #region zmiana kroków - poziomy 2,3,4
            if (status.poziom % 4 != 1)
            {
                licznik++;
                if (licznik < prog && zmiana)
                {
                    zerujStrzalke();
                    strzalka[sKroki[isKroki]] = true;
                    label3.Text = "1zmiana kroków";
                    zmiana = false;
                    poprawny = false;
                }
                else if (licznik >= prog)
                {
                    // czyli gdy koniec czasu na krok, dajemy sygnał do zmiany kroku, bez pauzowania
                    label3.Text = "2bez pauzy do zmiany";
                    zmiana = true;
                    iKroki++;
                    if (iKroki >= tKroki.Length)
                    {
                        iKroki = 0;
                        licznik = 0;
                    }
                }
                if (licznik >= status.czasyKonca[status.poziom]){
                    licznik = 0;
                }
            }
            #endregion

            #region zmiana kroków - poziomy 1
            label2.Text = tickToDsec(licznikZP).ToString() + " " + iKroki.ToString() + " " + isKroki.ToString();
            if (status.poziom % 4 == 1)
            {
                if (licznikZP < prog && zmiana)
                {
                    licznikZP++;
                    zerujStrzalke();
                    strzalka[sKroki[isKroki]] = true;
                    label3.Text = "1zmiana kroków";
                    zmiana = false;
                    poprawny = false;
                }
                else if (licznikZP >= prog)
                {
                    if (poprawny)
                    {
                        licznikZP++;
                        label3.Text = "3. poprawny pauza";
                        //nie pauzujemy, zmieniamy krok na następny)
                        if (vPauza)
                        {
                            vPauza = false;
                            kontrCale.play();
                            label3.Text = "3a. odpałzowanie";
                        }
                        zmiana = true;
                        iKroki++;
                        if (iKroki >= tKroki.Length)
                        {
                            iKroki = 0;
                        }
                    }
                    else
                    {
                        //czekamy aż naciśnie poprawny
                        if (!vPauza)
                        {
                            label3.Text = "4. niepoprawny pauza";
                            vPauza = true;
                            kontrCale.pause();
                        }
                    }
                }
                else
                { licznikZP++; }
                if (tickToDsec(licznikZP) >= status.czasyKonca[status.poziom])
                {
                    licznikZP = 0;
                }
            }
            #endregion

            #region strzałki
            for (i = 0; i < strzalka.Length; i++)
            {
                //if (strzalkaWcisnieta[i] && timeToWygasniecie[i] >= 500)
                #region powrot do zwyklych strzalek
                if (!strzalka[i] && !mata[i])
                {
                    if (i == 6) this.pbG.Image = global::WindowsFormsApplication1.Properties.Resources.gora;
                    if (i == 5) this.pbD.Image = global::WindowsFormsApplication1.Properties.Resources.dol;
                    if (i == 7) this.pbP.Image = global::WindowsFormsApplication1.Properties.Resources.prawo_z;
                    if (i == 4) this.pbL.Image = global::WindowsFormsApplication1.Properties.Resources.lewo;
                    if (i == 10) this.pbGL.Image = global::WindowsFormsApplication1.Properties.Resources.x;
                    if (i == 9) this.pbDL.Image = global::WindowsFormsApplication1.Properties.Resources.t;
                    if (i == 8) this.pbDP.Image = global::WindowsFormsApplication1.Properties.Resources.k;
                    if (i == 11) this.pbGP.Image = global::WindowsFormsApplication1.Properties.Resources.o;
                    //this.pbP.Image = global::WindowsFormsApplication1.Properties.Resources.prawo_z;
                    strzalkaWcisnieta[i] = false;
                    timeToWygasniecie[i] = 0;
                }else
                #endregion

                #region sprawdzanie tablicy mata
                if (mata[i] == true)
                {
                    if (strzalka[i] == true)
                    {
                        if (i == 6) this.pbG.Image = global::WindowsFormsApplication1.Properties.Resources.gora_wcisniete_obwod;
                        if (i == 5) this.pbD.Image = global::WindowsFormsApplication1.Properties.Resources.dol_wcisniete_obwod;
                        if (i == 7) this.pbP.Image = global::WindowsFormsApplication1.Properties.Resources.prawo_wcisniete_obwod;
                        if (i == 4) this.pbL.Image = global::WindowsFormsApplication1.Properties.Resources.lewo_wcisniete_obwod;
                        if (i == 10) this.pbGL.Image = global::WindowsFormsApplication1.Properties.Resources.x_wcisniete_obwod;
                        if (i == 9) this.pbDL.Image = global::WindowsFormsApplication1.Properties.Resources.t_wcisniete_obwod;
                        if (i == 8) this.pbDP.Image = global::WindowsFormsApplication1.Properties.Resources.k_wcisniete_obwod;
                        if (i == 11) this.pbGP.Image = global::WindowsFormsApplication1.Properties.Resources.o_wcisniete_obwod;
                    }
                    else
                    {
                        if (i == 6) this.pbG.Image = global::WindowsFormsApplication1.Properties.Resources.gora_wcisniete;
                        if (i == 5) this.pbD.Image = global::WindowsFormsApplication1.Properties.Resources.dol_wcisniete;
                        if (i == 7) this.pbP.Image = global::WindowsFormsApplication1.Properties.Resources.prawo_wcisniete;
                        if (i == 4) this.pbL.Image = global::WindowsFormsApplication1.Properties.Resources.lewo_wcisniete;
                        if (i == 10) this.pbGL.Image = global::WindowsFormsApplication1.Properties.Resources.x_wcisniete;
                        if (i == 9) this.pbDL.Image = global::WindowsFormsApplication1.Properties.Resources.t_wcisniete;
                        if (i == 8) this.pbDP.Image = global::WindowsFormsApplication1.Properties.Resources.k_wcisniete;
                        if (i == 11) this.pbGP.Image = global::WindowsFormsApplication1.Properties.Resources.o_wcisniete;
                    }
                } else
                #endregion
                #region wysiwetlanie strzalek do nacisniecia
                if (strzalka[i] == true)
                {
                    if (i == 6) this.pbG.Image = global::WindowsFormsApplication1.Properties.Resources.gora_obwod;
                    if (i == 5) this.pbD.Image = global::WindowsFormsApplication1.Properties.Resources.dol_obwod;
                    if (i == 7) this.pbP.Image = global::WindowsFormsApplication1.Properties.Resources.prawo_obwod;
                    if (i == 4) this.pbL.Image = global::WindowsFormsApplication1.Properties.Resources.lewo_obwod;
                    if (i == 10) this.pbGL.Image = global::WindowsFormsApplication1.Properties.Resources.x_obwod;
                    if (i == 9) this.pbDL.Image = global::WindowsFormsApplication1.Properties.Resources.t_obwod;
                    if (i == 8) this.pbDP.Image = global::WindowsFormsApplication1.Properties.Resources.k_obwod;
                    if (i == 11) this.pbGP.Image = global::WindowsFormsApplication1.Properties.Resources.o_obwod;

                }
                #endregion
            }
            #endregion

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
                    mata[6] = true;
                }
                else if(b.Equals(ButtonReader.PadButton.DOWN))
                {
                    mata[5] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.RIGHT))
                {
                    mata[7] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.LEFT))
                {
                    mata[4] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.X))
                {
                    mata[10] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.TRIANGLE))
                {
                    mata[9] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.SQUARE))
                {
                    mata[8] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.CIRCLE))
                {
                    mata[11] = true;
                }
                else if (b.Equals(ButtonReader.PadButton.SELECT))
                {
                    mata[12] = true;
                    //za jaki przycisk mial odpowiadac select na macie? Pauza?
                    pauza();
                    status.pauza.Show();
                    status.reader.stop();
                }
                else if (b.Equals(ButtonReader.PadButton.START))
                {
                    mata[13] = true;
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
                mata[6] = true;
            }
            //down - X
            if (e.nKeyCode == 88)
            {
                mata[5] = true;
            }
            //right -D
            if (e.nKeyCode == 68)
            {
                mata[7] = true;
            }
            //left - A
            if (e.nKeyCode == 65)
            {
                mata[4] = true;
            }
            //x - Q
            if (e.nKeyCode == 81)
            {
                mata[10] = true;
            }
            //TRAINGLE - Z
            if (e.nKeyCode == 90)
            {
                mata[9] = true;
            }
            //SQAURE - C
            if (e.nKeyCode == 67)
            {
                mata[8] = true;
            }
            //CIRCLE-E
            if (e.nKeyCode == 69)
            {
                mata[11] = true;
            }
            //select - spacja
            if (e.nKeyCode == 32)
            {
                mata[12] = true;
                pauza();
                status.pauza.Show();
                status.reader.stop();
            }
            //start - S
            if (e.nKeyCode == 83)
            {
                mata[13] = true;
                status.reader.start();
                timer1.Start();
                kontrCale.play();
                status.kurs.Focus();
            }
        }

        private void vCale_KeyUpEvent(object sender, AxWMPLib._WMPOCXEvents_KeyUpEvent e)
        {
            //up -W
            if (e.nKeyCode == 87)
            {
                mata[6] = false;
            }
            //down - X
            if (e.nKeyCode == 88)
            {
                mata[5] = false;
            }
            //right -D
            if (e.nKeyCode == 68)
            {
                mata[7] = false;
            }
            //left - A
            if (e.nKeyCode == 65)
            {
                mata[4] = false;
            }
            //x - Q
            if (e.nKeyCode == 81)
            {
                mata[10] = false;
            }
            //TRAINGLE - Z
            if (e.nKeyCode == 90)
            {
                mata[9] = false;
            }
            //SQAURE - C
            if (e.nKeyCode == 67)
            {
                mata[8] = false;
            }
            //CIRCLE-E
            if (e.nKeyCode == 69)
            {
                mata[11] = false;
            }
        }
        #endregion

    }
}

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

namespace WindowsFormsApplication1
{
    public partial class oLogowania : Form
    {
        private bool wybczynowy = false; //0 - wybierz, 1 - nowy
        private int lUzytk = 0;
        private List<string> Uzytk;
        //private WMPLib.IWMPControls3 kontr;

        public oLogowania()
        {
            InitializeComponent();
            lUzytk = 0;
            Uzytk = new List<string>();
            string U;
            try
            {
                StreamReader file = new StreamReader(status.pUzytk, true);
                while ((U = file.ReadLine()) != null)
                {
                    Uzytk.Add(U);
                    lUzytk++;
                    cBwybierz.Items.Add(U);
                }
                file.Close();
            }
            catch (Exception ex)
            {
                File.Create(status.pUzytk);
            }
            wmpPlayer.URL = "filmy/wLogowanie.mp4";
            wmpPlayer.Ctlcontrols.play();
            cBwybierz.Enabled = false;
            tBnazwa.Enabled = false;
            status.menu = new oMenu();
            status.wybor = new oWybor();
            status.kurs = new oKurs();
            status.info = new oInformacje();
            status.wyniki = new oWyniki();
            status.pauza = new oPauza();
            status.pomoc = new oPomoc();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //rBnowe.Checked = false;
            //rBwybierz.Checked = true;
            cBwybierz.Enabled = true;
            tBnazwa.Enabled = false;
            wybczynowy = false;
            wmpPlayer.Ctlcontrols.pause();
        }

        private void rBnowe_CheckedChanged(object sender, EventArgs e)
        {
            //rBnowe.Checked = true;
            //rBwybierz.Checked = false;
            cBwybierz.Enabled = false;
            tBnazwa.Enabled = true;
            wybczynowy = true;
        }

        private void bAnuluj_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            bool czyOk = true;
            string nazwa = null;
            #region ustawienia
            if (wybczynowy)
            {
                //nowy
                nazwa = tBnazwa.Text;

                // czy nazwa jest wystarczająco długa?
                if(nazwa.Length >=1) czyOk = true;
                else MessageBox.Show("Nie podano nazwy użytkownika");
                
                // czy nazwa już istnieje? 
                if (Uzytk.Contains(nazwa) && czyOk)
                {
                    MessageBox.Show("Użytkownik o podanej nazwie już istnieje, wpisz inną nazwę.");
                    czyOk = false;
                }
                else if (czyOk)
                {
                    // nowy plik
                    File.Create(status.pDane + nazwa);
                    // dodaj do bazy użytkowników
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(status.pUzytk, true))
                    {
                        file.WriteLine(nazwa);
                    }
                }
            }
            else
            {
                nazwa = cBwybierz.SelectedItem.ToString();
                if (File.Exists(status.pDane + nazwa))
                {
                    // wczytaj ostatnio ukończony poziom!
                }
                else
                {
                    // poziom = 0;
                    File.Create(status.pDane + nazwa);
                }
                czyOk = true;
            }
            #endregion
            if (czyOk)
            {
                status.nUzytk = nazwa;
                //oMenu omenu = new oMenu();
                /*if (kontr.get_isAvailable("stop"))
                {
                    kontr.stop();
                }*/
                this.Hide();
                status.menu.Show();
            }
        }

        private void axWindowsMediaPlayer1_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            /*try
            // If the Player encounters a corrupt or missing file, 
            // show the hexadecimal error code and URL.
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
                                + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
            // In case pMediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error.");
            } */
        }

    }
}

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
    public partial class oInformacje : Form
    {
        public oInformacje()
        {
            InitializeComponent();
            tekst.Enabled = false;
            tekst.Text = "Aplikacja Tamte Prywatki jest to projekt stworzony przez Karolinę Drobotowicz i Weronikę Ważną. Jest to gra, której głównym celem jest aktywizacja osób starszych. W niej można nauczyć sie podstawowych króków Walca Angielskiego oraz potańczyć z muzyką. Możliwe jest również podejrzenie dotychczasowych wyników ćwiczeń. Planowane jest rozszerzenie funkcjonalności programu.\nAplikacja ta powstała w ramach projektu Telematyka na semestrze pierwszym studiów magisterskich Inżynierii Biomedycznej w roku 2016.";
        }

        public void film()
        {
            player.URL = "filmy/wInfo.avi";
        }

        private void bPowrot_Click(object sender, EventArgs e)
        {
            status.menu.Show();
            status.menu.film();
            player.Ctlcontrols.stop();
            this.Hide();
        }

        private void oInformacje_FormClosing(object sender, FormClosingEventArgs e)
        {
            status.menu.Show();
            status.menu.film();
            player.Ctlcontrols.stop();
            this.Hide();
        }

    }
}

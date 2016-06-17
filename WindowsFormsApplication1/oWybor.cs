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
    public partial class oWybor : Form
    {
        public oWybor()
        {
            InitializeComponent();
            wpoziom.Enabled = false;
            bWybierz.Enabled = false;
        }

        public void film()
        {
            player.URL = "filmy/wWybor.avi";
        }

        private void bPowrot_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            status.menu.Show();
            status.menu.film();
            this.Hide();
        }

        private void oWybor_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Ctlcontrols.stop();
            status.menu.Show();
            status.menu.film();
            this.Hide();
        }

        private void wKroku_Enter(object sender, EventArgs e)
        {
            wpoziom.Enabled = true;
        }

        private void bWybierz_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            if (rbKP.Checked) i = 1;
            if (rbKL.Checked) i = 2;
            if (rbOP.Checked) i = 3;
            if (rbOL.Checked) i = 4;
            if (rbKPK.Checked) j = 1;
            if (rbC.Checked) j = 2;
            if (rbBP.Checked) j = 3;
            if (rbM.Checked) j = 4;

            status.poziom = i * j;

            player.Ctlcontrols.stop();
            this.Hide();
            status.kurs.Show();
            status.kurs.film();
        }

        private void wpoziom_Enter(object sender, EventArgs e)
        {
            bWybierz.Enabled = true;
        }
    }
}

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
    public partial class Gratulacje : Form
    {
        public Gratulacje()
        {
            InitializeComponent();
            richTextBox1.Text = "Gratulacje! Udało Ci się ukończyć ten poziom! Aby przejść do kolejnego naciśnij pole START lub przycisk poniżej. Aby potwórzyć ćwiczenie, naciśnij pole SELECT lub przycisk poniżej. Aby powrócić do menu naciśnij przycisk poniżej.";
            richTextBox1.Enabled = false;
        }

        public void filmy()
        {
            player.URL = "filmy/wGratulacje.avi";
        }

        private void bPowrot_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            this.Hide();
            status.menu.Show();
            status.menu.film();
        }

        private void bPowtorz_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            this.Hide();
            status.kurs.Show();
            status.kurs.film();
        }

        private void bPrzejdz_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            status.poziom++;
            this.Hide();
            status.kurs.Show();
            status.kurs.film();
        }


    }
}

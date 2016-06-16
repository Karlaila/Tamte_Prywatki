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
            richTextBox1.Text = "Tutaj będzie to co jest mówione na filmie. Film póki co inny.";
        }

        public void filmy()
        {
            player.URL = "filmy/wInfo.avi";
        }

        private void bPowrot_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            this.Hide();
            status.kurs.Hide();
            status.menu.Show();
            status.menu.film();
        }

        private void bPowtorz_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            this.Hide();
            status.kurs.film();
        }

        private void bPrzejdz_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            status.poziom++;
            this.Hide();
            status.kurs.film();
        }


    }
}

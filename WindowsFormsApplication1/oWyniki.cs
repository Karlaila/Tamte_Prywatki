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
    public partial class oWyniki : Form
    {
        public oWyniki()
        {
            InitializeComponent();
        }

        private void bPowrot_Click(object sender, EventArgs e)
        {
            status.menu.Show();
            status.menu.film();
            this.Hide();
        }

        private void oWyniki_FormClosing(object sender, FormClosingEventArgs e)
        {
            status.menu.Show();
            status.menu.film();
            this.Hide();
        }
    }
}

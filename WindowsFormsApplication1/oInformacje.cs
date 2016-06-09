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
        }

        private void bPowrot_Click(object sender, EventArgs e)
        {
            status.menu.Show();
            this.Hide();
        }

        private void oInformacje_FormClosing(object sender, FormClosingEventArgs e)
        {
            status.menu.Show();
            this.Hide();
        }

    }
}

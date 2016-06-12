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
    public partial class oPauza : Form
    {
        public oPauza()
        {
            InitializeComponent();
        }

        private void bPowrotKurs_Click(object sender, EventArgs e)
        {
            status.kurs.uruchom();
            status.reader.start();
            this.Hide();
            
        }

        private void oPauza_FormClosing(object sender, FormClosingEventArgs e)
        {
            status.czypauza = false;
            status.kurs.uruchom();
            this.Hide();
        }
    }
}

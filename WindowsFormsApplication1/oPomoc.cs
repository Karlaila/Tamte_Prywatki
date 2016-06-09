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
    public partial class oPomoc : Form
    {
        public oPomoc()
        {
            InitializeComponent();
        }

        private void bPowrot_Click(object sender, EventArgs e)
        {
            status.kurs.uruchom();
            this.Hide();
        }

        private void oPomoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            status.kurs.uruchom();
            this.Hide();
        }
    }
}

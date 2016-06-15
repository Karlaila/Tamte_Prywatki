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
            richTextBox1.Enabled = false;
            richTextBox1.Text = "PAUZA. W celu powrotu do ćwiczenia naciśnij pierwszy z guzików lub START na macie. W celu powrotu do menu naciśnij drugi z guzików lub SELECT na macie.";
        }

        private void bPowrotKurs_Click(object sender, EventArgs e)
        {
            status.kurs.uruchom();
            this.Hide();
        }

        private void oPauza_FormClosing(object sender, FormClosingEventArgs e)
        {
            status.kurs.uruchom();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caption = "Powrót do menu";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wrócić do menu i skończyć kurs?", caption, button, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // DANE?!
                status.kurs.stop();
                this.Hide();
                status.menu.Show();
                status.menu.film();
            }
        }
    }
}

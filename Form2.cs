using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEvent25_26
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultat = MessageBox.Show(
            "Voulez-vous vraiment quitter ?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit(); // ferme complètement l’application
            }
        }
    }
}

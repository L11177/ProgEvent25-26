using System.Windows.Forms;

namespace ProgEvent25_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BouttonPermuter_Click(object sender, EventArgs e)
        {
            Image temp = Avion.Image;
            Avion.Image = Voiture.Image;
            Voiture.Image = temp;
        }

        private void BoutonDisparition_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}

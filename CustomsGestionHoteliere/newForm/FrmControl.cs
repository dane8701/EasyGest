using CustomsGestionHoteliere.newForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere
{
    public partial class NouveauFormParent : Form
    {
        public NouveauFormParent()
        {
            InitializeComponent();
        }

        private void btCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            Form f = new FrmGestionClient();
            f.Show();
        }

        private void NouveauFormParent_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            Form f = new FrmGestionFactures();
            f.Show();
        }

        private void guna2GradientTileButton8_Click(object sender, EventArgs e)
        {
            Form f = new FrmGestionParametre();
            f.Show();
        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            Form f = new FrmGestionUtilisateur();
            f.Show();
        }

        private void guna2GradientTileButton9_Click(object sender, EventArgs e)
        {
            Form f = new FrmGestionPlats();
            f.Show();
        }
    }
}

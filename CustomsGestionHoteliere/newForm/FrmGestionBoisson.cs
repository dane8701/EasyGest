using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere.newForm
{
    public partial class FrmGestionBoisson : Form
    {
        public FrmGestionBoisson()
        {
            InitializeComponent();
        }

        private void AjouterBoisson_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void FrmGestionBoisson_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet.TypeBoissons'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeBoissonsTableAdapter.Fill(this.easyGestDataSet.TypeBoissons);
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet.BOISSONS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bOISSONSTableAdapter.Fill(this.easyGestDataSet.BOISSONS);

        }
    }
}

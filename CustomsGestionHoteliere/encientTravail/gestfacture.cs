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
    public partial class gestfacture : Form
    {
        public gestfacture()
        {
            InitializeComponent();
        }

        private void gestfacture_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet.facture'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.factureTableAdapter.Fill(this.gset_hotelDataSet.facture);


        }

        private void guna2TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            
          factureBindingSource.EndEdit();
            factureTableAdapter.Insert(int.Parse(cbidfactu.Text.Trim()),cbdatefact.Value, int.Parse(cbmttotal.Text.Trim()),cbmodepaiement.Text.Trim(),int.Parse(cbidclient.Text.Trim()), int.Parse(cbidagent.Text.Trim()), int.Parse(cbidreserv.Text.Trim()), int.Parse(cbdure.Text.Trim()));
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

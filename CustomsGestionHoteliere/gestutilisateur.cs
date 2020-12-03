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
    public partial class gestutilisateur : Form
    {
        public gestutilisateur()
        {
            InitializeComponent();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                agentTableAdapter.Insert(int.Parse(txtid.Text), txtnom.Text.Trim(), txtadress.Text.Trim(), txtsex.Text.Trim(), txttel.Text.Trim(), txtpost.Text.Trim(), cbsatut.Text.Trim(), txtpsw.Text.Trim(), txtusername.Text.Trim());
                MessageBox.Show("reussite");
            }
            catch 
            {
                MessageBox.Show("echec");
            }
        }

        private void utilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet.agent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.agentTableAdapter.Fill(this.gset_hotelDataSet.agent);
      }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere
{
    public partial class enregistreClient : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=gset_hotel;Integrated Security=True");
        public enregistreClient()
        {
            InitializeComponent();
        }

        private void enregistreClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet2.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.gset_hotelDataSet2.client);
          

        }

        private void BtSaveClt_Click(object sender, EventArgs e)
        { 
            try
            {
                
                clientBindingSource.EndEdit();
                clientTableAdapter.Insert( nom.Text.Trim(), cbsex.Text.Trim(), adress.Text.Trim(), int.Parse(txttelephone.Text.Trim()), email.Text.Trim(), nationalit.Text.Trim());
                MessageBox.Show("reussite");
            }
            catch
            {
                MessageBox.Show("echec");
            }
        
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

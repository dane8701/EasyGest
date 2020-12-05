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

namespace CustomsGestionHoteliere.newForm
{
    public partial class FrmGestionClient : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog = EasyGest; Integrated Security = True");
        SqlCommand com = new SqlCommand();
        public FrmGestionClient()
        {
            InitializeComponent();
        }

        private void addUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void FrmGestionClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet.CLIENTS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           // this.cLIENTSTableAdapter.Fill(this.easyGestDataSet.CLIENTS);

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            materialTabControl1.SelectTab(0);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            materialTabControl1.SelectTab(1);
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("insert_client", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idClient", txtidClient.Text);
            adp.SelectCommand.Parameters.AddWithValue("@nomClient", txtnomClient.Text);
            adp.SelectCommand.Parameters.AddWithValue("@prenomClient", txtprenomClient.Text);
            adp.SelectCommand.Parameters.AddWithValue("@telephone", int.Parse(txttelephone.Text));
            adp.SelectCommand.Parameters.AddWithValue("@adresse", txtadresse.Text);
            adp.SelectCommand.Parameters.AddWithValue("@TABLESidTable", int.Parse(txtTABLESidTable.Text));
            adp.SelectCommand.Parameters.AddWithValue("@COMMANDESidComande", int.Parse(txtCOMMANDESidCommande.Text));
            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            con.Close();
        }
    }
}

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
    public partial class FrmGestionCommande : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EasyGest;Integrated Security=True");
        public FrmGestionCommande()
        {
            InitializeComponent();
        }

        private void addUtilisateur_Click(object sender, EventArgs e)
        {

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

        private void FrmGestionCommande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet5.COMMANDES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cOMMANDESTableAdapter.Fill(this.easyGestDataSet5.COMMANDES);
           
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            cOMMANDESBindingSource.EndEdit();

            this.cOMMANDESTableAdapter.Insert(int.Parse(txtIdCommande.Text.Trim()), cbDatefCommande.Value, int.Parse(txtQuantite.Text.Trim()), int.Parse(txtPrixUnitaire.Text.Trim()), int.Parse(txtprg.Text.Trim()), int.Parse(txtmenueID.Text.Trim())) ;

        }

        private void txtPrixGlobal_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
              cOMMANDESBindingSource.EndEdit();
            this.cOMMANDESTableAdapter.Update(this.easyGestDataSet5.COMMANDES);

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string query = "SELECT * from FACTURES";
            SqlDataAdapter sdt = new SqlDataAdapter(query, con);
            DataTable das = new DataTable();
            sdt.Fill(das);
            bunifuCustomDataGrid4.DataSource = das;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("search_commande", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idComande", guna2GradientButton4.Text.Trim());
            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            bunifuCustomDataGrid4.DataSource = Dat;
            con.Close();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();        }
    }
}

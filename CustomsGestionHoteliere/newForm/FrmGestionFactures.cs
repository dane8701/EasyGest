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
    public partial class FrmGestionFactures : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = EasyGest; Integrated Security = True");
        SqlCommand com = new SqlCommand();
        public FrmGestionFactures()
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

        private void guna2Button16_Click(object sender, EventArgs e)
        {
           
            try
            {
                fACTURESBindingSource.EndEdit();
                fACTURESTableAdapter.Insert(int.Parse(txtidFacture.Text.Trim()), dateFacturation.Value, int.Parse(txtmontantTotal.Text.Trim()), txtNomPlat.Text.Trim(), int.Parse(txtQuantiter.Text.Trim()));
                MessageBox.Show("enregistrer");
            }
            catch
            {
                MessageBox.Show("donner invalide ");
            }
        }

        private void FrmGestionFactures_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet10.FACTURES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fACTURESTableAdapter.Fill(this.easyGestDataSet10.FACTURES);
         
           

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            fACTURESBindingSource.EndEdit();

            this.fACTURESTableAdapter.Update(this.easyGestDataSet10.FACTURES);

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {


            if (con.State == ConnectionState.Closed)
                con.Open();
            string query = "SELECT * from CLIENTS ";
            SqlDataAdapter sdt = new SqlDataAdapter(query, con);
            DataTable das = new DataTable();
            sdt.Fill(das);
            bunifuCustomDataGrid4.DataSource = das;

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

           if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("search_facture", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idFacture", guna2GradientButton4.Text.Trim());
            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            bunifuCustomDataGrid4.DataSource = Dat;
            con.Close();
        }

        private void txtQuantiter_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Form f = new FrmPreview();
            f.Show();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

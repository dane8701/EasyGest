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
    public partial class FrmGestionUtilisateur : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EasyGest;Integrated Security=True");


        public FrmGestionUtilisateur()
        {
            InitializeComponent();
        }

        private void slider_Click(object sender, EventArgs e)
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

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("search_utilisateur", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@nomUtilisateur", guna2TextBox4.Text.Trim());
            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            bunifuCustomDataGrid4.DataSource = Dat;
            con.Close();
        }

        private void FrmGestionUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet3.UTILISATEURS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.uTILISATEURSTableAdapter.Fill(this.easyGestDataSet3.UTILISATEURS);



        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {


            try
            {
                uTILISATEURSBindingSource.EndEdit();
                this.uTILISATEURSTableAdapter.Insert(int.Parse(txtid.Text.Trim()), txtnom.Text.Trim(), txtpsw.Text.Trim(), int.Parse(txttel.Text.Trim()), txtadress.Text.Trim(), cbsatut.Text.Trim());
                MessageBox.Show("enregistrer");
            }
            catch
            {
                MessageBox.Show("donner invalide ");
            }


        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.uTILISATEURSTableAdapter.Update(this.easyGestDataSet3.UTILISATEURS);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string query = "SELECT * from UTILISATEURS";
            SqlDataAdapter sdt = new SqlDataAdapter(query, con);
            DataTable das = new DataTable();
            sdt.Fill(das);
           bunifuCustomDataGrid4.DataSource = das;

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

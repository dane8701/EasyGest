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
    public partial class FrmGestionReservation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EasyGest;Integrated Security=True");

        public FrmGestionReservation()
        {
            InitializeComponent();
        }

        private void FrmGestionReservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet8.RESERVATIONS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rESERVATIONSTableAdapter.Fill(this.easyGestDataSet8.RESERVATIONS);
        
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            rESERVATIONSBindingSource.EndEdit();
            this.rESERVATIONSTableAdapter.Insert(int.Parse(guna2ComboBox2.Text.Trim()), int.Parse(guna2ComboBox1.Text.Trim()), int.Parse(guna2ComboBox3.Text.Trim()));

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            rESERVATIONSBindingSource.EndEdit();
            this.rESERVATIONSTableAdapter.Update(this.easyGestDataSet8.RESERVATIONS);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            string query = "SELECT * from RESERVATIONS";
            SqlDataAdapter sdt = new SqlDataAdapter(query, con);
            DataTable das = new DataTable();
            sdt.Fill(das);
            bunifuCustomDataGrid4.DataSource = das;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("search_reservation", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@CLIENTSidClient", guna2TextBox1.Text.Trim());
            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            bunifuCustomDataGrid4.DataSource = Dat;
            con.Close();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

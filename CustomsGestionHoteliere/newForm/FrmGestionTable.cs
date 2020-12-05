using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere.newForm
{
    public partial class FrmGestionTable : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EasyGest;Integrated Security=True");

        public FrmGestionTable()
        {
            InitializeComponent();
        }

        private void FrmGestionTable_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet7.TABLES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tABLESTableAdapter.Fill(this.easyGestDataSet7.TABLES);

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            tABLESBindingSource.EndEdit();
            this.tABLESTableAdapter.Insert(int.Parse(txtidFacture.Text.Trim()) ,int.Parse(txtmontantTotal.Text.Trim()) , int.Parse(guna2ComboBox3.Text.Trim()) );


        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            tABLESBindingSource.EndEdit();
            this.tABLESTableAdapter.Update(this.easyGestDataSet7.TABLES);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("search_table", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idTable", guna2TextBox1.Text.Trim());
            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            bunifuCustomDataGrid4.DataSource = Dat;
            con.Close();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            string query = "SELECT * from TABLES";
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

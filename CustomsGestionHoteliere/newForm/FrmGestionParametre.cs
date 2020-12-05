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
    public partial class FrmGestionParametre : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = EasyGest; Integrated Security = True");
        SqlCommand com = new SqlCommand();
        public FrmGestionParametre()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtCOMMANDESidCommande_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            insertable(txtTypeTable.Text, txtidTypeTable.Text);
            InserBoisson(txtTypeBoisson.Text, txtidTypeBoisson.Text);
            InserTypeMenu(txtTypeMenu.Text, txtidTypeMenu.Text);
            InserStatut(txtStatut.Text, txtidStatut.Text);
            InserTypePlat(txtTypePlat.Text, txtidTypePlat.Text);
        }

        private void insertable(string idTypeTable, string nomTypeTable)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("insert_typeTable", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@nomTypeTable", nomTypeTable);
            adp.SelectCommand.Parameters.AddWithValue("@idTypeTable", idTypeTable);

            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            con.Close();
        }

        private void InserBoisson(string idTypeBoisson, string BOISSONSidBoisson)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("insert_typeBoisson", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idTypeBoisson", idTypeBoisson);
            adp.SelectCommand.Parameters.AddWithValue("@BOISSONSidBoisson", BOISSONSidBoisson);

            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            con.Close();
        }

        private void InserTypeMenu(string idTypeMenu, string nomTypeMenu)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("insert_typeMenu", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idTypeMenu", idTypeMenu);
            adp.SelectCommand.Parameters.AddWithValue("@nomTypeMenu", nomTypeMenu);

            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            con.Close();
        }

        private void InserStatut(string idStatut, string nomStatut)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("insert_statut", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idStatut", idStatut);
            adp.SelectCommand.Parameters.AddWithValue("@nomStatut", nomStatut);

            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            con.Close();
        }

        private void InserTypePlat(string idPlat, string nomPlat)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("insert_typePlat", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idPlat", idPlat);
            adp.SelectCommand.Parameters.AddWithValue("@nomPlat", nomPlat);

            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            con.Close();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();      
             
        }
    }
}

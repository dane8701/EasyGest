using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=gset_hotel;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            materialTabControl1.SelectTab(0);
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet4.agent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.agentTableAdapter.Fill(this.gset_hotelDataSet4.agent);
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet4.facture'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.factureTableAdapter.Fill(this.gset_hotelDataSet4.facture);
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet4.reservation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationTableAdapter.Fill(this.gset_hotelDataSet4.reservation);
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet4.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter1.Fill(this.gset_hotelDataSet4.client);
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet2.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.clientTableAdapter1.Fill(this.gset_hotelDataSet2.client);
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet1.agent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.agentTableAdapter.Fill(this.gset_hotelDataSet1.agent);
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet1.facture'. Vous pouvez la déplacer ou la supprimer selon les besoins.
          //  this.factureTableAdapter.Fill(this.gset_hotelDataSet1.facture);
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet1.reservation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           // this.reservationTableAdapter.Fill(this.gset_hotelDataSet1.reservation);
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet1.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           //this.clientTableAdapter.Fill(this.gset_hotelDataSet1.client);

        }

        private void guna2ImageButton12_Click(object sender, EventArgs e)
        {
            gestutilisateur gu = new gestutilisateur();
            gu.Show();
        }

        private void guna2ImageButton9_Click(object sender, EventArgs e)
        {
            gestfacture gf = new gestfacture();
            gf.Show();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            gestReservation gr = new gestReservation();
            gr.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            enregistreClient ec = new enregistreClient();
            ec.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            materialTabControl1.SelectTab(1);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            materialTabControl1.SelectTab(2);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            materialTabControl1.SelectTab(3);
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            slider.Left = ((Guna.UI2.WinForms.Guna2TileButton)sender).Left;
            slider.Width = ((Guna.UI2.WinForms.Guna2TileButton)sender).Width;
            materialTabControl1.SelectTab(4);
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            clientBindingSource1.EndEdit();
            clientTableAdapter1.Update(gset_hotelDataSet4.client);
            
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            int rows = bunifuCustomDataGrid1.RowCount;
            for (int i = rows - 1; i >= 0; i--)
            {
                if (bunifuCustomDataGrid1.Rows[i].Selected)
                {
                    clientBindingSource1.RemoveCurrent();
                }
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("seachAndviewClient", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@name", guna2TextBox1.Text.Trim());
            DataTable Dat = new DataTable();
            adp.Fill(Dat);
           bunifuCustomDataGrid1.DataSource = Dat;
            con.Close();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {

            int rows = bunifuCustomDataGrid2.RowCount;
            for (int i = rows - 1; i >= 0; i--)
            {
                if (bunifuCustomDataGrid2.Rows[i].Selected)
                {
                    reservationBindingSource.RemoveCurrent();
                }

            }
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            reservationBindingSource.EndEdit();
            reservationTableAdapter.Update(gset_hotelDataSet4.reservation);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("seachreserv", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idresv", guna2TextBox2.Text.Trim());
            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            bunifuCustomDataGrid2.DataSource = Dat;
            con.Close();
        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
        {

            int rows = bunifuCustomDataGrid3.RowCount;
            for (int i = rows - 1; i >= 0; i--)
            {
                if (bunifuCustomDataGrid3.Rows[i].Selected)
                {
                    factureBindingSource.RemoveCurrent();
                }

            }
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            factureBindingSource.EndEdit();
            factureTableAdapter.Update(gset_hotelDataSet4.facture);
        }
        //print bt 
        private void guna2ImageButton13_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("seachfacture", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idfactur", guna2TextBox3.Text.Trim());
            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            bunifuCustomDataGrid3.DataSource = Dat;
            con.Close();
        }

        private void guna2ImageButton11_Click(object sender, EventArgs e)
        {
            int rows = bunifuCustomDataGrid4.RowCount;
            for (int i = rows - 1; i >= 0; i--)
            {
                if (bunifuCustomDataGrid4.Rows[i].Selected)
                {
                   agentBindingSource.RemoveCurrent();
                }

            }
        }

        private void guna2ImageButton10_Click(object sender, EventArgs e)
        {
            agentBindingSource.EndEdit();
            agentTableAdapter.Update(gset_hotelDataSet4.agent);
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("seachuser", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@nomuser", guna2TextBox3.Text.Trim());
            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            bunifuCustomDataGrid4.DataSource = Dat;
            con.Close();
        }
    }
}

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
    public partial class FrmGestionPlats : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = EasyGest; Integrated Security = True");
        SqlCommand com = new SqlCommand();
        public FrmGestionPlats()
        {
            InitializeComponent();
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
            SqlDataAdapter adp = new SqlDataAdapter("insert_plat", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idPlat", txtidPlat.Text);
            adp.SelectCommand.Parameters.AddWithValue("@nomPlat", txtnomPlat.Text);
            adp.SelectCommand.Parameters.AddWithValue("@prix", int.Parse(txtprix.Text));
            adp.SelectCommand.Parameters.AddWithValue("@TypePlatidTypePlat", txtTypePlatidTypePlat.Text);

            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            con.Close();
        }

        private void FrmGestionPlats_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet1.TypePlats'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typePlatsTableAdapter.Fill(this.easyGestDataSet1.TypePlats);
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet.PLATS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pLATSTableAdapter.Fill(this.easyGestDataSet.PLATS);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("insert_typePlat", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@idPlat", int.Parse(guna2TextBox3.Text));
            adp.SelectCommand.Parameters.AddWithValue("@nomPlat", guna2TextBox1.Text);

            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            con.Close();
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
    }
}

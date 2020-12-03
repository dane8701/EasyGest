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
using CustomsGestionHoteliere;

namespace CustomsGestionHoteliere
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=gset_hotel;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        public login()
        {
            InitializeComponent();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var logi = Log(guna2TextBox1.Text.Trim(), guna2TextBox2.Text.Trim());
            if (logi == true )
            {
                if (guna2ComboBox1.Text.Equals("admin"))
                {
                    Form1 fr = new Form1();
                   
                    fr.Show();
                    this.Hide();
                } 
                else
                {
                    Form1 fr = new Form1();
                    fr.bunifuFlatButton4.Visible = false;
                    fr.Show();
                    this.Hide();
                }    
               
            }
            else
            {
                MessageBox.Show("eror");
            }

        }
        public bool Log(String user, string password)
        {
            user = guna2TextBox1.Text.Trim();
            password = guna2TextBox2.Text.Trim();

            if (con.State == ConnectionState.Closed)
                con.Open();
            string query = " select * from agent where [username]= '" + user + "' and [mot de passe ]= '" + password + "'";
            SqlDataAdapter sdt = new SqlDataAdapter(query, con);
            DataTable das = new DataTable();
            sdt.Fill(das);
            if (das.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using CustomsGestionHoteliere.newForm;
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
    public partial class formLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"");
        public formLogin()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            var logi = Log(guna2TextBox1.Text.Trim(), guna2TextBox2.Text.Trim());
            if (logi == true)
            {
                if (guna2ComboBox1.Text.Equals("admin"))
                {
                    NouveauFormParent fr = new NouveauFormParent();

                    fr.Show();
                    this.Hide();
                }
                else
                {
                    NouveauFormParent fr = new NouveauFormParent();
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

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = " select * from agent where [username]= '" + user + "' and [mot de passe ]= '" + password + "'";
            SqlDataAdapter sdt = new SqlDataAdapter(query, conn);
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

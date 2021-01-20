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
    public partial class FrmLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EasyGest;Integrated Security=True");
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            var logi = Log(txtLogin.Text.Trim(), txtPassword.Text.Trim());
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
                   fr.guna2GradientTileButton5.Visible = false;
                    fr.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("idenfiant invalide ");
            }

        }
        public bool Log(String user, string password)
        {
            user = txtLogin.Text.Trim();
            password = txtPassword.Text.Trim();

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "SELECT * from UTILISATEURS where [nomUtilisateur]= '" + user + "' and [motDePasse]= '" + password + "'";
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

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void txtLogin_MouseClick(object sender, MouseEventArgs e)
        {
            txtLogin.Clear();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
        }
    }
}

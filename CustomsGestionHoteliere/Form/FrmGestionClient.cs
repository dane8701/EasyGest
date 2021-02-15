using EasyGest.BLL;
using EasyGest.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere.newForm
{
    public partial class FrmGestionClient : Form
    {
        private readonly TableBLO tableBLO;
        private readonly ClientBLO clientBLO;
        public FrmGestionClient()
        {
            InitializeComponent();
            tableBLO = new TableBLO(ConfigurationManager.AppSettings["Dbfolder"]);
            clientBLO = new ClientBLO(ConfigurationManager.AppSettings["Dbfolder"]);
        }

        private void loaddata()
        {
            string value = txtSearch.Text.ToLower();
            var clients = clientBLO.GetAllClient();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clients;
            dataGridView1.ClearSelection();
        }

        private void FrmGestionClient_Load(object sender, EventArgs e)
        {
            var tables = tableBLO.GetAllTable();
            cbIdTable.DataSource = tables;
            loaddata();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomClient_MouseClick(object sender, MouseEventArgs e)
        {
            txtNomClient.Clear();
        }

        private void txtTelephone_MouseClick(object sender, MouseEventArgs e)
        {
            txtTelephone.Clear();
        }

        private void txtPrenomClient_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrenomClient.Clear();
        }

        private void txtAdresse_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdresse.Clear();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            materialTabControl1.SelectTab(0);
        }

        private void txtNomClient_Leave(object sender, EventArgs e)
        {
            if (txtNomClient.Text == "")
                txtNomClient.Text = "Nom client";
        }

        private void txtTelephone_Leave(object sender, EventArgs e)
        {
            if (txtTelephone.Text == "")
                txtTelephone.Text = "Telpphone";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                txtEmail.Text = "Email";
        }

        private void txtPrenomClient_Leave(object sender, EventArgs e)
        {
            if (txtPrenomClient.Text == "")
                txtPrenomClient.Text = "Prenom client";
        }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "")
                txtAdresse.Text = "Adresse";
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Table table = cbIdTable.SelectedItem as Table;
            
            try
            {
                Client newClient = new Client(
                    txtNomClient.Text, 
                    txtPrenomClient.Text, 
                    double.Parse(txtTelephone.Text), 
                    txtEmail.Text, 
                    txtAdresse.Text, 
                    table.Id);
                clientBLO.Save(newClient);
                MessageBox.Show
                (
                    "Save done !",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (TypingException ex)
            {
                foreach (var error in ex.Erros)
                {
                    foreach (Control control in this.Controls)
                    {
                        if (control.Name.Contains(error.Key) && !control.Name.Contains("Error"))
                        {
                            control.BackColor = Color.Pink;
                        }
                        if (control.Name.Contains(error.Key) && !control.Name.Contains("Error"))
                        {
                            control.Text = error.Value;
                            control.Visible = true;
                        }
                    }
                }
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
                (
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception)
            {
                MessageBox.Show
                (
                    "An error occured. Please try again later",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            materialTabControl1.SelectTab(1);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata();
            txtSearch.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                MessageBox.Show(
                    "Do you really want to delete this product (s) ?",
                    "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        clientBLO.DeleteClient(dataGridView1.SelectedRows[i].DataBoundItem as Client);
                    }
                    loaddata();
                }
            }
        }
    }
}

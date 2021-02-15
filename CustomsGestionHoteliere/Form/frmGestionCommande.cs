using EasyGest.BLL;
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
    public partial class FrmGestionCommande : Form
    {
        //private readonly CommandeBLO commandeBLO;
        private readonly ClientBLO clientBLO;
        public FrmGestionCommande()
        {
            InitializeComponent();
            //commandeBLO = new CommandeBLO(ConfigurationManager.AppSettings["Dbfolder"]);
            clientBLO = new ClientBLO(ConfigurationManager.AppSettings["Dbfolder"]);
        }
        private void loaddata()
        {
            string value = txtSearch.Text.ToLower();
            //var commandes = commandeBLO.GetAllClient();
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = commandes;
            dataGridView1.ClearSelection();
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

        private void FrmGestionCommande_Load(object sender, EventArgs e)
        {
           
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
                        //commandeBLO.DeleteCommande(dataGridView1.SelectedRows[i].DataBoundItem as Commande);
                    }
                    loaddata();
                }
            }
        }
    }
}

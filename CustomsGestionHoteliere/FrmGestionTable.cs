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
using EasyGest.BLL;
using EasyGest.BO;
using System.Configuration;

namespace CustomsGestionHoteliere.newForm
{
    public partial class FrmGestionTable : Form
    {
        private readonly TypeTableBLO typeTableBLO;
        private readonly TableBLO tableBLO;
        private static int count = 0;
        private void loaddata()
        {
            string value = txtSearch.Text.ToLower();
            var tables = tableBLO.GetAllTable();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tables;
            dataGridView1.ClearSelection();
            var typeTables = typeTableBLO.GetAllTypeTable();
            cbTypeTable.DataSource = typeTables;
        }
        private void loaddata1()
        {
            string value = txtSearch1.Text.ToLower();
            var typeTables = typeTableBLO.GetAllTypeTable();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = typeTables;
            dataGridView2.ClearSelection();
            var typeTables1 = typeTableBLO.GetAllTypeTable();
            cbTypeTable.DataSource = typeTables1;
        }
        public FrmGestionTable()
        {
            InitializeComponent();
            typeTableBLO = new TypeTableBLO(ConfigurationManager.AppSettings["Dbfolder"]);
            tableBLO = new TableBLO(ConfigurationManager.AppSettings["Dbfolder"]);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
        }

        private void FrmGestionTable_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata1();
            
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

        private void btnSave1_Click(object sender, EventArgs e)
        {
            try
            {
                TypeTable newTypeTable = new TypeTable(txtNomTypeTable.Text);
                typeTableBLO.Save(newTypeTable);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            count++;
            TypeTable typeTable = cbTypeTable.SelectedItem as TypeTable;
            try
            {
                Table newTable = new Table(count ,int.Parse(txtNombrePlace.Text), typeTable.Id);
                tableBLO.Save(newTable);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        tableBLO.DeleteTable(dataGridView1.SelectedRows[i].DataBoundItem as Table);
                    }
                    loaddata();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            //slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    materialTabControl1.SelectTab(0);
                    //dataGridView1.SelectedRows[i].DataBoundItem as Table
                    loaddata();
                }
            }
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            loaddata1();
            txtSearch1.Clear();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                if (
                MessageBox.Show(
                    "Do you really want to delete this product (s) ?",
                    "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                    {
                        typeTableBLO.DeleteTypeTable(dataGridView2.SelectedRows[i].DataBoundItem as TypeTable);
                    }
                    loaddata1();
                }
            }
        }
    }
}

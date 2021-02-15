using EasyGest.BLL;
using EasyGest.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere.newForm
{
    public partial class FrmGestionBoisson : Form
    {
        private readonly BoissonBLO boissonBLO;
        private readonly TypeBoissonBLO typeBoissonBLO;
        private Action callBack;
        private Boisson oldBoisson;
        private void loaddata()
        {
            string value = txtSearch.Text.ToLower();
            var boissons = boissonBLO.GetAllBoisson();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = boissons;
            dataGridView1.ClearSelection();
            var typeboissons = typeBoissonBLO.GetAllTypeBoisson();
            cbTypeBoisson.DataSource = typeboissons;
        }
        private void loaddata1()
        {
            string value = txtSearch1.Text.ToLower();
            var typeboissons = typeBoissonBLO.GetAllTypeBoisson();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = typeboissons;
            dataGridView3.ClearSelection();
            var typeboissons1 = typeBoissonBLO.GetAllTypeBoisson();
            cbTypeBoisson.DataSource = typeboissons1;
        }
        public FrmGestionBoisson()
        {
            InitializeComponent();
            typeBoissonBLO = new TypeBoissonBLO(ConfigurationManager.AppSettings["Dbfolder"]);
            boissonBLO = new BoissonBLO(ConfigurationManager.AppSettings["Dbfolder"]);
        }
        private void FrmGestionBoisson_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata1();
        }
        public FrmGestionBoisson(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmGestionBoisson(Boisson boisson, Action callBack) : this(callBack)
        {
            this.oldBoisson = boisson;
            txtNomBoisson.Text = oldBoisson.NomBoisson;
            txtPrixBoisson.Text = oldBoisson.PrixBoisson.ToString();
            //cbTypeBoisson.SelectedItem = oldBoisson.IdTypePlat
            if (oldBoisson.Picture != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(boisson.Picture));
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            dataGridView2.SelectTab(0);
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            dataGridView2.SelectTab(2);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            dataGridView2.SelectTab(1);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            dataGridView2.SelectTab(3);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TypeBoisson typeBoisson = cbTypeBoisson.SelectedItem as TypeBoisson;
            try
            {
                Boisson newBoisson = new Boisson
                    (
                    txtNomBoisson.Text, 
                    int.Parse(txtPrixBoisson.Text),
                    !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldBoisson?.Picture,
                    typeBoisson.Id);
                boissonBLO.Save(newBoisson);
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

        private void btnSave1_Click(object sender, EventArgs e)
        {
            try
            {
                TypeBoisson newTypeBoisson = new TypeBoisson(txtNomTypeBoisson.Text);
                typeBoissonBLO.Save(newTypeBoisson);
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

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif)";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata();
            txtSearch.Clear();
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            loaddata1();
            txtSearch1.Clear();
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
                        boissonBLO.DeleteBoisson(dataGridView1.SelectedRows[i].DataBoundItem as Boisson);
                    }
                    loaddata();
                }
            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                if (
                MessageBox.Show(
                    "Do you really want to delete this product (s) ?",
                    "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView3.SelectedRows.Count; i++)
                    {
                        typeBoissonBLO.DeleteTypeBoisson(dataGridView3.SelectedRows[i].DataBoundItem as TypeBoisson);
                    }
                    loaddata1();
                }
            }
        }
    }
}

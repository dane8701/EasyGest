using EasyGest.BLL;
using EasyGest.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere.newForm
{
    public partial class FrmGestionPlat : Form
    {
        private readonly TypePlatBLO typePlatBLO;
        private readonly PlatBLO platBLO;
        private Action callBack;
        private Plat oldPlat;
        private TypePlat oldTypePlat;

        private void loaddata()
        {
            string value = txtSearch.Text.ToLower();
            var plats = platBLO.GetAllPlat();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = plats;
            dataGridView1.ClearSelection();
            var typePlats = typePlatBLO.GetAllTypePlat();
            cbNomTypePlat.DataSource = typePlats;
        }
        private void loaddata1()
        {
            string value = txtSearch1.Text.ToLower();
            var typePlats = typePlatBLO.GetAllTypePlat();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = typePlats;
            dataGridView2.ClearSelection();
            var typePlats1 = typePlatBLO.GetAllTypePlat();
            cbNomTypePlat.DataSource = typePlats1;
        }
        public FrmGestionPlat()
        {
            InitializeComponent();
            typePlatBLO = new TypePlatBLO(ConfigurationManager.AppSettings["Dbfolder"]);
            platBLO = new PlatBLO(ConfigurationManager.AppSettings["Dbfolder"]);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoGenerateColumns = false;
        }
        public FrmGestionPlat(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmGestionPlat(Plat plat, Action callBack) : this(callBack)
        {
            this.oldPlat = plat;
            txtNomPlat.Text = oldPlat.NomPlat;
            txtPrix.Text = oldPlat.PrixPlat.ToString();
            //cbNomTypePlat.SelectedItem = ;
            if (oldPlat.Picture != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(plat.Picture));
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

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
               
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            try
            {
                TypePlat newTypePlat = new TypePlat(txtNomTypePlat.Text);
                if (this.oldPlat == null)
                    typePlatBLO.Save(newTypePlat);
                else
                    typePlatBLO.EditTypePlat(oldTypePlat, newTypePlat);
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
            TypePlat typePlat = cbNomTypePlat.SelectedItem as TypePlat;
            try
            {
                Plat newPlat = new Plat(
                    txtNomPlat.Text, 
                    int.Parse(txtPrix.Text),
                    !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldPlat?.Picture,
                    typePlat.Id);

                if (this.oldPlat == null)
                    platBLO.Save(newPlat);
                else
                    platBLO.EditPlat(oldPlat, newPlat);
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

        private void FrmGestionPlats_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata1();
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
                        platBLO.DeletePlat(dataGridView1.SelectedRows[i].DataBoundItem as Plat);
                    }
                    loaddata();
                }
            }
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
                        typePlatBLO.DeleteTypePlat(dataGridView2.SelectedRows[i].DataBoundItem as TypePlat);
                    }
                    loaddata1();
                }
            }
        }
    }
}

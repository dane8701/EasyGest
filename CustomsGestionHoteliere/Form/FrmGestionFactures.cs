using EasyGest.BLL;
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
    public partial class FrmGestionFactures : Form
    {
        //private readonly CommandeBLO commandeBLO;
        public FrmGestionFactures()
        {
            InitializeComponent();

            //commandeBLO = new CommandeBLO();
        }
        private void FrmGestionFactures_Load(object sender, EventArgs e)
        {
            //var commandes = commandeBLO.GetAllTypeTable();
            //cmIdCommande.DataSource = commandes;
        }

        private void addUtilisateur_Click(object sender, EventArgs e)
        {

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
            //Commande commande = cbIdCommande.SelectedItem as commande;
            try
            {
                //Commande newCommande = new Commande(commande.Id);
                //CommandeBLO.Save(newCommande);
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

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantiter_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Form f = new FrmPreview();
            f.Show();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }
    }
}

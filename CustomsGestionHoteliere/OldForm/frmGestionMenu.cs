using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere.newForm
{
    public partial class FrmGestionMenu : Form
    {
        public FrmGestionMenu()
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

        private void FrmGestionMenu_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet2.TypeMenus'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.typeMenusTableAdapter.Fill(this.easyGestDataSet2.TypeMenus);
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet.MENUS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.mENUSTableAdapter.Fill(this.easyGestDataSet.MENUS);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomMenu_MouseClick(object sender, MouseEventArgs e)
        {
            txtNomMenu.Clear();
        }

        private void txtPrixMenu_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrixMenu.Clear();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }
    }
}

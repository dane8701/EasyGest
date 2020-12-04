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
    public partial class FrmGestionTable : Form
    {
        public FrmGestionTable()
        {
            InitializeComponent();
        }

        private void FrmGestionTable_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'easyGestDataSet.TABLES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tABLESTableAdapter.Fill(this.easyGestDataSet.TABLES);

        }
    }
}

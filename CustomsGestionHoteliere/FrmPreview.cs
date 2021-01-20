using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere
{
    public partial class FrmPreview : Form
    {
        public FrmPreview()
        {
            InitializeComponent();
        }

        private void FrmPreview_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'EasyGestDataSet11.FACTURES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reportViewer1.RefreshReport();
        }
    }
}

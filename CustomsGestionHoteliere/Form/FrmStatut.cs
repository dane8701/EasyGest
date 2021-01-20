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
    public partial class FrmStatut : Form
    {
        public FrmStatut()
        {
            InitializeComponent();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtNomStatut_MouseClick(object sender, MouseEventArgs e)
        {
            txtNomStatut.Clear();
        }
    }
}

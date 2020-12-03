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
    public partial class gestReservation : Form
    {
        public gestReservation()
        {
            InitializeComponent();
        }

        private void gestReservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gset_hotelDataSet.reservation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationTableAdapter.Fill(this.gset_hotelDataSet.reservation);

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            reservationBindingSource.EndEdit();
           /// reservationTableAdapter.Insert()
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI.Controls;

namespace SotoAyu.view
{
    public partial class UCDasboardAdmin : UserControl
    {
        public UCDasboardAdmin()
        {
            InitializeComponent();
        }
        private void highlightButton(cuiButton activeButton)
        {
            List<cuiButton> menu_btn = new List<cuiButton> { this.cuiButtonLaporan, this.cuiButtonKasir, this.cuiButtonKaryawan, this.cuiButtonMenu, this.cuiButtonTransaksi };

            foreach (var btn in menu_btn)
            {
                btn.NormalBackground = Color.Transparent;
                btn.HoverBackground = Color.Transparent;
            }

            activeButton.NormalBackground = Color.FromArgb(126, 133, 110);
            activeButton.HoverBackground = Color.FromArgb(126, 133, 110);

        }

        private void cuiButtonLaporan_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);
        }

        private void cuiButtonKasir_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);

        }

        private void cuiButtonKaryawan_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);

        }

        private void cuiButtonMenu_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);

        }

        private void cuiButtonTransaksi_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hallo");
        }
    }
}

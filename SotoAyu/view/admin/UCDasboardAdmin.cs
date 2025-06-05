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
        MainForm MainForm;
        public UCDasboardAdmin(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
            LoadMenu(new UCLaporanPenjualan());
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
            LoadMenu(new UCLaporanPenjualan());
        }

        private void cuiButtonKasir_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);
            LoadMenu(new UCManajemenAkunKasir());

        }

        private void cuiButtonKaryawan_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);
            LoadMenu(new UCManajemenKaryawan());
        }

        private void cuiButtonMenu_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);
            LoadMenu(new UCManajemenMenu());

        }

        private void cuiButtonTransaksi_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);
            LoadMenu(new UCTransaksiAdmin());

        }

        private void cuiButtonLogout_Click(object sender, EventArgs e)
        {
            ExitForm exitForm = new ExitForm(MainForm);
            exitForm.ShowDialog();
        }
        public void LoadMenu(UserControl uc)
        {
            panelDasboardContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelDasboardContainer.Controls.Add(uc);
        }
    }
}

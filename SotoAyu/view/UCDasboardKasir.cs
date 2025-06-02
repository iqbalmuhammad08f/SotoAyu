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
    public partial class UCDasboardKasir : UserControl
    {
        MainForm mainForm;
        public UCDasboardKasir(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            LoadMenu(new UCTransaksiKasir());
        }
        public void LoadMenu(UserControl uc)
        {
            panelContainerKasir.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainerKasir.Controls.Add(uc);

        }

        private void highlightButton(cuiButton activeButton)
        {
            List<cuiButton> menu_btn = new List<cuiButton> { this.cuiButtonTransaksi, this.cuiButtonLaporan };

            foreach (var btn in menu_btn)
            {
                btn.NormalBackground = Color.Transparent;
                btn.HoverBackground = Color.Transparent;
            }

            activeButton.NormalBackground = Color.FromArgb(75, 110, 2);
            activeButton.HoverBackground = Color.FromArgb(75, 110, 2);

        }

        private void cuiButtonExit_Click(object sender, EventArgs e)
        {
            ExitForm exitForm = new ExitForm(mainForm);
            exitForm.ShowDialog();

        }

        private void cuiButtonTransaksi_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);
            LoadMenu(new UCTransaksiKasir());
        }

        private void cuiButtonLaporan_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);
            LoadMenu(new UCRiwayatTransaksi());
        }
    }
}

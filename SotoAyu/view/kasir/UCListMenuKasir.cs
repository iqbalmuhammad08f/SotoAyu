using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SotoAyu.model;

namespace SotoAyu.view
{
    public partial class UCListMenuKasir : UserControl
    {
        Menu menu;
        UCTransaksiKasir transaksiKasir;
        public UCListMenuKasir(Menu menu, UCTransaksiKasir transaksiKasir)
        {
            InitializeComponent();
            this.transaksiKasir = transaksiKasir;
            this.menu = menu;
            using (MemoryStream ms = new MemoryStream(menu.Gambar_menu))
            {
                cuiPictureBoxGambar.BackgroundImage = Image.FromStream(ms);
            }
            cuiLabelNama.Content = menu.Nama_menu;
            cuiLabelHarga.Content = $"Rp " + menu.Harga_menu.ToString("N0");
        }

        private void cuiButtonAdd_Click(object sender, EventArgs e)
        {
            transaksiKasir.loadOrder(menu);
        }
    }
}

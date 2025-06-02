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
    public partial class UCListOrder : UserControl
    {
        MenuOrder menuOrder;
        UCTransaksiKasir transaksiKasir;

        public UCListOrder(MenuOrder menuOrder, UCTransaksiKasir transaksiKasir)
        {
            InitializeComponent();
            this.menuOrder = menuOrder;
            this.transaksiKasir = transaksiKasir;

            cuiLabelNama.Content = menuOrder.menu.Nama_menu;
            cuiLabelHarga.Content = $"Rp.{menuOrder.menu.Harga_menu.ToString()}";
            cuiLabelJumlah.Content = menuOrder.qty.ToString();
        }

        private void cuiButtonMinus_Click(object sender, EventArgs e)
        {
            menuOrder.qty -= 1;
            if (menuOrder.qty <= 0)
            {
                transaksiKasir.listmenuOrder.Remove(menuOrder);
            }
            transaksiKasir.RefreshOrderPanel();
            transaksiKasir.loadTotal();
        }
    }
}

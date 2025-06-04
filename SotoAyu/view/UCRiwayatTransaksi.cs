using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SotoAyu.controller;

namespace SotoAyu.view
{
    public partial class UCRiwayatTransaksi : UserControl
    {
        public UCRiwayatTransaksi()
        {
            InitializeComponent();
            LoadlistTransaksi();
        }
        private void LoadlistTransaksi()
        {
            var list_transaksi = TransaksiController.GetAllTransaksis();
            int no = 1;
            foreach (var transaksi in list_transaksi)
            {
                flowLayoutPanelListTransaksi.Controls.Add(new UCListTransaksi(no, transaksi.Tanggal, transaksi.Total_transaksi, transaksi.id_transaksi));
                no++;
            }
        }
    }
    
}

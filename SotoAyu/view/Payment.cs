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
using SotoAyu.model;

namespace SotoAyu.view
{
    public partial class Payment : Form
    {
        int id;
        public Payment(int id)
        {
            InitializeComponent();
            this.id = id;
            loadPayment();
        }
        private void loadPayment()
        {
            var transaksi = TransaksiController.GetTransaksis(id);
            cuiLabelTotal.Content = $"Rp. {transaksi.Total_transaksi.ToString()}";
            cuiLabelMetode.Content = transaksi.Metode_pembayaran;
            cuiLabelTanggal.Content = transaksi.Tanggal.ToString("dd-MM-yyyy HH:mm");
            cuiLabelKasir.Content = transaksi.Nama_operator;
        }

        private void cuiButtonAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

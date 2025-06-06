using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SotoAyu.view
{
    public partial class UCListTransaksi : UserControl
    {
        int id;
        string tanggal;
        public UCListTransaksi(int no, DateTime tanggal, int total, int id, string kasir)
        {
            InitializeComponent();
            this.id = id;
            this.tanggal = tanggal.ToString("dd-MM-yyyy HH:mm");
            cuiLabelNo.Content = no.ToString();
            cuiLabelTanggal.Content = this.tanggal;
            cuiLabelTotal.Content = $"Rp " + total.ToString("N0");
            cuiLabelNamaOperator.Content = kasir;
        }

        private void cuiButtonInfo_Click(object sender, EventArgs e)
        {
            InfoListTransaksi transaksi = new InfoListTransaksi(id,tanggal);
            transaksi.ShowDialog(this);
        }
    }
}

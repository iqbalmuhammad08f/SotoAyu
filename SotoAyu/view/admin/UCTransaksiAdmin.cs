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
    public partial class UCTransaksiAdmin : UserControl
    {
        List<Transaksi> list_transaksi = TransaksiController.GetAllTransaksis();
        public UCTransaksiAdmin()
        {
            InitializeComponent();
            LoadlistTransaksi();
        }
        private void LoadlistTransaksi()
        {
            flowLayoutPanelListTransaksi.Controls.Clear();
            int no = 1;
            foreach (var transaksi in list_transaksi)
            {
                flowLayoutPanelListTransaksi.Controls.Add(new UCListTransaksi(no, transaksi.Tanggal, transaksi.Total_transaksi, transaksi.id_transaksi, transaksi.Nama_operator));
                no++;
            }
        }

        private void cuiButtonFilter_Click(object sender, EventArgs e)
        {
            Notif notif = new Notif();
            DateTime from = cuiCalendarDatePickerFrom.Value;
            DateTime to = cuiCalendarDatePickerTo.Value;
            list_transaksi = TransaksiController.GetFromToTransaksi(from, to);
            if (from >= to)
            {
                notif.setPesan("Input tanggal tidak boleh sama");
                notif.visibleExit(false);
                notif.ShowDialog();
                return;
            }
            else if (list_transaksi.Count == 0)
            {
                notif.setPesan("Tidak ada transaksi di rentang tanggal tersebut");
                notif.visibleExit(false);
                notif.ShowDialog();
                return;
            }
            else
            {
                LoadlistTransaksi();
            }
        }
    }
}

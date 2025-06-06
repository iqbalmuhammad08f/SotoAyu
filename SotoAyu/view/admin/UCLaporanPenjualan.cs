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
using SotoAyu.view.admin;

namespace SotoAyu.view
{
    public partial class UCLaporanPenjualan : UserControl
    {
        public UCLaporanPenjualan()
        {
            InitializeComponent();
            loadOverAll();


        }

        private void loadOverAll()
        {
            int no = 1;
            var list_laporan = LaporanController.GetOverallLaporan();
            int total_overall = list_laporan.Sum(a => a.Total);
            cuiLabelOverall.Content = $"Rp " + total_overall.ToString("N0");
            cuiLabelRentang.Content = $"Rp " + total_overall.ToString("N0");
            foreach (var laporan in list_laporan)
            {
                flowLayoutPanelListLaporan.Controls.Add(new UCListLaporan(laporan, no));
                no++;
            }

        }
        private void loadFromTo(DateTime from, DateTime to)
        {
            flowLayoutPanelListLaporan.Controls.Clear();
            int no = 1;
            var list_laporan = LaporanController.GetFromToLaporan(from, to);
            if(list_laporan.Count == 0)
            {
                cuiLabelRentang.Content = "Rp 0";
                Notif notif = new Notif();
                notif.setPesan("Tidak ada transaksi di rentang tanggal tersebut");
                notif.visibleExit(false);
                notif.ShowDialog();
                return;
            }
            else
            {
                int rentang_total = list_laporan.Sum(a => a.Total);
                cuiLabelRentang.Content = "Rp " + rentang_total.ToString("N0");
                foreach (var laporan in list_laporan)
                {
                    flowLayoutPanelListLaporan.Controls.Add(new UCListLaporan(laporan, no));
                    no++;
                }
            }
        }

        private void cuiButtonFilter_Click(object sender, EventArgs e)
        {
            Notif notif = new Notif();
            DateTime from = cuiCalendarDatePickerFrom.Value;
            DateTime to = cuiCalendarDatePickerTo.Value;
            loadFromTo(from, to);
        }
    }
}

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

namespace SotoAyu.view.admin
{
    public partial class UCListLaporan : UserControl
    {
        public UCListLaporan(Laporan laporan, int no)
        {
            InitializeComponent();
            cuiLabelNo.Content = no.ToString();
            cuiLabelTanggal.Content = laporan.Tanggal.ToString("dd-MM-yyyy");
            cuiLabelNama.Content = "Soto Ayu";
            cuiLabelTotal.Content = $"Rp " + laporan.Total.ToString("N0");

        }
    }
}

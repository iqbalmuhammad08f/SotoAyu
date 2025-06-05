using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotoAyu.model
{
    public class Transaksi
    {
        public int id_transaksi { get; set; }
        public DateTime Tanggal { get; set; }
        public string Nama_operator { get; set; }
        public int Total_transaksi { get; set; }
        public string Metode_pembayaran { get; set; }
    }
}

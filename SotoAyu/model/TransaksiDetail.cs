using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotoAyu.model
{
    internal class TransaksiDetail
    {
        public int id_detail { get; set; }
        public int id_transaksi { get; set; }
        public int id_menu { get; set; }
        public int Jumlah_transaksi { get; set; }
        public float Subtotal { get; set; }
    }
}

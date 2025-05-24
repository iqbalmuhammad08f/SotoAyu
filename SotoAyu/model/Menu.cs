using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotoAyu.model
{
    internal class menu
    {
        public int id_menu { get; set; }
        public string Nama_menu { get; set; }
        public string Kategori_Menu { get; set; }
        public float Harga_menu { get; set; }
        public string Gambar_menu { get; set; }
        public bool Ketersediaan { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotoAyu.model
{
    public class MenuOrder
    {
        public Menu menu { get; set; }
        public int qty { get; set; }

        public int Subtotal => (int)(menu.Harga_menu * qty);
    }
}

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

namespace SotoAyu.view
{
    public partial class UCListMenu : UserControl
    {
        public UCListMenu(Menu menu)
        {
            InitializeComponent();
            using (MemoryStream ms = new MemoryStream(menu.Gambar_menu))
            {
                cuiPictureBoxGambar.BackgroundImage = Image.FromStream(ms);
            }

            cuiLabelNama.Content = menu.Nama_menu;
            cuiLabelHarga.Content = menu.Harga_menu.ToString();
        }
    }
}

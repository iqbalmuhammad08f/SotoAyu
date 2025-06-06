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
        Menu menu;
        UCManajemenMenu parentmenu;
        public UCListMenu(Menu menu, UCManajemenMenu parentmenu)
        {
            InitializeComponent();
            this.parentmenu = parentmenu;
            this.menu = menu;
            this.Click += Menu_Click;
            cuiPictureBoxGambar.Click += Menu_Click;
            cuiLabelNama.Click += Menu_Click;
            cuiLabelHarga.Click += Menu_Click;
            cuiButton1.Click += Menu_Click;
            using (MemoryStream ms = new MemoryStream(menu.Gambar_menu))
            {
                cuiPictureBoxGambar.BackgroundImage = Image.FromStream(ms);
            }
            cuiLabelNama.Content = menu.Nama_menu;
            cuiLabelHarga.Content = $"Rp " + menu.Harga_menu.ToString("N0");
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            EditMenu editMenu = new EditMenu(menu, parentmenu);
            editMenu.ShowDialog(this);
        }
    }
}

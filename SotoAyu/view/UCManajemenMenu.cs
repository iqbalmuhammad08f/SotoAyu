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

namespace SotoAyu.view
{
    public partial class UCManajemenMenu : UserControl
    {
        public UCManajemenMenu()
        {
            InitializeComponent();
            loadMenu();
        }
        public void centerPopUp(Form form)
        {
            Point posisiGlobal = this.PointToScreen(Point.Empty);

            int centerX = posisiGlobal.X + (this.Width - form.Width) / 2;
            int centerY = posisiGlobal.Y + (this.Height - form.Height) / 2;

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(centerX, centerY);
        }

        private void cuiButtonTambahMakanan_Click(object sender, EventArgs e)
        {
            TambahMenu tambahMenu = new TambahMenu();
            tambahMenu.setKategori("makanan");
            centerPopUp(tambahMenu);
            tambahMenu.ShowDialog();
            loadMenu();

        }

        private void cuiButtonTambahMinuman_Click(object sender, EventArgs e)
        {
            TambahMenu tambahMenu = new TambahMenu();
            tambahMenu.setKategori("minuman");
            centerPopUp(tambahMenu);
            tambahMenu.ShowDialog();
            loadMenu();

        }
        public void loadMenu()
        {
            flowLayoutLoadMakanan.Controls.Clear();
            var list_makanan = MenuController.GetMenus();
            var filterMakanan = list_makanan.Where(a => a.Kategori_Menu == "makanan" && a.status == true);
            foreach(var makanan in filterMakanan)
            {
                flowLayoutLoadMakanan.Controls.Add(new UCListMenu(makanan,this));
            }

            flowLayoutLoadMinuman.Controls.Clear();
            var list_minuman = MenuController.GetMenus();
            var filterMinuman = list_makanan.Where(a => a.Kategori_Menu == "minuman" && a.status == true);
            foreach (var minuman in filterMinuman)
            {
                flowLayoutLoadMinuman.Controls.Add(new UCListMenu(minuman,this));
            }

        }
    }
}

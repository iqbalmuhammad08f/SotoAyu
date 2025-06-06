using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI.Controls;
using SotoAyu.controller;
using SotoAyu.model;

namespace SotoAyu.view
{
    public partial class UCTransaksiKasir : UserControl
    {
        private Dictionary<string, int> karyawanLookup = new Dictionary<string, int>();
        public List<MenuOrder> listmenuOrder = new List<MenuOrder>();
        public string metodePemayaran;
        public UCTransaksiKasir()
        {
            InitializeComponent();
            loadKaryawan();
            loadMenu();
        }
        public bool memilikiOrder => listmenuOrder != null && listmenuOrder.Count > 0;
        private void loadKaryawan()
        {
            var list_karyawan = KaryawanController.GetKaryawans();
            var filter = list_karyawan.Where(a => a.status == true && a.role == "kasir");
            foreach (var karyawan in filter)
            {
                this.cuiComboBoxKaryawan.AddItem(karyawan.nama);
                karyawanLookup[karyawan.nama] = karyawan.id_karywan;
            }
        }

        private void loadMenu()
        {
            flowLayoutPanelMakanan.Controls.Clear();
            var list_makanan = MenuController.GetMenus();
            var filterMakanan = list_makanan.Where(a => a.Kategori_Menu == "makanan" && a.status == true);
            foreach (var makanan in filterMakanan)
            {
                flowLayoutPanelMakanan.Controls.Add(new UCListMenuKasir(makanan, this));
            }

            flowLayoutPanelMinuman.Controls.Clear();
            var list_minuman = MenuController.GetMenus();
            var filterMinuman = list_makanan.Where(a => a.Kategori_Menu == "minuman" && a.status == true);
            foreach (var minuman in filterMinuman)
            {
                flowLayoutPanelMinuman.Controls.Add(new UCListMenuKasir(minuman, this));
            }

        }
        public void RefreshOrderPanel()
        {
            flowLayoutPanelOrder.Controls.Clear();
            foreach (var item in listmenuOrder)
            {
                flowLayoutPanelOrder.Controls.Add(new UCListOrder(item, this));
            }
        }
        public void loadOrder(Menu menu)
        {
            var existingOrder = listmenuOrder.FirstOrDefault(mo => mo.menu.id_menu == menu.id_menu);
            if (existingOrder != null)
            {
                existingOrder.qty += 1;
                RefreshOrderPanel();
            }
            else
            {
                listmenuOrder.Add(new MenuOrder { menu = menu, qty = 1 });
                RefreshOrderPanel();
            }

            loadTotal();
        }

        public void loadTotal()
        {
            float total = listmenuOrder.Sum(mo => mo.menu.Harga_menu * mo.qty);
            cuiLabelTotal.Content = $"Rp " + total.ToString("N0");
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);
            metodePemayaran = "Tunai";
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            highlightButton((cuiButton)sender);
            metodePemayaran = "Qris";
        }

        private void highlightButton(cuiButton activeButton)
        {
            List<cuiButton> menu_btn = new List<cuiButton> { this.cuiButtonTunai, this.cuiButtonQris };

            foreach (var btn in menu_btn)
            {
                btn.NormalBackground = Color.Transparent;
                btn.HoverBackground = Color.Transparent;
            }

            activeButton.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            activeButton.HoverBackground = Color.FromArgb(32, 128, 128, 128);
        }

        private int simpanOrder()
        {
            string namaKaryawan = cuiComboBoxKaryawan.SelectedItem.ToString();
            int idKaryawan = karyawanLookup[namaKaryawan];
            int total = (int)listmenuOrder.Sum(mo => mo.menu.Harga_menu * mo.qty);
            int idTransaksi = TransaksiController.InsertTransaksi(idKaryawan, total, metodePemayaran);
            foreach (var order in listmenuOrder)
            {
                TransaksiController.InsertTransaksiDetail(idTransaksi, order.menu.id_menu, order.qty, order.Subtotal
                );
            }
            return idTransaksi;


        }

        private void cuiButtonOrder_Click(object sender, EventArgs e)
        {
            Notif notif = new Notif();
            string namaKaryawan = cuiComboBoxKaryawan.SelectedItem.ToString();
            if (listmenuOrder.Count == 0)
            {
                notif.setPesan("Tidak ada order yang masuk");
                notif.visibleExit(false);
                notif.ShowDialog();
            }

            else if (!karyawanLookup.ContainsKey(namaKaryawan))
            {
                notif.setPesan("Belum Memilih Kasir");
                notif.visibleExit(false);
                notif.ShowDialog();
            }

            else if (metodePemayaran == null)
            {
                notif.setPesan("Belum Memilih metode pembayaran");
                notif.visibleExit(false);
                notif.ShowDialog();
            }
            else
            {
                int idTransaksi = simpanOrder();
                Payment payment = new Payment(idTransaksi);
                centerPopUp(payment);
                payment.ShowDialog();
                listmenuOrder.Clear();
                flowLayoutPanelOrder.Controls.Clear();
                loadTotal();

            }
        }
        public void centerPopUp(Form form)
        {
            Point posisiGlobal = this.PointToScreen(Point.Empty);

            int centerX = posisiGlobal.X + (this.Width - form.Width) / 2;
            int centerY = posisiGlobal.Y + (this.Height - form.Height) / 2;

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(centerX, centerY);
        }

    }
}

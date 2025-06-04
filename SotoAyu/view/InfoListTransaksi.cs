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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SotoAyu.view
{
    public partial class InfoListTransaksi : Form
    {
        int id;
        string tanggal;
        List<MenuOrder> menuOrders = new List<MenuOrder>();
        public InfoListTransaksi(int id, string tanggal)
        {
            InitializeComponent();
            this.id = id;
            this.tanggal = tanggal;
            cuiLabelTanggal.Content = tanggal;
            LoadInfoTransaksi(id);
        }

        private void cuiButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadInfoTransaksi(int idTransaksi)
        {
            List<MenuOrder> detailOrder = TransaksiController.InfoDetailTransaksi(idTransaksi);
            flowLayoutPanelDetailList.Controls.Clear();

            foreach (var order in detailOrder)
            {
                string teks = $"{order.menu.Nama_menu} {order.menu.Harga_menu} x {order.qty}";
                cuiLabel lbl = new cuiLabel();
                lbl.BackColor = Color.Transparent;
                lbl.Content = teks;
                lbl.Font = new Font("Alike", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                lbl.ForeColor = Color.FromArgb(75, 110, 2);
                lbl.HorizontalAlignment = StringAlignment.Center;
                lbl.Margin = new Padding(4, 5, 4, 5);
                lbl.Size = new Size(281, 34);
                lbl.VerticalAlignment = StringAlignment.Center;
                flowLayoutPanelDetailList.Controls.Add(lbl);
            }
        }

    }
}

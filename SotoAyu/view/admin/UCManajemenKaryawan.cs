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
using SotoAyu.model;

namespace SotoAyu.view
{
    public partial class UCManajemenKaryawan : UserControl
    {
        public UCManajemenKaryawan()
        {
            InitializeComponent();
            loadKaryawan();
        }

        private void cuiButtonTambahKaryawan_Click(object sender, EventArgs e)
        {
            TambahKaryawan tambahKaryawan = new TambahKaryawan();
            centerPopUp(tambahKaryawan);
            tambahKaryawan.ShowDialog();
            loadKaryawan();
        }
        public void centerPopUp(Form form)
        {
            Point posisiGlobal = this.PointToScreen(Point.Empty);

            int centerX = posisiGlobal.X + (this.Width - form.Width) / 2;
            int centerY = posisiGlobal.Y + (this.Height - form.Height) / 2;

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(centerX, centerY);
        }
        public void loadKaryawan()
        {
            flowLayoutPanelKaryawan.Controls.Clear();
            var list_karyawan = KaryawanController.GetKaryawans();
            var filter = list_karyawan.Where(a => a.status == true);
            int no = 1;
            foreach (var karyawan in filter)
            {
                flowLayoutPanelKaryawan.Controls.Add(new UCListKaryawan(karyawan,no,this));
                no++;
            }
        }
        private void loadKaryawan(string search)
        {
            flowLayoutPanelKaryawan.Controls.Clear();
            var list_karyawan = KaryawanController.GetKaryawans();
            var filter = list_karyawan.Where(a => a.nama.Contains(search));
            int no = 1;
            foreach (var karyawan in filter)
            {
                flowLayoutPanelKaryawan.Controls.Add(new UCListKaryawan(karyawan, no,this));
                no++;
            }

        }

        private void cuiButtonCreate_Click(object sender, EventArgs e)
        {
            string search = cuiTextBoxSearch.Content;
            loadKaryawan(search);
        }
    }

}

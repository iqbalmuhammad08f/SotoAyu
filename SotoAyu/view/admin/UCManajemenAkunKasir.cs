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
    public partial class UCManajemenAkunKasir : UserControl
    {
        public UCManajemenAkunKasir()
        {
            InitializeComponent();
        }

        private void cuiButtonCreateKasir_Click(object sender, EventArgs e)
        {
            if (KasirController.Read() == null)
            {
                BuatAkunKasir buatAkunKasir = new BuatAkunKasir();
                centerPopUp(buatAkunKasir);
                buatAkunKasir.ShowDialog();
            }
            else
            {
                Notif notif = new Notif();
                notif.setPesan("Tidak Dapat Membuat Akun Kasir Lagi");
                centerPopUp(notif);
                notif.ShowDialog();
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

        private void cuiButtonInfoKasir_Click(object sender, EventArgs e)
        {
            if (KasirController.Read() == null)
            {
                Notif notif = new Notif();
                notif.setPesan("Belum Memiliki Akun Kasir");
                centerPopUp(notif);
                notif.ShowDialog();
            }
            else
            {
                Kasir kasir = KasirController.Read();
                InfoAkunKasir infoAkunKasir = new InfoAkunKasir();
                infoAkunKasir.setUserPW(kasir.username, kasir.password);
                centerPopUp(infoAkunKasir);
                infoAkunKasir.ShowDialog();
            }
        }

        private void cuiButtonUpdateKasir_Click(object sender, EventArgs e)
        {
            if (KasirController.Read() == null)
            {
                Notif notif = new Notif();
                notif.setPesan("Belum Memiliki Akun Kasir");
                centerPopUp(notif);
                notif.ShowDialog();
            }
            else
            {
                PerbaruiAkunKasir perbaruiAkunKasir = new PerbaruiAkunKasir();
                centerPopUp(perbaruiAkunKasir);
                perbaruiAkunKasir.ShowDialog();
            }
        }
    }
}

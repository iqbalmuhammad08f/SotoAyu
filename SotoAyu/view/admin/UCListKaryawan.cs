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
    public partial class UCListKaryawan : UserControl
    {
        private int id_karyawan;
        Karyawan karyawan;
        UCManajemenKaryawan manajemenKaryawan;
        public UCListKaryawan(Karyawan karyawan, int no, UCManajemenKaryawan manajemenKaryawan)
        {
            InitializeComponent();
            this.karyawan = karyawan;
            this.id_karyawan = karyawan.id_karywan;
            this.manajemenKaryawan = manajemenKaryawan;
            cuiLabelNo.Content = no.ToString();
            cuiLabelNama.Content = karyawan.nama;
            cuiLabelRole.Content = karyawan.role;
        }

        private void cuiButtonHapus_Click(object sender, EventArgs e)
        {
            Notif notif = new Notif();
            notif.visibleExit(true);
            notif.ShowDialog();

            if (notif.UserConfirmed)
            {
                KaryawanController.DelKaryawan(id_karyawan);
                this.Parent.Controls.Remove(this);
            }
        }

        private void cuiButtonEdit_Click(object sender, EventArgs e)
        {
            EditKaryawan editKaryawan = new EditKaryawan(karyawan);
            editKaryawan.ShowDialog();
            manajemenKaryawan.loadKaryawan();

        }
    }
}

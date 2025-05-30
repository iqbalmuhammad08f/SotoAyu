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
        public UCListKaryawan(Karyawan karyawan)
        {
            InitializeComponent();
            this.id_karyawan = karyawan.id_karywan;
            cuiLabelNama.Content = karyawan.nama;
            cuiLabelRole.Content = karyawan.role;
        }

        private void cuiButtonAccept_Click(object sender, EventArgs e)
        {
            Notif notif = new Notif();
            notif.ShowDialog();

            if (notif.UserConfirmed)
            {
                KaryawanController.DelKaryawan(id_karyawan);
                this.Parent.Controls.Remove(this);
            }
        }
    }
}

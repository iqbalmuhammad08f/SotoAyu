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
    public partial class EditKaryawan : Form
    {
        Karyawan karyawan;
        public EditKaryawan(Karyawan karyawan)
        {
            InitializeComponent();
            this.karyawan = karyawan;
            cuiTextBoxNama.Enabled = false;
            cuiTextBoxNama.Content = karyawan.nama;


        }

        private void cuiButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cuiButtonAccept_Click(object sender, EventArgs e)
        {
            string role = cuiComboBoxRole.SelectedItem.ToLower();
            if (role != string.Empty)
            {
                KaryawanController.UpdateKaryawan(karyawan.id_karywan, role);
                Notif notif = new Notif();
                notif.setPesan("Berhasil Diupdate");
                notif.visibleExit(false);
                notif.ShowDialog();
                this.Close();
            }
            else
            {
                Notif notif = new Notif();
                notif.setPesan("Belum Mengisi role");
                notif.visibleExit(false);
                notif.ShowDialog();
            }
        }
    }
}

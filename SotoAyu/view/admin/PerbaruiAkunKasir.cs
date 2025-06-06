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
    public partial class PerbaruiAkunKasir : Form
    {
        public PerbaruiAkunKasir()
        {
            InitializeComponent();
        }

        private void cuiButtonCreate_Click(object sender, EventArgs e)
        {
            Kasir akun = KasirController.Read();
            string username = akun.username;
            string password = akun.password;

            string username_lama = cuiTextBoxUserLama.Content;
            string password_lama = cuiTextBoxPwLama.Content;

            string username_baru = cuiTextBoxUserBaru.Content;
            string password_baru = cuiTextBoxPwBaru.Content;

            if (username == username_lama && password == password_lama && password_lama != password_baru)
            {
                KasirController.Update(username_baru, password_baru);
                Notif notif = new Notif();
                notif.setPesan("Akun Berhasil Diperbarui");
                notif.ShowDialog(this);
                this.Close();
            }
            else
            {
                Notif notif = new Notif();
                notif.setPesan("Input Tidak Sesuai");
                notif.ShowDialog(this);
            }


        }

        private void cuiButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

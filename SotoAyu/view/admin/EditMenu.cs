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
    public partial class EditMenu : Form
    {
        Menu menu;
        UCManajemenMenu parentmenu;
        public EditMenu(Menu menu, UCManajemenMenu parentmenu)
        {
            InitializeComponent();
            this.parentmenu = parentmenu;
            this.menu = menu;
            cuiTextBoxNama.Content = menu.Nama_menu;
            cuiLabelKategori.Content = menu.Kategori_Menu;
            using (MemoryStream ms = new MemoryStream(menu.Gambar_menu))
            {
                cuiPictureBoxUpload.BackgroundImage = Image.FromStream(ms);
            }
        }

        private void cuiButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cuiButtonOk_Click(object sender, EventArgs e)
        {
            int harga;
            if (!int.TryParse(cuiTextBoxHarga.Content, out harga))
            {
                Notif notif = new Notif();
                notif.setPesan("Input tidak sesuai");
                notif.ShowDialog();
                cuiTextBoxHarga.Content = "";

            }
            else
            {
                Notif notif = new Notif();
                MenuController.updateMenu(menu, harga);
                notif.setPesan("Menu berhasil diupdate");
                notif.ShowDialog();
                parentmenu.loadMenu();
                this.Close();
            }
        }

        private void cuiButtonHapus_Click(object sender, EventArgs e)
        {
            Notif notif = new Notif();
            notif.visibleExit(true);
            MenuController.hapusMenu(menu);
            notif.ShowDialog();
            if (notif.UserConfirmed)
            {
                parentmenu.loadMenu();
                this.Close();
            }
        }
    }
}

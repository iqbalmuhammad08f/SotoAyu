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
    public partial class TambahMenu : Form
    {
        private byte[] imageBytes;

        public TambahMenu()
        {
            InitializeComponent();

        }

        private void cuiPictureBoxUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Pilih gambar";
                openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    cuiPictureBoxUpload.BackgroundImage = Image.FromFile(openFile.FileName);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        cuiPictureBoxUpload.BackgroundImage.Save(ms, cuiPictureBoxUpload.BackgroundImage.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }
            }
        }

        private void cuiButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setKategori(string kategori)
        {
            cuiLabelKategori.Content = kategori;
        }

        private void cuiButtonAccept_Click(object sender, EventArgs e)
        {
            string nama = cuiTextBoxNama.Content;
            int harga;
            string kategori = cuiLabelKategori.Content;
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
                MenuController.tambahmenu(nama, harga, kategori, imageBytes);
                notif.setPesan("Menu berhasil ditambahkan");
                notif.ShowDialog();
                this.Close();
            }
        }

    }
}

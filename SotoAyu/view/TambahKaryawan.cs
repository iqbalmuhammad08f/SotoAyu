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
    public partial class TambahKaryawan : Form
    {
        public TambahKaryawan()
        {
            InitializeComponent();
        }

        private void cuiButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cuiButtonAccept_Click(object sender, EventArgs e)
        {
            string nama = cuiTextBoxNama.Content;
            string role = cuiComboBoxRole.SelectedItem.ToString().ToLower();

            if (string.IsNullOrWhiteSpace(nama) || nama.Any(char.IsDigit) || role == string.Empty)
            {
                Notif notif = new Notif();
                notif.setPesan("Isi format harus sesuai dan tidak boleh angka");
                notif.ShowDialog();
                cuiTextBoxNama.Content = "";
                cuiComboBoxRole.SelectedItem = string.Empty;
            }
            else
            {
                bool result = KaryawanController.Create(nama, role);
                
                if (result)
                {
                    Notif notif = new Notif();
                    notif.setPesan("Berhasil Ditambahkan");
                    notif.ShowDialog();
                    this.Close();
                }
            }
            
        }
    }
}

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
    public partial class BuatAkunKasir : Form
    {
        public BuatAkunKasir()
        {
            InitializeComponent();
        }

        private void cuiButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cuiButtonCreate_Click(object sender, EventArgs e)
        {
            string username = cuiTextBoxUsername.Content;
            string password = cuiTextBoxPassword.Content;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                KasirController.Create(username, password);
                this.Close();
            }
            else
            {
                MessageBox.Show("Username dan password tidak boleh kosong atau hanya spasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }

}

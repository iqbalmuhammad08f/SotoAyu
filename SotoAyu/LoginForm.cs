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

namespace SotoAyu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            var result = AuthController.login(cuiTextBoxUsername.Content, cuiTextBoxPassword.Content);

            if (result != null)
            {
                if (result == "admin")
                {
                    var form = new MainForm("admin"); 
                    form.Show();
                }
                else if (result == "kasir")
                {
                    var form = new MainForm("kasir");
                    form.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah.");
            }

        }

        private void cuiButtonHidePw_Click(object sender, EventArgs e)
        {
            this.cuiTextBoxPassword.PasswordChar = (cuiTextBoxPassword.PasswordChar) ? false : true;
        }
    }
}

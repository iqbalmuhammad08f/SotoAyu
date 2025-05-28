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
    public partial class UCLogin : UserControl
    {
        MainForm MainForm;
        public UCLogin(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void buttonHidePw_Click(object sender, EventArgs e)
        {
            this.cuiTextBoxPassword.PasswordChar = (cuiTextBoxPassword.PasswordChar) ? false : true;
        }

        private void cuiButtonLogin_Click(object sender, EventArgs e)
        {
            var result = AuthController.login(cuiTextBoxUsername.Content, cuiTextBoxPassword.Content);
            if (result != null)
            {
                if (result == "admin")
                {
                    MainForm.LoadControl(new UCDasboardAdmin(MainForm));
                }
                else if (result == "kasir")
                {
                    MainForm.LoadControl(new UCDasboardKasir());
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah.");
            }
        }

        private void UCLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

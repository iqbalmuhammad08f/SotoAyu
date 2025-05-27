using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SotoAyu.view
{
    public partial class InfoAkunKasir : Form
    {
        public InfoAkunKasir()
        {
            InitializeComponent();
        }

        private void cuiButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setUserPW(string username, string password)
        {
            cuiTextBoxUsername.Content = username;
            cuiTextBoxPassword.Content = password;
        }
    }
}

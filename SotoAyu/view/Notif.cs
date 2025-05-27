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
    public partial class Notif : Form
    {
        public Notif()
        {
            InitializeComponent();
        }
        public void setPesan(string pesan)
        {
            labelNotif.Text = pesan;
        }

        private void cuiButtonAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

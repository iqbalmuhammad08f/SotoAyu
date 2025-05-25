using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SotoAyu.view;

namespace SotoAyu
{
    public partial class tester : Form
    {
        public tester()
        {
            InitializeComponent();
            LoadControl(new UCDasboardAdmin());

        }

        public void LoadControl(UserControl uc)
        {
            cuiPanel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            cuiPanel1.Controls.Add(uc);
        }
    }
}

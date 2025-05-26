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
    public partial class UCManajemenAkunKasir : UserControl
    {
        public UCManajemenAkunKasir()
        {
            InitializeComponent();
        }

        private void cuiButtonCreateKasir_Click(object sender, EventArgs e)
        {
            BuatAkunKasir buatAkunKasir = new BuatAkunKasir();

            Point posisiGlobal = this.PointToScreen(Point.Empty);

            int centerX = posisiGlobal.X + (this.Width - buatAkunKasir.Width) / 2;
            int centerY = posisiGlobal.Y + (this.Height - buatAkunKasir.Height) / 2;

            buatAkunKasir.StartPosition = FormStartPosition.Manual;
            buatAkunKasir.Location = new Point(centerX, centerY);

            buatAkunKasir.ShowDialog();
        }
    }
}

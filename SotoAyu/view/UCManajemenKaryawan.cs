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
    public partial class UCManajemenKaryawan : UserControl
    {
        public UCManajemenKaryawan()
        {
            InitializeComponent();
        }

        private void cuiButtonTambahKaryawan_Click(object sender, EventArgs e)
        {
            TambahKaryawan tambahKaryawan = new TambahKaryawan();
            centerPopUp(tambahKaryawan);
            tambahKaryawan.ShowDialog();
        }
        public void centerPopUp(Form form)
        {
            Point posisiGlobal = this.PointToScreen(Point.Empty);

            int centerX = posisiGlobal.X + (this.Width - form.Width) / 2;
            int centerY = posisiGlobal.Y + (this.Height - form.Height) / 2;

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(centerX, centerY);
        }
    }
}

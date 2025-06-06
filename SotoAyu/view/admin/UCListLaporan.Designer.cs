namespace SotoAyu.view.admin
{
    partial class UCListLaporan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cuiLabelNama = new CuoreUI.Controls.cuiLabel();
            cuiLabelTotal = new CuoreUI.Controls.cuiLabel();
            cuiLabelTanggal = new CuoreUI.Controls.cuiLabel();
            cuiLabelNo = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // cuiLabelNama
            // 
            cuiLabelNama.BackColor = Color.White;
            cuiLabelNama.Content = "Nama\\ Warung";
            cuiLabelNama.Font = new Font("Alike", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelNama.ForeColor = Color.FromArgb(75, 110, 2);
            cuiLabelNama.HorizontalAlignment = StringAlignment.Center;
            cuiLabelNama.Location = new Point(292, 7);
            cuiLabelNama.Margin = new Padding(4, 5, 4, 5);
            cuiLabelNama.Name = "cuiLabelNama";
            cuiLabelNama.Size = new Size(190, 34);
            cuiLabelNama.TabIndex = 53;
            cuiLabelNama.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabelTotal
            // 
            cuiLabelTotal.BackColor = Color.White;
            cuiLabelTotal.Content = "Total";
            cuiLabelTotal.Font = new Font("Alike", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelTotal.ForeColor = Color.FromArgb(75, 110, 2);
            cuiLabelTotal.HorizontalAlignment = StringAlignment.Center;
            cuiLabelTotal.Location = new Point(545, 7);
            cuiLabelTotal.Margin = new Padding(4, 5, 4, 5);
            cuiLabelTotal.Name = "cuiLabelTotal";
            cuiLabelTotal.Size = new Size(262, 34);
            cuiLabelTotal.TabIndex = 52;
            cuiLabelTotal.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabelTanggal
            // 
            cuiLabelTanggal.BackColor = Color.White;
            cuiLabelTanggal.Content = "Tanggal";
            cuiLabelTanggal.Font = new Font("Alike", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelTanggal.ForeColor = Color.FromArgb(75, 110, 2);
            cuiLabelTanggal.HorizontalAlignment = StringAlignment.Center;
            cuiLabelTanggal.Location = new Point(72, 7);
            cuiLabelTanggal.Margin = new Padding(4, 5, 4, 5);
            cuiLabelTanggal.Name = "cuiLabelTanggal";
            cuiLabelTanggal.Size = new Size(212, 34);
            cuiLabelTanggal.TabIndex = 51;
            cuiLabelTanggal.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabelNo
            // 
            cuiLabelNo.BackColor = Color.White;
            cuiLabelNo.Content = "No";
            cuiLabelNo.Font = new Font("Alike", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelNo.ForeColor = Color.FromArgb(75, 110, 2);
            cuiLabelNo.HorizontalAlignment = StringAlignment.Center;
            cuiLabelNo.Location = new Point(3, 7);
            cuiLabelNo.Margin = new Padding(4, 5, 4, 5);
            cuiLabelNo.Name = "cuiLabelNo";
            cuiLabelNo.Size = new Size(61, 34);
            cuiLabelNo.TabIndex = 50;
            cuiLabelNo.VerticalAlignment = StringAlignment.Center;
            // 
            // UCListLaporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cuiLabelNama);
            Controls.Add(cuiLabelTotal);
            Controls.Add(cuiLabelTanggal);
            Controls.Add(cuiLabelNo);
            Margin = new Padding(0);
            Name = "UCListLaporan";
            Size = new Size(864, 48);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabelNama;
        private CuoreUI.Controls.cuiLabel cuiLabelTotal;
        private CuoreUI.Controls.cuiLabel cuiLabelTanggal;
        private CuoreUI.Controls.cuiLabel cuiLabelNo;
    }
}

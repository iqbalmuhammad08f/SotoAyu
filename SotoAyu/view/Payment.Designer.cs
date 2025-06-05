namespace SotoAyu.view
{
    partial class Payment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            cuiButtonAccept = new CuoreUI.Controls.cuiButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabelTotal = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabelMetode = new CuoreUI.Controls.cuiLabel();
            cuiLabelTanggal = new CuoreUI.Controls.cuiLabel();
            cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            cuiLabelKasir = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // cuiFormRounder1
            // 
            cuiFormRounder1.EnhanceCorners = false;
            cuiFormRounder1.OutlineColor = Color.FromArgb(32, 128, 128, 128);
            cuiFormRounder1.Rounding = 10;
            cuiFormRounder1.TargetForm = this;
            // 
            // cuiButtonAccept
            // 
            cuiButtonAccept.BackColor = Color.Transparent;
            cuiButtonAccept.CheckButton = false;
            cuiButtonAccept.Checked = false;
            cuiButtonAccept.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonAccept.CheckedForeColor = Color.White;
            cuiButtonAccept.CheckedImageTint = Color.White;
            cuiButtonAccept.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonAccept.Content = "Confrim";
            cuiButtonAccept.DialogResult = DialogResult.None;
            cuiButtonAccept.Font = new Font("Archivo Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButtonAccept.ForeColor = Color.White;
            cuiButtonAccept.HoverBackground = Color.White;
            cuiButtonAccept.HoveredImageTint = Color.White;
            cuiButtonAccept.HoverForeColor = Color.Black;
            cuiButtonAccept.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButtonAccept.Image = null;
            cuiButtonAccept.ImageAutoCenter = true;
            cuiButtonAccept.ImageExpand = new Point(0, 0);
            cuiButtonAccept.ImageOffset = new Point(0, 0);
            cuiButtonAccept.Location = new Point(69, 437);
            cuiButtonAccept.Name = "cuiButtonAccept";
            cuiButtonAccept.NormalBackground = Color.FromArgb(67, 119, 30);
            cuiButtonAccept.NormalForeColor = Color.White;
            cuiButtonAccept.NormalImageTint = Color.White;
            cuiButtonAccept.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonAccept.OutlineThickness = 1F;
            cuiButtonAccept.PressedBackground = Color.WhiteSmoke;
            cuiButtonAccept.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButtonAccept.PressedImageTint = Color.White;
            cuiButtonAccept.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonAccept.Rounding = new Padding(25);
            cuiButtonAccept.Size = new Size(205, 55);
            cuiButtonAccept.TabIndex = 15;
            cuiButtonAccept.TextAlignment = StringAlignment.Center;
            cuiButtonAccept.TextOffset = new Point(0, 0);
            cuiButtonAccept.Click += cuiButtonAccept_Click;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Payment\\ Success!";
            cuiLabel1.Font = new Font("Archivo Black", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.FromArgb(35, 48, 8);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(46, 168);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(298, 46);
            cuiLabel1.TabIndex = 18;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabelTotal
            // 
            cuiLabelTotal.BackColor = Color.Transparent;
            cuiLabelTotal.Content = "Total";
            cuiLabelTotal.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelTotal.ForeColor = Color.FromArgb(4, 32, 33);
            cuiLabelTotal.HorizontalAlignment = StringAlignment.Center;
            cuiLabelTotal.Location = new Point(13, 216);
            cuiLabelTotal.Margin = new Padding(4, 5, 4, 5);
            cuiLabelTotal.Name = "cuiLabelTotal";
            cuiLabelTotal.Size = new Size(331, 27);
            cuiLabelTotal.TabIndex = 20;
            cuiLabelTotal.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Metode\\ pembayaran";
            cuiLabel3.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = Color.FromArgb(4, 32, 33);
            cuiLabel3.HorizontalAlignment = StringAlignment.Near;
            cuiLabel3.Location = new Point(13, 321);
            cuiLabel3.Margin = new Padding(4, 5, 4, 5);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(174, 27);
            cuiLabel3.TabIndex = 21;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel4
            // 
            cuiLabel4.BackColor = Color.Transparent;
            cuiLabel4.Content = "Tanggal";
            cuiLabel4.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel4.ForeColor = Color.FromArgb(4, 32, 33);
            cuiLabel4.HorizontalAlignment = StringAlignment.Near;
            cuiLabel4.Location = new Point(13, 358);
            cuiLabel4.Margin = new Padding(4, 5, 4, 5);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(187, 27);
            cuiLabel4.TabIndex = 22;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabelMetode
            // 
            cuiLabelMetode.BackColor = Color.Transparent;
            cuiLabelMetode.Content = "Metode";
            cuiLabelMetode.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelMetode.ForeColor = Color.FromArgb(4, 32, 33);
            cuiLabelMetode.HorizontalAlignment = StringAlignment.Far;
            cuiLabelMetode.Location = new Point(195, 321);
            cuiLabelMetode.Margin = new Padding(4, 5, 4, 5);
            cuiLabelMetode.Name = "cuiLabelMetode";
            cuiLabelMetode.Size = new Size(149, 27);
            cuiLabelMetode.TabIndex = 23;
            cuiLabelMetode.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabelTanggal
            // 
            cuiLabelTanggal.BackColor = Color.Transparent;
            cuiLabelTanggal.Content = "Tanggal";
            cuiLabelTanggal.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelTanggal.ForeColor = Color.FromArgb(4, 32, 33);
            cuiLabelTanggal.HorizontalAlignment = StringAlignment.Far;
            cuiLabelTanggal.Location = new Point(195, 358);
            cuiLabelTanggal.Margin = new Padding(4, 5, 4, 5);
            cuiLabelTanggal.Name = "cuiLabelTanggal";
            cuiLabelTanggal.Size = new Size(149, 27);
            cuiLabelTanggal.TabIndex = 24;
            cuiLabelTanggal.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel5
            // 
            cuiLabel5.BackColor = Color.Transparent;
            cuiLabel5.Content = "Kasir";
            cuiLabel5.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel5.ForeColor = Color.FromArgb(4, 32, 33);
            cuiLabel5.HorizontalAlignment = StringAlignment.Near;
            cuiLabel5.Location = new Point(13, 284);
            cuiLabel5.Margin = new Padding(4, 5, 4, 5);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(174, 27);
            cuiLabel5.TabIndex = 25;
            cuiLabel5.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabelKasir
            // 
            cuiLabelKasir.BackColor = Color.Transparent;
            cuiLabelKasir.Content = "Nama\\ Kasir";
            cuiLabelKasir.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelKasir.ForeColor = Color.FromArgb(4, 32, 33);
            cuiLabelKasir.HorizontalAlignment = StringAlignment.Far;
            cuiLabelKasir.Location = new Point(195, 284);
            cuiLabelKasir.Margin = new Padding(4, 5, 4, 5);
            cuiLabelKasir.Name = "cuiLabelKasir";
            cuiLabelKasir.Size = new Size(149, 27);
            cuiLabelKasir.TabIndex = 26;
            cuiLabelKasir.VerticalAlignment = StringAlignment.Near;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(357, 516);
            Controls.Add(cuiLabelKasir);
            Controls.Add(cuiLabel5);
            Controls.Add(cuiLabelTanggal);
            Controls.Add(cuiLabelMetode);
            Controls.Add(cuiLabel4);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiLabelTotal);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiButtonAccept);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private CuoreUI.Controls.cuiButton cuiButtonAccept;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabelTotal;
        private CuoreUI.Controls.cuiLabel cuiLabelTanggal;
        private CuoreUI.Controls.cuiLabel cuiLabelMetode;
        private CuoreUI.Controls.cuiLabel cuiLabelKasir;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
    }
}
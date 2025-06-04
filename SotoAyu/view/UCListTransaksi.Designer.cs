namespace SotoAyu.view
{
    partial class UCListTransaksi
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
            cuiLabelTotal = new CuoreUI.Controls.cuiLabel();
            cuiLabelTanggal = new CuoreUI.Controls.cuiLabel();
            cuiLabelNo = new CuoreUI.Controls.cuiLabel();
            cuiButtonInfo = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // cuiLabelTotal
            // 
            cuiLabelTotal.BackColor = Color.White;
            cuiLabelTotal.Content = "Total";
            cuiLabelTotal.Font = new Font("Alike", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelTotal.ForeColor = Color.FromArgb(75, 110, 2);
            cuiLabelTotal.HorizontalAlignment = StringAlignment.Center;
            cuiLabelTotal.Location = new Point(369, 7);
            cuiLabelTotal.Margin = new Padding(4, 5, 4, 5);
            cuiLabelTotal.Name = "cuiLabelTotal";
            cuiLabelTotal.Size = new Size(281, 34);
            cuiLabelTotal.TabIndex = 28;
            cuiLabelTotal.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabelTanggal
            // 
            cuiLabelTanggal.BackColor = Color.White;
            cuiLabelTanggal.Content = "Tanggal";
            cuiLabelTanggal.Font = new Font("Alike", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelTanggal.ForeColor = Color.FromArgb(75, 110, 2);
            cuiLabelTanggal.HorizontalAlignment = StringAlignment.Center;
            cuiLabelTanggal.Location = new Point(80, 7);
            cuiLabelTanggal.Margin = new Padding(4, 5, 4, 5);
            cuiLabelTanggal.Name = "cuiLabelTanggal";
            cuiLabelTanggal.Size = new Size(281, 34);
            cuiLabelTanggal.TabIndex = 27;
            cuiLabelTanggal.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabelNo
            // 
            cuiLabelNo.BackColor = Color.White;
            cuiLabelNo.Content = "No";
            cuiLabelNo.Font = new Font("Alike", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelNo.ForeColor = Color.FromArgb(75, 110, 2);
            cuiLabelNo.HorizontalAlignment = StringAlignment.Center;
            cuiLabelNo.Location = new Point(11, 7);
            cuiLabelNo.Margin = new Padding(4, 5, 4, 5);
            cuiLabelNo.Name = "cuiLabelNo";
            cuiLabelNo.Size = new Size(61, 34);
            cuiLabelNo.TabIndex = 26;
            cuiLabelNo.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiButtonInfo
            // 
            cuiButtonInfo.BackColor = Color.Transparent;
            cuiButtonInfo.CheckButton = false;
            cuiButtonInfo.Checked = false;
            cuiButtonInfo.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonInfo.CheckedForeColor = Color.White;
            cuiButtonInfo.CheckedImageTint = Color.White;
            cuiButtonInfo.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonInfo.Content = "Info";
            cuiButtonInfo.DialogResult = DialogResult.None;
            cuiButtonInfo.Font = new Font("Archivo Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButtonInfo.ForeColor = Color.White;
            cuiButtonInfo.HoverBackground = Color.FromArgb(75, 110, 2);
            cuiButtonInfo.HoveredImageTint = Color.White;
            cuiButtonInfo.HoverForeColor = Color.White;
            cuiButtonInfo.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButtonInfo.Image = null;
            cuiButtonInfo.ImageAutoCenter = true;
            cuiButtonInfo.ImageExpand = new Point(0, 0);
            cuiButtonInfo.ImageOffset = new Point(0, 0);
            cuiButtonInfo.Location = new Point(657, 7);
            cuiButtonInfo.Name = "cuiButtonInfo";
            cuiButtonInfo.NormalBackground = Color.FromArgb(75, 110, 2);
            cuiButtonInfo.NormalForeColor = Color.White;
            cuiButtonInfo.NormalImageTint = Color.White;
            cuiButtonInfo.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonInfo.OutlineThickness = 1F;
            cuiButtonInfo.PressedBackground = Color.WhiteSmoke;
            cuiButtonInfo.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButtonInfo.PressedImageTint = Color.White;
            cuiButtonInfo.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonInfo.Rounding = new Padding(10);
            cuiButtonInfo.Size = new Size(205, 34);
            cuiButtonInfo.TabIndex = 29;
            cuiButtonInfo.TextAlignment = StringAlignment.Center;
            cuiButtonInfo.TextOffset = new Point(0, 0);
            cuiButtonInfo.Click += cuiButtonInfo_Click;
            // 
            // UCListTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cuiButtonInfo);
            Controls.Add(cuiLabelTotal);
            Controls.Add(cuiLabelTanggal);
            Controls.Add(cuiLabelNo);
            Margin = new Padding(0);
            Name = "UCListTransaksi";
            Size = new Size(877, 48);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabelTotal;
        private CuoreUI.Controls.cuiLabel cuiLabelTanggal;
        private CuoreUI.Controls.cuiLabel cuiLabelNo;
        private CuoreUI.Controls.cuiButton cuiButtonInfo;
    }
}

namespace SotoAyu.view
{
    partial class InfoListTransaksi
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
            cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            cuiButtonExit = new CuoreUI.Controls.cuiButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            flowLayoutPanelDetailList = new FlowLayoutPanel();
            cuiLabelTanggal = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // cuiFormRounder1
            // 
            cuiFormRounder1.EnhanceCorners = false;
            cuiFormRounder1.OutlineColor = Color.FromArgb(32, 128, 128, 128);
            cuiFormRounder1.Rounding = 10;
            cuiFormRounder1.TargetForm = this;
            // 
            // cuiButtonExit
            // 
            cuiButtonExit.CheckButton = false;
            cuiButtonExit.Checked = false;
            cuiButtonExit.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonExit.CheckedForeColor = Color.White;
            cuiButtonExit.CheckedImageTint = Color.White;
            cuiButtonExit.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonExit.Content = "";
            cuiButtonExit.DialogResult = DialogResult.None;
            cuiButtonExit.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonExit.ForeColor = Color.Black;
            cuiButtonExit.HoverBackground = Color.FromArgb(231, 0, 0);
            cuiButtonExit.HoveredImageTint = Color.White;
            cuiButtonExit.HoverForeColor = Color.Black;
            cuiButtonExit.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButtonExit.Image = Properties.Resources.Multiply;
            cuiButtonExit.ImageAutoCenter = true;
            cuiButtonExit.ImageExpand = new Point(12, 12);
            cuiButtonExit.ImageOffset = new Point(0, 0);
            cuiButtonExit.Location = new Point(307, 12);
            cuiButtonExit.Name = "cuiButtonExit";
            cuiButtonExit.NormalBackground = Color.FromArgb(231, 0, 0);
            cuiButtonExit.NormalForeColor = Color.Black;
            cuiButtonExit.NormalImageTint = Color.White;
            cuiButtonExit.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonExit.OutlineThickness = 1F;
            cuiButtonExit.PressedBackground = Color.WhiteSmoke;
            cuiButtonExit.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButtonExit.PressedImageTint = Color.White;
            cuiButtonExit.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonExit.Rounding = new Padding(8);
            cuiButtonExit.Size = new Size(39, 38);
            cuiButtonExit.TabIndex = 33;
            cuiButtonExit.TextAlignment = StringAlignment.Center;
            cuiButtonExit.TextOffset = new Point(0, 0);
            cuiButtonExit.Click += cuiButtonExit_Click;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Info";
            cuiLabel1.Font = new Font("Archivo Black", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.FromArgb(35, 48, 8);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(51, 12);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(249, 38);
            cuiLabel1.TabIndex = 35;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // flowLayoutPanelDetailList
            // 
            flowLayoutPanelDetailList.Location = new Point(29, 111);
            flowLayoutPanelDetailList.Name = "flowLayoutPanelDetailList";
            flowLayoutPanelDetailList.Size = new Size(297, 206);
            flowLayoutPanelDetailList.TabIndex = 36;
            // 
            // cuiLabelTanggal
            // 
            cuiLabelTanggal.BackColor = Color.Transparent;
            cuiLabelTanggal.Content = "Tanggal";
            cuiLabelTanggal.Font = new Font("Alike", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelTanggal.ForeColor = Color.FromArgb(75, 110, 2);
            cuiLabelTanggal.HorizontalAlignment = StringAlignment.Center;
            cuiLabelTanggal.Location = new Point(29, 69);
            cuiLabelTanggal.Margin = new Padding(4, 5, 4, 5);
            cuiLabelTanggal.Name = "cuiLabelTanggal";
            cuiLabelTanggal.Size = new Size(281, 34);
            cuiLabelTanggal.TabIndex = 37;
            cuiLabelTanggal.VerticalAlignment = StringAlignment.Center;
            // 
            // InfoListTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 337);
            Controls.Add(cuiLabelTanggal);
            Controls.Add(flowLayoutPanelDetailList);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiButtonExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoListTransaksi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InfoListTransaksi";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private CuoreUI.Controls.cuiButton cuiButtonExit;
        private FlowLayoutPanel flowLayoutPanelDetailList;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabelTanggal;
    }
}
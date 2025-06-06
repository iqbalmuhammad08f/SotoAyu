namespace SotoAyu.view
{
    partial class UCListMenu
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
            cuiPictureBoxGambar = new CuoreUI.Controls.cuiPictureBox();
            cuiLabelNama = new CuoreUI.Controls.cuiLabel();
            cuiLabelHarga = new CuoreUI.Controls.cuiLabel();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // cuiPictureBoxGambar
            // 
            cuiPictureBoxGambar.BackColor = Color.White;
            cuiPictureBoxGambar.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBoxGambar.Content = null;
            cuiPictureBoxGambar.ImageTint = Color.White;
            cuiPictureBoxGambar.Location = new Point(36, 21);
            cuiPictureBoxGambar.Margin = new Padding(4, 5, 4, 5);
            cuiPictureBoxGambar.Name = "cuiPictureBoxGambar";
            cuiPictureBoxGambar.OutlineThickness = 1F;
            cuiPictureBoxGambar.PanelOutlineColor = Color.Empty;
            cuiPictureBoxGambar.Rotation = 0;
            cuiPictureBoxGambar.Rounding = new Padding(8);
            cuiPictureBoxGambar.Size = new Size(102, 88);
            cuiPictureBoxGambar.TabIndex = 0;
            // 
            // cuiLabelNama
            // 
            cuiLabelNama.BackColor = Color.White;
            cuiLabelNama.Content = "Nama";
            cuiLabelNama.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelNama.ForeColor = Color.Black;
            cuiLabelNama.HorizontalAlignment = StringAlignment.Center;
            cuiLabelNama.Location = new Point(5, 119);
            cuiLabelNama.Margin = new Padding(4, 5, 4, 5);
            cuiLabelNama.Name = "cuiLabelNama";
            cuiLabelNama.Size = new Size(168, 30);
            cuiLabelNama.TabIndex = 23;
            cuiLabelNama.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabelHarga
            // 
            cuiLabelHarga.BackColor = Color.White;
            cuiLabelHarga.Content = "Harga";
            cuiLabelHarga.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelHarga.ForeColor = Color.Black;
            cuiLabelHarga.HorizontalAlignment = StringAlignment.Center;
            cuiLabelHarga.Location = new Point(5, 159);
            cuiLabelHarga.Margin = new Padding(4, 5, 4, 5);
            cuiLabelHarga.Name = "cuiLabelHarga";
            cuiLabelHarga.Size = new Size(168, 30);
            cuiLabelHarga.TabIndex = 24;
            cuiLabelHarga.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.Transparent;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Dock = DockStyle.Fill;
            cuiButton1.Enabled = false;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(0, 0);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(10);
            cuiButton1.Size = new Size(177, 213);
            cuiButton1.TabIndex = 30;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // UCListMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(cuiLabelHarga);
            Controls.Add(cuiLabelNama);
            Controls.Add(cuiPictureBoxGambar);
            Controls.Add(cuiButton1);
            Margin = new Padding(20);
            Name = "UCListMenu";
            Size = new Size(177, 213);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPictureBox cuiPictureBoxGambar;
        private CuoreUI.Controls.cuiLabel cuiLabelNama;
        private CuoreUI.Controls.cuiLabel cuiLabelHarga;
        private CuoreUI.Controls.cuiButton cuiButton1;
    }
}

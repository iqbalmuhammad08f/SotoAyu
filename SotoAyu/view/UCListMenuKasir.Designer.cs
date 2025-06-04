namespace SotoAyu.view
{
    partial class UCListMenuKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCListMenuKasir));
            cuiLabelHarga = new CuoreUI.Controls.cuiLabel();
            cuiLabelNama = new CuoreUI.Controls.cuiLabel();
            cuiPictureBoxGambar = new CuoreUI.Controls.cuiPictureBox();
            cuiButtonAdd = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // cuiLabelHarga
            // 
            cuiLabelHarga.BackColor = Color.Transparent;
            cuiLabelHarga.Content = "Harga";
            cuiLabelHarga.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelHarga.ForeColor = Color.Black;
            cuiLabelHarga.HorizontalAlignment = StringAlignment.Center;
            cuiLabelHarga.Location = new Point(7, 143);
            cuiLabelHarga.Margin = new Padding(4, 5, 4, 5);
            cuiLabelHarga.Name = "cuiLabelHarga";
            cuiLabelHarga.Size = new Size(103, 21);
            cuiLabelHarga.TabIndex = 27;
            cuiLabelHarga.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabelNama
            // 
            cuiLabelNama.BackColor = Color.Transparent;
            cuiLabelNama.Content = "Nama";
            cuiLabelNama.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelNama.ForeColor = Color.Black;
            cuiLabelNama.HorizontalAlignment = StringAlignment.Center;
            cuiLabelNama.Location = new Point(7, 103);
            cuiLabelNama.Margin = new Padding(4, 5, 4, 5);
            cuiLabelNama.Name = "cuiLabelNama";
            cuiLabelNama.Size = new Size(153, 21);
            cuiLabelNama.TabIndex = 26;
            cuiLabelNama.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiPictureBoxGambar
            // 
            cuiPictureBoxGambar.BackColor = Color.Transparent;
            cuiPictureBoxGambar.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBoxGambar.Content = null;
            cuiPictureBoxGambar.ImageTint = Color.White;
            cuiPictureBoxGambar.Location = new Point(47, 5);
            cuiPictureBoxGambar.Margin = new Padding(4, 5, 4, 5);
            cuiPictureBoxGambar.Name = "cuiPictureBoxGambar";
            cuiPictureBoxGambar.OutlineThickness = 1F;
            cuiPictureBoxGambar.PanelOutlineColor = Color.Empty;
            cuiPictureBoxGambar.Rotation = 0;
            cuiPictureBoxGambar.Rounding = new Padding(8);
            cuiPictureBoxGambar.Size = new Size(85, 88);
            cuiPictureBoxGambar.TabIndex = 25;
            // 
            // cuiButtonAdd
            // 
            cuiButtonAdd.BackColor = Color.Transparent;
            cuiButtonAdd.BackgroundImage = (Image)resources.GetObject("cuiButtonAdd.BackgroundImage");
            cuiButtonAdd.BackgroundImageLayout = ImageLayout.Zoom;
            cuiButtonAdd.CheckButton = false;
            cuiButtonAdd.Checked = false;
            cuiButtonAdd.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonAdd.CheckedForeColor = Color.White;
            cuiButtonAdd.CheckedImageTint = Color.White;
            cuiButtonAdd.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonAdd.Content = "";
            cuiButtonAdd.DialogResult = DialogResult.None;
            cuiButtonAdd.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonAdd.ForeColor = Color.Black;
            cuiButtonAdd.HoverBackground = Color.Transparent;
            cuiButtonAdd.HoveredImageTint = Color.White;
            cuiButtonAdd.HoverForeColor = Color.Black;
            cuiButtonAdd.HoverOutline = Color.Transparent;
            cuiButtonAdd.Image = null;
            cuiButtonAdd.ImageAutoCenter = true;
            cuiButtonAdd.ImageExpand = new Point(0, 0);
            cuiButtonAdd.ImageOffset = new Point(0, 0);
            cuiButtonAdd.Location = new Point(110, 121);
            cuiButtonAdd.Name = "cuiButtonAdd";
            cuiButtonAdd.NormalBackground = Color.Transparent;
            cuiButtonAdd.NormalForeColor = Color.Black;
            cuiButtonAdd.NormalImageTint = Color.White;
            cuiButtonAdd.NormalOutline = Color.Transparent;
            cuiButtonAdd.OutlineThickness = 1F;
            cuiButtonAdd.PressedBackground = Color.WhiteSmoke;
            cuiButtonAdd.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButtonAdd.PressedImageTint = Color.White;
            cuiButtonAdd.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonAdd.Rounding = new Padding(8);
            cuiButtonAdd.Size = new Size(50, 45);
            cuiButtonAdd.TabIndex = 28;
            cuiButtonAdd.TextAlignment = StringAlignment.Center;
            cuiButtonAdd.TextOffset = new Point(0, 0);
            cuiButtonAdd.Click += cuiButtonAdd_Click;
            // 
            // UCListMenuKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cuiButtonAdd);
            Controls.Add(cuiLabelHarga);
            Controls.Add(cuiLabelNama);
            Controls.Add(cuiPictureBoxGambar);
            Name = "UCListMenuKasir";
            Size = new Size(167, 169);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabelHarga;
        private CuoreUI.Controls.cuiLabel cuiLabelNama;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBoxGambar;
        private CuoreUI.Controls.cuiButton cuiButtonAdd;
    }
}

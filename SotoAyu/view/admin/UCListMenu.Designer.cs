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
            SuspendLayout();
            // 
            // cuiPictureBoxGambar
            // 
            cuiPictureBoxGambar.BackColor = Color.Transparent;
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
            cuiLabelNama.BackColor = Color.Transparent;
            cuiLabelNama.Content = "Nama";
            cuiLabelNama.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelNama.ForeColor = Color.Black;
            cuiLabelNama.HorizontalAlignment = StringAlignment.Center;
            cuiLabelNama.Location = new Point(5, 119);
            cuiLabelNama.Margin = new Padding(4, 5, 4, 5);
            cuiLabelNama.Name = "cuiLabelNama";
            cuiLabelNama.Size = new Size(172, 30);
            cuiLabelNama.TabIndex = 23;
            cuiLabelNama.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabelHarga
            // 
            cuiLabelHarga.BackColor = Color.Transparent;
            cuiLabelHarga.Content = "Harga";
            cuiLabelHarga.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelHarga.ForeColor = Color.Black;
            cuiLabelHarga.HorizontalAlignment = StringAlignment.Center;
            cuiLabelHarga.Location = new Point(5, 159);
            cuiLabelHarga.Margin = new Padding(4, 5, 4, 5);
            cuiLabelHarga.Name = "cuiLabelHarga";
            cuiLabelHarga.Size = new Size(172, 30);
            cuiLabelHarga.TabIndex = 24;
            cuiLabelHarga.VerticalAlignment = StringAlignment.Center;
            // 
            // UCListMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(cuiLabelHarga);
            Controls.Add(cuiLabelNama);
            Controls.Add(cuiPictureBoxGambar);
            Margin = new Padding(20);
            Name = "UCListMenu";
            Size = new Size(177, 213);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPictureBox cuiPictureBoxGambar;
        private CuoreUI.Controls.cuiLabel cuiLabelNama;
        private CuoreUI.Controls.cuiLabel cuiLabelHarga;
    }
}

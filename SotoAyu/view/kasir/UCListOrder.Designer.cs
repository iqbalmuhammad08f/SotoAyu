namespace SotoAyu.view
{
    partial class UCListOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCListOrder));
            cuiLabelNama = new CuoreUI.Controls.cuiLabel();
            cuiLabelHarga = new CuoreUI.Controls.cuiLabel();
            cuiButtonMinus = new CuoreUI.Controls.cuiButton();
            cuiLabelJumlah = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // cuiLabelNama
            // 
            cuiLabelNama.Content = "Nama\\ Menu";
            cuiLabelNama.Font = new Font("Alike", 7.799999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelNama.HorizontalAlignment = StringAlignment.Center;
            cuiLabelNama.Location = new Point(4, 5);
            cuiLabelNama.Margin = new Padding(4, 5, 4, 5);
            cuiLabelNama.Name = "cuiLabelNama";
            cuiLabelNama.Size = new Size(107, 27);
            cuiLabelNama.TabIndex = 0;
            cuiLabelNama.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabelHarga
            // 
            cuiLabelHarga.Content = "Harga";
            cuiLabelHarga.Font = new Font("Alike", 7.799999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelHarga.HorizontalAlignment = StringAlignment.Center;
            cuiLabelHarga.Location = new Point(110, 5);
            cuiLabelHarga.Margin = new Padding(4, 5, 4, 5);
            cuiLabelHarga.Name = "cuiLabelHarga";
            cuiLabelHarga.Size = new Size(97, 27);
            cuiLabelHarga.TabIndex = 1;
            cuiLabelHarga.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiButtonMinus
            // 
            cuiButtonMinus.BackColor = Color.Transparent;
            cuiButtonMinus.BackgroundImage = (Image)resources.GetObject("cuiButtonMinus.BackgroundImage");
            cuiButtonMinus.BackgroundImageLayout = ImageLayout.Zoom;
            cuiButtonMinus.CheckButton = false;
            cuiButtonMinus.Checked = false;
            cuiButtonMinus.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonMinus.CheckedForeColor = Color.White;
            cuiButtonMinus.CheckedImageTint = Color.White;
            cuiButtonMinus.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonMinus.Content = "";
            cuiButtonMinus.DialogResult = DialogResult.None;
            cuiButtonMinus.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonMinus.ForeColor = Color.Black;
            cuiButtonMinus.HoverBackground = Color.Transparent;
            cuiButtonMinus.HoveredImageTint = Color.White;
            cuiButtonMinus.HoverForeColor = Color.Black;
            cuiButtonMinus.HoverOutline = Color.Transparent;
            cuiButtonMinus.Image = null;
            cuiButtonMinus.ImageAutoCenter = true;
            cuiButtonMinus.ImageExpand = new Point(0, 0);
            cuiButtonMinus.ImageOffset = new Point(0, 0);
            cuiButtonMinus.Location = new Point(267, 0);
            cuiButtonMinus.Name = "cuiButtonMinus";
            cuiButtonMinus.NormalBackground = Color.Transparent;
            cuiButtonMinus.NormalForeColor = Color.Black;
            cuiButtonMinus.NormalImageTint = Color.White;
            cuiButtonMinus.NormalOutline = Color.Transparent;
            cuiButtonMinus.OutlineThickness = 1F;
            cuiButtonMinus.PressedBackground = Color.WhiteSmoke;
            cuiButtonMinus.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButtonMinus.PressedImageTint = Color.White;
            cuiButtonMinus.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonMinus.Rounding = new Padding(8);
            cuiButtonMinus.Size = new Size(39, 37);
            cuiButtonMinus.TabIndex = 29;
            cuiButtonMinus.TextAlignment = StringAlignment.Center;
            cuiButtonMinus.TextOffset = new Point(0, 0);
            cuiButtonMinus.Click += cuiButtonMinus_Click;
            // 
            // cuiLabelJumlah
            // 
            cuiLabelJumlah.Content = "jumlah";
            cuiLabelJumlah.Font = new Font("Alike", 7.799999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelJumlah.HorizontalAlignment = StringAlignment.Center;
            cuiLabelJumlah.Location = new Point(216, 5);
            cuiLabelJumlah.Margin = new Padding(4, 5, 4, 5);
            cuiLabelJumlah.Name = "cuiLabelJumlah";
            cuiLabelJumlah.Size = new Size(44, 27);
            cuiLabelJumlah.TabIndex = 30;
            cuiLabelJumlah.VerticalAlignment = StringAlignment.Center;
            // 
            // UCListOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cuiLabelJumlah);
            Controls.Add(cuiButtonMinus);
            Controls.Add(cuiLabelHarga);
            Controls.Add(cuiLabelNama);
            Margin = new Padding(0);
            Name = "UCListOrder";
            Size = new Size(309, 37);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabelNama;
        private CuoreUI.Controls.cuiLabel cuiLabelHarga;
        private CuoreUI.Controls.cuiButton cuiButtonMinus;
        private CuoreUI.Controls.cuiLabel cuiLabelJumlah;
    }
}

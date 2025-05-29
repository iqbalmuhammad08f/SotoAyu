namespace SotoAyu.view
{
    partial class UCListKaryawan
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
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            cuiLabelNama = new CuoreUI.Controls.cuiLabel();
            cuiLabelRole = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // cuiButton2
            // 
            cuiButton2.BackColor = Color.Transparent;
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton2.Content = "";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Dock = DockStyle.Fill;
            cuiButton2.Enabled = false;
            cuiButton2.Font = new Font("Archivo Black", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = Color.White;
            cuiButton2.HoverBackground = Color.White;
            cuiButton2.HoveredImageTint = Color.White;
            cuiButton2.HoverForeColor = Color.Black;
            cuiButton2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.Location = new Point(0, 0);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.FromArgb(108, 156, 8);
            cuiButton2.NormalForeColor = Color.White;
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.PressedBackground = Color.WhiteSmoke;
            cuiButton2.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.Rounding = new Padding(20);
            cuiButton2.Size = new Size(784, 65);
            cuiButton2.TabIndex = 20;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextOffset = new Point(0, 0);
            // 
            // cuiLabelNama
            // 
            cuiLabelNama.BackColor = Color.FromArgb(108, 156, 8);
            cuiLabelNama.Content = "Nama";
            cuiLabelNama.Font = new Font("Alike", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelNama.ForeColor = Color.White;
            cuiLabelNama.HorizontalAlignment = StringAlignment.Center;
            cuiLabelNama.Location = new Point(19, 5);
            cuiLabelNama.Margin = new Padding(4, 5, 4, 5);
            cuiLabelNama.Name = "cuiLabelNama";
            cuiLabelNama.Size = new Size(245, 55);
            cuiLabelNama.TabIndex = 21;
            cuiLabelNama.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabelRole
            // 
            cuiLabelRole.BackColor = Color.FromArgb(108, 156, 8);
            cuiLabelRole.Content = "Role";
            cuiLabelRole.Font = new Font("Alike", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabelRole.ForeColor = Color.White;
            cuiLabelRole.HorizontalAlignment = StringAlignment.Center;
            cuiLabelRole.Location = new Point(520, 5);
            cuiLabelRole.Margin = new Padding(4, 5, 4, 5);
            cuiLabelRole.Name = "cuiLabelRole";
            cuiLabelRole.Size = new Size(245, 55);
            cuiLabelRole.TabIndex = 22;
            cuiLabelRole.VerticalAlignment = StringAlignment.Center;
            // 
            // UCListKaryawan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cuiLabelRole);
            Controls.Add(cuiLabelNama);
            Controls.Add(cuiButton2);
            Margin = new Padding(3, 3, 3, 10);
            Name = "UCListKaryawan";
            Size = new Size(784, 65);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiLabel cuiLabelNama;
        private CuoreUI.Controls.cuiLabel cuiLabelRole;
    }
}

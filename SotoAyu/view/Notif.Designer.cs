namespace SotoAyu.view
{
    partial class Notif
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
            labelNotif = new Label();
            cuiButtonAccept = new CuoreUI.Controls.cuiButton();
            cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            SuspendLayout();
            // 
            // labelNotif
            // 
            labelNotif.FlatStyle = FlatStyle.Flat;
            labelNotif.Font = new Font("Alike", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNotif.Location = new Point(91, 65);
            labelNotif.Name = "labelNotif";
            labelNotif.Size = new Size(264, 70);
            labelNotif.TabIndex = 1;
            labelNotif.Text = "Apakah yakin Ingin keluar?";
            labelNotif.TextAlign = ContentAlignment.MiddleCenter;
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
            cuiButtonAccept.Content = "Ascept";
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
            cuiButtonAccept.Location = new Point(119, 138);
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
            cuiButtonAccept.TabIndex = 14;
            cuiButtonAccept.TextAlignment = StringAlignment.Center;
            cuiButtonAccept.TextOffset = new Point(0, 0);
            cuiButtonAccept.Click += cuiButtonAccept_Click;
            // 
            // cuiFormRounder1
            // 
            cuiFormRounder1.EnhanceCorners = false;
            cuiFormRounder1.OutlineColor = Color.FromArgb(32, 128, 128, 128);
            cuiFormRounder1.Rounding = 10;
            cuiFormRounder1.TargetForm = this;
            // 
            // Notif
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 233);
            Controls.Add(cuiButtonAccept);
            Controls.Add(labelNotif);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notif";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Notif";
            ResumeLayout(false);
        }

        #endregion

        private Label labelNotif;
        private CuoreUI.Controls.cuiButton cuiButtonAccept;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
    }
}
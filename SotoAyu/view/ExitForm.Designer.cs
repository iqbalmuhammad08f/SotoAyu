namespace SotoAyu.view
{
    partial class ExitForm
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
            label1 = new Label();
            cuiButtonExit = new CuoreUI.Controls.cuiButton();
            cuiButtonYes = new CuoreUI.Controls.cuiButton();
            cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Alike", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 70);
            label1.Name = "label1";
            label1.Size = new Size(259, 27);
            label1.TabIndex = 0;
            label1.Text = "Apakah yakin Ingin keluar?";
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
            cuiButtonExit.Location = new Point(63, 114);
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
            cuiButtonExit.Size = new Size(95, 59);
            cuiButtonExit.TabIndex = 1;
            cuiButtonExit.TextAlignment = StringAlignment.Center;
            cuiButtonExit.TextOffset = new Point(0, 0);
            cuiButtonExit.Click += cuiButtonExit_Click;
            // 
            // cuiButtonYes
            // 
            cuiButtonYes.CheckButton = false;
            cuiButtonYes.Checked = false;
            cuiButtonYes.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonYes.CheckedForeColor = Color.White;
            cuiButtonYes.CheckedImageTint = Color.White;
            cuiButtonYes.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonYes.Content = "";
            cuiButtonYes.DialogResult = DialogResult.None;
            cuiButtonYes.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonYes.ForeColor = Color.Black;
            cuiButtonYes.HoverBackground = Color.White;
            cuiButtonYes.HoveredImageTint = Color.White;
            cuiButtonYes.HoverForeColor = Color.Black;
            cuiButtonYes.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButtonYes.Image = Properties.Resources.Done;
            cuiButtonYes.ImageAutoCenter = true;
            cuiButtonYes.ImageExpand = new Point(15, 15);
            cuiButtonYes.ImageOffset = new Point(0, 0);
            cuiButtonYes.Location = new Point(196, 114);
            cuiButtonYes.Name = "cuiButtonYes";
            cuiButtonYes.NormalBackground = Color.White;
            cuiButtonYes.NormalForeColor = Color.Black;
            cuiButtonYes.NormalImageTint = Color.White;
            cuiButtonYes.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonYes.OutlineThickness = 1F;
            cuiButtonYes.PressedBackground = Color.WhiteSmoke;
            cuiButtonYes.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButtonYes.PressedImageTint = Color.White;
            cuiButtonYes.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonYes.Rounding = new Padding(8);
            cuiButtonYes.Size = new Size(95, 59);
            cuiButtonYes.TabIndex = 2;
            cuiButtonYes.TextAlignment = StringAlignment.Center;
            cuiButtonYes.TextOffset = new Point(0, 0);
            cuiButtonYes.Click += cuiButtonYes_Click;
            // 
            // cuiFormRounder1
            // 
            cuiFormRounder1.EnhanceCorners = false;
            cuiFormRounder1.OutlineColor = Color.FromArgb(32, 128, 128, 128);
            cuiFormRounder1.Rounding = 10;
            cuiFormRounder1.TargetForm = this;
            // 
            // ExitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 236);
            Controls.Add(cuiButtonYes);
            Controls.Add(cuiButtonExit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExitForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CuoreUI.Controls.cuiButton cuiButtonExit;
        private CuoreUI.Controls.cuiButton cuiButtonYes;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
    }
}
namespace SotoAyu.view
{
    partial class EditKaryawan
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
            cuiComboBoxRole = new CuoreUI.Controls.cuiComboBox();
            cuiButtonExit = new CuoreUI.Controls.cuiButton();
            cuiButtonAccept = new CuoreUI.Controls.cuiButton();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiTextBoxNama = new CuoreUI.Controls.cuiTextBox();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // cuiFormRounder1
            // 
            cuiFormRounder1.EnhanceCorners = false;
            cuiFormRounder1.OutlineColor = Color.FromArgb(32, 128, 128, 128);
            cuiFormRounder1.Rounding = 10;
            cuiFormRounder1.TargetForm = this;
            // 
            // cuiComboBoxRole
            // 
            cuiComboBoxRole.BackColor = Color.Transparent;
            cuiComboBoxRole.BackgroundColor = Color.FromArgb(232, 232, 232);
            cuiComboBoxRole.ButtonCursor = Cursors.Arrow;
            cuiComboBoxRole.ButtonHoverBackground = Color.DarkOliveGreen;
            cuiComboBoxRole.ButtonHoverOutline = Color.Transparent;
            cuiComboBoxRole.ButtonNormalBackground = Color.FromArgb(67, 119, 30);
            cuiComboBoxRole.ButtonNormalOutline = Color.Transparent;
            cuiComboBoxRole.ButtonPressedBackground = Color.DarkOliveGreen;
            cuiComboBoxRole.ButtonPressedOutline = Color.Empty;
            cuiComboBoxRole.DropDownBackgroundColor = SystemColors.Control;
            cuiComboBoxRole.DropDownOutlineColor = Color.Transparent;
            cuiComboBoxRole.ExpandArrowColor = Color.Gray;
            cuiComboBoxRole.Font = new Font("Alike", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiComboBoxRole.ForeColor = Color.Black;
            cuiComboBoxRole.Items = new string[]
    {
    "Kasir",
    "Chef",
    "Pelayan"
    };
            cuiComboBoxRole.Location = new Point(72, 225);
            cuiComboBoxRole.Margin = new Padding(4, 5, 4, 5);
            cuiComboBoxRole.Name = "cuiComboBoxRole";
            cuiComboBoxRole.NoSelectionDropdownText = "";
            cuiComboBoxRole.NoSelectionText = "Role";
            cuiComboBoxRole.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiComboBoxRole.OutlineThickness = 1F;
            cuiComboBoxRole.Rounding = 8;
            cuiComboBoxRole.Size = new Size(354, 36);
            cuiComboBoxRole.TabIndex = 30;
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
            cuiButtonExit.Location = new Point(433, 23);
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
            cuiButtonExit.TabIndex = 29;
            cuiButtonExit.TextAlignment = StringAlignment.Center;
            cuiButtonExit.TextOffset = new Point(0, 0);
            cuiButtonExit.Click += cuiButtonExit_Click;
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
            cuiButtonAccept.Content = "Konfirmasi";
            cuiButtonAccept.DialogResult = DialogResult.None;
            cuiButtonAccept.Font = new Font("Archivo Black", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButtonAccept.ForeColor = Color.White;
            cuiButtonAccept.HoverBackground = Color.White;
            cuiButtonAccept.HoveredImageTint = Color.White;
            cuiButtonAccept.HoverForeColor = Color.Black;
            cuiButtonAccept.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButtonAccept.Image = null;
            cuiButtonAccept.ImageAutoCenter = true;
            cuiButtonAccept.ImageExpand = new Point(0, 0);
            cuiButtonAccept.ImageOffset = new Point(0, 0);
            cuiButtonAccept.Location = new Point(138, 343);
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
            cuiButtonAccept.TabIndex = 28;
            cuiButtonAccept.TextAlignment = StringAlignment.Center;
            cuiButtonAccept.TextOffset = new Point(0, 0);
            cuiButtonAccept.Click += cuiButtonAccept_Click;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Role";
            cuiLabel3.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = Color.FromArgb(4, 32, 33);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(77, 199);
            cuiLabel3.Margin = new Padding(4, 5, 4, 5);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(42, 20);
            cuiLabel3.TabIndex = 27;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiTextBoxNama
            // 
            cuiTextBoxNama.BackgroundColor = Color.FromArgb(232, 232, 232);
            cuiTextBoxNama.BorderColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBoxNama.Content = "";
            cuiTextBoxNama.FocusBackgroundColor = Color.White;
            cuiTextBoxNama.FocusBorderColor = Color.White;
            cuiTextBoxNama.FocusImageTint = Color.White;
            cuiTextBoxNama.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBoxNama.ForeColor = Color.Black;
            cuiTextBoxNama.Image = null;
            cuiTextBoxNama.ImageExpand = new Point(0, 0);
            cuiTextBoxNama.ImageOffset = new Point(0, 0);
            cuiTextBoxNama.Location = new Point(72, 159);
            cuiTextBoxNama.Margin = new Padding(4);
            cuiTextBoxNama.Multiline = false;
            cuiTextBoxNama.Name = "cuiTextBoxNama";
            cuiTextBoxNama.NormalImageTint = Color.White;
            cuiTextBoxNama.Padding = new Padding(22, 7, 22, 0);
            cuiTextBoxNama.PasswordChar = false;
            cuiTextBoxNama.PlaceholderColor = SystemColors.WindowText;
            cuiTextBoxNama.PlaceholderText = "";
            cuiTextBoxNama.Rounding = new Padding(8);
            cuiTextBoxNama.Size = new Size(354, 37);
            cuiTextBoxNama.TabIndex = 26;
            cuiTextBoxNama.TextOffset = new Size(0, 0);
            cuiTextBoxNama.UnderlinedStyle = true;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Nama\\ Lengkap";
            cuiLabel2.Font = new Font("Alike", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.FromArgb(4, 32, 33);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(59, 134);
            cuiLabel2.Margin = new Padding(4, 5, 4, 5);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(158, 21);
            cuiLabel2.TabIndex = 25;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Edit\\ Karyawan";
            cuiLabel1.Font = new Font("Archivo Black", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.FromArgb(35, 48, 8);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(134, 14);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(211, 90);
            cuiLabel1.TabIndex = 24;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // EditKaryawan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(cuiComboBoxRole);
            Controls.Add(cuiButtonExit);
            Controls.Add(cuiButtonAccept);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiTextBoxNama);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditKaryawan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditKaryawan";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private CuoreUI.Controls.cuiComboBox cuiComboBoxRole;
        private CuoreUI.Controls.cuiButton cuiButtonExit;
        private CuoreUI.Controls.cuiButton cuiButtonAccept;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiTextBox cuiTextBoxNama;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
    }
}
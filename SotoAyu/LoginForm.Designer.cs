using System.Drawing.Text;

namespace SotoAyu
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            cuiTextBoxUsername = new CuoreUI.Controls.cuiTextBox();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiTextBoxPassword = new CuoreUI.Controls.cuiTextBox();
            cuiButtonHidePw = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Alike", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 242, 226);
            label1.Location = new Point(671, 295);
            label1.Name = "label1";
            label1.Size = new Size(118, 31);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Alike", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 242, 226);
            label2.Location = new Point(671, 404);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // cuiTextBoxUsername
            // 
            cuiTextBoxUsername.AutoValidate = AutoValidate.EnablePreventFocusChange;
            cuiTextBoxUsername.BackColor = Color.Transparent;
            cuiTextBoxUsername.BackgroundColor = SystemColors.ButtonHighlight;
            cuiTextBoxUsername.BorderColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBoxUsername.Content = "";
            cuiTextBoxUsername.FocusBackgroundColor = Color.White;
            cuiTextBoxUsername.FocusBorderColor = Color.Transparent;
            cuiTextBoxUsername.FocusImageTint = Color.White;
            cuiTextBoxUsername.Font = new Font("Alike", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBoxUsername.ForeColor = Color.Black;
            cuiTextBoxUsername.Image = null;
            cuiTextBoxUsername.ImageExpand = new Point(0, 0);
            cuiTextBoxUsername.ImageOffset = new Point(0, 0);
            cuiTextBoxUsername.Location = new Point(687, 333);
            cuiTextBoxUsername.Margin = new Padding(4);
            cuiTextBoxUsername.Multiline = false;
            cuiTextBoxUsername.Name = "cuiTextBoxUsername";
            cuiTextBoxUsername.NormalImageTint = Color.White;
            cuiTextBoxUsername.Padding = new Padding(26, 13, 26, 0);
            cuiTextBoxUsername.PasswordChar = false;
            cuiTextBoxUsername.PlaceholderColor = SystemColors.InactiveCaption;
            cuiTextBoxUsername.PlaceholderText = "";
            cuiTextBoxUsername.Rounding = new Padding(30);
            cuiTextBoxUsername.Size = new Size(378, 52);
            cuiTextBoxUsername.TabIndex = 2;
            cuiTextBoxUsername.TextOffset = new Size(0, 0);
            cuiTextBoxUsername.UnderlinedStyle = true;
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
            cuiButton1.Content = "Login";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Alike", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.FromArgb(4, 32, 33);
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(774, 551);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = SystemColors.ButtonHighlight;
            cuiButton1.NormalForeColor = Color.FromArgb(4, 32, 33);
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(25);
            cuiButton1.Size = new Size(205, 55);
            cuiButton1.TabIndex = 4;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            cuiButton1.Click += cuiButton1_Click;
            // 
            // cuiTextBoxPassword
            // 
            cuiTextBoxPassword.BackColor = Color.Transparent;
            cuiTextBoxPassword.BackgroundColor = SystemColors.ButtonHighlight;
            cuiTextBoxPassword.BorderColor = Color.Transparent;
            cuiTextBoxPassword.Content = "";
            cuiTextBoxPassword.FocusBackgroundColor = Color.White;
            cuiTextBoxPassword.FocusBorderColor = Color.Transparent;
            cuiTextBoxPassword.FocusImageTint = Color.White;
            cuiTextBoxPassword.Font = new Font("Alike", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBoxPassword.ForeColor = Color.Black;
            cuiTextBoxPassword.Image = null;
            cuiTextBoxPassword.ImageExpand = new Point(0, 0);
            cuiTextBoxPassword.ImageOffset = new Point(0, 0);
            cuiTextBoxPassword.Location = new Point(687, 441);
            cuiTextBoxPassword.Margin = new Padding(4);
            cuiTextBoxPassword.Multiline = false;
            cuiTextBoxPassword.Name = "cuiTextBoxPassword";
            cuiTextBoxPassword.NormalImageTint = Color.White;
            cuiTextBoxPassword.Padding = new Padding(26, 13, 26, 0);
            cuiTextBoxPassword.PasswordChar = true;
            cuiTextBoxPassword.PlaceholderColor = SystemColors.WindowText;
            cuiTextBoxPassword.PlaceholderText = "";
            cuiTextBoxPassword.Rounding = new Padding(30);
            cuiTextBoxPassword.Size = new Size(326, 52);
            cuiTextBoxPassword.TabIndex = 5;
            cuiTextBoxPassword.TextOffset = new Size(0, 0);
            cuiTextBoxPassword.UnderlinedStyle = true;
            // 
            // cuiButtonHidePw
            // 
            cuiButtonHidePw.BackColor = Color.Transparent;
            cuiButtonHidePw.BackgroundImage = Properties.Resources.Hide;
            cuiButtonHidePw.BackgroundImageLayout = ImageLayout.Zoom;
            cuiButtonHidePw.CheckButton = false;
            cuiButtonHidePw.Checked = false;
            cuiButtonHidePw.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonHidePw.CheckedForeColor = Color.White;
            cuiButtonHidePw.CheckedImageTint = Color.White;
            cuiButtonHidePw.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonHidePw.Content = "";
            cuiButtonHidePw.DialogResult = DialogResult.None;
            cuiButtonHidePw.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonHidePw.ForeColor = Color.Transparent;
            cuiButtonHidePw.HoverBackground = Color.Transparent;
            cuiButtonHidePw.HoveredImageTint = Color.Transparent;
            cuiButtonHidePw.HoverForeColor = Color.Black;
            cuiButtonHidePw.HoverOutline = Color.Transparent;
            cuiButtonHidePw.Image = Properties.Resources.Hide;
            cuiButtonHidePw.ImageAutoCenter = true;
            cuiButtonHidePw.ImageExpand = new Point(5, 5);
            cuiButtonHidePw.ImageOffset = new Point(0, 0);
            cuiButtonHidePw.Location = new Point(1011, 455);
            cuiButtonHidePw.Name = "cuiButtonHidePw";
            cuiButtonHidePw.NormalBackground = Color.Transparent;
            cuiButtonHidePw.NormalForeColor = Color.Transparent;
            cuiButtonHidePw.NormalImageTint = Color.White;
            cuiButtonHidePw.NormalOutline = Color.Transparent;
            cuiButtonHidePw.OutlineThickness = 1F;
            cuiButtonHidePw.PressedBackground = Color.WhiteSmoke;
            cuiButtonHidePw.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButtonHidePw.PressedImageTint = Color.White;
            cuiButtonHidePw.PressedOutline = Color.DimGray;
            cuiButtonHidePw.Rounding = new Padding(8);
            cuiButtonHidePw.Size = new Size(43, 27);
            cuiButtonHidePw.TabIndex = 6;
            cuiButtonHidePw.TextAlignment = StringAlignment.Center;
            cuiButtonHidePw.TextOffset = new Point(0, 0);
            cuiButtonHidePw.Click += cuiButtonHidePw_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1222, 777);
            Controls.Add(cuiButtonHidePw);
            Controls.Add(cuiTextBoxPassword);
            Controls.Add(cuiButton1);
            Controls.Add(cuiTextBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CuoreUI.Controls.cuiTextBox cuiTextBoxUsername;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiTextBox cuiTextBoxPassword;
        private CuoreUI.Controls.cuiButton cuiButtonHidePw;
    }
}
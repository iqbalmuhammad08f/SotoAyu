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
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
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
            // cuiTextBox1
            // 
            cuiTextBox1.BackColor = Color.Transparent;
            cuiTextBox1.BackgroundColor = SystemColors.ButtonHighlight;
            cuiTextBox1.BorderColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusBorderColor = Color.Transparent;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.Font = new Font("Alike", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Black;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(687, 332);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.Padding = new Padding(26, 14, 26, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = SystemColors.InactiveCaption;
            cuiTextBox1.PlaceholderText = "";
            cuiTextBox1.Rounding = new Padding(30);
            cuiTextBox1.Size = new Size(378, 55);
            cuiTextBox1.TabIndex = 2;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = true;
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
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.BackColor = Color.Transparent;
            cuiTextBox2.BackgroundColor = SystemColors.ButtonHighlight;
            cuiTextBox2.BorderColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox2.Content = "";
            cuiTextBox2.FocusBackgroundColor = Color.White;
            cuiTextBox2.FocusBorderColor = Color.Transparent;
            cuiTextBox2.FocusImageTint = Color.White;
            cuiTextBox2.Font = new Font("Alike", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox2.ForeColor = Color.Black;
            cuiTextBox2.Image = null;
            cuiTextBox2.ImageExpand = new Point(0, 0);
            cuiTextBox2.ImageOffset = new Point(0, 0);
            cuiTextBox2.Location = new Point(687, 439);
            cuiTextBox2.Margin = new Padding(4);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.Padding = new Padding(26, 14, 26, 0);
            cuiTextBox2.PasswordChar = false;
            cuiTextBox2.PlaceholderColor = SystemColors.WindowText;
            cuiTextBox2.PlaceholderText = "";
            cuiTextBox2.Rounding = new Padding(30);
            cuiTextBox2.Size = new Size(378, 55);
            cuiTextBox2.TabIndex = 5;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1222, 777);
            Controls.Add(cuiTextBox2);
            Controls.Add(cuiButton1);
            Controls.Add(cuiTextBox1);
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
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
    }
}
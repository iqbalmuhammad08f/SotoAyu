namespace SotoAyu.view
{
    partial class UCLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLogin));
            label1 = new Label();
            label2 = new Label();
            cuiTextBoxUsername = new CuoreUI.Controls.cuiTextBox();
            cuiButtonLogin = new CuoreUI.Controls.cuiButton();
            cuiTextBoxPassword = new CuoreUI.Controls.cuiTextBox();
            buttonHidePw = new Button();
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
            // cuiButtonLogin
            // 
            cuiButtonLogin.BackColor = Color.Transparent;
            cuiButtonLogin.CheckButton = false;
            cuiButtonLogin.Checked = false;
            cuiButtonLogin.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonLogin.CheckedForeColor = Color.White;
            cuiButtonLogin.CheckedImageTint = Color.White;
            cuiButtonLogin.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonLogin.Content = "Login";
            cuiButtonLogin.DialogResult = DialogResult.None;
            cuiButtonLogin.Font = new Font("Alike", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButtonLogin.ForeColor = Color.FromArgb(4, 32, 33);
            cuiButtonLogin.HoverBackground = Color.White;
            cuiButtonLogin.HoveredImageTint = Color.White;
            cuiButtonLogin.HoverForeColor = Color.Black;
            cuiButtonLogin.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButtonLogin.Image = null;
            cuiButtonLogin.ImageAutoCenter = true;
            cuiButtonLogin.ImageExpand = new Point(0, 0);
            cuiButtonLogin.ImageOffset = new Point(0, 0);
            cuiButtonLogin.Location = new Point(774, 551);
            cuiButtonLogin.Name = "cuiButtonLogin";
            cuiButtonLogin.NormalBackground = SystemColors.ButtonHighlight;
            cuiButtonLogin.NormalForeColor = Color.FromArgb(4, 32, 33);
            cuiButtonLogin.NormalImageTint = Color.White;
            cuiButtonLogin.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonLogin.OutlineThickness = 1F;
            cuiButtonLogin.PressedBackground = Color.WhiteSmoke;
            cuiButtonLogin.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButtonLogin.PressedImageTint = Color.White;
            cuiButtonLogin.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButtonLogin.Rounding = new Padding(25);
            cuiButtonLogin.Size = new Size(205, 55);
            cuiButtonLogin.TabIndex = 4;
            cuiButtonLogin.TextAlignment = StringAlignment.Center;
            cuiButtonLogin.TextOffset = new Point(0, 0);
            cuiButtonLogin.Click += cuiButtonLogin_Click;
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
            // buttonHidePw
            // 
            buttonHidePw.BackColor = Color.Transparent;
            buttonHidePw.BackgroundImage = Properties.Resources.Hide;
            buttonHidePw.BackgroundImageLayout = ImageLayout.Center;
            buttonHidePw.FlatAppearance.BorderSize = 0;
            buttonHidePw.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonHidePw.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonHidePw.FlatStyle = FlatStyle.Flat;
            buttonHidePw.Location = new Point(1004, 448);
            buttonHidePw.Name = "buttonHidePw";
            buttonHidePw.Size = new Size(54, 43);
            buttonHidePw.TabIndex = 7;
            buttonHidePw.UseVisualStyleBackColor = false;
            buttonHidePw.Click += buttonHidePw_Click;
            // 
            // UCLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(buttonHidePw);
            Controls.Add(cuiTextBoxPassword);
            Controls.Add(cuiButtonLogin);
            Controls.Add(cuiTextBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "UCLogin";
            Size = new Size(1222, 777);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CuoreUI.Controls.cuiTextBox cuiTextBoxUsername;
        private CuoreUI.Controls.cuiButton cuiButtonLogin;
        private CuoreUI.Controls.cuiTextBox cuiTextBoxPassword;
        private Button buttonHidePw;
    }
}

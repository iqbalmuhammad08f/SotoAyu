namespace SotoAyu
{
    partial class Form1
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
            cuiComboBox1 = new CuoreUI.Controls.cuiComboBox();
            SuspendLayout();
            // 
            // cuiComboBox1
            // 
            cuiComboBox1.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuiComboBox1.ButtonCursor = Cursors.Arrow;
            cuiComboBox1.ButtonHoverBackground = Color.FromArgb(192, 255, 106, 0);
            cuiComboBox1.ButtonHoverOutline = Color.Empty;
            cuiComboBox1.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            cuiComboBox1.ButtonNormalOutline = Color.Empty;
            cuiComboBox1.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            cuiComboBox1.ButtonPressedOutline = Color.Empty;
            cuiComboBox1.DropDownBackgroundColor = Color.White;
            cuiComboBox1.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            cuiComboBox1.ExpandArrowColor = Color.Gray;
            cuiComboBox1.ForeColor = Color.Gray;
            cuiComboBox1.Location = new Point(217, 184);
            cuiComboBox1.Margin = new Padding(4, 5, 4, 5);
            cuiComboBox1.Name = "cuiComboBox1";
            cuiComboBox1.NoSelectionDropdownText = "Empty";
            cuiComboBox1.NoSelectionText = "None";
            cuiComboBox1.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiComboBox1.OutlineThickness = 1F;
            cuiComboBox1.Rounding = 8;
            cuiComboBox1.Size = new Size(509, 64);
            cuiComboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 739);
            Controls.Add(cuiComboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiComboBox cuiComboBox1;
    }
}
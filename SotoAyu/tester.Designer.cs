namespace SotoAyu
{
    partial class tester
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
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Dock = DockStyle.Fill;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(255, 106, 0);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(255, 106, 0);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(1223, 777);
            cuiPanel1.TabIndex = 0;
            // 
            // tester
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 777);
            Controls.Add(cuiPanel1);
            Name = "tester";
            Text = "tester";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
    }
}
namespace FlourSystem.Forms.User_Control
{
    partial class ucSettings
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
            cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            label1 = new Label();
            cuiBorder1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiBorder1
            // 
            cuiBorder1.Controls.Add(label1);
            cuiBorder1.Dock = DockStyle.Fill;
            cuiBorder1.Location = new Point(0, 0);
            cuiBorder1.Name = "cuiBorder1";
            cuiBorder1.OutlineThickness = 1F;
            cuiBorder1.PanelColor = Color.FromArgb(232, 237, 223);
            cuiBorder1.PanelOutlineColor = Color.FromArgb(232, 237, 223);
            cuiBorder1.Rounding = new Padding(25);
            cuiBorder1.Size = new Size(1084, 580);
            cuiBorder1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Cairo", 50F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1084, 580);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(cuiBorder1);
            Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "ucSettings";
            Size = new Size(1084, 580);
            cuiBorder1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiBorder cuiBorder1;
        private Label label1;
    }
}

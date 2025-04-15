namespace FlourSystem.Forms.User_Control
{
    partial class ucHome
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
            pnlRoundedContainer = new CuoreUI.Controls.cuiBorder();
            label1 = new Label();
            pnlRoundedContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRoundedContainer
            // 
            pnlRoundedContainer.Controls.Add(label1);
            pnlRoundedContainer.Dock = DockStyle.Fill;
            pnlRoundedContainer.Location = new Point(0, 0);
            pnlRoundedContainer.Margin = new Padding(3, 5, 3, 5);
            pnlRoundedContainer.Name = "pnlRoundedContainer";
            pnlRoundedContainer.OutlineThickness = 1F;
            pnlRoundedContainer.PanelColor = Color.FromArgb(232, 237, 223);
            pnlRoundedContainer.PanelOutlineColor = Color.FromArgb(232, 237, 223);
            pnlRoundedContainer.Rounding = new Padding(25);
            pnlRoundedContainer.Size = new Size(1084, 580);
            pnlRoundedContainer.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 50F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1084, 580);
            label1.TabIndex = 0;
            label1.Text = "Home";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucHome
            // 
            AutoScaleDimensions = new SizeF(6F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlRoundedContainer);
            Font = new Font("Cairo", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "ucHome";
            Size = new Size(1084, 580);
            pnlRoundedContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiBorder pnlRoundedContainer;
        private Label label1;
    }
}

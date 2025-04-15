namespace FlourSystem.Forms.User_Control
{
    partial class ucStatistaics
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
            lblStatistaics = new Label();
            pnlRoundedContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRoundedContainer
            // 
            pnlRoundedContainer.Controls.Add(lblStatistaics);
            pnlRoundedContainer.Dock = DockStyle.Fill;
            pnlRoundedContainer.Font = new Font("Cairo", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // lblStatistaics
            // 
            lblStatistaics.Dock = DockStyle.Fill;
            lblStatistaics.Font = new Font("Cairo", 50F);
            lblStatistaics.ForeColor = Color.Black;
            lblStatistaics.Location = new Point(0, 0);
            lblStatistaics.Name = "lblStatistaics";
            lblStatistaics.Size = new Size(1084, 580);
            lblStatistaics.TabIndex = 0;
            lblStatistaics.Text = "Statistaics";
            lblStatistaics.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucStatistaics
            // 
            AutoScaleDimensions = new SizeF(6F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlRoundedContainer);
            Font = new Font("Cairo", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "ucStatistaics";
            Size = new Size(1084, 580);
            pnlRoundedContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiBorder pnlRoundedContainer;
        private Label lblStatistaics;
    }
}

namespace FlourSystem.Forms
{
    partial class frmDashboard
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
            frmBorder = new CuoreUI.Components.cuiFormRounder();
            SuspendLayout();
            // 
            // frmBorder
            // 
            frmBorder.EnhanceCorners = false;
            frmBorder.OutlineColor = Color.FromArgb(71, 137, 75);
            frmBorder.Rounding = 5;
            frmBorder.TargetForm = this;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(5F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 675);
            Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 4, 2, 4);
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDashboard";
            Load += frmDashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Components.cuiFormRounder frmBorder;
    }
}
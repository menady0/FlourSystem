namespace FlourSystem.Forms.ToastMessage
{
    partial class Toast
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
            components = new System.ComponentModel.Container();
            lblMessage = new Label();
            slideTimer = new System.Windows.Forms.Timer(components);
            progressTimer = new System.Windows.Forms.Timer(components);
            icon = new FontAwesome.Sharp.IconPictureBox();
            cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            pnlIconContainer = new Panel();
            pnlProgress = new Panel();
            btnYes = new FlourSystem.Classes.Controls.roundedButton();
            btnNo = new FlourSystem.Classes.Controls.roundedButton();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            pnlIconContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMessage.Location = new Point(12, 8);
            lblMessage.Name = "lblMessage";
            lblMessage.RightToLeft = RightToLeft.Yes;
            lblMessage.Size = new Size(244, 42);
            lblMessage.TabIndex = 7;
            lblMessage.Text = "هنا تكتب الرسالة";
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // slideTimer
            // 
            slideTimer.Interval = 10;
            // 
            // progressTimer
            // 
            progressTimer.Interval = 16;
            progressTimer.Tick += progressTimer_Tick;
            // 
            // icon
            // 
            icon.BackColor = Color.Transparent;
            icon.ForeColor = Color.FromArgb(0, 204, 104);
            icon.IconChar = FontAwesome.Sharp.IconChar.FaceSmile;
            icon.IconColor = Color.FromArgb(0, 204, 104);
            icon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon.IconSize = 40;
            icon.Location = new Point(5, 5);
            icon.Name = "icon";
            icon.Size = new Size(40, 40);
            icon.SizeMode = PictureBoxSizeMode.CenterImage;
            icon.TabIndex = 5;
            icon.TabStop = false;
            // 
            // cuiSeparator1
            // 
            cuiSeparator1.Dock = DockStyle.Left;
            cuiSeparator1.ForeColor = Color.FromArgb(128, 128, 128, 128);
            cuiSeparator1.Location = new Point(0, 0);
            cuiSeparator1.Margin = new Padding(0);
            cuiSeparator1.Name = "cuiSeparator1";
            cuiSeparator1.SeparatorMargin = 8;
            cuiSeparator1.Size = new Size(1, 50);
            cuiSeparator1.TabIndex = 6;
            cuiSeparator1.Thickness = 1F;
            cuiSeparator1.Vertical = true;
            // 
            // pnlIconContainer
            // 
            pnlIconContainer.BackColor = Color.Transparent;
            pnlIconContainer.Controls.Add(cuiSeparator1);
            pnlIconContainer.Controls.Add(icon);
            pnlIconContainer.Location = new Point(265, 5);
            pnlIconContainer.Margin = new Padding(0);
            pnlIconContainer.Name = "pnlIconContainer";
            pnlIconContainer.Size = new Size(50, 50);
            pnlIconContainer.TabIndex = 6;
            // 
            // pnlProgress
            // 
            pnlProgress.BackColor = Color.FromArgb(0, 204, 104);
            pnlProgress.Location = new Point(0, 58);
            pnlProgress.Name = "pnlProgress";
            pnlProgress.Size = new Size(320, 2);
            pnlProgress.TabIndex = 8;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(71, 137, 75);
            btnYes.BackgroundColor = Color.FromArgb(71, 137, 75);
            btnYes.BorderColor = Color.Transparent;
            btnYes.BorderRadius = 5;
            btnYes.BorderSize = 0;
            btnYes.Cursor = Cursors.Hand;
            btnYes.FlatAppearance.BorderSize = 0;
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btnYes.ForeColor = Color.White;
            btnYes.Location = new Point(160, 60);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(160, 40);
            btnYes.TabIndex = 9;
            btnYes.Text = "نعم";
            btnYes.TextColor = Color.White;
            btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.Gray;
            btnNo.BackgroundColor = Color.Gray;
            btnNo.BorderColor = Color.Transparent;
            btnNo.BorderRadius = 5;
            btnNo.BorderSize = 0;
            btnNo.Cursor = Cursors.Hand;
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btnNo.ForeColor = Color.White;
            btnNo.Location = new Point(0, 60);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(160, 40);
            btnNo.TabIndex = 10;
            btnNo.Text = "لا";
            btnNo.TextColor = Color.White;
            btnNo.UseVisualStyleBackColor = false;
            // 
            // Toast
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnNo;
            ClientSize = new Size(320, 100);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(pnlProgress);
            Controls.Add(lblMessage);
            Controls.Add(pnlIconContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Toast";
            Opacity = 0D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            TopMost = true;
            Load += ToastMessage_Load;
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            pnlIconContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblMessage;
        private System.Windows.Forms.Timer slideTimer;
        private Panel pnlIconContainer;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private FontAwesome.Sharp.IconPictureBox icon;
        private Panel pnlProgress;
        private Classes.Controls.roundedButton btnYes;
        private Classes.Controls.roundedButton btnNo;
        private System.Windows.Forms.Timer progressTimer;
    }
}
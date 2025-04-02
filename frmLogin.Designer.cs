namespace FlourSystem
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pnlBar = new Panel();
            btnDarkMode = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            btnLogin = new FlourSystem.Classes.Controls.roundedButton();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlBar
            // 
            pnlBar.Controls.Add(btnDarkMode);
            pnlBar.Controls.Add(btnClose);
            pnlBar.Dock = DockStyle.Top;
            pnlBar.Location = new Point(0, 0);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(1000, 30);
            pnlBar.TabIndex = 0;
            // 
            // btnDarkMode
            // 
            btnDarkMode.BackColor = Color.FromArgb(15, 0, 0, 0);
            btnDarkMode.Cursor = Cursors.Hand;
            btnDarkMode.Dock = DockStyle.Left;
            btnDarkMode.FlatAppearance.BorderSize = 0;
            btnDarkMode.FlatStyle = FlatStyle.Flat;
            btnDarkMode.ForeColor = Color.FromArgb(232, 237, 223);
            btnDarkMode.IconChar = FontAwesome.Sharp.IconChar.Moon;
            btnDarkMode.IconColor = Color.FromArgb(232, 237, 223);
            btnDarkMode.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnDarkMode.IconSize = 16;
            btnDarkMode.Location = new Point(0, 0);
            btnDarkMode.Name = "btnDarkMode";
            btnDarkMode.Size = new Size(40, 30);
            btnDarkMode.TabIndex = 2;
            btnDarkMode.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.FromArgb(36, 35, 35);
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnClose.IconColor = Color.FromArgb(36, 35, 35);
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 16;
            btnClose.Location = new Point(940, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(60, 30);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo Black", 33F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(36, 36, 35);
            label1.Location = new Point(630, 116);
            label1.Name = "label1";
            label1.Size = new Size(331, 82);
            label1.TabIndex = 1;
            label1.Text = "!مرحباً بعودتك";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.input;
            pictureBox1.Location = new Point(644, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(207, 219, 213);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.ForeColor = Color.FromArgb(136, 136, 135);
            txtUsername.Location = new Point(652, 255);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "أسم المستخدم";
            txtUsername.Size = new Size(241, 23);
            txtUsername.TabIndex = 3;
            txtUsername.TextAlign = HorizontalAlignment.Right;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(207, 219, 213);
            iconPictureBox1.ForeColor = Color.FromArgb(36, 36, 35);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            iconPictureBox1.IconColor = Color.FromArgb(36, 36, 35);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 18;
            iconPictureBox1.Location = new Point(909, 258);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(18, 18);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(207, 219, 213);
            iconPictureBox2.ForeColor = Color.FromArgb(36, 36, 35);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.FromArgb(36, 36, 35);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 18;
            iconPictureBox2.Location = new Point(909, 318);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(18, 18);
            iconPictureBox2.TabIndex = 7;
            iconPictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(207, 219, 213);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.ForeColor = Color.FromArgb(136, 136, 135);
            txtPassword.Location = new Point(652, 315);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "كلمة المرور";
            txtPassword.Size = new Size(241, 23);
            txtPassword.TabIndex = 6;
            txtPassword.TextAlign = HorizontalAlignment.Right;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.input;
            pictureBox2.Location = new Point(644, 301);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(36, 36, 35);
            btnLogin.BackgroundColor = Color.FromArgb(36, 36, 35);
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 5;
            btnLogin.BorderSize = 0;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Cairo", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLogin.ForeColor = Color.FromArgb(232, 237, 223);
            btnLogin.Location = new Point(644, 391);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 50);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "تسجيل الدخول";
            btnLogin.TextColor = Color.FromArgb(232, 237, 223);
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(5F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 237, 223);
            BackgroundImage = Properties.Resources.cpyShapes;
            ClientSize = new Size(1000, 600);
            Controls.Add(btnLogin);
            Controls.Add(iconPictureBox2);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pnlBar);
            Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            ForeColor = Color.FromArgb(136, 136, 135);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            pnlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnDarkMode;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TextBox txtPassword;
        private PictureBox pictureBox2;
        private Classes.Controls.roundedButton btnLogin;
    }
}

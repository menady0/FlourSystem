namespace FlourSystem.Forms.User_Control.ucHomeBtns
{
    partial class frmAddOwner
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
            btnAdd = new FlourSystem.Classes.Controls.roundedButton();
            panel1 = new Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            opacityTimer = new System.Windows.Forms.Timer(components);
            frmAnimation = new CuoreUI.Components.cuiFormAnimator(components);
            frmDrag = new CuoreUI.cuiFormDrag(components);
            frmBorder = new CuoreUI.Components.cuiFormRounder();
            picConfirmPassword = new FontAwesome.Sharp.IconPictureBox();
            txtConfirmPassword = new CuoreUI.Controls.cuiTextBox2();
            picPassword = new FontAwesome.Sharp.IconPictureBox();
            txtPassword = new CuoreUI.Controls.cuiTextBox2();
            picUsername = new FontAwesome.Sharp.IconPictureBox();
            txtUsername = new CuoreUI.Controls.cuiTextBox2();
            picShowPassword = new FontAwesome.Sharp.IconPictureBox();
            picShowConfirmPassword = new FontAwesome.Sharp.IconPictureBox();
            picName = new FontAwesome.Sharp.IconPictureBox();
            txtName = new CuoreUI.Controls.cuiTextBox2();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShowConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picName).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(71, 137, 75);
            btnAdd.BackgroundColor = Color.FromArgb(71, 137, 75);
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 5;
            btnAdd.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Cairo", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(8, 354);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(280, 40);
            btnAdd.TabIndex = 15;
            btnAdd.TabStop = false;
            btnAdd.Text = "إضافة";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 0, 0, 0);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 30);
            panel1.TabIndex = 14;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnClose.IconColor = Color.FromArgb(36, 36, 35);
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnClose.IconSize = 20;
            btnClose.Location = new Point(246, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(54, 30);
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // opacityTimer
            // 
            opacityTimer.Interval = 50;
            opacityTimer.Tick += opacityTimer_Tick;
            // 
            // frmAnimation
            // 
            frmAnimation.AnimateOnStart = true;
            frmAnimation.Duration = 400;
            frmAnimation.EasingType = CuoreUI.Drawing.EasingTypes.QuadOut;
            frmAnimation.StartOpacity = 0D;
            frmAnimation.TargetForm = this;
            frmAnimation.TargetOpacity = 1D;
            // 
            // frmDrag
            // 
            frmDrag.TargetForm = this;
            // 
            // frmBorder
            // 
            frmBorder.EnhanceCorners = true;
            frmBorder.OutlineColor = Color.FromArgb(71, 137, 75);
            frmBorder.Rounding = 10;
            frmBorder.TargetForm = this;
            // 
            // picConfirmPassword
            // 
            picConfirmPassword.BackColor = Color.FromArgb(207, 219, 213);
            picConfirmPassword.ForeColor = Color.FromArgb(36, 36, 35);
            picConfirmPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            picConfirmPassword.IconColor = Color.FromArgb(36, 36, 35);
            picConfirmPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picConfirmPassword.IconSize = 22;
            picConfirmPassword.Location = new Point(260, 249);
            picConfirmPassword.Name = "picConfirmPassword";
            picConfirmPassword.Size = new Size(22, 22);
            picConfirmPassword.SizeMode = PictureBoxSizeMode.CenterImage;
            picConfirmPassword.TabIndex = 21;
            picConfirmPassword.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(207, 219, 213);
            txtConfirmPassword.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtConfirmPassword.BorderColor = Color.FromArgb(244, 245, 244);
            txtConfirmPassword.BorderSize = 1;
            txtConfirmPassword.Content = "";
            txtConfirmPassword.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtConfirmPassword.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtConfirmPassword.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.Black;
            txtConfirmPassword.Location = new Point(10, 240);
            txtConfirmPassword.Margin = new Padding(4);
            txtConfirmPassword.Multiline = false;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Padding = new Padding(40, 8, 40, 0);
            txtConfirmPassword.PasswordChar = true;
            txtConfirmPassword.PlaceholderColor = Color.Gray;
            txtConfirmPassword.PlaceholderText = "تأكيد كلمة المرور";
            txtConfirmPassword.RightToLeft = RightToLeft.Yes;
            txtConfirmPassword.Rounding = new Padding(5);
            txtConfirmPassword.Size = new Size(280, 40);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.TextOffset = new Size(15, 0);
            txtConfirmPassword.UnderlinedStyle = false;
            txtConfirmPassword.ContentChanged += txtConfirmPassword_ContentChanged;
            // 
            // picPassword
            // 
            picPassword.BackColor = Color.FromArgb(207, 219, 213);
            picPassword.ForeColor = Color.FromArgb(36, 36, 35);
            picPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            picPassword.IconColor = Color.FromArgb(36, 36, 35);
            picPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picPassword.IconSize = 22;
            picPassword.Location = new Point(260, 209);
            picPassword.Name = "picPassword";
            picPassword.Size = new Size(22, 22);
            picPassword.SizeMode = PictureBoxSizeMode.CenterImage;
            picPassword.TabIndex = 20;
            picPassword.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(207, 219, 213);
            txtPassword.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtPassword.BorderColor = Color.FromArgb(244, 245, 244);
            txtPassword.BorderSize = 1;
            txtPassword.Content = "";
            txtPassword.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtPassword.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtPassword.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(10, 200);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(40, 8, 40, 0);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.Gray;
            txtPassword.PlaceholderText = "كلمة المرور";
            txtPassword.RightToLeft = RightToLeft.Yes;
            txtPassword.Rounding = new Padding(5);
            txtPassword.Size = new Size(280, 40);
            txtPassword.TabIndex = 2;
            txtPassword.TextOffset = new Size(15, 0);
            txtPassword.UnderlinedStyle = false;
            txtPassword.ContentChanged += txtPassword_ContentChanged;
            // 
            // picUsername
            // 
            picUsername.BackColor = Color.FromArgb(207, 219, 213);
            picUsername.ForeColor = Color.FromArgb(36, 36, 35);
            picUsername.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            picUsername.IconColor = Color.FromArgb(36, 36, 35);
            picUsername.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picUsername.IconSize = 22;
            picUsername.Location = new Point(258, 169);
            picUsername.Name = "picUsername";
            picUsername.Size = new Size(22, 22);
            picUsername.SizeMode = PictureBoxSizeMode.CenterImage;
            picUsername.TabIndex = 19;
            picUsername.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(207, 219, 213);
            txtUsername.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtUsername.BorderColor = Color.FromArgb(244, 245, 244);
            txtUsername.BorderSize = 1;
            txtUsername.Content = "";
            txtUsername.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtUsername.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtUsername.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(10, 160);
            txtUsername.Margin = new Padding(4);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(40, 8, 40, 0);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.Gray;
            txtUsername.PlaceholderText = "اسم المستخدم";
            txtUsername.RightToLeft = RightToLeft.Yes;
            txtUsername.Rounding = new Padding(5);
            txtUsername.Size = new Size(280, 40);
            txtUsername.TabIndex = 1;
            txtUsername.TextOffset = new Size(15, 0);
            txtUsername.UnderlinedStyle = false;
            // 
            // picShowPassword
            // 
            picShowPassword.BackColor = Color.FromArgb(207, 219, 213);
            picShowPassword.Cursor = Cursors.Hand;
            picShowPassword.ForeColor = Color.FromArgb(36, 36, 35);
            picShowPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            picShowPassword.IconColor = Color.FromArgb(36, 36, 35);
            picShowPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picShowPassword.IconSize = 22;
            picShowPassword.Location = new Point(22, 209);
            picShowPassword.Name = "picShowPassword";
            picShowPassword.Size = new Size(22, 22);
            picShowPassword.SizeMode = PictureBoxSizeMode.CenterImage;
            picShowPassword.TabIndex = 22;
            picShowPassword.TabStop = false;
            picShowPassword.Visible = false;
            picShowPassword.Click += picShowPassword_Click;
            // 
            // picShowConfirmPassword
            // 
            picShowConfirmPassword.BackColor = Color.FromArgb(207, 219, 213);
            picShowConfirmPassword.Cursor = Cursors.Hand;
            picShowConfirmPassword.ForeColor = Color.FromArgb(36, 36, 35);
            picShowConfirmPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            picShowConfirmPassword.IconColor = Color.FromArgb(36, 36, 35);
            picShowConfirmPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picShowConfirmPassword.IconSize = 22;
            picShowConfirmPassword.Location = new Point(22, 249);
            picShowConfirmPassword.Name = "picShowConfirmPassword";
            picShowConfirmPassword.Size = new Size(22, 22);
            picShowConfirmPassword.SizeMode = PictureBoxSizeMode.CenterImage;
            picShowConfirmPassword.TabIndex = 23;
            picShowConfirmPassword.TabStop = false;
            picShowConfirmPassword.Visible = false;
            picShowConfirmPassword.Click += picShowConfirmPassword_Click;
            // 
            // picName
            // 
            picName.BackColor = Color.FromArgb(207, 219, 213);
            picName.ForeColor = Color.FromArgb(36, 36, 35);
            picName.IconChar = FontAwesome.Sharp.IconChar.User;
            picName.IconColor = Color.FromArgb(36, 36, 35);
            picName.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picName.IconSize = 22;
            picName.Location = new Point(257, 129);
            picName.Name = "picName";
            picName.Size = new Size(22, 22);
            picName.SizeMode = PictureBoxSizeMode.CenterImage;
            picName.TabIndex = 25;
            picName.TabStop = false;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(207, 219, 213);
            txtName.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtName.BorderColor = Color.FromArgb(244, 245, 244);
            txtName.BorderSize = 1;
            txtName.Content = "";
            txtName.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtName.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtName.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(10, 120);
            txtName.Margin = new Padding(4);
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(40, 8, 40, 0);
            txtName.PasswordChar = false;
            txtName.PlaceholderColor = Color.Gray;
            txtName.PlaceholderText = "الاسم";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Rounding = new Padding(5);
            txtName.Size = new Size(280, 40);
            txtName.TabIndex = 0;
            txtName.TextOffset = new Size(15, 0);
            txtName.UnderlinedStyle = false;
            // 
            // frmAddOwner
            // 
            AutoScaleDimensions = new SizeF(6F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 237, 223);
            ClientSize = new Size(300, 400);
            Controls.Add(picName);
            Controls.Add(txtName);
            Controls.Add(picShowConfirmPassword);
            Controls.Add(picShowPassword);
            Controls.Add(picConfirmPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(picPassword);
            Controls.Add(txtPassword);
            Controls.Add(picUsername);
            Controls.Add(txtUsername);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Font = new Font("Cairo", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmAddOwner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Owner";
            TopMost = true;
            FormClosing += frmAddCustomer_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShowConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picName).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Classes.Controls.roundedButton btnAdd;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Timer opacityTimer;
        private CuoreUI.Components.cuiFormAnimator frmAnimation;
        private CuoreUI.cuiFormDrag frmDrag;
        private CuoreUI.Components.cuiFormRounder frmBorder;
        private FontAwesome.Sharp.IconPictureBox picConfirmPassword;
        private CuoreUI.Controls.cuiTextBox2 txtConfirmPassword;
        private FontAwesome.Sharp.IconPictureBox picPassword;
        private CuoreUI.Controls.cuiTextBox2 txtPassword;
        private FontAwesome.Sharp.IconPictureBox picUsername;
        private CuoreUI.Controls.cuiTextBox2 txtUsername;
        private FontAwesome.Sharp.IconPictureBox picName;
        private CuoreUI.Controls.cuiTextBox2 txtName;
        private FontAwesome.Sharp.IconPictureBox picShowConfirmPassword;
        private FontAwesome.Sharp.IconPictureBox picShowPassword;
    }
}
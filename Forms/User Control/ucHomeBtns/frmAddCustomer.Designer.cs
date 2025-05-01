namespace FlourSystem.Forms.User_Control.ucHomeBtns
{
    partial class frmAddCustomer
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
            frmDrag = new CuoreUI.cuiFormDrag(components);
            opacityTimer = new System.Windows.Forms.Timer(components);
            btnClose = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            frmBorder = new CuoreUI.Components.cuiFormRounder();
            txtCardID = new CuoreUI.Controls.cuiTextBox2();
            picCardID = new FontAwesome.Sharp.IconPictureBox();
            picName = new FontAwesome.Sharp.IconPictureBox();
            txtName = new CuoreUI.Controls.cuiTextBox2();
            picMembers = new FontAwesome.Sharp.IconPictureBox();
            txtMembers = new CuoreUI.Controls.cuiTextBox2();
            picQuantity = new FontAwesome.Sharp.IconPictureBox();
            txtQuantity = new CuoreUI.Controls.cuiTextBox2();
            picPrice = new FontAwesome.Sharp.IconPictureBox();
            txtPrice = new CuoreUI.Controls.cuiTextBox2();
            btnAdd = new FlourSystem.Classes.Controls.roundedButton();
            frmAnimation = new CuoreUI.Components.cuiFormAnimator(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCardID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPrice).BeginInit();
            SuspendLayout();
            // 
            // frmDrag
            // 
            frmDrag.TargetForm = this;
            // 
            // opacityTimer
            // 
            opacityTimer.Interval = 50;
            opacityTimer.Tick += opacityTimer_Tick;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 0, 0, 0);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 30);
            panel1.TabIndex = 2;
            // 
            // frmBorder
            // 
            frmBorder.EnhanceCorners = false;
            frmBorder.OutlineColor = Color.FromArgb(71, 137, 75);
            frmBorder.Rounding = 10;
            frmBorder.TargetForm = this;
            // 
            // txtCardID
            // 
            txtCardID.BackColor = Color.FromArgb(207, 219, 213);
            txtCardID.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtCardID.BorderColor = Color.FromArgb(244, 245, 244);
            txtCardID.BorderSize = 1;
            txtCardID.Content = "";
            txtCardID.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtCardID.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtCardID.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCardID.ForeColor = Color.Black;
            txtCardID.Location = new Point(8, 85);
            txtCardID.Margin = new Padding(4);
            txtCardID.Multiline = false;
            txtCardID.Name = "txtCardID";
            txtCardID.Padding = new Padding(40, 8, 40, 0);
            txtCardID.PasswordChar = false;
            txtCardID.PlaceholderColor = Color.Gray;
            txtCardID.PlaceholderText = "رقم البطاقة";
            txtCardID.RightToLeft = RightToLeft.Yes;
            txtCardID.Rounding = new Padding(5);
            txtCardID.Size = new Size(280, 40);
            txtCardID.TabIndex = 0;
            txtCardID.TextOffset = new Size(15, 0);
            txtCardID.UnderlinedStyle = false;
            // 
            // picCardID
            // 
            picCardID.BackColor = Color.FromArgb(207, 219, 213);
            picCardID.ForeColor = Color.FromArgb(36, 36, 35);
            picCardID.IconChar = FontAwesome.Sharp.IconChar.DriversLicense;
            picCardID.IconColor = Color.FromArgb(36, 36, 35);
            picCardID.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picCardID.IconSize = 22;
            picCardID.Location = new Point(259, 94);
            picCardID.Name = "picCardID";
            picCardID.Size = new Size(22, 22);
            picCardID.SizeMode = PictureBoxSizeMode.CenterImage;
            picCardID.TabIndex = 4;
            picCardID.TabStop = false;
            // 
            // picName
            // 
            picName.BackColor = Color.FromArgb(207, 219, 213);
            picName.ForeColor = Color.FromArgb(36, 36, 35);
            picName.IconChar = FontAwesome.Sharp.IconChar.User;
            picName.IconColor = Color.FromArgb(36, 36, 35);
            picName.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picName.IconSize = 22;
            picName.Location = new Point(257, 139);
            picName.Name = "picName";
            picName.Size = new Size(22, 22);
            picName.SizeMode = PictureBoxSizeMode.CenterImage;
            picName.TabIndex = 6;
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
            txtName.Location = new Point(8, 130);
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
            txtName.TabIndex = 1;
            txtName.TextOffset = new Size(15, 0);
            txtName.UnderlinedStyle = false;
            // 
            // picMembers
            // 
            picMembers.BackColor = Color.FromArgb(207, 219, 213);
            picMembers.ForeColor = Color.FromArgb(36, 36, 35);
            picMembers.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            picMembers.IconColor = Color.FromArgb(36, 36, 35);
            picMembers.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picMembers.IconSize = 22;
            picMembers.Location = new Point(259, 184);
            picMembers.Name = "picMembers";
            picMembers.Size = new Size(22, 22);
            picMembers.SizeMode = PictureBoxSizeMode.CenterImage;
            picMembers.TabIndex = 8;
            picMembers.TabStop = false;
            // 
            // txtMembers
            // 
            txtMembers.BackColor = Color.FromArgb(207, 219, 213);
            txtMembers.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtMembers.BorderColor = Color.FromArgb(244, 245, 244);
            txtMembers.BorderSize = 1;
            txtMembers.Content = "";
            txtMembers.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtMembers.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtMembers.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMembers.ForeColor = Color.Black;
            txtMembers.Location = new Point(10, 175);
            txtMembers.Margin = new Padding(4);
            txtMembers.Multiline = false;
            txtMembers.Name = "txtMembers";
            txtMembers.Padding = new Padding(40, 8, 40, 0);
            txtMembers.PasswordChar = false;
            txtMembers.PlaceholderColor = Color.Gray;
            txtMembers.PlaceholderText = "عدد الافراد";
            txtMembers.RightToLeft = RightToLeft.Yes;
            txtMembers.Rounding = new Padding(5);
            txtMembers.Size = new Size(280, 40);
            txtMembers.TabIndex = 2;
            txtMembers.TextOffset = new Size(15, 0);
            txtMembers.UnderlinedStyle = false;
            txtMembers.ContentChanged += txtMembers_ContentChanged;
            // 
            // picQuantity
            // 
            picQuantity.BackColor = Color.FromArgb(207, 219, 213);
            picQuantity.ForeColor = Color.FromArgb(36, 36, 35);
            picQuantity.IconChar = FontAwesome.Sharp.IconChar.SackXmark;
            picQuantity.IconColor = Color.FromArgb(36, 36, 35);
            picQuantity.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picQuantity.IconSize = 22;
            picQuantity.Location = new Point(259, 229);
            picQuantity.Name = "picQuantity";
            picQuantity.Size = new Size(22, 22);
            picQuantity.SizeMode = PictureBoxSizeMode.CenterImage;
            picQuantity.TabIndex = 10;
            picQuantity.TabStop = false;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(207, 219, 213);
            txtQuantity.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtQuantity.BorderColor = Color.FromArgb(244, 245, 244);
            txtQuantity.BorderSize = 1;
            txtQuantity.Content = "";
            txtQuantity.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtQuantity.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtQuantity.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.ForeColor = Color.Black;
            txtQuantity.Location = new Point(10, 220);
            txtQuantity.Margin = new Padding(4);
            txtQuantity.Multiline = false;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Padding = new Padding(40, 8, 40, 0);
            txtQuantity.PasswordChar = false;
            txtQuantity.PlaceholderColor = Color.Gray;
            txtQuantity.PlaceholderText = "الكمية بالكيلو";
            txtQuantity.RightToLeft = RightToLeft.Yes;
            txtQuantity.Rounding = new Padding(5);
            txtQuantity.Size = new Size(280, 40);
            txtQuantity.TabIndex = 3;
            txtQuantity.TextOffset = new Size(15, 0);
            txtQuantity.UnderlinedStyle = false;
            // 
            // picPrice
            // 
            picPrice.BackColor = Color.FromArgb(207, 219, 213);
            picPrice.ForeColor = Color.FromArgb(36, 36, 35);
            picPrice.IconChar = FontAwesome.Sharp.IconChar.Usd;
            picPrice.IconColor = Color.FromArgb(36, 36, 35);
            picPrice.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picPrice.IconSize = 22;
            picPrice.Location = new Point(257, 274);
            picPrice.Name = "picPrice";
            picPrice.Size = new Size(22, 22);
            picPrice.SizeMode = PictureBoxSizeMode.CenterImage;
            picPrice.TabIndex = 12;
            picPrice.TabStop = false;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(207, 219, 213);
            txtPrice.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtPrice.BorderColor = Color.FromArgb(244, 245, 244);
            txtPrice.BorderSize = 1;
            txtPrice.Content = "";
            txtPrice.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtPrice.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtPrice.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.ForeColor = Color.Black;
            txtPrice.Location = new Point(8, 265);
            txtPrice.Margin = new Padding(4);
            txtPrice.Multiline = false;
            txtPrice.Name = "txtPrice";
            txtPrice.Padding = new Padding(40, 8, 40, 0);
            txtPrice.PasswordChar = false;
            txtPrice.PlaceholderColor = Color.Gray;
            txtPrice.PlaceholderText = "السعر";
            txtPrice.RightToLeft = RightToLeft.Yes;
            txtPrice.Rounding = new Padding(5);
            txtPrice.Size = new Size(280, 40);
            txtPrice.TabIndex = 4;
            txtPrice.TextOffset = new Size(15, 0);
            txtPrice.UnderlinedStyle = false;
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
            btnAdd.Location = new Point(8, 348);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(280, 40);
            btnAdd.TabIndex = 13;
            btnAdd.TabStop = false;
            btnAdd.Text = "إضافة";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            // frmAddCustomer
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(5F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 237, 223);
            CancelButton = btnClose;
            ClientSize = new Size(300, 400);
            Controls.Add(btnAdd);
            Controls.Add(picPrice);
            Controls.Add(txtPrice);
            Controls.Add(picQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(picMembers);
            Controls.Add(txtMembers);
            Controls.Add(picName);
            Controls.Add(txtName);
            Controls.Add(picCardID);
            Controls.Add(txtCardID);
            Controls.Add(panel1);
            Font = new Font("Cairo", 8.999999F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 4, 2, 4);
            MaximumSize = new Size(300, 400);
            MinimumSize = new Size(300, 0);
            Name = "frmAddCustomer";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Customer";
            TopMost = true;
            FormClosing += frmAddCustomer_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCardID).EndInit();
            ((System.ComponentModel.ISupportInitialize)picName).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.cuiFormDrag frmDrag;
        private System.Windows.Forms.Timer opacityTimer;
        private FontAwesome.Sharp.IconButton btnClose;
        private Panel panel1;
        private CuoreUI.Components.cuiFormRounder frmBorder;
        private FontAwesome.Sharp.IconPictureBox picCardID;
        private FontAwesome.Sharp.IconPictureBox picName;
        private FontAwesome.Sharp.IconPictureBox picMembers;
        private FontAwesome.Sharp.IconPictureBox picPrice;
        private FontAwesome.Sharp.IconPictureBox picQuantity;
        private CuoreUI.Components.cuiFormAnimator frmAnimation;
        public CuoreUI.Controls.cuiTextBox2 txtCardID;
        public CuoreUI.Controls.cuiTextBox2 txtName;
        public CuoreUI.Controls.cuiTextBox2 txtMembers;
        public CuoreUI.Controls.cuiTextBox2 txtPrice;
        public CuoreUI.Controls.cuiTextBox2 txtQuantity;
        internal Classes.Controls.roundedButton btnAdd;
    }
}
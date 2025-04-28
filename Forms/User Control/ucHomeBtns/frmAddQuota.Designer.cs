namespace FlourSystem.Forms.User_Control.ucHomeBtns
{
    partial class frmAddQuota
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
            frmAnimation = new CuoreUI.Components.cuiFormAnimator(components);
            frmDrag = new CuoreUI.cuiFormDrag(components);
            frmBorder = new CuoreUI.Components.cuiFormRounder();
            opacityTimer = new System.Windows.Forms.Timer(components);
            picPrice = new FontAwesome.Sharp.IconPictureBox();
            txtPrice = new CuoreUI.Controls.cuiTextBox2();
            picAmountPerKG = new FontAwesome.Sharp.IconPictureBox();
            txtAmountPerKG = new CuoreUI.Controls.cuiTextBox2();
            picAmount = new FontAwesome.Sharp.IconPictureBox();
            txtAmount = new CuoreUI.Controls.cuiTextBox2();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAmountPerKG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAmount).BeginInit();
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
            btnAdd.Click += btnAdd_Click;
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
            // opacityTimer
            // 
            opacityTimer.Interval = 50;
            opacityTimer.Tick += opacityTimer_Tick;
            // 
            // picPrice
            // 
            picPrice.BackColor = Color.FromArgb(207, 219, 213);
            picPrice.ForeColor = Color.FromArgb(36, 36, 35);
            picPrice.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1;
            picPrice.IconColor = Color.FromArgb(36, 36, 35);
            picPrice.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picPrice.IconSize = 22;
            picPrice.Location = new Point(260, 227);
            picPrice.Name = "picPrice";
            picPrice.Size = new Size(22, 22);
            picPrice.SizeMode = PictureBoxSizeMode.CenterImage;
            picPrice.TabIndex = 21;
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
            txtPrice.Location = new Point(9, 218);
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
            txtPrice.TabIndex = 18;
            txtPrice.TextOffset = new Size(15, 0);
            txtPrice.UnderlinedStyle = false;
            // 
            // picAmountPerKG
            // 
            picAmountPerKG.BackColor = Color.FromArgb(207, 219, 213);
            picAmountPerKG.ForeColor = Color.FromArgb(36, 36, 35);
            picAmountPerKG.IconChar = FontAwesome.Sharp.IconChar.SackXmark;
            picAmountPerKG.IconColor = Color.FromArgb(36, 36, 35);
            picAmountPerKG.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picAmountPerKG.IconSize = 22;
            picAmountPerKG.Location = new Point(262, 187);
            picAmountPerKG.Name = "picAmountPerKG";
            picAmountPerKG.Size = new Size(22, 22);
            picAmountPerKG.SizeMode = PictureBoxSizeMode.CenterImage;
            picAmountPerKG.TabIndex = 20;
            picAmountPerKG.TabStop = false;
            // 
            // txtAmountPerKG
            // 
            txtAmountPerKG.BackColor = Color.FromArgb(207, 219, 213);
            txtAmountPerKG.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtAmountPerKG.BorderColor = Color.FromArgb(244, 245, 244);
            txtAmountPerKG.BorderSize = 1;
            txtAmountPerKG.Content = "";
            txtAmountPerKG.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtAmountPerKG.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtAmountPerKG.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmountPerKG.ForeColor = Color.Black;
            txtAmountPerKG.Location = new Point(11, 178);
            txtAmountPerKG.Margin = new Padding(4);
            txtAmountPerKG.Multiline = false;
            txtAmountPerKG.Name = "txtAmountPerKG";
            txtAmountPerKG.Padding = new Padding(40, 8, 40, 0);
            txtAmountPerKG.PasswordChar = false;
            txtAmountPerKG.PlaceholderColor = Color.Gray;
            txtAmountPerKG.PlaceholderText = "الكمية بالكيلو";
            txtAmountPerKG.RightToLeft = RightToLeft.Yes;
            txtAmountPerKG.Rounding = new Padding(5);
            txtAmountPerKG.Size = new Size(280, 40);
            txtAmountPerKG.TabIndex = 17;
            txtAmountPerKG.TextOffset = new Size(15, 0);
            txtAmountPerKG.UnderlinedStyle = false;
            // 
            // picAmount
            // 
            picAmount.BackColor = Color.FromArgb(207, 219, 213);
            picAmount.ForeColor = Color.FromArgb(36, 36, 35);
            picAmount.IconChar = FontAwesome.Sharp.IconChar.DollyBox;
            picAmount.IconColor = Color.FromArgb(36, 36, 35);
            picAmount.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picAmount.IconSize = 22;
            picAmount.Location = new Point(262, 147);
            picAmount.Name = "picAmount";
            picAmount.Size = new Size(22, 22);
            picAmount.SizeMode = PictureBoxSizeMode.CenterImage;
            picAmount.TabIndex = 19;
            picAmount.TabStop = false;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.FromArgb(207, 219, 213);
            txtAmount.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtAmount.BorderColor = Color.FromArgb(244, 245, 244);
            txtAmount.BorderSize = 1;
            txtAmount.Content = "";
            txtAmount.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtAmount.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtAmount.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.ForeColor = Color.Black;
            txtAmount.Location = new Point(11, 138);
            txtAmount.Margin = new Padding(4);
            txtAmount.Multiline = false;
            txtAmount.Name = "txtAmount";
            txtAmount.Padding = new Padding(40, 8, 40, 0);
            txtAmount.PasswordChar = false;
            txtAmount.PlaceholderColor = Color.Gray;
            txtAmount.PlaceholderText = "الكمية";
            txtAmount.RightToLeft = RightToLeft.Yes;
            txtAmount.Rounding = new Padding(5);
            txtAmount.Size = new Size(280, 40);
            txtAmount.TabIndex = 16;
            txtAmount.TextOffset = new Size(15, 0);
            txtAmount.UnderlinedStyle = false;
            txtAmount.ContentChanged += txtAmount_ContentChanged;
            // 
            // frmAddQuota
            // 
            AutoScaleDimensions = new SizeF(6F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 237, 223);
            ClientSize = new Size(300, 400);
            Controls.Add(picPrice);
            Controls.Add(txtPrice);
            Controls.Add(picAmountPerKG);
            Controls.Add(txtAmountPerKG);
            Controls.Add(picAmount);
            Controls.Add(txtAmount);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Font = new Font("Cairo", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmAddQuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Quota";
            TopMost = true;
            FormClosing += frmAddQuota_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAmountPerKG).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Classes.Controls.roundedButton btnAdd;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnClose;
        private CuoreUI.Components.cuiFormAnimator frmAnimation;
        private CuoreUI.cuiFormDrag frmDrag;
        private CuoreUI.Components.cuiFormRounder frmBorder;
        private System.Windows.Forms.Timer opacityTimer;
        private FontAwesome.Sharp.IconPictureBox picPrice;
        private CuoreUI.Controls.cuiTextBox2 txtPrice;
        private FontAwesome.Sharp.IconPictureBox picAmountPerKG;
        private CuoreUI.Controls.cuiTextBox2 txtAmountPerKG;
        private FontAwesome.Sharp.IconPictureBox picAmount;
        private CuoreUI.Controls.cuiTextBox2 txtAmount;
    }
}
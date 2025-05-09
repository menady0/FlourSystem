using FlourSystem.Properties;

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
            components = new System.ComponentModel.Container();
            container = new CuoreUI.Controls.cuiBorder();
            pnlSave = new CuoreUI.Controls.cuiBorder();
            btnSave = new FontAwesome.Sharp.IconButton();
            separator = new Panel();
            pnlRightSide = new FlowLayoutPanel();
            pnlAccountInfo = new Panel();
            pnlShowPass = new Panel();
            pnlCheck = new CuoreUI.Controls.cuiBorder();
            picChecked = new FontAwesome.Sharp.IconPictureBox();
            lblShowPassword = new Label();
            pnlPasswordContainer = new Panel();
            label7 = new Label();
            pnlPassword = new Panel();
            picPassword = new FontAwesome.Sharp.IconPictureBox();
            txtPassword = new CuoreUI.Controls.cuiTextBox2();
            pnlUsernameContainer = new Panel();
            label9 = new Label();
            pnlUsername = new Panel();
            picUsername = new FontAwesome.Sharp.IconPictureBox();
            txtUsername = new CuoreUI.Controls.cuiTextBox2();
            pnlNameContainer = new Panel();
            lblName = new Label();
            pnlName = new Panel();
            picUser = new FontAwesome.Sharp.IconPictureBox();
            txtName = new CuoreUI.Controls.cuiTextBox2();
            lblAccountInfo = new Label();
            pnlPriceAndQuantity = new Panel();
            pnlQuantityPerPersonContainer = new Panel();
            label11 = new Label();
            pnlQuantityPerPerson = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            txtQuantityPerPerson = new CuoreUI.Controls.cuiTextBox2();
            pnlPriceContainer = new Panel();
            label12 = new Label();
            pnlPrice = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtPrice = new CuoreUI.Controls.cuiTextBox2();
            label13 = new Label();
            pnlLeftSide = new FlowLayoutPanel();
            label1 = new Label();
            pnlSwitchContainer = new Panel();
            swtchLazyLoad = new CuoreUI.Controls.cuiSwitch();
            label4 = new Label();
            pnlBatchSizeContainer = new Panel();
            label2 = new Label();
            pnlBatchSize = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            txtBatchSize = new CuoreUI.Controls.cuiTextBox2();
            pnlScrollThreHoldContainer = new Panel();
            label3 = new Label();
            pnlScrollThreHold = new Panel();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            txtScrollThreshold = new CuoreUI.Controls.cuiTextBox2();
            pnlDelete = new CuoreUI.Controls.cuiBorder();
            btnDelete = new FontAwesome.Sharp.IconButton();
            toolTip = new ToolTip(components);
            container.SuspendLayout();
            pnlSave.SuspendLayout();
            pnlRightSide.SuspendLayout();
            pnlAccountInfo.SuspendLayout();
            pnlShowPass.SuspendLayout();
            pnlCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChecked).BeginInit();
            pnlPasswordContainer.SuspendLayout();
            pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPassword).BeginInit();
            pnlUsernameContainer.SuspendLayout();
            pnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUsername).BeginInit();
            pnlNameContainer.SuspendLayout();
            pnlName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnlPriceAndQuantity.SuspendLayout();
            pnlQuantityPerPersonContainer.SuspendLayout();
            pnlQuantityPerPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            pnlPriceContainer.SuspendLayout();
            pnlPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            pnlLeftSide.SuspendLayout();
            pnlSwitchContainer.SuspendLayout();
            pnlBatchSizeContainer.SuspendLayout();
            pnlBatchSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            pnlScrollThreHoldContainer.SuspendLayout();
            pnlScrollThreHold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            pnlDelete.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.BackColor = Color.Transparent;
            container.Controls.Add(pnlSave);
            container.Controls.Add(separator);
            container.Controls.Add(pnlRightSide);
            container.Controls.Add(pnlLeftSide);
            container.Controls.Add(pnlDelete);
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.OutlineThickness = 1F;
            container.PanelColor = Color.FromArgb(232, 237, 223);
            container.PanelOutlineColor = Color.Transparent;
            container.Rounding = new Padding(25);
            container.Size = new Size(1084, 580);
            container.TabIndex = 0;
            // 
            // pnlSave
            // 
            pnlSave.Controls.Add(btnSave);
            pnlSave.Cursor = Cursors.Hand;
            pnlSave.Location = new Point(971, 503);
            pnlSave.Name = "pnlSave";
            pnlSave.OutlineThickness = 1F;
            pnlSave.Padding = new Padding(3);
            pnlSave.PanelColor = Color.FromArgb(71, 137, 75);
            pnlSave.PanelOutlineColor = Color.FromArgb(71, 137, 75);
            pnlSave.Rounding = new Padding(5);
            pnlSave.Size = new Size(60, 50);
            pnlSave.TabIndex = 16;
            toolTip.SetToolTip(pnlSave, "حفظ");
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(71, 137, 75);
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSave.IconColor = Color.White;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSave.IconSize = 30;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(54, 44);
            btnSave.TabIndex = 14;
            toolTip.SetToolTip(btnSave, "حفظ");
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // separator
            // 
            separator.BackColor = Color.FromArgb(125, 255, 255, 255);
            separator.Location = new Point(542, 140);
            separator.Name = "separator";
            separator.Size = new Size(1, 300);
            separator.TabIndex = 12;
            // 
            // pnlRightSide
            // 
            pnlRightSide.BackColor = Color.Transparent;
            pnlRightSide.Controls.Add(pnlAccountInfo);
            pnlRightSide.Controls.Add(pnlPriceAndQuantity);
            pnlRightSide.FlowDirection = FlowDirection.TopDown;
            pnlRightSide.Location = new Point(544, 0);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Padding = new Padding(25, 10, 25, 0);
            pnlRightSide.RightToLeft = RightToLeft.Yes;
            pnlRightSide.Size = new Size(540, 497);
            pnlRightSide.TabIndex = 1;
            // 
            // pnlAccountInfo
            // 
            pnlAccountInfo.Controls.Add(pnlShowPass);
            pnlAccountInfo.Controls.Add(pnlPasswordContainer);
            pnlAccountInfo.Controls.Add(pnlUsernameContainer);
            pnlAccountInfo.Controls.Add(pnlNameContainer);
            pnlAccountInfo.Controls.Add(lblAccountInfo);
            pnlAccountInfo.Location = new Point(47, 13);
            pnlAccountInfo.Name = "pnlAccountInfo";
            pnlAccountInfo.Size = new Size(440, 266);
            pnlAccountInfo.TabIndex = 16;
            // 
            // pnlShowPass
            // 
            pnlShowPass.Controls.Add(pnlCheck);
            pnlShowPass.Controls.Add(lblShowPassword);
            pnlShowPass.Location = new Point(3, 202);
            pnlShowPass.Name = "pnlShowPass";
            pnlShowPass.Size = new Size(352, 30);
            pnlShowPass.TabIndex = 10;
            // 
            // pnlCheck
            // 
            pnlCheck.Controls.Add(picChecked);
            pnlCheck.Cursor = Cursors.Hand;
            pnlCheck.Location = new Point(325, 7);
            pnlCheck.Name = "pnlCheck";
            pnlCheck.OutlineThickness = 1F;
            pnlCheck.PanelColor = Color.Transparent;
            pnlCheck.PanelOutlineColor = Color.Gray;
            pnlCheck.Rounding = new Padding(5);
            pnlCheck.Size = new Size(20, 20);
            pnlCheck.TabIndex = 13;
            pnlCheck.Click += pnlCheck_Click;
            // 
            // picChecked
            // 
            picChecked.BackColor = Color.Transparent;
            picChecked.ForeColor = Color.Black;
            picChecked.IconChar = FontAwesome.Sharp.IconChar.Check;
            picChecked.IconColor = Color.Black;
            picChecked.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picChecked.IconSize = 12;
            picChecked.Location = new Point(5, 5);
            picChecked.Name = "picChecked";
            picChecked.Size = new Size(12, 12);
            picChecked.TabIndex = 14;
            picChecked.TabStop = false;
            picChecked.Visible = false;
            picChecked.Click += picChecked_Click;
            // 
            // lblShowPassword
            // 
            lblShowPassword.AutoSize = true;
            lblShowPassword.Font = new Font("Cairo Light", 14F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblShowPassword.ForeColor = Color.Black;
            lblShowPassword.Location = new Point(205, 4);
            lblShowPassword.Name = "lblShowPassword";
            lblShowPassword.Size = new Size(112, 26);
            lblShowPassword.TabIndex = 12;
            lblShowPassword.Text = "إظهار كلمة المرور";
            // 
            // pnlPasswordContainer
            // 
            pnlPasswordContainer.Controls.Add(label7);
            pnlPasswordContainer.Controls.Add(pnlPassword);
            pnlPasswordContainer.Location = new Point(0, 145);
            pnlPasswordContainer.Name = "pnlPasswordContainer";
            pnlPasswordContainer.Size = new Size(440, 50);
            pnlPasswordContainer.TabIndex = 15;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Right;
            label7.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(348, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 50);
            label7.TabIndex = 5;
            label7.Text = "كلمة المرور:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlPassword
            // 
            pnlPassword.Controls.Add(picPassword);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Dock = DockStyle.Left;
            pnlPassword.Location = new Point(0, 0);
            pnlPassword.Margin = new Padding(3, 3, 3, 5);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Padding = new Padding(3);
            pnlPassword.Size = new Size(347, 50);
            pnlPassword.TabIndex = 6;
            // 
            // picPassword
            // 
            picPassword.BackColor = Color.FromArgb(207, 219, 213);
            picPassword.ForeColor = Color.Black;
            picPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            picPassword.IconColor = Color.Black;
            picPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picPassword.IconSize = 20;
            picPassword.Location = new Point(314, 15);
            picPassword.Name = "picPassword";
            picPassword.Size = new Size(20, 20);
            picPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            picPassword.TabIndex = 2;
            picPassword.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(207, 219, 213);
            txtPassword.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtPassword.BorderColor = Color.Transparent;
            txtPassword.BorderSize = 1;
            txtPassword.Content = "";
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtPassword.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtPassword.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(3, 3);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(50, 10, 50, 0);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.Gray;
            txtPassword.PlaceholderText = "";
            txtPassword.Rounding = new Padding(5);
            txtPassword.Size = new Size(341, 44);
            txtPassword.TabIndex = 1;
            txtPassword.TextOffset = new Size(25, 0);
            txtPassword.UnderlinedStyle = false;
            txtPassword.CursorChanged += InputChanged;
            txtPassword.Enter += TextBox_Enter;
            txtPassword.Leave += TextBox_Leave;
            // 
            // pnlUsernameContainer
            // 
            pnlUsernameContainer.Controls.Add(label9);
            pnlUsernameContainer.Controls.Add(pnlUsername);
            pnlUsernameContainer.Location = new Point(0, 95);
            pnlUsernameContainer.Name = "pnlUsernameContainer";
            pnlUsernameContainer.Size = new Size(440, 50);
            pnlUsernameContainer.TabIndex = 14;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Right;
            label9.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(348, 0);
            label9.Name = "label9";
            label9.Size = new Size(92, 50);
            label9.TabIndex = 5;
            label9.Text = "اسم المستخدم:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlUsername
            // 
            pnlUsername.Controls.Add(picUsername);
            pnlUsername.Controls.Add(txtUsername);
            pnlUsername.Dock = DockStyle.Left;
            pnlUsername.Location = new Point(0, 0);
            pnlUsername.Margin = new Padding(3, 3, 3, 5);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Padding = new Padding(3);
            pnlUsername.Size = new Size(348, 50);
            pnlUsername.TabIndex = 6;
            // 
            // picUsername
            // 
            picUsername.BackColor = Color.FromArgb(207, 219, 213);
            picUsername.ForeColor = Color.Black;
            picUsername.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            picUsername.IconColor = Color.Black;
            picUsername.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picUsername.IconSize = 20;
            picUsername.Location = new Point(314, 15);
            picUsername.Name = "picUsername";
            picUsername.Size = new Size(20, 20);
            picUsername.SizeMode = PictureBoxSizeMode.AutoSize;
            picUsername.TabIndex = 2;
            picUsername.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(207, 219, 213);
            txtUsername.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtUsername.BorderColor = Color.Transparent;
            txtUsername.BorderSize = 1;
            txtUsername.Content = "";
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtUsername.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtUsername.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(3, 3);
            txtUsername.Margin = new Padding(4);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(50, 10, 50, 0);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.Gray;
            txtUsername.PlaceholderText = "mina";
            txtUsername.Rounding = new Padding(5);
            txtUsername.Size = new Size(342, 44);
            txtUsername.TabIndex = 1;
            txtUsername.TextOffset = new Size(25, 0);
            txtUsername.UnderlinedStyle = false;
            txtUsername.CursorChanged += InputChanged;
            txtUsername.Enter += TextBox_Enter;
            txtUsername.Leave += TextBox_Leave;
            // 
            // pnlNameContainer
            // 
            pnlNameContainer.Controls.Add(lblName);
            pnlNameContainer.Controls.Add(pnlName);
            pnlNameContainer.Location = new Point(0, 46);
            pnlNameContainer.Name = "pnlNameContainer";
            pnlNameContainer.Size = new Size(440, 50);
            pnlNameContainer.TabIndex = 13;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Right;
            lblName.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(348, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(92, 50);
            lblName.TabIndex = 5;
            lblName.Text = "الاسم:";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlName
            // 
            pnlName.Controls.Add(picUser);
            pnlName.Controls.Add(txtName);
            pnlName.Dock = DockStyle.Left;
            pnlName.Location = new Point(0, 0);
            pnlName.Margin = new Padding(3, 3, 3, 5);
            pnlName.Name = "pnlName";
            pnlName.Padding = new Padding(3);
            pnlName.Size = new Size(348, 50);
            pnlName.TabIndex = 6;
            // 
            // picUser
            // 
            picUser.BackColor = Color.FromArgb(207, 219, 213);
            picUser.ForeColor = Color.Black;
            picUser.IconChar = FontAwesome.Sharp.IconChar.User;
            picUser.IconColor = Color.Black;
            picUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picUser.IconSize = 20;
            picUser.Location = new Point(314, 15);
            picUser.Name = "picUser";
            picUser.Size = new Size(20, 20);
            picUser.SizeMode = PictureBoxSizeMode.AutoSize;
            picUser.TabIndex = 2;
            picUser.TabStop = false;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(207, 219, 213);
            txtName.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtName.BorderColor = Color.Transparent;
            txtName.BorderSize = 1;
            txtName.Content = "";
            txtName.Dock = DockStyle.Fill;
            txtName.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtName.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtName.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(3, 3);
            txtName.Margin = new Padding(4);
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(50, 10, 50, 0);
            txtName.PasswordChar = false;
            txtName.PlaceholderColor = Color.Gray;
            txtName.PlaceholderText = "Mina";
            txtName.Rounding = new Padding(5);
            txtName.Size = new Size(342, 44);
            txtName.TabIndex = 1;
            txtName.TextOffset = new Size(25, 0);
            txtName.UnderlinedStyle = false;
            txtName.CursorChanged += InputChanged;
            txtName.Enter += TextBox_Enter;
            txtName.Leave += TextBox_Leave;
            // 
            // lblAccountInfo
            // 
            lblAccountInfo.Dock = DockStyle.Top;
            lblAccountInfo.Font = new Font("Cairo Black", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblAccountInfo.ForeColor = Color.Black;
            lblAccountInfo.Location = new Point(0, 0);
            lblAccountInfo.Margin = new Padding(3, 0, 3, 10);
            lblAccountInfo.Name = "lblAccountInfo";
            lblAccountInfo.Size = new Size(440, 46);
            lblAccountInfo.TabIndex = 0;
            lblAccountInfo.Text = "بـيـانـات الـحـسـاب";
            // 
            // pnlPriceAndQuantity
            // 
            pnlPriceAndQuantity.Controls.Add(pnlQuantityPerPersonContainer);
            pnlPriceAndQuantity.Controls.Add(pnlPriceContainer);
            pnlPriceAndQuantity.Controls.Add(label13);
            pnlPriceAndQuantity.Location = new Point(47, 285);
            pnlPriceAndQuantity.Name = "pnlPriceAndQuantity";
            pnlPriceAndQuantity.Size = new Size(440, 159);
            pnlPriceAndQuantity.TabIndex = 17;
            // 
            // pnlQuantityPerPersonContainer
            // 
            pnlQuantityPerPersonContainer.Controls.Add(label11);
            pnlQuantityPerPersonContainer.Controls.Add(pnlQuantityPerPerson);
            pnlQuantityPerPersonContainer.Location = new Point(0, 94);
            pnlQuantityPerPersonContainer.Name = "pnlQuantityPerPersonContainer";
            pnlQuantityPerPersonContainer.Size = new Size(440, 50);
            pnlQuantityPerPersonContainer.TabIndex = 14;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Right;
            label11.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(348, 0);
            label11.Name = "label11";
            label11.Size = new Size(92, 50);
            label11.TabIndex = 5;
            label11.Text = "وزن الشكارة:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlQuantityPerPerson
            // 
            pnlQuantityPerPerson.BackColor = Color.Transparent;
            pnlQuantityPerPerson.Controls.Add(iconPictureBox2);
            pnlQuantityPerPerson.Controls.Add(txtQuantityPerPerson);
            pnlQuantityPerPerson.Dock = DockStyle.Left;
            pnlQuantityPerPerson.Location = new Point(0, 0);
            pnlQuantityPerPerson.Margin = new Padding(3, 3, 3, 5);
            pnlQuantityPerPerson.Name = "pnlQuantityPerPerson";
            pnlQuantityPerPerson.Padding = new Padding(3);
            pnlQuantityPerPerson.Size = new Size(348, 50);
            pnlQuantityPerPerson.TabIndex = 6;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(207, 219, 213);
            iconPictureBox2.ForeColor = Color.Black;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.SackXmark;
            iconPictureBox2.IconColor = Color.Black;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox2.IconSize = 20;
            iconPictureBox2.Location = new Point(314, 15);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(20, 20);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            iconPictureBox2.TabIndex = 2;
            iconPictureBox2.TabStop = false;
            // 
            // txtQuantityPerPerson
            // 
            txtQuantityPerPerson.BackColor = Color.FromArgb(207, 219, 213);
            txtQuantityPerPerson.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtQuantityPerPerson.BorderColor = Color.Transparent;
            txtQuantityPerPerson.BorderSize = 1;
            txtQuantityPerPerson.Content = "";
            txtQuantityPerPerson.Dock = DockStyle.Fill;
            txtQuantityPerPerson.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtQuantityPerPerson.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtQuantityPerPerson.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantityPerPerson.ForeColor = Color.Black;
            txtQuantityPerPerson.Location = new Point(3, 3);
            txtQuantityPerPerson.Margin = new Padding(4);
            txtQuantityPerPerson.Multiline = false;
            txtQuantityPerPerson.Name = "txtQuantityPerPerson";
            txtQuantityPerPerson.Padding = new Padding(50, 10, 50, 0);
            txtQuantityPerPerson.PasswordChar = false;
            txtQuantityPerPerson.PlaceholderColor = Color.Gray;
            txtQuantityPerPerson.PlaceholderText = "";
            txtQuantityPerPerson.Rounding = new Padding(5);
            txtQuantityPerPerson.Size = new Size(342, 44);
            txtQuantityPerPerson.TabIndex = 1;
            txtQuantityPerPerson.TextOffset = new Size(25, 0);
            txtQuantityPerPerson.UnderlinedStyle = false;
            txtQuantityPerPerson.ContentChanged += InputChanged;
            txtQuantityPerPerson.Enter += TextBox_Enter;
            txtQuantityPerPerson.Leave += TextBox_Leave;
            // 
            // pnlPriceContainer
            // 
            pnlPriceContainer.Controls.Add(label12);
            pnlPriceContainer.Controls.Add(pnlPrice);
            pnlPriceContainer.Location = new Point(0, 46);
            pnlPriceContainer.Name = "pnlPriceContainer";
            pnlPriceContainer.Size = new Size(440, 50);
            pnlPriceContainer.TabIndex = 13;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Right;
            label12.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(348, 0);
            label12.Name = "label12";
            label12.Size = new Size(92, 50);
            label12.TabIndex = 5;
            label12.Text = "سعر الشكارة:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlPrice
            // 
            pnlPrice.Controls.Add(iconPictureBox1);
            pnlPrice.Controls.Add(txtPrice);
            pnlPrice.Dock = DockStyle.Left;
            pnlPrice.Location = new Point(0, 0);
            pnlPrice.Margin = new Padding(3, 3, 3, 5);
            pnlPrice.Name = "pnlPrice";
            pnlPrice.Padding = new Padding(3);
            pnlPrice.Size = new Size(348, 50);
            pnlPrice.TabIndex = 6;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(207, 219, 213);
            iconPictureBox1.ForeColor = Color.Black;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox1.IconSize = 20;
            iconPictureBox1.Location = new Point(314, 15);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(20, 20);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(207, 219, 213);
            txtPrice.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtPrice.BorderColor = Color.Transparent;
            txtPrice.BorderSize = 1;
            txtPrice.Content = "";
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtPrice.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtPrice.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.ForeColor = Color.Black;
            txtPrice.Location = new Point(3, 3);
            txtPrice.Margin = new Padding(4);
            txtPrice.Multiline = false;
            txtPrice.Name = "txtPrice";
            txtPrice.Padding = new Padding(50, 10, 50, 0);
            txtPrice.PasswordChar = false;
            txtPrice.PlaceholderColor = Color.Gray;
            txtPrice.PlaceholderText = "";
            txtPrice.Rounding = new Padding(5);
            txtPrice.Size = new Size(342, 44);
            txtPrice.TabIndex = 3;
            txtPrice.TextOffset = new Size(25, 0);
            txtPrice.UnderlinedStyle = false;
            txtPrice.ContentChanged += InputChanged;
            txtPrice.Enter += TextBox_Enter;
            txtPrice.Leave += TextBox_Leave;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Top;
            label13.Font = new Font("Cairo Black", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(0, 0);
            label13.Margin = new Padding(3, 0, 3, 10);
            label13.Name = "label13";
            label13.Size = new Size(440, 46);
            label13.TabIndex = 0;
            label13.Text = "الاسـعـار والـقـيـم";
            // 
            // pnlLeftSide
            // 
            pnlLeftSide.BackColor = Color.Transparent;
            pnlLeftSide.Controls.Add(label1);
            pnlLeftSide.Controls.Add(pnlSwitchContainer);
            pnlLeftSide.Controls.Add(pnlBatchSizeContainer);
            pnlLeftSide.Controls.Add(pnlScrollThreHoldContainer);
            pnlLeftSide.FlowDirection = FlowDirection.TopDown;
            pnlLeftSide.Location = new Point(0, 0);
            pnlLeftSide.Name = "pnlLeftSide";
            pnlLeftSide.Padding = new Padding(25, 10, 25, 0);
            pnlLeftSide.RightToLeft = RightToLeft.Yes;
            pnlLeftSide.Size = new Size(540, 346);
            pnlLeftSide.TabIndex = 11;
            // 
            // label1
            // 
            label1.Font = new Font("Cairo Black", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(47, 20);
            label1.Margin = new Padding(3, 10, 3, 5);
            label1.Name = "label1";
            label1.Size = new Size(440, 30);
            label1.TabIndex = 0;
            label1.Text = "التحميل عند الطلب";
            // 
            // pnlSwitchContainer
            // 
            pnlSwitchContainer.Controls.Add(swtchLazyLoad);
            pnlSwitchContainer.Controls.Add(label4);
            pnlSwitchContainer.Location = new Point(47, 58);
            pnlSwitchContainer.Name = "pnlSwitchContainer";
            pnlSwitchContainer.Size = new Size(440, 51);
            pnlSwitchContainer.TabIndex = 7;
            // 
            // swtchLazyLoad
            // 
            swtchLazyLoad.Checked = Settings.Default.lazyLoading;
            swtchLazyLoad.CheckedBackground = Color.FromArgb(71, 137, 75);
            swtchLazyLoad.CheckedForeground = Color.White;
            swtchLazyLoad.CheckedOutlineColor = Color.Transparent;
            swtchLazyLoad.CheckedSymbolColor = Color.FromArgb(71, 137, 75);
            swtchLazyLoad.Cursor = Cursors.Hand;
            swtchLazyLoad.ForeColor = Color.FromArgb(171, 171, 171);
            swtchLazyLoad.Location = new Point(390, 13);
            swtchLazyLoad.Name = "swtchLazyLoad";
            swtchLazyLoad.OutlineStyle = true;
            swtchLazyLoad.OutlineThickness = 1F;
            swtchLazyLoad.RightToLeft = RightToLeft.No;
            swtchLazyLoad.ShowSymbols = true;
            swtchLazyLoad.Size = new Size(48, 24);
            swtchLazyLoad.TabIndex = 9;
            swtchLazyLoad.ThumbSizeModifier = new Size(0, 0);
            swtchLazyLoad.UncheckedBackground = Color.Transparent;
            swtchLazyLoad.UncheckedForeground = Color.FromArgb(34, 34, 34);
            swtchLazyLoad.UncheckedOutlineColor = Color.FromArgb(34, 34, 34);
            swtchLazyLoad.UncheckedSymbolColor = Color.FromArgb(34, 34, 34);
            swtchLazyLoad.CheckedChanged += cuiSwitch1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo Light", 14F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(273, 12);
            label4.Name = "label4";
            label4.Size = new Size(114, 26);
            label4.TabIndex = 8;
            label4.Text = "التحميل عند الطلب";
            // 
            // pnlBatchSizeContainer
            // 
            pnlBatchSizeContainer.Controls.Add(label2);
            pnlBatchSizeContainer.Controls.Add(pnlBatchSize);
            pnlBatchSizeContainer.Location = new Point(50, 112);
            pnlBatchSizeContainer.Margin = new Padding(0);
            pnlBatchSizeContainer.Name = "pnlBatchSizeContainer";
            pnlBatchSizeContainer.Size = new Size(440, 50);
            pnlBatchSizeContainer.TabIndex = 15;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(327, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 50);
            label2.TabIndex = 5;
            label2.Text = "عدد العناصر المحمّلة:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlBatchSize
            // 
            pnlBatchSize.Controls.Add(iconPictureBox3);
            pnlBatchSize.Controls.Add(txtBatchSize);
            pnlBatchSize.Dock = DockStyle.Left;
            pnlBatchSize.Location = new Point(0, 0);
            pnlBatchSize.Margin = new Padding(3, 3, 3, 5);
            pnlBatchSize.Name = "pnlBatchSize";
            pnlBatchSize.Padding = new Padding(3);
            pnlBatchSize.Size = new Size(330, 50);
            pnlBatchSize.TabIndex = 6;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(207, 219, 213);
            iconPictureBox3.ForeColor = Color.Black;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Box;
            iconPictureBox3.IconColor = Color.Black;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox3.IconSize = 20;
            iconPictureBox3.Location = new Point(299, 15);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(20, 20);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            iconPictureBox3.TabIndex = 2;
            iconPictureBox3.TabStop = false;
            // 
            // txtBatchSize
            // 
            txtBatchSize.BackColor = Color.FromArgb(207, 219, 213);
            txtBatchSize.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtBatchSize.BorderColor = Color.Transparent;
            txtBatchSize.BorderSize = 1;
            txtBatchSize.Content = "";
            txtBatchSize.Dock = DockStyle.Fill;
            txtBatchSize.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtBatchSize.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtBatchSize.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBatchSize.ForeColor = Color.Black;
            txtBatchSize.Location = new Point(3, 3);
            txtBatchSize.Margin = new Padding(4);
            txtBatchSize.Multiline = false;
            txtBatchSize.Name = "txtBatchSize";
            txtBatchSize.Padding = new Padding(50, 10, 50, 0);
            txtBatchSize.PasswordChar = false;
            txtBatchSize.PlaceholderColor = Color.Gray;
            txtBatchSize.PlaceholderText = "";
            txtBatchSize.Rounding = new Padding(5);
            txtBatchSize.Size = new Size(324, 44);
            txtBatchSize.TabIndex = 1;
            txtBatchSize.TextOffset = new Size(25, 0);
            txtBatchSize.UnderlinedStyle = false;
            txtBatchSize.ContentChanged += InputChanged;
            txtBatchSize.Enter += TextBox_Enter;
            txtBatchSize.Leave += TextBox_Leave;
            // 
            // pnlScrollThreHoldContainer
            // 
            pnlScrollThreHoldContainer.Controls.Add(label3);
            pnlScrollThreHoldContainer.Controls.Add(pnlScrollThreHold);
            pnlScrollThreHoldContainer.Location = new Point(50, 162);
            pnlScrollThreHoldContainer.Margin = new Padding(0);
            pnlScrollThreHoldContainer.Name = "pnlScrollThreHoldContainer";
            pnlScrollThreHoldContainer.Size = new Size(440, 50);
            pnlScrollThreHoldContainer.TabIndex = 16;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(327, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 50);
            label3.TabIndex = 5;
            label3.Text = "حد التمرير للتحميل:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlScrollThreHold
            // 
            pnlScrollThreHold.Controls.Add(iconPictureBox4);
            pnlScrollThreHold.Controls.Add(txtScrollThreshold);
            pnlScrollThreHold.Dock = DockStyle.Left;
            pnlScrollThreHold.Location = new Point(0, 0);
            pnlScrollThreHold.Margin = new Padding(3, 3, 3, 5);
            pnlScrollThreHold.Name = "pnlScrollThreHold";
            pnlScrollThreHold.Padding = new Padding(3);
            pnlScrollThreHold.Size = new Size(330, 50);
            pnlScrollThreHold.TabIndex = 6;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(207, 219, 213);
            iconPictureBox4.ForeColor = Color.Black;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Mouse;
            iconPictureBox4.IconColor = Color.Black;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox4.IconSize = 20;
            iconPictureBox4.Location = new Point(299, 15);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(20, 20);
            iconPictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            iconPictureBox4.TabIndex = 2;
            iconPictureBox4.TabStop = false;
            // 
            // txtScrollThreshold
            // 
            txtScrollThreshold.BackColor = Color.FromArgb(207, 219, 213);
            txtScrollThreshold.BackgroundColor = Color.FromArgb(207, 219, 213);
            txtScrollThreshold.BorderColor = Color.Transparent;
            txtScrollThreshold.BorderSize = 1;
            txtScrollThreshold.Content = "";
            txtScrollThreshold.Dock = DockStyle.Fill;
            txtScrollThreshold.FocusBackgroundColor = Color.FromArgb(207, 219, 213);
            txtScrollThreshold.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtScrollThreshold.Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScrollThreshold.ForeColor = Color.Black;
            txtScrollThreshold.Location = new Point(3, 3);
            txtScrollThreshold.Margin = new Padding(4);
            txtScrollThreshold.Multiline = false;
            txtScrollThreshold.Name = "txtScrollThreshold";
            txtScrollThreshold.Padding = new Padding(50, 10, 50, 0);
            txtScrollThreshold.PasswordChar = false;
            txtScrollThreshold.PlaceholderColor = Color.Gray;
            txtScrollThreshold.PlaceholderText = "";
            txtScrollThreshold.Rounding = new Padding(5);
            txtScrollThreshold.Size = new Size(324, 44);
            txtScrollThreshold.TabIndex = 1;
            txtScrollThreshold.TextOffset = new Size(25, 0);
            txtScrollThreshold.UnderlinedStyle = false;
            txtScrollThreshold.ContentChanged += InputChanged;
            txtScrollThreshold.Enter += TextBox_Enter;
            txtScrollThreshold.Leave += TextBox_Leave;
            // 
            // pnlDelete
            // 
            pnlDelete.Controls.Add(btnDelete);
            pnlDelete.Cursor = Cursors.Hand;
            pnlDelete.Location = new Point(47, 503);
            pnlDelete.Name = "pnlDelete";
            pnlDelete.OutlineThickness = 1F;
            pnlDelete.Padding = new Padding(3);
            pnlDelete.PanelColor = Color.Transparent;
            pnlDelete.PanelOutlineColor = Color.Red;
            pnlDelete.Rounding = new Padding(5);
            pnlDelete.Size = new Size(60, 50);
            pnlDelete.TabIndex = 15;
            toolTip.SetToolTip(pnlDelete, "حذف الحساب الحالي");
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDelete.IconColor = Color.Red;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 25;
            btnDelete.Location = new Point(3, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(54, 44);
            btnDelete.TabIndex = 14;
            toolTip.SetToolTip(btnDelete, "حذف الحساب الحالي");
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ucSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(container);
            Font = new Font("Cairo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "ucSettings";
            Size = new Size(1084, 580);
            Load += ucSettings_Load;
            container.ResumeLayout(false);
            pnlSave.ResumeLayout(false);
            pnlRightSide.ResumeLayout(false);
            pnlAccountInfo.ResumeLayout(false);
            pnlShowPass.ResumeLayout(false);
            pnlShowPass.PerformLayout();
            pnlCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picChecked).EndInit();
            pnlPasswordContainer.ResumeLayout(false);
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPassword).EndInit();
            pnlUsernameContainer.ResumeLayout(false);
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUsername).EndInit();
            pnlNameContainer.ResumeLayout(false);
            pnlName.ResumeLayout(false);
            pnlName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnlPriceAndQuantity.ResumeLayout(false);
            pnlQuantityPerPersonContainer.ResumeLayout(false);
            pnlQuantityPerPerson.ResumeLayout(false);
            pnlQuantityPerPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            pnlPriceContainer.ResumeLayout(false);
            pnlPrice.ResumeLayout(false);
            pnlPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            pnlLeftSide.ResumeLayout(false);
            pnlSwitchContainer.ResumeLayout(false);
            pnlSwitchContainer.PerformLayout();
            pnlBatchSizeContainer.ResumeLayout(false);
            pnlBatchSize.ResumeLayout(false);
            pnlBatchSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            pnlScrollThreHoldContainer.ResumeLayout(false);
            pnlScrollThreHold.ResumeLayout(false);
            pnlScrollThreHold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            pnlDelete.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiBorder container;
        private Label lblAccountInfo;
        private FlowLayoutPanel pnlRightSide;
        private FontAwesome.Sharp.IconPictureBox picUsername;
        private FontAwesome.Sharp.IconPictureBox picPassword;
        private Panel pnlShowPass;
        private CuoreUI.Controls.cuiBorder pnlCheck;
        private Label lblShowPassword;
        private FontAwesome.Sharp.IconPictureBox picChecked;
        private Panel separator;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private CuoreUI.Controls.cuiTextBox2 txtQuantityPerPerson;
        private Panel pnlNameContainer;
        private Label lblName;
        private Panel pnlName;
        private FontAwesome.Sharp.IconPictureBox picUser;
        private CuoreUI.Controls.cuiTextBox2 txtName;
        private Panel pnlUsernameContainer;
        private Label label9;
        private Panel pnlUsername;
        private CuoreUI.Controls.cuiTextBox2 txtUsername;
        private Panel pnlPasswordContainer;
        private Label label7;
        private Panel pnlPassword;
        private CuoreUI.Controls.cuiTextBox2 txtPassword;
        private Panel pnlAccountInfo;
        private Panel pnlPriceAndQuantity;
        private Panel pnlQuantityPerPersonContainer;
        private Label label11;
        private Panel pnlQuantityPerPerson;
        private Panel pnlPriceContainer;
        private Label label12;
        private Panel pnlPrice;
        private Label label13;
        private CuoreUI.Controls.cuiTextBox2 txtPrice;
        private FlowLayoutPanel pnlLeftSide;
        private Label label1;
        private Panel pnlSwitchContainer;
        private CuoreUI.Controls.cuiSwitch swtchLazyLoad;
        private Label label4;
        private Panel pnlBatchSizeContainer;
        private Label label2;
        private Panel pnlBatchSize;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private CuoreUI.Controls.cuiTextBox2 txtBatchSize;
        private Panel pnlScrollThreHoldContainer;
        private Label label3;
        private Panel pnlScrollThreHold;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private CuoreUI.Controls.cuiTextBox2 txtScrollThreshold;
        private FontAwesome.Sharp.IconButton btnDelete;
        private CuoreUI.Controls.cuiBorder pnlDelete;
        private ToolTip toolTip;
        private CuoreUI.Controls.cuiBorder pnlSave;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}

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
            components = new System.ComponentModel.Container();
            frmBorder = new CuoreUI.Components.cuiFormRounder();
            pnlNavBar = new Panel();
            pnlUpdateCheck = new Panel();
            btnUpdateCheck = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            spUpdateCheck = new CuoreUI.Controls.cuiSpinner();
            pnlAddDropDown = new CuoreUI.Controls.cuiBorder();
            btnAddOwner = new CuoreUI.Controls.cuiButton();
            btnAddQuota = new CuoreUI.Controls.cuiButton();
            btnAddCustomer = new CuoreUI.Controls.cuiButton();
            lblTitle = new Label();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            pnlSearch = new Panel();
            picClearSearch = new FontAwesome.Sharp.IconPictureBox();
            txtSearch = new CuoreUI.Controls.cuiTextBox2();
            pnlNavBtns = new Panel();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            frmDrag = new CuoreUI.cuiControlDrag(components);
            pnlMenu = new Panel();
            btnSettings = new FontAwesome.Sharp.IconPictureBox();
            lblSettings = new Label();
            btnInfo = new FontAwesome.Sharp.IconPictureBox();
            lblInfo = new Label();
            btnHome = new FontAwesome.Sharp.IconPictureBox();
            btnSta = new FontAwesome.Sharp.IconPictureBox();
            lblStatistics = new Label();
            lblHome = new Label();
            circle = new CuoreUI.Controls.Shapes.cuiEllipse();
            btnMode = new FontAwesome.Sharp.IconButton();
            pnlContainer = new CuoreUI.Controls.cuiBorder();
            searchTimer = new System.Windows.Forms.Timer(components);
            menuTranstion = new System.Windows.Forms.Timer(components);
            typingTimer = new System.Windows.Forms.Timer(components);
            addDropDownTimer = new System.Windows.Forms.Timer(components);
            btnAddCustomerTimer = new System.Windows.Forms.Timer(components);
            pnlNavBar.SuspendLayout();
            pnlUpdateCheck.SuspendLayout();
            pnlAddDropDown.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClearSearch).BeginInit();
            pnlNavBtns.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSta).BeginInit();
            SuspendLayout();
            // 
            // frmBorder
            // 
            frmBorder.EnhanceCorners = false;
            frmBorder.OutlineColor = Color.FromArgb(0, 71, 137, 75);
            frmBorder.Rounding = 5;
            frmBorder.TargetForm = this;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.Transparent;
            pnlNavBar.Controls.Add(pnlUpdateCheck);
            pnlNavBar.Controls.Add(pnlAddDropDown);
            pnlNavBar.Controls.Add(lblTitle);
            pnlNavBar.Controls.Add(btnMinimize);
            pnlNavBar.Controls.Add(btnClose);
            pnlNavBar.Controls.Add(pnlSearch);
            pnlNavBar.Controls.Add(pnlNavBtns);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1200, 83);
            pnlNavBar.TabIndex = 0;
            // 
            // pnlUpdateCheck
            // 
            pnlUpdateCheck.Controls.Add(btnUpdateCheck);
            pnlUpdateCheck.Controls.Add(label1);
            pnlUpdateCheck.Controls.Add(spUpdateCheck);
            pnlUpdateCheck.Location = new Point(15, 24);
            pnlUpdateCheck.Name = "pnlUpdateCheck";
            pnlUpdateCheck.Size = new Size(132, 35);
            pnlUpdateCheck.TabIndex = 13;
            pnlUpdateCheck.Visible = false;
            // 
            // btnUpdateCheck
            // 
            btnUpdateCheck.BackColor = Color.FromArgb(18, 18, 18);
            btnUpdateCheck.Cursor = Cursors.Hand;
            btnUpdateCheck.Dock = DockStyle.Left;
            btnUpdateCheck.FlatAppearance.BorderSize = 0;
            btnUpdateCheck.FlatStyle = FlatStyle.Flat;
            btnUpdateCheck.ForeColor = Color.Transparent;
            btnUpdateCheck.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnUpdateCheck.IconColor = Color.White;
            btnUpdateCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdateCheck.IconSize = 16;
            btnUpdateCheck.Location = new Point(59, 0);
            btnUpdateCheck.Name = "btnUpdateCheck";
            btnUpdateCheck.Size = new Size(38, 35);
            btnUpdateCheck.TabIndex = 4;
            btnUpdateCheck.TabStop = false;
            btnUpdateCheck.UseVisualStyleBackColor = false;
            btnUpdateCheck.Click += btnUpdateCheck_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(232, 237, 223);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 35);
            label1.TabIndex = 5;
            label1.Text = "تفقد التحديثات";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // spUpdateCheck
            // 
            spUpdateCheck.ArcColor = Color.FromArgb(71, 137, 75);
            spUpdateCheck.BackColor = Color.FromArgb(18, 18, 18);
            spUpdateCheck.Dock = DockStyle.Right;
            spUpdateCheck.Location = new Point(97, 0);
            spUpdateCheck.Name = "spUpdateCheck";
            spUpdateCheck.RingColor = Color.FromArgb(34, 34, 34);
            spUpdateCheck.RotateSpeed = 3F;
            spUpdateCheck.Rotation = 132.091217F;
            spUpdateCheck.Size = new Size(35, 35);
            spUpdateCheck.TabIndex = 14;
            spUpdateCheck.Thickness = 3F;
            spUpdateCheck.Visible = false;
            // 
            // pnlAddDropDown
            // 
            pnlAddDropDown.BackColor = Color.Transparent;
            pnlAddDropDown.BackgroundImage = Properties.Resources.AddDropDownBackGround;
            pnlAddDropDown.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAddDropDown.Controls.Add(btnAddOwner);
            pnlAddDropDown.Controls.Add(btnAddQuota);
            pnlAddDropDown.Controls.Add(btnAddCustomer);
            pnlAddDropDown.Location = new Point(20, 59);
            pnlAddDropDown.MaximumSize = new Size(150, 120);
            pnlAddDropDown.MinimumSize = new Size(150, 0);
            pnlAddDropDown.Name = "pnlAddDropDown";
            pnlAddDropDown.OutlineThickness = 1F;
            pnlAddDropDown.PanelColor = Color.FromArgb(221, 221, 221);
            pnlAddDropDown.PanelOutlineColor = Color.FromArgb(221, 221, 221);
            pnlAddDropDown.Rounding = new Padding(10);
            pnlAddDropDown.Size = new Size(150, 0);
            pnlAddDropDown.TabIndex = 11;
            // 
            // btnAddOwner
            // 
            btnAddOwner.BackColor = Color.Transparent;
            btnAddOwner.CheckButton = false;
            btnAddOwner.Checked = false;
            btnAddOwner.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAddOwner.CheckedForeColor = Color.White;
            btnAddOwner.CheckedImageTint = Color.White;
            btnAddOwner.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAddOwner.Content = "إضافة مالك";
            btnAddOwner.Cursor = Cursors.Hand;
            btnAddOwner.DialogResult = DialogResult.None;
            btnAddOwner.Dock = DockStyle.Top;
            btnAddOwner.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btnAddOwner.ForeColor = Color.Black;
            btnAddOwner.HoverBackground = Color.LightGray;
            btnAddOwner.HoveredImageTint = Color.White;
            btnAddOwner.HoverForeColor = Color.Black;
            btnAddOwner.HoverOutline = Color.Empty;
            btnAddOwner.Image = null;
            btnAddOwner.ImageAutoCenter = true;
            btnAddOwner.ImageExpand = new Point(0, 0);
            btnAddOwner.ImageOffset = new Point(0, 0);
            btnAddOwner.Location = new Point(0, 80);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.NormalBackground = Color.Transparent;
            btnAddOwner.NormalForeColor = Color.Black;
            btnAddOwner.NormalImageTint = Color.White;
            btnAddOwner.NormalOutline = Color.Empty;
            btnAddOwner.OutlineThickness = 0F;
            btnAddOwner.PressedBackground = Color.FromArgb(71, 137, 75);
            btnAddOwner.PressedForeColor = Color.White;
            btnAddOwner.PressedImageTint = Color.White;
            btnAddOwner.PressedOutline = Color.Empty;
            btnAddOwner.Rounding = new Padding(0, 0, 10, 10);
            btnAddOwner.Size = new Size(150, 40);
            btnAddOwner.TabIndex = 2;
            btnAddOwner.TextOffset = new Point(0, 0);
            btnAddOwner.Click += btnAddOwner_Click;
            // 
            // btnAddQuota
            // 
            btnAddQuota.BackColor = Color.Transparent;
            btnAddQuota.CheckButton = false;
            btnAddQuota.Checked = false;
            btnAddQuota.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAddQuota.CheckedForeColor = Color.White;
            btnAddQuota.CheckedImageTint = Color.White;
            btnAddQuota.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAddQuota.Content = "إضافة حصة";
            btnAddQuota.Cursor = Cursors.Hand;
            btnAddQuota.DialogResult = DialogResult.None;
            btnAddQuota.Dock = DockStyle.Top;
            btnAddQuota.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btnAddQuota.ForeColor = Color.Black;
            btnAddQuota.HoverBackground = Color.LightGray;
            btnAddQuota.HoveredImageTint = Color.White;
            btnAddQuota.HoverForeColor = Color.Black;
            btnAddQuota.HoverOutline = Color.Empty;
            btnAddQuota.Image = null;
            btnAddQuota.ImageAutoCenter = true;
            btnAddQuota.ImageExpand = new Point(0, 0);
            btnAddQuota.ImageOffset = new Point(0, 0);
            btnAddQuota.Location = new Point(0, 40);
            btnAddQuota.Name = "btnAddQuota";
            btnAddQuota.NormalBackground = Color.Transparent;
            btnAddQuota.NormalForeColor = Color.Black;
            btnAddQuota.NormalImageTint = Color.White;
            btnAddQuota.NormalOutline = Color.Empty;
            btnAddQuota.OutlineThickness = 0F;
            btnAddQuota.PressedBackground = Color.FromArgb(71, 137, 75);
            btnAddQuota.PressedForeColor = Color.White;
            btnAddQuota.PressedImageTint = Color.White;
            btnAddQuota.PressedOutline = Color.Empty;
            btnAddQuota.Rounding = new Padding(0);
            btnAddQuota.Size = new Size(150, 40);
            btnAddQuota.TabIndex = 1;
            btnAddQuota.TextOffset = new Point(0, 0);
            btnAddQuota.Click += btnAddQuota_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.Transparent;
            btnAddCustomer.CheckButton = false;
            btnAddCustomer.Checked = false;
            btnAddCustomer.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAddCustomer.CheckedForeColor = Color.White;
            btnAddCustomer.CheckedImageTint = Color.White;
            btnAddCustomer.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAddCustomer.Content = "إضافة عميل";
            btnAddCustomer.Cursor = Cursors.Hand;
            btnAddCustomer.DialogResult = DialogResult.None;
            btnAddCustomer.Dock = DockStyle.Top;
            btnAddCustomer.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btnAddCustomer.ForeColor = Color.Black;
            btnAddCustomer.HoverBackground = Color.LightGray;
            btnAddCustomer.HoveredImageTint = Color.White;
            btnAddCustomer.HoverForeColor = Color.Black;
            btnAddCustomer.HoverOutline = Color.Empty;
            btnAddCustomer.Image = null;
            btnAddCustomer.ImageAutoCenter = true;
            btnAddCustomer.ImageExpand = new Point(0, 0);
            btnAddCustomer.ImageOffset = new Point(0, 0);
            btnAddCustomer.Location = new Point(0, 0);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.NormalBackground = Color.Transparent;
            btnAddCustomer.NormalForeColor = Color.Black;
            btnAddCustomer.NormalImageTint = Color.White;
            btnAddCustomer.NormalOutline = Color.Empty;
            btnAddCustomer.OutlineThickness = 0F;
            btnAddCustomer.PressedBackground = Color.FromArgb(71, 137, 75);
            btnAddCustomer.PressedForeColor = Color.White;
            btnAddCustomer.PressedImageTint = Color.White;
            btnAddCustomer.PressedOutline = Color.Empty;
            btnAddCustomer.Rounding = new Padding(10, 10, 3, 3);
            btnAddCustomer.Size = new Size(150, 40);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.TextOffset = new Point(0, 0);
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Cairo", 28F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(751, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 85);
            lblTitle.TabIndex = 9;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(18, 18, 18);
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.Transparent;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.White;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 16;
            btnMinimize.Location = new Point(1120, 13);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 1;
            btnMinimize.TabStop = false;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnClose_MouseLeave;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(18, 18, 18);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 25;
            btnClose.Location = new Point(1160, 13);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(picClearSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Location = new Point(120, 24);
            pnlSearch.MaximumSize = new Size(200, 35);
            pnlSearch.MinimumSize = new Size(0, 35);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(0, 35);
            pnlSearch.TabIndex = 8;
            // 
            // picClearSearch
            // 
            picClearSearch.BackColor = Color.Transparent;
            picClearSearch.Cursor = Cursors.Hand;
            picClearSearch.IconChar = FontAwesome.Sharp.IconChar.X;
            picClearSearch.IconColor = Color.White;
            picClearSearch.IconFont = FontAwesome.Sharp.IconFont.Solid;
            picClearSearch.IconSize = 12;
            picClearSearch.Location = new Point(15, 14);
            picClearSearch.Name = "picClearSearch";
            picClearSearch.Size = new Size(12, 12);
            picClearSearch.SizeMode = PictureBoxSizeMode.AutoSize;
            picClearSearch.TabIndex = 13;
            picClearSearch.TabStop = false;
            picClearSearch.Visible = false;
            picClearSearch.Click += btnSrchClear_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(18, 18, 18);
            txtSearch.BackgroundColor = Color.FromArgb(18, 18, 18);
            txtSearch.BorderColor = Color.DimGray;
            txtSearch.BorderSize = 1;
            txtSearch.Content = "";
            txtSearch.FocusBackgroundColor = Color.FromArgb(18, 18, 18);
            txtSearch.FocusBorderColor = Color.FromArgb(71, 137, 75);
            txtSearch.Font = new Font("Cairo Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(0, 0);
            txtSearch.Margin = new Padding(4);
            txtSearch.MaximumSize = new Size(200, 35);
            txtSearch.MinimumSize = new Size(0, 35);
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(15, 10, 15, 0);
            txtSearch.PasswordChar = false;
            txtSearch.PlaceholderColor = Color.DimGray;
            txtSearch.PlaceholderText = "بحث عن..";
            txtSearch.RightToLeft = RightToLeft.Yes;
            txtSearch.Rounding = new Padding(18);
            txtSearch.Size = new Size(200, 35);
            txtSearch.TabIndex = 6;
            txtSearch.TextOffset = new Size(0, 0);
            txtSearch.UnderlinedStyle = false;
            txtSearch.ContentChanged += txtSearch_ContentChanged;
            // 
            // pnlNavBtns
            // 
            pnlNavBtns.Controls.Add(btnAdd);
            pnlNavBtns.Controls.Add(btnRefresh);
            pnlNavBtns.Controls.Add(btnSearch);
            pnlNavBtns.Location = new Point(15, 24);
            pnlNavBtns.Name = "pnlNavBtns";
            pnlNavBtns.Size = new Size(105, 35);
            pnlNavBtns.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(18, 18, 18);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Dock = DockStyle.Right;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 20;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(35, 35);
            btnAdd.TabIndex = 2;
            btnAdd.TabStop = false;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(18, 18, 18);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Dock = DockStyle.Right;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 20;
            btnRefresh.Location = new Point(35, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(35, 35);
            btnRefresh.TabIndex = 3;
            btnRefresh.TabStop = false;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(18, 18, 18);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Dock = DockStyle.Right;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Transparent;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 20;
            btnSearch.Location = new Point(70, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(35, 35);
            btnSearch.TabIndex = 7;
            btnSearch.TabStop = false;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmDrag
            // 
            frmDrag.TargetControl = pnlNavBar;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Transparent;
            pnlMenu.Controls.Add(btnSettings);
            pnlMenu.Controls.Add(lblSettings);
            pnlMenu.Controls.Add(btnInfo);
            pnlMenu.Controls.Add(lblInfo);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(btnSta);
            pnlMenu.Controls.Add(lblStatistics);
            pnlMenu.Controls.Add(lblHome);
            pnlMenu.Controls.Add(circle);
            pnlMenu.Controls.Add(btnMode);
            pnlMenu.Dock = DockStyle.Right;
            pnlMenu.Location = new Point(1100, 83);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(100, 592);
            pnlMenu.TabIndex = 1;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            btnSettings.IconColor = Color.White;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSettings.IconSize = 25;
            btnSettings.Location = new Point(38, 391);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(25, 25);
            btnSettings.SizeMode = PictureBoxSizeMode.CenterImage;
            btnSettings.TabIndex = 21;
            btnSettings.TabStop = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Font = new Font("Cairo", 8F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettings.ForeColor = Color.White;
            lblSettings.Location = new Point(32, 431);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(36, 15);
            lblSettings.TabIndex = 20;
            lblSettings.Text = "الإعدادات";
            lblSettings.Visible = false;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Transparent;
            btnInfo.Cursor = Cursors.Hand;
            btnInfo.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnInfo.IconColor = Color.White;
            btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInfo.IconSize = 25;
            btnInfo.Location = new Point(38, 308);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(25, 25);
            btnInfo.SizeMode = PictureBoxSizeMode.CenterImage;
            btnInfo.TabIndex = 19;
            btnInfo.TabStop = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Cairo", 8F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(27, 348);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(46, 15);
            lblInfo.TabIndex = 18;
            lblInfo.Text = "فريق العمل";
            lblInfo.Visible = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.Cursor = Cursors.Hand;
            btnHome.ForeColor = Color.FromArgb(18, 18, 18);
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.FromArgb(18, 18, 18);
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 25;
            btnHome.Location = new Point(38, 140);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(25, 25);
            btnHome.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHome.TabIndex = 17;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnSta
            // 
            btnSta.BackColor = Color.Transparent;
            btnSta.Cursor = Cursors.Hand;
            btnSta.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btnSta.IconColor = Color.White;
            btnSta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSta.IconSize = 25;
            btnSta.Location = new Point(38, 225);
            btnSta.Name = "btnSta";
            btnSta.Size = new Size(25, 25);
            btnSta.SizeMode = PictureBoxSizeMode.CenterImage;
            btnSta.TabIndex = 16;
            btnSta.TabStop = false;
            btnSta.Click += btnSta_Click;
            // 
            // lblStatistics
            // 
            lblStatistics.AutoSize = true;
            lblStatistics.Font = new Font("Cairo", 8F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStatistics.ForeColor = Color.White;
            lblStatistics.Location = new Point(29, 265);
            lblStatistics.Name = "lblStatistics";
            lblStatistics.Size = new Size(42, 15);
            lblStatistics.TabIndex = 13;
            lblStatistics.Text = "استعلامات";
            lblStatistics.Visible = false;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Cairo", 8F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(33, 180);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(34, 15);
            lblHome.TabIndex = 10;
            lblHome.Text = "الرئيسية";
            // 
            // circle
            // 
            circle.Location = new Point(25, 128);
            circle.Margin = new Padding(2, 4, 2, 4);
            circle.Name = "circle";
            circle.OutlineColor = Color.Empty;
            circle.OutlineThickness = 1;
            circle.PanelColor = Color.White;
            circle.Size = new Size(50, 49);
            circle.TabIndex = 12;
            // 
            // btnMode
            // 
            btnMode.BackColor = Color.FromArgb(18, 18, 18);
            btnMode.Cursor = Cursors.Hand;
            btnMode.FlatAppearance.BorderSize = 0;
            btnMode.FlatStyle = FlatStyle.Flat;
            btnMode.ForeColor = Color.Transparent;
            btnMode.IconChar = FontAwesome.Sharp.IconChar.Moon;
            btnMode.IconColor = Color.White;
            btnMode.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnMode.IconSize = 30;
            btnMode.Location = new Point(25, 530);
            btnMode.Name = "btnMode";
            btnMode.Size = new Size(50, 50);
            btnMode.TabIndex = 10;
            btnMode.TabStop = false;
            btnMode.UseVisualStyleBackColor = false;
            btnMode.Click += btnMode_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.Transparent;
            pnlContainer.ForeColor = Color.Transparent;
            pnlContainer.Location = new Point(10, 85);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.OutlineThickness = 1F;
            pnlContainer.PanelColor = Color.Transparent;
            pnlContainer.PanelOutlineColor = Color.Transparent;
            pnlContainer.Rounding = new Padding(25);
            pnlContainer.Size = new Size(1084, 580);
            pnlContainer.TabIndex = 2;
            // 
            // searchTimer
            // 
            searchTimer.Interval = 10;
            searchTimer.Tick += searchTimer_Tick;
            // 
            // menuTranstion
            // 
            menuTranstion.Interval = 10;
            menuTranstion.Tick += menuTranstion_Tick;
            // 
            // typingTimer
            // 
            typingTimer.Interval = 50;
            typingTimer.Tick += typingTimer_Tick;
            // 
            // addDropDownTimer
            // 
            addDropDownTimer.Interval = 10;
            addDropDownTimer.Tick += addDropDownTimer_Tick;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(5F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1200, 675);
            Controls.Add(pnlContainer);
            Controls.Add(pnlMenu);
            Controls.Add(pnlNavBar);
            Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 4, 2, 4);
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDashboard";
            Load += frmDashboard_Load;
            pnlNavBar.ResumeLayout(false);
            pnlUpdateCheck.ResumeLayout(false);
            pnlAddDropDown.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClearSearch).EndInit();
            pnlNavBtns.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Components.cuiFormRounder frmBorder;
        private Panel pnlNavBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private CuoreUI.cuiControlDrag frmDrag;
        private Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnAdd;
        private CuoreUI.Controls.cuiTextBox2 txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Label lblTitle;
        private FontAwesome.Sharp.IconButton btnMode;
        private CuoreUI.Controls.Shapes.cuiEllipse circle;
        private Label lblHome;
        private Label lblStatistics;
        private FontAwesome.Sharp.IconPictureBox btnSta;
        private FontAwesome.Sharp.IconPictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox btnInfo;
        private Label lblInfo;
        private FontAwesome.Sharp.IconPictureBox btnSettings;
        private Label lblSettings;
        private System.Windows.Forms.Timer menuTranstion;
        private System.Windows.Forms.Timer typingTimer;
        private CuoreUI.Controls.cuiButton btnAddCustomer;
        private CuoreUI.Controls.cuiButton btnAddQuota;
        private CuoreUI.Controls.cuiButton btnAddOwner;
        private System.Windows.Forms.Timer btnAddCustomerTimer;
        public FontAwesome.Sharp.IconButton btnRefresh;
        private Panel pnlNavBtns;
        private FontAwesome.Sharp.IconPictureBox picClearSearch;
        private Panel pnlUpdateCheck;
        private Label label1;
        public FontAwesome.Sharp.IconButton btnUpdateCheck;
        public CuoreUI.Controls.cuiBorder pnlContainer;
        public Panel pnlSearch;
        public System.Windows.Forms.Timer searchTimer;
        public CuoreUI.Controls.cuiBorder pnlAddDropDown;
        public System.Windows.Forms.Timer addDropDownTimer;
        public CuoreUI.Controls.cuiSpinner spUpdateCheck;
    }
}
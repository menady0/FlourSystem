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
            lblTitle = new Label();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            pnlSearch = new Panel();
            btnSrchClear = new FontAwesome.Sharp.IconButton();
            txtSearch = new CuoreUI.Controls.cuiTextBox2();
            cuiControlDrag1 = new CuoreUI.cuiControlDrag(components);
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
            pnlNavBar.SuspendLayout();
            pnlSearch.SuspendLayout();
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
            pnlNavBar.Controls.Add(lblTitle);
            pnlNavBar.Controls.Add(btnSearch);
            pnlNavBar.Controls.Add(btnRefresh);
            pnlNavBar.Controls.Add(btnAdd);
            pnlNavBar.Controls.Add(btnMinimize);
            pnlNavBar.Controls.Add(btnClose);
            pnlNavBar.Controls.Add(pnlSearch);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1200, 83);
            pnlNavBar.TabIndex = 0;
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
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(18, 18, 18);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Transparent;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 20;
            btnSearch.Location = new Point(82, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(30, 30);
            btnSearch.TabIndex = 7;
            btnSearch.TabStop = false;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(18, 18, 18);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 20;
            btnRefresh.Location = new Point(51, 33);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(30, 30);
            btnRefresh.TabIndex = 3;
            btnRefresh.TabStop = false;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(18, 18, 18);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 20;
            btnAdd.Location = new Point(20, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(30, 30);
            btnAdd.TabIndex = 2;
            btnAdd.TabStop = false;
            btnAdd.UseVisualStyleBackColor = false;
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
            pnlSearch.Controls.Add(btnSrchClear);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Location = new Point(114, 28);
            pnlSearch.MaximumSize = new Size(200, 35);
            pnlSearch.MinimumSize = new Size(0, 35);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(0, 35);
            pnlSearch.TabIndex = 8;
            // 
            // btnSrchClear
            // 
            btnSrchClear.BackColor = Color.Transparent;
            btnSrchClear.Cursor = Cursors.Hand;
            btnSrchClear.FlatAppearance.BorderSize = 0;
            btnSrchClear.FlatStyle = FlatStyle.Flat;
            btnSrchClear.ForeColor = Color.Transparent;
            btnSrchClear.IconChar = FontAwesome.Sharp.IconChar.X;
            btnSrchClear.IconColor = Color.White;
            btnSrchClear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSrchClear.IconSize = 10;
            btnSrchClear.Location = new Point(10, 6);
            btnSrchClear.Name = "btnSrchClear";
            btnSrchClear.Size = new Size(25, 25);
            btnSrchClear.TabIndex = 9;
            btnSrchClear.UseVisualStyleBackColor = false;
            btnSrchClear.Visible = false;
            btnSrchClear.Click += btnSrchClear_Click;
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
            txtSearch.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // cuiControlDrag1
            // 
            cuiControlDrag1.TargetControl = pnlNavBar;
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
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.Transparent;
            pnlContainer.ForeColor = Color.Transparent;
            pnlContainer.Location = new Point(10, 85);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.OutlineThickness = 1F;
            pnlContainer.PanelColor = Color.FromArgb(232, 237, 223);
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
            typingTimer.Interval = 75;
            typingTimer.Tick += typingTimer_Tick;
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
            pnlSearch.ResumeLayout(false);
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
        private CuoreUI.cuiControlDrag cuiControlDrag1;
        private Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnAdd;
        private CuoreUI.Controls.cuiBorder pnlContainer;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private CuoreUI.Controls.cuiTextBox2 txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Timer searchTimer;
        private Panel pnlSearch;
        private FontAwesome.Sharp.IconButton btnSrchClear;
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
    }
}
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
            cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            searchTimer = new System.Windows.Forms.Timer(components);
            pnlNavBar.SuspendLayout();
            pnlSearch.SuspendLayout();
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
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
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
            btnSearch.Size = new Size(25, 25);
            btnSearch.TabIndex = 7;
            btnSearch.TabStop = false;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
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
            btnRefresh.Size = new Size(25, 25);
            btnRefresh.TabIndex = 3;
            btnRefresh.TabStop = false;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
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
            btnAdd.Size = new Size(25, 25);
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
            btnMinimize.IconSize = 25;
            btnMinimize.Location = new Point(1113, 13);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
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
            btnClose.Size = new Size(25, 25);
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
            pnlMenu.Dock = DockStyle.Right;
            pnlMenu.Location = new Point(1100, 83);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(100, 592);
            pnlMenu.TabIndex = 1;
            // 
            // cuiBorder1
            // 
            cuiBorder1.BackColor = Color.Transparent;
            cuiBorder1.ForeColor = Color.Transparent;
            cuiBorder1.Location = new Point(10, 85);
            cuiBorder1.Name = "cuiBorder1";
            cuiBorder1.OutlineThickness = 1F;
            cuiBorder1.PanelColor = Color.FromArgb(232, 237, 223);
            cuiBorder1.PanelOutlineColor = Color.Transparent;
            cuiBorder1.Rounding = new Padding(25);
            cuiBorder1.Size = new Size(1080, 580);
            cuiBorder1.TabIndex = 2;
            // 
            // searchTimer
            // 
            searchTimer.Interval = 10;
            searchTimer.Tick += searchTimer_Tick;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(5F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1200, 675);
            Controls.Add(cuiBorder1);
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
        private CuoreUI.Controls.cuiBorder cuiBorder1;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private CuoreUI.Controls.cuiTextBox2 txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Timer searchTimer;
        private Panel pnlSearch;
        private FontAwesome.Sharp.IconButton btnSrchClear;
    }
}
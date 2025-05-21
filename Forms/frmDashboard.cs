using FontAwesome.Sharp;
using FlourSystem.Forms.User_Control;
using FlourSystem.Forms.ToastMessage;
using FlourSystem.Properties;
using FlourSystem.Forms.User_Control.ucHomeBtns;
using FlourSystem.Classes;
using FlourSystem.Classes.ToastClass;
using Timer = System.Windows.Forms.Timer;


namespace FlourSystem.Forms
{
    public partial class frmDashboard : Form
    {
        IconButton[] btns;
        IconPictureBox[] menu;
        Control[] redBtns;
        public frmDashboard()
        {
            InitializeComponent();
            btns = new IconButton[] { btnSearch, btnAdd, btnRefresh, btnHistory };
            redBtns = new Control[] { btnClose, picClearSearch };
            menu = new IconPictureBox[] { btnHome, btnSta, btnInfo, btnSettings };
            targetbtn = btnHome;
            targetLabel = lblHome;
        }
        private async void frmDashboard_Load(object sender, EventArgs e)
        {
            HoverEffect.Hover(
                btns,
                getHoverValue: ctrl => ThemeColors.Green,
                getDefaultValue: ctrl => Color.White,
                setValue: (ctrl, value) =>
                {
                    if (ctrl is IconButton btn)
                        btn.IconColor = value;
                },
                interpolate: HoverEffect.InterpolateColor,
                transitionDuration: 100
            );
            HoverEffect.Hover(
                redBtns,
                getDefaultValue: ctrl => Color.White,
                getHoverValue: ctrl => Color.Red,
                setValue: (ctrl, value) =>
                {
                    if (ctrl is IconButton btn)
                        btn.IconColor = value;
                    if (ctrl is IconPictureBox pic)
                        pic.IconColor = value;
                },
                interpolate: HoverEffect.InterpolateColor,
                transitionDuration: 100
            );
            HoverEffect.Hover(
                menu,
                getHoverValue: ctrl => ThemeColors.Green,
                getDefaultValue: ctrl => Color.White,
                setValue: (ctrl, value) =>
                {
                    if (ctrl is IconPictureBox pic)
                        pic.IconColor = value;
                    if (ctrl is IconPictureBox pic2 && pic2 == targetbtn)
                        pic2.IconColor = ThemeColors.LightForeColor;
                },
                interpolate: HoverEffect.InterpolateColor,
                transitionDuration: 100
            );

            CloseOpenedSearch(this);
            btnHome_Click(sender, e);
            ThemeManager.ApplyTheme();
            if (Settings.Default.DarkMode)
            {
                btnMode.IconChar = IconChar.Sun;
                btnMode.IconColor = Color.FromArgb(245, 203, 92);
            }
            else
            {
                btnMode.IconChar = IconChar.Moon;
                btnMode.IconColor = Color.White;
            }

            await CheckUpdates.CheckForUpdatesAsync(newUpdateAvaliable: true);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                form.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(18, 18, 18);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(18, 18, 18);
            btnClose.IconColor = Color.Red;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.White;
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            _ucHomeInstance?.RefreshData();
        }

        #region Search Button
        public bool srchExpanded = false;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchTimer.Start();
        }
        private void searchTimer_Tick(object sender, EventArgs e)
        {
            if (srchExpanded)
            {
                if (pnlSearch.Width > 0)
                {
                    pnlSearch.Width -= 10;
                }
                else
                {
                    searchTimer.Stop();
                    srchExpanded = false;
                }
            }
            else
            {
                if (pnlSearch.Width < pnlSearch.MaximumSize.Width)
                {
                    pnlSearch.Width += 10;
                }
                else
                {
                    searchTimer.Stop();
                    srchExpanded = true;
                    txtSearch.Focus();
                }
            }
        }
        void CloseOpenedSearch(Control control)
        {
            control.MouseDown += Form1_MouseDown;

            foreach (Control child in control.Controls)
                CloseOpenedSearch(child);
        }
        private void txtSearch_ContentChanged(object sender, EventArgs e)
        {
            picClearSearch.Visible = !string.IsNullOrEmpty(txtSearch.Content);
            if (_ucHomeInstance != null)
            {
                if (int.TryParse(txtSearch.Content, out int value))
                    _ucHomeInstance.FilterCustomersByID(txtSearch.Content);
                else
                    _ucHomeInstance.FilterCustomersByName(txtSearch.Content);
            }
        }
        private void btnSrchClear_Click(object sender, EventArgs e)
        {
            txtSearch.Content = string.Empty;
            txtSearch.Focus();
        }
        #endregion

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (!pnlSearch.Bounds.Contains(PointToClient(MousePosition)) && srchExpanded)
                searchTimer.Start();
            if (!pnlAddDropDown.Bounds.Contains(PointToClient(MousePosition)) && isAddDropDownExpanded)
                addDropDownTimer.Start();
            if (!pnlHistory.Bounds.Contains(PointToClient(MousePosition)) && isHistoryExpanded)
                historyTimer.Start();
            if (_ucHomeInstance != null && !_ucHomeInstance.pnlAddtionalDropDown.Bounds.Contains(PointToClient(MousePosition)) && _ucHomeInstance.isAddtionalDropDownExpanded)
                _ucHomeInstance.AdditionaldropDownTimer.Start();
        }

        private void LoadUserControl(UserControl uc)
        {
            if (pnlContainer.Controls.Count > 0)
            {
                UserControl? currentControl = pnlContainer.Controls[0] as UserControl;
                if (currentControl != null && currentControl.GetType() == uc.GetType())
                    return;
            }
            pnlContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            ThemeManager.ApplyUCTheme(uc);
            pnlContainer.Controls.Add(uc);
            AttachClickEvent(uc);
        }
        private void UserControl_Click(object? sender, EventArgs e)
        {
            if (srchExpanded)
                searchTimer.Start();

            if (isAddDropDownExpanded)
                addDropDownTimer.Start();
        }
        private void AttachClickEvent(Control control)
        {
            control.Click += UserControl_Click;

            foreach (Control child in control.Controls)
            {
                AttachClickEvent(child);
            }
        }

        int targetY;
        int transtionStep = 10;
        IconPictureBox targetbtn;
        Label? targetLabel;
        void selectedbtn(IconPictureBox selectedButton)
        {
            foreach (var btn in menu)
            {
                if (btn == selectedButton)
                {
                    targetbtn = btn;
                    targetY = btn.Location.Y + (btn.Height / 2) - (circle.Height / 2);
                    menuTranstion.Start();
                    targetLabel = GetAssociatedLabel(btn);
                }
                else
                {
                    Label? associatedLabel = GetAssociatedLabel(btn);
                    if (associatedLabel != null)
                    {
                        associatedLabel.Visible = false;
                    }
                    btn.BackColor = Color.FromArgb(18, 18, 18);
                    btn.IconColor = Color.White;
                }
                if (selectedButton == btnHome)
                {
                    pnlUpdateCheck.Visible = false;
                    pnlNavBtns.Visible = true;
                }
                else if (selectedButton == btnSettings)
                {
                    pnlNavBtns.Visible = false;
                    pnlUpdateCheck.Visible = true;
                }
                else
                {
                    pnlNavBtns.Visible = false;
                    pnlUpdateCheck.Visible = false;
                }
            }
        }
        private void menuTranstion_Tick(object sender, EventArgs e)
        {
            if (circle.Location.Y < targetY)
            {
                circle.Location = new Point(circle.Location.X, Math.Min(circle.Location.Y + transtionStep, targetY));
            }
            else if (circle.Location.Y > targetY)
            {
                circle.Location = new Point(circle.Location.X, Math.Max(circle.Location.Y - transtionStep, targetY));
            }
            else
            {
                menuTranstion.Stop();
                targetbtn.BackColor = Color.White;
                targetbtn.IconColor = Color.FromArgb(18, 18, 18);
                targetLabel.Visible = true;
            }
        }
        private Label? GetAssociatedLabel(IconPictureBox button)
        {
            if (button == btnHome) return lblHome;
            if (button == btnSta) return lblStatistics;
            if (button == btnInfo) return lblInfo;
            if (button == btnSettings) return lblSettings;
            return null;
        }

        #region Side Menu Buttons
        ucHome? _ucHomeInstance;
        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadTitle("الرئيسية");
            selectedbtn(btnHome);
            if (_ucHomeInstance == null)
                _ucHomeInstance = new ucHome(this);
            LoadUserControl(_ucHomeInstance);
        }
        //ucStatistaics _ucStatistaics;
        private void btnSta_Click(object sender, EventArgs e)
        {
            LoadTitle("الاستعلامات");
            selectedbtn(btnSta);
            //if (_ucStatistaics == null)
            //_ucStatistaics = new ucStatistaics();
            LoadUserControl(new ucStatistaics());
        }
        ucTeam? _ucTeamInstance;
        private void btnInfo_Click(object sender, EventArgs e)
        {
            LoadTitle("فريق العمل");
            selectedbtn(btnInfo);
            if (_ucTeamInstance == null)
                _ucTeamInstance = new ucTeam();
            LoadUserControl(_ucTeamInstance);
        }
        ucSettings? _ucSettings;
        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadTitle("الإعدادات");
            selectedbtn(btnSettings);
            if (_ucSettings == null)
                _ucSettings = new ucSettings();
            LoadUserControl(_ucSettings);
        }
        #endregion

        int counter;
        string currentTitle = "";
        void LoadTitle(string title)
        {
            if (currentTitle == title) return;

            lblTitle.Text = "";
            counter = 0;
            currentTitle = title;
            typingTimer.Start();
        }
        private void typingTimer_Tick(object sender, EventArgs e)
        {
            if (counter < currentTitle.Length)
            {
                lblTitle.Text += currentTitle[counter];
                counter++;
            }
            else
                typingTimer.Stop();
        }


        public bool isAddDropDownExpanded = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAddDropDown.Parent = this;
            pnlAddDropDown.BringToFront();
            addDropDownTimer.Start();
        }
        private void addDropDownTimer_Tick(object sender, EventArgs e)
        {
            if (isAddDropDownExpanded)
            {
                if (pnlAddDropDown.Height > 0)
                {
                    pnlAddDropDown.Height -= 5;
                }
                else
                {
                    addDropDownTimer.Stop();
                    isAddDropDownExpanded = false;
                }
            }
            else
            {
                if (pnlAddDropDown.Height < pnlAddDropDown.MaximumSize.Height)
                {
                    pnlAddDropDown.Height += 5;
                }
                else
                {
                    addDropDownTimer.Stop();
                    isAddDropDownExpanded = true;
                }
            }
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme();
            Settings.Default.DarkMode = ThemeManager.IsDarkMode;
            Settings.Default.Save();
            if (ThemeManager.IsDarkMode)
            {
                btnMode.IconChar = IconChar.Sun;
                btnMode.IconColor = Color.FromArgb(245, 203, 92);
            }
            else
            {
                btnMode.IconChar = IconChar.Moon;
                btnMode.IconColor = Color.White;
            }

            if (_ucHomeInstance != null)
            {
                _ucHomeInstance.Dispose();
                _ucHomeInstance = null;
            }

            _ucHomeInstance = new ucHome(this);

            if (lblHome.Visible)
                LoadUserControl(_ucHomeInstance);

            ThemeManager.ApplyTheme();
        }
        #region Add Buttons
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addDropDownTimer.Start();
            new frmAddCustomer(this).ShowDialog();
        }
        private void btnAddQuota_Click(object sender, EventArgs e)
        {
            addDropDownTimer.Start();
            new frmAddQuota().ShowDialog();
        }
        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            addDropDownTimer.Start();
            new frmAddOwner().ShowDialog();
        }
        #endregion
        public void AttachGlobalMouseHandler(Form form)
        {
            form.MouseDown -= Form1_MouseDown;
            form.MouseDown += Form1_MouseDown;

            foreach (Control ctrl in form.Controls)
                AttachMouseDownToControl(ctrl);
        }

        private void AttachMouseDownToControl(Control control)
        {
            control.MouseDown -= Form1_MouseDown;
            control.MouseDown += Form1_MouseDown;

            foreach (Control child in control.Controls)
                AttachMouseDownToControl(child);
        }
        private async void btnUpdateCheck_Click(object sender, EventArgs e)
        {
            spUpdateCheck.Visible = true;
            await CheckUpdates.CheckForUpdatesAsync(true);
            spUpdateCheck.Visible = false;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            pnlHistory.Parent = this;
            pnlHistory.BringToFront();
            historyTimer.Start();
            DisplayYears();
        }
        private FlowLayoutPanel? expandingPanel;
        IconPictureBox? arrowIcon;
        bool isExpanding = true;
        bool yearsDisplayed = false;

        void DisplayYears()
        {
            if (yearsDisplayed) return;
            yearsDisplayed = true;

            pnlHistoryContainer.Controls.Clear();

            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            (int firstYear, int firstMonth) = DataBase.GetFirstOperationDate();
            if (firstYear == 0)
            {
                Toast.Show("لا توجد بيانات سابقة", ToastType.Info);
                return;
            }
            for (int i = currentYear; i >= firstYear; i--)
            {
                FlowLayoutPanel pnlYear = new FlowLayoutPanel
                {
                    Name = $"year{i}",
                    Width = 300,
                    Height = 35,
                    Font = new Font("Cairo", 10),
                    Padding = new Padding(0),
                    Margin = new Padding(0),
                    RightToLeft = RightToLeft.Yes,
                    FlowDirection = FlowDirection.TopDown,
                    Tag = i,
                    BackColor = Color.FromArgb(232, 232, 232),
                    MaximumSize = new Size(300, 155),
                    MinimumSize = new Size(300, 35),
                };
                // Year Header
                FlowLayoutPanel yearHeader = new FlowLayoutPanel
                {
                    Name = $"yearHeader{i}",
                    Width = 300,
                    Height = 35,
                    Font = new Font("Cairo", 10),
                    Padding = new Padding(10, 0, 10, 0),
                    Margin = new Padding(0),
                    RightToLeft = RightToLeft.Yes,
                    Tag = i,
                    BackColor = Color.FromArgb(227, 227, 227),
                    Cursor = Cursors.Hand,
                };
                IconPictureBox arrow = new IconPictureBox
                {
                    IconChar = IconChar.AngleLeft,
                    IconColor = ThemeManager.IsDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor,
                    IconSize = 16,
                    Width = 16,
                    Height = 35,
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Margin = new Padding(0),
                    Cursor = Cursors.Hand,
                };
                Label lblYear = new Label
                {
                    Text = i.ToString(),
                    RightToLeft = RightToLeft.Yes,
                    Height = 35,
                    Width = 100,
                    TextAlign = ContentAlignment.MiddleLeft,
                    ForeColor = ThemeManager.IsDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor,
                    Cursor = Cursors.Hand,
                };
                yearHeader.Controls.Add(arrow);
                yearHeader.Controls.Add(lblYear);
                // Month Container
                FlowLayoutPanel monthContainer = new FlowLayoutPanel
                {
                    Name = $"monthContainer{i}",
                    Width = 300,
                    Height = 120,
                    Font = new Font("Cairo", 10),
                    Padding = new Padding(0),
                    Margin = new Padding(0),
                    RightToLeft = RightToLeft.Yes,
                    Tag = i,
                    BackColor = Color.Transparent,
                    AutoScroll = true,
                    FlowDirection = FlowDirection.TopDown,

                };
                yearHeader.Click += (s, e) => YearHeader_Click(s, e);
                arrow.Click += (s, e) => YearHeader_Click(s, e);
                lblYear.Click += (s, e) => YearHeader_Click(s, e);
                // This is for testing
                Label lbl = new Label
                {
                    Text = "الشهر",
                    RightToLeft = RightToLeft.Yes,
                    Height = 35,
                    Width = 100,
                    TextAlign = ContentAlignment.MiddleLeft,
                    ForeColor = ThemeManager.IsDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor,
                    Cursor = Cursors.Hand,
                };
                monthContainer.Controls.Add(lbl);

                pnlYear.Controls.Add(yearHeader);
                pnlYear.Controls.Add(monthContainer);

                pnlHistoryContainer.Controls.Add(pnlYear);
            }
        }

        public bool isHistoryExpanded = false;
        private void historyTimer_Tick(object sender, EventArgs e)
        {
            if (isHistoryExpanded)
            {
                if (pnlHistory.Height > 0)
                {
                    pnlHistory.Height -= 20;
                }
                else
                {
                    historyTimer.Stop();
                    isHistoryExpanded = false;
                    foreach (FlowLayoutPanel yearPanel in pnlHistoryContainer.Controls.OfType<FlowLayoutPanel>())
                    {
                        if (yearPanel.Height > yearPanel.MinimumSize.Height)
                        {
                            yearPanel.Height = 35;

                            var arrowIcon = yearPanel.Controls
                                .OfType<FlowLayoutPanel>()
                                .FirstOrDefault(y => y.Name.StartsWith("yearHeader"))
                                ?.Controls.OfType<IconPictureBox>().FirstOrDefault();

                            if (arrowIcon != null)
                                arrowIcon.Rotation = 0;
                        }
                    }
                }
            }
            else
            {
                if (pnlHistory.Height < pnlHistory.MaximumSize.Height)
                {
                    pnlHistory.Height += 20;
                }
                else
                {
                    historyTimer.Stop();
                    isHistoryExpanded = true;
                }
            }
        }

        private void yearTimer_Tick(object sender, EventArgs e)
        {
            if (expandingPanel == null || arrowIcon == null) return;

            if (isExpanding)
            {
                if (expandingPanel.Height < expandingPanel.MaximumSize.Height)
                {
                    expandingPanel.Height += 10;
                    arrowIcon.Rotation -= 7.5f;
                }
                else
                {
                    expandingPanel.Height = expandingPanel.MaximumSize.Height;
                    arrowIcon.Rotation = -90;
                    yearTimer.Stop();
                }
            }
            else
            {
                if (expandingPanel.Height > expandingPanel.MinimumSize.Height)
                {
                    expandingPanel.Height -= 10;
                    arrowIcon.Rotation += 7.5f;
                }
                else
                {
                    expandingPanel.Height = expandingPanel.MinimumSize.Height;
                    arrowIcon.Rotation = 0;
                    yearTimer.Stop();
                }
            }
        }
        void YearHeader_Click(object? sender, EventArgs e)
        {
            FlowLayoutPanel? header = sender is FlowLayoutPanel pnl
                ? pnl
                : (sender as Control)?.Parent as FlowLayoutPanel;

            if (header == null) return;

            if (header.Parent is FlowLayoutPanel parent && parent != null)
                expandingPanel = parent;
            else return;

            isExpanding = expandingPanel != null && expandingPanel.Height <= expandingPanel.MinimumSize.Height;

            arrowIcon = header.Controls.OfType<IconPictureBox>().FirstOrDefault();

            yearTimer.Start();

            FlowLayoutPanel? monthContainer = expandingPanel.Controls
                .OfType<FlowLayoutPanel>()
                .FirstOrDefault(m => m.Name.StartsWith("monthContainer"));

            if (monthContainer != null)
            {
                int year = (int)expandingPanel.Tag;
                DisplayMonths(monthContainer, year);
            }

        }
        void DisplayMonths(FlowLayoutPanel monthContainer, int year)
        {
            monthContainer.Controls.Clear();

            List<int> months = DataBase.GetMonthsForYear(year);

            foreach (int month in months)
            {
                int balance = DataBase.GetAmountPerKGForMonth(month, year);
                int sales = DataBase.GetStore(month, year);
                if (balance == 0) continue;
                FlowLayoutPanel pnlMonth = new FlowLayoutPanel
                {
                    Width = 300,
                    Height = 30,
                    Font = new Font("Cairo", 10),
                    Padding = new Padding(20, 0, 20, 0),
                    Margin = new Padding(0),
                    RightToLeft = RightToLeft.Yes,
                    BackColor = Color.Transparent,
                    Cursor = Cursors.Hand,
                };
                Label lblMonth = new Label
                {
                    Text = new DateTime(year, month, 1).ToString("MMMM", new System.Globalization.CultureInfo("ar-EG")),
                    AutoSize = false,
                    Height = 30,
                    Width = 80,
                    RightToLeft = RightToLeft.Yes,
                    Padding = new Padding(10, 0, 10, 0),
                    Font = new Font("Cairo", 10),
                    Cursor = Cursors.Hand,
                    ForeColor = ThemeManager.IsDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor,
                    BackColor = Color.Transparent,
                    Margin = new Padding(5, 0, 5, 0)
                };
                pnlMonth.Controls.Add(lblMonth);
                pnlMonth.Click += (s, e) => MonthClick(s, e, lblMonth.Text, year, balance, sales);
                lblMonth.Click += (s, e) => MonthClick(s, e, lblMonth.Text, year, balance, sales);


                monthContainer.Controls.Add(pnlMonth);
            }
        }
        void MonthClick(object? sender, EventArgs e, string monthName, int year, int balance, int sales)
        {
            Toast.Show($"شهر {monthName} - {year}: الرصيد [{balance}], المبيعات [{sales}]", ToastType.Info);
        }

        private void txtHistorySearch_TextChanged(object sender, EventArgs e)
        {
            Toast.Show("لا تزال ميزة البحث قيد التطوير...", ToastType.Info);
            txtHistorySearch.Focus();
        }
    }
}
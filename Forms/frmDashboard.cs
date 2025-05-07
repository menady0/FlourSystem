using FontAwesome.Sharp;
using FlourSystem.Forms.User_Control;
using FlourSystem.Properties;
using FlourSystem.Forms.User_Control.ucHomeBtns;
using FlourSystem.Classes;
using System.Runtime;
using System.Drawing.Drawing2D;
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
            btns = new IconButton[] { btnSearch, btnAdd, btnRefresh };
            redBtns = new Control[] { btnClose, picClearSearch };
            menu = new IconPictureBox[] { btnHome, btnSta, btnInfo, btnSettings };
            targetbtn = btnHome;
            targetLabel = lblHome;
        }
        private void frmDashboard_Load(object sender, EventArgs e)
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
            //ThemeManager.ApplyTheme();
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
        bool srchExpanded = false;
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
            if(!_ucHomeInstance.pnlAddtionalDropDown.Bounds.Contains(PointToClient(MousePosition)) && _ucHomeInstance.isAddtionalDropDownExpanded)
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


        bool isAddDropDownExpanded = false;
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
        private void btnUpdateCheck_Click(object sender, EventArgs e)
        {

        }
    }
}

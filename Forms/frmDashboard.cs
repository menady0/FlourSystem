using FontAwesome.Sharp;
using FlourSystem.Forms.User_Control;
namespace FlourSystem.Forms
{
    public partial class frmDashboard : Form
    {
        IconButton[] btns;
        IconPictureBox[] menu;
        public frmDashboard()
        {
            InitializeComponent();
            btns = new IconButton[] { btnSearch, btnAdd, btnRefresh, btnSrchClear };
            menu = new IconPictureBox[] { btnHome, btnSta, btnInfo, btnSettings };
            targetbtn = btnHome;
            targetLabel = lblHome;
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            AttachHoverEffect(btns);
            CloseOpenedSearch(this);
            btnHome_Click(sender, e);
            //ThemeManager.ApplyTheme();
        }
        private void AttachHoverEffect(IconButton[] buttons)
        {
            foreach (var button in buttons)
            {
                button.MouseEnter += Button_MouseEnter;
                button.MouseLeave += Button_MouseLeave;
            }
        }
        private void Button_MouseEnter(object? sender, EventArgs e)
        {
            IconButton? button = sender as IconButton;
            if (button != null)
            {
                button.BackColor = Color.FromArgb(18, 18, 18);
                button.IconColor = ThemeColors.Green;
            }
            if (button == btnSrchClear)
            {
                button.IconColor = Color.Red;
            }
        }
        private void Button_MouseLeave(object? sender, EventArgs e)
        {
            IconButton? button = sender as IconButton;
            if (button != null)
            {
                button.BackColor = Color.FromArgb(18, 18, 18);
                button.IconColor = Color.White;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        // Search Button
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
                }
            }
        }
        private void CloseOpenedSearch(Control control)
        {
            control.MouseDown += Form1_MouseDown;

            foreach (Control child in control.Controls)
                CloseOpenedSearch(child);
        }
        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (!pnlSearch.Bounds.Contains(PointToClient(MousePosition)) && srchExpanded)
                searchTimer.Start();
            if (!pnlAddDropDown.Bounds.Contains(PointToClient(MousePosition)) && isAddDropDownExpanded)
                addDropDownTimer.Start();
        }

        private void txtSearch_ContentChanged(object sender, EventArgs e)
        {
            btnSrchClear.Visible = !string.IsNullOrEmpty(txtSearch.Content);
        }

        private void btnSrchClear_Click(object sender, EventArgs e)
        {
            txtSearch.Content = string.Empty;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadTitle(0);
            selectedbtn(btnHome);
            LoadUserControl(new ucHome());
        }

        private void btnSta_Click(object sender, EventArgs e)
        {
            LoadTitle(1);
            selectedbtn(btnSta);
            LoadUserControl(new ucStatistaics());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            LoadTitle(2);
            selectedbtn(btnInfo);
            LoadUserControl(new ucTeam());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadTitle(3);
            selectedbtn(btnSettings);
            LoadUserControl(new ucSettings());
        }
        string[] menuNames = new string[] {
            "الرئيسية",
            "الاستعلامات",
            "فريق العمل",
            "الإعدادات"
        };
        int counter;
        int index = -1;
        void LoadTitle(int i)
        {
            if (index == i) return;

            lblTitle.Text = "";
            counter = 0;
            index = i;
            typingTimer.Start();
        }
        private void typingTimer_Tick(object sender, EventArgs e)
        {
            if (counter < menuNames[index].Length)
            {
                lblTitle.Text += menuNames[index][counter];
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
    }
}

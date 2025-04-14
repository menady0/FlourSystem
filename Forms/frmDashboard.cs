using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlourSystem.Forms
{
    public partial class frmDashboard : Form
    {
        IconButton[] btns;

        public frmDashboard()
        {
            InitializeComponent();
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            btns = new IconButton[] { btnSearch, btnAdd, btnRefresh, btnSrchClear };
            AttachHoverEffect(btns);
            CloseOpenedSearch(this);
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
        }

        private void txtSearch_ContentChanged(object sender, EventArgs e)
        {
            btnSrchClear.Visible = !string.IsNullOrEmpty(txtSearch.Content);
        }

        private void btnSrchClear_Click(object sender, EventArgs e)
        {
            txtSearch.Content = string.Empty;
        }
    }
}

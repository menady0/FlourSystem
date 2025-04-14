using CuoreUI.Controls;
using FlourSystem.Forms;
using FlourSystem.Properties;
using FontAwesome.Sharp;

namespace FlourSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlBar.BackColor = Color.FromArgb(15, 0, 0, 0);
            ThemeManager.ApplyTheme();
            if (Settings.Default.DarkMode)
                btnDarkMode.IconChar = IconChar.Sun;
            else
                btnDarkMode.IconChar = IconChar.Moon;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // --------- Remeber To Change the condition & UnComment this ↓ ---------
            //bool isValid = DataBase.login(txtUsername.Content, txtPassword.Text);
            bool isValid = true;
            if (isValid)
            {
                this.Hide();
                frmDashboard dashboard = new frmDashboard();
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtUsername.Content = "";
                txtPassword.Text = "";
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme();
            Settings.Default.DarkMode = ThemeManager.IsDarkMode;
            Settings.Default.Save();
            if (ThemeManager.IsDarkMode)
                btnDarkMode.IconChar = IconChar.Sun;
            else
                btnDarkMode.IconChar = IconChar.Moon;
        }
        private void btnDarkMode_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (ThemeManager.IsDarkMode)
                    btn.BackColor = Color.FromArgb(15, 0, 0, 0);
            }
        }
        private void btnDarkMode_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (ThemeManager.IsDarkMode)
                    btn.BackColor = Color.FromArgb(0, 0, 0, 0);
            }
        }
    }
}

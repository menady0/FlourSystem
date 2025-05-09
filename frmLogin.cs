using CuoreUI.Controls;
using FlourSystem.Forms;
using FlourSystem.Properties;
using FontAwesome.Sharp;
using BCrypt.Net;
using FlourSystem.Classes;

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
            ThemeManager.ApplyTheme();
            if (ThemeManager.IsDarkMode)
            {
                btnDarkMode.IconChar = IconChar.Sun;
                btnDarkMode.IconColor = Color.FromArgb(245, 203, 92);
            }
            else
            {
                btnDarkMode.IconChar = IconChar.Moon;
                btnDarkMode.IconColor = ThemeColors.LightForeColor;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static frmDashboard? dashboard;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Content) || string.IsNullOrEmpty(txtPassword.Content))
            {
                MessageBox.Show("Username or Password cannot be empty.");
                txtUsername.Focus();
                return;
            }

            string username = txtUsername.Content;
            string password = txtPassword.Content;

            // Logging In WITH Hashed Password
            // ---------------------------------------------------------------------
            string hashedPassword = DataBase.GetHashedPassword(username);
            bool isValid;
            try
            {
                isValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during password verification: {ex.Message}");
                return;
            }
            // ---------------------------------------------------------------------

            // Logging In WITHOUT Hashed Password
            // ---------------------------------------------------------------------
            //bool isValid = DataBase.login(txtUsername.Content, txtPassword.Content);
            //---------------------------------------------------------------------
            //isValid = true;
            if (isValid)
            {
                DataBase.loggedOwner = DataBase.retrieveOwnerID(username);
                DataBase.currentUsername = username;
                DataBase.currentPassword = password;
                this.Hide();
                dashboard = new frmDashboard();
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtUsername.Content = "";
                txtPassword.Content = "";
                txtUsername.Focus();
            }
        }

        #region Dark Mode Button
        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme();
            Settings.Default.DarkMode = ThemeManager.IsDarkMode;
            Settings.Default.Save();
            if (ThemeManager.IsDarkMode)
            {
                btnDarkMode.IconChar = IconChar.Sun;
                btnDarkMode.IconColor = Color.FromArgb(245, 203, 92);
            }
            else
            {
                btnDarkMode.IconChar = IconChar.Moon;
                btnDarkMode.IconColor = ThemeColors.LightForeColor;
            }
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
        #endregion
    }
}

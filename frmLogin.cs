using CuoreUI.Controls;
using FlourSystem.Forms;
using FlourSystem.Properties;
using FontAwesome.Sharp;
using BCrypt.Net;
using FlourSystem.Classes;
using FlourSystem.Classes.ToastClass;
using FlourSystem.Forms.ToastMessage;
using FlourSystem.Forms.User_Control;

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
            if (DateTime.Now.Day == 1 && Settings.Default.resetDate != DateTime.Now.Date)
            {
                ResetAllCustomersForNewMonth();

                Settings.Default.resetDate = DateTime.Now.Date;
                Settings.Default.Save();
            }

        }
        void ResetAllCustomersForNewMonth()
        {
            var customers = DataBase.CustomersList;

            int successCount = 0;
            int failCount = 0;

            foreach (var customer in customers)
            {
                if (customer.TryGetValue("CustomerID", out var idObj) &&
                    long.TryParse(idObj.ToString(), out long customerId) &&
                    customer.TryGetValue("numberOfPeople", out var numObj) &&
                    int.TryParse(numObj.ToString(), out int customerNum))
                {
                    if (ucHome.ResetCustomerValues(customerId, customerNum, false))
                        successCount++;
                    else
                        failCount++;
                }
            }

            Toast.Show($"تمت إعادة تعيين بيانات {successCount} عميل. ({failCount} فشل)", ToastType.Info);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                form.Close();
        }
        public static frmDashboard? dashboard;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Content) || string.IsNullOrEmpty(txtPassword.Content))
            {
                Toast.Show("لا يمكن أن يكون اسم المستخدم أو كلمة المرور فارغًا.", ToastType.Error);
                txtUsername.Focus();
                return;
            }

            string username = txtUsername.Content;
            string password = txtPassword.Content;

            // Logging In WITH Hashed Password
            // ---------------------------------------------------------------------
            string hashedPassword = DataBase.GetHashedPassword(username);
            if (string.IsNullOrEmpty(hashedPassword))
            {
                Toast.Show("اسم المستخدم غير موجود.", ToastType.Error);
                txtUsername.Content = "";
                txtPassword.Content = "";
                txtUsername.Focus();
                return;
            }
            bool isValid;
            try
            {
                isValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            }
            catch (Exception ex)
            {
                Toast.Show($"حدث خطأ أثناء التحقق من كلمة المرور: {ex.Message}", ToastType.Error);
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
                Toast.Show("اسم المستخدم أو كلمة المرور غير صحيحة", ToastType.Error);
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

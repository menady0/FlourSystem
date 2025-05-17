using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using BCrypt.Net;
using FlourSystem.Classes.ToastClass;
using FlourSystem.Forms.ToastMessage;
using FontAwesome.Sharp;

namespace FlourSystem.Forms.User_Control.ucHomeBtns
{
    public partial class frmAddOwner : Form
    {
        public frmAddOwner()
        {
            InitializeComponent();
            ThemeManager.ApplyFormTheme(this);
        }

        #region Closing
        bool closing = true;
        private void btnClose_Click(object sender, EventArgs e)
        {
            opacityTimer.Start();
        }
        private void opacityTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.25;
            }
            else
            {
                opacityTimer.Stop();
                closing = false;
                this.Close();
            }
        }
        private void frmAddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = closing;
        }
        #endregion

        #region Password & Confirm Password
        private void txtPassword_ContentChanged(object sender, EventArgs e)
        {
            picShowPassword.Visible = !string.IsNullOrEmpty(txtPassword.Content);
            if (string.IsNullOrEmpty(txtPassword.Content))
                txtPassword.PasswordChar = true;
        }
        private void picShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !txtPassword.PasswordChar;
            if(picShowPassword.IconChar == IconChar.EyeSlash)
                picShowPassword.IconChar = IconChar.Eye;
            else
                picShowPassword.IconChar = IconChar.EyeSlash;
        }

        private void txtConfirmPassword_ContentChanged(object sender, EventArgs e)
        {
            picShowConfirmPassword.Visible = !string.IsNullOrEmpty(txtConfirmPassword.Content);
            if (string.IsNullOrEmpty(txtConfirmPassword.Content))
                txtConfirmPassword.PasswordChar = true;
        }
        private void picShowConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = !txtConfirmPassword.PasswordChar;
            if (picConfirmPassword.IconChar == IconChar.EyeSlash)
                picConfirmPassword.IconChar = IconChar.Eye;
            else
                picConfirmPassword.IconChar = IconChar.EyeSlash;
        }
        #endregion


        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            if (
                string.IsNullOrEmpty(txtName.Content)
                || string.IsNullOrEmpty(txtUsername.Content)
                || string.IsNullOrEmpty(txtPassword.Content)
                || string.IsNullOrEmpty(txtConfirmPassword.Content)
                )
            {
                Toast.Show("يرجى تعبئة جميع الحقول.", ToastType.Error);
                return;
            }
            if(DataBase.OwnerExists(txtUsername.Content))
            {
                Toast.Show("اسم المستخدم موجود بالفعل.", ToastType.Error);
                txtUsername.Content = "";
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Content!= txtConfirmPassword.Content)
            {
                Toast.Show("كلمتا المرور غير متطابقتين.", ToastType.Error);
                txtConfirmPassword.Content = "";
                txtConfirmPassword.Focus();
                return;
            }
            #endregion

            string name = txtName.Content;
            string username = txtUsername.Content;
            string password = txtPassword.Content;
            string confirmPassword = txtConfirmPassword.Content;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            if (DataBase.AddOwner(name, username, hashedPassword))
            {
                Toast.Show("تم إضافة المالك بنجاح.", ToastType.Success);
                btnClose.PerformClick();
            }
            else Toast.Show("فشل إضافة المالك!", ToastType.Error);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            if (ThemeManager.IsDarkMode)
                btnClose.BackColor = Color.FromArgb(15, 0, 0, 0);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            if (ThemeManager.IsDarkMode)
                btnClose.BackColor = Color.FromArgb(0, 0, 0, 0);
        }
    }
}

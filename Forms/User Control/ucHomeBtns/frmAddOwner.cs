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
using BCrypt.Net;
using FontAwesome.Sharp;

namespace FlourSystem.Forms.User_Control.ucHomeBtns
{
    public partial class frmAddOwner : Form
    {
        public frmAddOwner()
        {
            InitializeComponent();
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
            if (picShowPassword.IconChar == IconChar.EyeSlash)
                picShowPassword.IconChar = IconChar.Eye;
            else
                picShowPassword.IconChar = IconChar.EyeSlash;
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
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(DataBase.OwnerExists(txtUsername.Content))
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Content = "";
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Content!= txtConfirmPassword.Content)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Owner added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClose.PerformClick();
            }
            else
                MessageBox.Show("Failed to add owner.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

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

        private void txtPassword_ContentChanged(object sender, EventArgs e)
        {
            picShowPassword.Visible = !string.IsNullOrEmpty(txtPassword.Content);
            if (string.IsNullOrEmpty(txtPassword.Content))
                txtPassword.PasswordChar = true;
        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !txtPassword.PasswordChar;
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
        }
    }
}

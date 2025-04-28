using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlourSystem.Forms.User_Control.ucHomeBtns
{
    public partial class frmAddQuota : Form
    {
        public frmAddQuota()
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
        private void frmAddQuota_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = closing;
        }
        #endregion

        private void txtAmount_ContentChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Content.ToString()) || !int.TryParse(txtAmount.Content, out _))
            {
                txtAmountPerKG.Content = "";
                txtPrice.Content = "";
                return;
            }
            txtAmountPerKG.Content = (int.Parse(txtAmount.Content) * 20).ToString();
            txtPrice.Content = (int.Parse(txtAmount.Content) * 56).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtAmount.Content) ||
                string.IsNullOrEmpty(txtAmountPerKG.Content) ||
                string.IsNullOrEmpty(txtPrice.Content)
                )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (
                !float.TryParse(txtAmount.Content, out _)
                && !int.TryParse(txtAmountPerKG.Content, out _)
                && !int.TryParse(txtPrice.Content, out _)
                )
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
            if (
                float.Parse(txtAmount.Content) <= 0
                || int.Parse(txtAmountPerKG.Content) <= 0
                || int.Parse(txtPrice.Content) <= 0
                )
            {
                MessageBox.Show("Please enter greater values than 0 values.");
                return;
            }

            float amount = float.Parse(txtAmount.Content);
            int amountPerKG = int.Parse(txtAmountPerKG.Content);
            int price = int.Parse(txtPrice.Content);
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            if (DataBase.QuotaExists(DataBase.loggedOwner, date))
            {
                MessageBox.Show("Quota already exists for today.");
                return;
            }

            if (DataBase.addQuota(amount, amountPerKG, price, date, DataBase.loggedOwner))
            {
                MessageBox.Show("Quota added successfully.");
                btnClose.PerformClick();
            }
            else MessageBox.Show("Failed to add quota.");


        }
    }
}

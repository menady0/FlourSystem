using CuoreUI.Controls;
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
    public partial class frmAddCustomer : Form
    {
        private frmDashboard _dashboard;
        public frmAddCustomer(frmDashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
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

        private void txtMembers_ContentChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtMembers.Content, out int value))
            {
                int quantity = value * 10;
                int price = value * 10 * 3;
                txtQuantity.Content = quantity.ToString();
                txtPrice.Content = price.ToString();
            }
            if (string.IsNullOrEmpty(txtMembers.Content))
            {
                txtQuantity.Content = "";
                txtPrice.Content = "";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            if (
                string.IsNullOrEmpty(txtCardID.Content) ||
                string.IsNullOrEmpty(txtName.Content) ||
                string.IsNullOrEmpty(txtMembers.Content) ||
                string.IsNullOrEmpty(txtPrice.Content) ||
                string.IsNullOrEmpty(txtQuantity.Content)
               )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            MessageBox.Show(txtCardID.Content);
            if (!long.TryParse(txtCardID.Content, out _))
            {
                MessageBox.Show("Please enter a valid number in the Card ID field.");
                txtCardID.Content = "";
                txtCardID.Focus();
                return;
            }
            else if (!int.TryParse(txtMembers.Content, out _))
            {
                MessageBox.Show("Please enter a valid number in the Members field.");
                txtMembers.Content = "";
                txtMembers.Focus();
                return;
            }
            else if (!int.TryParse(txtPrice.Content, out _))
            {
                MessageBox.Show("Please enter a valid number in the Price field.");
                txtPrice.Content = "";
                txtPrice.Focus();
                return;
            }
            else if (!int.TryParse(txtQuantity.Content, out _))
            {
                MessageBox.Show("Please enter a valid number in the Quantity field.");
                txtQuantity.Content = "";
                txtQuantity.Focus();
                return;
            }

            if (DataBase.CustomerExists(long.Parse(txtCardID.Content)))
            {
                MessageBox.Show("Customer with this Card ID already exists.");
                txtCardID.Content = "";
                txtCardID.Focus();
                return;
            }
            #endregion

            long cardID = long.Parse(txtCardID.Content);
            string name = txtName.Content;
            int members = int.Parse(txtMembers.Content);
            int quantity = int.Parse(txtQuantity.Content);
            int price = int.Parse(txtPrice.Content);
            int registration = 0;
            int delivered = 0;
            int customerIndex = 999;
            string renewalDate = DateTime.Now.ToString("yyyy-MM-dd");
            if (DataBase.AddCustomer(cardID, name, members, quantity, price, registration, delivered, renewalDate, customerIndex))
            {
                MessageBox.Show("Customer added successfully.");
                this.Close();

                _dashboard.btnRefresh.PerformClick();
            }
            else
            {
                MessageBox.Show("Failed to add customer.");
            }

        }
    }
}

using CuoreUI.Controls;
using FlourSystem.Classes.ToastClass;
using FlourSystem.Forms.ToastMessage;
using FlourSystem.Properties;

namespace FlourSystem.Forms.User_Control.ucHomeBtns
{
    public partial class frmAddCustomer : Form
    {
        private frmDashboard _dashboard;
        public frmAddCustomer(frmDashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
            ThemeManager.ApplyFormTheme(this);
        }
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
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
                int quantity = value * (Settings.Default.sack / 2);
                int price = quantity * (Settings.Default.price / Settings.Default.sack);
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
                Toast.Show("يرجى تعبئة جميع الحقول.", ToastType.Error);
                txtCardID.Focus();
                return;
            }

            if (!long.TryParse(txtCardID.Content, out _))
            {
                Toast.Show("يرجى إدخال رقم صالح في حقل رقم البطاقة.", ToastType.Error);
                txtCardID.Content = "";
                txtCardID.Focus();
                return;
            }
            else if (!int.TryParse(txtMembers.Content, out _))
            {
                Toast.Show("يرجى إدخال رقم صالح في حقل الأعضاء.", ToastType.Error);
                txtMembers.Content = "";
                txtMembers.Focus();
                return;
            }
            else if (!int.TryParse(txtPrice.Content, out _))
            {
                Toast.Show("يرجى إدخال رقم صالح في حقل السعر.", ToastType.Error);
                txtPrice.Content = "";
                txtPrice.Focus();
                return;
            }
            else if (!int.TryParse(txtQuantity.Content, out _))
            {
                Toast.Show("يرجى إدخال رقم صالح في حقل الكمية.", ToastType.Error);
                txtQuantity.Content = "";
                txtQuantity.Focus();
                return;
            }

            int count = DataBase.CustomerExists(long.Parse(txtCardID.Content));
            if ((btnAdd.Tag as string) != "update" && count > 0)
            {
                Toast.Show("يوجد عميل بنفس رقم البطاقة.", ToastType.Error);
                txtCardID.Content = "";
                txtCardID.Focus();
                return;
            }
            else if ((btnAdd.Tag as string) == "update" && count > 1)
            {
                Toast.Show("يوجد عميل بنفس رقم البطاقة.", ToastType.Error);
                txtCardID.Content = Tag as string;
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
            int delivered = quantity;
            int customerIndex = DataBase.RetrieveCustomerTable().Count;
            string renewalDate = DateTime.Now.ToString("yyyy-MM-dd");

            if ((btnAdd.Tag as string) == "update")
            {
                long originalID = int.Parse((string)Tag);
                if (DataBase.UpdateCustomer(originalID, cardID, name, members, quantity, price))
                {
                    this.FormClosed += (s, args) => _dashboard.btnRefresh.PerformClick();
                    btnClose.PerformClick();
                }
                else Toast.Show("فشل في تحديث بيانات العميل.", ToastType.Error);
            }
            else
            {
                if (DataBase.AddCustomer(cardID, name, members, quantity, price, registration, delivered, renewalDate, customerIndex))
                {
                    this.FormClosed += (s, args) => _dashboard.btnRefresh.PerformClick();
                    btnClose.PerformClick();
                }
                else Toast.Show("فشل في إضافة عميل جديد.", ToastType.Error);
            }

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

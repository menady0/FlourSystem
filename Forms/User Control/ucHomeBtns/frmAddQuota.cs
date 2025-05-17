using FlourSystem.Classes.ToastClass;
using FlourSystem.Forms.ToastMessage;

namespace FlourSystem.Forms.User_Control.ucHomeBtns
{
    public partial class frmAddQuota : Form
    {
        public frmAddQuota()
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
        private void frmAddQuota_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = closing;
        }
        #endregion

        private void txtAmount_ContentChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Content) || !float.TryParse(txtAmount.Content, out _))
            {
                txtAmountPerKG.Content = "";
                return;
            }
            txtAmountPerKG.Content = (float.Parse(txtAmount.Content) * 20).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtAmount.Content) ||
                string.IsNullOrEmpty(txtAmountPerKG.Content)
                )
            {
                Toast.Show("يرجى تعبئة جميع الحقول.", ToastType.Error);
                return;
            }
            if (
                !float.TryParse(txtAmount.Content, out _)
                && !int.TryParse(txtAmountPerKG.Content, out _)
                )
            {
                Toast.Show("إدخال غير صالح. يرجى إدخال أرقام صحيحة.", ToastType.Error);
                return;
            }
            if (
                float.Parse(txtAmount.Content) <= 0
                || int.Parse(txtAmountPerKG.Content) <= 0
                )
            {
                Toast.Show("يرجى إدخال قيم أكبر من 0.", ToastType.Error);
                return;
            }

            (int preMonth, int preYear) = DataBase.GetPreviousMonthYear(DateTime.Now.Month, DateTime.Now.Year);
            int prevMonthAmount = DataBase.GetAmountPerKGForMonth(preMonth, preYear) - DataBase.GetStore(preMonth, preYear);

            float amount = float.Parse(txtAmount.Content);
            int amountPerKG = int.Parse(txtAmountPerKG.Content);
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            if (DataBase.QuotaExists(DataBase.loggedOwner, date))
            {
                Toast.Show("تم استلام حصة اليوم بالفعل", ToastType.Info);
                return;
            }

            if (prevMonthAmount > 0)
            {
                Toast.Show(
                    "هل انت متأكد من الاستمرار؟\n" +
                    $"متبقي {prevMonthAmount} من الشهر الماضي"
                    , ToastType.YesNo, input =>
                {
                    if (input)
                    {
                        amountPerKG -= prevMonthAmount;
                        if (amountPerKG <= 0)
                        {
                            Toast.Show("يرجى إدخال قيمة أكبر من 0.", ToastType.Error);
                            return;
                        }
                        amount = amountPerKG / 20;
                        Toast.Show($"تم إضافة كمية: {amountPerKG}", ToastType.Info);
                    }
                    else
                        return;
                });
            }
            if (DataBase.addQuota(amount, amountPerKG, date, DataBase.loggedOwner))
            {
                Toast.Show("تم إضافة الحصة بنجاح", ToastType.Success);
                btnClose.PerformClick();
            }
            else Toast.Show("فشل إضافة الحصة", ToastType.Error);
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

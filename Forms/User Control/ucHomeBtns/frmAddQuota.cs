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
            #region Validation
            if (string.IsNullOrEmpty(txtAmount.Content) || string.IsNullOrEmpty(txtAmountPerKG.Content))
            {
                Toast.Show("يرجى تعبئة جميع الحقول.", ToastType.Error);
                txtAmount.Focus();
                return;
            }

            if (!float.TryParse(txtAmount.Content, out float amount) || !int.TryParse(txtAmountPerKG.Content, out int amountPerKG))
            {
                Toast.Show("إدخال غير صالح. يرجى إدخال أرقام صحيحة.", ToastType.Error);
                txtAmount.Focus();
                return;
            }

            if (amount <= 0 || amountPerKG <= 0)
            {
                Toast.Show("يرجى إدخال قيم أكبر من 0.", ToastType.Error);
                txtAmount.Focus();
                return;
            }

            if (amount > 74.5 || amountPerKG > 1490)
            {
                Toast.Show("الكمية المدخلة تتجاوز الحد الأقصى: 74.5 للكمية أو 1490 للكمية لكل كجم.", ToastType.Error);
                txtAmount.Focus();
                return;
            }

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            if (DataBase.QuotaExists(DataBase.loggedOwner, date))
            {
                Toast.Show("تم استلام حصة اليوم بالفعل", ToastType.Info);
                btnClose.PerformClick();
                return;
            }

            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            int currentMonthQuotas = DataBase.ReceivedQuotas(currentMonth, currentYear);
            if (currentMonthQuotas > 4)
            {
                Toast.Show("تم الوصول إلى الحد الأقصى للحصص لهذا الشهر (4 حصص).", ToastType.Error);
                return;
            }
            #endregion
            (int preMonth, int preYear) = DataBase.GetPreviousMonthYear(currentMonth, currentYear);
            int prevMonthAmount = DataBase.GetAmountPerKGForMonth(preMonth, preYear) - DataBase.GetStore(preMonth, preYear);
            int totalAmountPerKGCurrent = DataBase.GetAmountPerKGForMonth(currentMonth, currentYear);
            int totalStoreCurrent = DataBase.GetStore(currentMonth, currentYear);
            int currentMonthResidual = totalAmountPerKGCurrent - totalStoreCurrent;
            int totalResidual = prevMonthAmount + currentMonthResidual;

            if (totalResidual > 0)
            {
                Toast.Show(
                    $"هل أنت متأكد من الاستمرار؟\n" +
                    $"متبقي {totalResidual} من الحصص السابقة",
                    ToastType.YesNo, input =>
                    {
                        if (input)
                        {
                            amountPerKG -= totalResidual;
                            if (amountPerKG <= 0)
                            {
                                Toast.Show("الكمية المتبقية بعد الخصم غير كافية.", ToastType.Error);
                                return;
                            }
                            amount = amountPerKG / 20f;
                            Toast.Show($"تم تعديل الكمية إلى: {amountPerKG}", ToastType.Info);
                        }
                        else
                            return;

                        if (DataBase.addQuota(amount, amountPerKG, date, DataBase.loggedOwner))
                        {
                            Toast.Show("تم إضافة الحصة بنجاح", ToastType.Success);
                            btnClose.PerformClick();
                        }
                        else
                            Toast.Show("فشل إضافة الحصة", ToastType.Error);
                    });
            }
            else
            {
                if (DataBase.addQuota(amount, amountPerKG, date, DataBase.loggedOwner))
                {
                    Toast.Show("تم إضافة الحصة بنجاح", ToastType.Success);
                    btnClose.PerformClick();
                }
                else
                {
                    Toast.Show("فشل إضافة الحصة", ToastType.Error);
                }
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

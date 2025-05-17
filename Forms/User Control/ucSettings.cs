using CuoreUI.Controls;
using FlourSystem.Classes;
using FlourSystem.Classes.ToastClass;
using FlourSystem.Forms.ToastMessage;
using FlourSystem.Properties;
using FontAwesome.Sharp;

namespace FlourSystem.Forms.User_Control
{
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            // Update swtchLazyLoad.Checked Every Time You Change Anything in Design
            // Settings.Default.lazyLoading
            InitializeComponent();
            if (Settings.Default.lazyLoading)
            {
                txtBatchSize.Enabled = txtScrollThreshold.Enabled = true;
                pnlBatchSize.Cursor = Cursors.Default;
                pnlScrollThreHold.Cursor = Cursors.Default;
                //lazyLoadingSetting = true;
            }
            else
            {
                txtBatchSize.Enabled = txtScrollThreshold.Enabled = false;
                pnlBatchSize.Cursor = Cursors.No;
                pnlScrollThreHold.Cursor = Cursors.No;
                //lazyLoadingSetting = false;
            }
        }
        //bool lazyLoadingSetting;
        private void ucSettings_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme();

            if (Settings.Default.lazyLoading)
            {
                txtBatchSize.Enabled = txtScrollThreshold.Enabled = true;
                pnlBatchSize.Cursor = Cursors.Default;
                pnlScrollThreHold.Cursor = Cursors.Default;
            }
            else
            {
                txtBatchSize.Enabled = txtScrollThreshold.Enabled = false;
                pnlBatchSize.Cursor = Cursors.No;
                pnlScrollThreHold.Cursor = Cursors.No;
            }

            // Set the default values for the text boxes
            if (!string.IsNullOrEmpty(DataBase.currentUsername))
                txtName.PlaceholderText = DataBase.RetriveName(DataBase.currentUsername);
            txtUsername.PlaceholderText = DataBase.currentUsername;
            txtPassword.Content = DataBase.currentPassword;

            txtPrice.PlaceholderText = Settings.Default.price.ToString();
            txtQuantityPerPerson.PlaceholderText = Settings.Default.sack.ToString();

            txtBatchSize.PlaceholderText = Settings.Default.batchSize.ToString();
            txtScrollThreshold.PlaceholderText = Settings.Default.scrollThreshold.ToString();

            HoverEffect.Hover(
                new Control[] { pnlDelete, btnDelete },
                getDefaultValue: ctrl => Color.Transparent,
                getHoverValue: ctrl => Color.Red,
                setValue: (ctrl, value) =>
                {
                    if (ctrl is IconButton btn)
                    {
                        btn.BackColor = value;
                        btn.IconColor = value == Color.Transparent ? Color.Red : Color.White;
                    }
                    else if (ctrl is cuiBorder pnl)
                    {
                        pnl.PanelColor = value;
                        if (pnl == pnlDelete && btnDelete is IconButton btnInsidePanel)
                        {
                            btnInsidePanel.IconColor = value == Color.Transparent ? Color.Red : Color.White;
                        }
                    }
                },
                interpolate: HoverEffect.InterpolateColor,
                transitionDuration: 200
            );
        }
        private void pnlCheck_Click(object sender, EventArgs e)
        {
            picChecked.Visible = !picChecked.Visible;
            showPassword();
        }

        private void picChecked_Click(object sender, EventArgs e)
        {
            picChecked.Visible = false;
            showPassword();
        }
        void showPassword()
        {
            if (picChecked.Visible)
                txtPassword.PasswordChar = false;
            else
                txtPassword.PasswordChar = true;
        }
        #region TextBox Enter & Leave
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is cuiTextBox2 txt)
            {
                if (string.IsNullOrWhiteSpace(txt.Content))
                {
                    txt.Content = txt.PlaceholderText;
                }
            }
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is cuiTextBox2 txt)
            {
                if (txt.Content == txt.PlaceholderText)
                {
                    txt.Content = string.Empty;
                }
            }
        }
        #endregion

        private void cuiSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            txtBatchSize.Enabled = txtScrollThreshold.Enabled = swtchLazyLoad.Checked;

            Cursor cursorToSet = swtchLazyLoad.Checked ? Cursors.Default : Cursors.No;
            pnlBatchSize.Cursor = cursorToSet;
            pnlScrollThreHold.Cursor = cursorToSet;

            Settings.Default.lazyLoading = swtchLazyLoad.Checked;
            Settings.Default.Save();
        }

        void SaveChanges()
        {
            string? newUsername = null;
            string? newName = null;
            string? newPassword = null;

            int? price = null, quantityPerPerson = null, batchSize = null, scrollThreshold = null;

            bool invalidNumber = false;

            void ProcessControl(Control ctrl)
            {
                if (ctrl is cuiTextBox2 txt)
                {
                    string? content = txt.Content?.Trim();
                    if (string.IsNullOrWhiteSpace(content))
                        return;

                    switch (txt.Name)
                    {
                        case "txtUsername":
                            newUsername = content;
                            break;

                        case "txtName":
                            newName = content;
                            break;

                        case "txtPassword":
                            newPassword = content;
                            break;

                        case "txtPrice":
                            if (int.TryParse(content, out int p) && p != Settings.Default.price)
                                price = p;
                            else if (!int.TryParse(content, out _))
                                invalidNumber = true;
                            break;

                        case "txtQuantityPerPerson":
                            if (int.TryParse(content, out int q) && q != Settings.Default.sack)
                                quantityPerPerson = q;
                            else if (!int.TryParse(content, out _))
                                invalidNumber = true;
                            break;

                        case "txtBatchSize":
                            if (int.TryParse(content, out int b) && b != Settings.Default.batchSize)
                                batchSize = b;
                            else if (!int.TryParse(content, out _))
                                invalidNumber = true;
                            break;

                        case "txtScrollThreshold":
                            if (int.TryParse(content, out int s) && s != Settings.Default.scrollThreshold)
                                scrollThreshold = s;
                            else if (!int.TryParse(content, out _))
                                invalidNumber = true;
                            break;
                    }
                }

                foreach (Control child in ctrl.Controls)
                    ProcessControl(child);
            }

            ProcessControl(container);

            // Show error only once if needed
            if (invalidNumber)
            {
                Toast.Show("يرجى إدخال أرقام صحيحة في الحقول الرقمية.", ToastType.Error);
                return;
            }

            // Update database only once
            if (newUsername != null || newName != null || newPassword != null)
            {
                newPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                DataBase.UpdateOwner(DataBase.currentUsername, newUsername, newName, newPassword);
                if (newUsername != null)
                    DataBase.currentUsername = newUsername;
                if (newPassword != null)
                    DataBase.currentPassword = newPassword;
            }

            // Update settings only if values changed
            if (price.HasValue) Settings.Default.price = price.Value;
            if (quantityPerPerson.HasValue) Settings.Default.sack = quantityPerPerson.Value;
            if (batchSize.HasValue) Settings.Default.batchSize = batchSize.Value;
            if (scrollThreshold.HasValue) Settings.Default.scrollThreshold = scrollThreshold.Value;

            Settings.Default.Save();
            Toast.Show("تم حفظ التغييرات بنجاح.", ToastType.Success);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            btnSave.BackColor = pnlSave.PanelColor = pnlSave.PanelOutlineColor = ThemeColors.Green;

        }
        private void InputChanged(object sender, EventArgs e)
        {
            if (IsModified())
                btnSave.BackColor = pnlSave.PanelColor = pnlSave.PanelOutlineColor = Color.Gray;
            else
                btnSave.BackColor = pnlSave.PanelColor = pnlSave.PanelOutlineColor = ThemeColors.Green;
        }

        private bool IsModified()
        {
            return
                !string.IsNullOrEmpty(txtName.Content) ||
                txtUsername.Content != DataBase.currentUsername ||
                txtPassword.Content != DataBase.currentPassword ||
                txtBatchSize.Content != Settings.Default.batchSize.ToString() ||
                txtScrollThreshold.Content != Settings.Default.scrollThreshold.ToString() ||
                txtPrice.Content != Settings.Default.price.ToString() ||
                txtQuantityPerPerson.Content != Settings.Default.sack.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Toast.Show("هل أنت متأكد من رغبتك في حذف حسابك؟", ToastType.YesNo, async input =>
            {
                if (input)
                {
                    if (DataBase.CheckOwners())
                    {
                        Toast.Show("لا يمكنك حذف المالك الأخير.", ToastType.Error);
                        return;
                    }
                    DataBase.DeleteOwner(DataBase.currentUsername);
                    Toast.Show("تم حذف الحساب بنجاح. سيتم تسجيل خروجك.", ToastType.Success);
                    await Task.Delay(Toast.duration);
                    Application.Exit();
                }
            });
        }
    }
}

using FontAwesome.Sharp;
using FlourSystem.Properties;
using CuoreUI.Controls;
using FlourSystem.Forms;
using System.Diagnostics;
using FlourSystem.Forms.ToastMessage;

public class ThemeManager
{
    public static bool IsDarkMode
    {
        get { return Settings.Default.DarkMode; }
        set { Settings.Default.DarkMode = value; }
    }

    public static void ToggleTheme()
    {
        IsDarkMode = !IsDarkMode;
        ApplyTheme();
    }
    public static void ApplyTheme()
    {
        foreach (Form form in Application.OpenForms)
        {
            if (!form.Visible) continue;
            if (form.Name == "frmDashboard")
            {
                var dashboard = form as frmDashboard;

                if (dashboard != null && dashboard.pnlContainer.Controls.Count > 0)
                {
                    UserControl? uc = dashboard.pnlContainer.Controls[0] as UserControl;
                    if (uc != null)
                    {
                        ApplyUCTheme(uc);
                    }
                    
                }
            }
            else if (form.Name == "Toast")
            {
                if (IsDarkMode)
                {
                    form.BackColor = ThemeColors.DarkBackground;
                    form.ForeColor = ThemeColors.DarkForeColor;
                }
                else
                {
                    form.BackColor = ThemeColors.LightBackground;
                    form.ForeColor = ThemeColors.LightForeColor;
                }
            }
            else
                ApplyFormTheme(form);
        }
    }
    public static void ApplyUCTheme(UserControl uc)
    {
        cuiBorder? parent = uc.Controls[0] as cuiBorder;
        if(parent == null)
        {
            MessageBox.Show("parent is null");
            return;
        }

        if (IsDarkMode)
        {
            parent.PanelColor = ThemeColors.UserControlBG;
            parent.ForeColor = ThemeColors.DarkForeColor;
        }
        else
        {
            parent.PanelColor = ThemeColors.LightBackground;
            parent.ForeColor = ThemeColors.LightForeColor;
        }
        foreach (Control control in parent.Controls)
        {
            ApplyControlTheme(control, IsDarkMode);
        }
    }
    public static void ApplyFormTheme(Form form)
    {
        if (IsDarkMode)
        {
            form.BackColor = ThemeColors.UserControlBG;
            form.ForeColor = ThemeColors.DarkForeColor;
        }
        else
        {
            form.BackColor = ThemeColors.LightBackground;
            form.ForeColor = ThemeColors.LightForeColor;
        }
        foreach (Control control in form.Controls)
        {
            ApplyControlTheme(control, IsDarkMode);
        }
    }
    public static void ApplyControlTheme(Control control, bool isDarkMode)
    {
        if (control is IconButton iconbtn)
        {
            if (control.Name != "btnDelete" && control.Name != "btnSave")
            {
                iconbtn.IconColor = isDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor;
                iconbtn.BackColor = Color.Transparent;
            }
        }
        else if (control is Button button)
        {
            button.BackColor = isDarkMode ? ThemeColors.Green : ThemeColors.DarkBackground;
            button.ForeColor = isDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightBackground;
        }
        else if (control is Label)
        {
            control.ForeColor = isDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor;
        }
        else if (control is cuiTextBox2 txt && txt.Name.Contains("input"))
        {
            txt.BackgroundColor = IsDarkMode ? ThemeColors.DarkTextbox : ThemeColors.LightBorderPanel;
            txt.BorderColor = IsDarkMode ? Color.FromArgb(5, 255, 255, 255) : Color.LightGray;
            txt.ForeColor = IsDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor;
            txt.FocusBackgroundColor = IsDarkMode ? ThemeColors.DarkTextbox : ThemeColors.LightBorderPanel;

        }
        else if (control is cuiTextBox2 cuiTextBox)
        {
            cuiTextBox.BackgroundColor = isDarkMode ? ThemeColors.DarkTextbox : ThemeColors.LightTextbox;
            cuiTextBox.ForeColor = isDarkMode ? ThemeColors.LightTextbox : ThemeColors.DarkTextbox;
            cuiTextBox.FocusBackgroundColor = cuiTextBox.BackgroundColor;
        }
        else if (control is IconPictureBox pic && pic.Name.Contains("picDrag"))
        {
            pic.BackColor = Color.Transparent;
        }
        else if (control is IconPictureBox pic2 && pic2.Name.Contains("link"))
        {
            pic2.BackColor = isDarkMode ? ThemeColors.DarkSocialMediaPanel : ThemeColors.LightSocialMediaPanel;
            pic2.IconColor = isDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor;
        }
        else if (control is IconPictureBox icon)
        {
            icon.BackColor = isDarkMode ? ThemeColors.DarkTextbox : ThemeColors.LightTextbox;
            icon.IconColor = IsDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor;
        }
        else if (control is Panel pnl)
        {
            if (pnl is cuiBorder border && pnl.GetType() == typeof(cuiBorder))
            {
                if (border.Name == "pnlDelete")
                    border.PanelColor = Color.Transparent;
                else if (border.Name == "pnlSave")
                    if (border.PanelColor == Color.Gray)
                        border.PanelColor = Color.Gray;
                    else
                        border.PanelColor = ThemeColors.Green;
                else if (border.Name.Contains("pnlSocialMedia"))
                    border.PanelColor = isDarkMode ? ThemeColors.DarkSocialMediaPanel : ThemeColors.LightSocialMediaPanel;
                else if (border.Name.Contains("pnlImageBorder"))
                    border.PanelOutlineColor = isDarkMode ? ThemeColors.LightBorderPanel : ThemeColors.DarkBorderPanel;
                else if (border.Name != "pnlAddtionalDropDown")
                {
                    border.PanelColor = isDarkMode ? ThemeColors.DarkBorderPanel : ThemeColors.LightBorderPanel;
                    border.PanelOutlineColor = isDarkMode ? ThemeColors.DarkBorderPanel : ThemeColors.LightBorderPanel;
                }
            }
            else if (pnl is FlowLayoutPanel flow && pnl.GetType() == typeof(FlowLayoutPanel))
            {
                if (pnl.Name == "pnlTableHeader")
                    pnl.BackColor = isDarkMode ? ThemeColors.DarkucHomeTableHeaderpnl : ThemeColors.LightucHomeTableHeaderpnl;
                else if (pnl.Name == "pnlCustomerContainer")
                    //pnl.BackColor = Color.Yellow;
                    pnl.BackColor = isDarkMode ? ThemeColors.UserControlBG : ThemeColors.LightBackground;
                if (pnl.Name == "pnlCustomer")
                    CustomerPanelTheme(pnl as FlowLayoutPanel);
            }
            if (pnl.Name == "separator")
                pnl.BackColor = isDarkMode ? Color.FromArgb(25, 255, 255, 255) : Color.FromArgb(25, 0, 0, 0);

            foreach (Control childControl in pnl.Controls)
            {
                ApplyControlTheme(childControl, isDarkMode);
            }
        }

    }
    static int index = 0;
    public static void CustomerPanelTheme(FlowLayoutPanel? panel)
    {
        if (panel == null) return;

        Color evenRowBackColor = IsDarkMode ? ThemeColors.DarkTextbox : ThemeColors.LightBorderPanel;
        Color normalBorderColor = IsDarkMode ? Color.FromArgb(5 ,255, 255, 255) : Color.LightGray;
        Color focusBorderColor = ThemeColors.Green;
        if (index % 2 == 0)
            panel.BackColor = evenRowBackColor;

        else
            panel.BackColor = Color.Transparent;

        index++;
    }
}


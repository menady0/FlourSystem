using FontAwesome.Sharp;
using FlourSystem.Properties;
using CuoreUI.Controls;

public static class ThemeManager
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
            ApplyFormTheme(form);
        }
    }
    private static void ApplyFormTheme(Form form)
    {
        if (IsDarkMode)
        {
            form.BackColor = ThemeColors.DarkBackground;
            form.ForeColor = ThemeColors.DarkForeColor;

            foreach (Control control in form.Controls)
            {
                ApplyControlTheme(control, true);
            }
        }
        else
        {
            form.BackColor = ThemeColors.LightBackground;
            form.ForeColor = ThemeColors.LightForeColor;

            foreach (Control control in form.Controls)
            {
                ApplyControlTheme(control, false);
            }
        }
    }

    private static void ApplyControlTheme(Control control, bool isDarkMode)
    {
        if (control is IconButton iconbtn)
        {
            iconbtn.IconColor = isDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor;
            iconbtn.BackColor = Color.Transparent;
        }
        else if (control is Button)
        {
            Button button = (Button)control;
            button.BackColor = isDarkMode ? ThemeColors.Green : ThemeColors.DarkBackground;
            button.ForeColor = isDarkMode ? ThemeColors.DarkForeColor : ThemeColors.DarkForeColor;
        }
        else if (control is Label)
        {
            control.ForeColor = isDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor;
        }
        else if (control is TextBox)
        {
            control.BackColor = isDarkMode ? ThemeColors.DarkTextbox : ThemeColors.LightTextbox;
        }
        else if ( control is cuiTextBox2 cuiTextBox)
        {
            cuiTextBox.BackgroundColor = isDarkMode ? ThemeColors.DarkTextbox : ThemeColors.LightTextbox;
            cuiTextBox.FocusBackgroundColor = cuiTextBox.BackgroundColor;
        }
        else if (control is IconPictureBox)
        {
            IconPictureBox icon = (IconPictureBox)control;
            icon.BackColor = isDarkMode ? ThemeColors.DarkTextbox : ThemeColors.LightTextbox;
            icon.IconColor = IsDarkMode ? ThemeColors.DarkForeColor : ThemeColors.LightForeColor;
        }
        else if (control is PictureBox)
        {
            if (isDarkMode) ChangeImage((PictureBox)control, ThemeColors.DarkTextBoxImage);
            else ChangeImage((PictureBox)control, ThemeColors.LightTextBoxImage);
        }

        else if (control is Panel)
        {
            Panel panel = (Panel)control;
            foreach (Control childControl in panel.Controls)
            {
                ApplyControlTheme(childControl, isDarkMode);
            }
        }
    }

    public static void ChangeImage(PictureBox pictureBox, string imageName)
    {
        try
        {
            pictureBox.Image = Resources.ResourceManager.GetObject(imageName) as Image;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading image: {ex.Message}");
        }
    }
}


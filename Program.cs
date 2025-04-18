using System.Diagnostics;
using System.Drawing.Text;

namespace FlourSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (!IsFontInstalled("Cairo"))
            {
                DialogResult result = MessageBox.Show(
                    "The 'Cairo' font is not installed on this system.\n\nClick OK to download it, or Cancel to exit.",
                    "Cairo Font Missing",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://www.deefont.com/cairo-font-family/",
                        UseShellExecute = true
                    });
                }
                return;
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
        static bool IsFontInstalled(string fontName)
        {
            using (InstalledFontCollection fontsCollection = new InstalledFontCollection())
            {
                return fontsCollection.Families.Any(f => f.Name.Equals(fontName, StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}
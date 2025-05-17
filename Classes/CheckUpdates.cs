using FlourSystem.Classes.ToastClass;
using FlourSystem.Forms.ToastMessage;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection;

namespace FlourSystem.Classes
{
    internal class CheckUpdates
    {
        public static async Task CheckForUpdatesAsync(bool upToDate = false, bool newUpdateAvaliable = false)
        {
            string updateUrl = "https://raw.githubusercontent.com/menady0/FlourSystem/main/update-info.json";

            try
            {
                using(HttpClient client = new HttpClient())
                {
                    string json = await client.GetStringAsync(updateUrl);
                    UpdateInfo? update = JsonConvert.DeserializeObject<UpdateInfo>(json); // 1.0.0.0 - GitHub

                    if (update != null && !string.IsNullOrEmpty(update.version))
                    {
                        Version? currentVersion = Assembly.GetExecutingAssembly().GetName().Version; // 0.1.0.0
                        Version latestVersion = new Version(update.version); // 1.0.0.0

                        if (newUpdateAvaliable && latestVersion > currentVersion)
                            Toast.Show("تحديث جديد متوفر!", ToastType.Info);
                        else if (latestVersion > currentVersion)
                        {
                            Toast.Show("يتوفر تحديث جديد!", ToastType.YesNo, input =>
                            {
                                if (input)
                                {
                                    Process.Start(new ProcessStartInfo
                                    {
                                        FileName = update.url,
                                        UseShellExecute = true
                                    });
                                    Application.Exit();
                                }
                            });
                        }
                        else if (upToDate) Toast.Show("أنت تستخدم أحدث إصدار.", ToastType.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update check failed: {ex.Message}");
            }
        }
        public class UpdateInfo
        {
            public string? version { get; set; }
            public string? url { get; set; }
            public string? changelog { get; set; }
        }
    }
}

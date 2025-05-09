using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlourSystem.Classes
{
    internal class CheckUpdates
    {
        public static readonly HttpClient client = new HttpClient();

        public static async Task CheckForUpdatesAsync(bool upToDate = false)
        {
            string updateUrl = "https://raw.githubusercontent.com/menady0/FlourSystem/main/update-info.json";

            try
            {
                string json = await client.GetStringAsync(updateUrl);
                UpdateInfo? update = JsonConvert.DeserializeObject<UpdateInfo>(json);

                if (update != null && !string.IsNullOrEmpty(update.version))
                {
                    Version? currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
                    Version latestVersion = new Version(update.version);

                    if (latestVersion > currentVersion)
                    {
                        DialogResult result = MessageBox.Show(
                            $"Update available!\n\n{update.changelog}\n\nDownload now?",
                            "Update",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information
                        );

                        if (result == DialogResult.Yes)
                        {
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = update.url,
                                UseShellExecute = true
                            });
                            Application.Exit();
                        }
                    }
                    else if (upToDate)
                        MessageBox.Show("You are using the latest version.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update check failed: " + ex.Message);
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

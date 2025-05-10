using FlourSystem.Forms.ToastMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlourSystem.Classes.ToastClass
{
    public static class ToastManager
    {
        private static List<Toast> activeToasts = new List<Toast>();
        private const int padding = 10;

        public static void Register(Toast toast)
        {
            activeToasts.Add(toast);
            Reposition();
        }

        public static void Unregister(Toast toast)
        {
            activeToasts.Remove(toast);
            Reposition();
        }
        public static Toast? IsDuplicate(string message)
        {
            return activeToasts.FirstOrDefault(t => t.Visible && t.Controls.OfType<Label>().Any(l => l.Text == message));
        }
        private static void Reposition()
        {
            int bottom = (Screen.PrimaryScreen?.WorkingArea.Bottom ?? 0) - padding;
            foreach (var toast in activeToasts.AsEnumerable().Reverse())
            {

                int newX = (Screen.PrimaryScreen?.WorkingArea.Width ?? 0) - toast.Width - padding;
                int newY = bottom - toast.Height;

                toast.TargetY = newY;

                bottom -= (toast.Height + padding);
            }
        }
    }

}

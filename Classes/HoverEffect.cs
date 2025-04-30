using System.Windows.Forms;
using System.Drawing;
using CuoreUI.Controls;

namespace FlourSystem.Classes
{
    public class HoverEffect
    {
        public static void Hover<T>(
            Control[] controls,
            Func<Control, T> getHoverValue,
            Func<Control, T> getDefaultValue,
            Action<Control, T> setValue,
            Func<T, T, double, T> interpolate,
            int transitionDuration = 300
        )
        {
            foreach (var control in controls)
            {
                // Track whether the cursor is inside the control
                bool isMouseInside = false;

                // Attach MouseEnter and MouseLeave to the control
                control.MouseEnter += (sender, e) =>
                {
                    if (!isMouseInside)
                    {
                        isMouseInside = true;
                        StartTransition(control, getDefaultValue(control), getHoverValue(control), setValue, interpolate, transitionDuration);
                    }
                };

                control.MouseLeave += (sender, e) =>
                {
                    if (isMouseInside && !IsMouseOverControl(control))
                    {
                        isMouseInside = false;
                        StartTransition(control, getHoverValue(control), getDefaultValue(control), setValue, interpolate, transitionDuration);
                    }
                };

                // Attach MouseEnter and MouseLeave to child controls (if any)
                foreach (Control child in control.Controls)
                {
                    child.MouseEnter += (sender, e) =>
                    {
                        if (!isMouseInside)
                        {
                            isMouseInside = true;
                            StartTransition(control, getDefaultValue(control), getHoverValue(control), setValue, interpolate, transitionDuration);
                        }
                    };

                    child.MouseLeave += (sender, e) =>
                    {
                        if (isMouseInside && !IsMouseOverControl(control))
                        {
                            isMouseInside = false;
                            StartTransition(control, getHoverValue(control), getDefaultValue(control), setValue, interpolate, transitionDuration);
                        }
                    };
                }
            }
        }

        private static void StartTransition<T>(
            Control control,
            T startValue,
            T targetValue,
            Action<Control, T> setValue,
            Func<T, T, double, T> interpolate,
            int transitionDuration)
        {
            System.Windows.Forms.Timer transitionTimer = new System.Windows.Forms.Timer { Interval = 15 };
            double progress = 0;

            transitionTimer.Tick += (s, e) =>
            {
                progress += (double)transitionTimer.Interval / transitionDuration;
                if (progress >= 1)
                {
                    setValue(control, targetValue);
                    transitionTimer.Stop();
                }
                else
                {
                    setValue(control, interpolate(startValue, targetValue, progress));
                }
            };

            transitionTimer.Start();
        }

        private static bool IsMouseOverControl(Control control)
        {
            return control.ClientRectangle.Contains(control.PointToClient(Cursor.Position));
        }

        public static Color InterpolateColor(Color start, Color end, double progress)
        {
            int r = (int)(start.R + (end.R - start.R) * progress);
            int g = (int)(start.G + (end.G - start.G) * progress);
            int b = (int)(start.B + (end.B - start.B) * progress);
            return Color.FromArgb(r, g, b);
        }

        public static int InterpolateInt(int start, int end, double progress)
        {
            return (int)(start + (end - start) * progress);
        }

        public static double InterpolateDouble(double start, double end, double progress)
        {
            return start + (end - start) * progress;
        }
    }
}

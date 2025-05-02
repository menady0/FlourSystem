using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace FlourSystem.Classes
{
    public class HoverEffectRefactored
    {
        private static Dictionary<Control, Timer> activeTimers = new();
        #region Easing Functions For Smooth Transitions
        /*
         // Linear (default)
         t => t;

         // Ease In (slow start)
         t => t * t;

         // Ease Out (fast start, slow end)
         t => 1 - Math.Pow(1 - t, 2);

         // Ease In-Out (smooth curve both ways)
         t => t * t * (3 - 2 * t);

         // Bounce (fun springy effect)
         t => {
            if (t < 0.5)
                return 4 * t * t * t;
            else
            {
                double f = ((2 * t) - 2);
                return 0.5 * f * f * f + 1;
            }
         };
        */
        #endregion
        public static void Hover<T>(
            Control control,
            Func<Control, T> getHoverValue,
            Func<Control, T> getDefaultValue,
            Action<Control, T> setValue,
            Func<T, T, double, T> interpolate,
            int transitionDuration = 300,
            Func<double, double>? easing = null
        )
        {
            bool isMouseInside = false;

            void StartHoverIn() =>
                StartTransition(control, getDefaultValue(control), getHoverValue(control), setValue, interpolate, transitionDuration, easing);

            void StartHoverOut() =>
                StartTransition(control, getHoverValue(control), getDefaultValue(control), setValue, interpolate, transitionDuration, easing);

            control.MouseEnter += (s, e) =>
            {
                if (!isMouseInside)
                {
                    isMouseInside = true;
                    StartHoverIn();
                }
            };

            control.MouseLeave += (s, e) =>
            {
                if (isMouseInside && !IsMouseOverControl(control))
                {
                    isMouseInside = false;
                    StartHoverOut();
                }
            };

            foreach (Control child in control.Controls)
            {
                child.MouseEnter += (s, e) =>
                {
                    if (!isMouseInside)
                    {
                        isMouseInside = true;
                        StartHoverIn();
                    }
                };

                child.MouseLeave += (s, e) =>
                {
                    if (isMouseInside && !IsMouseOverControl(control))
                    {
                        isMouseInside = false;
                        StartHoverOut();
                    }
                };
            }

        }

        public static void Hover<T>(
            Control[] controls,
            Func<Control, T> getHoverValue,
            Func<Control, T> getDefaultValue,
            Action<Control, T> setValue,
            Func<T, T, double, T> interpolate,
            int transitionDuration = 300,
            Func<double, double>? easing = null
        )
        {
            foreach (var control in controls)
            {
                Hover(control, getHoverValue, getDefaultValue, setValue, interpolate, transitionDuration, easing);
            }
        }

        private static void StartTransition<T>(
            Control control,
            T startValue,
            T targetValue,
            Action<Control, T> setValue,
            Func<T, T, double, T> interpolate,
            int transitionDuration,
            Func<double, double>? easing = null,
            Action? onComplete = null
        )
        {
            if (activeTimers.TryGetValue(control, out Timer? existingTimer))
            {
                existingTimer.Stop();
                activeTimers.Remove(control);
            }

            Timer timer = new() { Interval = 15 };
            double progress = 0;

            timer.Tick += (s, e) =>
            {
                progress += (double)timer.Interval / transitionDuration;
                double easedProgress = easing != null ? easing(progress) : progress;

                if (progress >= 1)
                {
                    setValue(control, targetValue);
                    timer.Stop();
                    activeTimers.Remove(control);
                    onComplete?.Invoke();
                }
                else
                {
                    setValue(control, interpolate(startValue, targetValue, easedProgress));
                }
            };

            activeTimers[control] = timer;
            timer.Start();
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

        public static void HoverWithChainedTransition<T1, T2>(
            Control control,
            Func<Control, T1> getHoverValue1,
            Func<Control, T1> getDefaultValue1,
            Action<Control, T1> setValue1,
            Func<T1, T1, double, T1> interpolate1,

            Control chainedControl,
            Func<Control, T2> getHoverValue2,
            Func<Control, T2> getDefaultValue2,
            Action<Control, T2> setValue2,
            Func<T2, T2, double, T2> interpolate2,

            int transitionDuration = 300,
            Func<double, double>? easing = null
        )
        {
            bool isMouseInside = false;
            bool chainedStarted = false;

            void StartHoverIn()
            {
                CancelTransition(control);
                CancelTransition(chainedControl);
                chainedStarted = false;

                StartTransition(control,
                    getDefaultValue1(control),
                    getHoverValue1(control),
                    setValue1,
                    interpolate1,
                    transitionDuration,
                    easing,
                    () =>
                    {
                        if (isMouseInside)
                        {
                            chainedStarted = true;
                            StartTransition(chainedControl,
                                getDefaultValue2(chainedControl),
                                getHoverValue2(chainedControl),
                                setValue2,
                                interpolate2,
                                transitionDuration,
                                easing);
                        }
                    });
            }

            void StartHoverOut()
            {
                CancelTransition(control);
                CancelTransition(chainedControl);

                if (chainedStarted)
                {
                    StartTransition(chainedControl,
                        getHoverValue2(chainedControl),
                        getDefaultValue2(chainedControl),
                        setValue2,
                        interpolate2,
                        transitionDuration,
                        easing,
                        () => StartTransition(control,
                            getHoverValue1(control),
                            getDefaultValue1(control),
                            setValue1,
                            interpolate1,
                            transitionDuration,
                            easing));
                }
                else
                {
                    StartTransition(control,
                        getHoverValue1(control),
                        getDefaultValue1(control),
                        setValue1,
                        interpolate1,
                        transitionDuration,
                        easing);
                }
            }

            void AttachHoverHandlers(Control target)
            {
                target.MouseEnter += (s, e) =>
                {
                    if (!isMouseInside)
                    {
                        isMouseInside = true;
                        StartHoverIn();
                    }
                };

                target.MouseLeave += (s, e) =>
                {
                    if (isMouseInside && !IsMouseOverControlRecursive(control))
                    {
                        isMouseInside = false;
                        StartHoverOut();
                    }
                };
            }

            AttachHoverHandlers(control);

            foreach (Control child in control.Controls)
                AttachHoverHandlers(child);
            foreach (Control child in chainedControl.Controls)
                AttachHoverHandlers(child);
        }

        public static void HoverWithChainedTransition<T1, T2>(
             Control[] parentControls,
             Func<Control, T1> getHoverValue1,
             Func<Control, T1> getDefaultValue1,
             Action<Control, T1> setValue1,
             Func<T1, T1, double, T1> interpolate1,

             Control[] chainedControls,
             Func<Control, T2> getHoverValue2,
             Func<Control, T2> getDefaultValue2,
             Action<Control, T2> setValue2,
             Func<T2, T2, double, T2> interpolate2,

             int transitionDuration = 300,
             Func<double, double>? easing = null
         )
        {
            if (parentControls.Length != chainedControls.Length)
                throw new ArgumentException("Parent and chained control arrays must have the same length.");

            for (int i = 0; i < parentControls.Length; i++)
            {
                var parent = parentControls[i];
                var chained = chainedControls[i];

                HoverWithChainedTransition(
                    parent,
                    getHoverValue1,
                    getDefaultValue1,
                    setValue1,
                    interpolate1,
                    chained,
                    getHoverValue2,
                    getDefaultValue2,
                    setValue2,
                    interpolate2,
                    transitionDuration,
                    easing
                );
            }
        }
        private static void CancelTransition(Control control)
        {
            if (activeTimers.TryGetValue(control, out Timer? timer))
            {
                timer.Stop();
                activeTimers.Remove(control);
            }
        }
        private static bool IsMouseOverControlRecursive(Control control)
        {
            Point mousePos = Cursor.Position;

            if (control.ClientRectangle.Contains(control.PointToClient(mousePos)))
                return true;

            foreach (Control child in control.Controls)
            {
                if (IsMouseOverControlRecursive(child))
                    return true;
            }

            return false;
        }
    }
}
public static class Easings
{
    public static double Linear(double t) => t;
    public static double EaseIn(double t) => t * t;
    public static double EaseOut(double t) => 1 - Math.Pow(1 - t, 2);
    public static double EaseInOut(double t) => t * t * (3 - 2 * t);
}

using CuoreUI.Components;
using FlourSystem.Classes;
using FlourSystem.Classes.ToastClass;
using FontAwesome.Sharp;

namespace FlourSystem.Forms.ToastMessage
{
    public partial class Toast : Form
    {
        private int screenX, screenY;
        public int TargetY { get; set; }
        private Action<bool>? yesNoCallback;
        public Toast(string message, ToastType type, Action<bool>? callback = null)
        {
            InitializeComponent();

            yesNoCallback = callback;
            Height = type == ToastType.YesNo ? 100 : 60;

            screenX = (Screen.PrimaryScreen?.WorkingArea.Width ?? 0) - Width - 20;
            screenY = (Screen.PrimaryScreen?.WorkingArea.Height ?? 0);
            TargetY = screenY - Height - 20;

            Location = new Point(screenX, screenY);
            PauseOnHover();


            lblMessage.Text = message;
            icon.IconChar = GetIcon(type);
            icon.IconColor = GetColor(type);
            pnlProgress.BackColor = GetColor(type);

            slideTimer.Tick += SlideIn;
            if (type == ToastType.YesNo)
            {
                pnlProgress.Visible = false;
                btnYes.Click += (s, e) => Respond(true);
                btnNo.Click += (s, e) => Respond(false);
                HoverEffect.Hover
                (
                    new Control[] { btnYes, btnNo },
                    getDefaultValue: ctrl => ctrl.Name == "btnYes" ? ThemeColors.Green : Color.Gray,
                    getHoverValue: ctrl => ctrl.Name == "btnYes" ? Color.Green : Color.Red,
                    setValue: (ctrl, value) => ctrl.BackColor = value,
                    interpolate: HoverEffect.InterpolateColor,
                    transitionDuration: 150
                );
            }
            else
                progressTimer.Start();

            slideTimer.Start();
            ToastManager.Register(this);
        }
        private void Respond(bool result)
        {
            yesNoCallback?.Invoke(result);
            slideTimer.Tick -= SlideIn;
            slideTimer.Tick += SlideOut;
            slideTimer.Start();
        }
        private void SlideIn(object? sender, EventArgs e)
        {
            if (Opacity < 1.0)
                Opacity += 0.05;

            if (Top > TargetY)
                Top -= 5;
            else
                Top = TargetY;
        }
        private void SlideOut(object? sender, EventArgs e)
        {
            if (Opacity > 0)
            {
                Opacity -= 0.05;
                Top += 5;
            }
            else
            {
                slideTimer.Stop();
                ToastManager.Unregister(this);
                Close();
            }
        }
        #region Get Color & Icon
        private Color GetColor(ToastType type)
        {
            return type switch
            {
                ToastType.Success => Color.FromArgb(0, 204, 104),
                ToastType.Info => Color.FromArgb(1, 104, 255),
                ToastType.Error => Color.FromArgb(250, 63, 100),
                ToastType.YesNo => Color.FromArgb(255, 106, 0),
                _ => Color.Gray
            };
        }
        private IconChar GetIcon(ToastType type)
        {
            return type switch
            {
                ToastType.Success => IconChar.FaceSmile,
                ToastType.Info => IconChar.CircleInfo,
                ToastType.Error => IconChar.FaceFrown,
                ToastType.YesNo => IconChar.CircleQuestion,
                _ => IconChar.Skull
            };
        }
        #endregion
        public static void Show(string message, ToastType type, Action<bool>? onYesNo = null)
        {
            Toast? duplicateToast = ToastManager.IsDuplicate(message);
            if (type != ToastType.YesNo && duplicateToast != null)
            {
                duplicateToast.ResetProgress();
                return;
            }

            Toast toast = new Toast(message, type, onYesNo);

            if (type == ToastType.YesNo)
                toast.ShowDialog();
            else
                toast.Show();
            //NativeMethods.ShowWindow(toast.Handle, 4);
        }


        public static int duration = 3000;
        int elapsed = 0;
        private bool isPaused = false;
        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (isPaused) return;

            elapsed += progressTimer.Interval;

            int remainingWidth = Width - (Width * elapsed / duration);
            pnlProgress.Width = Math.Max(remainingWidth, 0);

            if (elapsed >= duration)
            {
                progressTimer.Stop();
                slideTimer.Tick -= SlideIn;
                slideTimer.Tick += SlideOut;
            }
        }
        public void ResetProgress()
        {
            elapsed = 0;
            pnlProgress.Width = this.Width;
            if (!progressTimer.Enabled)
                progressTimer.Start();
        }
        private void PauseOnHover(Control? control = null)
        {
            this.MouseEnter += (s, e) => isPaused = true;
            this.MouseLeave += (s, e) => isPaused = false;
            if (control != null)
            {
                foreach (Control ctrl in control.Controls)
                {
                    ctrl.MouseEnter += (s, e) => isPaused = true;
                    ctrl.MouseLeave += (s, e) => isPaused = false;
                }
            }
            else
                foreach (Control ctrl in Controls)
                {
                    ctrl.MouseEnter += (s, e) => isPaused = true;
                    ctrl.MouseLeave += (s, e) => isPaused = false;
                    if (ctrl is Panel pnl)
                    {
                        PauseOnHover(pnl);
                    }
                }
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme();
        }

        #region Toast Focus
        //internal static class NativeMethods
        //{
        //    [DllImport("user32.dll")]
        //    public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        //}
        #endregion
    }
}

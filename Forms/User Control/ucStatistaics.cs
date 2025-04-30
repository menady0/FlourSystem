using CuoreUI.Controls;
using FlourSystem.Classes;

namespace FlourSystem.Forms.User_Control
{
    public partial class ucStatistaics : UserControl
    {
        int receivedQuota;
        int todayCards;
        int totalCards;

        //int balance;
        int todaySales;
        int totalSales;

        Control[] cards;
        public ucStatistaics()
        {
            InitializeComponent();

            int currentDay = DateTime.Now.Day;
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            receivedQuota = DataBase.ReceivedQuotas(currentMonth, currentYear);
            todayCards = DataBase.Cards(currentDay, currentMonth, currentYear);
            totalCards = DataBase.Cards(currentMonth, currentYear);

            DataBase.balance = DataBase.AmountPerKG(currentMonth, currentYear) - DataBase.Store(currentMonth, currentYear);
            todaySales = DataBase.Store(currentDay, currentMonth, currentYear);
            totalSales = DataBase.Store(currentMonth, currentYear);

            cards = new Control[]
            {
                lblReceivedQuota,
                receivedQuotalbl,
                pnlReceivedQuota,

                lblTodayCards,
                todayCardlbl,
                pnlTodayCard,

                lblTotalCards,
                totalCardslbl,
                pnlTotalCards,

                lblBalance,
                balancelbl,
                pnlBalance,

                lblTodaySales,
                todaySaleslbl,
                pnlTodaySale,

                lblTotalSales,
                totalSaleslbl,
                pnlTotalSales,
            };
        }

        private void ucStatistaics_Load(object sender, EventArgs e)
        {
            StartAllAnimations();

            // Use Instead To Display The Values Without Animation
            // ----------------------------------------------------
            //lblReceivedQuota.Text = receivedQuota.ToString();
            //lblTodayCards.Text = todayCards.ToString();
            //lblTotalCards.Text = totalCards.ToString();

            //lblBalance.Text = balance.ToString();
            //lblTodaySales.Text = todaySales.ToString();
            //lblTotalSales.Text = totalSales.ToString();
            // ----------------------------------------------------

            HoverEffect.Hover(
                cards,
                getHoverValue: ctrl => ThemeColors.Green,
                getDefaultValue: ctrl => Color.Transparent,
                setValue: (ctrl, value) =>
                {
                    if (ctrl is cuiBorder panel)
                        panel.PanelOutlineColor = value;
                },
                interpolate: HoverEffect.InterpolateColor,
                transitionDuration: 250
            );
        }

        private List<NumberAnimation> animations = new List<NumberAnimation>();
        private void StartAllAnimations()
        {
            animations = new List<NumberAnimation>
            {
                new NumberAnimation { TargetLabel = lblReceivedQuota, StartValue = 0, EndValue = receivedQuota, Duration = 750, StartTime = DateTime.Now },
                new NumberAnimation { TargetLabel = lblTodayCards, StartValue = 0, EndValue = todayCards, Duration = 1000, StartTime = DateTime.Now },
                new NumberAnimation { TargetLabel = lblTotalCards, StartValue = 0, EndValue = totalCards, Duration = 1000, StartTime = DateTime.Now },
                new NumberAnimation { TargetLabel = lblBalance, StartValue = 0, EndValue = DataBase.balance, Duration = 2000, StartTime = DateTime.Now },
                new NumberAnimation { TargetLabel = lblTodaySales, StartValue = 0, EndValue = todaySales, Duration = 2000, StartTime = DateTime.Now },
                new NumberAnimation { TargetLabel = lblTotalSales, StartValue = 0, EndValue = totalSales, Duration = 2000, StartTime = DateTime.Now },
            };

            timing.Start();
        }
        private void timing_Tick(object sender, EventArgs e)
        {
            bool anyActive = false;

            foreach (var anim in animations)
            {
                double elapsed = (DateTime.Now - anim.StartTime).TotalMilliseconds;
                double progress = Math.Min(elapsed / anim.Duration, 1.0);
                double easedProgress = EaseInOut(progress);

                int currentValue = (int)(anim.StartValue + (anim.EndValue - anim.StartValue) * easedProgress);
                anim.TargetLabel.Text = currentValue.ToString();

                if (progress < 1.0)
                    anyActive = true;
            }

            if (!anyActive)
            {
                timing.Stop();
                timing.Dispose();
            }
        }
        private double EaseInOut(double t)
        {
            return t < 0.5
                ? 4 * t * t * t
                : 1 - Math.Pow(-2 * t + 2, 3) / 2;
        }
    }
}
class NumberAnimation
{
    public required Label TargetLabel { get; set; }
    public int StartValue { get; set; }
    public int EndValue { get; set; }
    public int Duration { get; set; } // in ms
    public DateTime StartTime { get; set; }
}


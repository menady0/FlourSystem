using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlourSystem.Forms.User_Control
{
    public partial class ucStatistaics : UserControl
    {
        int receivedQuota;
        int todayCards;
        int totalCards;

        int balance;
        int todaySales;
        int totalSales;
        public ucStatistaics()
        {
            InitializeComponent();

            int currentDay = DateTime.Now.Day;
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            receivedQuota = DataBase.ReceivedQuotas(currentMonth, currentYear);
            todayCards = DataBase.Cards(currentDay, currentMonth, currentYear);
            totalCards = DataBase.Cards(currentMonth, currentYear);

            balance = DataBase.AmountPerKG(currentMonth, currentYear) - DataBase.Store(currentMonth, currentYear);
            todaySales = DataBase.Store(currentDay, currentMonth, currentYear);
            totalSales = DataBase.Store(currentMonth, currentYear);
        }

        private void ucStatistaics_Load(object sender, EventArgs e)
        {
            lblReceivedQuota.Text = receivedQuota.ToString();
            lblTodayCards.Text = todayCards.ToString();
            lblTotalCards.Text = totalCards.ToString();

            lblBalance.Text = balance.ToString();
            lblTodaySales.Text = todaySales.ToString();
            lblTotalSales.Text = totalSales.ToString();
        }
    }
}

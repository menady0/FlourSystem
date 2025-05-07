namespace FlourSystem.Forms.User_Control
{
    partial class ucStatistaics
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlRoundedContainer = new CuoreUI.Controls.cuiBorder();
            pnlTotalSales = new CuoreUI.Controls.cuiBorder();
            totalSaleslbl = new Label();
            lblTotalSales = new Label();
            pnlTotalCards = new CuoreUI.Controls.cuiBorder();
            totalCardslbl = new Label();
            lblTotalCards = new Label();
            pnlTodaySale = new CuoreUI.Controls.cuiBorder();
            todaySaleslbl = new Label();
            lblTodaySales = new Label();
            pnlBalance = new CuoreUI.Controls.cuiBorder();
            balancelbl = new Label();
            lblBalance = new Label();
            pnlTodayCard = new CuoreUI.Controls.cuiBorder();
            todayCardlbl = new Label();
            lblTodayCards = new Label();
            pnlReceivedQuota = new CuoreUI.Controls.cuiBorder();
            receivedQuotalbl = new Label();
            lblReceivedQuota = new Label();
            timing = new System.Windows.Forms.Timer(components);
            pnlRoundedContainer.SuspendLayout();
            pnlTotalSales.SuspendLayout();
            pnlTotalCards.SuspendLayout();
            pnlTodaySale.SuspendLayout();
            pnlBalance.SuspendLayout();
            pnlTodayCard.SuspendLayout();
            pnlReceivedQuota.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRoundedContainer
            // 
            pnlRoundedContainer.Controls.Add(pnlTotalSales);
            pnlRoundedContainer.Controls.Add(pnlTotalCards);
            pnlRoundedContainer.Controls.Add(pnlTodaySale);
            pnlRoundedContainer.Controls.Add(pnlBalance);
            pnlRoundedContainer.Controls.Add(pnlTodayCard);
            pnlRoundedContainer.Controls.Add(pnlReceivedQuota);
            pnlRoundedContainer.Dock = DockStyle.Fill;
            pnlRoundedContainer.Font = new Font("Cairo", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlRoundedContainer.Location = new Point(0, 0);
            pnlRoundedContainer.Margin = new Padding(3, 5, 3, 5);
            pnlRoundedContainer.Name = "pnlRoundedContainer";
            pnlRoundedContainer.OutlineThickness = 1F;
            pnlRoundedContainer.PanelColor = Color.FromArgb(232, 237, 223);
            pnlRoundedContainer.PanelOutlineColor = Color.Transparent;
            pnlRoundedContainer.Rounding = new Padding(25);
            pnlRoundedContainer.Size = new Size(1084, 580);
            pnlRoundedContainer.TabIndex = 0;
            // 
            // pnlTotalSales
            // 
            pnlTotalSales.Controls.Add(totalSaleslbl);
            pnlTotalSales.Controls.Add(lblTotalSales);
            pnlTotalSales.Location = new Point(67, 299);
            pnlTotalSales.Name = "pnlTotalSales";
            pnlTotalSales.OutlineThickness = 1F;
            pnlTotalSales.PanelColor = Color.FromArgb(216, 220, 208);
            pnlTotalSales.PanelOutlineColor = Color.Transparent;
            pnlTotalSales.Rounding = new Padding(10);
            pnlTotalSales.Size = new Size(300, 175);
            pnlTotalSales.TabIndex = 6;
            // 
            // totalSaleslbl
            // 
            totalSaleslbl.AutoSize = true;
            totalSaleslbl.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalSaleslbl.ForeColor = Color.Black;
            totalSaleslbl.Location = new Point(89, 130);
            totalSaleslbl.Name = "totalSaleslbl";
            totalSaleslbl.Size = new Size(123, 30);
            totalSaleslbl.TabIndex = 1;
            totalSaleslbl.Text = "إجمالي المبيعات";
            // 
            // lblTotalSales
            // 
            lblTotalSales.Font = new Font("Cairo Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = Color.Black;
            lblTotalSales.Location = new Point(25, 2);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(250, 125);
            lblTotalSales.TabIndex = 0;
            lblTotalSales.Text = "0";
            lblTotalSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTotalCards
            // 
            pnlTotalCards.Controls.Add(totalCardslbl);
            pnlTotalCards.Controls.Add(lblTotalCards);
            pnlTotalCards.Location = new Point(67, 106);
            pnlTotalCards.Name = "pnlTotalCards";
            pnlTotalCards.OutlineThickness = 1F;
            pnlTotalCards.PanelColor = Color.FromArgb(216, 220, 208);
            pnlTotalCards.PanelOutlineColor = Color.Transparent;
            pnlTotalCards.Rounding = new Padding(10);
            pnlTotalCards.Size = new Size(300, 175);
            pnlTotalCards.TabIndex = 3;
            // 
            // totalCardslbl
            // 
            totalCardslbl.AutoSize = true;
            totalCardslbl.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalCardslbl.ForeColor = Color.Black;
            totalCardslbl.Location = new Point(90, 130);
            totalCardslbl.Name = "totalCardslbl";
            totalCardslbl.Size = new Size(121, 30);
            totalCardslbl.TabIndex = 1;
            totalCardslbl.Text = "إجمالي البطاقات";
            // 
            // lblTotalCards
            // 
            lblTotalCards.Font = new Font("Cairo Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCards.ForeColor = Color.Black;
            lblTotalCards.Location = new Point(25, 2);
            lblTotalCards.Name = "lblTotalCards";
            lblTotalCards.Size = new Size(250, 125);
            lblTotalCards.TabIndex = 0;
            lblTotalCards.Text = "0";
            lblTotalCards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTodaySale
            // 
            pnlTodaySale.Controls.Add(todaySaleslbl);
            pnlTodaySale.Controls.Add(lblTodaySales);
            pnlTodaySale.Location = new Point(392, 299);
            pnlTodaySale.Name = "pnlTodaySale";
            pnlTodaySale.OutlineThickness = 1F;
            pnlTodaySale.PanelColor = Color.FromArgb(216, 220, 208);
            pnlTodaySale.PanelOutlineColor = Color.Transparent;
            pnlTodaySale.Rounding = new Padding(10);
            pnlTodaySale.Size = new Size(300, 175);
            pnlTodaySale.TabIndex = 5;
            // 
            // todaySaleslbl
            // 
            todaySaleslbl.AutoSize = true;
            todaySaleslbl.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            todaySaleslbl.ForeColor = Color.Black;
            todaySaleslbl.Location = new Point(101, 130);
            todaySaleslbl.Name = "todaySaleslbl";
            todaySaleslbl.Size = new Size(99, 30);
            todaySaleslbl.TabIndex = 1;
            todaySaleslbl.Text = "مبيعات اليوم";
            // 
            // lblTodaySales
            // 
            lblTodaySales.Font = new Font("Cairo Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodaySales.ForeColor = Color.Black;
            lblTodaySales.Location = new Point(25, 2);
            lblTodaySales.Name = "lblTodaySales";
            lblTodaySales.Size = new Size(250, 125);
            lblTodaySales.TabIndex = 0;
            lblTodaySales.Text = "0";
            lblTodaySales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBalance
            // 
            pnlBalance.Controls.Add(balancelbl);
            pnlBalance.Controls.Add(lblBalance);
            pnlBalance.Location = new Point(717, 299);
            pnlBalance.Name = "pnlBalance";
            pnlBalance.OutlineThickness = 1F;
            pnlBalance.PanelColor = Color.FromArgb(216, 220, 208);
            pnlBalance.PanelOutlineColor = Color.Transparent;
            pnlBalance.Rounding = new Padding(10);
            pnlBalance.Size = new Size(300, 175);
            pnlBalance.TabIndex = 4;
            // 
            // balancelbl
            // 
            balancelbl.AutoSize = true;
            balancelbl.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balancelbl.ForeColor = Color.Black;
            balancelbl.Location = new Point(101, 130);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(99, 30);
            balancelbl.TabIndex = 1;
            balancelbl.Text = "الرصيد المتاح";
            // 
            // lblBalance
            // 
            lblBalance.Font = new Font("Cairo Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.Black;
            lblBalance.Location = new Point(25, 2);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(250, 125);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "0";
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTodayCard
            // 
            pnlTodayCard.Controls.Add(todayCardlbl);
            pnlTodayCard.Controls.Add(lblTodayCards);
            pnlTodayCard.Location = new Point(392, 106);
            pnlTodayCard.Name = "pnlTodayCard";
            pnlTodayCard.OutlineThickness = 1F;
            pnlTodayCard.PanelColor = Color.FromArgb(216, 220, 208);
            pnlTodayCard.PanelOutlineColor = Color.Transparent;
            pnlTodayCard.Rounding = new Padding(10);
            pnlTodayCard.Size = new Size(300, 175);
            pnlTodayCard.TabIndex = 2;
            // 
            // todayCardlbl
            // 
            todayCardlbl.AutoSize = true;
            todayCardlbl.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            todayCardlbl.ForeColor = Color.Black;
            todayCardlbl.Location = new Point(102, 130);
            todayCardlbl.Name = "todayCardlbl";
            todayCardlbl.Size = new Size(97, 30);
            todayCardlbl.TabIndex = 1;
            todayCardlbl.Text = "بطاقات اليوم";
            // 
            // lblTodayCards
            // 
            lblTodayCards.Font = new Font("Cairo Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayCards.ForeColor = Color.Black;
            lblTodayCards.Location = new Point(25, 2);
            lblTodayCards.Name = "lblTodayCards";
            lblTodayCards.Size = new Size(250, 125);
            lblTodayCards.TabIndex = 0;
            lblTodayCards.Text = "0";
            lblTodayCards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlReceivedQuota
            // 
            pnlReceivedQuota.Controls.Add(receivedQuotalbl);
            pnlReceivedQuota.Controls.Add(lblReceivedQuota);
            pnlReceivedQuota.Location = new Point(717, 106);
            pnlReceivedQuota.Name = "pnlReceivedQuota";
            pnlReceivedQuota.OutlineThickness = 1F;
            pnlReceivedQuota.PanelColor = Color.FromArgb(216, 220, 208);
            pnlReceivedQuota.PanelOutlineColor = Color.Transparent;
            pnlReceivedQuota.Rounding = new Padding(10);
            pnlReceivedQuota.Size = new Size(300, 175);
            pnlReceivedQuota.TabIndex = 0;
            // 
            // receivedQuotalbl
            // 
            receivedQuotalbl.AutoSize = true;
            receivedQuotalbl.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receivedQuotalbl.ForeColor = Color.Black;
            receivedQuotalbl.Location = new Point(84, 130);
            receivedQuotalbl.Name = "receivedQuotalbl";
            receivedQuotalbl.Size = new Size(133, 30);
            receivedQuotalbl.TabIndex = 1;
            receivedQuotalbl.Text = "الحصص المستلمه";
            // 
            // lblReceivedQuota
            // 
            lblReceivedQuota.Font = new Font("Cairo Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceivedQuota.ForeColor = Color.Black;
            lblReceivedQuota.Location = new Point(25, 2);
            lblReceivedQuota.Name = "lblReceivedQuota";
            lblReceivedQuota.Size = new Size(250, 125);
            lblReceivedQuota.TabIndex = 0;
            lblReceivedQuota.Text = "0";
            lblReceivedQuota.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timing
            // 
            timing.Interval = 16;
            timing.Tick += timing_Tick;
            // 
            // ucStatistaics
            // 
            AutoScaleDimensions = new SizeF(6F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlRoundedContainer);
            Font = new Font("Cairo", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "ucStatistaics";
            Size = new Size(1084, 580);
            Load += ucStatistaics_Load;
            pnlRoundedContainer.ResumeLayout(false);
            pnlTotalSales.ResumeLayout(false);
            pnlTotalSales.PerformLayout();
            pnlTotalCards.ResumeLayout(false);
            pnlTotalCards.PerformLayout();
            pnlTodaySale.ResumeLayout(false);
            pnlTodaySale.PerformLayout();
            pnlBalance.ResumeLayout(false);
            pnlBalance.PerformLayout();
            pnlTodayCard.ResumeLayout(false);
            pnlTodayCard.PerformLayout();
            pnlReceivedQuota.ResumeLayout(false);
            pnlReceivedQuota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiBorder pnlRoundedContainer;
        private CuoreUI.Controls.cuiBorder pnlReceivedQuota;
        private Label receivedQuotalbl;
        private Label lblReceivedQuota;
        private CuoreUI.Controls.cuiBorder pnlTotalCards;
        private Label totalCardslbl;
        private Label lblTotalCards;
        private CuoreUI.Controls.cuiBorder pnlTodayCard;
        private Label todayCardlbl;
        private Label lblTodayCards;
        private CuoreUI.Controls.cuiBorder pnlTotalSales;
        private Label totalSaleslbl;
        private Label lblTotalSales;
        private CuoreUI.Controls.cuiBorder pnlTodaySale;
        private Label todaySaleslbl;
        private Label lblTodaySales;
        private CuoreUI.Controls.cuiBorder pnlBalance;
        private Label balancelbl;
        private Label lblBalance;
        private System.Windows.Forms.Timer timing;
    }
}

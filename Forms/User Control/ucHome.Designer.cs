namespace FlourSystem.Forms.User_Control
{
    partial class ucHome
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
            pnlAddtionalDropDown = new CuoreUI.Controls.cuiBorder();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            btnAddQuota = new CuoreUI.Controls.cuiButton();
            btnAddCustomer = new CuoreUI.Controls.cuiButton();
            pnlCustomerContainer = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            AdditionaldropDownTimer = new System.Windows.Forms.Timer(components);
            _renderTimer = new System.Windows.Forms.Timer(components);
            ScrollTimer = new System.Windows.Forms.Timer(components);
            pnlRoundedContainer.SuspendLayout();
            pnlAddtionalDropDown.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRoundedContainer
            // 
            pnlRoundedContainer.Controls.Add(pnlAddtionalDropDown);
            pnlRoundedContainer.Controls.Add(pnlCustomerContainer);
            pnlRoundedContainer.Controls.Add(flowLayoutPanel1);
            pnlRoundedContainer.Dock = DockStyle.Fill;
            pnlRoundedContainer.Location = new Point(0, 0);
            pnlRoundedContainer.Margin = new Padding(3, 5, 3, 5);
            pnlRoundedContainer.Name = "pnlRoundedContainer";
            pnlRoundedContainer.OutlineThickness = 1F;
            pnlRoundedContainer.PanelColor = Color.FromArgb(232, 237, 223);
            pnlRoundedContainer.PanelOutlineColor = Color.FromArgb(232, 237, 223);
            pnlRoundedContainer.Rounding = new Padding(25);
            pnlRoundedContainer.Size = new Size(1084, 580);
            pnlRoundedContainer.TabIndex = 0;
            // 
            // pnlAddtionalDropDown
            // 
            pnlAddtionalDropDown.BackColor = Color.FromArgb(232, 237, 223);
            pnlAddtionalDropDown.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAddtionalDropDown.Controls.Add(cuiButton1);
            pnlAddtionalDropDown.Controls.Add(btnAddQuota);
            pnlAddtionalDropDown.Controls.Add(btnAddCustomer);
            pnlAddtionalDropDown.Location = new Point(18, 3);
            pnlAddtionalDropDown.MaximumSize = new Size(100, 90);
            pnlAddtionalDropDown.MinimumSize = new Size(100, 0);
            pnlAddtionalDropDown.Name = "pnlAddtionalDropDown";
            pnlAddtionalDropDown.OutlineThickness = 1F;
            pnlAddtionalDropDown.PanelColor = Color.FromArgb(221, 221, 221);
            pnlAddtionalDropDown.PanelOutlineColor = Color.FromArgb(221, 221, 221);
            pnlAddtionalDropDown.Rounding = new Padding(10);
            pnlAddtionalDropDown.Size = new Size(100, 0);
            pnlAddtionalDropDown.TabIndex = 12;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.Transparent;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "حذف";
            cuiButton1.Cursor = Cursors.Hand;
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Dock = DockStyle.Top;
            cuiButton1.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.LightGray;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.Empty;
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(0, 60);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.Transparent;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.Empty;
            cuiButton1.OutlineThickness = 0F;
            cuiButton1.PressedBackground = Color.FromArgb(71, 137, 75);
            cuiButton1.PressedForeColor = Color.White;
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.Empty;
            cuiButton1.Rounding = new Padding(0, 0, 10, 10);
            cuiButton1.Size = new Size(100, 30);
            cuiButton1.TabIndex = 2;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // btnAddQuota
            // 
            btnAddQuota.BackColor = Color.Transparent;
            btnAddQuota.CheckButton = false;
            btnAddQuota.Checked = false;
            btnAddQuota.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAddQuota.CheckedForeColor = Color.White;
            btnAddQuota.CheckedImageTint = Color.White;
            btnAddQuota.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAddQuota.Content = "تحديث";
            btnAddQuota.Cursor = Cursors.Hand;
            btnAddQuota.DialogResult = DialogResult.None;
            btnAddQuota.Dock = DockStyle.Top;
            btnAddQuota.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btnAddQuota.ForeColor = Color.Black;
            btnAddQuota.HoverBackground = Color.LightGray;
            btnAddQuota.HoveredImageTint = Color.White;
            btnAddQuota.HoverForeColor = Color.Black;
            btnAddQuota.HoverOutline = Color.Empty;
            btnAddQuota.Image = null;
            btnAddQuota.ImageAutoCenter = true;
            btnAddQuota.ImageExpand = new Point(0, 0);
            btnAddQuota.ImageOffset = new Point(0, 0);
            btnAddQuota.Location = new Point(0, 30);
            btnAddQuota.Name = "btnAddQuota";
            btnAddQuota.NormalBackground = Color.Transparent;
            btnAddQuota.NormalForeColor = Color.Black;
            btnAddQuota.NormalImageTint = Color.White;
            btnAddQuota.NormalOutline = Color.Empty;
            btnAddQuota.OutlineThickness = 0F;
            btnAddQuota.PressedBackground = Color.FromArgb(71, 137, 75);
            btnAddQuota.PressedForeColor = Color.White;
            btnAddQuota.PressedImageTint = Color.White;
            btnAddQuota.PressedOutline = Color.Empty;
            btnAddQuota.Rounding = new Padding(0);
            btnAddQuota.Size = new Size(100, 30);
            btnAddQuota.TabIndex = 1;
            btnAddQuota.TextOffset = new Point(0, 0);
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.Transparent;
            btnAddCustomer.CheckButton = false;
            btnAddCustomer.Checked = false;
            btnAddCustomer.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAddCustomer.CheckedForeColor = Color.White;
            btnAddCustomer.CheckedImageTint = Color.White;
            btnAddCustomer.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAddCustomer.Content = "إعادة ضبط";
            btnAddCustomer.Cursor = Cursors.Hand;
            btnAddCustomer.DialogResult = DialogResult.None;
            btnAddCustomer.Dock = DockStyle.Top;
            btnAddCustomer.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btnAddCustomer.ForeColor = Color.Black;
            btnAddCustomer.HoverBackground = Color.LightGray;
            btnAddCustomer.HoveredImageTint = Color.White;
            btnAddCustomer.HoverForeColor = Color.Black;
            btnAddCustomer.HoverOutline = Color.Empty;
            btnAddCustomer.Image = null;
            btnAddCustomer.ImageAutoCenter = true;
            btnAddCustomer.ImageExpand = new Point(0, 0);
            btnAddCustomer.ImageOffset = new Point(0, 0);
            btnAddCustomer.Location = new Point(0, 0);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.NormalBackground = Color.Transparent;
            btnAddCustomer.NormalForeColor = Color.Black;
            btnAddCustomer.NormalImageTint = Color.White;
            btnAddCustomer.NormalOutline = Color.Empty;
            btnAddCustomer.OutlineThickness = 0F;
            btnAddCustomer.PressedBackground = Color.FromArgb(71, 137, 75);
            btnAddCustomer.PressedForeColor = Color.White;
            btnAddCustomer.PressedImageTint = Color.White;
            btnAddCustomer.PressedOutline = Color.Empty;
            btnAddCustomer.Rounding = new Padding(10, 10, 3, 3);
            btnAddCustomer.Size = new Size(100, 30);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.TextOffset = new Point(0, 0);
            // 
            // pnlCustomerContainer
            // 
            pnlCustomerContainer.AutoScroll = true;
            pnlCustomerContainer.BackColor = Color.Transparent;
            pnlCustomerContainer.FlowDirection = FlowDirection.TopDown;
            pnlCustomerContainer.Location = new Point(0, 80);
            pnlCustomerContainer.Name = "pnlCustomerContainer";
            pnlCustomerContainer.Padding = new Padding(3);
            pnlCustomerContainer.Size = new Size(1084, 480);
            pnlCustomerContainer.TabIndex = 1;
            pnlCustomerContainer.WrapContents = false;
            pnlCustomerContainer.MouseWheel += PnlCustomerContainer_MouseWheel;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(207, 219, 213);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(1084, 40);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(761, 10);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 0;
            label1.Text = "الاسم";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(670, 10);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "الإجمالي";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(579, 10);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "المتبقي";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(488, 10);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "المطلوب";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(397, 10);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "استلم";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(306, 10);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 5;
            label6.Text = "المبلغ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(215, 10);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 6;
            label7.Text = "المدفوع";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(124, 10);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 7;
            label8.Text = "تسجيل";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(33, 10);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 8;
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdditionaldropDownTimer
            // 
            AdditionaldropDownTimer.Interval = 1;
            AdditionaldropDownTimer.Tick += AdditionaldropDownTimer_Tick;
            // 
            // _renderTimer
            // 
            _renderTimer.Interval = 25;
            _renderTimer.Tick += RenderNextBatch;
            // 
            // ScrollTimer
            // 
            ScrollTimer.Interval = 1;
            ScrollTimer.Tick += ScrollTimer_Tick;
            // 
            // ucHome
            // 
            AutoScaleDimensions = new SizeF(6F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlRoundedContainer);
            Font = new Font("Cairo", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "ucHome";
            Size = new Size(1084, 580);
            Load += ucHome_Load;
            pnlRoundedContainer.ResumeLayout(false);
            pnlAddtionalDropDown.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiBorder pnlRoundedContainer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel pnlCustomerContainer;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CuoreUI.Controls.cuiBorder pnlAddtionalDropDown;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton btnAddQuota;
        private CuoreUI.Controls.cuiButton btnAddCustomer;
        private System.Windows.Forms.Timer AdditionaldropDownTimer;
        private System.Windows.Forms.Timer _renderTimer;
        private System.Windows.Forms.Timer ScrollTimer;
    }
}

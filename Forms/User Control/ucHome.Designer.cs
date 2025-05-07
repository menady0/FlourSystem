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
            btnDelete = new CuoreUI.Controls.cuiButton();
            btnUpdate = new CuoreUI.Controls.cuiButton();
            btnReset = new CuoreUI.Controls.cuiButton();
            pnlCustomerContainer = new FlowLayoutPanel();
            pnlTableHeader = new FlowLayoutPanel();
            lblName = new Label();
            lblTotal = new Label();
            lblRemain = new Label();
            lblRequired = new Label();
            lblReceived = new Label();
            lblPrice = new Label();
            lblPaid = new Label();
            lblRegister = new Label();
            lblAddtional = new Label();
            AdditionaldropDownTimer = new System.Windows.Forms.Timer(components);
            _renderTimer = new System.Windows.Forms.Timer(components);
            ScrollTimer = new System.Windows.Forms.Timer(components);
            pnlRoundedContainer.SuspendLayout();
            pnlAddtionalDropDown.SuspendLayout();
            pnlTableHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRoundedContainer
            // 
            pnlRoundedContainer.Controls.Add(pnlAddtionalDropDown);
            pnlRoundedContainer.Controls.Add(pnlCustomerContainer);
            pnlRoundedContainer.Controls.Add(pnlTableHeader);
            pnlRoundedContainer.Dock = DockStyle.Fill;
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
            // pnlAddtionalDropDown
            // 
            pnlAddtionalDropDown.BackColor = Color.FromArgb(232, 237, 223);
            pnlAddtionalDropDown.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAddtionalDropDown.Controls.Add(btnDelete);
            pnlAddtionalDropDown.Controls.Add(btnUpdate);
            pnlAddtionalDropDown.Controls.Add(btnReset);
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
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.CheckButton = false;
            btnDelete.Checked = false;
            btnDelete.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnDelete.CheckedForeColor = Color.White;
            btnDelete.CheckedImageTint = Color.White;
            btnDelete.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnDelete.Content = "حذف";
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.DialogResult = DialogResult.None;
            btnDelete.Dock = DockStyle.Top;
            btnDelete.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.HoverBackground = Color.LightGray;
            btnDelete.HoveredImageTint = Color.White;
            btnDelete.HoverForeColor = Color.Black;
            btnDelete.HoverOutline = Color.Empty;
            btnDelete.Image = null;
            btnDelete.ImageAutoCenter = true;
            btnDelete.ImageExpand = new Point(0, 0);
            btnDelete.ImageOffset = new Point(0, 0);
            btnDelete.Location = new Point(0, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.NormalBackground = Color.Transparent;
            btnDelete.NormalForeColor = Color.Black;
            btnDelete.NormalImageTint = Color.White;
            btnDelete.NormalOutline = Color.Empty;
            btnDelete.OutlineThickness = 0F;
            btnDelete.PressedBackground = Color.FromArgb(71, 137, 75);
            btnDelete.PressedForeColor = Color.White;
            btnDelete.PressedImageTint = Color.White;
            btnDelete.PressedOutline = Color.Empty;
            btnDelete.Rounding = new Padding(0, 0, 10, 10);
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 2;
            btnDelete.TextOffset = new Point(0, 0);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.CheckButton = false;
            btnUpdate.Checked = false;
            btnUpdate.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnUpdate.CheckedForeColor = Color.White;
            btnUpdate.CheckedImageTint = Color.White;
            btnUpdate.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnUpdate.Content = "تحديث";
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.DialogResult = DialogResult.None;
            btnUpdate.Dock = DockStyle.Top;
            btnUpdate.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.HoverBackground = Color.LightGray;
            btnUpdate.HoveredImageTint = Color.White;
            btnUpdate.HoverForeColor = Color.Black;
            btnUpdate.HoverOutline = Color.Empty;
            btnUpdate.Image = null;
            btnUpdate.ImageAutoCenter = true;
            btnUpdate.ImageExpand = new Point(0, 0);
            btnUpdate.ImageOffset = new Point(0, 0);
            btnUpdate.Location = new Point(0, 30);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NormalBackground = Color.Transparent;
            btnUpdate.NormalForeColor = Color.Black;
            btnUpdate.NormalImageTint = Color.White;
            btnUpdate.NormalOutline = Color.Empty;
            btnUpdate.OutlineThickness = 0F;
            btnUpdate.PressedBackground = Color.FromArgb(71, 137, 75);
            btnUpdate.PressedForeColor = Color.White;
            btnUpdate.PressedImageTint = Color.White;
            btnUpdate.PressedOutline = Color.Empty;
            btnUpdate.Rounding = new Padding(0);
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 1;
            btnUpdate.TextOffset = new Point(0, 0);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.CheckButton = false;
            btnReset.Checked = false;
            btnReset.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnReset.CheckedForeColor = Color.White;
            btnReset.CheckedImageTint = Color.White;
            btnReset.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnReset.Content = "إعادة ضبط";
            btnReset.Cursor = Cursors.Hand;
            btnReset.DialogResult = DialogResult.None;
            btnReset.Dock = DockStyle.Top;
            btnReset.Font = new Font("Cairo Light", 12F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btnReset.ForeColor = Color.Black;
            btnReset.HoverBackground = Color.LightGray;
            btnReset.HoveredImageTint = Color.White;
            btnReset.HoverForeColor = Color.Black;
            btnReset.HoverOutline = Color.Empty;
            btnReset.Image = null;
            btnReset.ImageAutoCenter = true;
            btnReset.ImageExpand = new Point(0, 0);
            btnReset.ImageOffset = new Point(0, 0);
            btnReset.Location = new Point(0, 0);
            btnReset.Name = "btnReset";
            btnReset.NormalBackground = Color.Transparent;
            btnReset.NormalForeColor = Color.Black;
            btnReset.NormalImageTint = Color.White;
            btnReset.NormalOutline = Color.Empty;
            btnReset.OutlineThickness = 0F;
            btnReset.PressedBackground = Color.FromArgb(71, 137, 75);
            btnReset.PressedForeColor = Color.White;
            btnReset.PressedImageTint = Color.White;
            btnReset.PressedOutline = Color.Empty;
            btnReset.Rounding = new Padding(10, 10, 3, 3);
            btnReset.Size = new Size(100, 30);
            btnReset.TabIndex = 0;
            btnReset.TextOffset = new Point(0, 0);
            btnReset.Click += btnReset_Click;
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
            pnlCustomerContainer.Scroll += pnlCustomerContainer_Scroll;
            pnlCustomerContainer.MouseWheel += PnlCustomerContainer_MouseWheel;
            // 
            // pnlTableHeader
            // 
            pnlTableHeader.BackColor = Color.FromArgb(207, 219, 213);
            pnlTableHeader.Controls.Add(lblName);
            pnlTableHeader.Controls.Add(lblTotal);
            pnlTableHeader.Controls.Add(lblRemain);
            pnlTableHeader.Controls.Add(lblRequired);
            pnlTableHeader.Controls.Add(lblReceived);
            pnlTableHeader.Controls.Add(lblPrice);
            pnlTableHeader.Controls.Add(lblPaid);
            pnlTableHeader.Controls.Add(lblRegister);
            pnlTableHeader.Controls.Add(lblAddtional);
            pnlTableHeader.FlowDirection = FlowDirection.RightToLeft;
            pnlTableHeader.Location = new Point(0, 40);
            pnlTableHeader.Name = "pnlTableHeader";
            pnlTableHeader.Padding = new Padding(10);
            pnlTableHeader.Size = new Size(1084, 40);
            pnlTableHeader.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(761, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(300, 20);
            lblName.TabIndex = 0;
            lblName.Text = "الاسم";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(670, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(85, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "الإجمالي";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemain
            // 
            lblRemain.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblRemain.ForeColor = Color.Black;
            lblRemain.Location = new Point(579, 10);
            lblRemain.Name = "lblRemain";
            lblRemain.Size = new Size(85, 20);
            lblRemain.TabIndex = 2;
            lblRemain.Text = "المتبقي";
            lblRemain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRequired
            // 
            lblRequired.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblRequired.ForeColor = Color.Black;
            lblRequired.Location = new Point(488, 10);
            lblRequired.Name = "lblRequired";
            lblRequired.Size = new Size(85, 20);
            lblRequired.TabIndex = 3;
            lblRequired.Text = "المطلوب";
            lblRequired.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReceived
            // 
            lblReceived.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblReceived.ForeColor = Color.Black;
            lblReceived.Location = new Point(397, 10);
            lblReceived.Name = "lblReceived";
            lblReceived.Size = new Size(85, 20);
            lblReceived.TabIndex = 4;
            lblReceived.Text = "استلم";
            lblReceived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(306, 10);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(85, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "المبلغ";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPaid
            // 
            lblPaid.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblPaid.ForeColor = Color.Black;
            lblPaid.Location = new Point(215, 10);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(85, 20);
            lblPaid.TabIndex = 6;
            lblPaid.Text = "المدفوع";
            lblPaid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRegister
            // 
            lblRegister.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblRegister.ForeColor = Color.Black;
            lblRegister.Location = new Point(124, 10);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(85, 20);
            lblRegister.TabIndex = 7;
            lblRegister.Text = "تسجيل";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddtional
            // 
            lblAddtional.BackColor = Color.Transparent;
            lblAddtional.Font = new Font("Cairo", 10F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lblAddtional.ForeColor = Color.Black;
            lblAddtional.Location = new Point(33, 10);
            lblAddtional.Name = "lblAddtional";
            lblAddtional.Size = new Size(85, 20);
            lblAddtional.TabIndex = 8;
            lblAddtional.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdditionaldropDownTimer
            // 
            AdditionaldropDownTimer.Interval = 1;
            AdditionaldropDownTimer.Tick += AdditionaldropDownTimer_Tick;
            // 
            // _renderTimer
            // 
            _renderTimer.Interval = 16;
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
            pnlTableHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiBorder pnlRoundedContainer;
        private FlowLayoutPanel pnlTableHeader;
        private Label lblName;
        private Label lblTotal;
        private Label lblRemain;
        private Label lblRequired;
        private Label lblReceived;
        private Label lblPrice;
        private Label lblPaid;
        private Label lblRegister;
        private Label lblAddtional;
        private CuoreUI.Controls.cuiButton btnDelete;
        private CuoreUI.Controls.cuiButton btnUpdate;
        private CuoreUI.Controls.cuiButton btnReset;
        private System.Windows.Forms.Timer _renderTimer;
        private System.Windows.Forms.Timer ScrollTimer;
        public FlowLayoutPanel pnlCustomerContainer;
        public CuoreUI.Controls.cuiBorder pnlAddtionalDropDown;
        public System.Windows.Forms.Timer AdditionaldropDownTimer;
    }
}

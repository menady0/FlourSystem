using CuoreUI.Controls;
using FlourSystem.Classes;
using FlourSystem.Classes.ToastClass;
using FlourSystem.Forms.ToastMessage;
using FlourSystem.Forms.User_Control.ucHomeBtns;
using FlourSystem.Properties;
using FontAwesome.Sharp;

namespace FlourSystem.Forms.User_Control
{
    public partial class ucHome : UserControl
    {
        private frmDashboard _dashboard;
        public ucHome(frmDashboard dasbhoard)
        {
            InitializeComponent();
            _dashboard = dasbhoard;
        }
        private void ucHome_Load(object sender, EventArgs e)
        {
            DataBase.CustomersList = DataBase.RetrieveCustomerTable();


            DisplayTimer(DataBase.CustomersList);
            CloseOpenedDropDown(this);

            #region Stop Watch
            //Stopwatch sw = Stopwatch.StartNew();
            //sw.Start();
            //sw.Stop();
            //MessageBox.Show($"Time taken to load customers: {sw.ElapsedMilliseconds} ms");
            #endregion
            ThemeManager.ApplyTheme();
        }
        #region Display Data [Best For Performance]

        private bool isLoading = false;
        public int currentIndex = 0;
        public int targetIndex = 0;

        private List<Dictionary<string, object>> customersToDisplay;
        public void DisplayTimer(List<Dictionary<string, object>> customers)
        {
            customersToDisplay = customers;
            if (Settings.Default.lazyLoading)
                targetIndex = Math.Min(currentIndex + Settings.Default.batchSize, customersToDisplay.Count);
            else
                targetIndex = customersToDisplay.Count;

            if (isLoading || currentIndex >= customersToDisplay.Count)
                return;

            isLoading = true;

            _renderTimer.Start();
        }
        private void RenderNextBatch(object? sender, EventArgs e)
        {
            int steps = 1;
            int endIndex = Math.Min(currentIndex + steps, targetIndex);

            for (int i = currentIndex; i < endIndex; i++)
            {
                var customer = customersToDisplay[i];
                FlowLayoutPanel customerPanel = CreateCustomerPanel(customer);
                pnlCustomerContainer.Controls.Add(customerPanel);
                CloseOpenedDropDown(customerPanel);
            }

            currentIndex = endIndex;

            if (currentIndex >= targetIndex)
            {
                _renderTimer.Stop();
                isLoading = false;
                HoverEffect.Hover
                (
                completed.ToArray(),
                getDefaultValue: ctrl => ThemeManager.IsDarkMode ? ThemeColors.DarkCompleted : ThemeColors.LightCompleted,
                getHoverValue: ctrl => ThemeManager.IsDarkMode ? ThemeColors.DarkHoverCompleted : ThemeColors.LightHoverCompleted,
                setValue: (ctrl, value) =>
                {
                    if (ctrl is FlowLayoutPanel panel)
                    {
                        panel.BackColor = value;
                    }
                },
                interpolate: HoverEffect.InterpolateColor,
                transitionDuration: 100
                );
            }
        }
        private FlowLayoutPanel CreateCustomerPanel(Dictionary<string, object> customer)
        {
            FlowLayoutPanel customerPanel = new FlowLayoutPanel
            {
                Name = "customerPanel",
                Width = 1067,
                Height = 40,
                Font = new Font("Cairo", 10),
                Padding = new Padding(10, 0, 10, 0),
                Margin = new Padding(0, 0, 0, 0),
                AllowDrop = true,
                FlowDirection = FlowDirection.RightToLeft,
                Tag = customer["CustomerID"],
            };
            customerPanel.DragEnter += CustomerPanel_DragEnter;
            customerPanel.DragDrop += CustomerPanel_DragDrop;
            customerPanel.DragLeave += CustomerPanel_DragLeave;

            IconPictureBox drag = new IconPictureBox
            {
                Name = "picDrag",
                IconChar = IconChar.GripVertical,
                IconColor = Color.Gray,
                IconSize = 20,
                Width = 20,
                Height = 40,
                SizeMode = PictureBoxSizeMode.CenterImage,
                Cursor = Cursors.Hand,
                BackColor = Color.Transparent,
            };
            drag.MouseDown += (sender, e) => drag_MouseDown(sender, e, customerPanel);

            Label lblName = new Label
            {
                AutoSize = false,
                Text = $"{customer["name"]}",
                Width = 270,
                Height = 40,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.Black,
            };
            Label lblTotal = new Label
            {
                AutoSize = false,
                Text = $"{int.Parse(customer["numberOfPeople"]?.ToString() ?? "0") * (Settings.Default.sack / 2)}",
                Width = 80,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
            };
            Label lblRemain = new Label
            {
                AutoSize = false,
                Text = $"{customer["remainQuantity"]}",
                Width = 80,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
            };
            cuiTextBox2 txtRequired = new cuiTextBox2
            {
                Name = "input",
                Content = "0",
                Width = 80,
                Height = 30,
                Padding = new Padding(0),
                Rounding = new Padding(5),
                ForeColor = Color.Black,
                BackgroundColor = ThemeColors.LightBackground,
                //BorderColor = Color.FromArgb(216, 220, 208),
                BorderColor = Color.Transparent,
                FocusBackgroundColor = Color.Transparent,
                FocusBorderColor = ThemeColors.Green,
            };
            Label lblReceivedRemain = new Label
            {
                AutoSize = false,
                Text = $"{customer["delivered"]}",
                Width = 80,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
            };
            cuiTextBox2 txtReceived = new cuiTextBox2
            {
                Name = "input",
                Content = $"{customer["delivered"]}",
                Width = 80,
                Height = 30,
                Padding = new Padding(0),
                Rounding = new Padding(5),
                ForeColor = Color.Black,
                BackgroundColor = ThemeColors.LightBackground,
                //BorderColor = Color.FromArgb(216, 220, 208),
                BorderColor = Color.Transparent,
                FocusBackgroundColor = Color.Transparent,
                FocusBorderColor = ThemeColors.Green,
            };
            Label lblPrice = new Label
            {
                AutoSize = false,
                Text = $"{customer["price"]}",
                Width = 80,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
            };
            cuiTextBox2 txtPaid = new cuiTextBox2
            {
                Name = "input",
                Content = $"{customer["price"]}",
                Width = 80,
                Height = 30,
                Padding = new Padding(0),
                Rounding = new Padding(5),
                ForeColor = Color.Black,
                BackgroundColor = ThemeColors.LightBackground,
                //BorderColor = Color.FromArgb(216, 220, 208),
                BorderColor = Color.Transparent,
                FocusBackgroundColor = Color.Transparent,
                FocusBorderColor = ThemeColors.Green,
            };
            //txtRequired.ContentChanged += (sender, e) => txtRequired_ContentChanged(sender, e, txtReceived, txtPaid);

            cuiButton btnRegister = new cuiButton
            {
                Name = "btnRegister",
                Content = $"{customer["registration"]}",
                Width = 70,
                Height = 25,
                Rounding = new Padding(5),
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 7, 0, 7),
                ForeColor = Color.White,
                NormalBackground = Color.FromArgb(85, 86, 82),
                HoverBackground = Color.FromArgb(200, 71, 137, 75),
                PressedBackground = Color.FromArgb(71, 137, 75),
                Tag = new { Customer = customer, Remain = lblRemain, Required = txtRequired, ReceivedRemain = lblReceivedRemain, Received = txtReceived, Price = lblPrice, Paid = txtPaid},
            };
            if (btnRegister.Content != "0") btnRegister.NormalBackground = Color.FromArgb(71, 137, 75);
            btnRegister.Click += btnRegister_Click;

            Panel pnlAdditional = new Panel
            {
                Width = 55,
                Height = 40,
                BackColor = Color.Transparent,
                Padding = new Padding(25, 0, 25, 0),
            };
            IconButton btnAdditional = new IconButton
            {
                IconChar = IconChar.EllipsisV,
                IconColor = ThemeColors.LightForeColor,
                IconSize = 20,
                Dock = DockStyle.Fill,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance =
                    {
                        BorderSize = 0,
                        MouseDownBackColor = Color.Transparent,
                        MouseOverBackColor = Color.Transparent,
                    },
                BackColor = Color.Transparent,
                TabStop = false,
                Tag = customer,
            };
            btnAdditional.Click += (sender, e) =>
            {
                var clickedButton = sender as IconButton;
                bool isSameButton = lastTriggerButton == clickedButton;

                if (isAddtionalDropDownExpanded)
                {
                    if (isSameButton)
                    {
                        AdditionaldropDownTimer.Start();
                        lastTriggerButton = null;
                        return;
                    }

                    else
                    {
                        isClosingForReposition = true;
                        pnlAddtionalDropDown.Tag = clickedButton;
                        AdditionaldropDownTimer.Start();
                    }

                    return;
                }
                OpenDropDown(clickedButton);
            };
            pnlAdditional.Controls.Add(btnAdditional);

            customerPanel.Controls.Add(drag);
            customerPanel.Controls.Add(lblName);
            customerPanel.Controls.Add(lblTotal);
            customerPanel.Controls.Add(lblRemain);
            customerPanel.Controls.Add(txtRequired);
            customerPanel.Controls.Add(lblReceivedRemain);
            customerPanel.Controls.Add(txtReceived);
            customerPanel.Controls.Add(lblPrice);
            customerPanel.Controls.Add(txtPaid);
            customerPanel.Controls.Add(btnRegister);
            customerPanel.Controls.Add(pnlAdditional);

            pnlCustomerContainer.Controls.Add(customerPanel);
            ThemeManager.CustomerPanelTheme(customerPanel);

            if (int.TryParse(customer["price"].ToString(), out int price) &&
                int.TryParse(customer["remainQuantity"].ToString(), out int remain) &&
                int.TryParse(customer["delivered"].ToString(), out int delivered) &&
                price == 0 && remain == 0 && delivered == 0)
            {
                customerPanel.BackColor = ThemeManager.IsDarkMode ? ThemeColors.DarkCompleted : ThemeColors.LightCompleted;
                completed.Add(customerPanel);
            }
            ThemeManager.ApplyControlTheme(customerPanel, ThemeManager.IsDarkMode);
            return customerPanel;
        }
        IconButton? lastTriggerButton = null;
        private void txtRequired_ContentChanged(object? sender, EventArgs e, cuiTextBox2 txtReceived, cuiTextBox2 txtPaid)
        {
            if (sender is cuiTextBox2 req)
            {
                if (int.TryParse(req.Content, out int reqValue))
                {
                    txtReceived.Content = reqValue.ToString();
                    txtPaid.Content = (reqValue * (Settings.Default.price / Settings.Default.sack)).ToString();
                }
                else
                {
                    txtReceived.Content = "0";
                    txtPaid.Content = "0";
                }
            }
        }
        private List<Control> completed = new();
        private void btnRegister_Click(object? sender, EventArgs e)
        {
            if (sender is cuiButton btnRegister)
            {
                dynamic? tag = btnRegister.Tag;
                Dictionary<string, object> customer = tag.Customer;

                Label remain = tag.Remain;
                cuiTextBox2 txtRequired = tag.Required;

                Label ReceivedRemain = tag.ReceivedRemain;
                cuiTextBox2 txtReceived = tag.Received;

                Label price = tag.Price;
                cuiTextBox2 txtPaid = tag.Paid;

                if (
                    string.IsNullOrEmpty(txtReceived.Content) ||
                    string.IsNullOrEmpty(txtRequired.Content) ||
                    string.IsNullOrEmpty(txtPaid.Content)
                    )
                {
                    Toast.Show("لا يمكن ترك أحد الحقول فارغًا!", ToastType.Error);
                    return;
                }
                if (
                    int.TryParse(txtRequired.Content, out int reqValue) &&
                    int.TryParse(txtReceived.Content, out int recValue) &&
                    int.TryParse(txtPaid.Content, out int paidValue))
                {
                    if (reqValue < 0 || recValue < 0 || paidValue < 0)
                    {
                        Toast.Show("لا يمكن ان تكون القيمة سالبة!", ToastType.Error);
                        return;
                    }
                    else if (reqValue == 0 && recValue == 0 && paidValue == 0)
                    {
                        Toast.Show("لا يمكن أن تكون جميع القيم صفرًا!", ToastType.Error);
                        return;
                    }
                    else if (
                        reqValue > int.Parse(remain.Text) ||
                        recValue > int.Parse(ReceivedRemain.Text) ||
                        paidValue > int.Parse(price.Text)
                        )
                    {
                        Toast.Show("الكمية تتجاوز الكمية المتبقية.", ToastType.Error);
                        return;
                    }
                    int currentMonth = DateTime.Now.Month;
                    int currentYear = DateTime.Now.Year;
                    DataBase.balance = DataBase.Balance(currentMonth, currentYear);
                    if (reqValue > DataBase.balance)
                    {
                        Toast.Show("الرصيد غير كافٍ.", ToastType.Error);
                        return;
                    }
                    DataBase.flourStored = DataBase.FlourStored(currentMonth, currentYear);
                    if (recValue > DataBase.flourStored)
                    {
                        Toast.Show("الكمية في المخزن غير كافية.", ToastType.Error);
                        return;
                    }
                }
                else
                {
                    Toast.Show("يرجى إدخال رقم صالح.", ToastType.Error);
                    return;
                }

                if (customer != null && txtRequired != null && txtReceived != null && txtPaid != null && remain != null)
                {
                    int required = int.Parse(txtRequired.Content);
                    int received = int.Parse(txtReceived.Content);
                    int paid = int.Parse(txtPaid.Content);
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    DataBase.Registration(customer, required, received, paid, date);

                    int totalQuantity = int.Parse(remain.Text); 
                    int receivedQuantity = int.Parse(txtRequired.Content); 
                    int DeliveredQuantity = int.Parse(txtReceived.Content);
                    int money = int.Parse(txtPaid.Content);

                    remain.Text = (int.Parse(remain.Text) - receivedQuantity).ToString();
                    txtRequired.Content = remain.Text;

                    ReceivedRemain.Text = (int.Parse(ReceivedRemain.Text) - DeliveredQuantity).ToString();
                    txtReceived.Content = ReceivedRemain.Text;

                    price.Text = (int.Parse(price.Text) - money).ToString();
                    txtPaid.Content = price.Text;

                    btnRegister.Content = (int.Parse(btnRegister.Content) + 1).ToString();
                    btnRegister.NormalBackground = ThemeColors.Green;

                    if (
                        int.TryParse(remain.Text, out int value) &&
                        value == 0 &&
                        int.TryParse(ReceivedRemain.Text, out int value2) &&
                        value2 == 0 &&
                        int.TryParse(price.Text, out int value3) &&
                        value3 == 0)
                    {
                        FlowLayoutPanel? parentPanel = btnRegister.Parent as FlowLayoutPanel;
                        parentPanel.BackColor = ThemeManager.IsDarkMode ? ThemeColors.DarkCompleted : ThemeColors.LightCompleted;
                        completed.Add(parentPanel);
                        HoverEffect.Hover
                        (
                            new Control[] {parentPanel},
                            getDefaultValue: ctrl => ThemeManager.IsDarkMode ? ThemeColors.DarkCompleted : ThemeColors.LightCompleted,
                            getHoverValue: ctrl => ThemeManager.IsDarkMode ? ThemeColors.DarkHoverCompleted : ThemeColors.LightHoverCompleted,
                            setValue: (ctrl, value) =>
                            {
                                if (ctrl is FlowLayoutPanel panel)
                                {
                                    panel.BackColor = value;
                                }
                            },
                            interpolate: HoverEffect.InterpolateColor,
                            transitionDuration: 100
                        );
                    }
                }
            }
        }
        private void PnlCustomerContainer_MouseWheel(object sender, MouseEventArgs e)
        {
            if (isAddtionalDropDownExpanded)
                AdditionaldropDownTimer.Start();

            DisplayTheRest(sender);
        }
        private void pnlCustomerContainer_Scroll(object sender, ScrollEventArgs e)
        {
            if (isAddtionalDropDownExpanded)
                AdditionaldropDownTimer.Start();

            DisplayTheRest(sender);
        }
        void DisplayTheRest(object sender)
        {
            var scrollPanel = (FlowLayoutPanel)sender;
            int scrollThreshold = Settings.Default.scrollThreshold;
            if (scrollPanel.VerticalScroll.Value + scrollPanel.Height + scrollThreshold >= scrollPanel.VerticalScroll.Maximum)
            {
                DisplayTimer(customersToDisplay);
            }
        }
        public void RefreshData()
        {
            currentIndex = 0;
            targetIndex = 0;
            pnlCustomerContainer.Controls.Clear();
            DataBase.CustomersList = DataBase.RetrieveCustomerTable();
            DisplayTimer(DataBase.CustomersList);
        }
        #endregion

        #region Filter
        public void FilterCustomersByName(string searchQuery)
        {
            customersToDisplay = DataBase.CustomersList
                .Where(customer => customer["name"].ToString().Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
                .ToList();

            FilterCustomer();
        }
        public void FilterCustomersByID(string searchQuery)
        {
            customersToDisplay = DataBase.CustomersList
                .Where(customer => customer["CustomerID"].ToString().StartsWith(searchQuery))
                .ToList();
            FilterCustomer();
        }
        void FilterCustomer()
        {

            currentIndex = 0;
            targetIndex = 0;
            isLoading = false;

            pnlCustomerContainer.Controls.Clear();

            if (customersToDisplay.Count == 0)
            {
                Toast.Show("لم يتم العثور على أي نتائج.", ToastType.Error);
                return;
            }

            if (_renderTimer != null)
            {
                _renderTimer.Stop();
            }
            targetIndex = Math.Min(currentIndex + Settings.Default.batchSize, customersToDisplay.Count);

            _renderTimer.Tick -= RenderNextBatch;
            _renderTimer.Tick += RenderNextBatch;
            _renderTimer.Start();
        }
        #endregion

        #region Close Opened Drop-Down
        public bool isAddtionalDropDownExpanded = false;
        private void AdditionaldropDownTimer_Tick(object sender, EventArgs e)
        {
            if (isAddtionalDropDownExpanded)
            {
                if (pnlAddtionalDropDown.Height > 0)
                {
                    pnlAddtionalDropDown.Height -= 10;
                }
                else
                {
                    AdditionaldropDownTimer.Stop();
                    isAddtionalDropDownExpanded = false;

                    // If closing for reposition, reopen at the new position
                    if (isClosingForReposition && pnlAddtionalDropDown.Tag is IconButton newButton)
                    {
                        OpenDropDown(newButton);
                        isClosingForReposition = false;
                    }
                }
            }
            else
            {
                // Open the drop-down
                if (pnlAddtionalDropDown.Height < pnlAddtionalDropDown.MaximumSize.Height)
                {
                    pnlAddtionalDropDown.Height += 10;
                }
                else
                {
                    AdditionaldropDownTimer.Stop();
                    isAddtionalDropDownExpanded = true;
                }
            }
        }
        private bool isClosingForReposition = false;
        private void OpenDropDown(IconButton triggerButton)
        {
            // Get button location relative to the UserControl
            Point relativePos = this.PointToClient(triggerButton.PointToScreen(Point.Empty));

            int controlHeight = this.ClientSize.Height; // height of the UserControl

            int spaceBelow = controlHeight - (relativePos.Y + triggerButton.Height);
            int spaceAbove = relativePos.Y;

            int dropdownHeight = pnlAddtionalDropDown.MaximumSize.Height;

            int dropdownY;

            if (spaceBelow >= dropdownHeight)
            {
                dropdownY = triggerButton.PointToScreen(new Point(0, triggerButton.Height)).Y;
            }
            else if (spaceAbove >= dropdownHeight)
            {
                dropdownY = triggerButton.PointToScreen(new Point(0, -dropdownHeight)).Y;
            }
            else
            {
                dropdownY = triggerButton.PointToScreen(new Point(0, triggerButton.Height)).Y;
            }

            // Convert screen position to parent form space
            Point finalPosition = this.FindForm().PointToClient(new Point(triggerButton.PointToScreen(Point.Empty).X + triggerButton.Width, dropdownY));

            pnlAddtionalDropDown.Parent = this.FindForm();
            pnlAddtionalDropDown.Location = finalPosition;
            pnlAddtionalDropDown.BringToFront();

            foreach (Control ctrl in pnlAddtionalDropDown.Controls)
            {
                if (ctrl is cuiButton btn)
                    btn.Tag = triggerButton.Tag;
            }

            lastTriggerButton = triggerButton;
            isAddtionalDropDownExpanded = false;
            AdditionaldropDownTimer.Start();
        }

        private void CloseOpenedDropDown(Control control)
        {
            control.MouseDown -= Form1_MouseDown;
            control.MouseDown += Form1_MouseDown;
            foreach (Control child in control.Controls)
                CloseOpenedDropDown(child);
        }
        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (!pnlAddtionalDropDown.Bounds.Contains(PointToClient(MousePosition)) && isAddtionalDropDownExpanded)
                AdditionaldropDownTimer.Start();
            if (!_dashboard.pnlSearch.Bounds.Contains(PointToClient(MousePosition)) && _dashboard.srchExpanded)
                _dashboard.searchTimer.Start();
            if (!_dashboard.pnlAddDropDown.Bounds.Contains(PointToClient(MousePosition)) && _dashboard.isAddDropDownExpanded)
                _dashboard.addDropDownTimer.Start();
            if (!_dashboard.pnlHistory.Bounds.Contains(PointToClient(MousePosition)) && _dashboard.isHistoryExpanded)
                _dashboard.historyTimer.Start();
        }
        #endregion


        #region Drag, Drop & Scrolling
        public enum scrollDirection
        {
            Up,
            None,
            Down
        }
        scrollDirection direction = scrollDirection.None;
        private void drag_MouseDown(object? sender, MouseEventArgs e, FlowLayoutPanel customerPanel)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(customerPanel, DragDropEffects.Move);
            }
        }
        private void CustomerPanel_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(FlowLayoutPanel)))
            {
                e.Effect = DragDropEffects.Move;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

            Point clientPoint = pnlCustomerContainer.PointToClient(new Point(e.X, e.Y));

            if (clientPoint.Y >= pnlCustomerContainer.Height - 50)
            {
                direction = scrollDirection.Down;
                ScrollTimer.Start();
            }
            else if (clientPoint.Y <= 50)
            {
                direction = scrollDirection.Up;
                ScrollTimer.Start();
            }
            else
            {
                direction = scrollDirection.None;
                ScrollTimer.Stop();
            }
        }
        private void CustomerPanel_DragDrop(object? sender, DragEventArgs e)
        {
            FlowLayoutPanel? draggedPanel = e.Data.GetData(typeof(FlowLayoutPanel)) as FlowLayoutPanel;
            FlowLayoutPanel? targetPanel = sender as FlowLayoutPanel;

            if (draggedPanel != null && targetPanel != null && targetPanel.Parent is FlowLayoutPanel container)
            {

                int targetIndex = container.Controls.GetChildIndex(targetPanel);
                container.Controls.SetChildIndex(draggedPanel, targetIndex);

                UpdateCustomerIndexes(container);
            }

            ScrollTimer.Stop();
            direction = scrollDirection.None;
        }
        public void CustomerPanel_DragLeave(object? sender, EventArgs e)
        {
            ScrollTimer.Stop();
            direction = scrollDirection.None;
        }
        private void UpdateCustomerIndexes(FlowLayoutPanel container)
        {
            for (int i = 0; i < container.Controls.Count; i++)
            {
                if (container.Controls[i] is FlowLayoutPanel customerPanel)
                {
                    var customerId = customerPanel.Tag;

                    DataBase.UpdateCustomerIndex(customerId, i);
                }
            }
        }
        int scrollSpeed = 10;
        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            if (direction == scrollDirection.Down)
            {
                if (pnlCustomerContainer.VerticalScroll.Value + pnlCustomerContainer.VerticalScroll.SmallChange <= pnlCustomerContainer.VerticalScroll.Maximum)
                {
                    pnlCustomerContainer.VerticalScroll.Value += (pnlCustomerContainer.VerticalScroll.SmallChange + scrollSpeed);
                }
            }
            else if (direction == scrollDirection.Up)
            {
                if (pnlCustomerContainer.VerticalScroll.Value - pnlCustomerContainer.VerticalScroll.SmallChange >= pnlCustomerContainer.VerticalScroll.Minimum)
                {
                    pnlCustomerContainer.VerticalScroll.Value -= (pnlCustomerContainer.VerticalScroll.SmallChange + scrollSpeed);
                }
            }
        }
        #endregion
        private void btnReset_Click(object sender, EventArgs e)
        {
            AdditionaldropDownTimer.Start();
            if (sender is cuiButton btn)
            {
                if (btn.Tag is Dictionary<string, object> customer)
                {
                    if (
                        customer.TryGetValue("CustomerID", out var customerIdObj) &&
                        long.TryParse(customerIdObj.ToString(), out long customerId) &&
                        customer.TryGetValue("numberOfPeople", out var customerNumObj) &&
                        int.TryParse(customerNumObj.ToString(), out int customerNum)
                        )
                    {
                        Toast.Show("هل أنت متأكد من إعادة تعيين بيانات العميل؟", ToastType.YesNo, input =>
                        {
                            if (input)
                            {
                                if (ResetCustomerValues(customerId, customerNum, true))
                                {
                                    Toast.Show("تمت إعادة تعيين بيانات العميل بنجاح.", ToastType.Success);
                                    RefreshData();
                                }
                                else Toast.Show("فشل في إعادة تعيين بيانات العميل.", ToastType.Error);
                            }
                        });

                    }
                    else Toast.Show("بيانات العميل غير صالحة.", ToastType.Error);
                }
                else Toast.Show("لا توجد بيانات عميل مرتبطة بهذا الزر.", ToastType.Error);
            }
        }
        public static bool ResetCustomerValues(long customerId, int numberOfPeople, bool deleteStore)
        {
            try
            {
                int sack = Settings.Default.sack;
                int priceSetting = Settings.Default.price;
                int totalQuantity = numberOfPeople * (sack / 2);
                int price = totalQuantity * (priceSetting / sack);
                string date = DateTime.Now.ToString("yyyy-MM");

                return DataBase.ResetCustomer(customerId, totalQuantity, price, date, deleteStore);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"فشل في إعادة تعيين البيانات: {ex.Message}");
                return false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AdditionaldropDownTimer.Start();
            if(sender is cuiButton btn)
            {
                if (btn.Tag is Dictionary<string, object> customer)
                {
                    if (
                        customer.TryGetValue("CustomerID", out var customerIdObj) &&
                        long.TryParse(customerIdObj.ToString(), out long customerId) &&
                        customer.TryGetValue("name", out var customerNameObj) &&
                        customer.TryGetValue("numberOfPeople", out var customerNumObj) &&
                        int.TryParse(customerNumObj.ToString(), out int customerNum)
                        )
                    {
                        frmAddCustomer addCustomer = new frmAddCustomer(_dashboard);

                        addCustomer.txtCardID.Content = customerId.ToString();
                        addCustomer.txtName.Content = customerNameObj.ToString();
                        addCustomer.txtMembers.Content = customerNumObj.ToString();
                        addCustomer.txtQuantity.Content = (customerNum * (Settings.Default.sack / 2)).ToString();
                        addCustomer.txtPrice.Content = (customerNum * (Settings.Default.price / Settings.Default.sack) * (Settings.Default.sack / 2)).ToString();
                        addCustomer.btnAdd.Text = "تعديل";
                        addCustomer.btnAdd.Tag = "update";
                        addCustomer.Tag = customerId.ToString();

                        addCustomer.ShowDialog();

                    }
                }
                else Toast.Show("لا توجد بيانات عميل مرتبطة بهذا الزر.", ToastType.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AdditionaldropDownTimer.Start();
            if (sender is cuiButton btn) 
            {
                if (btn.Tag is Dictionary<string, object> customer)
                {
                    if (customer.TryGetValue("CustomerID", out var customerIdObj) &&
                        long.TryParse(customerIdObj.ToString(), out long customerId) &&
                        customer.TryGetValue("name", out var customerNameObj))
                    {
                        Toast.Show("هل أنت متأكد من حذف بيانات هذا العميل؟", ToastType.YesNo, input =>
                        {
                            if (input)
                            {
                                if (DataBase.DeleteCustomer(customerId))
                                {
                                    Toast.Show($"تم حذف العميل: {customerNameObj}.", ToastType.Success);

                                    RefreshData();
                                }
                                else Toast.Show("فشل حذف العميل.", ToastType.Error);
                            }
                        });
                    }
                }
                else Toast.Show("لا توجد بيانات عميل مرتبطة بهذا الزر.", ToastType.Error);
            }
        }
    }
}

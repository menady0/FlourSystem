using CuoreUI.Controls;
using FontAwesome.Sharp;

namespace FlourSystem.Forms.User_Control
{
    public partial class ucHome : UserControl
    {
        public static List<Dictionary<string, object>> CustomersList = new List<Dictionary<string, object>>();
        public ucHome()
        {
            InitializeComponent();
            CustomersList = DataBase.RetrieveCustomerTable();
        }
        private void ucHome_Load(object sender, EventArgs e)
        {
            DisplayCustomers(CustomersList);
            CloseOpenedSearch(this);
            #region Stop Watch
            //Stopwatch sw = Stopwatch.StartNew();
            //sw.Start();
            //DisplayCustomersIncrementally(CustomersList);
            //sw.Stop();
            //MessageBox.Show($"Time taken to load customers: {sw.ElapsedMilliseconds} ms");
            #endregion
        }
        #region Display Data
        void DisplayCustomers(List<Dictionary<string, object>> customers)
        {

            int index = 0;
            foreach (var customer in customers)
            {
                FlowLayoutPanel customerPanel = new FlowLayoutPanel
                {
                    Width = 1084,
                    Height = 40,
                    Font = new Font("Cairo", 10),
                    Padding = new Padding(10, 0, 10, 0),
                    Margin = new Padding(0, 0, 0, 0),
                    AllowDrop = true,
                    FlowDirection = FlowDirection.RightToLeft,
                    //Dock = DockStyle.Top,
                    //BackColor = Color.Gray,
                };
                //customerPanel.DragEnter += CustomerPanel_DragEnter;
                //customerPanel.DragDrop += CustomerPanel_DragDrop;

                IconPictureBox drag = new IconPictureBox
                {
                    IconChar = IconChar.GripVertical,
                    IconColor = Color.Gray,
                    IconSize = 20,
                    Width = 20,
                    Height = 40,
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Cursor = Cursors.Hand,
                };

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
                    Text = $"{int.Parse(customer["numberOfPeople"]?.ToString() ?? "0") * 10}",
                    Width = 85,
                    Height = 40,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Black,
                };
                Label lblRemain = new Label
                {
                    AutoSize = false,
                    Text = $"{customer["remainQuantity"]}",
                    Width = 85,
                    Height = 40,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Black,
                };
                cuiTextBox2 txtRequired = new cuiTextBox2
                {
                    Content = $"{customer["remainQuantity"]}",
                    Width = 85,
                    Height = 30,
                    Padding = new Padding(0),
                    Rounding = new Padding(5),
                    ForeColor = Color.Black,
                    BackgroundColor = ThemeColors.LightBackground,
                    BorderColor = Color.FromArgb(216, 220, 208),
                    FocusBackgroundColor = Color.Transparent,
                    FocusBorderColor = ThemeColors.Green,
                };
                cuiTextBox2 txtReceived = new cuiTextBox2
                {
                    Content = $"{customer["remainQuantity"]}",
                    Width = 85,
                    Height = 30,
                    Padding = new Padding(0),
                    Rounding = new Padding(5),
                    ForeColor = Color.Black,
                    BackgroundColor = ThemeColors.LightBackground,
                    BorderColor = Color.FromArgb(216, 220, 208),
                    FocusBackgroundColor = Color.Transparent,
                    FocusBorderColor = ThemeColors.Green,
                };
                Label lblPrice = new Label
                {
                    AutoSize = false,
                    Text = $"{customer["price"]}",
                    Width = 85,
                    Height = 40,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Black,
                };
                cuiTextBox2 txtPaid = new cuiTextBox2
                {
                    Name = "txtPaid",
                    Content = $"{customer["price"]}",
                    Width = 85,
                    Height = 30,
                    Padding = new Padding(0),
                    Rounding = new Padding(5),
                    ForeColor = Color.Black,
                    BackgroundColor = ThemeColors.LightBackground,
                    BorderColor = Color.FromArgb(216, 220, 208),
                    FocusBackgroundColor = Color.Transparent,
                    FocusBorderColor = ThemeColors.Green,
                };
                cuiButton btnRegister = new cuiButton
                {
                    Name = "btnRegister",
                    Content = $"{customer["registration"]}",
                    Width = 85,
                    Height = 25,
                    Rounding = new Padding(5),
                    Cursor = Cursors.Hand,
                    Margin = new Padding(0, 7, 0, 7),
                    ForeColor = Color.White,
                    NormalBackground = Color.FromArgb(85, 86, 82),
                    HoverBackground = Color.FromArgb(200, 71, 137, 75),
                    PressedBackground = Color.FromArgb(71, 137, 75),
                };
                Panel pnlAdditional = new Panel
                {
                    Width = 85,
                    Height = 40,
                    BackColor = Color.Transparent,
                    Padding = new Padding(25, 0, 25, 0),
                };
                IconButton btnAdditonals = new IconButton
                {
                    IconChar = IconChar.EllipsisV,
                    IconColor = ThemeColors.LightForeColor,
                    IconSize = 20,
                    Dock = DockStyle.Fill,
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance =
                    {
                        BorderSize = 0
                    },
                    BackColor = Color.Transparent,
                    Tag = customer["CustomerID"],
                };
                //btnAdditonals.Click += btnAdditonals_Click;
                btnAdditonals.Click += (sender, e) =>
                {
                    IconButton clickedButton = (IconButton)sender;

                    // Check if the drop-down is already expanded and associated with a different button
                    if (isAddtionalDropDownExpanded && pnlAddtionalDropDown.Tag != clickedButton)
                    {
                        // Close the drop-down first
                        pnlAddtionalDropDown.Tag = clickedButton; // Update the tag to the new button
                        _isClosingForReposition = true;
                        AdditionaldropDownTimer.Start();
                    }
                    else if (!isAddtionalDropDownExpanded)
                    {
                        // If the drop-down is not expanded, open it immediately
                        pnlAddtionalDropDown.Tag = clickedButton; // Associate the drop-down with the clicked button
                        OpenDropDown(clickedButton);
                    }
                    //if (isAddtionalDropDownExpanded && _currentlySelectedButton == btnAdditonals)
                    //{
                    //    AdditionaldropDownTimer.Start();
                    //}
                    //else if(isAddtionalDropDownExpanded && _currentlySelectedButton != btnAdditonals)
                    //{
                    //    AdditionaldropDownTimer.Start();
                    //}
                    //SelectedButton(btnAdditonals);

                    //Point location = btnAdditonals.PointToScreen(Point.Empty);
                    //Form? mainfrm = this.FindForm();
                    //Point drpdownLocation = mainfrm.PointToClient(new Point(location.X, location.Y + btnAdditonals.Height));
                    //pnlAddtionalDropDown.Location = drpdownLocation;


                    //// Bring the drop-down panel to the front and make it visible
                    //pnlAddtionalDropDown.Parent = this.FindForm();
                    //pnlAddtionalDropDown.BringToFront();
                    //AdditionaldropDownTimer.Start();
                };

                pnlAdditional.Controls.Add(btnAdditonals);

                customerPanel.Controls.Add(drag);
                customerPanel.Controls.Add(lblName);
                customerPanel.Controls.Add(lblTotal);
                customerPanel.Controls.Add(lblRemain);
                customerPanel.Controls.Add(txtRequired);
                customerPanel.Controls.Add(txtReceived);
                customerPanel.Controls.Add(lblPrice);
                customerPanel.Controls.Add(txtPaid);
                customerPanel.Controls.Add(btnRegister);
                customerPanel.Controls.Add(pnlAdditional);

                pnlCustomerContainer.Controls.Add(customerPanel);
                if(index % 2 == 0)
                {
                    customerPanel.BackColor = Color.FromArgb(216, 220, 208);
                    txtPaid.BackgroundColor = txtReceived.BackgroundColor = txtRequired.BackgroundColor = Color.FromArgb(216, 220, 208);
                    txtPaid.BorderColor = txtReceived.BorderColor = txtRequired.BorderColor = Color.FromArgb(196, 200, 188);
                    txtPaid.FocusBackgroundColor = txtReceived.FocusBackgroundColor = txtRequired.FocusBackgroundColor = Color.Transparent;
                    txtPaid.FocusBorderColor = txtReceived.FocusBorderColor = txtRequired.FocusBorderColor = ThemeColors.Green;
                }
                else
                {
                    customerPanel.BackColor = Color.Transparent;
                    txtPaid.BackgroundColor = txtReceived.BackgroundColor = txtRequired.BackgroundColor = ThemeColors.LightBackground;
                    txtPaid.BorderColor = txtReceived.BorderColor = txtRequired.BorderColor = Color.LightGray;
                    txtPaid.FocusBackgroundColor = txtReceived.FocusBackgroundColor = txtRequired.FocusBackgroundColor = ThemeColors.LightBackground;
                    txtPaid.FocusBorderColor = txtReceived.FocusBorderColor = txtRequired.FocusBorderColor = ThemeColors.Green;
                }
                index++;
            }
        }
        private bool _isClosingForReposition = false;
        private void OpenDropDown(IconButton? button)
        {
            Point location = button.PointToScreen(Point.Empty);
            Form? mainfrm = this.FindForm();
            Point drpdownLocation = mainfrm.PointToClient(new Point(location.X, location.Y + button.Height));
            pnlAddtionalDropDown.Location = drpdownLocation;

            // Bring the drop-down panel to the front and make it visible
            pnlAddtionalDropDown.Parent = this.FindForm();
            pnlAddtionalDropDown.BringToFront();
            AdditionaldropDownTimer.Start();
        }

        #endregion

        #region Display Data [Best For Performance]
        private int _currentIndex = 0;
        private List<Dictionary<string, object>> _customersToDisplay;
        System.Windows.Forms.Timer _renderTimer;
        public void DisplayCustomersIncrementally(List<Dictionary<string, object>> customers)
        {
            _customersToDisplay = customers;
            _currentIndex = 0;

            pnlCustomerContainer.Controls.Clear();

            // Initialize and start the timer
            _renderTimer = new System.Windows.Forms.Timer();
            _renderTimer.Interval = 50; // Render every 50ms
            _renderTimer.Tick += RenderNextBatch;
            _renderTimer.Start();
        }
        private void RenderNextBatch(object? sender, EventArgs e)
        {
            int batchSize = 10; // Number of rows to render per tick
            int endIndex = Math.Min(_currentIndex + batchSize, _customersToDisplay.Count);

            for (int i = _currentIndex; i < endIndex; i++)
            {
                var customer = _customersToDisplay[i];
                FlowLayoutPanel customerPanel = CreateCustomerPanel(customer);
                pnlCustomerContainer.Controls.Add(customerPanel);
            }

            _currentIndex = endIndex;

            if (_currentIndex >= _customersToDisplay.Count)
            {
                _renderTimer.Stop();
                _renderTimer.Dispose();
            }
        }
        int index = 0;
        private FlowLayoutPanel CreateCustomerPanel(Dictionary<string, object> customer)
        {
            FlowLayoutPanel customerPanel = new FlowLayoutPanel
            {
                Width = 1084,
                Height = 40,
                Font = new Font("Cairo", 10),
                Padding = new Padding(10, 0, 10, 0),
                Margin = new Padding(0, 0, 0, 0),
                AllowDrop = true,
                FlowDirection = FlowDirection.RightToLeft,
            };

            IconPictureBox drag = new IconPictureBox
            {
                IconChar = IconChar.GripVertical,
                IconColor = Color.Gray,
                IconSize = 20,
                Width = 20,
                Height = 40,
                SizeMode = PictureBoxSizeMode.CenterImage,
                Cursor = Cursors.Hand,
            };

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
                Text = $"{int.Parse(customer["numberOfPeople"]?.ToString() ?? "0") * 10}",
                Width = 85,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
            };
            Label lblRemain = new Label
            {
                AutoSize = false,
                Text = $"{customer["remainQuantity"]}",
                Width = 85,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
            };
            cuiTextBox2 txtRequired = new cuiTextBox2
            {
                Content = $"{customer["remainQuantity"]}",
                Width = 85,
                Height = 30,
                Padding = new Padding(0),
                Rounding = new Padding(5),
                ForeColor = Color.Black,
                BackgroundColor = ThemeColors.LightBackground,
                BorderColor = Color.FromArgb(216, 220, 208),
                FocusBackgroundColor = Color.Transparent,
                FocusBorderColor = ThemeColors.Green,
            };
            cuiTextBox2 txtReceived = new cuiTextBox2
            {
                Content = $"{customer["remainQuantity"]}",
                Width = 85,
                Height = 30,
                Padding = new Padding(0),
                Rounding = new Padding(5),
                ForeColor = Color.Black,
                BackgroundColor = ThemeColors.LightBackground,
                BorderColor = Color.FromArgb(216, 220, 208),
                FocusBackgroundColor = Color.Transparent,
                FocusBorderColor = ThemeColors.Green,
            };
            Label lblPrice = new Label
            {
                AutoSize = false,
                Text = $"{customer["price"]}",
                Width = 85,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
            };
            cuiTextBox2 txtPaid = new cuiTextBox2
            {
                Name = "txtPaid",
                Content = $"{customer["price"]}",
                Width = 85,
                Height = 30,
                Padding = new Padding(0),
                Rounding = new Padding(5),
                ForeColor = Color.Black,
                BackgroundColor = ThemeColors.LightBackground,
                BorderColor = Color.FromArgb(216, 220, 208),
                FocusBackgroundColor = Color.Transparent,
                FocusBorderColor = ThemeColors.Green,
            };
            cuiButton btnRegister = new cuiButton
            {
                Name = "btnRegister",
                Content = $"{customer["registration"]}",
                Width = 85,
                Height = 25,
                Rounding = new Padding(5),
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 7, 0, 7),
                ForeColor = Color.White,
                NormalBackground = Color.FromArgb(85, 86, 82),
                HoverBackground = Color.FromArgb(200, 71, 137, 75),
                PressedBackground = Color.FromArgb(71, 137, 75),
            };
            Panel pnlAdditional = new Panel
            {
                Width = 85,
                Height = 40,
                BackColor = Color.Transparent,
                Padding = new Padding(25, 0, 25, 0),
            };
            IconButton btnAdditonals = new IconButton
            {
                IconChar = IconChar.EllipsisV,
                IconColor = ThemeColors.LightForeColor,
                IconSize = 20,
                Dock = DockStyle.Fill,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance =
                    {
                        BorderSize = 0
                    },
                BackColor = Color.Transparent,
            };

            btnAdditonals.Click += (sender, e) =>
            {
                if (isAddtionalDropDownExpanded)
                {
                    pnlAddtionalDropDown.Height = 0;
                    isAddtionalDropDownExpanded = false;
                }
                // Calculate the new position for the drop-down panel
                Point panelPosition = customerPanel.PointToScreen(Point.Empty);
                pnlAddtionalDropDown.Location = new Point(
                    panelPosition.X,
                    panelPosition.Y
                );

                // Bring the drop-down panel to the front and make it visible
                pnlAddtionalDropDown.Parent = this.FindForm();
                pnlAddtionalDropDown.BringToFront();
                AdditionaldropDownTimer.Start();
            };
            pnlAdditional.Controls.Add(btnAdditonals);

            customerPanel.Controls.Add(drag);
            customerPanel.Controls.Add(lblName);
            customerPanel.Controls.Add(lblTotal);
            customerPanel.Controls.Add(lblRemain);
            customerPanel.Controls.Add(txtRequired);
            customerPanel.Controls.Add(txtReceived);
            customerPanel.Controls.Add(lblPrice);
            customerPanel.Controls.Add(txtPaid);
            customerPanel.Controls.Add(btnRegister);
            customerPanel.Controls.Add(pnlAdditional);

            pnlCustomerContainer.Controls.Add(customerPanel);
            if (index % 2 == 0)
            {
                customerPanel.BackColor = Color.FromArgb(216, 220, 208);
                txtPaid.BackgroundColor = txtReceived.BackgroundColor = txtRequired.BackgroundColor = Color.FromArgb(216, 220, 208);
                txtPaid.BorderColor = txtReceived.BorderColor = txtRequired.BorderColor = Color.FromArgb(196, 200, 188);
                txtPaid.FocusBackgroundColor = txtReceived.FocusBackgroundColor = txtRequired.FocusBackgroundColor = Color.Transparent;
                txtPaid.FocusBorderColor = txtReceived.FocusBorderColor = txtRequired.FocusBorderColor = ThemeColors.Green;
            }
            else
            {
                customerPanel.BackColor = Color.Transparent;
                txtPaid.BackgroundColor = txtReceived.BackgroundColor = txtRequired.BackgroundColor = ThemeColors.LightBackground;
                txtPaid.BorderColor = txtReceived.BorderColor = txtRequired.BorderColor = Color.LightGray;
                txtPaid.FocusBackgroundColor = txtReceived.FocusBackgroundColor = txtRequired.FocusBackgroundColor = ThemeColors.LightBackground;
                txtPaid.FocusBorderColor = txtReceived.FocusBorderColor = txtRequired.FocusBorderColor = ThemeColors.Green;
            }
            index++;
            return customerPanel;
        }
        #endregion

        #region Filter
        public void FilterCustomersByName(string searchQuery)
        {
            var filteredCustomers = CustomersList
                .Where(customer => customer["name"].ToString().Contains(searchQuery))
                .ToList();

            pnlCustomerContainer.Controls.Clear();
            DisplayCustomers(filteredCustomers);
        }
        public void FilterCustomersByID(string searchQuery)
        {
            var filteredCustomers = CustomersList
                .Where(customer => customer["CustomerID"].ToString().StartsWith(searchQuery))
                .ToList();

            pnlCustomerContainer.Controls.Clear();
            DisplayCustomers(filteredCustomers);
        }
        #endregion

        #region Close Opened Drop-Down
        bool isAddtionalDropDownExpanded = false;
        private void AdditionaldropDownTimer_Tick(object sender, EventArgs e)
        {
            if (isAddtionalDropDownExpanded)
            {
                // Close the drop-down
                if (pnlAddtionalDropDown.Height > 0)
                {
                    pnlAddtionalDropDown.Height -= 10;
                }
                else
                {
                    AdditionaldropDownTimer.Stop();
                    isAddtionalDropDownExpanded = false;

                    // If closing for reposition, reopen at the new position
                    if (_isClosingForReposition && pnlAddtionalDropDown.Tag is IconButton newButton)
                    {
                        OpenDropDown(newButton);
                        _isClosingForReposition = false;
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
        private void CloseOpenedSearch(Control control)
        {
            control.MouseDown += Form1_MouseDown;
            foreach (Control child in control.Controls)
                CloseOpenedSearch(child);
        }
        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (!pnlAddtionalDropDown.Bounds.Contains(PointToClient(MousePosition)) && isAddtionalDropDownExpanded)
                AdditionaldropDownTimer.Start();
        }
        #endregion

        public void RefreshData()
        {
            pnlCustomerContainer.Controls.Clear();
            CustomersList = DataBase.RetrieveCustomerTable();
            DisplayCustomers(CustomersList);
        }

    }
}

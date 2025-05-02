using CuoreUI.Controls;
using FlourSystem.Forms.User_Control.ucHomeBtns;
using FontAwesome.Sharp;
using System;
using System.Diagnostics;

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
            CloseOpenedSearch(this);
            #region Stop Watch
            //Stopwatch sw = Stopwatch.StartNew();
            //sw.Start();
            //sw.Stop();
            //MessageBox.Show($"Time taken to load customers: {sw.ElapsedMilliseconds} ms");
            #endregion
        }



        #region Display Data
        //void DisplayCustomers(List<Dictionary<string, object>> customers)
        //{

        //    int index = 0;
        //    foreach (var customer in customers)
        //    {
        //        FlowLayoutPanel customerPanel = new FlowLayoutPanel
        //        {
        //            Width = 1067,
        //            Height = 40,
        //            Font = new Font("Cairo", 10),
        //            Padding = new Padding(10, 0, 10, 0),
        //            Margin = new Padding(0, 0, 0, 0),
        //            AllowDrop = true,
        //            FlowDirection = FlowDirection.RightToLeft,
        //            //Dock = DockStyle.Top,
        //            //BackColor = Color.Gray,
        //        };
        //        //customerPanel.DragEnter += CustomerPanel_DragEnter;
        //        //customerPanel.DragDrop += CustomerPanel_DragDrop;

        //        IconPictureBox drag = new IconPictureBox
        //        {
        //            IconChar = IconChar.GripVertical,
        //            IconColor = Color.Gray,
        //            IconSize = 20,
        //            Width = 20,
        //            Height = 40,
        //            SizeMode = PictureBoxSizeMode.CenterImage,
        //            Cursor = Cursors.Hand,
        //        };

        //        Label lblName = new Label
        //        {
        //            AutoSize = false,
        //            Text = $"{customer["name"]}",
        //            Width = 270,
        //            Height = 40,
        //            TextAlign = ContentAlignment.MiddleRight,
        //            ForeColor = Color.Black,
        //        };
        //        Label lblTotal = new Label
        //        {
        //            AutoSize = false,
        //            Text = $"{int.Parse(customer["numberOfPeople"]?.ToString() ?? "0") * 10}",
        //            Width = 85,
        //            Height = 40,
        //            TextAlign = ContentAlignment.MiddleCenter,
        //            ForeColor = Color.Black,
        //        };
        //        Label lblRemain = new Label
        //        {
        //            AutoSize = false,
        //            Text = $"{customer["remainQuantity"]}",
        //            Width = 85,
        //            Height = 40,
        //            TextAlign = ContentAlignment.MiddleCenter,
        //            ForeColor = Color.Black,
        //        };
        //        cuiTextBox2 txtRequired = new cuiTextBox2
        //        {
        //            Content = $"{customer["remainQuantity"]}",
        //            Width = 85,
        //            Height = 30,
        //            Padding = new Padding(0),
        //            Rounding = new Padding(5),
        //            ForeColor = Color.Black,
        //            BackgroundColor = ThemeColors.LightBackground,
        //            BorderColor = Color.FromArgb(216, 220, 208),
        //            FocusBackgroundColor = Color.Transparent,
        //            FocusBorderColor = ThemeColors.Green,
        //        };
        //        cuiTextBox2 txtReceived = new cuiTextBox2
        //        {
        //            Content = $"{customer["remainQuantity"]}",
        //            Width = 85,
        //            Height = 30,
        //            Padding = new Padding(0),
        //            Rounding = new Padding(5),
        //            ForeColor = Color.Black,
        //            BackgroundColor = ThemeColors.LightBackground,
        //            BorderColor = Color.FromArgb(216, 220, 208),
        //            FocusBackgroundColor = Color.Transparent,
        //            FocusBorderColor = ThemeColors.Green,
        //        };
        //        Label lblPrice = new Label
        //        {
        //            AutoSize = false,
        //            Text = $"{customer["price"]}",
        //            Width = 85,
        //            Height = 40,
        //            TextAlign = ContentAlignment.MiddleCenter,
        //            ForeColor = Color.Black,
        //        };
        //        cuiTextBox2 txtPaid = new cuiTextBox2
        //        {
        //            Name = "txtPaid",
        //            Content = $"{customer["price"]}",
        //            Width = 85,
        //            Height = 30,
        //            Padding = new Padding(0),
        //            Rounding = new Padding(5),
        //            ForeColor = Color.Black,
        //            BackgroundColor = ThemeColors.LightBackground,
        //            BorderColor = Color.FromArgb(216, 220, 208),
        //            FocusBackgroundColor = Color.Transparent,
        //            FocusBorderColor = ThemeColors.Green,
        //        };

        //        cuiButton btnRegister = new cuiButton
        //        {
        //            Name = "btnRegister",
        //            Content = $"{customer["registration"]}",
        //            Width = 85,
        //            Height = 25,
        //            Rounding = new Padding(5),
        //            Cursor = Cursors.Hand,
        //            Margin = new Padding(0, 7, 0, 7),
        //            ForeColor = Color.White,
        //            NormalBackground = Color.FromArgb(85, 86, 82),
        //            HoverBackground = Color.FromArgb(200, 71, 137, 75),
        //            PressedBackground = Color.FromArgb(71, 137, 75),
        //        };
        //        Panel pnlAdditional = new Panel
        //        {
        //            Width = 85,
        //            Height = 40,
        //            BackColor = Color.Transparent,
        //            Padding = new Padding(25, 0, 25, 0),
        //        };
        //        IconButton btnAdditonals = new IconButton
        //        {
        //            IconChar = IconChar.EllipsisV,
        //            IconColor = ThemeColors.LightForeColor,
        //            IconSize = 20,
        //            Dock = DockStyle.Fill,
        //            Cursor = Cursors.Hand,
        //            FlatStyle = FlatStyle.Flat,
        //            FlatAppearance =
        //            {
        //                BorderSize = 0
        //            },
        //            BackColor = Color.Transparent,
        //            Tag = customer["CustomerID"],
        //        };
        //        btnAdditonals.Click += (sender, e) =>
        //        {
        //            IconButton clickedButton = (IconButton)sender;

        //            // Check if the drop-down is already expanded and associated with a different button
        //            if (isAddtionalDropDownExpanded && pnlAddtionalDropDown.Tag != clickedButton)
        //            {
        //                // Close the drop-down first
        //                pnlAddtionalDropDown.Tag = clickedButton; // Update the tag to the new button
        //                _isClosingForReposition = true;
        //                AdditionaldropDownTimer.Start();
        //            }
        //            else if (!isAddtionalDropDownExpanded)
        //            {
        //                // If the drop-down is not expanded, open it immediately
        //                pnlAddtionalDropDown.Tag = clickedButton; // Associate the drop-down with the clicked button
        //                OpenDropDown(clickedButton);
        //            }
        //        };

        //        pnlAdditional.Controls.Add(btnAdditonals);

        //        customerPanel.Controls.Add(drag);
        //        customerPanel.Controls.Add(lblName);
        //        customerPanel.Controls.Add(lblTotal);
        //        customerPanel.Controls.Add(lblRemain);
        //        customerPanel.Controls.Add(txtRequired);
        //        customerPanel.Controls.Add(txtReceived);
        //        customerPanel.Controls.Add(lblPrice);
        //        customerPanel.Controls.Add(txtPaid);
        //        customerPanel.Controls.Add(btnRegister);
        //        customerPanel.Controls.Add(pnlAdditional);

        //        pnlCustomerContainer.Controls.Add(customerPanel);
        //        if (index % 2 == 0)
        //        {
        //            customerPanel.BackColor = Color.FromArgb(216, 220, 208);
        //            txtPaid.BackgroundColor = txtReceived.BackgroundColor = txtRequired.BackgroundColor = Color.FromArgb(216, 220, 208);
        //            txtPaid.BorderColor = txtReceived.BorderColor = txtRequired.BorderColor = Color.FromArgb(196, 200, 188);
        //            txtPaid.FocusBackgroundColor = txtReceived.FocusBackgroundColor = txtRequired.FocusBackgroundColor = Color.Transparent;
        //        }
        //        else
        //        {
        //            customerPanel.BackColor = Color.Transparent;
        //            txtPaid.BackgroundColor = txtReceived.BackgroundColor = txtRequired.BackgroundColor = ThemeColors.LightBackground;
        //            txtPaid.BorderColor = txtReceived.BorderColor = txtRequired.BorderColor = Color.LightGray;
        //            txtPaid.FocusBackgroundColor = txtReceived.FocusBackgroundColor = txtRequired.FocusBackgroundColor = Color.Transparent;
        //        }
        //        txtPaid.FocusBorderColor = txtReceived.FocusBorderColor = txtRequired.FocusBorderColor = ThemeColors.Green;
        //        index++;
        //    }
        //}
        #endregion



        private bool isClosingForReposition = false;
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

        #region Display Data [Best For Performance]

        private int batchSize = 25;
        private bool isLoading = false;
        public int currentIndex = 0;
        public int targetIndex = 0;

        private List<Dictionary<string, object>> customersToDisplay;
        public void DisplayTimer(List<Dictionary<string, object>> customers)
        {
            customersToDisplay = customers;
            // Change Min To Max: To Display All Customers at once
            targetIndex = Math.Min(currentIndex + batchSize, customersToDisplay.Count);

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
            }

            currentIndex = endIndex;

            if (currentIndex >= targetIndex)
            {
                _renderTimer.Stop();
                isLoading = false;
            }
        }
        int index = 0;
        private FlowLayoutPanel CreateCustomerPanel(Dictionary<string, object> customer)
        {
            FlowLayoutPanel customerPanel = new FlowLayoutPanel
            {
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
                IconChar = IconChar.GripVertical,
                IconColor = Color.Gray,
                IconSize = 20,
                Width = 20,
                Height = 40,
                SizeMode = PictureBoxSizeMode.CenterImage,
                Cursor = Cursors.Hand,
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
            txtRequired.ContentChanged += (sender, e) => txtRequired_ContentChanged(sender, e, txtReceived, txtPaid);

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
                Tag = new { Customer = customer, Remain = lblRemain, Required = txtRequired, Price = lblPrice, Paid = txtPaid, Received = txtReceived },
            };
            if (btnRegister.Content != "0") btnRegister.NormalBackground = Color.FromArgb(71, 137, 75);
            btnRegister.Click += btnRegister_Click;


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
                Tag = customer,
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

                foreach(Control ctrl in pnlAddtionalDropDown.Controls)
                {
                    if (ctrl is cuiButton btn) 
                        btn.Tag = btnAdditonals.Tag;
                }

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
            }
            else
            {
                customerPanel.BackColor = Color.Transparent;
                txtPaid.BackgroundColor = txtReceived.BackgroundColor = txtRequired.BackgroundColor = ThemeColors.LightBackground;
                txtPaid.BorderColor = txtReceived.BorderColor = txtRequired.BorderColor = Color.LightGray;
            }
            txtPaid.FocusBackgroundColor = txtReceived.FocusBackgroundColor = txtRequired.FocusBackgroundColor = Color.Transparent;
            txtPaid.FocusBorderColor = txtReceived.FocusBorderColor = txtRequired.FocusBorderColor = ThemeColors.Green;
            index++;
            return customerPanel;
        }
        private void txtRequired_ContentChanged(object? sender, EventArgs e, cuiTextBox2 txtReceived, cuiTextBox2 txtPaid)
        {
            if (sender is cuiTextBox2 req)
            {
                if (int.TryParse(req.Content, out int reqValue))
                {
                    txtReceived.Content = reqValue.ToString();
                    txtPaid.Content = (reqValue * 3).ToString();
                }
                else
                {
                    txtReceived.Content = "0";
                    txtPaid.Content = "0";
                }
            }
        }
        private void btnRegister_Click(object? sender, EventArgs e)
        {
            if (sender is cuiButton btnRegister)
            {
                dynamic? tag = btnRegister.Tag;
                Dictionary<string, object> customer = tag.Customer;

                Label remain = tag.Remain;
                cuiTextBox2 txtRequired = tag.Required;

                cuiTextBox2 txtReceived = tag.Received;

                Label price = tag.Price;
                cuiTextBox2 txtPaid = tag.Paid;

                if (
                    string.IsNullOrEmpty(txtReceived.Content) ||
                    string.IsNullOrEmpty(txtRequired.Content) ||
                    string.IsNullOrEmpty(txtPaid.Content)
                    )
                {
                    MessageBox.Show("Can't Leave one of the fields empty!");
                    return;
                }
                if (
                    int.TryParse(txtRequired.Content, out int reqValue) &&
                    int.TryParse(txtReceived.Content, out int recValue) &&
                    int.TryParse(txtPaid.Content, out int paidValue))
                {
                    if (
                        reqValue <= 0 ||
                        reqValue > int.Parse(customer["remainQuantity"].ToString()) ||
                        recValue <= 0 ||
                        recValue > int.Parse(customer["remainQuantity"].ToString()) ||
                        paidValue <= 0 ||
                        paidValue > int.Parse(customer["price"].ToString())
                        )
                    {
                        MessageBox.Show("Quantity exceeds the remaining quantity.");
                        return;
                    }
                    int currentMonth = DateTime.Now.Month;
                    int currentYear = DateTime.Now.Year;
                    DataBase.balance = DataBase.AmountPerKG(currentMonth, currentYear) - DataBase.Store(currentMonth, currentYear);
                    if (reqValue > DataBase.balance)
                    {
                        MessageBox.Show("Not enough balance.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
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
                    //totalQuantity *= 10;
                    int receivedQuantity = int.Parse(txtRequired.Content);
                    MessageBox.Show($"{totalQuantity} - {receivedQuantity}");
                    remain.Text = (totalQuantity - receivedQuantity).ToString();
                    txtRequired.Content = remain.Text;
                    txtReceived.Content = remain.Text;
                    price.Text = (int.Parse(remain.Text) * 3).ToString();
                    txtPaid.Content = price.Text;

                    btnRegister.Content = (int.Parse(btnRegister.Content) + 1).ToString();
                    btnRegister.NormalBackground = Color.Green;
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
            DisplayTheRest(sender);
        }
        void DisplayTheRest(object sender)
        {
            var scrollPanel = (FlowLayoutPanel)sender;
            int scrollThreshold = 200;
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
                MessageBox.Show("No results found.");
                return;
            }

            if (_renderTimer != null)
            {
                _renderTimer.Stop();
            }
            targetIndex = Math.Min(currentIndex + batchSize, customersToDisplay.Count);

            _renderTimer.Tick -= RenderNextBatch;
            _renderTimer.Tick += RenderNextBatch;
            _renderTimer.Start();
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
                        int.TryParse(customerIdObj.ToString(), out int customerId) &&
                        customer.TryGetValue("numberOfPeople", out var customerNumObj) &&
                        int.TryParse(customerNumObj.ToString(), out int customerNum)
                        )
                    {
                        var result = MessageBox.Show(
                            "Are you sure you want to reset this customer's data?",
                            "Confirm Reset",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.Yes)
                        {
                            int totalQuantity = customerNum * 10;
                            int price = totalQuantity * 3;
                            string date = DateTime.Now.ToString("yyyy-MM");
                            if (DataBase.ResetCustomer(customerId, totalQuantity, price, date))
                            {
                                MessageBox.Show("Customer data reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                RefreshData();
                            }
                            else MessageBox.Show("Failed to reset customer data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else MessageBox.Show("Invalid customer data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("No customer data associated with this button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AdditionaldropDownTimer.Start();
            if(sender is cuiButton btn)
            {
                if (btn.Tag is Dictionary<string, object> customer) 
                {
                    if(
                        customer.TryGetValue("CustomerID", out var customerIdObj) &&
                        int.TryParse(customerIdObj.ToString(), out int customerId) &&
                        customer.TryGetValue("name", out var customerNameObj) &&
                        customer.TryGetValue("numberOfPeople", out var customerNumObj) &&
                        int.TryParse(customerNumObj.ToString(), out int customerNum)
                        )
                    {
                        frmAddCustomer addCustomer = new frmAddCustomer(_dashboard);

                        addCustomer.txtCardID.Content = customerId.ToString();
                        addCustomer.txtName.Content = customerNameObj.ToString();
                        addCustomer.txtMembers.Content = customerNumObj.ToString();
                        addCustomer.txtQuantity.Content = (customerNum * 10).ToString();
                        addCustomer.txtPrice.Content = (customerNum * 10 * 3).ToString();
                        addCustomer.btnAdd.Text = "تعديل";
                        addCustomer.btnAdd.Tag = "update";
                        addCustomer.Tag = customerId.ToString();

                        addCustomer.ShowDialog();

                    }
                        
                }
                else MessageBox.Show("No customer data associated with this button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AdditionaldropDownTimer.Start();
            if (sender is cuiButton btn) 
            {
                if(btn.Tag is Dictionary<string, object> customer)
                {
                    if (customer.TryGetValue("CustomerID", out var customerIdObj) && 
                        int.TryParse(customerIdObj.ToString(), out int customerId) &&
                        customer.TryGetValue("name", out var customerNameObj))
                    {
                        var result = MessageBox.Show(
                            "Are you sure you want to delete this customer's data?",
                            "Confirm Reset",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.Yes)
                        {
                            if (DataBase.DeleteCustomer(customerId))
                            {
                                MessageBox.Show($"Customer: {customerNameObj} with the ID: {customerId} is deleted successfully");
                                RefreshData();
                            }
                            else
                                MessageBox.Show($"Failed to delete customer: {customerNameObj} with the ID: {customerId}");
                        }
                    }
                }
                else MessageBox.Show("No customer data associated with this button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

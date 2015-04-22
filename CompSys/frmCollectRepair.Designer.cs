namespace CompSys
{
    partial class frmCollectRepair
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCollectRepair));
            this.payTab = new System.Windows.Forms.TabPage();
            this.btnCollect = new System.Windows.Forms.Button();
            this.CollectedDate = new System.Windows.Forms.DateTimePicker();
            this.lblCol = new System.Windows.Forms.Label();
            this.tableTotal = new System.Windows.Forms.TableLayoutPanel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbVat = new System.Windows.Forms.TextBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.listViewBox = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BillToTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRepairID = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chooseTab = new System.Windows.Forms.TabPage();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.rbRepDate = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbModel = new System.Windows.Forms.RadioButton();
            this.rbProb = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbDevice = new System.Windows.Forms.RadioButton();
            this.dgvListRepairs = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabCollectRepair = new System.Windows.Forms.TabControl();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnBack = new System.Windows.Forms.Button();
            this.prnDialog = new System.Windows.Forms.PrintDialog();
            this.prnDocument = new System.Drawing.Printing.PrintDocument();
            this.payTab.SuspendLayout();
            this.tableTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.chooseTab.SuspendLayout();
            this.gbSortBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRepairs)).BeginInit();
            this.tabCollectRepair.SuspendLayout();
            this.SuspendLayout();
            // 
            // payTab
            // 
            this.payTab.BackColor = System.Drawing.Color.Snow;
            this.payTab.Controls.Add(this.btnCollect);
            this.payTab.Controls.Add(this.CollectedDate);
            this.payTab.Controls.Add(this.lblCol);
            this.payTab.Controls.Add(this.tableTotal);
            this.payTab.Controls.Add(this.listViewBox);
            this.payTab.Controls.Add(this.BillToTextBox);
            this.payTab.Controls.Add(this.label1);
            this.payTab.Controls.Add(this.tbRepairID);
            this.payTab.Controls.Add(this.AddressTextBox);
            this.payTab.Controls.Add(this.pictureBox1);
            this.payTab.Location = new System.Drawing.Point(4, 29);
            this.payTab.Name = "payTab";
            this.payTab.Padding = new System.Windows.Forms.Padding(3);
            this.payTab.Size = new System.Drawing.Size(698, 440);
            this.payTab.TabIndex = 3;
            this.payTab.Text = "Payment";
            // 
            // btnCollect
            // 
            this.btnCollect.BackColor = System.Drawing.SystemColors.Info;
            this.btnCollect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCollect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCollect.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollect.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCollect.Image = global::CompSys.Properties.Resources.iconPay;
            this.btnCollect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCollect.Location = new System.Drawing.Point(221, 383);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(232, 57);
            this.btnCollect.TabIndex = 40;
            this.btnCollect.Text = "Make Payment";
            this.btnCollect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCollect.UseCompatibleTextRendering = true;
            this.btnCollect.UseVisualStyleBackColor = false;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // CollectedDate
            // 
            this.CollectedDate.CustomFormat = "dd-MMM-yy";
            this.CollectedDate.Enabled = false;
            this.CollectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CollectedDate.Location = new System.Drawing.Point(7, 305);
            this.CollectedDate.Name = "CollectedDate";
            this.CollectedDate.Size = new System.Drawing.Size(103, 21);
            this.CollectedDate.TabIndex = 39;
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(3, 282);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(106, 20);
            this.lblCol.TabIndex = 38;
            this.lblCol.Text = "Repair Date";
            // 
            // tableTotal
            // 
            this.tableTotal.BackColor = System.Drawing.Color.BurlyWood;
            this.tableTotal.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableTotal.ColumnCount = 2;
            this.tableTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.14286F));
            this.tableTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.85714F));
            this.tableTotal.Controls.Add(this.btnCalculate, 0, 3);
            this.tableTotal.Controls.Add(this.label5, 0, 0);
            this.tableTotal.Controls.Add(this.label3, 0, 2);
            this.tableTotal.Controls.Add(this.tbSubtotal, 1, 0);
            this.tableTotal.Controls.Add(this.tbVat, 1, 1);
            this.tableTotal.Controls.Add(this.tbDiscount, 1, 2);
            this.tableTotal.Controls.Add(this.label6, 0, 1);
            this.tableTotal.Controls.Add(this.tbTotal, 1, 3);
            this.tableTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableTotal.Location = new System.Drawing.Point(516, 284);
            this.tableTotal.Name = "tableTotal";
            this.tableTotal.RowCount = 4;
            this.tableTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableTotal.Size = new System.Drawing.Size(176, 103);
            this.tableTotal.TabIndex = 37;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(4, 79);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(65, 20);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Total";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Subtotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Discount";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Enabled = false;
            this.tbSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubtotal.Location = new System.Drawing.Point(76, 4);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(93, 20);
            this.tbSubtotal.TabIndex = 11;
            // 
            // tbVat
            // 
            this.tbVat.BackColor = System.Drawing.SystemColors.Info;
            this.tbVat.Enabled = false;
            this.tbVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVat.Location = new System.Drawing.Point(76, 30);
            this.tbVat.Name = "tbVat";
            this.tbVat.Size = new System.Drawing.Size(66, 20);
            this.tbVat.TabIndex = 9;
            // 
            // tbDiscount
            // 
            this.tbDiscount.BackColor = System.Drawing.SystemColors.Info;
            this.tbDiscount.Enabled = false;
            this.tbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscount.Location = new System.Drawing.Point(76, 54);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(93, 20);
            this.tbDiscount.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "VAT %";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(76, 79);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(93, 20);
            this.tbTotal.TabIndex = 12;
            // 
            // listViewBox
            // 
            this.listViewBox.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewBox.BackColor = System.Drawing.Color.DimGray;
            this.listViewBox.CheckBoxes = true;
            this.listViewBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.PartName,
            this.Quantity,
            this.Price});
            this.listViewBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBox.ForeColor = System.Drawing.SystemColors.Control;
            this.listViewBox.FullRowSelect = true;
            this.listViewBox.GridLines = true;
            this.listViewBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBox.HideSelection = false;
            this.listViewBox.HoverSelection = true;
            this.listViewBox.Location = new System.Drawing.Point(7, 140);
            this.listViewBox.Name = "listViewBox";
            this.listViewBox.ShowItemToolTips = true;
            this.listViewBox.Size = new System.Drawing.Size(685, 141);
            this.listViewBox.TabIndex = 36;
            this.listViewBox.UseCompatibleStateImageBehavior = false;
            this.listViewBox.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 55;
            // 
            // PartName
            // 
            this.PartName.Text = "Part Name";
            this.PartName.Width = 453;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Qty";
            this.Quantity.Width = 70;
            // 
            // Price
            // 
            this.Price.Text = "Price €";
            this.Price.Width = 103;
            // 
            // BillToTextBox
            // 
            this.BillToTextBox.AcceptsReturn = true;
            this.BillToTextBox.Enabled = false;
            this.BillToTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillToTextBox.Location = new System.Drawing.Point(460, 30);
            this.BillToTextBox.Multiline = true;
            this.BillToTextBox.Name = "BillToTextBox";
            this.BillToTextBox.Size = new System.Drawing.Size(232, 104);
            this.BillToTextBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Repair #";
            // 
            // tbRepairID
            // 
            this.tbRepairID.Enabled = false;
            this.tbRepairID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepairID.Location = new System.Drawing.Point(588, 6);
            this.tbRepairID.Name = "tbRepairID";
            this.tbRepairID.Size = new System.Drawing.Size(104, 21);
            this.tbRepairID.TabIndex = 7;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.AcceptsReturn = true;
            this.AddressTextBox.Enabled = false;
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(103, 0);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(152, 91);
            this.AddressTextBox.TabIndex = 3;
            this.AddressTextBox.Text = "PC Solutions\r\nPembroke Street\r\nTralee\r\nCo Kerry\r\n(066) 711 8242";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CompSys.Properties.Resources.screwdriver26;
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // chooseTab
            // 
            this.chooseTab.Controls.Add(this.btnEstimate);
            this.chooseTab.Controls.Add(this.gbSortBy);
            this.chooseTab.Controls.Add(this.dgvListRepairs);
            this.chooseTab.Location = new System.Drawing.Point(4, 29);
            this.chooseTab.Name = "chooseTab";
            this.chooseTab.Padding = new System.Windows.Forms.Padding(3);
            this.chooseTab.Size = new System.Drawing.Size(698, 440);
            this.chooseTab.TabIndex = 2;
            this.chooseTab.Text = "Choose Repair";
            this.chooseTab.UseVisualStyleBackColor = true;
            // 
            // btnEstimate
            // 
            this.btnEstimate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEstimate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstimate.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimate.ForeColor = System.Drawing.Color.Transparent;
            this.btnEstimate.Image = global::CompSys.Properties.Resources.iconCart2;
            this.btnEstimate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstimate.Location = new System.Drawing.Point(232, 391);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(219, 43);
            this.btnEstimate.TabIndex = 39;
            this.btnEstimate.Text = "Choose Repair";
            this.btnEstimate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstimate.UseCompatibleTextRendering = true;
            this.btnEstimate.UseVisualStyleBackColor = false;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // gbSortBy
            // 
            this.gbSortBy.BackColor = System.Drawing.Color.Transparent;
            this.gbSortBy.Controls.Add(this.rbRepDate);
            this.gbSortBy.Controls.Add(this.rbID);
            this.gbSortBy.Controls.Add(this.label7);
            this.gbSortBy.Controls.Add(this.rbModel);
            this.gbSortBy.Controls.Add(this.rbProb);
            this.gbSortBy.Controls.Add(this.rbCustomer);
            this.gbSortBy.Controls.Add(this.rbDevice);
            this.gbSortBy.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSortBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSortBy.Location = new System.Drawing.Point(9, 6);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Size = new System.Drawing.Size(680, 48);
            this.gbSortBy.TabIndex = 38;
            this.gbSortBy.TabStop = false;
            // 
            // rbRepDate
            // 
            this.rbRepDate.AutoSize = true;
            this.rbRepDate.BackColor = System.Drawing.Color.Transparent;
            this.rbRepDate.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRepDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbRepDate.Location = new System.Drawing.Point(573, 20);
            this.rbRepDate.Name = "rbRepDate";
            this.rbRepDate.Size = new System.Drawing.Size(80, 20);
            this.rbRepDate.TabIndex = 23;
            this.rbRepDate.TabStop = true;
            this.rbRepDate.Text = "RepDate";
            this.rbRepDate.UseVisualStyleBackColor = false;
            this.rbRepDate.CheckedChanged += new System.EventHandler(this.rbRepDate_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.BackColor = System.Drawing.Color.Transparent;
            this.rbID.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbID.Location = new System.Drawing.Point(98, 20);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(90, 20);
            this.rbID.TabIndex = 22;
            this.rbID.TabStop = true;
            this.rbID.Text = "REPAIR ID";
            this.rbID.UseVisualStyleBackColor = false;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "SORT BY:";
            // 
            // rbModel
            // 
            this.rbModel.AutoSize = true;
            this.rbModel.BackColor = System.Drawing.Color.Transparent;
            this.rbModel.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbModel.Location = new System.Drawing.Point(486, 20);
            this.rbModel.Name = "rbModel";
            this.rbModel.Size = new System.Drawing.Size(71, 20);
            this.rbModel.TabIndex = 17;
            this.rbModel.TabStop = true;
            this.rbModel.Text = "MODEL";
            this.rbModel.UseVisualStyleBackColor = false;
            this.rbModel.CheckedChanged += new System.EventHandler(this.rbModel_CheckedChanged);
            // 
            // rbProb
            // 
            this.rbProb.AutoSize = true;
            this.rbProb.BackColor = System.Drawing.Color.Transparent;
            this.rbProb.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbProb.Location = new System.Drawing.Point(307, 20);
            this.rbProb.Name = "rbProb";
            this.rbProb.Size = new System.Drawing.Size(86, 20);
            this.rbProb.TabIndex = 14;
            this.rbProb.TabStop = true;
            this.rbProb.Text = "PROBLEM";
            this.rbProb.UseVisualStyleBackColor = false;
            this.rbProb.CheckedChanged += new System.EventHandler(this.rbProb_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.BackColor = System.Drawing.Color.Transparent;
            this.rbCustomer.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbCustomer.Location = new System.Drawing.Point(194, 20);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(97, 20);
            this.rbCustomer.TabIndex = 15;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "CUSTOMER";
            this.rbCustomer.UseVisualStyleBackColor = false;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // rbDevice
            // 
            this.rbDevice.AutoSize = true;
            this.rbDevice.BackColor = System.Drawing.Color.Transparent;
            this.rbDevice.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDevice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbDevice.Location = new System.Drawing.Point(399, 20);
            this.rbDevice.Name = "rbDevice";
            this.rbDevice.Size = new System.Drawing.Size(72, 20);
            this.rbDevice.TabIndex = 16;
            this.rbDevice.TabStop = true;
            this.rbDevice.Text = "DEVICE";
            this.rbDevice.UseVisualStyleBackColor = false;
            this.rbDevice.CheckedChanged += new System.EventHandler(this.rbDevice_CheckedChanged);
            // 
            // dgvListRepairs
            // 
            this.dgvListRepairs.AllowUserToAddRows = false;
            this.dgvListRepairs.AllowUserToDeleteRows = false;
            this.dgvListRepairs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListRepairs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListRepairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListRepairs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListRepairs.BackgroundColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListRepairs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRepairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.dgvListRepairs.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListRepairs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListRepairs.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListRepairs.Location = new System.Drawing.Point(9, 56);
            this.dgvListRepairs.Name = "dgvListRepairs";
            this.dgvListRepairs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListRepairs.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvListRepairs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListRepairs.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListRepairs.RowTemplate.DividerHeight = 3;
            this.dgvListRepairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListRepairs.Size = new System.Drawing.Size(680, 329);
            this.dgvListRepairs.TabIndex = 31;
            // 
            // Check
            // 
            this.Check.FillWeight = 30F;
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check.HeaderText = "*";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabCollectRepair
            // 
            this.tabCollectRepair.Controls.Add(this.chooseTab);
            this.tabCollectRepair.Controls.Add(this.payTab);
            this.tabCollectRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCollectRepair.Location = new System.Drawing.Point(0, 69);
            this.tabCollectRepair.Name = "tabCollectRepair";
            this.tabCollectRepair.SelectedIndex = 0;
            this.tabCollectRepair.Size = new System.Drawing.Size(706, 473);
            this.tabCollectRepair.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Image = global::CompSys.Properties.Resources.btnBack1;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(591, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 42);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // prnDialog
            // 
            this.prnDialog.UseEXDialog = true;
            // 
            // prnDocument
            // 
            this.prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prnDocument_PrintPage);
            // 
            // frmCollectRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 542);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabCollectRepair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmCollectRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - Collect Repair";
            this.Load += new System.EventHandler(this.frmCollectRepair_Load);
            this.payTab.ResumeLayout(false);
            this.payTab.PerformLayout();
            this.tableTotal.ResumeLayout(false);
            this.tableTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.chooseTab.ResumeLayout(false);
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRepairs)).EndInit();
            this.tabCollectRepair.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.TabPage payTab;
        private System.Windows.Forms.TabPage chooseTab;
        private System.Windows.Forms.TabControl tabCollectRepair;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvListRepairs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.RadioButton rbRepDate;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbModel;
        private System.Windows.Forms.RadioButton rbProb;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbDevice;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox tbRepairID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BillToTextBox;
        private System.Windows.Forms.ListView listViewBox;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader PartName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.TableLayoutPanel tableTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbVat;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.DateTimePicker CollectedDate;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.PrintDialog prnDialog;
        private System.Drawing.Printing.PrintDocument prnDocument;
    }
}
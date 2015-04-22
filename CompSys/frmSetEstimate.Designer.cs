namespace CompSys
{
    partial class frmSetEstimate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetEstimate));
            this.tabSetEstimate = new System.Windows.Forms.TabControl();
            this.tabRepairs = new System.Windows.Forms.TabPage();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.rbRepDate = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbModel = new System.Windows.Forms.RadioButton();
            this.rbProb = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbDevice = new System.Windows.Forms.RadioButton();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvListRepairs = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSet = new System.Windows.Forms.TabPage();
            this.btnSetEstimate = new System.Windows.Forms.Button();
            this.gbFoundInventory = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbQtyAvailable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPartID = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPartName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbSearchInventory = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescSearch = new System.Windows.Forms.TextBox();
            this.tbPartSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listViewBox = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableTotal = new System.Windows.Forms.TableLayoutPanel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbVat = new System.Windows.Forms.TextBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.printRepairJobs = new System.Drawing.Printing.PrintDocument();
            this.tabSetEstimate.SuspendLayout();
            this.tabRepairs.SuspendLayout();
            this.gbSortBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRepairs)).BeginInit();
            this.tabSet.SuspendLayout();
            this.gbFoundInventory.SuspendLayout();
            this.gbSearchInventory.SuspendLayout();
            this.gbItems.SuspendLayout();
            this.tableTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSetEstimate
            // 
            this.tabSetEstimate.Controls.Add(this.tabRepairs);
            this.tabSetEstimate.Controls.Add(this.tabSet);
            this.tabSetEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSetEstimate.Location = new System.Drawing.Point(-4, 70);
            this.tabSetEstimate.Name = "tabSetEstimate";
            this.tabSetEstimate.SelectedIndex = 0;
            this.tabSetEstimate.Size = new System.Drawing.Size(709, 471);
            this.tabSetEstimate.TabIndex = 1;
            // 
            // tabRepairs
            // 
            this.tabRepairs.Controls.Add(this.gbSortBy);
            this.tabRepairs.Controls.Add(this.btnEstimate);
            this.tabRepairs.Controls.Add(this.btnPrint);
            this.tabRepairs.Controls.Add(this.dgvListRepairs);
            this.tabRepairs.Location = new System.Drawing.Point(4, 29);
            this.tabRepairs.Name = "tabRepairs";
            this.tabRepairs.Padding = new System.Windows.Forms.Padding(3);
            this.tabRepairs.Size = new System.Drawing.Size(701, 438);
            this.tabRepairs.TabIndex = 0;
            this.tabRepairs.Text = "Repairs";
            this.tabRepairs.UseVisualStyleBackColor = true;
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
            this.gbSortBy.Location = new System.Drawing.Point(8, 7);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Size = new System.Drawing.Size(680, 48);
            this.gbSortBy.TabIndex = 36;
            this.gbSortBy.TabStop = false;
            // 
            // rbRepDate
            // 
            this.rbRepDate.AutoSize = true;
            this.rbRepDate.BackColor = System.Drawing.Color.Transparent;
            this.rbRepDate.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRepDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbRepDate.Location = new System.Drawing.Point(596, 20);
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
            this.rbID.Size = new System.Drawing.Size(86, 20);
            this.rbID.TabIndex = 22;
            this.rbID.TabStop = true;
            this.rbID.Text = "Repair ID";
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
            this.rbModel.Location = new System.Drawing.Point(516, 20);
            this.rbModel.Name = "rbModel";
            this.rbModel.Size = new System.Drawing.Size(65, 20);
            this.rbModel.TabIndex = 17;
            this.rbModel.TabStop = true;
            this.rbModel.Text = "Model";
            this.rbModel.UseVisualStyleBackColor = false;
            this.rbModel.CheckedChanged += new System.EventHandler(this.rbModel_CheckedChanged);
            // 
            // rbProb
            // 
            this.rbProb.AutoSize = true;
            this.rbProb.BackColor = System.Drawing.Color.Transparent;
            this.rbProb.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbProb.Location = new System.Drawing.Point(311, 20);
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
            this.rbCustomer.Location = new System.Drawing.Point(190, 20);
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
            this.rbDevice.Location = new System.Drawing.Point(421, 20);
            this.rbDevice.Name = "rbDevice";
            this.rbDevice.Size = new System.Drawing.Size(72, 20);
            this.rbDevice.TabIndex = 16;
            this.rbDevice.TabStop = true;
            this.rbDevice.Text = "DEVICE";
            this.rbDevice.UseVisualStyleBackColor = false;
            this.rbDevice.CheckedChanged += new System.EventHandler(this.rbDevice_CheckedChanged);
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
            this.btnEstimate.Location = new System.Drawing.Point(228, 396);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(219, 39);
            this.btnEstimate.TabIndex = 32;
            this.btnEstimate.Text = "Choose Repair";
            this.btnEstimate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstimate.UseCompatibleTextRendering = true;
            this.btnEstimate.UseVisualStyleBackColor = false;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPrint.Image = global::CompSys.Properties.Resources.iconPrint;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(564, 396);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(124, 39);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.dgvListRepairs.Location = new System.Drawing.Point(8, 61);
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
            this.dgvListRepairs.TabIndex = 29;
            // 
            // Check
            // 
            this.Check.FillWeight = 30F;
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check.HeaderText = "*";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabSet
            // 
            this.tabSet.Controls.Add(this.btnSetEstimate);
            this.tabSet.Controls.Add(this.gbFoundInventory);
            this.tabSet.Controls.Add(this.gbSearchInventory);
            this.tabSet.Controls.Add(this.gbItems);
            this.tabSet.Location = new System.Drawing.Point(4, 29);
            this.tabSet.Name = "tabSet";
            this.tabSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabSet.Size = new System.Drawing.Size(701, 438);
            this.tabSet.TabIndex = 1;
            this.tabSet.Text = "Set Estimate";
            this.tabSet.UseVisualStyleBackColor = true;
            // 
            // btnSetEstimate
            // 
            this.btnSetEstimate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSetEstimate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetEstimate.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetEstimate.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetEstimate.Image = global::CompSys.Properties.Resources.iconCart2;
            this.btnSetEstimate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetEstimate.Location = new System.Drawing.Point(253, 389);
            this.btnSetEstimate.Name = "btnSetEstimate";
            this.btnSetEstimate.Size = new System.Drawing.Size(198, 46);
            this.btnSetEstimate.TabIndex = 33;
            this.btnSetEstimate.Text = "Set Estimate";
            this.btnSetEstimate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetEstimate.UseCompatibleTextRendering = true;
            this.btnSetEstimate.UseVisualStyleBackColor = false;
            this.btnSetEstimate.Click += new System.EventHandler(this.btnSetEstimate_Click);
            // 
            // gbFoundInventory
            // 
            this.gbFoundInventory.BackColor = System.Drawing.Color.SlateGray;
            this.gbFoundInventory.Controls.Add(this.label10);
            this.gbFoundInventory.Controls.Add(this.tbQtyAvailable);
            this.gbFoundInventory.Controls.Add(this.label2);
            this.gbFoundInventory.Controls.Add(this.tbPrice);
            this.gbFoundInventory.Controls.Add(this.label1);
            this.gbFoundInventory.Controls.Add(this.label9);
            this.gbFoundInventory.Controls.Add(this.tbPartID);
            this.gbFoundInventory.Controls.Add(this.tbQuantity);
            this.gbFoundInventory.Controls.Add(this.btnAdd);
            this.gbFoundInventory.Controls.Add(this.tbPartName);
            this.gbFoundInventory.Controls.Add(this.label11);
            this.gbFoundInventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbFoundInventory.Location = new System.Drawing.Point(292, 265);
            this.gbFoundInventory.Name = "gbFoundInventory";
            this.gbFoundInventory.Size = new System.Drawing.Size(409, 121);
            this.gbFoundInventory.TabIndex = 3;
            this.gbFoundInventory.TabStop = false;
            this.gbFoundInventory.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(230, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Qty Available";
            // 
            // tbQtyAvailable
            // 
            this.tbQtyAvailable.Enabled = false;
            this.tbQtyAvailable.Location = new System.Drawing.Point(233, 30);
            this.tbQtyAvailable.Name = "tbQtyAvailable";
            this.tbQtyAvailable.Size = new System.Drawing.Size(89, 26);
            this.tbQtyAvailable.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Price / item";
            // 
            // tbPrice
            // 
            this.tbPrice.Enabled = false;
            this.tbPrice.Location = new System.Drawing.Point(106, 82);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(93, 26);
            this.tbPrice.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Part_ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(230, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Qty Needed";
            // 
            // tbPartID
            // 
            this.tbPartID.Enabled = false;
            this.tbPartID.Location = new System.Drawing.Point(9, 82);
            this.tbPartID.Name = "tbPartID";
            this.tbPartID.Size = new System.Drawing.Size(73, 26);
            this.tbPartID.TabIndex = 9;
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.SystemColors.Info;
            this.tbQuantity.Location = new System.Drawing.Point(233, 82);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(89, 26);
            this.tbQuantity.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Image = global::CompSys.Properties.Resources.btnAddCart;
            this.btnAdd.Location = new System.Drawing.Point(341, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 52);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPartName
            // 
            this.tbPartName.Enabled = false;
            this.tbPartName.Location = new System.Drawing.Point(9, 30);
            this.tbPartName.Name = "tbPartName";
            this.tbPartName.Size = new System.Drawing.Size(190, 26);
            this.tbPartName.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(6, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Part Name";
            // 
            // gbSearchInventory
            // 
            this.gbSearchInventory.BackColor = System.Drawing.Color.LightSlateGray;
            this.gbSearchInventory.Controls.Add(this.btnSearch);
            this.gbSearchInventory.Controls.Add(this.label4);
            this.gbSearchInventory.Controls.Add(this.tbDescSearch);
            this.gbSearchInventory.Controls.Add(this.tbPartSearch);
            this.gbSearchInventory.Controls.Add(this.label8);
            this.gbSearchInventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSearchInventory.Location = new System.Drawing.Point(0, 265);
            this.gbSearchInventory.Name = "gbSearchInventory";
            this.gbSearchInventory.Size = new System.Drawing.Size(286, 121);
            this.gbSearchInventory.TabIndex = 2;
            this.gbSearchInventory.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.Image = global::CompSys.Properties.Resources.btnSearch2;
            this.btnSearch.Location = new System.Drawing.Point(221, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 52);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // tbDescSearch
            // 
            this.tbDescSearch.BackColor = System.Drawing.SystemColors.Info;
            this.tbDescSearch.Location = new System.Drawing.Point(9, 82);
            this.tbDescSearch.Name = "tbDescSearch";
            this.tbDescSearch.Size = new System.Drawing.Size(190, 26);
            this.tbDescSearch.TabIndex = 5;
            // 
            // tbPartSearch
            // 
            this.tbPartSearch.BackColor = System.Drawing.SystemColors.Info;
            this.tbPartSearch.Location = new System.Drawing.Point(9, 30);
            this.tbPartSearch.Name = "tbPartSearch";
            this.tbPartSearch.Size = new System.Drawing.Size(190, 26);
            this.tbPartSearch.TabIndex = 4;
            this.tbPartSearch.TextChanged += new System.EventHandler(this.tbPartSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Part Name";
            // 
            // gbItems
            // 
            this.gbItems.BackColor = System.Drawing.Color.LightSlateGray;
            this.gbItems.Controls.Add(this.btnRemove);
            this.gbItems.Controls.Add(this.listViewBox);
            this.gbItems.Controls.Add(this.tableTotal);
            this.gbItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbItems.Location = new System.Drawing.Point(0, 0);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(701, 263);
            this.gbItems.TabIndex = 1;
            this.gbItems.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRemove.Image = global::CompSys.Properties.Resources.cartRemove3;
            this.btnRemove.Location = new System.Drawing.Point(7, 156);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(59, 52);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listViewBox
            // 
            this.listViewBox.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewBox.BackColor = System.Drawing.Color.Maroon;
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
            this.listViewBox.Location = new System.Drawing.Point(7, 13);
            this.listViewBox.Name = "listViewBox";
            this.listViewBox.ShowItemToolTips = true;
            this.listViewBox.Size = new System.Drawing.Size(685, 141);
            this.listViewBox.TabIndex = 2;
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
            this.tableTotal.Location = new System.Drawing.Point(516, 155);
            this.tableTotal.Name = "tableTotal";
            this.tableTotal.RowCount = 4;
            this.tableTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableTotal.Size = new System.Drawing.Size(176, 103);
            this.tableTotal.TabIndex = 1;
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
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
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
            this.tbSubtotal.TextChanged += new System.EventHandler(this.tbSubtotal_TextChanged);
            // 
            // tbVat
            // 
            this.tbVat.BackColor = System.Drawing.SystemColors.Info;
            this.tbVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVat.Location = new System.Drawing.Point(76, 30);
            this.tbVat.Name = "tbVat";
            this.tbVat.Size = new System.Drawing.Size(66, 20);
            this.tbVat.TabIndex = 9;
            this.tbVat.TextChanged += new System.EventHandler(this.tbVat_TextChanged);
            // 
            // tbDiscount
            // 
            this.tbDiscount.BackColor = System.Drawing.SystemColors.Info;
            this.tbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscount.Location = new System.Drawing.Point(76, 54);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(93, 20);
            this.tbDiscount.TabIndex = 10;
            this.tbDiscount.TextChanged += new System.EventHandler(this.tbDiscount_TextChanged);
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
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // printRepairJobs
            // 
            this.printRepairJobs.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printRepairJobs_BeginPrint);
            this.printRepairJobs.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printRepairJobs_PrintPage);
            // 
            // frmSetEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 537);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabSetEstimate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmSetEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - Set Estimate";
            this.Load += new System.EventHandler(this.frmSetEstimate_Load);
            this.tabSetEstimate.ResumeLayout(false);
            this.tabRepairs.ResumeLayout(false);
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRepairs)).EndInit();
            this.tabSet.ResumeLayout(false);
            this.gbFoundInventory.ResumeLayout(false);
            this.gbFoundInventory.PerformLayout();
            this.gbSearchInventory.ResumeLayout(false);
            this.gbSearchInventory.PerformLayout();
            this.gbItems.ResumeLayout(false);
            this.tableTotal.ResumeLayout(false);
            this.tableTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSetEstimate;
        private System.Windows.Forms.TabPage tabRepairs;
        private System.Windows.Forms.TabPage tabSet;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.TableLayoutPanel tableTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvListRepairs;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader PartName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ListView listViewBox;
        private System.Windows.Forms.GroupBox gbSearchInventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPartName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbVat;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescSearch;
        private System.Windows.Forms.TextBox tbPartSearch;
        private System.Windows.Forms.TextBox tbPartID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFoundInventory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbQtyAvailable;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Drawing.Printing.PrintDocument printRepairJobs;
        private System.Windows.Forms.Button btnSetEstimate;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbModel;
        private System.Windows.Forms.RadioButton rbProb;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbDevice;
        private System.Windows.Forms.RadioButton rbRepDate;
    }
}
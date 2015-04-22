namespace CompSys
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.gbSetRate = new System.Windows.Forms.GroupBox();
            this.rbUsed = new System.Windows.Forms.RadioButton();
            this.rbRefurb = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVendor = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lblStockSR = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPriceSR = new System.Windows.Forms.Label();
            this.lblCondSR = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDescSR = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabList = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAmend = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.rbQuantity = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.rbPrice = new System.Windows.Forms.RadioButton();
            this.rbDescription = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbVendor = new System.Windows.Forms.RadioButton();
            this.dgvListInventory = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabAmend = new System.Windows.Forms.TabPage();
            this.btnClearAmend = new System.Windows.Forms.Button();
            this.btnAmendInventory = new System.Windows.Forms.Button();
            this.gbAmend = new System.Windows.Forms.GroupBox();
            this.rbUsedAmend = new System.Windows.Forms.RadioButton();
            this.rbRefurbAmend = new System.Windows.Forms.RadioButton();
            this.rbNewAmend = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVendorAmend = new System.Windows.Forms.TextBox();
            this.tbQuantityAmend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPriceAmend = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDescAmend = new System.Windows.Forms.TextBox();
            this.tbProductAmend = new System.Windows.Forms.TextBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.gbSetRate.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabList.SuspendLayout();
            this.gbSortBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInventory)).BeginInit();
            this.tabAmend.SuspendLayout();
            this.gbAmend.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetRate
            // 
            this.gbSetRate.BackColor = System.Drawing.Color.Maroon;
            this.gbSetRate.Controls.Add(this.rbUsed);
            this.gbSetRate.Controls.Add(this.rbRefurb);
            this.gbSetRate.Controls.Add(this.rbNew);
            this.gbSetRate.Controls.Add(this.label1);
            this.gbSetRate.Controls.Add(this.tbVendor);
            this.gbSetRate.Controls.Add(this.tbQuantity);
            this.gbSetRate.Controls.Add(this.lblStockSR);
            this.gbSetRate.Controls.Add(this.tbPrice);
            this.gbSetRate.Controls.Add(this.lblPriceSR);
            this.gbSetRate.Controls.Add(this.lblCondSR);
            this.gbSetRate.Controls.Add(this.lblDesc);
            this.gbSetRate.Controls.Add(this.lblDescSR);
            this.gbSetRate.Controls.Add(this.tbDescription);
            this.gbSetRate.Controls.Add(this.tbProduct);
            this.gbSetRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSetRate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSetRate.Location = new System.Drawing.Point(8, 11);
            this.gbSetRate.Name = "gbSetRate";
            this.gbSetRate.Size = new System.Drawing.Size(680, 284);
            this.gbSetRate.TabIndex = 3;
            this.gbSetRate.TabStop = false;
            // 
            // rbUsed
            // 
            this.rbUsed.AutoSize = true;
            this.rbUsed.Location = new System.Drawing.Point(382, 103);
            this.rbUsed.Name = "rbUsed";
            this.rbUsed.Size = new System.Drawing.Size(65, 24);
            this.rbUsed.TabIndex = 5;
            this.rbUsed.TabStop = true;
            this.rbUsed.Text = "Used";
            this.rbUsed.UseVisualStyleBackColor = true;
            // 
            // rbRefurb
            // 
            this.rbRefurb.AutoSize = true;
            this.rbRefurb.Location = new System.Drawing.Point(382, 144);
            this.rbRefurb.Name = "rbRefurb";
            this.rbRefurb.Size = new System.Drawing.Size(114, 24);
            this.rbRefurb.TabIndex = 6;
            this.rbRefurb.TabStop = true;
            this.rbRefurb.Text = "Refurbished";
            this.rbRefurb.UseVisualStyleBackColor = true;
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Location = new System.Drawing.Point(382, 61);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(58, 24);
            this.rbNew.TabIndex = 4;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(6, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manufacturer:";
            // 
            // tbVendor
            // 
            this.tbVendor.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVendor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbVendor.Location = new System.Drawing.Point(9, 235);
            this.tbVendor.Name = "tbVendor";
            this.tbVendor.Size = new System.Drawing.Size(252, 32);
            this.tbVendor.TabIndex = 3;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbQuantity.Location = new System.Drawing.Point(382, 235);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(109, 32);
            this.tbQuantity.TabIndex = 7;
            // 
            // lblStockSR
            // 
            this.lblStockSR.AutoSize = true;
            this.lblStockSR.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockSR.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStockSR.Location = new System.Drawing.Point(379, 217);
            this.lblStockSR.Name = "lblStockSR";
            this.lblStockSR.Size = new System.Drawing.Size(73, 15);
            this.lblStockSR.TabIndex = 10;
            this.lblStockSR.Text = "Quantity:";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbPrice.Location = new System.Drawing.Point(554, 235);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(109, 32);
            this.tbPrice.TabIndex = 8;
            // 
            // lblPriceSR
            // 
            this.lblPriceSR.AutoSize = true;
            this.lblPriceSR.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceSR.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPriceSR.Location = new System.Drawing.Point(551, 217);
            this.lblPriceSR.Name = "lblPriceSR";
            this.lblPriceSR.Size = new System.Drawing.Size(58, 15);
            this.lblPriceSR.TabIndex = 8;
            this.lblPriceSR.Text = "Price: €";
            // 
            // lblCondSR
            // 
            this.lblCondSR.AutoSize = true;
            this.lblCondSR.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondSR.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCondSR.Location = new System.Drawing.Point(379, 34);
            this.lblCondSR.Name = "lblCondSR";
            this.lblCondSR.Size = new System.Drawing.Size(81, 15);
            this.lblCondSR.TabIndex = 7;
            this.lblCondSR.Text = "Condition:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDesc.Location = new System.Drawing.Point(6, 109);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(93, 15);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "Description:";
            // 
            // lblDescSR
            // 
            this.lblDescSR.AutoSize = true;
            this.lblDescSR.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSR.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDescSR.Location = new System.Drawing.Point(6, 34);
            this.lblDescSR.Name = "lblDescSR";
            this.lblDescSR.Size = new System.Drawing.Size(108, 15);
            this.lblDescSR.TabIndex = 5;
            this.lblDescSR.Text = "Product Name:";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbDescription.Location = new System.Drawing.Point(9, 127);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(252, 75);
            this.tbDescription.TabIndex = 2;
            // 
            // tbProduct
            // 
            this.tbProduct.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProduct.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbProduct.Location = new System.Drawing.Point(9, 53);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(252, 32);
            this.tbProduct.TabIndex = 1;
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
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Controls.Add(this.tabList);
            this.tabControl.Controls.Add(this.tabAmend);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 76);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(706, 469);
            this.tabControl.TabIndex = 14;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.btnClear);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Controls.Add(this.gbSetRate);
            this.tabAdd.Location = new System.Drawing.Point(4, 29);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(698, 436);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add Inventory";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.Image = global::CompSys.Properties.Resources.btnClear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(8, 318);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 61);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Image = global::CompSys.Properties.Resources.btnAdd;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(210, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(330, 78);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add New Inventory";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseCompatibleTextRendering = true;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabList
            // 
            this.tabList.BackColor = System.Drawing.Color.Snow;
            this.tabList.Controls.Add(this.btnPrint);
            this.tabList.Controls.Add(this.btnAmend);
            this.tabList.Controls.Add(this.btnDelete);
            this.tabList.Controls.Add(this.gbSortBy);
            this.tabList.Controls.Add(this.dgvListInventory);
            this.tabList.Location = new System.Drawing.Point(4, 29);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(698, 436);
            this.tabList.TabIndex = 1;
            this.tabList.Text = "List Inventory";
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
            this.btnPrint.Location = new System.Drawing.Point(288, 394);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(124, 39);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAmend
            // 
            this.btnAmend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAmend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAmend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAmend.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmend.ForeColor = System.Drawing.Color.Olive;
            this.btnAmend.Image = global::CompSys.Properties.Resources.iconAmend;
            this.btnAmend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmend.Location = new System.Drawing.Point(6, 394);
            this.btnAmend.Name = "btnAmend";
            this.btnAmend.Size = new System.Drawing.Size(124, 39);
            this.btnAmend.TabIndex = 30;
            this.btnAmend.Text = "Edit";
            this.btnAmend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAmend.UseCompatibleTextRendering = true;
            this.btnAmend.UseVisualStyleBackColor = false;
            this.btnAmend.Click += new System.EventHandler(this.btnAmend_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::CompSys.Properties.Resources.btnDel;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(564, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 39);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseCompatibleTextRendering = true;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbSortBy
            // 
            this.gbSortBy.BackColor = System.Drawing.Color.Transparent;
            this.gbSortBy.Controls.Add(this.rbQuantity);
            this.gbSortBy.Controls.Add(this.label2);
            this.gbSortBy.Controls.Add(this.cbStatus);
            this.gbSortBy.Controls.Add(this.rbPrice);
            this.gbSortBy.Controls.Add(this.rbDescription);
            this.gbSortBy.Controls.Add(this.rbName);
            this.gbSortBy.Controls.Add(this.rbVendor);
            this.gbSortBy.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSortBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSortBy.Location = new System.Drawing.Point(8, 3);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Size = new System.Drawing.Size(680, 48);
            this.gbSortBy.TabIndex = 28;
            this.gbSortBy.TabStop = false;
            // 
            // rbQuantity
            // 
            this.rbQuantity.AutoSize = true;
            this.rbQuantity.BackColor = System.Drawing.Color.Transparent;
            this.rbQuantity.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbQuantity.Location = new System.Drawing.Point(386, 20);
            this.rbQuantity.Name = "rbQuantity";
            this.rbQuantity.Size = new System.Drawing.Size(95, 20);
            this.rbQuantity.TabIndex = 22;
            this.rbQuantity.TabStop = true;
            this.rbQuantity.Text = "QUANTITY";
            this.rbQuantity.UseVisualStyleBackColor = false;
            this.rbQuantity.CheckedChanged += new System.EventHandler(this.rbQuantity_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "SORT BY:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStatus.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "New",
            "Refurbished",
            "Used"});
            this.cbStatus.Location = new System.Drawing.Point(556, 17);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(108, 24);
            this.cbStatus.Sorted = true;
            this.cbStatus.TabIndex = 18;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
            // 
            // rbPrice
            // 
            this.rbPrice.AutoSize = true;
            this.rbPrice.BackColor = System.Drawing.Color.Transparent;
            this.rbPrice.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbPrice.Location = new System.Drawing.Point(487, 20);
            this.rbPrice.Name = "rbPrice";
            this.rbPrice.Size = new System.Drawing.Size(63, 20);
            this.rbPrice.TabIndex = 17;
            this.rbPrice.TabStop = true;
            this.rbPrice.Text = "PRICE";
            this.rbPrice.UseVisualStyleBackColor = false;
            this.rbPrice.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
            // 
            // rbDescription
            // 
            this.rbDescription.AutoSize = true;
            this.rbDescription.BackColor = System.Drawing.Color.Transparent;
            this.rbDescription.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbDescription.Location = new System.Drawing.Point(180, 20);
            this.rbDescription.Name = "rbDescription";
            this.rbDescription.Size = new System.Drawing.Size(113, 20);
            this.rbDescription.TabIndex = 14;
            this.rbDescription.TabStop = true;
            this.rbDescription.Text = "DESCRIPTION";
            this.rbDescription.UseVisualStyleBackColor = false;
            this.rbDescription.CheckedChanged += new System.EventHandler(this.rbDescription_CheckedChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.BackColor = System.Drawing.Color.Transparent;
            this.rbName.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbName.Location = new System.Drawing.Point(111, 20);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(63, 20);
            this.rbName.TabIndex = 15;
            this.rbName.TabStop = true;
            this.rbName.Text = "NAME";
            this.rbName.UseVisualStyleBackColor = false;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbVendor
            // 
            this.rbVendor.AutoSize = true;
            this.rbVendor.BackColor = System.Drawing.Color.Transparent;
            this.rbVendor.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVendor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbVendor.Location = new System.Drawing.Point(299, 20);
            this.rbVendor.Name = "rbVendor";
            this.rbVendor.Size = new System.Drawing.Size(81, 20);
            this.rbVendor.TabIndex = 16;
            this.rbVendor.TabStop = true;
            this.rbVendor.Text = "VENDOR";
            this.rbVendor.UseVisualStyleBackColor = false;
            this.rbVendor.CheckedChanged += new System.EventHandler(this.rbVendor_CheckedChanged);
            // 
            // dgvListInventory
            // 
            this.dgvListInventory.AllowUserToAddRows = false;
            this.dgvListInventory.AllowUserToDeleteRows = false;
            this.dgvListInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListInventory.BackgroundColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.dgvListInventory.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListInventory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListInventory.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListInventory.Location = new System.Drawing.Point(7, 56);
            this.dgvListInventory.Name = "dgvListInventory";
            this.dgvListInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListInventory.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvListInventory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListInventory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListInventory.RowTemplate.DividerHeight = 3;
            this.dgvListInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListInventory.Size = new System.Drawing.Size(681, 333);
            this.dgvListInventory.TabIndex = 27;
            // 
            // Check
            // 
            this.Check.FillWeight = 30F;
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check.HeaderText = "*";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabAmend
            // 
            this.tabAmend.Controls.Add(this.btnClearAmend);
            this.tabAmend.Controls.Add(this.btnAmendInventory);
            this.tabAmend.Controls.Add(this.gbAmend);
            this.tabAmend.Location = new System.Drawing.Point(4, 29);
            this.tabAmend.Name = "tabAmend";
            this.tabAmend.Padding = new System.Windows.Forms.Padding(3);
            this.tabAmend.Size = new System.Drawing.Size(698, 436);
            this.tabAmend.TabIndex = 2;
            this.tabAmend.Text = "Amend Inventory";
            this.tabAmend.UseVisualStyleBackColor = true;
            // 
            // btnClearAmend
            // 
            this.btnClearAmend.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAmend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearAmend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClearAmend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAmend.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAmend.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClearAmend.Image = global::CompSys.Properties.Resources.btnClear;
            this.btnClearAmend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAmend.Location = new System.Drawing.Point(8, 318);
            this.btnClearAmend.Name = "btnClearAmend";
            this.btnClearAmend.Size = new System.Drawing.Size(127, 61);
            this.btnClearAmend.TabIndex = 11;
            this.btnClearAmend.Text = "Clear";
            this.btnClearAmend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearAmend.UseVisualStyleBackColor = false;
            this.btnClearAmend.Click += new System.EventHandler(this.btnClearAmend_Click);
            // 
            // btnAmendInventory
            // 
            this.btnAmendInventory.BackColor = System.Drawing.Color.White;
            this.btnAmendInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAmendInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmendInventory.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmendInventory.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAmendInventory.Image = global::CompSys.Properties.Resources.btnAdd;
            this.btnAmendInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmendInventory.Location = new System.Drawing.Point(210, 301);
            this.btnAmendInventory.Name = "btnAmendInventory";
            this.btnAmendInventory.Size = new System.Drawing.Size(330, 78);
            this.btnAmendInventory.TabIndex = 10;
            this.btnAmendInventory.Text = "Amend Inventory";
            this.btnAmendInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAmendInventory.UseCompatibleTextRendering = true;
            this.btnAmendInventory.UseVisualStyleBackColor = false;
            this.btnAmendInventory.Click += new System.EventHandler(this.btnAmendInventory_Click);
            // 
            // gbAmend
            // 
            this.gbAmend.BackColor = System.Drawing.Color.Maroon;
            this.gbAmend.Controls.Add(this.rbUsedAmend);
            this.gbAmend.Controls.Add(this.rbRefurbAmend);
            this.gbAmend.Controls.Add(this.rbNewAmend);
            this.gbAmend.Controls.Add(this.label3);
            this.gbAmend.Controls.Add(this.tbVendorAmend);
            this.gbAmend.Controls.Add(this.tbQuantityAmend);
            this.gbAmend.Controls.Add(this.label4);
            this.gbAmend.Controls.Add(this.tbPriceAmend);
            this.gbAmend.Controls.Add(this.label5);
            this.gbAmend.Controls.Add(this.label6);
            this.gbAmend.Controls.Add(this.label7);
            this.gbAmend.Controls.Add(this.label8);
            this.gbAmend.Controls.Add(this.tbDescAmend);
            this.gbAmend.Controls.Add(this.tbProductAmend);
            this.gbAmend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAmend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbAmend.Location = new System.Drawing.Point(8, 11);
            this.gbAmend.Name = "gbAmend";
            this.gbAmend.Size = new System.Drawing.Size(680, 284);
            this.gbAmend.TabIndex = 4;
            this.gbAmend.TabStop = false;
            // 
            // rbUsedAmend
            // 
            this.rbUsedAmend.AutoSize = true;
            this.rbUsedAmend.Location = new System.Drawing.Point(382, 103);
            this.rbUsedAmend.Name = "rbUsedAmend";
            this.rbUsedAmend.Size = new System.Drawing.Size(65, 24);
            this.rbUsedAmend.TabIndex = 5;
            this.rbUsedAmend.TabStop = true;
            this.rbUsedAmend.Text = "Used";
            this.rbUsedAmend.UseVisualStyleBackColor = true;
            // 
            // rbRefurbAmend
            // 
            this.rbRefurbAmend.AutoSize = true;
            this.rbRefurbAmend.Location = new System.Drawing.Point(382, 144);
            this.rbRefurbAmend.Name = "rbRefurbAmend";
            this.rbRefurbAmend.Size = new System.Drawing.Size(114, 24);
            this.rbRefurbAmend.TabIndex = 6;
            this.rbRefurbAmend.TabStop = true;
            this.rbRefurbAmend.Text = "Refurbished";
            this.rbRefurbAmend.UseVisualStyleBackColor = true;
            // 
            // rbNewAmend
            // 
            this.rbNewAmend.AutoSize = true;
            this.rbNewAmend.Location = new System.Drawing.Point(382, 61);
            this.rbNewAmend.Name = "rbNewAmend";
            this.rbNewAmend.Size = new System.Drawing.Size(58, 24);
            this.rbNewAmend.TabIndex = 4;
            this.rbNewAmend.TabStop = true;
            this.rbNewAmend.Text = "New";
            this.rbNewAmend.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(6, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Manufacturer:";
            // 
            // tbVendorAmend
            // 
            this.tbVendorAmend.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVendorAmend.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbVendorAmend.Location = new System.Drawing.Point(9, 235);
            this.tbVendorAmend.Name = "tbVendorAmend";
            this.tbVendorAmend.Size = new System.Drawing.Size(252, 32);
            this.tbVendorAmend.TabIndex = 3;
            // 
            // tbQuantityAmend
            // 
            this.tbQuantityAmend.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantityAmend.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbQuantityAmend.Location = new System.Drawing.Point(382, 235);
            this.tbQuantityAmend.Name = "tbQuantityAmend";
            this.tbQuantityAmend.Size = new System.Drawing.Size(109, 32);
            this.tbQuantityAmend.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(379, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity:";
            // 
            // tbPriceAmend
            // 
            this.tbPriceAmend.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceAmend.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbPriceAmend.Location = new System.Drawing.Point(554, 235);
            this.tbPriceAmend.Name = "tbPriceAmend";
            this.tbPriceAmend.Size = new System.Drawing.Size(109, 32);
            this.tbPriceAmend.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(551, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price: €";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(379, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Condition:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Product Name:";
            // 
            // tbDescAmend
            // 
            this.tbDescAmend.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescAmend.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbDescAmend.Location = new System.Drawing.Point(9, 127);
            this.tbDescAmend.Multiline = true;
            this.tbDescAmend.Name = "tbDescAmend";
            this.tbDescAmend.Size = new System.Drawing.Size(252, 75);
            this.tbDescAmend.TabIndex = 2;
            // 
            // tbProductAmend
            // 
            this.tbProductAmend.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductAmend.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbProductAmend.Location = new System.Drawing.Point(9, 53);
            this.tbProductAmend.Name = "tbProductAmend";
            this.tbProductAmend.Size = new System.Drawing.Size(252, 32);
            this.tbProductAmend.TabIndex = 1;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.gbSetRate.ResumeLayout(false);
            this.gbSetRate.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInventory)).EndInit();
            this.tabAmend.ResumeLayout(false);
            this.gbAmend.ResumeLayout(false);
            this.gbAmend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetRate;
        private System.Windows.Forms.Label lblCondSR;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblDescSR;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblStockSR;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPriceSR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVendor;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbUsed;
        private System.Windows.Forms.RadioButton rbRefurb;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.RadioButton rbPrice;
        private System.Windows.Forms.RadioButton rbDescription;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbVendor;
        private System.Windows.Forms.RadioButton rbQuantity;
        private System.Windows.Forms.Button btnAmend;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvListInventory;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.TabPage tabAmend;
        private System.Windows.Forms.Button btnAmendInventory;
        private System.Windows.Forms.GroupBox gbAmend;
        private System.Windows.Forms.RadioButton rbUsedAmend;
        private System.Windows.Forms.RadioButton rbRefurbAmend;
        private System.Windows.Forms.RadioButton rbNewAmend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVendorAmend;
        private System.Windows.Forms.TextBox tbQuantityAmend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPriceAmend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDescAmend;
        private System.Windows.Forms.TextBox tbProductAmend;
        private System.Windows.Forms.Button btnClearAmend;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;

    }
}
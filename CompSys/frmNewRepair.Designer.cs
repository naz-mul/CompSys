namespace CompSys
{
    partial class frmNewRepair
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewRepair));
            this.problemTab = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.gbProblem = new System.Windows.Forms.GroupBox();
            this.clbProblem = new System.Windows.Forms.CheckedListBox();
            this.gbDevice = new System.Windows.Forms.GroupBox();
            this.cbOS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDeviceType = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.custTab = new System.Windows.Forms.TabPage();
            this.grdListCust = new System.Windows.Forms.DataGridView();
            this.AmendCell = new System.Windows.Forms.DataGridViewButtonColumn();
            this.startTab = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearchAmendStaff = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQueryTown = new System.Windows.Forms.TextBox();
            this.lblTownAmendStaff = new System.Windows.Forms.Label();
            this.tbQuerySurname = new System.Windows.Forms.TextBox();
            this.lblLastnameAmendStaff = new System.Windows.Forms.Label();
            this.tbQueryFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstnameAmendStaff = new System.Windows.Forms.Label();
            this.tabNewRepair = new System.Windows.Forms.TabControl();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.problemTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbProblem.SuspendLayout();
            this.gbDevice.SuspendLayout();
            this.custTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListCust)).BeginInit();
            this.startTab.SuspendLayout();
            this.gbSearchAmendStaff.SuspendLayout();
            this.tabNewRepair.SuspendLayout();
            this.SuspendLayout();
            // 
            // problemTab
            // 
            this.problemTab.Controls.Add(this.btnClear);
            this.problemTab.Controls.Add(this.btnAdd);
            this.problemTab.Controls.Add(this.groupBox1);
            this.problemTab.Controls.Add(this.gbProblem);
            this.problemTab.Controls.Add(this.gbDevice);
            this.problemTab.Location = new System.Drawing.Point(4, 29);
            this.problemTab.Name = "problemTab";
            this.problemTab.Size = new System.Drawing.Size(698, 428);
            this.problemTab.TabIndex = 3;
            this.problemTab.Text = "Problem";
            this.problemTab.UseVisualStyleBackColor = true;
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
            this.btnClear.Location = new System.Drawing.Point(8, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 52);
            this.btnClear.TabIndex = 11;
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
            this.btnAdd.Location = new System.Drawing.Point(206, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(330, 76);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Save Repair Details";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseCompatibleTextRendering = true;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(350, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 186);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(19, 21);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(304, 155);
            this.tbDescription.TabIndex = 0;
            // 
            // gbProblem
            // 
            this.gbProblem.BackColor = System.Drawing.Color.Maroon;
            this.gbProblem.Controls.Add(this.clbProblem);
            this.gbProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProblem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbProblem.Location = new System.Drawing.Point(8, 153);
            this.gbProblem.Name = "gbProblem";
            this.gbProblem.Size = new System.Drawing.Size(333, 186);
            this.gbProblem.TabIndex = 3;
            this.gbProblem.TabStop = false;
            this.gbProblem.Text = "Problem Type";
            // 
            // clbProblem
            // 
            this.clbProblem.BackColor = System.Drawing.SystemColors.Info;
            this.clbProblem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbProblem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clbProblem.FormattingEnabled = true;
            this.clbProblem.Items.AddRange(new object[] {
            "Virus & Spyware Removal",
            "BSOD",
            "OS Reinstall",
            "Full Service",
            "Anti-Virus Installation",
            "Misc. Program Installation",
            "Backup & Restore",
            "Networking Setup",
            "HDD Problem",
            "Driver Problem",
            "Hardware Upgrade",
            "Software Upgrade",
            "Miscellaneous"});
            this.clbProblem.Location = new System.Drawing.Point(11, 21);
            this.clbProblem.Name = "clbProblem";
            this.clbProblem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clbProblem.Size = new System.Drawing.Size(303, 155);
            this.clbProblem.TabIndex = 0;
            this.clbProblem.ThreeDCheckBoxes = true;
            // 
            // gbDevice
            // 
            this.gbDevice.BackColor = System.Drawing.Color.Maroon;
            this.gbDevice.Controls.Add(this.cbOS);
            this.gbDevice.Controls.Add(this.label3);
            this.gbDevice.Controls.Add(this.tbModel);
            this.gbDevice.Controls.Add(this.label2);
            this.gbDevice.Controls.Add(this.tbBrand);
            this.gbDevice.Controls.Add(this.label1);
            this.gbDevice.Controls.Add(this.cbDeviceType);
            this.gbDevice.Controls.Add(this.lbl1);
            this.gbDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDevice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDevice.Location = new System.Drawing.Point(8, 3);
            this.gbDevice.Name = "gbDevice";
            this.gbDevice.Size = new System.Drawing.Size(680, 145);
            this.gbDevice.TabIndex = 2;
            this.gbDevice.TabStop = false;
            this.gbDevice.Text = "Device Details";
            // 
            // cbOS
            // 
            this.cbOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOS.FormattingEnabled = true;
            this.cbOS.Items.AddRange(new object[] {
            "Windows 7",
            "Windows 8",
            "Windows Vista",
            "Windows Older",
            "MacOS X",
            "Linux",
            "Other"});
            this.cbOS.Location = new System.Drawing.Point(361, 46);
            this.cbOS.Name = "cbOS";
            this.cbOS.Size = new System.Drawing.Size(304, 28);
            this.cbOS.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Operating System";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(361, 109);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(304, 26);
            this.tbModel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model";
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(11, 109);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(303, 26);
            this.tbBrand.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Brand";
            // 
            // cbDeviceType
            // 
            this.cbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeviceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDeviceType.FormattingEnabled = true;
            this.cbDeviceType.Items.AddRange(new object[] {
            "Laptop",
            "Desktop",
            "Printer",
            "Other"});
            this.cbDeviceType.Location = new System.Drawing.Point(11, 46);
            this.cbDeviceType.Name = "cbDeviceType";
            this.cbDeviceType.Size = new System.Drawing.Size(303, 28);
            this.cbDeviceType.TabIndex = 6;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(8, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(93, 15);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Device Type";
            // 
            // custTab
            // 
            this.custTab.Controls.Add(this.grdListCust);
            this.custTab.Location = new System.Drawing.Point(4, 29);
            this.custTab.Name = "custTab";
            this.custTab.Padding = new System.Windows.Forms.Padding(3);
            this.custTab.Size = new System.Drawing.Size(698, 428);
            this.custTab.TabIndex = 1;
            this.custTab.Text = "Choose Customer";
            this.custTab.UseVisualStyleBackColor = true;
            // 
            // grdListCust
            // 
            this.grdListCust.AllowUserToAddRows = false;
            this.grdListCust.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.grdListCust.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdListCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdListCust.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdListCust.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.grdListCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdListCust.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grdListCust.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdListCust.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdListCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AmendCell});
            this.grdListCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdListCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListCust.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdListCust.Location = new System.Drawing.Point(3, 3);
            this.grdListCust.Name = "grdListCust";
            this.grdListCust.ReadOnly = true;
            this.grdListCust.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdListCust.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdListCust.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.grdListCust.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdListCust.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.grdListCust.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SlateBlue;
            this.grdListCust.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdListCust.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grdListCust.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.grdListCust.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grdListCust.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdListCust.RowTemplate.DividerHeight = 5;
            this.grdListCust.Size = new System.Drawing.Size(692, 422);
            this.grdListCust.StandardTab = true;
            this.grdListCust.TabIndex = 1;
            this.grdListCust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListCust_CellContentClick);
            // 
            // AmendCell
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.AmendCell.DefaultCellStyle = dataGridViewCellStyle3;
            this.AmendCell.HeaderText = "*";
            this.AmendCell.Name = "AmendCell";
            this.AmendCell.ReadOnly = true;
            this.AmendCell.Text = "Choose";
            this.AmendCell.UseColumnTextForButtonValue = true;
            // 
            // startTab
            // 
            this.startTab.Controls.Add(this.btnSearch);
            this.startTab.Controls.Add(this.gbSearchAmendStaff);
            this.startTab.Location = new System.Drawing.Point(4, 29);
            this.startTab.Name = "startTab";
            this.startTab.Padding = new System.Windows.Forms.Padding(3);
            this.startTab.Size = new System.Drawing.Size(698, 428);
            this.startTab.TabIndex = 0;
            this.startTab.Text = "Start";
            this.startTab.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.Image = global::CompSys.Properties.Resources.btnSearch;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(195, 296);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(312, 76);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search Customer";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseCompatibleTextRendering = true;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbSearchAmendStaff
            // 
            this.gbSearchAmendStaff.BackColor = System.Drawing.Color.Maroon;
            this.gbSearchAmendStaff.Controls.Add(this.label4);
            this.gbSearchAmendStaff.Controls.Add(this.tbQueryTown);
            this.gbSearchAmendStaff.Controls.Add(this.lblTownAmendStaff);
            this.gbSearchAmendStaff.Controls.Add(this.tbQuerySurname);
            this.gbSearchAmendStaff.Controls.Add(this.lblLastnameAmendStaff);
            this.gbSearchAmendStaff.Controls.Add(this.tbQueryFirstname);
            this.gbSearchAmendStaff.Controls.Add(this.lblFirstnameAmendStaff);
            this.gbSearchAmendStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchAmendStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSearchAmendStaff.Location = new System.Drawing.Point(50, 45);
            this.gbSearchAmendStaff.Name = "gbSearchAmendStaff";
            this.gbSearchAmendStaff.Size = new System.Drawing.Size(602, 245);
            this.gbSearchAmendStaff.TabIndex = 2;
            this.gbSearchAmendStaff.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(555, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Please enter customer details to continue ...";
            // 
            // tbQueryTown
            // 
            this.tbQueryTown.AutoCompleteCustomSource.AddRange(new string[] {
            "ab"});
            this.tbQueryTown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbQueryTown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbQueryTown.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQueryTown.Location = new System.Drawing.Point(201, 187);
            this.tbQueryTown.Name = "tbQueryTown";
            this.tbQueryTown.Size = new System.Drawing.Size(274, 36);
            this.tbQueryTown.TabIndex = 5;
            this.tbQueryTown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTown_KeyDown);
            // 
            // lblTownAmendStaff
            // 
            this.lblTownAmendStaff.AutoSize = true;
            this.lblTownAmendStaff.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownAmendStaff.Location = new System.Drawing.Point(114, 187);
            this.lblTownAmendStaff.Name = "lblTownAmendStaff";
            this.lblTownAmendStaff.Size = new System.Drawing.Size(71, 22);
            this.lblTownAmendStaff.TabIndex = 4;
            this.lblTownAmendStaff.Text = "Town:";
            // 
            // tbQuerySurname
            // 
            this.tbQuerySurname.AutoCompleteCustomSource.AddRange(new string[] {
            "ab"});
            this.tbQuerySurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbQuerySurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbQuerySurname.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuerySurname.Location = new System.Drawing.Point(201, 138);
            this.tbQuerySurname.Name = "tbQuerySurname";
            this.tbQuerySurname.Size = new System.Drawing.Size(274, 36);
            this.tbQuerySurname.TabIndex = 3;
            // 
            // lblLastnameAmendStaff
            // 
            this.lblLastnameAmendStaff.AutoSize = true;
            this.lblLastnameAmendStaff.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastnameAmendStaff.Location = new System.Drawing.Point(73, 138);
            this.lblLastnameAmendStaff.Name = "lblLastnameAmendStaff";
            this.lblLastnameAmendStaff.Size = new System.Drawing.Size(112, 22);
            this.lblLastnameAmendStaff.TabIndex = 2;
            this.lblLastnameAmendStaff.Text = "Lastname:";
            // 
            // tbQueryFirstname
            // 
            this.tbQueryFirstname.AutoCompleteCustomSource.AddRange(new string[] {
            "ab"});
            this.tbQueryFirstname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbQueryFirstname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbQueryFirstname.BackColor = System.Drawing.SystemColors.Window;
            this.tbQueryFirstname.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQueryFirstname.ForeColor = System.Drawing.Color.Black;
            this.tbQueryFirstname.Location = new System.Drawing.Point(201, 91);
            this.tbQueryFirstname.Name = "tbQueryFirstname";
            this.tbQueryFirstname.Size = new System.Drawing.Size(274, 33);
            this.tbQueryFirstname.TabIndex = 1;
            // 
            // lblFirstnameAmendStaff
            // 
            this.lblFirstnameAmendStaff.AutoSize = true;
            this.lblFirstnameAmendStaff.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstnameAmendStaff.Location = new System.Drawing.Point(69, 91);
            this.lblFirstnameAmendStaff.Name = "lblFirstnameAmendStaff";
            this.lblFirstnameAmendStaff.Size = new System.Drawing.Size(116, 22);
            this.lblFirstnameAmendStaff.TabIndex = 0;
            this.lblFirstnameAmendStaff.Text = "Firstname:";
            // 
            // tabNewRepair
            // 
            this.tabNewRepair.Controls.Add(this.startTab);
            this.tabNewRepair.Controls.Add(this.custTab);
            this.tabNewRepair.Controls.Add(this.problemTab);
            this.tabNewRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNewRepair.Location = new System.Drawing.Point(0, 82);
            this.tabNewRepair.Name = "tabNewRepair";
            this.tabNewRepair.SelectedIndex = 0;
            this.tabNewRepair.Size = new System.Drawing.Size(706, 461);
            this.tabNewRepair.TabIndex = 1;
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
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.Transparent;
            this.btnBack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack2.Image = global::CompSys.Properties.Resources.btnBack1;
            this.btnBack2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack2.Location = new System.Drawing.Point(484, 22);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(101, 42);
            this.btnBack2.TabIndex = 13;
            this.btnBack2.Text = "Back";
            this.btnBack2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack2.UseCompatibleTextRendering = true;
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Visible = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnBack3
            // 
            this.btnBack3.BackColor = System.Drawing.Color.Transparent;
            this.btnBack3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack3.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack3.Image = global::CompSys.Properties.Resources.btnBack1;
            this.btnBack3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack3.Location = new System.Drawing.Point(373, 22);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(101, 42);
            this.btnBack3.TabIndex = 14;
            this.btnBack3.Text = "Back";
            this.btnBack3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack3.UseCompatibleTextRendering = true;
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Visible = false;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // frmNewRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgDefault;
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.btnBack3);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabNewRepair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmNewRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - New Repair";
            this.Load += new System.EventHandler(this.frmNewRepair_Load);
            this.problemTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbProblem.ResumeLayout(false);
            this.gbDevice.ResumeLayout(false);
            this.gbDevice.PerformLayout();
            this.custTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListCust)).EndInit();
            this.startTab.ResumeLayout(false);
            this.gbSearchAmendStaff.ResumeLayout(false);
            this.gbSearchAmendStaff.PerformLayout();
            this.tabNewRepair.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.TabPage problemTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.GroupBox gbProblem;
        private System.Windows.Forms.CheckedListBox clbProblem;
        private System.Windows.Forms.GroupBox gbDevice;
        private System.Windows.Forms.ComboBox cbOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDeviceType;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TabPage custTab;
        private System.Windows.Forms.TabPage startTab;
        private System.Windows.Forms.TabControl tabNewRepair;
        private System.Windows.Forms.GroupBox gbSearchAmendStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQueryTown;
        private System.Windows.Forms.Label lblTownAmendStaff;
        private System.Windows.Forms.TextBox tbQuerySurname;
        private System.Windows.Forms.Label lblLastnameAmendStaff;
        private System.Windows.Forms.TextBox tbQueryFirstname;
        private System.Windows.Forms.Label lblFirstnameAmendStaff;
        private System.Windows.Forms.DataGridView grdListCust;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewButtonColumn AmendCell;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnBack3;
    }
}
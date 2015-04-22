namespace CompSys
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "55,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "35,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "5,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "20,0,0,0");
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.staffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEstimateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finaliseRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRepairJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picCustomerMain = new System.Windows.Forms.PictureBox();
            this.btnMainAddCustomer = new System.Windows.Forms.Button();
            this.lblGetStartedMain = new System.Windows.Forms.Label();
            this.picRepairMain = new System.Windows.Forms.PictureBox();
            this.btnMainNewRepair = new System.Windows.Forms.Button();
            this.picInvoiceMain = new System.Windows.Forms.PictureBox();
            this.btnMainNewInvoice = new System.Windows.Forms.Button();
            this.picEstimateMain = new System.Windows.Forms.PictureBox();
            this.btnNewEstimateMain = new System.Windows.Forms.Button();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRepair = new System.Windows.Forms.Label();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepairMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvoiceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstimateMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.msMain.BackColor = System.Drawing.Color.DarkKhaki;
            this.msMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msMain.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem1,
            this.custToolStripMenuItem,
            this.repairToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.userToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(100, 1, 0, 1);
            this.msMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.msMain.ShowItemToolTips = true;
            this.msMain.Size = new System.Drawing.Size(704, 40);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMain";
            // 
            // staffToolStripMenuItem1
            // 
            this.staffToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.staffToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStaffToolStripMenuItem,
            this.amendStaffToolStripMenuItem,
            this.listStaffToolStripMenuItem});
            this.staffToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staffToolStripMenuItem1.Name = "staffToolStripMenuItem1";
            this.staffToolStripMenuItem1.ShortcutKeyDisplayString = "S";
            this.staffToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.staffToolStripMenuItem1.Size = new System.Drawing.Size(102, 38);
            this.staffToolStripMenuItem1.Text = "STAFF";
            this.staffToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newStaffToolStripMenuItem
            // 
            this.newStaffToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.newStaffToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStaffToolStripMenuItem.Image = global::CompSys.Properties.Resources.profile29;
            this.newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            this.newStaffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.newStaffToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.newStaffToolStripMenuItem.Text = "New Staff";
            this.newStaffToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newStaffToolStripMenuItem.Click += new System.EventHandler(this.newStaffToolStripMenuItem_Click);
            // 
            // amendStaffToolStripMenuItem
            // 
            this.amendStaffToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amendStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("amendStaffToolStripMenuItem.Image")));
            this.amendStaffToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.amendStaffToolStripMenuItem.Name = "amendStaffToolStripMenuItem";
            this.amendStaffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.amendStaffToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.amendStaffToolStripMenuItem.Text = "Amend Staff";
            this.amendStaffToolStripMenuItem.Click += new System.EventHandler(this.amendStaffToolStripMenuItem_Click);
            // 
            // listStaffToolStripMenuItem
            // 
            this.listStaffToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listStaffToolStripMenuItem.Image")));
            this.listStaffToolStripMenuItem.Name = "listStaffToolStripMenuItem";
            this.listStaffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.listStaffToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.listStaffToolStripMenuItem.Text = "List Staff";
            this.listStaffToolStripMenuItem.Click += new System.EventHandler(this.listStaffToolStripMenuItem_Click);
            // 
            // custToolStripMenuItem
            // 
            this.custToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem,
            this.amendCustomerToolStripMenuItem,
            this.queryCustomerToolStripMenuItem,
            this.listCustomersToolStripMenuItem});
            this.custToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.custToolStripMenuItem.Name = "custToolStripMenuItem";
            this.custToolStripMenuItem.Size = new System.Drawing.Size(166, 38);
            this.custToolStripMenuItem.Text = "CUSTOMER";
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerToolStripMenuItem.Image = global::CompSys.Properties.Resources.profile29;
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // amendCustomerToolStripMenuItem
            // 
            this.amendCustomerToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amendCustomerToolStripMenuItem.Image = global::CompSys.Properties.Resources.pencil124;
            this.amendCustomerToolStripMenuItem.Name = "amendCustomerToolStripMenuItem";
            this.amendCustomerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.amendCustomerToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.amendCustomerToolStripMenuItem.Text = "Amend Customer";
            this.amendCustomerToolStripMenuItem.Click += new System.EventHandler(this.amendCustomerToolStripMenuItem_Click);
            // 
            // queryCustomerToolStripMenuItem
            // 
            this.queryCustomerToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryCustomerToolStripMenuItem.Image = global::CompSys.Properties.Resources.book244;
            this.queryCustomerToolStripMenuItem.Name = "queryCustomerToolStripMenuItem";
            this.queryCustomerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.queryCustomerToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.queryCustomerToolStripMenuItem.Text = "Query Customer";
            this.queryCustomerToolStripMenuItem.Click += new System.EventHandler(this.queryCustomerToolStripMenuItem_Click);
            // 
            // listCustomersToolStripMenuItem
            // 
            this.listCustomersToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCustomersToolStripMenuItem.Image = global::CompSys.Properties.Resources.notes26;
            this.listCustomersToolStripMenuItem.Name = "listCustomersToolStripMenuItem";
            this.listCustomersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listCustomersToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.listCustomersToolStripMenuItem.Text = "List Customers";
            this.listCustomersToolStripMenuItem.Click += new System.EventHandler(this.listCustomersToolStripMenuItem_Click);
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRepairToolStripMenuItem,
            this.setEstimateToolStripMenuItem,
            this.validateRepairToolStripMenuItem,
            this.finaliseRepairToolStripMenuItem,
            this.collectRepairToolStripMenuItem,
            this.repairReportsToolStripMenuItem});
            this.repairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(118, 38);
            this.repairToolStripMenuItem.Text = "REPAIR";
            // 
            // newRepairToolStripMenuItem
            // 
            this.newRepairToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRepairToolStripMenuItem.Image = global::CompSys.Properties.Resources.repair17;
            this.newRepairToolStripMenuItem.Name = "newRepairToolStripMenuItem";
            this.newRepairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.newRepairToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
            this.newRepairToolStripMenuItem.Text = "New Repair";
            this.newRepairToolStripMenuItem.Click += new System.EventHandler(this.newRepairToolStripMenuItem_Click);
            // 
            // setEstimateToolStripMenuItem
            // 
            this.setEstimateToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setEstimateToolStripMenuItem.Image = global::CompSys.Properties.Resources.sheet31;
            this.setEstimateToolStripMenuItem.Name = "setEstimateToolStripMenuItem";
            this.setEstimateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.setEstimateToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
            this.setEstimateToolStripMenuItem.Text = "Set Estimate";
            this.setEstimateToolStripMenuItem.Click += new System.EventHandler(this.setEstimateToolStripMenuItem_Click);
            // 
            // validateRepairToolStripMenuItem
            // 
            this.validateRepairToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateRepairToolStripMenuItem.Image = global::CompSys.Properties.Resources.envelope54;
            this.validateRepairToolStripMenuItem.Name = "validateRepairToolStripMenuItem";
            this.validateRepairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.validateRepairToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
            this.validateRepairToolStripMenuItem.Text = "Validate Repair";
            this.validateRepairToolStripMenuItem.Click += new System.EventHandler(this.validateRepairToolStripMenuItem_Click);
            // 
            // finaliseRepairToolStripMenuItem
            // 
            this.finaliseRepairToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finaliseRepairToolStripMenuItem.Image = global::CompSys.Properties.Resources.caution7;
            this.finaliseRepairToolStripMenuItem.Name = "finaliseRepairToolStripMenuItem";
            this.finaliseRepairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.finaliseRepairToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
            this.finaliseRepairToolStripMenuItem.Text = "Finalise Repair";
            this.finaliseRepairToolStripMenuItem.Click += new System.EventHandler(this.finaliseRepairToolStripMenuItem_Click);
            // 
            // collectRepairToolStripMenuItem
            // 
            this.collectRepairToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectRepairToolStripMenuItem.Image = global::CompSys.Properties.Resources.message30;
            this.collectRepairToolStripMenuItem.Name = "collectRepairToolStripMenuItem";
            this.collectRepairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.collectRepairToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
            this.collectRepairToolStripMenuItem.Text = "Collect Repair";
            this.collectRepairToolStripMenuItem.Click += new System.EventHandler(this.collectRepairToolStripMenuItem_Click);
            // 
            // repairReportsToolStripMenuItem
            // 
            this.repairReportsToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairReportsToolStripMenuItem.Image = global::CompSys.Properties.Resources.screwdriver26;
            this.repairReportsToolStripMenuItem.Name = "repairReportsToolStripMenuItem";
            this.repairReportsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.repairReportsToolStripMenuItem.Size = new System.Drawing.Size(343, 30);
            this.repairReportsToolStripMenuItem.Text = "Repair Report";
            this.repairReportsToolStripMenuItem.Click += new System.EventHandler(this.repairReportsToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listRepairJobsToolStripMenuItem,
            this.issueInvoiceToolStripMenuItem,
            this.incomeAnalysisToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.administrationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(110, 38);
            this.administrationToolStripMenuItem.Text = "ADMIN";
            // 
            // listRepairJobsToolStripMenuItem
            // 
            this.listRepairJobsToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRepairJobsToolStripMenuItem.Image = global::CompSys.Properties.Resources.notes26;
            this.listRepairJobsToolStripMenuItem.Name = "listRepairJobsToolStripMenuItem";
            this.listRepairJobsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.listRepairJobsToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.listRepairJobsToolStripMenuItem.Text = "List Repair Jobs";
            this.listRepairJobsToolStripMenuItem.Click += new System.EventHandler(this.listRepairJobsToolStripMenuItem_Click);
            // 
            // issueInvoiceToolStripMenuItem
            // 
            this.issueInvoiceToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueInvoiceToolStripMenuItem.Image = global::CompSys.Properties.Resources.sheet3;
            this.issueInvoiceToolStripMenuItem.Name = "issueInvoiceToolStripMenuItem";
            this.issueInvoiceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.I)));
            this.issueInvoiceToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.issueInvoiceToolStripMenuItem.Text = "Issue Invoice";
            this.issueInvoiceToolStripMenuItem.Click += new System.EventHandler(this.issueInvoiceToolStripMenuItem_Click);
            // 
            // incomeAnalysisToolStripMenuItem
            // 
            this.incomeAnalysisToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeAnalysisToolStripMenuItem.Image = global::CompSys.Properties.Resources.chart46;
            this.incomeAnalysisToolStripMenuItem.Name = "incomeAnalysisToolStripMenuItem";
            this.incomeAnalysisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.incomeAnalysisToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.incomeAnalysisToolStripMenuItem.Text = "Income Analysis";
            this.incomeAnalysisToolStripMenuItem.Click += new System.EventHandler(this.incomeAnalysisToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryToolStripMenuItem.Image = global::CompSys.Properties.Resources.chart45;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.setRepairRateToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.userToolStripMenuItem.Size = new System.Drawing.Size(28, 38);
            this.userToolStripMenuItem.Text = null;
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // picCustomerMain
            // 
            this.picCustomerMain.BackColor = System.Drawing.Color.Transparent;
            this.picCustomerMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picCustomerMain.Image = global::CompSys.Properties.Resources.user;
            this.picCustomerMain.Location = new System.Drawing.Point(12, 217);
            this.picCustomerMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picCustomerMain.Name = "picCustomerMain";
            this.picCustomerMain.Size = new System.Drawing.Size(64, 64);
            this.picCustomerMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomerMain.TabIndex = 1;
            this.picCustomerMain.TabStop = false;
            // 
            // btnMainAddCustomer
            // 
            this.btnMainAddCustomer.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainAddCustomer.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnMainAddCustomer.Image = global::CompSys.Properties.Resources.btnGold;
            this.btnMainAddCustomer.Location = new System.Drawing.Point(90, 227);
            this.btnMainAddCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMainAddCustomer.Name = "btnMainAddCustomer";
            this.btnMainAddCustomer.Size = new System.Drawing.Size(205, 53);
            this.btnMainAddCustomer.TabIndex = 3;
            this.btnMainAddCustomer.Text = "+ Add Customer";
            this.btnMainAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainAddCustomer.UseVisualStyleBackColor = true;
            this.btnMainAddCustomer.Click += new System.EventHandler(this.btnMainAddCustomer_Click);
            // 
            // lblGetStartedMain
            // 
            this.lblGetStartedMain.AutoSize = true;
            this.lblGetStartedMain.BackColor = System.Drawing.Color.Transparent;
            this.lblGetStartedMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetStartedMain.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblGetStartedMain.Location = new System.Drawing.Point(85, 181);
            this.lblGetStartedMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGetStartedMain.Name = "lblGetStartedMain";
            this.lblGetStartedMain.Size = new System.Drawing.Size(145, 29);
            this.lblGetStartedMain.TabIndex = 4;
            this.lblGetStartedMain.Text = "Get Started";
            // 
            // picRepairMain
            // 
            this.picRepairMain.BackColor = System.Drawing.Color.Transparent;
            this.picRepairMain.Image = global::CompSys.Properties.Resources.repair;
            this.picRepairMain.Location = new System.Drawing.Point(12, 286);
            this.picRepairMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picRepairMain.Name = "picRepairMain";
            this.picRepairMain.Size = new System.Drawing.Size(64, 64);
            this.picRepairMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRepairMain.TabIndex = 5;
            this.picRepairMain.TabStop = false;
            // 
            // btnMainNewRepair
            // 
            this.btnMainNewRepair.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainNewRepair.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnMainNewRepair.Image = global::CompSys.Properties.Resources.btnGold;
            this.btnMainNewRepair.Location = new System.Drawing.Point(90, 298);
            this.btnMainNewRepair.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMainNewRepair.Name = "btnMainNewRepair";
            this.btnMainNewRepair.Size = new System.Drawing.Size(205, 53);
            this.btnMainNewRepair.TabIndex = 6;
            this.btnMainNewRepair.Text = "+ New Repair";
            this.btnMainNewRepair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainNewRepair.UseVisualStyleBackColor = true;
            this.btnMainNewRepair.Click += new System.EventHandler(this.btnMainNewRepair_Click);
            // 
            // picInvoiceMain
            // 
            this.picInvoiceMain.BackColor = System.Drawing.Color.Transparent;
            this.picInvoiceMain.Image = global::CompSys.Properties.Resources.invo;
            this.picInvoiceMain.Location = new System.Drawing.Point(12, 355);
            this.picInvoiceMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picInvoiceMain.Name = "picInvoiceMain";
            this.picInvoiceMain.Size = new System.Drawing.Size(64, 64);
            this.picInvoiceMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInvoiceMain.TabIndex = 7;
            this.picInvoiceMain.TabStop = false;
            // 
            // btnMainNewInvoice
            // 
            this.btnMainNewInvoice.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainNewInvoice.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnMainNewInvoice.Image = global::CompSys.Properties.Resources.btnGold;
            this.btnMainNewInvoice.Location = new System.Drawing.Point(90, 367);
            this.btnMainNewInvoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMainNewInvoice.Name = "btnMainNewInvoice";
            this.btnMainNewInvoice.Size = new System.Drawing.Size(205, 53);
            this.btnMainNewInvoice.TabIndex = 8;
            this.btnMainNewInvoice.Text = "+ New Invoice";
            this.btnMainNewInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainNewInvoice.UseVisualStyleBackColor = true;
            this.btnMainNewInvoice.Click += new System.EventHandler(this.btnMainNewInvoice_Click);
            // 
            // picEstimateMain
            // 
            this.picEstimateMain.BackColor = System.Drawing.Color.Transparent;
            this.picEstimateMain.Image = global::CompSys.Properties.Resources.est;
            this.picEstimateMain.Location = new System.Drawing.Point(12, 426);
            this.picEstimateMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picEstimateMain.Name = "picEstimateMain";
            this.picEstimateMain.Size = new System.Drawing.Size(64, 64);
            this.picEstimateMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEstimateMain.TabIndex = 9;
            this.picEstimateMain.TabStop = false;
            // 
            // btnNewEstimateMain
            // 
            this.btnNewEstimateMain.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEstimateMain.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnNewEstimateMain.Image = global::CompSys.Properties.Resources.btnGold;
            this.btnNewEstimateMain.Location = new System.Drawing.Point(90, 438);
            this.btnNewEstimateMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNewEstimateMain.Name = "btnNewEstimateMain";
            this.btnNewEstimateMain.Size = new System.Drawing.Size(205, 53);
            this.btnNewEstimateMain.TabIndex = 10;
            this.btnNewEstimateMain.Text = "+ New Estimate";
            this.btnNewEstimateMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEstimateMain.UseVisualStyleBackColor = true;
            this.btnNewEstimateMain.Click += new System.EventHandler(this.btnNewEstimateMain_Click);
            // 
            // chartMain
            // 
            this.chartMain.BackColor = System.Drawing.Color.Transparent;
            this.chartMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartMain.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.chartMain.BackSecondaryColor = System.Drawing.Color.White;
            this.chartMain.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Perspective = 100;
            chartArea1.Area3DStyle.PointGapDepth = 1000;
            chartArea1.Area3DStyle.Rotation = 90;
            chartArea1.Area3DStyle.WallWidth = 30;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.Maroon;
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(301, 227);
            this.chartMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartMain.Name = "chartMain";
            this.chartMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsXValueIndexed = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.LegendText = "New Repair";
            dataPoint2.LegendText = "Fixed Repair";
            dataPoint3.LegendText = "Cancelled";
            dataPoint4.LegendText = "Collected";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.YValuesPerPoint = 4;
            this.chartMain.Series.Add(series1);
            this.chartMain.Size = new System.Drawing.Size(391, 263);
            this.chartMain.TabIndex = 11;
            this.chartMain.Text = "chartMain";
            // 
            // lblRepair
            // 
            this.lblRepair.AutoSize = true;
            this.lblRepair.BackColor = System.Drawing.Color.Transparent;
            this.lblRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepair.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRepair.Location = new System.Drawing.Point(423, 181);
            this.lblRepair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepair.Name = "lblRepair";
            this.lblRepair.Size = new System.Drawing.Size(269, 29);
            this.lblRepair.TabIndex = 12;
            this.lblRepair.Text = "Repair Summary 2015";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 542);
            this.Controls.Add(this.lblRepair);
            this.Controls.Add(this.chartMain);
            this.Controls.Add(this.btnNewEstimateMain);
            this.Controls.Add(this.picEstimateMain);
            this.Controls.Add(this.btnMainNewInvoice);
            this.Controls.Add(this.picInvoiceMain);
            this.Controls.Add(this.btnMainNewRepair);
            this.Controls.Add(this.picRepairMain);
            this.Controls.Add(this.lblGetStartedMain);
            this.Controls.Add(this.btnMainAddCustomer);
            this.Controls.Add(this.picCustomerMain);
            this.Controls.Add(this.msMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 581);
            this.MinimumSize = new System.Drawing.Size(720, 581);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepairMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvoiceMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstimateMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem custToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.PictureBox picCustomerMain;
        private System.Windows.Forms.Button btnMainAddCustomer;
        private System.Windows.Forms.Label lblGetStartedMain;
        private System.Windows.Forms.PictureBox picRepairMain;
        private System.Windows.Forms.Button btnMainNewRepair;
        private System.Windows.Forms.PictureBox picInvoiceMain;
        private System.Windows.Forms.Button btnMainNewInvoice;
        private System.Windows.Forms.PictureBox picEstimateMain;
        private System.Windows.Forms.Button btnNewEstimateMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.Label lblRepair;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amendCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEstimateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finaliseRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amendStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listRepairJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}


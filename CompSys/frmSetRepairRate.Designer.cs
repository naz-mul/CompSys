namespace CompSys
{
    partial class frmSetRepairRate
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "40,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "80,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "500,0,0,0");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetRepairRate));
            this.msSetRate = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSetRate = new System.Windows.Forms.GroupBox();
            this.lblCondSR = new System.Windows.Forms.Label();
            this.lblTownNewStaff = new System.Windows.Forms.Label();
            this.lblDescSR = new System.Windows.Forms.Label();
            this.cbCondSR = new System.Windows.Forms.ComboBox();
            this.tbVendorSR = new System.Windows.Forms.TextBox();
            this.tbDescSR = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSaveSR = new System.Windows.Forms.Button();
            this.btnBackListStaff = new System.Windows.Forms.Button();
            this.btnClearSR = new System.Windows.Forms.Button();
            this.lblPriceSR = new System.Windows.Forms.Label();
            this.tbPriceSR = new System.Windows.Forms.TextBox();
            this.lblStockSR = new System.Windows.Forms.Label();
            this.tbQuantitySR = new System.Windows.Forms.TextBox();
            this.lblStockSummary = new System.Windows.Forms.Label();
       
            this.msSetRate.SuspendLayout();
            this.gbSetRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
   
            this.SuspendLayout();
            // 
            // msSetRate
            // 
            this.msSetRate.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msSetRate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.repairToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msSetRate.Location = new System.Drawing.Point(0, 0);
            this.msSetRate.Name = "msSetRate";
            this.msSetRate.Size = new System.Drawing.Size(704, 27);
            this.msSetRate.TabIndex = 0;
            this.msSetRate.Text = "msSetRate";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.repairToolStripMenuItem.Text = "Repair";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gbSetRate
            // 
            this.gbSetRate.BackColor = System.Drawing.Color.SaddleBrown;
            this.gbSetRate.Controls.Add(this.tbQuantitySR);
            this.gbSetRate.Controls.Add(this.lblStockSR);
            this.gbSetRate.Controls.Add(this.tbPriceSR);
            this.gbSetRate.Controls.Add(this.lblPriceSR);
            this.gbSetRate.Controls.Add(this.lblCondSR);
            this.gbSetRate.Controls.Add(this.lblTownNewStaff);
            this.gbSetRate.Controls.Add(this.lblDescSR);
            this.gbSetRate.Controls.Add(this.cbCondSR);
            this.gbSetRate.Controls.Add(this.tbVendorSR);
            this.gbSetRate.Controls.Add(this.tbDescSR);
            this.gbSetRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSetRate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSetRate.Location = new System.Drawing.Point(12, 91);
            this.gbSetRate.Name = "gbSetRate";
            this.gbSetRate.Size = new System.Drawing.Size(370, 289);
            this.gbSetRate.TabIndex = 3;
            this.gbSetRate.TabStop = false;
            this.gbSetRate.Text = "Set Repair Rate:";
            // 
            // lblCondSR
            // 
            this.lblCondSR.AutoSize = true;
            this.lblCondSR.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondSR.Location = new System.Drawing.Point(7, 139);
            this.lblCondSR.Name = "lblCondSR";
            this.lblCondSR.Size = new System.Drawing.Size(81, 15);
            this.lblCondSR.TabIndex = 7;
            this.lblCondSR.Text = "Condition:";
            this.lblCondSR.Click += new System.EventHandler(this.lblCountyNewStaff_Click);
            // 
            // lblTownNewStaff
            // 
            this.lblTownNewStaff.AutoSize = true;
            this.lblTownNewStaff.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownNewStaff.Location = new System.Drawing.Point(7, 95);
            this.lblTownNewStaff.Name = "lblTownNewStaff";
            this.lblTownNewStaff.Size = new System.Drawing.Size(62, 15);
            this.lblTownNewStaff.TabIndex = 6;
            this.lblTownNewStaff.Text = "Vendor:";
            // 
            // lblDescSR
            // 
            this.lblDescSR.AutoSize = true;
            this.lblDescSR.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSR.Location = new System.Drawing.Point(6, 52);
            this.lblDescSR.Name = "lblDescSR";
            this.lblDescSR.Size = new System.Drawing.Size(89, 15);
            this.lblDescSR.TabIndex = 5;
            this.lblDescSR.Text = "Description";
            // 
            // cbCondSR
            // 
            this.cbCondSR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondSR.Items.AddRange(new object[] {
            "New",
            "Refurbished",
            "Used"});
            this.cbCondSR.Location = new System.Drawing.Point(102, 132);
            this.cbCondSR.Name = "cbCondSR";
            this.cbCondSR.Size = new System.Drawing.Size(252, 28);
            this.cbCondSR.TabIndex = 3;
            this.cbCondSR.SelectedIndexChanged += new System.EventHandler(this.cbCountiesNewStaff_SelectedIndexChanged);
            // 
            // tbVendorSR
            // 
            this.tbVendorSR.Location = new System.Drawing.Point(102, 88);
            this.tbVendorSR.Name = "tbVendorSR";
            this.tbVendorSR.Size = new System.Drawing.Size(252, 26);
            this.tbVendorSR.TabIndex = 2;
            // 
            // tbDescSR
            // 
            this.tbDescSR.Location = new System.Drawing.Point(102, 45);
            this.tbDescSR.Name = "tbDescSR";
            this.tbDescSR.Size = new System.Drawing.Size(252, 26);
            this.tbDescSR.TabIndex = 1;
            this.tbDescSR.TextChanged += new System.EventHandler(this.tbDescSR_TextChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedVertical;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
    
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(392, 116);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.CustomProperties = "PieLineColor=255\\, 255\\, 192, PieDrawingStyle=Concave";
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.DimGray;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            dataPoint1.BackSecondaryColor = System.Drawing.Color.Black;
            dataPoint1.BorderColor = System.Drawing.Color.Transparent;
            dataPoint1.LegendText = "New";
            dataPoint2.LegendText = "Refurbished";
            dataPoint3.LegendText = "Used";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.ShadowColor = System.Drawing.Color.Silver;
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 264);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnSaveSR
            // 
            this.btnSaveSR.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveSR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveSR.BackgroundImage")));
            this.btnSaveSR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSaveSR.Location = new System.Drawing.Point(0, 386);
            this.btnSaveSR.Name = "btnSaveSR";
            this.btnSaveSR.Size = new System.Drawing.Size(704, 38);
            this.btnSaveSR.TabIndex = 16;
            this.btnSaveSR.Text = "SAVE REPAIR RATE";
            this.btnSaveSR.UseVisualStyleBackColor = false;
            // 
            // btnBackListStaff
            // 
            this.btnBackListStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackListStaff.BackgroundImage")));
            this.btnBackListStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackListStaff.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackListStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackListStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackListStaff.Location = new System.Drawing.Point(12, 500);
            this.btnBackListStaff.Name = "btnBackListStaff";
            this.btnBackListStaff.Size = new System.Drawing.Size(91, 30);
            this.btnBackListStaff.TabIndex = 17;
            this.btnBackListStaff.Text = "<< Back";
            this.btnBackListStaff.UseVisualStyleBackColor = true;
            this.btnBackListStaff.Click += new System.EventHandler(this.btnBackListStaff_Click);
            // 
            // btnClearSR
            // 
            this.btnClearSR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearSR.BackgroundImage")));
            this.btnClearSR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSR.ForeColor = System.Drawing.Color.Navy;
            this.btnClearSR.Location = new System.Drawing.Point(118, 500);
            this.btnClearSR.Name = "btnClearSR";
            this.btnClearSR.Size = new System.Drawing.Size(91, 30);
            this.btnClearSR.TabIndex = 18;
            this.btnClearSR.Text = "Clear";
            this.btnClearSR.UseVisualStyleBackColor = true;
            this.btnClearSR.Click += new System.EventHandler(this.btnClearSR_Click);
            // 
            // lblPriceSR
            // 
            this.lblPriceSR.AutoSize = true;
            this.lblPriceSR.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceSR.Location = new System.Drawing.Point(7, 185);
            this.lblPriceSR.Name = "lblPriceSR";
            this.lblPriceSR.Size = new System.Drawing.Size(45, 15);
            this.lblPriceSR.TabIndex = 8;
            this.lblPriceSR.Text = "Price:";
            // 
            // tbPriceSR
            // 
            this.tbPriceSR.Location = new System.Drawing.Point(102, 178);
            this.tbPriceSR.Name = "tbPriceSR";
            this.tbPriceSR.Size = new System.Drawing.Size(95, 26);
            this.tbPriceSR.TabIndex = 9;
            // 
            // lblStockSR
            // 
            this.lblStockSR.AutoSize = true;
            this.lblStockSR.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockSR.Location = new System.Drawing.Point(7, 229);
            this.lblStockSR.Name = "lblStockSR";
            this.lblStockSR.Size = new System.Drawing.Size(73, 15);
            this.lblStockSR.TabIndex = 10;
            this.lblStockSR.Text = "Quantity:";
            // 
            // tbQuantitySR
            // 
            this.tbQuantitySR.Location = new System.Drawing.Point(102, 222);
            this.tbQuantitySR.Name = "tbQuantitySR";
            this.tbQuantitySR.Size = new System.Drawing.Size(95, 26);
            this.tbQuantitySR.TabIndex = 11;
            // 
            // lblStockSummary
            // 
            this.lblStockSummary.AutoSize = true;
            this.lblStockSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblStockSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockSummary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStockSummary.Location = new System.Drawing.Point(558, 91);
            this.lblStockSummary.Name = "lblStockSummary";
            this.lblStockSummary.Size = new System.Drawing.Size(134, 20);
            this.lblStockSummary.TabIndex = 19;
            this.lblStockSummary.Text = "Stock Summary";
            this.lblStockSummary.Click += new System.EventHandler(this.label1_Click);
            // 
            // compuRite
          
            // 
            // frmSetRepairRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 542);
            this.Controls.Add(this.lblStockSummary);
            this.Controls.Add(this.btnClearSR);
            this.Controls.Add(this.btnBackListStaff);
            this.Controls.Add(this.btnSaveSR);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gbSetRate);
            this.Controls.Add(this.msSetRate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msSetRate;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmSetRepairRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - Set Repair Rate";
            this.Load += new System.EventHandler(this.frmSetRepairRate_Load);
            this.msSetRate.ResumeLayout(false);
            this.msSetRate.PerformLayout();
            this.gbSetRate.ResumeLayout(false);
            this.gbSetRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
 
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msSetRate;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbSetRate;
        private System.Windows.Forms.Label lblCondSR;
        private System.Windows.Forms.Label lblTownNewStaff;
        private System.Windows.Forms.Label lblDescSR;
        private System.Windows.Forms.ComboBox cbCondSR;
        private System.Windows.Forms.TextBox tbVendorSR;
        private System.Windows.Forms.TextBox tbDescSR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnSaveSR;
        private System.Windows.Forms.Button btnBackListStaff;
        private System.Windows.Forms.Button btnClearSR;
        private System.Windows.Forms.TextBox tbQuantitySR;
        private System.Windows.Forms.Label lblStockSR;
        private System.Windows.Forms.TextBox tbPriceSR;
        private System.Windows.Forms.Label lblPriceSR;
        private System.Windows.Forms.Label lblStockSummary;

    }
}
namespace CompSys
{
    partial class frmListStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListStaff));
            this.dgvListStaff = new System.Windows.Forms.DataGridView();
            this.printStaffList = new System.Drawing.Printing.PrintDocument();
            this.btnPrintStaffList = new System.Windows.Forms.Button();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.rbRegDate = new System.Windows.Forms.RadioButton();
            this.rbFirstname = new System.Windows.Forms.RadioButton();
            this.rbLastname = new System.Windows.Forms.RadioButton();
            this.rbTown = new System.Windows.Forms.RadioButton();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).BeginInit();
            this.gbSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListStaff
            // 
            this.dgvListStaff.AllowUserToAddRows = false;
            this.dgvListStaff.AllowUserToDeleteRows = false;
            this.dgvListStaff.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListStaff.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvListStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvListStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListStaff.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListStaff.Location = new System.Drawing.Point(12, 129);
            this.dgvListStaff.Name = "dgvListStaff";
            this.dgvListStaff.ReadOnly = true;
            this.dgvListStaff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListStaff.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvListStaff.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListStaff.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListStaff.RowTemplate.DividerHeight = 3;
            this.dgvListStaff.Size = new System.Drawing.Size(680, 358);
            this.dgvListStaff.TabIndex = 13;
            // 
            // printStaffList
            // 
            this.printStaffList.DocumentName = "Printing Staff List";
            this.printStaffList.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printStaffList_BeginPrint);
            this.printStaffList.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printStaffList_PrintPage);
            // 
            // btnPrintStaffList
            // 
            this.btnPrintStaffList.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintStaffList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintStaffList.BackgroundImage")));
            this.btnPrintStaffList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintStaffList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPrintStaffList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintStaffList.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintStaffList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPrintStaffList.Location = new System.Drawing.Point(0, 500);
            this.btnPrintStaffList.Name = "btnPrintStaffList";
            this.btnPrintStaffList.Size = new System.Drawing.Size(704, 42);
            this.btnPrintStaffList.TabIndex = 17;
            this.btnPrintStaffList.Text = "Print Staff Details";
            this.btnPrintStaffList.UseCompatibleTextRendering = true;
            this.btnPrintStaffList.UseVisualStyleBackColor = false;
            this.btnPrintStaffList.Click += new System.EventHandler(this.btnPrintStaffList_Click);
            // 
            // gbSortBy
            // 
            this.gbSortBy.BackColor = System.Drawing.Color.Transparent;
            this.gbSortBy.Controls.Add(this.rbRegDate);
            this.gbSortBy.Controls.Add(this.cbStatus);
            this.gbSortBy.Controls.Add(this.rbFirstname);
            this.gbSortBy.Controls.Add(this.rbLastname);
            this.gbSortBy.Controls.Add(this.rbTown);
            this.gbSortBy.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSortBy.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gbSortBy.Location = new System.Drawing.Point(12, 71);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Size = new System.Drawing.Size(680, 52);
            this.gbSortBy.TabIndex = 20;
            this.gbSortBy.TabStop = false;
            this.gbSortBy.Text = "Sort by:";
            // 
            // rbRegDate
            // 
            this.rbRegDate.AutoSize = true;
            this.rbRegDate.BackColor = System.Drawing.Color.Transparent;
            this.rbRegDate.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbRegDate.Location = new System.Drawing.Point(432, 19);
            this.rbRegDate.Name = "rbRegDate";
            this.rbRegDate.Size = new System.Drawing.Size(91, 20);
            this.rbRegDate.TabIndex = 17;
            this.rbRegDate.TabStop = true;
            this.rbRegDate.Text = "REG DATE";
            this.rbRegDate.UseVisualStyleBackColor = false;
            this.rbRegDate.CheckedChanged += new System.EventHandler(this.rbRegDate_CheckedChanged);
            // 
            // rbFirstname
            // 
            this.rbFirstname.AutoSize = true;
            this.rbFirstname.BackColor = System.Drawing.Color.Transparent;
            this.rbFirstname.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFirstname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbFirstname.Location = new System.Drawing.Point(169, 18);
            this.rbFirstname.Name = "rbFirstname";
            this.rbFirstname.Size = new System.Drawing.Size(96, 20);
            this.rbFirstname.TabIndex = 14;
            this.rbFirstname.TabStop = true;
            this.rbFirstname.Text = "FORENAME";
            this.rbFirstname.UseVisualStyleBackColor = false;
            this.rbFirstname.CheckedChanged += new System.EventHandler(this.rbFirstname_CheckedChanged);
            // 
            // rbLastname
            // 
            this.rbLastname.AutoSize = true;
            this.rbLastname.BackColor = System.Drawing.Color.Transparent;
            this.rbLastname.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLastname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbLastname.Location = new System.Drawing.Point(38, 19);
            this.rbLastname.Name = "rbLastname";
            this.rbLastname.Size = new System.Drawing.Size(88, 20);
            this.rbLastname.TabIndex = 15;
            this.rbLastname.TabStop = true;
            this.rbLastname.Text = "SURNAME";
            this.rbLastname.UseVisualStyleBackColor = false;
            this.rbLastname.CheckedChanged += new System.EventHandler(this.rbLastname_CheckedChanged);
            // 
            // rbTown
            // 
            this.rbTown.AutoSize = true;
            this.rbTown.BackColor = System.Drawing.Color.Transparent;
            this.rbTown.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbTown.Location = new System.Drawing.Point(312, 19);
            this.rbTown.Name = "rbTown";
            this.rbTown.Size = new System.Drawing.Size(67, 20);
            this.rbTown.TabIndex = 16;
            this.rbTown.TabStop = true;
            this.rbTown.Text = "TOWN";
            this.rbTown.UseVisualStyleBackColor = false;
            this.rbTown.CheckedChanged += new System.EventHandler(this.rbTown_CheckedChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbStatus.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbStatus.Location = new System.Drawing.Point(554, 17);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(108, 24);
            this.cbStatus.Sorted = true;
            this.cbStatus.TabIndex = 18;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
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
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmListStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 542);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbSortBy);
            this.Controls.Add(this.btnPrintStaffList);
            this.Controls.Add(this.dgvListStaff);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmListStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - List Staff";
            this.Load += new System.EventHandler(this.frmListStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).EndInit();
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListStaff;
        private System.Drawing.Printing.PrintDocument printStaffList;
        private System.Windows.Forms.Button btnPrintStaffList;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.RadioButton rbFirstname;
        private System.Windows.Forms.RadioButton rbLastname;
        private System.Windows.Forms.RadioButton rbTown;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.RadioButton rbRegDate;
        private System.Windows.Forms.Button btnBack;
    }
}
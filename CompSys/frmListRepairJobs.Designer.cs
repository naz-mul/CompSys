namespace CompSys
{
    partial class frmListRepairJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListRepairJobs));
            this.printRepairJobs = new System.Drawing.Printing.PrintDocument();
            this.dgvListJobs = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFixing = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFixed = new System.Windows.Forms.Button();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.rbTotal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.rbDescription = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbDevice = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListJobs)).BeginInit();
            this.gbSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // printRepairJobs
            // 
            this.printRepairJobs.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printRepairJobs_BeginPrint);
            this.printRepairJobs.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printRepairJobs_PrintPage);
            // 
            // dgvListJobs
            // 
            this.dgvListJobs.AllowUserToAddRows = false;
            this.dgvListJobs.AllowUserToDeleteRows = false;
            this.dgvListJobs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListJobs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListJobs.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvListJobs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.dgvListJobs.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListJobs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListJobs.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListJobs.Location = new System.Drawing.Point(12, 125);
            this.dgvListJobs.Name = "dgvListJobs";
            this.dgvListJobs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvListJobs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListJobs.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListJobs.RowTemplate.DividerHeight = 3;
            this.dgvListJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListJobs.Size = new System.Drawing.Size(680, 368);
            this.dgvListJobs.TabIndex = 30;
            // 
            // Check
            // 
            this.Check.FillWeight = 30F;
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check.HeaderText = "*";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnFixing
            // 
            this.btnFixing.BackColor = System.Drawing.Color.Snow;
            this.btnFixing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFixing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFixing.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixing.ForeColor = System.Drawing.Color.Olive;
            this.btnFixing.Image = global::CompSys.Properties.Resources.iconAmend;
            this.btnFixing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixing.Location = new System.Drawing.Point(12, 499);
            this.btnFixing.Name = "btnFixing";
            this.btnFixing.Size = new System.Drawing.Size(124, 39);
            this.btnFixing.TabIndex = 32;
            this.btnFixing.Text = "Fixing";
            this.btnFixing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFixing.UseCompatibleTextRendering = true;
            this.btnFixing.UseVisualStyleBackColor = false;
            this.btnFixing.Visible = false;
            this.btnFixing.Click += new System.EventHandler(this.btnFixing_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPrint.Image = global::CompSys.Properties.Resources.iconPrint;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(290, 499);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(124, 39);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnFixed
            // 
            this.btnFixed.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnFixed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFixed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFixed.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixed.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnFixed.Image = global::CompSys.Properties.Resources.iconCheck2;
            this.btnFixed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixed.Location = new System.Drawing.Point(568, 499);
            this.btnFixed.Name = "btnFixed";
            this.btnFixed.Size = new System.Drawing.Size(124, 39);
            this.btnFixed.TabIndex = 34;
            this.btnFixed.Text = "Fixed";
            this.btnFixed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFixed.UseCompatibleTextRendering = true;
            this.btnFixed.UseVisualStyleBackColor = false;
            this.btnFixed.Visible = false;
            this.btnFixed.Click += new System.EventHandler(this.btnFixed_Click);
            // 
            // gbSortBy
            // 
            this.gbSortBy.BackColor = System.Drawing.Color.Transparent;
            this.gbSortBy.Controls.Add(this.rbTotal);
            this.gbSortBy.Controls.Add(this.label2);
            this.gbSortBy.Controls.Add(this.cbStatus);
            this.gbSortBy.Controls.Add(this.rbDescription);
            this.gbSortBy.Controls.Add(this.rbName);
            this.gbSortBy.Controls.Add(this.rbDevice);
            this.gbSortBy.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSortBy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSortBy.Location = new System.Drawing.Point(12, 71);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Size = new System.Drawing.Size(680, 48);
            this.gbSortBy.TabIndex = 35;
            this.gbSortBy.TabStop = false;
            // 
            // rbTotal
            // 
            this.rbTotal.AutoSize = true;
            this.rbTotal.BackColor = System.Drawing.Color.Transparent;
            this.rbTotal.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbTotal.Location = new System.Drawing.Point(463, 20);
            this.rbTotal.Name = "rbTotal";
            this.rbTotal.Size = new System.Drawing.Size(70, 20);
            this.rbTotal.TabIndex = 22;
            this.rbTotal.TabStop = true;
            this.rbTotal.Text = "TOTAL";
            this.rbTotal.UseVisualStyleBackColor = false;
            this.rbTotal.CheckedChanged += new System.EventHandler(this.rbTotal_CheckedChanged);
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
            "Fixing",
            "Resolved",
            "Validated"});
            this.cbStatus.Location = new System.Drawing.Point(556, 17);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(108, 24);
            this.cbStatus.Sorted = true;
            this.cbStatus.TabIndex = 18;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
            // 
            // rbDescription
            // 
            this.rbDescription.AutoSize = true;
            this.rbDescription.BackColor = System.Drawing.Color.Transparent;
            this.rbDescription.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbDescription.Location = new System.Drawing.Point(234, 20);
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
            this.rbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbName.Location = new System.Drawing.Point(111, 20);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(97, 20);
            this.rbName.TabIndex = 15;
            this.rbName.TabStop = true;
            this.rbName.Text = "CUSTOMER";
            this.rbName.UseVisualStyleBackColor = false;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged_1);
            // 
            // rbDevice
            // 
            this.rbDevice.AutoSize = true;
            this.rbDevice.BackColor = System.Drawing.Color.Transparent;
            this.rbDevice.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDevice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbDevice.Location = new System.Drawing.Point(369, 20);
            this.rbDevice.Name = "rbDevice";
            this.rbDevice.Size = new System.Drawing.Size(72, 20);
            this.rbDevice.TabIndex = 16;
            this.rbDevice.TabStop = true;
            this.rbDevice.Text = "DEVICE";
            this.rbDevice.UseVisualStyleBackColor = false;
            this.rbDevice.CheckedChanged += new System.EventHandler(this.rbDevice_CheckedChanged);
            // 
            // frmListRepairJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.gbSortBy);
            this.Controls.Add(this.btnFixed);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnFixing);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvListJobs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmListRepairJobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - List Repair Jobs";
            this.Load += new System.EventHandler(this.frmListRepairJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListJobs)).EndInit();
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printRepairJobs;
        private System.Windows.Forms.DataGridView dgvListJobs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFixing;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnFixed;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.RadioButton rbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.RadioButton rbDescription;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbDevice;
    }
}
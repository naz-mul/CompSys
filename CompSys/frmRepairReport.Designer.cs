namespace CompSys
{
    partial class frmRepairReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepairReport));
            this.btnBack = new System.Windows.Forms.Button();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.rbEstDate = new System.Windows.Forms.RadioButton();
            this.rbRegDate = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.rbTotal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.dgvListJobs = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.gbSortBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListJobs)).BeginInit();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // gbSortBy
            // 
            this.gbSortBy.BackColor = System.Drawing.Color.Transparent;
            this.gbSortBy.Controls.Add(this.rbEstDate);
            this.gbSortBy.Controls.Add(this.rbRegDate);
            this.gbSortBy.Controls.Add(this.rbID);
            this.gbSortBy.Controls.Add(this.rbStatus);
            this.gbSortBy.Controls.Add(this.rbTotal);
            this.gbSortBy.Controls.Add(this.label2);
            this.gbSortBy.Controls.Add(this.rbName);
            this.gbSortBy.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSortBy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSortBy.Location = new System.Drawing.Point(12, 71);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Size = new System.Drawing.Size(680, 48);
            this.gbSortBy.TabIndex = 36;
            this.gbSortBy.TabStop = false;
            // 
            // rbEstDate
            // 
            this.rbEstDate.AutoSize = true;
            this.rbEstDate.BackColor = System.Drawing.Color.Transparent;
            this.rbEstDate.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEstDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbEstDate.Location = new System.Drawing.Point(376, 20);
            this.rbEstDate.Name = "rbEstDate";
            this.rbEstDate.Size = new System.Drawing.Size(99, 20);
            this.rbEstDate.TabIndex = 26;
            this.rbEstDate.TabStop = true;
            this.rbEstDate.Text = "ESTIMATED";
            this.rbEstDate.UseVisualStyleBackColor = false;
            this.rbEstDate.CheckedChanged += new System.EventHandler(this.rbEstDate_CheckedChanged);
            // 
            // rbRegDate
            // 
            this.rbRegDate.AutoSize = true;
            this.rbRegDate.BackColor = System.Drawing.Color.Transparent;
            this.rbRegDate.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbRegDate.Location = new System.Drawing.Point(165, 20);
            this.rbRegDate.Name = "rbRegDate";
            this.rbRegDate.Size = new System.Drawing.Size(80, 20);
            this.rbRegDate.TabIndex = 25;
            this.rbRegDate.TabStop = true;
            this.rbRegDate.Text = "RepDate";
            this.rbRegDate.UseVisualStyleBackColor = false;
            this.rbRegDate.CheckedChanged += new System.EventHandler(this.rbRegDate_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.BackColor = System.Drawing.Color.Transparent;
            this.rbID.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbID.Location = new System.Drawing.Point(109, 20);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(40, 20);
            this.rbID.TabIndex = 24;
            this.rbID.TabStop = true;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = false;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // rbStatus
            // 
            this.rbStatus.AutoSize = true;
            this.rbStatus.BackColor = System.Drawing.Color.Transparent;
            this.rbStatus.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbStatus.Location = new System.Drawing.Point(593, 20);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Size = new System.Drawing.Size(76, 20);
            this.rbStatus.TabIndex = 23;
            this.rbStatus.TabStop = true;
            this.rbStatus.Text = "STATUS";
            this.rbStatus.UseVisualStyleBackColor = false;
            this.rbStatus.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // rbTotal
            // 
            this.rbTotal.AutoSize = true;
            this.rbTotal.BackColor = System.Drawing.Color.Transparent;
            this.rbTotal.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbTotal.Location = new System.Drawing.Point(507, 20);
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
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.BackColor = System.Drawing.Color.Transparent;
            this.rbName.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbName.Location = new System.Drawing.Point(260, 20);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(97, 20);
            this.rbName.TabIndex = 15;
            this.rbName.TabStop = true;
            this.rbName.Text = "CUSTOMER";
            this.rbName.UseVisualStyleBackColor = false;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // dgvListJobs
            // 
            this.dgvListJobs.AllowUserToAddRows = false;
            this.dgvListJobs.AllowUserToDeleteRows = false;
            this.dgvListJobs.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListJobs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListJobs.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvListJobs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.dgvListJobs.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListJobs.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListJobs.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListJobs.Location = new System.Drawing.Point(12, 125);
            this.dgvListJobs.Name = "dgvListJobs";
            this.dgvListJobs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.dgvListJobs.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListJobs.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListJobs.RowTemplate.DividerHeight = 3;
            this.dgvListJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListJobs.Size = new System.Drawing.Size(680, 368);
            this.dgvListJobs.TabIndex = 37;
            // 
            // Check
            // 
            this.Check.FillWeight = 30F;
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check.HeaderText = "*";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.btnPrint.Location = new System.Drawing.Point(272, 499);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(124, 39);
            this.btnPrint.TabIndex = 38;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(565, 499);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(127, 38);
            this.tbTotal.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Total: ";
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // frmRepairReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvListJobs);
            this.Controls.Add(this.gbSortBy);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmRepairReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - Repair Report";
            this.Load += new System.EventHandler(this.frmRepairReport_Load);
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.RadioButton rbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.DataGridView dgvListJobs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.RadioButton rbEstDate;
        private System.Windows.Forms.RadioButton rbRegDate;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbStatus;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument;

    }
}
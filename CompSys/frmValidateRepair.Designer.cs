namespace CompSys
{
    partial class frmValidateRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidateRepair));
            this.dgvListRepairs = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTotal = new System.Windows.Forms.RadioButton();
            this.rbProb = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbDevice = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRepairs)).BeginInit();
            this.gbSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListRepairs
            // 
            this.dgvListRepairs.AllowUserToAddRows = false;
            this.dgvListRepairs.AllowUserToDeleteRows = false;
            this.dgvListRepairs.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListRepairs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListRepairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListRepairs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListRepairs.BackgroundColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListRepairs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRepairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.dgvListRepairs.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListRepairs.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListRepairs.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListRepairs.Location = new System.Drawing.Point(12, 125);
            this.dgvListRepairs.Name = "dgvListRepairs";
            this.dgvListRepairs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListRepairs.RowHeadersVisible = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.dgvListRepairs.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListRepairs.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListRepairs.RowTemplate.DividerHeight = 3;
            this.dgvListRepairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListRepairs.Size = new System.Drawing.Size(680, 334);
            this.dgvListRepairs.TabIndex = 28;
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
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidate.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.ForeColor = System.Drawing.Color.Transparent;
            this.btnValidate.Image = global::CompSys.Properties.Resources.btnAmend;
            this.btnValidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidate.Location = new System.Drawing.Point(226, 465);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(257, 72);
            this.btnValidate.TabIndex = 31;
            this.btnValidate.Text = "Validate Repair";
            this.btnValidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidate.UseCompatibleTextRendering = true;
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.Image = global::CompSys.Properties.Resources.btnClear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(12, 485);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 52);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbSortBy
            // 
            this.gbSortBy.BackColor = System.Drawing.Color.Transparent;
            this.gbSortBy.Controls.Add(this.rbID);
            this.gbSortBy.Controls.Add(this.label1);
            this.gbSortBy.Controls.Add(this.rbTotal);
            this.gbSortBy.Controls.Add(this.rbProb);
            this.gbSortBy.Controls.Add(this.rbCustomer);
            this.gbSortBy.Controls.Add(this.rbDevice);
            this.gbSortBy.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSortBy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSortBy.Location = new System.Drawing.Point(12, 71);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Size = new System.Drawing.Size(680, 48);
            this.gbSortBy.TabIndex = 35;
            this.gbSortBy.TabStop = false;
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.BackColor = System.Drawing.Color.Transparent;
            this.rbID.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbID.Location = new System.Drawing.Point(109, 20);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(86, 20);
            this.rbID.TabIndex = 22;
            this.rbID.TabStop = true;
            this.rbID.Text = "Repair ID";
            this.rbID.UseVisualStyleBackColor = false;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "SORT BY:";
            // 
            // rbTotal
            // 
            this.rbTotal.AutoSize = true;
            this.rbTotal.BackColor = System.Drawing.Color.Transparent;
            this.rbTotal.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbTotal.Location = new System.Drawing.Point(579, 20);
            this.rbTotal.Name = "rbTotal";
            this.rbTotal.Size = new System.Drawing.Size(70, 20);
            this.rbTotal.TabIndex = 17;
            this.rbTotal.TabStop = true;
            this.rbTotal.Text = "TOTAL";
            this.rbTotal.UseVisualStyleBackColor = false;
            this.rbTotal.CheckedChanged += new System.EventHandler(this.rbTotal_CheckedChanged);
            // 
            // rbProb
            // 
            this.rbProb.AutoSize = true;
            this.rbProb.BackColor = System.Drawing.Color.Transparent;
            this.rbProb.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbProb.Location = new System.Drawing.Point(357, 20);
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
            this.rbCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCustomer.Location = new System.Drawing.Point(226, 20);
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
            this.rbDevice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbDevice.Location = new System.Drawing.Point(477, 20);
            this.rbDevice.Name = "rbDevice";
            this.rbDevice.Size = new System.Drawing.Size(72, 20);
            this.rbDevice.TabIndex = 16;
            this.rbDevice.TabStop = true;
            this.rbDevice.Text = "DEVICE";
            this.rbDevice.UseVisualStyleBackColor = false;
            this.rbDevice.CheckedChanged += new System.EventHandler(this.rbDevice_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPrint.Image = global::CompSys.Properties.Resources.iconPrint;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(565, 485);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(127, 52);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // frmValidateRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbSortBy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvListRepairs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmValidateRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - Validate Repair";
            this.Load += new System.EventHandler(this.frmValidateRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRepairs)).EndInit();
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListRepairs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTotal;
        private System.Windows.Forms.RadioButton rbProb;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbDevice;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}
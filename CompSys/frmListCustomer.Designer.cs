namespace CompSys
{
    partial class frmListCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printCustomerList = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.rbRegDate = new System.Windows.Forms.RadioButton();
            this.rbFirstname = new System.Windows.Forms.RadioButton();
            this.rbLastname = new System.Windows.Forms.RadioButton();
            this.rbTown = new System.Windows.Forms.RadioButton();
            this.dgvListCust = new System.Windows.Forms.DataGridView();
            this.gbSortBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCust)).BeginInit();
            this.SuspendLayout();
            // 
            // printCustomerList
            // 
            this.printCustomerList.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printCustomerList_BeginPrint);
            this.printCustomerList.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCustomerList_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPrint.Location = new System.Drawing.Point(0, 499);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(704, 42);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Print Customer Details";
            this.btnPrint.UseCompatibleTextRendering = true;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(584, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 35);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // gbSortBy
            // 
            this.gbSortBy.BackColor = System.Drawing.Color.Transparent;
            this.gbSortBy.Controls.Add(this.label1);
            this.gbSortBy.Controls.Add(this.cbStatus);
            this.gbSortBy.Controls.Add(this.rbRegDate);
            this.gbSortBy.Controls.Add(this.rbFirstname);
            this.gbSortBy.Controls.Add(this.rbLastname);
            this.gbSortBy.Controls.Add(this.rbTown);
            this.gbSortBy.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSortBy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSortBy.Location = new System.Drawing.Point(12, 71);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Size = new System.Drawing.Size(680, 48);
            this.gbSortBy.TabIndex = 23;
            this.gbSortBy.TabStop = false;
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
            this.cbStatus.Location = new System.Drawing.Point(556, 17);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(108, 24);
            this.cbStatus.Sorted = true;
            this.cbStatus.TabIndex = 18;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
            // 
            // rbRegDate
            // 
            this.rbRegDate.AutoSize = true;
            this.rbRegDate.BackColor = System.Drawing.Color.Transparent;
            this.rbRegDate.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbRegDate.Location = new System.Drawing.Point(442, 20);
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
            this.rbFirstname.Location = new System.Drawing.Point(223, 20);
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
            this.rbLastname.Location = new System.Drawing.Point(115, 20);
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
            this.rbTown.Location = new System.Drawing.Point(353, 20);
            this.rbTown.Name = "rbTown";
            this.rbTown.Size = new System.Drawing.Size(67, 20);
            this.rbTown.TabIndex = 16;
            this.rbTown.TabStop = true;
            this.rbTown.Text = "TOWN";
            this.rbTown.UseVisualStyleBackColor = false;
            this.rbTown.CheckedChanged += new System.EventHandler(this.rbTown_CheckedChanged);
            // 
            // dgvListCust
            // 
            this.dgvListCust.AllowUserToAddRows = false;
            this.dgvListCust.AllowUserToDeleteRows = false;
            this.dgvListCust.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListCust.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCust.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListCust.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvListCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListCust.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvListCust.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCust.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCust.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListCust.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListCust.Location = new System.Drawing.Point(12, 130);
            this.dgvListCust.Name = "dgvListCust";
            this.dgvListCust.ReadOnly = true;
            this.dgvListCust.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListCust.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvListCust.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListCust.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListCust.RowTemplate.DividerHeight = 3;
            this.dgvListCust.Size = new System.Drawing.Size(680, 357);
            this.dgvListCust.TabIndex = 24;
            // 
            // frmListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.dgvListCust);
            this.Controls.Add(this.gbSortBy);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmListCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - List Customer";
            this.Load += new System.EventHandler(this.frmListCustomer_Load);
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printCustomerList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.RadioButton rbRegDate;
        private System.Windows.Forms.RadioButton rbFirstname;
        private System.Windows.Forms.RadioButton rbLastname;
        private System.Windows.Forms.RadioButton rbTown;
        private System.Windows.Forms.DataGridView dgvListCust;
    }
}
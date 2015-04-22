namespace CompSys
{
    partial class frmNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCustomer));
            this.gbNewCustomer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCustType = new System.Windows.Forms.ComboBox();
            this.lblDobNewCustomer = new System.Windows.Forms.Label();
            this.lblSnNewCustomer = new System.Windows.Forms.Label();
            this.lblFnNewCustomer = new System.Windows.Forms.Label();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbForename = new System.Windows.Forms.TextBox();
            this.gbContactNewCustomer = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmailNewCustomer = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.lblPhoneNewCustomer = new System.Windows.Forms.Label();
            this.gbAddressNewCustomer = new System.Windows.Forms.GroupBox();
            this.lblCountyNewCustomer = new System.Windows.Forms.Label();
            this.lblTownNewCustomer = new System.Windows.Forms.Label();
            this.lblAd2NewCustomer = new System.Windows.Forms.Label();
            this.lblAd1NewCustomer = new System.Windows.Forms.Label();
            this.cbCounties = new System.Windows.Forms.ComboBox();
            this.tbTown = new System.Windows.Forms.TextBox();
            this.tbAd2 = new System.Windows.Forms.TextBox();
            this.tbAd1 = new System.Windows.Forms.TextBox();
            this.btnSaveNewCust = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbNewCustomer.SuspendLayout();
            this.gbContactNewCustomer.SuspendLayout();
            this.gbAddressNewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewCustomer
            // 
            this.gbNewCustomer.BackColor = System.Drawing.Color.Maroon;
            this.gbNewCustomer.Controls.Add(this.label1);
            this.gbNewCustomer.Controls.Add(this.cbCustType);
            this.gbNewCustomer.Controls.Add(this.lblDobNewCustomer);
            this.gbNewCustomer.Controls.Add(this.lblSnNewCustomer);
            this.gbNewCustomer.Controls.Add(this.lblFnNewCustomer);
            this.gbNewCustomer.Controls.Add(this.dateDOB);
            this.gbNewCustomer.Controls.Add(this.tbSurname);
            this.gbNewCustomer.Controls.Add(this.tbForename);
            this.gbNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbNewCustomer.Location = new System.Drawing.Point(12, 88);
            this.gbNewCustomer.Name = "gbNewCustomer";
            this.gbNewCustomer.Size = new System.Drawing.Size(680, 143);
            this.gbNewCustomer.TabIndex = 2;
            this.gbNewCustomer.TabStop = false;
            this.gbNewCustomer.Text = "Enter your details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer Type:";
            // 
            // cbCustType
            // 
            this.cbCustType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustType.Items.AddRange(new object[] {
            "Normal",
            "Student",
            "OAP"});
            this.cbCustType.Location = new System.Drawing.Point(415, 101);
            this.cbCustType.Name = "cbCustType";
            this.cbCustType.Size = new System.Drawing.Size(252, 28);
            this.cbCustType.TabIndex = 7;
            // 
            // lblDobNewCustomer
            // 
            this.lblDobNewCustomer.AutoSize = true;
            this.lblDobNewCustomer.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobNewCustomer.Location = new System.Drawing.Point(7, 80);
            this.lblDobNewCustomer.Name = "lblDobNewCustomer";
            this.lblDobNewCustomer.Size = new System.Drawing.Size(101, 15);
            this.lblDobNewCustomer.TabIndex = 5;
            this.lblDobNewCustomer.Text = "Date of Birth:";
            // 
            // lblSnNewCustomer
            // 
            this.lblSnNewCustomer.AutoSize = true;
            this.lblSnNewCustomer.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnNewCustomer.Location = new System.Drawing.Point(412, 26);
            this.lblSnNewCustomer.Name = "lblSnNewCustomer";
            this.lblSnNewCustomer.Size = new System.Drawing.Size(78, 15);
            this.lblSnNewCustomer.TabIndex = 4;
            this.lblSnNewCustomer.Text = "Lastname:";
            // 
            // lblFnNewCustomer
            // 
            this.lblFnNewCustomer.AutoSize = true;
            this.lblFnNewCustomer.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFnNewCustomer.Location = new System.Drawing.Point(10, 26);
            this.lblFnNewCustomer.Name = "lblFnNewCustomer";
            this.lblFnNewCustomer.Size = new System.Drawing.Size(81, 15);
            this.lblFnNewCustomer.TabIndex = 3;
            this.lblFnNewCustomer.Text = "Firstname:";
            // 
            // dateDOB
            // 
            this.dateDOB.Location = new System.Drawing.Point(11, 103);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(280, 26);
            this.dateDOB.TabIndex = 2;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(415, 45);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(252, 26);
            this.tbSurname.TabIndex = 1;
            // 
            // tbForename
            // 
            this.tbForename.Location = new System.Drawing.Point(11, 45);
            this.tbForename.Name = "tbForename";
            this.tbForename.Size = new System.Drawing.Size(280, 26);
            this.tbForename.TabIndex = 0;
            // 
            // gbContactNewCustomer
            // 
            this.gbContactNewCustomer.BackColor = System.Drawing.Color.Maroon;
            this.gbContactNewCustomer.Controls.Add(this.tbEmail);
            this.gbContactNewCustomer.Controls.Add(this.lblEmailNewCustomer);
            this.gbContactNewCustomer.Controls.Add(this.tbMobile);
            this.gbContactNewCustomer.Controls.Add(this.lblPhoneNewCustomer);
            this.gbContactNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContactNewCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbContactNewCustomer.Location = new System.Drawing.Point(12, 244);
            this.gbContactNewCustomer.Name = "gbContactNewCustomer";
            this.gbContactNewCustomer.Size = new System.Drawing.Size(305, 180);
            this.gbContactNewCustomer.TabIndex = 4;
            this.gbContactNewCustomer.TabStop = false;
            this.gbContactNewCustomer.Text = "Enter Contact Details";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(13, 102);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(278, 26);
            this.tbEmail.TabIndex = 3;
            // 
            // lblEmailNewCustomer
            // 
            this.lblEmailNewCustomer.AutoSize = true;
            this.lblEmailNewCustomer.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailNewCustomer.Location = new System.Drawing.Point(10, 83);
            this.lblEmailNewCustomer.Name = "lblEmailNewCustomer";
            this.lblEmailNewCustomer.Size = new System.Drawing.Size(110, 15);
            this.lblEmailNewCustomer.TabIndex = 2;
            this.lblEmailNewCustomer.Text = "Email Address:";
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(13, 47);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(278, 26);
            this.tbMobile.TabIndex = 1;
            // 
            // lblPhoneNewCustomer
            // 
            this.lblPhoneNewCustomer.AutoSize = true;
            this.lblPhoneNewCustomer.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNewCustomer.Location = new System.Drawing.Point(9, 28);
            this.lblPhoneNewCustomer.Name = "lblPhoneNewCustomer";
            this.lblPhoneNewCustomer.Size = new System.Drawing.Size(164, 15);
            this.lblPhoneNewCustomer.TabIndex = 0;
            this.lblPhoneNewCustomer.Text = "Mobile/Telephone No:";
            // 
            // gbAddressNewCustomer
            // 
            this.gbAddressNewCustomer.BackColor = System.Drawing.Color.Maroon;
            this.gbAddressNewCustomer.Controls.Add(this.lblCountyNewCustomer);
            this.gbAddressNewCustomer.Controls.Add(this.lblTownNewCustomer);
            this.gbAddressNewCustomer.Controls.Add(this.lblAd2NewCustomer);
            this.gbAddressNewCustomer.Controls.Add(this.lblAd1NewCustomer);
            this.gbAddressNewCustomer.Controls.Add(this.cbCounties);
            this.gbAddressNewCustomer.Controls.Add(this.tbTown);
            this.gbAddressNewCustomer.Controls.Add(this.tbAd2);
            this.gbAddressNewCustomer.Controls.Add(this.tbAd1);
            this.gbAddressNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddressNewCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbAddressNewCustomer.Location = new System.Drawing.Point(323, 244);
            this.gbAddressNewCustomer.Name = "gbAddressNewCustomer";
            this.gbAddressNewCustomer.Size = new System.Drawing.Size(369, 180);
            this.gbAddressNewCustomer.TabIndex = 5;
            this.gbAddressNewCustomer.TabStop = false;
            this.gbAddressNewCustomer.Text = "Enter your address";
            // 
            // lblCountyNewCustomer
            // 
            this.lblCountyNewCustomer.AutoSize = true;
            this.lblCountyNewCustomer.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountyNewCustomer.Location = new System.Drawing.Point(7, 145);
            this.lblCountyNewCustomer.Name = "lblCountyNewCustomer";
            this.lblCountyNewCustomer.Size = new System.Drawing.Size(61, 15);
            this.lblCountyNewCustomer.TabIndex = 7;
            this.lblCountyNewCustomer.Text = "County:";
            // 
            // lblTownNewCustomer
            // 
            this.lblTownNewCustomer.AutoSize = true;
            this.lblTownNewCustomer.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownNewCustomer.Location = new System.Drawing.Point(7, 106);
            this.lblTownNewCustomer.Name = "lblTownNewCustomer";
            this.lblTownNewCustomer.Size = new System.Drawing.Size(50, 15);
            this.lblTownNewCustomer.TabIndex = 6;
            this.lblTownNewCustomer.Text = "Town:";
            // 
            // lblAd2NewCustomer
            // 
            this.lblAd2NewCustomer.AutoSize = true;
            this.lblAd2NewCustomer.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd2NewCustomer.Location = new System.Drawing.Point(7, 69);
            this.lblAd2NewCustomer.Name = "lblAd2NewCustomer";
            this.lblAd2NewCustomer.Size = new System.Drawing.Size(80, 15);
            this.lblAd2NewCustomer.TabIndex = 5;
            this.lblAd2NewCustomer.Text = "Address 2:";
            // 
            // lblAd1NewCustomer
            // 
            this.lblAd1NewCustomer.AccessibleName = "dsd";
            this.lblAd1NewCustomer.AutoSize = true;
            this.lblAd1NewCustomer.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd1NewCustomer.Location = new System.Drawing.Point(7, 32);
            this.lblAd1NewCustomer.Name = "lblAd1NewCustomer";
            this.lblAd1NewCustomer.Size = new System.Drawing.Size(80, 15);
            this.lblAd1NewCustomer.TabIndex = 4;
            this.lblAd1NewCustomer.Text = "Address 1:";
            // 
            // cbCounties
            // 
            this.cbCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCounties.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbCounties.Location = new System.Drawing.Point(104, 138);
            this.cbCounties.Name = "cbCounties";
            this.cbCounties.Size = new System.Drawing.Size(252, 28);
            this.cbCounties.TabIndex = 3;
            // 
            // tbTown
            // 
            this.tbTown.Location = new System.Drawing.Point(104, 100);
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(252, 26);
            this.tbTown.TabIndex = 2;
            // 
            // tbAd2
            // 
            this.tbAd2.Location = new System.Drawing.Point(104, 63);
            this.tbAd2.Name = "tbAd2";
            this.tbAd2.Size = new System.Drawing.Size(252, 26);
            this.tbAd2.TabIndex = 1;
            // 
            // tbAd1
            // 
            this.tbAd1.Location = new System.Drawing.Point(104, 26);
            this.tbAd1.Name = "tbAd1";
            this.tbAd1.Size = new System.Drawing.Size(252, 26);
            this.tbAd1.TabIndex = 0;
            // 
            // btnSaveNewCust
            // 
            this.btnSaveNewCust.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveNewCust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveNewCust.BackgroundImage")));
            this.btnSaveNewCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveNewCust.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveNewCust.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewCust.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSaveNewCust.Location = new System.Drawing.Point(0, 499);
            this.btnSaveNewCust.Name = "btnSaveNewCust";
            this.btnSaveNewCust.Size = new System.Drawing.Size(704, 42);
            this.btnSaveNewCust.TabIndex = 14;
            this.btnSaveNewCust.Text = "Add New Customer";
            this.btnSaveNewCust.UseCompatibleTextRendering = true;
            this.btnSaveNewCust.UseVisualStyleBackColor = false;
            this.btnSaveNewCust.Click += new System.EventHandler(this.btnSaveNewCust_Click);
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
            this.btnBack.Location = new System.Drawing.Point(477, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 35);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Brown;
            this.btnClear.Location = new System.Drawing.Point(584, 30);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 35);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveNewCust);
            this.Controls.Add(this.gbAddressNewCustomer);
            this.Controls.Add(this.gbContactNewCustomer);
            this.Controls.Add(this.gbNewCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - New Customer";
            this.Load += new System.EventHandler(this.frmNewCustomer_Load);
            this.gbNewCustomer.ResumeLayout(false);
            this.gbNewCustomer.PerformLayout();
            this.gbContactNewCustomer.ResumeLayout(false);
            this.gbContactNewCustomer.PerformLayout();
            this.gbAddressNewCustomer.ResumeLayout(false);
            this.gbAddressNewCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewCustomer;
        private System.Windows.Forms.Label lblDobNewCustomer;
        private System.Windows.Forms.Label lblSnNewCustomer;
        private System.Windows.Forms.Label lblFnNewCustomer;
        private System.Windows.Forms.DateTimePicker dateDOB;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbForename;
        private System.Windows.Forms.GroupBox gbContactNewCustomer;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmailNewCustomer;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label lblPhoneNewCustomer;
        private System.Windows.Forms.GroupBox gbAddressNewCustomer;
        private System.Windows.Forms.Label lblCountyNewCustomer;
        private System.Windows.Forms.Label lblTownNewCustomer;
        private System.Windows.Forms.Label lblAd2NewCustomer;
        private System.Windows.Forms.Label lblAd1NewCustomer;
        private System.Windows.Forms.ComboBox cbCounties;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.TextBox tbAd2;
        private System.Windows.Forms.TextBox tbAd1;
        private System.Windows.Forms.Button btnSaveNewCust;
        private System.Windows.Forms.ComboBox cbCustType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
    }
}
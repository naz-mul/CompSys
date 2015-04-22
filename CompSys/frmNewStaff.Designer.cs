namespace CompSys
{
    partial class frmNewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewStaff));
            this.gbNewStaff = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStaffType = new System.Windows.Forms.ComboBox();
            this.lblDobNewStaff = new System.Windows.Forms.Label();
            this.lblSnNewStaff = new System.Windows.Forms.Label();
            this.lblFnNewStaff = new System.Windows.Forms.Label();
            this.dateDOBNewStaff = new System.Windows.Forms.DateTimePicker();
            this.tbSurnameNewStaff = new System.Windows.Forms.TextBox();
            this.tbForenameNewStaff = new System.Windows.Forms.TextBox();
            this.gbAddressNewStaff = new System.Windows.Forms.GroupBox();
            this.lblCountyNewStaff = new System.Windows.Forms.Label();
            this.lblTownNewStaff = new System.Windows.Forms.Label();
            this.lblAd2NewStaff = new System.Windows.Forms.Label();
            this.lblAd1NewStaff = new System.Windows.Forms.Label();
            this.cbCountiesNewStaff = new System.Windows.Forms.ComboBox();
            this.tbTownNewStaff = new System.Windows.Forms.TextBox();
            this.tbAd2NewStaff = new System.Windows.Forms.TextBox();
            this.tbAd1NewStaff = new System.Windows.Forms.TextBox();
            this.gbContactNewStaff = new System.Windows.Forms.GroupBox();
            this.tbEmailNewStaff = new System.Windows.Forms.TextBox();
            this.lblEmailNewStaff = new System.Windows.Forms.Label();
            this.tbMobileNewStaff = new System.Windows.Forms.TextBox();
            this.lblPhoneNewStaff = new System.Windows.Forms.Label();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnBackNewStaff = new System.Windows.Forms.Button();
            this.btnClearNewStaff = new System.Windows.Forms.Button();
            this.btnSaveNewStaff = new System.Windows.Forms.Button();
            this.gbNewStaff.SuspendLayout();
            this.gbAddressNewStaff.SuspendLayout();
            this.gbContactNewStaff.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewStaff
            // 
            this.gbNewStaff.BackColor = System.Drawing.Color.Maroon;
            this.gbNewStaff.Controls.Add(this.label1);
            this.gbNewStaff.Controls.Add(this.cbStaffType);
            this.gbNewStaff.Controls.Add(this.lblDobNewStaff);
            this.gbNewStaff.Controls.Add(this.lblSnNewStaff);
            this.gbNewStaff.Controls.Add(this.lblFnNewStaff);
            this.gbNewStaff.Controls.Add(this.dateDOBNewStaff);
            this.gbNewStaff.Controls.Add(this.tbSurnameNewStaff);
            this.gbNewStaff.Controls.Add(this.tbForenameNewStaff);
            this.gbNewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbNewStaff.Location = new System.Drawing.Point(12, 84);
            this.gbNewStaff.Name = "gbNewStaff";
            this.gbNewStaff.Size = new System.Drawing.Size(680, 143);
            this.gbNewStaff.TabIndex = 1;
            this.gbNewStaff.TabStop = false;
            this.gbNewStaff.Text = "Enter your details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Staff Type:";
            // 
            // cbStaffType
            // 
            this.cbStaffType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaffType.Items.AddRange(new object[] {
            "Manager",
            "Staff",
            "Intern"});
            this.cbStaffType.Location = new System.Drawing.Point(415, 105);
            this.cbStaffType.Name = "cbStaffType";
            this.cbStaffType.Size = new System.Drawing.Size(252, 28);
            this.cbStaffType.TabIndex = 6;
            // 
            // lblDobNewStaff
            // 
            this.lblDobNewStaff.AutoSize = true;
            this.lblDobNewStaff.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobNewStaff.Location = new System.Drawing.Point(7, 80);
            this.lblDobNewStaff.Name = "lblDobNewStaff";
            this.lblDobNewStaff.Size = new System.Drawing.Size(101, 15);
            this.lblDobNewStaff.TabIndex = 5;
            this.lblDobNewStaff.Text = "Date of Birth:";
            // 
            // lblSnNewStaff
            // 
            this.lblSnNewStaff.AutoSize = true;
            this.lblSnNewStaff.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnNewStaff.Location = new System.Drawing.Point(412, 26);
            this.lblSnNewStaff.Name = "lblSnNewStaff";
            this.lblSnNewStaff.Size = new System.Drawing.Size(78, 15);
            this.lblSnNewStaff.TabIndex = 4;
            this.lblSnNewStaff.Text = "Lastname:";
            // 
            // lblFnNewStaff
            // 
            this.lblFnNewStaff.AutoSize = true;
            this.lblFnNewStaff.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFnNewStaff.Location = new System.Drawing.Point(10, 26);
            this.lblFnNewStaff.Name = "lblFnNewStaff";
            this.lblFnNewStaff.Size = new System.Drawing.Size(81, 15);
            this.lblFnNewStaff.TabIndex = 3;
            this.lblFnNewStaff.Text = "Firstname:";
            // 
            // dateDOBNewStaff
            // 
            this.dateDOBNewStaff.CustomFormat = "";
            this.dateDOBNewStaff.Location = new System.Drawing.Point(11, 103);
            this.dateDOBNewStaff.Name = "dateDOBNewStaff";
            this.dateDOBNewStaff.Size = new System.Drawing.Size(280, 26);
            this.dateDOBNewStaff.TabIndex = 2;
            this.dateDOBNewStaff.Value = new System.DateTime(2015, 2, 8, 21, 36, 34, 0);
            // 
            // tbSurnameNewStaff
            // 
            this.tbSurnameNewStaff.Location = new System.Drawing.Point(415, 45);
            this.tbSurnameNewStaff.Name = "tbSurnameNewStaff";
            this.tbSurnameNewStaff.Size = new System.Drawing.Size(252, 26);
            this.tbSurnameNewStaff.TabIndex = 1;
            // 
            // tbForenameNewStaff
            // 
            this.tbForenameNewStaff.Location = new System.Drawing.Point(11, 45);
            this.tbForenameNewStaff.Name = "tbForenameNewStaff";
            this.tbForenameNewStaff.Size = new System.Drawing.Size(280, 26);
            this.tbForenameNewStaff.TabIndex = 0;
            // 
            // gbAddressNewStaff
            // 
            this.gbAddressNewStaff.BackColor = System.Drawing.Color.Maroon;
            this.gbAddressNewStaff.Controls.Add(this.lblCountyNewStaff);
            this.gbAddressNewStaff.Controls.Add(this.lblTownNewStaff);
            this.gbAddressNewStaff.Controls.Add(this.lblAd2NewStaff);
            this.gbAddressNewStaff.Controls.Add(this.lblAd1NewStaff);
            this.gbAddressNewStaff.Controls.Add(this.cbCountiesNewStaff);
            this.gbAddressNewStaff.Controls.Add(this.tbTownNewStaff);
            this.gbAddressNewStaff.Controls.Add(this.tbAd2NewStaff);
            this.gbAddressNewStaff.Controls.Add(this.tbAd1NewStaff);
            this.gbAddressNewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddressNewStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbAddressNewStaff.Location = new System.Drawing.Point(323, 236);
            this.gbAddressNewStaff.Name = "gbAddressNewStaff";
            this.gbAddressNewStaff.Size = new System.Drawing.Size(369, 180);
            this.gbAddressNewStaff.TabIndex = 3;
            this.gbAddressNewStaff.TabStop = false;
            this.gbAddressNewStaff.Text = "Enter your address";
            // 
            // lblCountyNewStaff
            // 
            this.lblCountyNewStaff.AutoSize = true;
            this.lblCountyNewStaff.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountyNewStaff.Location = new System.Drawing.Point(7, 145);
            this.lblCountyNewStaff.Name = "lblCountyNewStaff";
            this.lblCountyNewStaff.Size = new System.Drawing.Size(61, 15);
            this.lblCountyNewStaff.TabIndex = 7;
            this.lblCountyNewStaff.Text = "County:";
            // 
            // lblTownNewStaff
            // 
            this.lblTownNewStaff.AutoSize = true;
            this.lblTownNewStaff.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownNewStaff.Location = new System.Drawing.Point(7, 106);
            this.lblTownNewStaff.Name = "lblTownNewStaff";
            this.lblTownNewStaff.Size = new System.Drawing.Size(50, 15);
            this.lblTownNewStaff.TabIndex = 6;
            this.lblTownNewStaff.Text = "Town:";
            // 
            // lblAd2NewStaff
            // 
            this.lblAd2NewStaff.AutoSize = true;
            this.lblAd2NewStaff.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd2NewStaff.Location = new System.Drawing.Point(7, 69);
            this.lblAd2NewStaff.Name = "lblAd2NewStaff";
            this.lblAd2NewStaff.Size = new System.Drawing.Size(80, 15);
            this.lblAd2NewStaff.TabIndex = 5;
            this.lblAd2NewStaff.Text = "Address 2:";
            // 
            // lblAd1NewStaff
            // 
            this.lblAd1NewStaff.AccessibleName = "dsd";
            this.lblAd1NewStaff.AutoSize = true;
            this.lblAd1NewStaff.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd1NewStaff.Location = new System.Drawing.Point(7, 32);
            this.lblAd1NewStaff.Name = "lblAd1NewStaff";
            this.lblAd1NewStaff.Size = new System.Drawing.Size(80, 15);
            this.lblAd1NewStaff.TabIndex = 4;
            this.lblAd1NewStaff.Text = "Address 1:";
            // 
            // cbCountiesNewStaff
            // 
            this.cbCountiesNewStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountiesNewStaff.Items.AddRange(new object[] {
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
            this.cbCountiesNewStaff.Location = new System.Drawing.Point(104, 137);
            this.cbCountiesNewStaff.Name = "cbCountiesNewStaff";
            this.cbCountiesNewStaff.Size = new System.Drawing.Size(252, 28);
            this.cbCountiesNewStaff.TabIndex = 3;
            // 
            // tbTownNewStaff
            // 
            this.tbTownNewStaff.Location = new System.Drawing.Point(104, 100);
            this.tbTownNewStaff.Name = "tbTownNewStaff";
            this.tbTownNewStaff.Size = new System.Drawing.Size(252, 26);
            this.tbTownNewStaff.TabIndex = 2;
            // 
            // tbAd2NewStaff
            // 
            this.tbAd2NewStaff.Location = new System.Drawing.Point(104, 63);
            this.tbAd2NewStaff.Name = "tbAd2NewStaff";
            this.tbAd2NewStaff.Size = new System.Drawing.Size(252, 26);
            this.tbAd2NewStaff.TabIndex = 1;
            // 
            // tbAd1NewStaff
            // 
            this.tbAd1NewStaff.Location = new System.Drawing.Point(104, 26);
            this.tbAd1NewStaff.Name = "tbAd1NewStaff";
            this.tbAd1NewStaff.Size = new System.Drawing.Size(252, 26);
            this.tbAd1NewStaff.TabIndex = 0;
            // 
            // gbContactNewStaff
            // 
            this.gbContactNewStaff.BackColor = System.Drawing.Color.Maroon;
            this.gbContactNewStaff.Controls.Add(this.tbEmailNewStaff);
            this.gbContactNewStaff.Controls.Add(this.lblEmailNewStaff);
            this.gbContactNewStaff.Controls.Add(this.tbMobileNewStaff);
            this.gbContactNewStaff.Controls.Add(this.lblPhoneNewStaff);
            this.gbContactNewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContactNewStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbContactNewStaff.Location = new System.Drawing.Point(12, 236);
            this.gbContactNewStaff.Name = "gbContactNewStaff";
            this.gbContactNewStaff.Size = new System.Drawing.Size(305, 180);
            this.gbContactNewStaff.TabIndex = 2;
            this.gbContactNewStaff.TabStop = false;
            this.gbContactNewStaff.Text = "Enter Contact Details";
            // 
            // tbEmailNewStaff
            // 
            this.tbEmailNewStaff.Location = new System.Drawing.Point(13, 102);
            this.tbEmailNewStaff.Name = "tbEmailNewStaff";
            this.tbEmailNewStaff.Size = new System.Drawing.Size(278, 26);
            this.tbEmailNewStaff.TabIndex = 3;
            // 
            // lblEmailNewStaff
            // 
            this.lblEmailNewStaff.AutoSize = true;
            this.lblEmailNewStaff.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailNewStaff.Location = new System.Drawing.Point(10, 83);
            this.lblEmailNewStaff.Name = "lblEmailNewStaff";
            this.lblEmailNewStaff.Size = new System.Drawing.Size(110, 15);
            this.lblEmailNewStaff.TabIndex = 2;
            this.lblEmailNewStaff.Text = "Email Address:";
            // 
            // tbMobileNewStaff
            // 
            this.tbMobileNewStaff.Location = new System.Drawing.Point(13, 47);
            this.tbMobileNewStaff.Name = "tbMobileNewStaff";
            this.tbMobileNewStaff.Size = new System.Drawing.Size(278, 26);
            this.tbMobileNewStaff.TabIndex = 1;
            // 
            // lblPhoneNewStaff
            // 
            this.lblPhoneNewStaff.AutoSize = true;
            this.lblPhoneNewStaff.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNewStaff.Location = new System.Drawing.Point(9, 28);
            this.lblPhoneNewStaff.Name = "lblPhoneNewStaff";
            this.lblPhoneNewStaff.Size = new System.Drawing.Size(164, 15);
            this.lblPhoneNewStaff.TabIndex = 0;
            this.lblPhoneNewStaff.Text = "Mobile/Telephone No:";
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.Color.Maroon;
            this.gbUser.Controls.Add(this.label4);
            this.gbUser.Controls.Add(this.label5);
            this.gbUser.Controls.Add(this.tbPassword);
            this.gbUser.Controls.Add(this.tbUsername);
            this.gbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbUser.Location = new System.Drawing.Point(12, 422);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(680, 55);
            this.gbUser.TabIndex = 8;
            this.gbUser.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "username:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(415, 19);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(252, 26);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(97, 19);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(194, 26);
            this.tbUsername.TabIndex = 0;
            // 
            // btnBackNewStaff
            // 
            this.btnBackNewStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnBackNewStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackNewStaff.BackgroundImage")));
            this.btnBackNewStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackNewStaff.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackNewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackNewStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackNewStaff.Location = new System.Drawing.Point(477, 30);
            this.btnBackNewStaff.Name = "btnBackNewStaff";
            this.btnBackNewStaff.Size = new System.Drawing.Size(101, 35);
            this.btnBackNewStaff.TabIndex = 9;
            this.btnBackNewStaff.Text = "<< Back";
            this.btnBackNewStaff.UseCompatibleTextRendering = true;
            this.btnBackNewStaff.UseVisualStyleBackColor = true;
            // 
            // btnClearNewStaff
            // 
            this.btnClearNewStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnClearNewStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearNewStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClearNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClearNewStaff.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearNewStaff.ForeColor = System.Drawing.Color.Brown;
            this.btnClearNewStaff.Location = new System.Drawing.Point(584, 30);
            this.btnClearNewStaff.Name = "btnClearNewStaff";
            this.btnClearNewStaff.Size = new System.Drawing.Size(108, 35);
            this.btnClearNewStaff.TabIndex = 10;
            this.btnClearNewStaff.Text = "Clear";
            this.btnClearNewStaff.UseVisualStyleBackColor = false;
            this.btnClearNewStaff.Click += new System.EventHandler(this.btnClearNewStaff_Click);
            // 
            // btnSaveNewStaff
            // 
            this.btnSaveNewStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveNewStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveNewStaff.BackgroundImage")));
            this.btnSaveNewStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveNewStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveNewStaff.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewStaff.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSaveNewStaff.Location = new System.Drawing.Point(0, 499);
            this.btnSaveNewStaff.Name = "btnSaveNewStaff";
            this.btnSaveNewStaff.Size = new System.Drawing.Size(704, 42);
            this.btnSaveNewStaff.TabIndex = 11;
            this.btnSaveNewStaff.Text = "Add New Staff";
            this.btnSaveNewStaff.UseCompatibleTextRendering = true;
            this.btnSaveNewStaff.UseVisualStyleBackColor = false;
            this.btnSaveNewStaff.Click += new System.EventHandler(this.btnSaveNewStaff_Click);
            // 
            // frmNewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgDefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.btnSaveNewStaff);
            this.Controls.Add(this.btnClearNewStaff);
            this.Controls.Add(this.btnBackNewStaff);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.gbContactNewStaff);
            this.Controls.Add(this.gbAddressNewStaff);
            this.Controls.Add(this.gbNewStaff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmNewStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - Add New Staff";
            this.Load += new System.EventHandler(this.frmNewStaff_Load);
            this.gbNewStaff.ResumeLayout(false);
            this.gbNewStaff.PerformLayout();
            this.gbAddressNewStaff.ResumeLayout(false);
            this.gbAddressNewStaff.PerformLayout();
            this.gbContactNewStaff.ResumeLayout(false);
            this.gbContactNewStaff.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewStaff;
        private System.Windows.Forms.TextBox tbSurnameNewStaff;
        private System.Windows.Forms.TextBox tbForenameNewStaff;
        private System.Windows.Forms.DateTimePicker dateDOBNewStaff;
        private System.Windows.Forms.Label lblDobNewStaff;
        private System.Windows.Forms.Label lblSnNewStaff;
        private System.Windows.Forms.Label lblFnNewStaff;
        private System.Windows.Forms.GroupBox gbAddressNewStaff;
        private System.Windows.Forms.ComboBox cbCountiesNewStaff;
        private System.Windows.Forms.TextBox tbTownNewStaff;
        private System.Windows.Forms.TextBox tbAd2NewStaff;
        private System.Windows.Forms.TextBox tbAd1NewStaff;
        private System.Windows.Forms.Label lblCountyNewStaff;
        private System.Windows.Forms.Label lblTownNewStaff;
        private System.Windows.Forms.Label lblAd2NewStaff;
        private System.Windows.Forms.Label lblAd1NewStaff;
        private System.Windows.Forms.GroupBox gbContactNewStaff;
        private System.Windows.Forms.TextBox tbEmailNewStaff;
        private System.Windows.Forms.Label lblEmailNewStaff;
        private System.Windows.Forms.TextBox tbMobileNewStaff;
        private System.Windows.Forms.Label lblPhoneNewStaff;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnBackNewStaff;
        private System.Windows.Forms.Button btnClearNewStaff;
        private System.Windows.Forms.Button btnSaveNewStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStaffType;
       

    }
}
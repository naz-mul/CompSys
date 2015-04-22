namespace CompSys
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.oracleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oracleDatabaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTTraleeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(225, 239);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(252, 20);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(225, 295);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(252, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblUsername.Location = new System.Drawing.Point(222, 221);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 15);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPassword.Location = new System.Drawing.Point(222, 277);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 15);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please login to continue....";
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleDescription = "Login";
            this.btnLogin.AccessibleName = "System Login";
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(225, 332);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(252, 31);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oracleToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(704, 27);
            this.msMain.TabIndex = 17;
            this.msMain.Text = "msMain";
            // 
            // oracleToolStripMenuItem
            // 
            this.oracleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oracleDatabaseConnectionToolStripMenuItem,
            this.chooseLocationToolStripMenuItem});
            this.oracleToolStripMenuItem.Name = "oracleToolStripMenuItem";
            this.oracleToolStripMenuItem.Size = new System.Drawing.Size(144, 23);
            this.oracleToolStripMenuItem.Text = "Database Settings";
            // 
            // oracleDatabaseConnectionToolStripMenuItem
            // 
            this.oracleDatabaseConnectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.collegeToolStripMenuItem});
            this.oracleDatabaseConnectionToolStripMenuItem.Name = "oracleDatabaseConnectionToolStripMenuItem";
            this.oracleDatabaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.oracleDatabaseConnectionToolStripMenuItem.Text = "Add Connection Details";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.homeToolStripMenuItem.Text = "Home Server";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // collegeToolStripMenuItem
            // 
            this.collegeToolStripMenuItem.Name = "collegeToolStripMenuItem";
            this.collegeToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.collegeToolStripMenuItem.Text = "IT Tralee Server";
            this.collegeToolStripMenuItem.Click += new System.EventHandler(this.collegeToolStripMenuItem_Click);
            // 
            // chooseLocationToolStripMenuItem
            // 
            this.chooseLocationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeServerToolStripMenuItem,
            this.iTTraleeServerToolStripMenuItem});
            this.chooseLocationToolStripMenuItem.Name = "chooseLocationToolStripMenuItem";
            this.chooseLocationToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.chooseLocationToolStripMenuItem.Text = "Choose Location";
            // 
            // homeServerToolStripMenuItem
            // 
            this.homeServerToolStripMenuItem.Name = "homeServerToolStripMenuItem";
            this.homeServerToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.homeServerToolStripMenuItem.Text = "Home Server";
            this.homeServerToolStripMenuItem.Click += new System.EventHandler(this.homeServerToolStripMenuItem_Click);
            // 
            // iTTraleeServerToolStripMenuItem
            // 
            this.iTTraleeServerToolStripMenuItem.Name = "iTTraleeServerToolStripMenuItem";
            this.iTTraleeServerToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.iTTraleeServerToolStripMenuItem.Text = "IT Tralee Server";
            this.iTTraleeServerToolStripMenuItem.Click += new System.EventHandler(this.iTTraleeServerToolStripMenuItem_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::CompSys.Properties.Resources.bgLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompuRite - Login";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem oracleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oracleDatabaseConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTTraleeServerToolStripMenuItem;
    }
}
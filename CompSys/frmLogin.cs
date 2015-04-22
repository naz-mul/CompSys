using System;
using System.Collections;
using System.Net;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmLogin : Form
    {

        public static string username;
        public static string oracle;
        private Boolean IsLocationSelected = false;

        public frmLogin()
        {
            InitializeComponent();
            
            // If HostName = Alienware - Set default database to Home Server
            // I am using Alienware at home
            // I am assuming the only other place I'd run this program outside home would be college server
            if (Dns.GetHostName().Equals("Alienware"))
                homeServerToolStripMenuItem.Checked = true;    
            else
                iTTraleeServerToolStripMenuItem.Checked = true; // Set default database server to college

            IsLocationSelected = true;
            oracle = LocationChoosen();

        }

        #region LOGIN INTO THE SYSTEM
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Making sure the Database Location is Selected
            if (IsLocationSelected)
            {
                // If the user field and/or password field is empty
                if (tbUsername.Text.Equals("") || tbPassword.Text.Equals(""))
                {
                    MessageBox.Show(this, "Please enter both the username and the password in the specific fields provided.",
                                          "Username and Password are required!", MessageBoxButtons.OK,
                                          MessageBoxIcon.Exclamation,
                                          MessageBoxDefaultButton.Button1);
                    tbUsername.Focus();
                }

                // If both of the text boxes are filled
                else
                {
                    // Checks if the username and password is valid
                    if (Utils.LoginFromDatabase(tbUsername, tbPassword))
                    {
                        this.DialogResult = DialogResult.OK;
                        username = tbUsername.Text;
                    }

                    // otherwise display error message
                    else
                    {
                        MessageBox.Show(this, "The username/password entered is not found in the system. Please enter valid username and password.",
                                              "Authentication failed!", MessageBoxButtons.OK,
                                              MessageBoxIcon.Exclamation,
                                              MessageBoxDefaultButton.Button1);
                        tbUsername.Text = "";
                        tbPassword.Text = "";
                        tbUsername.Focus();

                    }
                }
            }

            // If the location is not selected - display error message
            else
            {
                MessageBox.Show(this, "Please choose database location before you can login to the system.",
                                              "Database Location", MessageBoxButtons.OK,
                                              MessageBoxIcon.Exclamation,
                                              MessageBoxDefaultButton.Button1);
            }

        }
        #endregion

        #region TOOL STRIP MENU ITEM LISTENER
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.SetOracleConnectionDetails("home.txt");
            oracle = LocationChoosen();
        }

        private void collegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.SetOracleConnectionDetails("college.txt");
            oracle = LocationChoosen();

        }
        private void homeServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeServerToolStripMenuItem.Checked = true;
            iTTraleeServerToolStripMenuItem.Checked = false;
            oracle = LocationChoosen();
            IsLocationSelected = true;
        }

        private void iTTraleeServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeServerToolStripMenuItem.Checked = false;
            iTTraleeServerToolStripMenuItem.Checked = true;
            oracle = LocationChoosen();
            IsLocationSelected = true;
        }
        #endregion

        #region UTILITY METHODS

        #region KEYBOARD BUTTON LISTENER
        /// <summary>
        /// This method focuses to next control on pressing the ENTER key
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        protected override bool ProcessKeyPreview(ref Message m)
        {
            if (m.Msg == 0x0100 && (int)m.WParam == 13)
            {
                this.ProcessTabKey(true);
            }
            return base.ProcessKeyPreview(ref m);
        }
        #endregion

        #region SUBMIT THE FORM
        /// <summary>
        /// Upon pressing enter key from the password textbox, this method submits the login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        #endregion

        #region CHECKS WHICH DATABASE SERVER IS CHOOSEN
        /// <summary>
        /// Depending on the location selected, either home or college
        /// This method reads a text file from the local source and 
        /// Outputs the Oracle Connection String
        /// </summary>
        /// <returns>oracle connection string</returns>
        private string LocationChoosen()
        {
            ArrayList strConnection = new ArrayList();
            string data = "";
            string username = "";
            string password = "";

            if (homeServerToolStripMenuItem.Checked)
                strConnection = Utils.ReadFromFile("home.txt");
            else if (iTTraleeServerToolStripMenuItem.Checked)
                strConnection = Utils.ReadFromFile("college.txt");

            data = strConnection[0] as string;
            username = strConnection[1] as string;
            password = strConnection[2] as string;

            return "Data Source=" + data + ";User Id=" + username + ";Password=" + password;
        }
        #endregion

        #endregion

    } // end of class
}

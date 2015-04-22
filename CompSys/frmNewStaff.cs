using System;
using System.Windows.Forms;


namespace CompSys
{
    public partial class frmNewStaff : Form
    {
        public frmNewStaff()
        {
            InitializeComponent();
        }

        #region LOAD DEFAULTS
        /// <summary>
        /// 1) Focus the first textbox in the form
        /// 2) Staff needs to be at least 16-60 years old
        ///    -- Set MaxDate 16 years behind
        ///    -- Set MinDate 60 years behind
        /// 3) Select a default county
        /// 4) Select a default staff type
        /// 5) Convert string to PasswordChar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNewStaff_Load(object sender, EventArgs e)
        {
            tbForenameNewStaff.Select(); //Focus to the first input field

            dateDOBNewStaff.MaxDate = DateTime.Now.AddYears(-16); //Staff needs to be at least 16 years old
            dateDOBNewStaff.MinDate = DateTime.Now.AddYears(-60); //Staff needs to be at most 60 years old
            cbCountiesNewStaff.SelectedIndex = cbCountiesNewStaff.Items.IndexOf("Kerry"); //County 'Kerry' is set default
            cbStaffType.SelectedIndex = cbStaffType.Items.IndexOf("Staff"); //StaffType 'Staff' is set to default
            tbPassword.PasswordChar = '●';
        }
        #endregion

        #region IF CLEAR BUTTON IS CLICKED
        /// <summary>
        /// Removes the contents from the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearNewStaff_Click(object sender, EventArgs e)
        { 
            Utils.ClearAllText(this);
        }
        #endregion

        #region VALIDATING EVERYTHING IN THE FORM
        /// <summary>
        /// This method validates the textbox entries and throws appropriate error messages to window
        /// </summary>
        /// <returns>Returns true if all the form entries are valid</returns>
        private Boolean IsValidTextBox()
        {
            Boolean IsValidEntry = true;
            
            // Firstname should only be letters
            // One space between every words
            // No trailing spaces
            // Between 1-30 characters
            if (Utils.IsAllLetter(tbForenameNewStaff.Text) || (tbForenameNewStaff.Text.Trim().Length < 1 || tbForenameNewStaff.Text.Trim().Length > 30) )
            {
                MessageBox.Show("Firstname is not valid, please make sure it matches these criteria: " 
                    + "\n1) Should only contain letters." + "\n2) Should NOT start/end with space(s)"
                    +"\n3) Between 1-30 characters." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbForenameNewStaff.Focus();
                IsValidEntry = false;
            }
            // Surname should only be letters
            // One space between every words
            // No trailing spaces
            // Between 1-30 characters
            else if (Utils.IsAllLetter(tbSurnameNewStaff.Text) || (tbSurnameNewStaff.Text.Trim().Length < 1 || tbSurnameNewStaff.Text.Trim().Length > 30) )
            {
                MessageBox.Show("Surname is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Length is between 1-30 characters." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSurnameNewStaff.Focus();
                IsValidEntry = false;
            }
            // Mobile number should only be digits
            // No spaces
            // Between 7-10 characters
            else if (Utils.IsAllDigits(tbMobileNewStaff.Text) && !Utils.IsWhiteSpace(tbMobileNewStaff.Text)
                || (tbMobileNewStaff.Text.Trim().Length < 7 || tbMobileNewStaff.Text.Trim().Length > 10))
            {
                MessageBox.Show("Mobile/Telephone number is not valid, please make sure it matches these criteria: " 
                    + "\n1) Should only contain digits." + "\n2) No spaces in between." + "\n3) Length is between 7-10 characters!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMobileNewStaff.Focus();
                IsValidEntry = false;
               
            }
            // Email should be a valid format
            // No special characters, no spaces
            // Alphanumeric, hyphen (-), underscore (_) and comma (.) is allowed only
            // Should not be greater than 100 characters long
            else if (!Utils.IsValidEmail(tbEmailNewStaff.Text.Trim()) || tbEmailNewStaff.Text.Trim().Length > 100)
            {
                MessageBox.Show("Please enter valid email address! e.g. Joe@Bloggs.com", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmailNewStaff.Focus();
                IsValidEntry = false;
            }
            else if (Utils.IsAlphaNumeric(tbAd1NewStaff.Text) || (tbAd1NewStaff.Text.Trim().Length < 1 || tbAd1NewStaff.Text.Trim().Length > 50) )
            {
                MessageBox.Show("Address 1 textbox is not valid, please match these criteria: " 
                    + "\n1) Letters or digits only." 
                    + "\n2) No leading or traling spaces."
                    + "\n3) Should not be greater than 50 characters long." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAd1NewStaff.Focus();
                IsValidEntry = false;
            }
            else if (Utils.IsAlphaNumeric(tbAd2NewStaff.Text) || tbAd2NewStaff.Text.Trim().Length > 50)
            {
                MessageBox.Show("Address 2 textbox is not valid, please match these criteria: "
                    + "\n1) Letters or digits only."
                    + "\n2) No leading or traling spaces."
                    + "\n3) Should not be greater than 50 characters long." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAd2NewStaff.Focus();
                IsValidEntry = false;
            }
            // Town should only be letters
            // One space between every words
            // No leading or trailing spaces
            // Between 1-30 characters
            else if (Utils.IsAllLetter(tbTownNewStaff.Text) || (tbTownNewStaff.Text.Trim().Length < 1 || tbTownNewStaff.Text.Trim().Length > 30) )
            {
                MessageBox.Show("Town is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Length is between 1-30 characters." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTownNewStaff.Focus();
                IsValidEntry = false;
            }
            // Username should be between 6-20 characters long
            // Username should be alphanumeric
            else if (Utils.IsAlphaNumeric(tbUsername.Text) || (tbUsername.Text.Trim().Length < 6 || tbUsername.Text.Trim().Length > 20) )
            {
                MessageBox.Show("Username is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters or digits." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Length is between 6-20 characters.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsername.Focus();
                IsValidEntry = false;
            }
            // Password should be between at least 5-20 characters long
            // Contain at least 2 letters
            // Contain at least 2 digits
            // Contain at least 1 Uppercase
            // Contain at least 1 Lowercase
            else if (!Utils.IsValidPassword(tbPassword.Text.Trim()))
            {              
                MessageBox.Show("Please make sure your password passes these criteria:\n" + "1) Password should be between 5-20 characters.\n"
                + "2) Should contain at least 2 letters.\n" + "3) Should contain at least 2 digits.\n"
                + "4) Should contain at least 1 UPPERCASE letter.\n" + "5) Should contain at least 1 LOWERCASE letter.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Focus();
                IsValidEntry = false;
            }

            return IsValidEntry;
        }
        #endregion

        #region ADDING A NEW STAFF
        /// <summary>
        /// If save new staff button is clicked, display staff is registered, otherwise display staff is not registered
        /// </summary>
        /// <param name="sender">the object that invoked the event that fired the event handler.</param>
        /// <param name="e"></param>
        private void btnSaveNewStaff_Click(object sender, EventArgs e)
        {

            if (IsValidTextBox())
            {
                string strMaxID = "SELECT MAX(Staff_ID) FROM Staff";
                string strNextID = Utils.GetNextID(strMaxID);
                //int nextID = Int32.Parse(strNextID);

                // Uppercase the first letter in every words
                // Trim the trailing white spaces at the end
                string surname = Utils.UppercaseFirstLetter(tbSurnameNewStaff.Text.Trim());
                string forename = Utils.UppercaseFirstLetter(tbForenameNewStaff.Text.Trim());
                string dob = dateDOBNewStaff.Value.ToString("dd-MMM-yyyy");
                string ad1 = Utils.UppercaseFirstLetter(tbAd1NewStaff.Text.Trim());
                string ad2 = Utils.UppercaseFirstLetter(tbAd2NewStaff.Text.Trim());
                string town = Utils.UppercaseFirstLetter(tbTownNewStaff.Text.Trim());

                // See which county is selected from the combo-box
                Object selectedItem = cbCountiesNewStaff.SelectedItem;
                string county = selectedItem.ToString();

                string tel = tbMobileNewStaff.Text.Trim();
                string email = tbEmailNewStaff.Text.Trim().ToLower();

                // See which staff type is selected from the combo box
                Object type_index = cbStaffType.SelectedItem;
                string staffType = type_index.ToString().Trim();

                string username = tbUsername.Text.Trim();
                string password = tbPassword.Text.Trim();


                string strSQL = "INSERT INTO Staff (Staff_ID, Surname, Forename, DOB, Address1, Address2, Town, County, Telephone, Email, Staff_Type, username, password)"
                    + " VALUES (" + strNextID + ", '" + surname + "','" + forename + "','" + dob + "','" + ad1 + "','" + ad2 + "','" + town + "','" + county + "', '" + tel + "','"
                    + email + "','" + staffType + "','" + username + "','" + password + "')";

                Utils.InsertData(strSQL);

                // If the staff registration is successful
                if (Utils.IsSuccessful())
                {
                    DialogResult dr = MessageBox.Show("Staff added successfully!\nDo you want to register another staff?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        Utils.ClearAllText(this);
                    }
                    else
                    {                      
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Staff registration was unsucessful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } // end of validating text box
              
        }
        #endregion

        #region KEYPRESS LISTENER - GOES TO THE NEXT TEXTBOX ON PRESSING ENTER BUTTON
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

        #region KEYPRESS LISTENER - SUBMITS THE FORM WHEN ENTER BUTTON IS CLICKED
        /// <summary>
        /// Upon pressing enter key from the last textbox, this method submits the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveNewStaff.PerformClick();
            }
        }
        #endregion
    }
}

using System;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmNewCustomer : Form
    {
        public frmNewCustomer()
        {
            InitializeComponent();

        }

        #region LOAD DEFAULTS
        ///<summary>
        /// 1) Focus the first textbox in the form
        /// 2) Customer needs to be at least 16-60 years old
        ///    -- Set MaxDate 16 years behind
        ///    -- Set MinDate 60 years behind
        /// 3) Select a default county
        /// 4) Select a default Customer type
        /// 5) Convert string to PasswordChar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNewCustomer_Load(object sender, EventArgs e)
        {
            dateDOB.MaxDate = DateTime.Now.AddYears(-16); //Customer needs to be at least 16
            dateDOB.MinDate = DateTime.Now.AddYears(-60); //Customer needs to be at most 60
            cbCounties.SelectedIndex = cbCounties.Items.IndexOf("Kerry"); //Choose County Kerry by default
            cbCustType.SelectedIndex = cbCustType.Items.IndexOf("Normal"); // Customer type is set to 'Normal' by default
            
        }
        #endregion

        #region CLEAR ALL THE TEXT
        /// <summary>
        /// Removes the contents from the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
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
            if (Utils.IsAllLetter(tbForename.Text) || (tbForename.Text.Trim().Length < 1 || tbForename.Text.Trim().Length > 30))
            {
                MessageBox.Show("Firstname is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Between 1-30 characters." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbForename.Focus();
                IsValidEntry = false;
            }
            // Surname should only be letters
            // One space between every words
            // No trailing spaces
            // Between 1-30 characters
            else if (Utils.IsAllLetter(tbSurname.Text) || (tbSurname.Text.Trim().Length < 1 || tbSurname.Text.Trim().Length > 30))
            {
                MessageBox.Show("Surname is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Length is between 1-30 characters." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSurname.Focus();
                IsValidEntry = false;
            }
            // Mobile number should only be digits
            // No spaces
            // Between 7-10 characters
            else if (Utils.IsAllDigits(tbMobile.Text) && !Utils.IsWhiteSpace(tbMobile.Text)
                || (tbMobile.Text.Trim().Length < 7 || tbMobile.Text.Trim().Length > 10))
            {
                MessageBox.Show("Mobile/Telephone number is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain digits." + "\n2) No spaces in between." + "\n3) Length is between 7-10 characters!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMobile.Focus();
                IsValidEntry = false;

            }
            // Email should be a valid format
            // No special characters, no spaces
            // Alphanumeric, hyphen (-), underscore (_) and comma (.) is allowed only
            // Should not be greater than 100 characters long
            else if (!Utils.IsValidEmail(tbEmail.Text.Trim()) || tbEmail.Text.Trim().Length > 100)
            {
                MessageBox.Show("Please enter valid email address! e.g. Joe@Bloggs.com", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Focus();
                IsValidEntry = false;
            }
            else if (Utils.IsAlphaNumeric(tbAd1.Text) || (tbAd1.Text.Trim().Length < 1 || tbAd1.Text.Trim().Length > 50))
            {
                MessageBox.Show("Address 1 textbox is not valid, please match these criteria: "
                    + "\n1) Letters or digits only."
                    + "\n2) No leading or traling spaces."
                    + "\n3) Should not be greater than 50 characters long." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAd1.Focus();
                IsValidEntry = false;
            }
            else if (Utils.IsAlphaNumeric(tbAd2.Text) || tbAd2.Text.Trim().Length > 50)
            {
                MessageBox.Show("Address 2 textbox is not valid, please match these criteria: "
                    + "\n1) Letters or digits only."
                    + "\n2) No leading or traling spaces."
                    + "\n3) Should not be greater than 50 characters long." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAd2.Focus();
                IsValidEntry = false;
            }
            // Town should only be letters
            // One space between every words
            // No leading or trailing spaces
            // Between 1-30 characters
            else if (Utils.IsAllLetter(tbTown.Text) || (tbTown.Text.Trim().Length < 1 || tbTown.Text.Trim().Length > 30))
            {
                MessageBox.Show("Town is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Length is between 1-30 characters." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTown.Focus();
                IsValidEntry = false;
            }

            return IsValidEntry;
        }
        #endregion

        #region ADDING A NEW CUSTOMER
        /// <summary>
        /// Adds new customer to the database
        /// If customer is added successfully - display successful message - otherwise, display error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveNewCust_Click(object sender, EventArgs e)
        {
            // Checks if the textboxes are valid
            if (IsValidTextBox())
            {
                string strMaxID = "SELECT MAX(Cust_ID) FROM Customers";
                string strNextID = Utils.GetNextID(strMaxID);

                // Uppercase the first letter in every words
                // Trim the trailing white spaces at the end
                string surname = Utils.UppercaseFirstLetter(tbSurname.Text.Trim());
                string forename = Utils.UppercaseFirstLetter(tbForename.Text.Trim());
                string dob = dateDOB.Value.ToString("dd-MMM-yyyy");
                string ad1 = Utils.UppercaseFirstLetter(tbAd1.Text.Trim());
                string ad2 = Utils.UppercaseFirstLetter(tbAd2.Text.Trim());
                string town = Utils.UppercaseFirstLetter(tbTown.Text.Trim());

                // See which county is selected from the combo-box
                Object selectedItem = cbCounties.SelectedItem;
                string county = selectedItem.ToString();

                string tel = tbMobile.Text.Trim();
                string email = tbEmail.Text.Trim().ToLower();

                // See which staff type is selected from the combo box
                Object type_index = cbCustType.SelectedItem;
                string custType = type_index.ToString().Trim();
                
                // SQL Query String
                string strSQL = "INSERT INTO Customers (Cust_ID, Surname, Forename, DOB, Address1, Address2, Town, County, Telephone, Email, Cust_Type)"
                + " VALUES (" + strNextID + ", '" + surname + "','" + forename + "','" + dob + "','" + ad1 + "','" + ad2 + "','" + town + "','" + county + "', '" + tel + "','"
                + email + "','" + custType + "')";

                // Insert into the database
                Utils.InsertData(strSQL);

                // Check if the Insert was successful
                if (Utils.IsSuccessful())
                {
                    DialogResult dr = MessageBox.Show("Customer added successfully!\nDo you want to register another customer?", 
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                    MessageBox.Show("Customer registration was unsucessful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } //end of validating textbox       
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
                btnSaveNewCust.PerformClick();
            }
        }
        #endregion

    }
}

using System;
using System.Data;
using System.Data.OracleClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmAmendCustomer : Form
    {
        #region GLOBAL VARIABLES

        private string ID_Choosen;

        #endregion

        #region INITIALIZE COMPONENT
        /// <summary>
        /// Intialize all the form components
        /// </summary>
        public frmAmendCustomer()
        {
            InitializeComponent();
        }
        #endregion

        #region LOAD DEFAULTS
        /// <summary>
        /// 1) Focus to the first text box
        /// 2) Remove the listTab and amendTab from TabPages
        /// 3) Set Min Date and Max Date for DateTimePicker
        /// 4) AutoCompleteList for Firstname
        /// 5) AutocompleteList for Surname
        /// 6) AutocompleteList for Town
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAmendCustomer_Load(object sender, EventArgs e)
        {
            this.tbQueryFirstname.Select();
            tabAmendCust.TabPages.Remove(listTab);
            tabAmendCust.TabPages.Remove(amendTab);
            dateDOB.MaxDate = DateTime.Now.AddYears(-16); // Customer needs to be at least 16 years old
            dateDOB.MinDate = DateTime.Now.AddYears(-60); // Customer needs to be at most 60 years old

            //
            // Generate auto complete list from the database for FIRSTNAME
            //
            string queryFirstname = "SELECT * FROM Customers WHERE forename LIKE '%" + tbQueryFirstname.Text.Trim() + "%'";
            tbQueryFirstname.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbQueryFirstname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbQueryFirstname.AutoCompleteCustomSource = Utils.AutoComplete(tbQueryFirstname, queryFirstname, "forename");

            //
            // Generate auto complete list from the database for LASTNAME
            //
            string queryLastname = "SELECT * FROM Customers WHERE surname LIKE '%" + tbQuerySurname.Text.Trim() + "%'";
            tbQuerySurname.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbQuerySurname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbQuerySurname.AutoCompleteCustomSource = Utils.AutoComplete(tbQuerySurname, queryLastname, "surname");

            //
            // Generate auto complete list from the database for TOWN
            //
            string queryTown = "SELECT * FROM Customers WHERE town LIKE '%" + tbQueryTown.Text.Trim() + "%'";
            tbQueryTown.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbQueryTown.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbQueryTown.AutoCompleteCustomSource = Utils.AutoComplete(tbQueryTown, queryTown, "town");
        }
        #endregion

        #region QUERY CUSTOMER BUTTON ACTIONS
        /// <summary>
        /// Hide/Show Back Buttons
        /// Remove/Insert Tabs
        /// Query the details from the database
        /// If no data as found
        /// -- Display error message - go back to the query tab
        /// -- Clear all the text from the query tab textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (IsValidTextBox_QueryTab())
            {
                this.btnBack1.Visible = false; // Hide Back Button from Query Tab
                this.btnBack2.Visible = true; // Show Back Button in List Tab
                this.btnBack2.Location = new System.Drawing.Point(584, 30);

                tabAmendCust.TabPages.Remove(queryTab); // Remove the query tab
                tabAmendCust.TabPages.Insert(0, listTab); // Insert the Customer List Tab
                tabAmendCust.SelectedTab = listTab; // Select the List Tab

                string strQuery = "SELECT Cust_ID AS ID, Surname, Forename, Town, Telephone "
                    + "FROM Customers WHERE forename LIKE '%" + Utils.UppercaseFirstLetter(tbQueryFirstname.Text.Trim())
                    + "%' AND surname LIKE '%" + Utils.UppercaseFirstLetter(tbQuerySurname.Text.Trim())
                    + "%' AND town LIKE '%" + Utils.UppercaseFirstLetter(tbQueryTown.Text.Trim()) + "%'";

                Utils.ListingOnDataGrid(grdAmendCust, strQuery);

                //
                // If no data is found
                //
                if (!Utils.IsSuccessful())
                {
                    MessageBox.Show(tbQueryFirstname.Text + " " + tbQuerySurname.Text + " doesn't exist in our database. Press OK to continue...");
                    this.btnBack2.Visible = false;
                    this.btnBack1.Visible = true;
                    tabAmendCust.TabPages.Remove(listTab);
                    tabAmendCust.TabPages.Insert(0, queryTab);
                    tabAmendCust.SelectedTab = queryTab;
                }
                //
                // Empty the text boxes
                //
                tbQueryFirstname.Text = String.Empty;
                tbQuerySurname.Text = String.Empty;
                tbQueryTown.Text = String.Empty;
                tbQueryFirstname.Select();
            }
        }
        #endregion

        #region TEXTBOX VALIDATION FOR QUERY TAB
        /// <summary>
        /// This method validates the textbox entries from the QueryTab and throws appropriate error messages to window
        /// </summary>
        /// <returns>
        /// Returns true if the textbox entries are valid
        /// </returns>
        private Boolean IsValidTextBox_QueryTab()
        {
            Boolean IsValidEntry = true;
            if (Utils.IsAllLetter(tbQueryFirstname.Text) || (tbQueryFirstname.Text.Trim().Length < 1 || tbQueryFirstname.Text.Trim().Length > 30))
            {
                MessageBox.Show("Firstname should not be empty or contain digits!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbQueryFirstname.Focus();
                IsValidEntry = false;
            }
            else if (Utils.IsAllLetter(tbQuerySurname.Text) || (tbQuerySurname.Text.Trim().Length < 1 || tbQuerySurname.Text.Trim().Length > 30))
            {
                MessageBox.Show("Surname should not be empty or contain digits!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbQuerySurname.Focus();
                IsValidEntry = false;
            }
            else if (Utils.IsAllLetter(tbQueryTown.Text) || tbQueryTown.Text.Trim().Length > 30)
            {
                MessageBox.Show("Town should not contain digits!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbQueryTown.Focus();
                IsValidEntry = false;
            }
            return IsValidEntry;
        }
        #endregion

        #region GET CONTENTS FROM THE DATAGRID VIEW
        /// <summary>
        /// Gets values from the datagridview
        /// -- Asks user if the specified customer to be amended
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdAmendCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //
            // Find out the value of the cell content
            //
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                ID_Choosen = grdAmendCust.Rows[e.RowIndex].Cells[1].Value.ToString().Trim(); // Customer ID clicked
                string ln = grdAmendCust.Rows[e.RowIndex].Cells[2].Value.ToString().Trim(); // Lastname clicked
                string fn = grdAmendCust.Rows[e.RowIndex].Cells[3].Value.ToString().Trim(); // Firstname clicked

                DialogResult dr = MessageBox.Show("Do you want to amend " + fn + " " + ln + "\'s details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    this.btnBack2.Visible = false;
                    this.btnBack3.Visible = true;
                    this.btnBack3.Location = new System.Drawing.Point(584, 30);

                    tabAmendCust.TabPages.Remove(listTab);
                    FillTextBoxes(ID_Choosen);
                    tabAmendCust.TabPages.Insert(0, amendTab);
                    tabAmendCust.SelectedTab = amendTab;
                }
            }
        }
        #endregion

        #region FILLING THE TEXTBOXES WITH THE VALUES FROM DATABASE
        /// <summary>
        /// This method retrieves data from the database and assigns them to the appropriate text boxes
        /// </summary>
        /// <param name="Cust_ID"></param>
        private void FillTextBoxes(String Cust_ID)
        {
            try
            {
                string oradb = Utils.OracleConnectionString();

                // Create an instance of an Oracle Command to be executed
                OracleConnection connect = new OracleConnection(oradb);

                string strQuery = "SELECT * FROM Customers WHERE Cust_ID = " + Cust_ID + "";
                //MessageBox.Show(strQuery);

                OracleCommand cmd = new OracleCommand(strQuery, connect);

                // Specify that the command type is a string
                cmd.CommandType = CommandType.Text;

                // Check if the connection is alive
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                // Create a data adapter to contain the results of the query
                OracleDataAdapter orada = new OracleDataAdapter(cmd);
                // Create a data table to store the data
                DataTable dt = new DataTable();
                // Fill up data into the data table
                orada.Fill(dt);
                // Count the rows in the data table
                int RowCount = dt.Rows.Count;
                string row = RowCount.ToString();
                //MessageBox.Show(RowCount.ToString());

                if (RowCount > 0)
                {

                    tbForename.Text = dt.Rows[0]["FORENAME"].ToString().Trim();
                    tbSurname.Text = dt.Rows[0]["SURNAME"].ToString().Trim();
                    string cust_type = dt.Rows[0]["CUST_TYPE"].ToString().Trim();
                    cbCustType.SelectedIndex = cbCustType.Items.IndexOf(cust_type);
                    dateDOB.Text = dt.Rows[0]["DOB"].ToString().Trim();

                    tbMobile.Text = dt.Rows[0]["TELEPHONE"].ToString().Trim();
                    tbEmail.Text = dt.Rows[0]["EMAIL"].ToString().Trim();
                    string status = dt.Rows[0]["STATUS"].ToString().Trim();
                    cbStatus.SelectedIndex = cbStatus.Items.IndexOf(status);

                    tbAd1.Text = dt.Rows[0]["ADDRESS1"].ToString().Trim();
                    tbAd2.Text = dt.Rows[0]["ADDRESS2"].ToString().Trim();
                    tbTown.Text = dt.Rows[0]["TOWN"].ToString().Trim();
                    string county = dt.Rows[0]["COUNTY"].ToString().Trim();
                    cbCounties.SelectedIndex = cbCounties.Items.IndexOf(county);
                }
                else
                {
                    System.Windows.MessageBox.Show("No data is found");
                }

                connect.Close();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region AMEND CUSTOMER DETAILS
        /// <summary>
        /// Amend customer details
        /// Removes multiple white spaces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAmendCust_Click(object sender, EventArgs e)
        {
            if (IsValidTextBox_AmendTab())
            {
                string dob = dateDOB.Value.ToString("dd-MMM-yyyy");
                Object selectedCounty = cbCounties.SelectedItem;
                string county = selectedCounty.ToString();
                Object selectedCust = cbCustType.SelectedItem;
                string Cust_Type = selectedCust.ToString();
                Object selectedStatus = cbStatus.SelectedItem;
                string status = selectedStatus.ToString();

                RemoveMultipleWhiteSpacesFromTextBox();

                string strQuery = "UPDATE Customers SET surname ='" + tbSurname.Text.Trim()
                    + "', forename='" + tbForename.Text.Trim() + "', DOB='"
                    + dob + "', Address1='" + tbAd1.Text.Trim()
                    + "', Address2='" + tbAd2.Text.Trim() + "', town='" + tbTown.Text.Trim() + "', county='"
                    + county + "', telephone='" + tbMobile.Text.Trim() + "', email='" + tbEmail.Text.Trim()
                    + "', Cust_Type='" + Cust_Type + "', status='" + status
                    + "' WHERE Cust_ID=" + ID_Choosen + "";
                //MessageBox.Show(strQuery);

                Utils.UpdateData(strQuery);

                if (Utils.IsSuccessful())
                {
                    DialogResult dr = MessageBox.Show("Customer details amended successfully!\nDo you want to amend another customer?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        this.btnBack3.Visible = false;
                        this.btnBack2.Visible = false;
                        this.btnBack1.Visible = true;
                        tabAmendCust.TabPages.Remove(amendTab);
                        tabAmendCust.TabPages.Insert(0, queryTab);
                        tabAmendCust.SelectedTab = queryTab;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Unfortunately, the system failed to amend the customer details. Please enter your details correctly!", 
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } // end of validating text boxes

        }
        #endregion

        #region TEXTBOX VALIDATION FOR AMEND CUSTOMER TAB
        /// <summary>
        /// This method validates the textbox entries and throws appropriate error messages to window
        /// </summary>
        /// <returns>Returns true if text box entries are valid</returns>
        private Boolean IsValidTextBox_AmendTab()
        {
            Boolean IsValidEntry = true;

            if (Utils.IsAllLetter(tbForename.Text) || (tbForename.Text.Length < 1 || tbForename.Text.Length > 30))
            {
                MessageBox.Show("Firstname is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Between 1-30 characters." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbForename.Focus();
                IsValidEntry = false;
            }
            else if (Utils.IsAllLetter(tbSurname.Text) || (tbSurname.Text.Trim().Length < 1 || tbSurname.Text.Trim().Length > 30))
            {
                MessageBox.Show("Surname is not valid, please make sure it matches these criteria: "
                                    + "\n1) Should only contain letters." + "\n2) Should NOT start/end with space(s)"
                                    + "\n3) Length is between 1-30 characters." + "\n4) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error); tbSurname.Focus();
                IsValidEntry = false;
            }

            else if (Utils.IsAllDigits(tbMobile.Text) && !Utils.IsWhiteSpace(tbMobile.Text)
                || (tbMobile.Text.Trim().Length < 7 || tbMobile.Text.Trim().Length > 10))
            {
                MessageBox.Show("Mobile/Telephone number is not valid, please make sure it matches these criteria: "
                                    + "\n1) Should only contain digits." + "\n2) No spaces in between." + "\n3) Length is between 7-10 characters!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error); tbMobile.Focus();
                IsValidEntry = false;

            }
            else if (!Utils.IsValidEmail(tbEmail.Text.Trim()) || tbEmail.Text.Length > 100)
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
                tbAd1.Focus();
                IsValidEntry = false;
            }
            else if (Utils.IsAllLetter(tbTown.Text) || (tbTown.Text.Trim().Length < 0 || tbTown.Text.Trim().Length > 30))
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

        #region REMOVE MULTIPLE WHITE SPACES FROME TEXT BOXES
        /// <summary>
        /// This method removes multiple white spaces from text boxes
        /// </summary>
        private void RemoveMultipleWhiteSpacesFromTextBox()
        {
            tbSurname.Text = Regex.Replace(tbSurname.Text.Trim(), @"\s+", " ");
            tbForename.Text = Regex.Replace(tbForename.Text.Trim(), @"\s+", " ");
            tbAd1.Text = Regex.Replace(tbAd1.Text.Trim(), @"\s+", " ");
            tbAd2.Text = Regex.Replace(tbAd2.Text.Trim(), @"\s+", " ");
            tbTown.Text = Regex.Replace(tbTown.Text.Trim(), @"\s+", " ");
        }
        #endregion

        #region BACK BUTTON FROM AMEND CUSTOMER TAB
        /// <summary>
        /// hide back button 3
        /// show back button 2
        /// move back button to a specific place
        /// remove amend tab
        /// show list tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack3_Click(object sender, EventArgs e)
        {
            this.btnBack3.Visible = false;
            this.btnBack2.Visible = true;
            this.btnBack2.Location = new System.Drawing.Point(584, 30);

            tabAmendCust.TabPages.Remove(amendTab);
            tabAmendCust.TabPages.Insert(0, listTab);
            tabAmendCust.SelectedTab = listTab;
        }
        #endregion

        #region BACK BUTTON FROM LIST TAB
        /// <summary>
        /// hide back button 2
        /// show back button 1
        /// remove list tab
        /// show query tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.btnBack2.Visible = false;
            this.btnBack1.Visible = true;

            tabAmendCust.TabPages.Remove(listTab);
            tabAmendCust.TabPages.Insert(0, queryTab);
            tabAmendCust.SelectedTab = queryTab;
        }
        #endregion

        #region MOVE TO NEXT TEXTBOX WHEN PRESSING THE ENTER BUTTON
        /// <summary>
        /// Moeves to the next textbox when enter button is pressed
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

        #region SUBMIT THE FORM IF ENTER BUTTON IS PRESSED FROM THE LAST TEXTBOX
        /// <summary>
        /// Upon pressing enter key from the town textbox, this method submits the login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbQueryTown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQuery.PerformClick();
            }
        }
        #endregion

    }
}

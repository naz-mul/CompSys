using System;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmNewRepair : Form
    {

        #region GLOBAL VARIABLES

        private String CustomerIDChosen;

        #endregion

        #region INITIALIZE COMPONENT
        /// <summary>
        /// 
        /// </summary>
        public frmNewRepair()
        {
            InitializeComponent();
            
        }
        #endregion

        #region LOAD DEFAULTS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNewRepair_Load(object sender, EventArgs e)
        {
            this.tbQueryFirstname.Select();
            tabNewRepair.TabPages.Remove(custTab);
            tabNewRepair.TabPages.Remove(problemTab);
           
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

        #region SEARCH CUSTOMER BUTTON
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (IsValidTextBox_QueryTab())
            {
                this.btnBack.Visible = false; // Hide Back Button from Query Tab
                this.btnBack2.Visible = true; // Show Back Button in List Tab
                this.btnBack2.Location = new System.Drawing.Point(591, 22);

                tabNewRepair.TabPages.Remove(startTab); // Remove the query tab
                tabNewRepair.TabPages.Insert(0, custTab); // Insert the Customer List Tab
                tabNewRepair.SelectedTab = custTab; // Select the List Tab

                string strQuery = "SELECT Cust_ID AS ID, Surname, Forename, Town, Telephone "
                    + "FROM Customers WHERE forename LIKE '%" + Utils.UppercaseFirstLetter(tbQueryFirstname.Text.Trim())
                    + "%' AND surname LIKE '%" + Utils.UppercaseFirstLetter(tbQuerySurname.Text.Trim())
                    + "%' AND town LIKE '%" + Utils.UppercaseFirstLetter(tbQueryTown.Text.Trim()) + "%'";

                Utils.ListingOnDataGrid(grdListCust, strQuery);

                //
                // If no data is found
                //
                if (!Utils.IsSuccessful())
                {
                    // display error message
                    MessageBox.Show(tbQueryFirstname.Text + " " + tbQuerySurname.Text 
                        + " doesn't exist in our database. Press OK to continue...");
                    
                    //hide/show back buttons
                    this.btnBack2.Visible = false;
                    this.btnBack.Visible = true;

                    tabNewRepair.TabPages.Remove(custTab);
                    tabNewRepair.TabPages.Insert(0, startTab);
                    tabNewRepair.SelectedTab = startTab;
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
        private void grdListCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //
            // Find out the value of the cell content
            //
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // Get customer information
                CustomerIDChosen = grdListCust.Rows[e.RowIndex].Cells[1].Value.ToString().Trim(); // Customer ID clicked
                string ln = grdListCust.Rows[e.RowIndex].Cells[2].Value.ToString().Trim(); // Lastname clicked
                string fn = grdListCust.Rows[e.RowIndex].Cells[3].Value.ToString().Trim(); // Firstname clicked

                DialogResult dr = MessageBox.Show("Do you want to add a new repair for customer: " + fn + " " + ln + "?"
                    , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    this.btnBack2.Visible = false;
                    this.btnBack3.Visible = true;
                    this.btnBack3.Location = new System.Drawing.Point(591, 22);

                    // Set defaults
                    cbDeviceType.SelectedIndex = cbDeviceType.Items.IndexOf("Laptop");
                    cbOS.SelectedIndex = cbOS.Items.IndexOf("Windows 8");

                    // Insert tabs
                    tabNewRepair.TabPages.Remove(custTab);
                    tabNewRepair.TabPages.Insert(0, problemTab);
                    tabNewRepair.SelectedTab = problemTab;  
                }
            }
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
        private void tbTown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
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

            // Brand name should only be letters/numbers
            // One space between every words
            // No trailing spaces
            // Between 1-50 characters
            if (Utils.IsAlphaNumeric(tbBrand.Text) || (tbBrand.Text.Trim().Length < 1 || tbBrand.Text.Trim().Length > 50))
            {
                MessageBox.Show("Brand is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters/numbers." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Between 1-50 characters." + "\n4) Only one space between words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBrand.Focus();
                IsValidEntry = false;
            }
            // Description can only be alphanumeric
            // Between 1-500 characters
            else if (tbDescription.Text.Trim().Length < 1 || tbDescription.Text.Trim().Length > 800)
            {
                MessageBox.Show("Description is not valid, please make sure it matches these criteria: "
                    + "\n1) Should NOT start/end with space(s)"
                    + "\n2) Length is between 1-800 characters." + "\n3) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDescription.Focus();
                IsValidEntry = false;
            }
            // Vendor name should only be letters
            // One space between every words
            // No trailing spaces
            // Between 1-50 characters
            else if (Utils.IsAlphaNumeric(tbModel.Text) || (tbModel.Text.Trim().Length < 1 || tbModel.Text.Trim().Length > 50))
            {
                MessageBox.Show("Model is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters/numbers." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Between 1-50 characters." + "\n4) Only one space between words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbModel.Focus();
                IsValidEntry = false;

            }

            return IsValidEntry;
        }
        #endregion

        #region ADD NEW REPAIR
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidTextBox())
            {
                // Get next repair ID
                String strMaxID = "SELECT MAX(Rep_ID) FROM Repairs";
                String strRepID = Utils.GetNextID(strMaxID);

                // Get Staff ID
                String strQueryStaff = "SELECT * FROM Staff WHERE username = '" + frmLogin.username + "'";
                String strStaffID = Utils.GetSingleValue(strQueryStaff, "Staff_ID");

                // Uppercase the first letter in every words
                // Trim the trailing white spaces at the end
                string brand = Utils.UppercaseFirstLetter(tbBrand.Text.Trim());
                string model = Utils.UppercaseFirstLetter(tbModel.Text.Trim());

                // See which device is selected from the combo-box
                Object selectedDevice = cbDeviceType.SelectedItem;
                string device = selectedDevice.ToString();

                // See which OS is selected from the combo-box
                Object selectedOS = cbOS.SelectedItem;
                string os = selectedOS.ToString();

                // Get description
                string description = GetCheckedItemsValue() + " " + tbDescription.Text.Trim();

                // Insert Query
                String strQuery = "INSERT INTO Repairs "
                                            + "(Rep_ID, Cust_ID, Staff_ID, Description, DeviceType, Brand, Model, OS)"
                                + "VALUES "
                                + "("
                                            + strRepID + ", "
                                            + CustomerIDChosen + ", "
                                            + strStaffID + ", '"
                                            + description + "', '"
                                            + device + "', '"
                                            + brand + "', '"
                                            + model + "', '"
                                            + os + "'"
                                + ")";

                // Insert into the database
                Utils.InsertData(strQuery);

                // Check if the Insert was successful
                if (Utils.IsSuccessful())
                {
                    DialogResult dr = MessageBox.Show("New repair added successfully!\nDo you want to add another one?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        // Clear everything
                        Utils.ClearAllText(this);
                        UncheckAllItems();

                        // Remove the tabs
                        tabNewRepair.TabPages.Remove(custTab);
                        tabNewRepair.TabPages.Remove(problemTab);
                        // Go back to the start
                        this.tbQueryFirstname.Select();
                        tabNewRepair.TabPages.Insert(0, startTab);
                        tabNewRepair.SelectedTab = startTab;

                        //hide/show back buttons
                        this.btnBack.Visible = true;
                        this.btnBack2.Visible = false;
                        this.btnBack3.Visible = false;

                    }
                    else
                    {
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Adding a new repair was not successful!", 
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region UNCHECK COMBO-BOX ITEMS
        /// <summary>
        /// 
        /// </summary>
        private void UncheckAllItems()
        {
            while (clbProblem.CheckedIndices.Count > 0)
                clbProblem.SetItemChecked(clbProblem.CheckedIndices[0], false);
        }
        #endregion

        #region CLEAR EVERYTHING
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Uncheck all the problems
            UncheckAllItems();

            // Clear everything from the textboxes
            Utils.ClearAllText(this);
        }
        #endregion

        #region GET VALUES OF LIST ITEMS
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Checked problems</returns>
        private String GetCheckedItemsValue()
        {
            String problems = "";
            foreach (object itemChecked in clbProblem.CheckedItems)
            {             
                problems += itemChecked.ToString() + ", ";
            }

            return problems;
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
            this.btnBack.Visible = true;

            tabNewRepair.TabPages.Remove(custTab);
            tabNewRepair.TabPages.Insert(0, startTab);
            tabNewRepair.SelectedTab = startTab;

            //
            // Empty the text boxes
            //
            tbQueryFirstname.Text = String.Empty;
            tbQuerySurname.Text = String.Empty;
            tbQueryTown.Text = String.Empty;
            tbQueryFirstname.Select();

            // Reset the datagrid view
            grdListCust.DataSource = null;
            grdListCust.Refresh();
        }
        #endregion

        #region BACK BUTTON FROM PROBLEM TAB
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
            this.btnBack2.Location = new System.Drawing.Point(591, 22);

            tabNewRepair.TabPages.Remove(problemTab);
            tabNewRepair.TabPages.Insert(0, custTab);
            tabNewRepair.SelectedTab = custTab;
        }
        #endregion

    }
}

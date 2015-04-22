using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmInventory : Form
    {
        #region GLOBAL VARIABLES

        private int TotalRowsChecked;
        private String Id_Selected;
        private ArrayList aList;

        #endregion

        #region LOAD THE FORM
        /// <summary>
        /// 
        /// </summary>
        public frmInventory()
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
        private void frmInventory_Load(object sender, EventArgs e)
        {
            tbProduct.Select(); // Select the first textbox
            tabAmend.Enabled = false;
            //cbStatus.SelectedIndex = cbStatus.Items.IndexOf("Used");
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

            // Product name should only be letters/numbers
            // One space between every words
            // No trailing spaces
            // Between 1-30 characters
            if (Utils.IsAlphaNumeric(tbProduct.Text) || (tbProduct.Text.Trim().Length < 1 || tbProduct.Text.Trim().Length > 40))
            {
                MessageBox.Show("Product is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters/numbers." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Between 1-40 characters." + "\n4) Only one space between words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbProduct.Focus();
                IsValidEntry = false;
            }
            // Description can only be alphanumeric
            // Between 1-500 characters
            else if (tbDescription.Text.Trim().Length < 1 || tbDescription.Text.Trim().Length > 500)
            {
                MessageBox.Show("Description is not valid, please make sure it matches these criteria: "
                    + "\n1) Should NOT start/end with space(s)"
                    + "\n2) Length is between 1-500 characters." + "\n3) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDescription.Focus();
                IsValidEntry = false;
            }
            // Vendor name should only be letters
            // One space between every words
            // No trailing spaces
            // Between 1-50 characters
            else if (Utils.IsAllLetter(tbVendor.Text) || (tbVendor.Text.Trim().Length < 1 || tbVendor.Text.Trim().Length > 50))
            {
                MessageBox.Show("Vendor is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Between 1-50 characters." + "\n4) Only one space between words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbVendor.Focus();
                IsValidEntry = false;

            }
            // Condition should be selected
            else if (!rbNew.Checked && !rbRefurb.Checked && !rbUsed.Checked)
            {
                MessageBox.Show("Please select the condition of the product!",
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsValidEntry = false;
            }
            // Quantity can only be Integer value
            else if (!Utils.IsInt(tbQuantity.Text.Trim()) || (tbQuantity.Text.Trim().Length < 1 || tbQuantity.Text.Trim().Length > 5))
            {
                MessageBox.Show("Quanity is not valid, please input a valid quantity! " +
                    "\na) It should only contains numbers. \nb) 1-5 digits only",
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbQuantity.Focus();
                IsValidEntry = false;
            }
            // Price can only be Double value
            else if (!Utils.IsDouble(tbPrice.Text.Trim()) || (tbPrice.Text.Trim().Length < 1 || tbPrice.Text.Trim().Length > 7))
            {
                MessageBox.Show("Price is not valid, please input a valid price! " +
                    "\na) It should only contains numbers. \nb) 9,2 number format",
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPrice.Focus();
                IsValidEntry = false;
            }

            return IsValidEntry;
        }
        #endregion

        #region CLEAR TEXT BOX INPUTS (Add)
        /// <summary>
        /// Clears everything from the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Utils.ClearAllText(this);
        }
        #endregion

        #region RADIO BUTTON TEXT
        /// <summary>
        /// Gets the value of the radio button
        /// </summary>
        /// <returns>String output of the selected radio button</returns>
        private String GetRadioButtonText(RadioButton a, RadioButton b)
        {
            if (a.Checked)
            {
                return "New";
            }
            else if (b.Checked)
            {
                return "Refurbished";
            }
            else
            {
                return "Used";
            }
        }
        #endregion

        #region ADDING A NEW INVENTORY
        /// <summary>
        /// Adds a new inventory item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //String strSQL = "INSERT INTO Parts";
            if (IsValidTextBox())
            {
                string strMaxID = "SELECT MAX(Part_ID) FROM Parts";
                string strNextID = Utils.GetNextID(strMaxID);

                // Uppercase the first letter in every words
                // Trim the trailing white spaces at the end
                string name = Utils.UppercaseFirstLetter(tbProduct.Text.Trim());
                string description = Utils.UppercaseFirstLetter(tbDescription.Text.Trim());
                string vendor = Utils.UppercaseFirstLetter(tbVendor.Text.Trim());
                string condition = GetRadioButtonText(rbNew, rbRefurb).Trim();
                string quantity = tbQuantity.Text.Trim();
                string price = tbPrice.Text.Trim();

                // Insert Query
                String strQuery = "INSERT INTO Parts "
                                + "VALUES "
                                + "("
                                            + strNextID + ", '"
                                            + name + "', '"
                                            + description + "', '"
                                            + vendor + "', '"
                                            + condition + "', "
                                            + quantity + ", "
                                            + price
                                + ")";


                //MessageBox.Show(strQuery);

                // Insert into the database
                Utils.InsertData(strQuery);

                // Check if the Insert was successful
                if (Utils.IsSuccessful())
                {
                    MessageBox.Show("Inventory added successfully!",
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utils.ClearAllText(this);

                }
                else
                {
                    MessageBox.Show("Adding Inventory was not successful!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } //end of validation

        } //end of method
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
                btnAdd.PerformClick();
            }
        }
        #endregion

        #region DELETE INVENTORY ITEM
        /// <summary>
        /// If there are more than 0 items in the grid
        ///     -- Get the rows checked
        ///     -- If checked rows > 0
        ///         -- Put each checked rows Part_ID into a String
        ///     -- Confirm if the user want to delete the items selected
        ///     -- Display successful message or error message
        ///     -- Bind the data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String ListOfIDsSelected = "";

            // Check if the row count is at least 1
            if (dgvListInventory.Rows.Count > 0)
            {
                // Get the rows checked
                RowsChecked();

                // Check if the ArrayList has any items             
                if (TotalRowsChecked > 0)
                {
                    // Get the Part_ID for each checked rows
                    foreach (String s in aList)
                    {
                        ListOfIDsSelected += s + ", ";
                    }

                    // Get rid of the last "," comma and extra space
                    ListOfIDsSelected = ListOfIDsSelected.Substring(0, ListOfIDsSelected.Length - 2);

                    DialogResult dr = MessageBox.Show("Do you want to delete inventory item(s) " + ListOfIDsSelected,
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        String query = "DELETE FROM Parts " +
                                                "WHERE Part_ID " +
                                                            "IN (" + ListOfIDsSelected + ")";
                        // Delete the items
                        Utils.UpdateData(query);

                        if (Utils.IsSuccessful())
                        {
                            dgvListInventory.DataSource = null;
                            //re bind grid and fill from database again
                            BindGrid();
                            dgvListInventory.Refresh();

                            // Display successful message
                            MessageBox.Show("Items deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Item deletion was not successfull!");
                        }
                    } // end of delete confirmation
                }
                else
                {
                    MessageBox.Show("Please select at least 1 item!");
                }
            }
        }
        #endregion

        #region LOAD DATA GRID WHEN THE TAB IS CHANGED
        /// <summary>
        /// Bind data every time tab is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            BindGrid();
        }
        #endregion

        #region DATA GRID LOADER
        /// <summary>
        /// Loads inventory data grid
        /// </summary>
        private void BindGrid()
        {
            String status = StatusSelected();
            // MessageBox.Show(status);

            String strQuery = "SELECT Part_ID AS ID, "
                                    + "Part_Name AS Name, "
                                    + "Description, "
                                    + "Vendor, "
                                    + "TotalStock AS Quantity, "
                                    + "ShopPrice AS Price "
                            + "FROM Parts "+ status +" " 
                            + "ORDER BY Part_ID";
            Utils.ListingOnDataGrid(dgvListInventory, strQuery);
        }
        #endregion

        #region CHECK WHICH ROWS ARE CHECKED
        /// <summary>
        /// Find out which rows are checked
        /// For each checked rows, add it to a list
        /// and find out how many rows are checked
        /// </summary>
        private void RowsChecked()
        {
            DataGridViewCheckBoxCell oCell;
            aList = new ArrayList();
            TotalRowsChecked = 0;

            foreach (DataGridViewRow row in dgvListInventory.Rows)
            {
                oCell = row.Cells["Check"] as DataGridViewCheckBoxCell;
                bool bChecked = (null != oCell && null != oCell.Value && true == (bool)oCell.Value);
                if (true == bChecked)
                {
                    aList.Add(row.Cells[1].Value.ToString());
                    TotalRowsChecked++;
                }
            }
            aList.Sort();
        }
        #endregion

        #region GET THE ITEM TO BE AMENDED FROM THE GRID
        /// <summary>
        /// Get the item to be amended from the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAmend_Click(object sender, EventArgs e)
        {
            String ListOfIDsSelected = "";
            RowsChecked();

            if (TotalRowsChecked == 1)
            {
                // Get the Part_ID number
                foreach (String s in aList)
                {
                    ListOfIDsSelected = s;
                }

                // Make it accessible outside this method
                Id_Selected = ListOfIDsSelected;

                FillTextBoxes(ListOfIDsSelected);
                tabAmend.Enabled = true;
                tabControl.SelectedIndex = 2;
            }
            else if (TotalRowsChecked > 1)
            {
                // Get the Part_ID number
                foreach (String s in aList)
                {
                    ListOfIDsSelected += s + ", ";
                }

                ListOfIDsSelected = ListOfIDsSelected.Substring(0, ListOfIDsSelected.Length - 2);

                MessageBox.Show("Only one inventory item can be amended at a time. \nPlease make sure you only checked 1 item!" +
                                "\nCurrently you selected these items: " + ListOfIDsSelected + ".", 
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
                MessageBox.Show("Please select one item!",
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region FILLING THE TEXTBOXES WITH THE VALUES FROM DATABASE
        /// <summary>
        /// This method retrieves data from the database and assigns them to the appropriate text boxes
        /// </summary>
        /// <param name="Staff_ID"></param>
        private void FillTextBoxes(String Part_ID)
        {
            try
            {
                string oradb = Utils.OracleConnectionString();

                // Create an instance of an Oracle Command to be executed
                OracleConnection connect = new OracleConnection(oradb);

                string strQuery = "SELECT * FROM Parts WHERE Part_ID = " + Part_ID + "";
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

                    tbProductAmend.Text = dt.Rows[0]["PART_NAME"].ToString().Trim();
                    tbDescAmend.Text = dt.Rows[0]["DESCRIPTION"].ToString().Trim(); 
                    tbVendorAmend.Text = dt.Rows[0]["VENDOR"].ToString().Trim();

                    String condition = dt.Rows[0]["CONDITION"].ToString().Trim();
                    if (condition.Equals("New"))
                        rbNewAmend.Checked = true;
                    else if(condition.Equals("Used"))
                        rbUsedAmend.Checked = true;
                    else
                        rbRefurbAmend.Checked = true;

                    tbQuantityAmend.Text = dt.Rows[0]["TOTALSTOCK"].ToString().Trim();
                    tbPriceAmend.Text = dt.Rows[0]["SHOPPRICE"].ToString().Trim();

                }
                else
                {
                    System.Windows.MessageBox.Show("No data is found");
                }

                connect.Close();
            }
            catch (OracleException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region CLEAR ALL THE TEXT (Amend)
        /// <summary>
        /// Clears all the text from text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAmend_Click(object sender, EventArgs e)
        {
            Utils.ClearAllText(this);
        }
        #endregion

        #region AMEND INVENTORY ITEM
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAmendInventory_Click(object sender, EventArgs e)
        {
            if (IsValidTextBoxAmendTab())
            {
                // Uppercase the first letter in every words
                // Trim the trailing white spaces at the end
                string name = Utils.UppercaseFirstLetter(tbProductAmend.Text.Trim());
                string description = Utils.UppercaseFirstLetter(tbDescAmend.Text.Trim());
                string vendor = Utils.UppercaseFirstLetter(tbVendorAmend.Text.Trim());
                string condition = GetRadioButtonText(rbNewAmend, rbRefurbAmend).Trim();
                string quantity = tbQuantityAmend.Text.Trim();
                string price = tbPriceAmend.Text.Trim();


                string strQuery = "UPDATE Parts SET Part_Name ='" + name
                    + "', Description ='" + description + "', Vendor ='"
                    + vendor + "', Condition ='" + condition
                    + "', TotalStock = " + quantity + ", ShopPrice = '" + price
                    + "' WHERE Part_ID = " + Id_Selected + "";
                //MessageBox.Show(strQuery);

                Utils.UpdateData(strQuery);

                if (Utils.IsSuccessful())
                {
                    MessageBox.Show("Inventory item details amended successfully!", 
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tabControl.SelectedIndex = 1;
                    Utils.ClearAllText(this);
                    tabAmend.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Unfortunately, the system failed to amend the inventory item. Please enter your details correctly!", 
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region VALIDATING EVERYTHING IN THE FORM (Amend)
        /// <summary>
        /// This method validates the textbox entries and throws appropriate error messages to window
        /// </summary>
        /// <returns>Returns true if all the form entries are valid</returns>
        private Boolean IsValidTextBoxAmendTab()
        {
            Boolean IsValidEntry = true;

            // Product name should only be letters/numbers
            // One space between every words
            // No trailing spaces
            // Between 1-30 characters
            if (Utils.IsAlphaNumeric(tbProductAmend.Text) || (tbProductAmend.Text.Trim().Length < 1 || tbProductAmend.Text.Trim().Length > 40))
            {
                MessageBox.Show("Product is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters/numbers." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Between 1-40 characters." + "\n4) Only one space between words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbProductAmend.Focus();
                IsValidEntry = false;
            }
            // Description can only be alphanumeric
            // Between 1-500 characters
            else if (tbDescAmend.Text.Trim().Length < 1 || tbDescAmend.Text.Trim().Length > 500)
            {
                MessageBox.Show("Description is not valid, please make sure it matches these criteria: "
                    + "\n1) Should NOT start/end with space(s)"
                    + "\n2) Length is between 1-500 characters." + "\n3) Only one space between every words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDescAmend.Focus();
                IsValidEntry = false;
            }
            // Vendor name should only be letters
            // One space between every words
            // No trailing spaces
            // Between 1-50 characters
            else if (Utils.IsAllLetter(tbVendorAmend.Text) || (tbVendorAmend.Text.Trim().Length < 1 || tbVendorAmend.Text.Trim().Length > 50))
            {
                MessageBox.Show("Vendor is not valid, please make sure it matches these criteria: "
                    + "\n1) Should only contain letters." + "\n2) Should NOT start/end with space(s)"
                    + "\n3) Between 1-50 characters." + "\n4) Only one space between words.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbVendorAmend.Focus();
                IsValidEntry = false;

            }
            // Condition should be selected
            else if (!rbNewAmend.Checked && !rbRefurbAmend.Checked && !rbUsedAmend.Checked)
            {
                MessageBox.Show("Please select the condition of the product!",
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsValidEntry = false;
            }
            // Quantity can only be Integer value
            else if (!Utils.IsInt(tbQuantityAmend.Text.Trim()) || (tbQuantityAmend.Text.Trim().Length < 1 || tbQuantityAmend.Text.Trim().Length > 5))
            {
                MessageBox.Show("Quanity is not valid, please input a valid quantity! " +
                    "\na) It should only contains numbers. \nb) 1-5 digits only",
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbQuantityAmend.Focus();
                IsValidEntry = false;
            }
            // Price can only be Double value
            else if (!Utils.IsDouble(tbPriceAmend.Text.Trim()) || (tbPriceAmend.Text.Trim().Length < 1 || tbPriceAmend.Text.Trim().Length > 7))
            {
                MessageBox.Show("Price is not valid, please input a valid price! " +
                    "\na) It should only contains numbers. \nb) 9,2 number format",
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPriceAmend.Focus();
                IsValidEntry = false;
            }

            return IsValidEntry;
        }
        #endregion

        #region CHECK WHICH STATUS IS SELECTED
        /// <summary>
        /// Returns String value of the item selected
        /// </summary>
        /// <returns>item selected</returns>
        private String StatusSelected()
        {
            String condition = "";
            if (cbStatus.SelectedIndex == 0)
            {
                condition = "WHERE Condition = 'New'";
            }
            else if (cbStatus.SelectedIndex == 1)
            {
                condition = "WHERE Condition = 'Refurbished'";
            }
            else if (cbStatus.SelectedIndex == 2)
            {
                condition = "WHERE Condition = 'Used'";
            }
            else
            {
                condition = "WHERE Condition = 'Used' OR Condition = 'New' OR Condition = 'Refurbished'";
            }
            
            return condition;

        }
        #endregion

        #region SORT DATA BY NAME
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            String status = StatusSelected();
            
            String strQuery = "SELECT Part_ID AS ID, "
                                    + "Part_Name AS Name, "
                                    + "Description, "
                                    + "Vendor, "
                                    + "TotalStock AS Quantity, "
                                    + "ShopPrice AS Price "
                            + "FROM Parts "+ status +" "
                            + "ORDER BY Part_Name";

            Utils.ListingOnDataGrid(dgvListInventory, strQuery);
        }
        #endregion

        #region SORT DATA BY DESCRIPTION
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbDescription_CheckedChanged(object sender, EventArgs e)
        {
            String status = StatusSelected();

            String strQuery = "SELECT Part_ID AS ID, "
                                    + "Part_Name AS Name, "
                                    + "Description, "
                                    + "Vendor, "
                                    + "TotalStock AS Quantity, "
                                    + "ShopPrice AS Price "
                            + "FROM Parts " + status + " "
                            + "ORDER BY Description";

            Utils.ListingOnDataGrid(dgvListInventory, strQuery);
        }
        #endregion

        #region SORT DATA BY VENDOR
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbVendor_CheckedChanged(object sender, EventArgs e)
        {
            String status = StatusSelected();

            String strQuery = "SELECT Part_ID AS ID, "
                                    + "Part_Name AS Name, "
                                    + "Description, "
                                    + "Vendor, "
                                    + "TotalStock AS Quantity, "
                                    + "ShopPrice AS Price "
                            + "FROM Parts " + status + " "
                            + "ORDER BY Vendor";

            Utils.ListingOnDataGrid(dgvListInventory, strQuery);
        }
        #endregion

        #region SORT DATA BY QUANTITTY
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbQuantity_CheckedChanged(object sender, EventArgs e)
        {
            String status = StatusSelected();

            String strQuery = "SELECT Part_ID AS ID, "
                                    + "Part_Name AS Name, "
                                    + "Description, "
                                    + "Vendor, "
                                    + "TotalStock AS Quantity, "
                                    + "ShopPrice AS Price "
                            + "FROM Parts " + status + " "
                            + "ORDER BY TotalStock";

            Utils.ListingOnDataGrid(dgvListInventory, strQuery);

        }
        #endregion

        #region SORT DATA BY PRICE
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbPrice_CheckedChanged(object sender, EventArgs e)
        {
            String status = StatusSelected();

            String strQuery = "SELECT Part_ID AS ID, "
                                    + "Part_Name AS Name, "
                                    + "Description, "
                                    + "Vendor, "
                                    + "TotalStock AS Quantity, "
                                    + "ShopPrice AS Price "
                            + "FROM Parts " + status + " "
                            + "ORDER BY ShopPrice";

            Utils.ListingOnDataGrid(dgvListInventory, strQuery);
        }
        #endregion

        #region DE-SELECT THE RADIO BUTTONS ON COMBO BUTTON CHANGE
        /// <summary>
        /// THIS METHOD DE-SELECTS THE RADIO BUTTONS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            var cntls = GetAll(this, typeof(RadioButton));
            foreach (Control cntrl in cntls)
            {
                RadioButton _rb = (RadioButton)cntrl;
                if (_rb.Checked)
                {
                    _rb.Checked = false;

                }
            }
        }

        /// <summary>
        /// THIS METHOD GETS ALL THE RADIO BUTTON IN THE FORM
        /// </summary>
        /// <param name="control"></param>
        /// <param name="type"></param>
        /// <returns>RETURNS THE RADIO BUTTONS</returns>
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }
        #endregion

        #region SORT DATA ON STATUS CHANGES
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListInventory.DataSource = null;
            //re bind grid and fill from database again
            //BindGrid();
            String status = StatusSelected();

            String strQuery = "SELECT Part_ID AS ID, "
                                    + "Part_Name AS Name, "
                                    + "Description, "
                                    + "Vendor, "
                                    + "TotalStock AS Quantity, "
                                    + "ShopPrice AS Price "
                            + "FROM Parts " + status + " "
                            + "ORDER BY Part_ID";

            Utils.ListingOnDataGrid(dgvListInventory, strQuery);

            dgvListInventory.Refresh();
        }
        #endregion

        ///
        /// <summary>
        /// PRINT OUT START
        /// </summary>
        ///

        #region HANDLES THE PRINT BUTTON CLICK EVENT
        /// <summary>
        /// Handles the print button click event
        /// Asks the user to Preview or Print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print.PrintButtonClickEvent(printDocument, "Items listing from DataGridView");

        }
        #endregion

        #region HANDLES THE PRINT PAGE EVENT
        /// <summary>
        /// Handles the print page event of print document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Print.PrintPageEvent(dgvListInventory, e, "INVENTORY ITEMS LISTING");
        }
        #endregion

        #region HANDLES THE BEGIN PRINT EVENT
        /// <summary>
        /// Handles the begin print event of print document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Print.BeginPrintEventHandler(dgvListInventory);
        }
        #endregion


    } //end of class
}

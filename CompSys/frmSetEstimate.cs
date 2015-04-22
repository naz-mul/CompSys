using System;
using System.Collections;
using System.Data;
using System.Data.OracleClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmSetEstimate : Form
    {

        #region GLOBAL VARIABLES

        private int ItemExistRowIndex;
        private ListViewItem item;

        private int TotalRowsChecked;
        private String Id_Selected;
        private ArrayList aList;

        #endregion

        #region LOAD FORM
        /// <summary>
        /// 
        /// </summary>
        public frmSetEstimate()
        {
            InitializeComponent();

        }
        #endregion

        #region LOAD DEFAULTS
        /// <summary>
        /// Load data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSetEstimate_Load(object sender, EventArgs e)
        {
            // Remove Set Estimate Tab
            tabSetEstimate.TabPages.Remove(tabSet);

            // Bind data grid view
            BindGrid("New", "r.repairdate");

            //
            // Generate auto complete list from the database for FIRSTNAME
            //
            string queryPartname = "SELECT * FROM Parts WHERE Part_Name LIKE '%"
                                                                + Utils.UppercaseFirstLetter(tbPartSearch.Text.Trim()) + "%'"
                                                                + " AND TotalStock > 0 ";
            tbPartSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbPartSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPartSearch.AutoCompleteCustomSource = Utils.AutoComplete(tbPartSearch, queryPartname, "Part_Name");

            //
            // Generate auto complete list from the database for LASTNAME
            //
            string queryDescription = "SELECT * FROM Parts WHERE Description LIKE '%"
                + Utils.UppercaseFirstLetter(tbDescSearch.Text.Trim())
                + "%' AND TotalStock > 0";

            tbDescSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbDescSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbDescSearch.AutoCompleteCustomSource = Utils.AutoComplete(tbDescSearch, queryDescription, "Description");

        }
        #endregion

        #region DATA GRID BINDER
        /// <summary>
        /// Bind data into the data grid
        /// </summary>
        /// <param name="status">Repair status</param>
        /// <param name="orderby">Order by</param>
        private void BindGrid(string status, string orderby)
        {
            string strQuery =
                "SELECT r.rep_id      AS ID, " +
                       "c.surname     AS Customer, " +
                       "r.description AS Problem, " +
                       "r.devicetype  AS Device, " +
                       "r.model, " +
                       "TO_CHAR(r.repairdate, 'DD/MM/YYYY') AS RepDate " +
                "FROM repairs r " +
                "JOIN customers c " +
                    "ON r.cust_id = c.cust_id " +
                "WHERE  r.status = '" + status + "' " +
                "ORDER  BY " + orderby;

            Utils.ListingOnDataGrid(dgvListRepairs, strQuery);
        }
        #endregion

        #region MOVE TO NEXT TEXTBOX WHEN PRESSING THE ENTER BUTTON
        /// <summary>
        /// Moves to the next textbox when enter button is pressed
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

        #region PRINTING OUT
        private void printRepairJobs_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Print.PrintPageEvent(dgvListRepairs, e, "REPAIRS LISTING");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print.PrintButtonClickEvent(printRepairJobs, "Repairs listing from DataGridView");
        }

        private void printRepairJobs_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Print.BeginPrintEventHandler(dgvListRepairs);
        }
        #endregion

        #region ADD BUTTON - NEW ITEM INTO THE LISTBOX
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (Utils.IsInt(tbQuantity.Text.Trim()))
            {
                int QuantityAvailable = Convert.ToInt32(tbQtyAvailable.Text.Trim());
                int QuantityNeeded = Convert.ToInt32(tbQuantity.Text.Trim());

                if (QuantityAvailable >= QuantityNeeded)
                {
                    if (IsItemAlreadyExist())
                    {
                        //MessageBox.Show("Item already exist");

                        DialogResult dr = MessageBox.Show("Item already exists, do you want to add more?"
                            , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dr == DialogResult.Yes)
                        {
                            // Get the current quantity from the listbox
                            int qtyListBox = Convert.ToInt32(listViewBox.Items[ItemExistRowIndex].SubItems[2].Text);
                            // Get the extra quantity from the textbox
                            int qtyTextBox = Convert.ToInt32(tbQuantity.Text.Trim());
                            // Add the total
                            int totalQuantity = qtyListBox + qtyTextBox;

                            if (QuantityAvailable >= totalQuantity)
                            {
                                // Get the current price from the listbox
                                double priceListBox = Convert.ToDouble(listViewBox.Items[ItemExistRowIndex].SubItems[3].Text);
                                double priceTextBox = Convert.ToDouble(tbPrice.Text.Trim());
                                double totalPrice = priceListBox + priceTextBox * qtyTextBox;

                                // Update as required
                                UpdateListViewValue(listViewBox, ItemExistRowIndex, 2, totalQuantity.ToString());
                                UpdateListViewValue(listViewBox, ItemExistRowIndex, 3, totalPrice.ToString());

                                // Add it to the sub-total
                                //SubTotal = totalPrice;

                                // Change sub-total value
                                tbSubtotal.Text = GetSubTotal();
                            }
                            else
                            {
                                MessageBox.Show("Quantity should be less than or equal to the available quantity!");
                            }
                            // end of inner quantitity validation


                        }
                    }
                    else
                    {
                        // Add new item to the listbox
                        AddToListBox();
                        // Change sub-total value
                        tbSubtotal.Text = GetSubTotal();
                    }
                    // end of item exist check validation


                }
                else
                {
                    MessageBox.Show("Quantity should be less than or equal to the available quantity!");
                }
                // end of outer quantity validation


            }
            else
            {
                MessageBox.Show("Quantity should be an integer!");
            }
            // end of textbox validation
        }
        #endregion

        #region NEW ITEM GENERATOR
        /// <summary>
        /// 
        /// </summary>
        private void AddToListBox()
        {
            item = new ListViewItem(tbPartID.Text.Trim());
            item.SubItems.Add(tbPartName.Text.Trim());
            item.SubItems.Add(tbQuantity.Text.Trim());

            int quantity = Convert.ToInt32(tbQuantity.Text);
            double price = Convert.ToDouble(tbPrice.Text);
            double total = price * quantity;

            item.SubItems.Add(total.ToString());

            listViewBox.Items.AddRange(new ListViewItem[] { item });

            // Add it to the sub-total
            //SubTotal = total;
        }
        #endregion

        #region CHECK IF ITEM ALREADY EXIST IN THE LISTBOX
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns true if exist</returns>
        private bool IsItemAlreadyExist()
        {
            for (int i = 0; i < listViewBox.Items.Count; i++)
            {

                //MessageBox.Show(listViewBox.Items[i].Text);
                if (listViewBox.Items[i].Text.Equals(tbPartID.Text.Trim()))
                {
                    ItemExistRowIndex = i;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region UPDATE LISTBOX ITEMS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listView">listbox to update</param>
        /// <param name="row">index of the row the item already exists</param>
        /// <param name="column">column index to change</param>
        /// <param name="newValue">value of the new item</param>
        private void UpdateListViewValue(ListView listView, int row, int column, string newValue)
        {
            if (column >= listView.Columns.Count)
                throw new InvalidOperationException("Cannot modify outside column bounds");
            ListViewItem item;
            if (row < listView.Items.Count)
                item = listView.Items[row];
            else
            {
                item = new ListViewItem();
                for (int i = 1; i < listView.Columns.Count; ++i)
                    item.SubItems.Add(new ListViewItem.ListViewSubItem());
                listView.Items.Add(item);
            }
            item.SubItems[column].Text = newValue;
        }
        #endregion

        #region REMOVE SELECTED ITEMS FROM THE TEXT BOX
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listViewBox.Items)
            {
                if (item.Checked)
                    listViewBox.Items.RemoveAt(item.Index);
            }

            tbSubtotal.Text = "";
            tbTotal.Text = "";
        }
        #endregion

        #region SEARCH FOR INVENTORY ITEM
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbDescSearch.Text.Trim()) && !String.IsNullOrEmpty(tbPartSearch.Text.Trim()))
            {
                FillTextBoxes();
            }
            else
                MessageBox.Show("Please enter part name and description to continue!");

        }
        #endregion

        #region FILLING THE TEXTBOXES WITH THE VALUES FROM DATABASE
        /// <summary>
        /// This method retrieves data from the database and assigns them to the appropriate text boxes
        /// </summary>
        /// <param name="Staff_ID"></param>
        private void FillTextBoxes()
        {
            try
            {
                string oradb = Utils.OracleConnectionString();

                // Create an instance of an Oracle Command to be executed
                OracleConnection connect = new OracleConnection(oradb);

                string strQuery = "SELECT * FROM Parts WHERE Part_Name = '"
                                                         + Utils.UppercaseFirstLetter(tbPartSearch.Text.Trim())
                                                         + "' AND Description = '"
                                                         + Utils.UppercaseFirstLetter(tbDescSearch.Text.Trim())
                                                         + "' AND TotalStock > 0 ";
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

                    tbPartName.Text = dt.Rows[0]["PART_NAME"].ToString().Trim();
                    tbPartID.Text = dt.Rows[0]["PART_ID"].ToString().Trim();
                    tbPrice.Text = dt.Rows[0]["SHOPPRICE"].ToString().Trim();
                    tbQtyAvailable.Text = dt.Rows[0]["TOTALSTOCK"].ToString().Trim();

                    // Display the Add Inventory group box
                    gbFoundInventory.Visible = true;
                }
                else
                {
                    // Hide add items to the listbox group box
                    gbFoundInventory.Visible = false;

                    System.Windows.MessageBox.Show("Part was not found!");

                    // Clear textboxes
                    tbPartName.Text = "";
                    tbPartID.Text = "";
                    tbPrice.Text = "";
                    tbQtyAvailable.Text = "";
                    tbQuantity.Text = "";
                }

                connect.Close();
            }
            catch (OracleException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region HIDE FOUND INVENTORY GROUPBOX
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPartSearch_TextChanged(object sender, EventArgs e)
        {
            gbFoundInventory.Visible = false;

            // Clear textboxes
            tbPartName.Text = "";
            tbPartID.Text = "";
            tbPrice.Text = "";
            tbQtyAvailable.Text = "";
            tbQuantity.Text = "";
        }
        #endregion

        #region GET SUB-TOTAL
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private String GetSubTotal()
        {
            int i = 0;
            double result = 0;
            while (i < listViewBox.Items.Count)
            {
                result += Convert.ToDouble(listViewBox.Items[i++].SubItems[3].Text);
            }

            return Convert.ToString(result); ;
        }
        #endregion

        #region CALCULATE TOTAL COST
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean IsDiscountVatEmpty = true;

            // Check if VAT and Discount text boxes are empty
            if (!String.IsNullOrEmpty(tbVat.Text.Trim()) && !String.IsNullOrEmpty(tbDiscount.Text.Trim()))
                IsDiscountVatEmpty = false;


            //MessageBox.Show(IsDiscountVatEmpty.ToString());

            if (!IsDiscountVatEmpty) // If VAT and Discount is added
            {
                if (Utils.IsDouble(tbDiscount.Text.Trim()) && Utils.IsDouble(tbVat.Text.Trim()))
                {
                    double subtotal = Convert.ToDouble(GetSubTotal());
                    double vat = Convert.ToDouble(tbVat.Text.Trim());
                    double discount = Convert.ToDouble(tbDiscount.Text.Trim());
                    double vatinclusive = (subtotal * (vat / 100)) + subtotal;
                    // Set it to the total
                    if (!tbSubtotal.Text.Equals(""))
                        tbTotal.Text = Convert.ToString(vatinclusive - discount);

                }
                else
                    MessageBox.Show("VAT and Discount should be number only!");

            }
            else
            {
                if (!String.IsNullOrEmpty(tbDiscount.Text.Trim())
                    && String.IsNullOrEmpty(tbVat.Text.Trim())) // If vat is not added
                {
                    if (Utils.IsDouble(tbDiscount.Text.Trim()))
                    {
                        double subtotal = Convert.ToDouble(GetSubTotal());
                        double discount = Convert.ToDouble(tbDiscount.Text.Trim());
                        // Set it to the total
                        if (!tbSubtotal.Text.Equals(""))
                            tbTotal.Text = Convert.ToString(subtotal - discount);

                    }
                    else
                        MessageBox.Show("Discount should be number only!");

                }
                else if (!String.IsNullOrEmpty(tbVat.Text.Trim())
                            && String.IsNullOrEmpty(tbDiscount.Text.Trim())) // if discount is not added
                {
                    if (Utils.IsDouble(tbVat.Text.Trim()))
                    {
                        double subtotal = Convert.ToDouble(GetSubTotal());
                        double vat = Convert.ToDouble(tbVat.Text.Trim());
                        // Set it to the total
                        if (!tbSubtotal.Text.Equals(""))
                            tbTotal.Text = Convert.ToString(((subtotal * (vat / 100)) + subtotal));

                    }
                    else
                        MessageBox.Show("VAT should be number only!");
                }
                else
                {
                    if (!tbSubtotal.Text.Equals(""))
                        tbTotal.Text = GetSubTotal();
                }
            }
        }
        #endregion

        #region TEXTBOX TEXTCHANGED

        private void tbSubtotal_TextChanged(object sender, EventArgs e)
        {
            tbTotal.Text = "";
        }

        private void tbVat_TextChanged(object sender, EventArgs e)
        {
            tbTotal.Text = "";
        }

        private void tbDiscount_TextChanged(object sender, EventArgs e)
        {
            tbTotal.Text = "";
        }
        #endregion

        #region CHOOSE REPAIR JOB
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstimate_Click(object sender, EventArgs e)
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

                tabSetEstimate.TabPages.Remove(tabRepairs);
                tabSetEstimate.TabPages.Insert(0, tabSet);
                tabSetEstimate.SelectedTab = tabSet;
            }
            else if (TotalRowsChecked > 1)
            {
                // Get the Part_ID number
                foreach (String s in aList)
                {
                    ListOfIDsSelected += s + ", ";
                }

                ListOfIDsSelected = ListOfIDsSelected.Substring(0, ListOfIDsSelected.Length - 2);

                MessageBox.Show("Only one repair job can be estimated at a time. \nPlease make sure you only checked ONE job only!" +
                                "\nCurrently you selected these items: " + ListOfIDsSelected + ".",
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select a repair job to continue!",
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            foreach (DataGridViewRow row in dgvListRepairs.Rows)
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

        #region SET ESTIMATE
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetEstimate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbTotal.Text.Trim()))
            {
                // Get Staff ID
                String strQueryStaff = "SELECT * FROM Staff WHERE username = '" + frmLogin.username + "'";
                String strStaffID = Utils.GetSingleValue(strQueryStaff, "Staff_ID");

                OracleTransaction transaction = null;
                OracleConnection con = null;

                // they will be used to decide whether to commit or rollback the transaction
                bool debitResult = false;
                bool creditResult = false;

                try
                {
                    con = new OracleConnection(Utils.OracleConnectionString());
                    con.Open();

                    // lets begin a transaction here
                    transaction = con.BeginTransaction();

                    // Let us do a debit first
                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;

                        //Check if VAT / Discount is empty
                        if (tbDiscount.Text.Equals(""))
                            tbDiscount.Text = "0";
                        if (tbVat.Text.Equals(""))
                            tbVat.Text = "0.00";

                        String queryEstimates = "INSERT INTO Estimates (Rep_ID, Staff_ID, VAT, Discount, Total) " +
                                                "VALUES (" + Id_Selected + ", "
                                                           + strStaffID + ", "
                                                           + tbVat.Text.Trim() + ", "
                                                           + tbDiscount.Text.Trim() + ", "
                                                           + tbTotal.Text.Trim()
                                                           + ")";

                        cmd.CommandText = queryEstimates;   // Query here

                        // assosiate this command with transaction
                        cmd.Transaction = transaction;

                        debitResult = cmd.ExecuteNonQuery() == 1;
                    }

                    // And now do a credit
                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;

                        for (int i = 0; i < listViewBox.Items.Count; i++)
                        {
                            String InsertEstPartsQuery = "INSERT INTO EstParts VALUES ("
                                                                + Id_Selected + ", "
                                                                + listViewBox.Items[i].SubItems[0].Text + ", "
                                                                + listViewBox.Items[i].SubItems[2].Text + ", "
                                                                + listViewBox.Items[i].SubItems[3].Text + ")";

                            cmd.CommandText = InsertEstPartsQuery;   // Query here

                            // assosiate this command with transaction
                            cmd.Transaction = transaction;

                            creditResult = cmd.ExecuteNonQuery() == 1;
                        }
                    }

                    if (debitResult && creditResult)
                    {
                        transaction.Commit();

                        // Update parts quantity
                        for (int i = 0; i < listViewBox.Items.Count; i++)
                        {
                            // Get Part ID
                            String strQueryPart = "SELECT * FROM Parts WHERE Part_ID = " + listViewBox.Items[i].SubItems[0].Text;
                            String strPartID = Utils.GetSingleValue(strQueryPart, "TotalStock");
                            int NewTotalStock = Convert.ToInt32(strPartID.Trim()) - Convert.ToInt32(listViewBox.Items[i].SubItems[2].Text);

                            String UpdatePartsQuery = "UPDATE Parts SET TotalStock = " + NewTotalStock
                                                                + " WHERE Part_ID = " + listViewBox.Items[i].SubItems[0].Text;

                            Utils.UpdateData(UpdatePartsQuery);

                        }

                        // Update Repairs status
                        String UpdateRepairsQuery = "UPDATE Repairs SET Status = 'Estimated'"
                                                                + " WHERE Rep_ID = " + Id_Selected;
                        Utils.UpdateData(UpdateRepairsQuery);

                        // Email confirmation message
                        EmailConfirmation();

                        DialogResult dr = MessageBox.Show("Estimate assigned successfully!\nDo you want to add another one?",
                            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dr == DialogResult.Yes)
                        {
                            // Clear everything
                            Utils.ClearAllText(this);

                            // Remove the tabs
                            tabSetEstimate.TabPages.Remove(tabSet);

                            // Bind Grid
                            dgvListRepairs.DataSource = null;
                            BindGrid("New", "r.repairdate");
                            dgvListRepairs.Refresh();

                            // Go back to the start
                            tabSetEstimate.TabPages.Insert(0, tabRepairs);
                            tabSetEstimate.SelectedTab = tabRepairs;

                            //hide/show back buttons
                            this.btnBack.Visible = true;
                            //this.btnBack2.Visible = false;

                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }

                catch (OracleException ex)
                {
                    MessageBox.Show("This repair may already have estimate assigned to it!\n" + ex.Message);
                }
                catch
                {
                    transaction.Rollback();
                }
                finally
                {
                    con.Close();
                }

            }
            else
                MessageBox.Show("Please add items onto the basket before setting an estimate."
                    + "\nIf you already have items in the basket, please make sure to get the total price (by clicking the total button).");
        }
        #endregion

        #region EMAIL CONFIRMATION MESSAGE
        /// <summary>
        /// 
        /// </summary>
        private void EmailConfirmation()
        {
            String NewEmail = "";

            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("t00152975softwareproject@gmail.com");

                // Get the rows checked - customer id numbers
                RowsChecked();


                NewEmail = GetEmailAddress(StringQuery(Id_Selected));
                message.To.Add(new MailAddress(NewEmail));
                message.To.Add(new MailAddress("Nazmul.Alam@students.ittralee.ie"));
                //message.To.Add(new MailAddress("Catherine.Woods@staff.ittralee.ie"));

                message.Subject = "CompuRite: your device is estimated";

                String EmailItemsBody = "";
                for (int i = 0; i < listViewBox.Items.Count; i++)
                {

                    EmailItemsBody += String.Format("\n{0,-9} ¦ {1,-40} ¦ {2,-5} ¦ {3,6}",
                                                    listViewBox.Items[i].SubItems[0].Text,
                                                    listViewBox.Items[i].SubItems[1].Text,
                                                    listViewBox.Items[i].SubItems[2].Text,
                                                    listViewBox.Items[i].SubItems[3].Text);

                }

                message.Body = "Dear CompuRite Customer, "
                                + "\nWe are very happy to confirm a member of our Technical Team have successfully assigned an estimate for your device."
                                + "\n\nPlease reply to this email if you want to confirm with the repair.\n\n\n"
                                + "---------------------------------------------------------------------\n"
                                + String.Format("{0,-9} ¦ {1,-40} ¦ {2,-5} ¦ {3,6}", "ID", "Part Name", "Qty", "Price")
                                + "\n---------------------------------------------------------------------"
                                + EmailItemsBody + "\n"
                                + "---------------------------------------------------------------------\n"
                                + "VAT(%) " + tbVat.Text + "    Discount: €" + tbDiscount.Text + "  Total Cost: €" + tbTotal.Text // 60 - 19
                                + "\n---------------------------------------------------------------------\n"
                                + "\n\n\nRegards, "
                                + "\n\nTechnical Staff";


                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("t00152975softwareproject@gmail.com", "catherinewoods");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unfortunately, sending email to the customer(s) was not successfull." +
                    "Please fix these errors: " + ex.Message);
            }
        }
        #endregion

        #region GETS EMAIL ADDRESS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSQL">Oracle DB Query</param>
        /// <returns>string output of the email</returns>
        public static String GetEmailAddress(String strSQL)
        {
            String Email = "";

            try
            {
                //Define database connection string
                String oradb = Utils.OracleConnectionString();

                //Create Oracle connection
                OracleConnection conn = new OracleConnection(oradb);

                //Define SQL query
                //String strSQL = "SELECT MAX(Cust_ID) FROM Customers";

                //Define Oracle command
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                // Specify that the command type is a string
                cmd.CommandType = CommandType.Text;

                // Check if the connection is alive
                if (conn.State != ConnectionState.Open)
                    conn.Open();

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
                    Email = dt.Rows[0]["EMAIL"].ToString().Trim();
                }

                //Close DB connection
                conn.Close();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
            }

            return Email;
        }
        #endregion

        #region ORACLE STRING QUERY
        /// <summary>
        /// 
        /// </summary>
        /// <param name="RepID"></param>
        /// <returns></returns>
        private String StringQuery(String RepID)
        {
            String strQuery = "SELECT c.email "
                            + "FROM Repairs r "
                            + "JOIN Customers c "
                            + "ON r.cust_id = c.cust_id "
                            + "WHERE r.rep_id = " + RepID;

            return strQuery;
        }
        #endregion

        #region SORT BY REPAIR ID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("New", "r.rep_id");
        }
        #endregion

        #region SORT BY CUSTOMER NAME
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("New", "c.surname");
        }
        #endregion

        #region SORT BY DESCRIPTION
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbProb_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("New", "r.description");
        }
        #endregion

        #region SORT BY DEVICE TYPE
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbDevice_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("New", "r.devicetype");
        }
        #endregion

        #region SORT BY MODEL
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbModel_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("New", "r.model");
        }
        #endregion

        #region SORT BY REPAIR DATE
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbRepDate_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("New", "r.repairdate");
        }
        #endregion

    }
}

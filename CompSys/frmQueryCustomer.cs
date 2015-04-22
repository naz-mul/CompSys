using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmQueryCustomer : Form
    {
        #region GLOBAL VARIABLES

        private string ID_Choosen;
        private string surname;
        private string forename;
        private string dob;
        private string ad1;
        private string ad2;
        private string town;
        private string county;
        private string tel;
        private string email;
        private string regdate;
        private string strInvoices;
        private string strInvoiced;
        private string strPaid;

        private string constr;
        private OracleConnection con;
        private OracleCommand com;
        private ToolTip tooltip = new ToolTip();

        private Boolean IsRepairPeriodChanged = false;
        private Boolean IsEstimatePeriodChanged = false;
        private string fromDate;
        private string toDate;

        private Boolean IsEstimatePrintButtonClicked = false;

        #endregion

        #region INITIALIZE THE FORM WITH AUTO-COMPLETE SUGGESTS
        /// <summary>
        /// Populate auto-complete suggestions from the database
        /// </summary>
        public frmQueryCustomer()
        {
            InitializeComponent();

            //
            // Generate auto complete list from the database for FIRSTNAME
            //
            string queryFirstname = "SELECT * FROM Customers WHERE forename LIKE '%" + tbFirstname.Text.Trim() + "%' AND Status = 'A'";
            tbFirstname.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbFirstname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbFirstname.AutoCompleteCustomSource = Utils.AutoComplete(tbFirstname, queryFirstname, "forename");

            //
            // Generate auto complete list from the database for LASTNAME
            //
            string queryLastname = "SELECT * FROM Customers WHERE surname LIKE '%" + tbSurname.Text.Trim() + "%' AND Status = 'A'";
            tbSurname.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbSurname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbSurname.AutoCompleteCustomSource = Utils.AutoComplete(tbFirstname, queryLastname, "surname");

            //
            // Generate auto complete list from the database for TOWN
            //
            string queryTown = "SELECT * FROM Customers WHERE town LIKE '%" + tbTown.Text.Trim() + "%' AND Status = 'A'";
            tbTown.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbTown.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbTown.AutoCompleteCustomSource = Utils.AutoComplete(tbTown, queryTown, "town");

        }
        #endregion

        #region LOAD DEFAULTS
        /// <summary>
        /// Focuses onto the first textbox
        /// Removes tabs
        /// Sets Min and Max dates for DateTimePicker
        /// Sets default combo box item to 'New'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQueryCustomer_Load(object sender, EventArgs e)
        {
            // Focus input to Firstname textbox
            tbFirstname.Select();
            // Remove unnecessary tabs
            tabQueryCust.TabPages.Remove(chooseTab);
            tabQueryCust.TabPages.Remove(custTab);
            tabQueryCust.TabPages.Remove(repairTab);
            tabQueryCust.TabPages.Remove(estTab);
            // Set Max and Min Date for DateTimePicker in Repairs Tab
            dtFromRepairs.MinDate = DateTime.Now.AddYears(-50);
            dtFromRepairs.MaxDate = DateTime.Today;
            dtToRepairs.MinDate = DateTime.Now.AddYears(-50);
            dtToRepairs.MaxDate = DateTime.Today;
            // Set Max and Min Date for DateTimePicker in Repairs Tab
            dtFromEstimates.MinDate = DateTime.Now.AddYears(-50);
            dtFromEstimates.MaxDate = DateTime.Today;
            dtToEstimates.MinDate = DateTime.Now.AddYears(-50);
            dtToEstimates.MaxDate = DateTime.Today;
            // Set default combo box for repair tab
            cbStatus.SelectedIndex = cbStatus.Items.IndexOf("New");

        }
        #endregion

        #region ORACLE CONNECTION
        /// <summary>
        /// This method is used to connect to the database
        /// </summary>
        private void connection()
        {
            constr = Utils.OracleConnectionString();
            con = new OracleConnection(constr);
            con.Open();

        }
        #endregion

        #region PIE CHART DATA LOADER
        /// <summary>
        /// Binds data from the database
        /// Retrives yearly data from the Total_Repairs View
        /// Displays the data on a pie chart
        /// </summary>
        private void Bindchart()
        {
            try
            {
                connection();
                string strQuery = "SELECT Status, COUNT(*) AS Total FROM Repairs WHERE Cust_ID = " + ID_Choosen + " GROUP BY Status ORDER BY Status";
                com = new OracleCommand(strQuery, con);
                com.CommandType = CommandType.Text;
                OracleDataAdapter da = new OracleDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataTable ChartData = ds.Tables[0];

                //storing total rows count to loop on each Record  
                string[] XPointMember = new string[ChartData.Rows.Count];
                int[] YPointMember = new int[ChartData.Rows.Count];

                for (int count = 0; count < ChartData.Rows.Count; count++)
                {
                    //storing Values for X axis  
                    XPointMember[count] = ChartData.Rows[count]["Status"].ToString();
                    //storing values for Y Axis  
                    YPointMember[count] = Convert.ToInt32(ChartData.Rows[count]["Total"]);

                }
                //binding chart control  
                chartQueryCust.Series[0].Points.DataBindXY(XPointMember, YPointMember);

                /*// Disable labels on the chart
                for (var i = 0; i < chartMain.Series.Count; i++)
                    for (var j = 0; j < chartMain.Series[i].Points.Count; j++)
                        chartMain.Series[i].Points[j]["PieLabelStyle"] = "Disabled"; */

                //Show YValue on the chart only
                chartQueryCust.Series[0].IsValueShownAsLabel = true;

                //Hide Xvalue
                //chartMain.Series[0].LegendText = "#VALY";

                //Show ToolTip
                chartQueryCust.Series[0].ToolTip = "#VALX";

                con.Close();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region QUERY CUSTOMER
        /// <summary>
        /// Removes query customer tab
        /// Inserts Choose Tab
        /// Queries if the customer exists in the system
        /// -- Display unsuccessful message
        /// -- Return back to the query tab
        /// -- Clear textboxes before returning to the query tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryCust_Click(object sender, EventArgs e)
        {
            if (IsValidTextBox_QueryTab())
            {

                tabQueryCust.TabPages.Remove(queryTab); // Remove the query tab
                tabQueryCust.TabPages.Insert(0, chooseTab); // Insert the Customer List Tab
                tabQueryCust.SelectedTab = chooseTab; // Select the List Tab

                string strQuery = "SELECT Cust_ID AS ID, Surname, Forename, Town, Telephone AS Tel "
                    + "FROM Customers WHERE forename LIKE '%" + Utils.UppercaseFirstLetter(tbFirstname.Text.Trim())
                    + "%' AND surname LIKE '%" + Utils.UppercaseFirstLetter(tbSurname.Text.Trim())
                    + "%' AND town LIKE '%" + Utils.UppercaseFirstLetter(tbTown.Text.Trim()) + "%' AND Status = 'A'";

                Utils.ListingOnDataGrid(grdListCust, strQuery);

                //
                // If no data is found
                //
                if (!Utils.IsSuccessful())
                {
                    MessageBox.Show(tbFirstname.Text + " " + tbSurname.Text + " doesn't exist in our database. Press OK to continue...");
                    //this.btnBack2.Visible = false;
                    //this.btnBack1.Visible = true;
                    tabQueryCust.TabPages.Remove(chooseTab);
                    tabQueryCust.TabPages.Insert(0, queryTab);
                    tabQueryCust.SelectedTab = queryTab;
                    tbFirstname.Select();
                }
                //
                // Empty the text boxes
                //
                tbFirstname.Text = String.Empty;
                tbSurname.Text = String.Empty;
                tbTown.Text = String.Empty;
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
            Boolean IsValid = true;
            if (Utils.IsAllLetter(tbFirstname.Text) || (tbFirstname.Text.Trim().Length < 1 || tbFirstname.Text.Trim().Length > 30))
            {
                MessageBox.Show("Firstname should not be empty or contain digits!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFirstname.Focus();
                IsValid = false;
            }
            else if (Utils.IsAllLetter(tbSurname.Text) || (tbSurname.Text.Trim().Length < 1 || tbSurname.Text.Trim().Length > 30))
            {
                MessageBox.Show("Surname should not be empty or contain digits!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSurname.Focus();
                IsValid = false;
            }
            else if (Utils.IsAllLetter(tbTown.Text) || tbTown.Text.Trim().Length > 30)
            {
                MessageBox.Show("Town should not contain digits!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTown.Focus();
                IsValid = false;
            }
            return IsValid;
        }
        #endregion

        #region MOVE TO NEXT TEXTBOX WHEN PRESSING THE ENTER BUTTON
        protected override bool ProcessKeyPreview(ref Message m)
        {
            if (m.Msg == 0x0100 && (int)m.WParam == 13)
            {
                this.ProcessTabKey(true);
            }
            return base.ProcessKeyPreview(ref m);
        }
        #endregion

        #region SUBMISSION FROM THE LAST TEXTBOX on ENTER KEY
        /// <summary>
        /// Upon pressing enter key from the password textbox, this method submits the login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbTown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQueryCust.PerformClick();
            }
        }
        #endregion

        #region DISPLAY CUSTOMER INFORMATION
        /// <summary>
        /// Get customer id when id cell is clicked
        /// If the user wants to view the details of the customer
        /// Retrieve all the details from the system
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
                ID_Choosen = grdListCust.Rows[e.RowIndex].Cells[1].Value.ToString().Trim(); // Staff ID clicked
                string ln = grdListCust.Rows[e.RowIndex].Cells[2].Value.ToString().Trim(); // Lastname clicked
                string fn = grdListCust.Rows[e.RowIndex].Cells[3].Value.ToString().Trim(); // Firstname clicked

                DialogResult dr = MessageBox.Show("Do you want to view " + fn + " " + ln + "\'s details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    // Show Back Button
                    this.btnBack.Visible = true;
                    
                    // Bind chart data
                    Bindchart();

                    // Set label texts for invoices
                    RetrieveDataToInvoiceDetails(ID_Choosen);
                    this.invoice.Text = strInvoices;
                    this.invoiced.Text = strInvoiced;
                    this.balance.Text = strPaid;
                    
                    // Set the label text for customer details
                    RetrieveDataToCustomerDetails(ID_Choosen);
                    this.custTab.Text = fn + " " + ln;
                    this.lblDOB.Text = dob;
                    this.lblAd1.Text = ad1;
                    this.lblAd2.Text = ad2;
                    this.lblTown.Text = town;
                    this.lblCounty.Text = county;
                    this.lblTel.Text = tel;
                    this.lblEmail.Text = email;
                    this.lblReg.Text = regdate;

                    // Remove Choose Customer Tab
                    // Insert Other tabs
                    tabQueryCust.TabPages.Remove(chooseTab);
                    tabQueryCust.TabPages.Insert(0, custTab);
                    tabQueryCust.TabPages.Insert(1, repairTab);
                    tabQueryCust.TabPages.Insert(2, estTab);

                    //
                    // Fill up data in the Repairs DataGridView
                    //
                    string repQuery = "SELECT Rep_ID AS ID, Description AS Problem, DeviceType AS Device, Model, TO_CHAR(RepairDate, 'DD/MM/YYYY') AS Brought, TO_CHAR(CollectionDate, 'DD/MM/YYYY') AS Collected FROM Repairs WHERE Cust_ID = " + ID_Choosen + "";
                    Utils.ListingOnDataGrid(dgvRepairs, repQuery);

                    //
                    // Fill up data in the Estimates DataGridView
                    //
                    string estQuery = "SELECT e.Rep_ID AS ID, TO_CHAR(e.EstimateDate, 'DD/MM/YYYY') AS Estimated, e.Total FROM Estimates e JOIN Repairs r ON e.Rep_ID = r.Rep_ID LEFT JOIN Customers c ON c.cust_id = r.cust_id WHERE r.Cust_ID = " + ID_Choosen;
                    Utils.ListingOnDataGrid(dgvEstimates, estQuery);
                }
            }
        }
        #endregion

        #region SETTING CUSTOMER DETAILS
        /// <summary>
        /// This method retrieves data from the database and assigns them to the appropriate text boxes
        /// </summary>
        /// <param name="Cust_ID"></param>
        private void RetrieveDataToCustomerDetails(string Cust_ID)
        {
            try
            {
                string oradb = Utils.OracleConnectionString();

                // Create an instance of an Oracle Command to be executed
                OracleConnection connect = new OracleConnection(oradb);

                string strQuery = "SELECT forename, surname, TO_CHAR(dob, 'DD-MON-YYYY') AS dob, telephone, email, address1, address2, town, county, TO_CHAR(regdate, 'DD-MON-YYYY') AS regdate "
                    + "FROM Customers WHERE Cust_ID = " + Cust_ID + "";
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

                    forename = dt.Rows[0]["FORENAME"].ToString().Trim();
                    surname = dt.Rows[0]["SURNAME"].ToString().Trim();
                    dob = dt.Rows[0]["DOB"].ToString().Trim();
                    tel = dt.Rows[0]["TELEPHONE"].ToString().Trim();
                    email = dt.Rows[0]["EMAIL"].ToString().Trim();
                    ad1 = dt.Rows[0]["ADDRESS1"].ToString().Trim();
                    ad2 = dt.Rows[0]["ADDRESS2"].ToString().Trim();
                    town = dt.Rows[0]["TOWN"].ToString().Trim();
                    county = dt.Rows[0]["COUNTY"].ToString().Trim();
                    regdate = dt.Rows[0]["REGDATE"].ToString().Trim();
                }
                else
                {
                    System.Windows.MessageBox.Show("No repairs data is found");
                }

                connect.Close();
            }
            catch (OracleException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region SETTING INVOICE DETAILS
        /// <summary>
        /// This method retrieves data from the database and assigns them to the appropriate text boxes
        /// </summary>
        /// <param name="Cust_ID"></param>
        private void RetrieveDataToInvoiceDetails(string Cust_ID)
        {
            try
            {
                string oradb = Utils.OracleConnectionString();

                // Create an instance of an Oracle Command to be executed
                OracleConnection connect = new OracleConnection(oradb);

                String strQuery = "";
                strQuery += "SELECT r.status AS STATUS, COUNT(*) AS INVOICES, SUM(e.Total) AS INVOICED " + "\n";
                strQuery += "FROM estimates e JOIN repairs r " + "\n";
                strQuery += "ON e.rep_id = r.rep_id LEFT JOIN Customers c ON r.cust_id = c.cust_id " + "\n";
                strQuery += "WHERE r.cust_id = " + Cust_ID + " AND (r.status = 'Invoiced' OR r.status = 'Paid') " + "\n";
                strQuery += "GROUP BY r.status";

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
                    strInvoices = dt.Rows[1]["INVOICES"].ToString().Trim();
                    strInvoiced = "€";
                    strInvoiced += dt.Rows[1]["INVOICED"].ToString().Trim();
                    Double TotalPaid = Double.Parse(dt.Rows[1]["INVOICED"].ToString().Trim())
                        - Double.Parse(dt.Rows[0]["INVOICED"].ToString().Trim());
                    strPaid = "€";
                    strPaid += TotalPaid.ToString();
                }
                else
                {
                    System.Windows.MessageBox.Show("No estimate data is found");
                }

                connect.Close();
            }
            catch (OracleException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
        }
        #endregion

        ///
        /// <summary>
        /// SORTING DATA WHEN RADIO BOX IS CLICKED
        /// </summary>
        ///

        #region SORT BY COLLECTION DATE (Repairs)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbColDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ID_Choosen != null)
            {
                //string fromDate = dtFromRepairs.Value.ToString("yyyy/MM/dd");
                //string toDate = dtToRepairs.Value.ToString("yyyy/MM/dd");

                dtValueChanged(dtFromRepairs, dtToRepairs, IsRepairPeriodChanged);
                string status = StatusSelected();

                string repQuery = "SELECT Rep_ID AS ID, Description AS Problem, DeviceType AS Device, Model, TO_CHAR(RepairDate, 'DD/MM/YYYY') AS Brought, TO_CHAR(CollectionDate, 'DD/MM/YYYY') AS Collected FROM Repairs WHERE Cust_ID = "
                    + ID_Choosen
                    + " AND RepairDate >= TO_DATE('" + fromDate + "', 'yyyy/mm/dd') AND RepairDate <= TO_DATE('"
                                 + toDate + "', 'yyyy/mm/dd') AND Status = '" + status + "' ORDER BY CollectionDate";
                Utils.ListingOnDataGrid(dgvRepairs, repQuery);
            }
        }
        #endregion

        #region SORT BY REPAIR DATE (Repairs)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbRepDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ID_Choosen != null)
            {
                //string fromDate = dtFromRepairs.Value.ToString("yyyy/MM/dd");
                //string toDate = dtToRepairs.Value.ToString("yyyy/MM/dd");

                dtValueChanged(dtFromRepairs, dtToRepairs, IsRepairPeriodChanged);
                string status = StatusSelected();

                string repQuery = "SELECT Rep_ID AS ID, Description AS Problem, DeviceType AS Device, Model, TO_CHAR(RepairDate, 'DD/MM/YYYY') AS Brought, TO_CHAR(CollectionDate, 'DD/MM/YYYY') AS Collected FROM Repairs WHERE Cust_ID = "
                    + ID_Choosen
                    + " AND RepairDate >= TO_DATE('" + fromDate + "', 'yyyy/mm/dd') AND RepairDate <= TO_DATE('"
                                 + toDate + "', 'yyyy/mm/dd') AND Status = '" + status + "' ORDER BY RepairDate";
                Utils.ListingOnDataGrid(dgvRepairs, repQuery);
            }
        }
        #endregion

        #region SORT BY DESCRIPTION (Repairs)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbDescription_CheckedChanged(object sender, EventArgs e)
        {
            if (ID_Choosen != null)
            {
                //string fromDate = dtFromRepairs.Value.ToString("yyyy/MM/dd");
                //string toDate = dtToRepairs.Value.ToString("yyyy/MM/dd");

                dtValueChanged(dtFromRepairs, dtToRepairs, IsRepairPeriodChanged);
                string status = StatusSelected();

                string repQuery = "SELECT Rep_ID AS ID, Description AS Problem, DeviceType AS Device, Model, TO_CHAR(RepairDate, 'DD/MM/YYYY') AS Brought, TO_CHAR(CollectionDate, 'DD/MM/YYYY') AS Collected FROM Repairs WHERE Cust_ID = "
                    + ID_Choosen
                    + " AND RepairDate >= TO_DATE('" + fromDate + "', 'yyyy/mm/dd') AND RepairDate <= TO_DATE('"
                                 + toDate + "', 'yyyy/mm/dd') AND Status = '" + status + "' ORDER BY Description";
                Utils.ListingOnDataGrid(dgvRepairs, repQuery);
            }
        }
        #endregion

        #region SROT BY DEVICE TYPE (Repairs)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (ID_Choosen != null)
            {
                //string fromDate = dtFromRepairs.Value.ToString("yyyy/MM/dd");
                //string toDate = dtToRepairs.Value.ToString("yyyy/MM/dd");

                dtValueChanged(dtFromRepairs, dtToRepairs, IsRepairPeriodChanged);
                string status = StatusSelected();

                string repQuery = "SELECT Rep_ID AS ID, Description AS Problem, DeviceType AS Device, Model, TO_CHAR(RepairDate, 'DD/MM/YYYY') AS Brought, TO_CHAR(CollectionDate, 'DD/MM/YYYY') AS Collected FROM Repairs WHERE Cust_ID = "
                    + ID_Choosen
                    + " AND RepairDate >= TO_DATE('" + fromDate + "', 'yyyy/mm/dd') AND RepairDate <= TO_DATE('"
                                 + toDate + "', 'yyyy/mm/dd') AND Status = '" + status + "' ORDER BY Device";
                Utils.ListingOnDataGrid(dgvRepairs, repQuery);
            }
        }
        #endregion

        #region SORT BY DATE (Estimates)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ID_Choosen != null)
            {
                dtValueChanged(dtFromEstimates, dtToEstimates, IsEstimatePeriodChanged);
                string estQuery = "SELECT e.rep_id AS ID, TO_CHAR(e.EstimateDate, 'DD/MM/YYYY') AS Estimated, e.Total FROM Estimates e JOIN Repairs r ON e.rep_id = r.rep_id LEFT JOIN Customers c ON c.cust_id = r.cust_id WHERE r.cust_id = "
                    + ID_Choosen + " AND EstimateDate >= TO_DATE('" + fromDate + "', 'yyyy/mm/dd') AND EstimateDate <= TO_DATE('"
                 + toDate + "', 'yyyy/mm/dd') ORDER BY EstimateDate";
                Utils.ListingOnDataGrid(dgvEstimates, estQuery);
            }
        }
        #endregion

        #region SORT BY TOTAL BALANCE (Estimates)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (ID_Choosen != null)
            {
                dtValueChanged(dtFromEstimates, dtToEstimates, IsEstimatePeriodChanged);
                string estQuery = "SELECT e.rep_id AS ID, TO_CHAR(e.EstimateDate, 'DD/MM/YYYY') AS Estimated, e.Total FROM Estimates e JOIN Repairs r ON e.rep_id = r.rep_id LEFT JOIN Customers c ON c.cust_id = r.cust_id WHERE r.cust_id = "
                    + ID_Choosen + " AND EstimateDate >= TO_DATE('" + fromDate + "', 'yyyy/mm/dd') AND EstimateDate <= TO_DATE('"
                 + toDate + "', 'yyyy/mm/dd') ORDER BY Total";

                Utils.ListingOnDataGrid(dgvEstimates, estQuery);
            }
        }
        #endregion

        #region SORTING DATA ON COMBO-BOX (status) CHANGES
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ID_Choosen != null)
            {
                //string fromDate = dtFromRepairs.Value.ToString("yyyy/MM/dd");
                //string toDate = dtToRepairs.Value.ToString("yyyy/MM/dd");

                dtValueChanged(dtFromRepairs, dtToRepairs, true);
                string status = StatusSelected();

                string repQuery = "SELECT Rep_ID AS ID, Description AS Problem, DeviceType AS Device, Model, TO_CHAR(RepairDate, 'DD/MM/YYYY') AS Brought, TO_CHAR(CollectionDate, 'DD/MM/YYYY') AS Collected FROM Repairs WHERE Cust_ID = "
                    + ID_Choosen
                    + " AND RepairDate >= TO_DATE('" + fromDate + "', 'yyyy/mm/dd') AND RepairDate <= TO_DATE('"
                                 + toDate + "', 'yyyy/mm/dd') AND Status = '" + status + "'";
                Utils.ListingOnDataGrid(dgvRepairs, repQuery);
            }
        }
        #endregion

        ///
        /// <summary>
        /// CHANGE DATA GRID ON DATE CHANGES
        /// </summary>
        ///

        #region GET NEW DATA IF FROM DATE PERIOD IS CHANGED (Repairs)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtFromRepairs_ValueChanged(object sender, EventArgs e)
        {
            if (ID_Choosen != null)
            {
                // Check the value of the dates
                dtValueChanged(dtFromRepairs, dtToRepairs, true);
                string status = StatusSelected();
                //MessageBox.Show(fromDate);

                string repQuery = "SELECT Rep_ID AS ID, Description AS Problem, DeviceType AS Device, Model, TO_CHAR(RepairDate, 'DD/MM/YYYY') AS Brought, TO_CHAR(CollectionDate, 'DD/MM/YYYY') AS Collected FROM Repairs WHERE Cust_ID = "
                 + ID_Choosen + " AND RepairDate >= TO_DATE('" + fromDate + "', 'yyyy/mm/dd') AND RepairDate <= TO_DATE('"
                 + toDate + "', 'yyyy/mm/dd') AND Status = '" + status + "'";

                //MessageBox.Show(repQuery);
                Utils.ListingOnDataGrid(dgvRepairs, repQuery);

                IsRepairPeriodChanged = true;
            }
        }
        #endregion

        #region GET NEW DATA IF TO DATE PERIOD IS CHANGED (Repairs)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtToRepairs_ValueChanged(object sender, EventArgs e)
        {
            if (ID_Choosen != null)
            {
                // Check the value of the dates
                dtValueChanged(dtFromRepairs, dtToRepairs, true);
                string status = StatusSelected();

                string repQuery = "SELECT Rep_ID AS ID, Description AS Problem, DeviceType AS Device, Model, TO_CHAR(RepairDate, 'DD/MM/YYYY') AS Brought, TO_CHAR(CollectionDate, 'DD/MM/YYYY') AS Collected FROM Repairs WHERE Cust_ID = "
                                 + ID_Choosen + " AND RepairDate >= TO_DATE('" + fromDate + "', 'yyyy/mm/dd') AND RepairDate <= TO_DATE('"
                                 + toDate + "', 'yyyy/mm/dd') AND Status = '" + status + "'";

                Utils.ListingOnDataGrid(dgvRepairs, repQuery);

                IsRepairPeriodChanged = true;
            }
        }
        #endregion

        #region GET NEW DATA IF FROM DATE PERIOD IS CHANGED (Estimates)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtFromEstimates_ValueChanged(object sender, EventArgs e)
        {
            if (ID_Choosen != null)
            {
                // Check the value of the dates
                dtValueChanged(dtFromEstimates, dtToEstimates, true);

                string estQuery = "SELECT e.rep_id AS ID, TO_CHAR(e.EstimateDate, 'DD/MM/YYYY') AS Estimated, e.Total FROM Estimates e JOIN Repairs r ON e.rep_id = r.rep_id LEFT JOIN Customers c ON c.cust_id = r.cust_id WHERE r.cust_id = "
                    + ID_Choosen + " AND EstimateDate >= TO_DATE('" + fromDate + "', 'yyyy/mm/dd') AND EstimateDate <= TO_DATE('"
                 + toDate + "', 'yyyy/mm/dd')";

                Utils.ListingOnDataGrid(dgvEstimates, estQuery);

                IsEstimatePeriodChanged = true;
            }
        }
        #endregion

        #region GET NEW DATA IF TO DATE PERIOD IS CHANGED (Estimates)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtToEstimates_ValueChanged(object sender, EventArgs e)
        {
            if (ID_Choosen != null)
            {
                // Check the value of the dates
                dtValueChanged(dtFromEstimates, dtToEstimates, true);

                string estQuery = "SELECT e.rep_id AS ID, TO_CHAR(e.EstimateDate, 'DD/MM/YYYY') AS Estimated, e.Total FROM Estimates e JOIN Repairs r ON e.rep_id = r.rep_id LEFT JOIN Customers c ON c.cust_id = r.cust_id WHERE r.cust_id = "
                    + ID_Choosen + " AND EstimateDate >= TO_DATE('" + fromDate + "', 'yyyy/mm/dd') AND EstimateDate <= TO_DATE('"
                 + toDate + "', 'yyyy/mm/dd')";

                Utils.ListingOnDataGrid(dgvEstimates, estQuery);

                IsEstimatePeriodChanged = true;
            }
        }
        #endregion

        ///
        /// <summary>
        /// CLEAR DATAGRIDVIEW WHEN DATE TIME PICKER CLICKED
        /// </summary>
        ///

        #region CHECK IF 'FROM' DATE IS DROPPED (Repairs)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtFromRepairs_DropDown(object sender, EventArgs e)
        {
            if (dgvRepairs.DataSource != null)
            {
                dgvRepairs.DataSource = null;
                dgvRepairs.Refresh();
            }

        }
        #endregion

        #region CHECK IF 'TO' DATE IS DROPPED (Repairs)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtToRepairs_DropDown(object sender, EventArgs e)
        {
            if (dgvRepairs.DataSource != null)
            {
                dgvRepairs.DataSource = null;
                dgvRepairs.Refresh();
            }
        }
        #endregion

        #region CHECK IF 'FROM' DATE IS DROPPED (Estimates)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtFromEstimates_DropDown(object sender, EventArgs e)
        {
            if (dgvEstimates.DataSource != null)
            {
                dgvEstimates.DataSource = null;
                dgvEstimates.Refresh();
            }
        }
        #endregion

        #region CHECK IF 'TO' DATE IS DROPPED (Estimates)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtToEstimates_DropDown(object sender, EventArgs e)
        {
            if (dgvEstimates.DataSource != null)
            {
                dgvEstimates.DataSource = null;
                dgvEstimates.Refresh();
            }
        }
        #endregion

        ///
        /// <summary>
        /// PRINTING OUT
        /// </summary>
        ///

        #region HANDLES THE PRINT PAGE EVENT
        /// <summary>
        /// Handles the print page event of print document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (IsEstimatePrintButtonClicked)
            {
                Print.PrintPageEvent(dgvEstimates, e, "ESTIMATES LISTING");
            }
            else
            {
                Print.PrintPageEvent(dgvRepairs, e, "REPAIRS LISTING");
            }
        }
        #endregion

        #region HANDLES THE PRINT BUTTON CLICK EVENT
        /// <summary>
        /// Handles the print button click event
        /// Asks the user to Preview or Print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintRepairs_Click(object sender, EventArgs e)
        {
            Print.PrintButtonClickEvent(printDoc, "Repairs listing from DataGridView");
        }

        private void btnPrintEstimates_Click(object sender, EventArgs e)
        {
            IsEstimatePrintButtonClicked = true;
            Print.PrintButtonClickEvent(printDoc, "Estimates listing from DataGridView");
        }
        #endregion

        #region HANDLES THE BEGIN PRINT EVENT
        /// <summary>
        /// Handles the begin print event of print document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDoc_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (IsEstimatePrintButtonClicked)
            {
                Print.BeginPrintEventHandler(dgvEstimates);
            }
            else
            {
                Print.BeginPrintEventHandler(dgvRepairs);
            }

        }
        #endregion

        ///
        /// <summary>
        /// UTILITY METHODS
        /// </summary>
        /// 

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

        #region FIND OUT WHICH STATUS IS SELECTED FROM THE COMBO BOX
        /// <summary>
        /// Returns int value of the item selected
        /// </summary>
        /// <returns>item selected</returns>
        private string StatusSelected()
        {
            int selectedIndex = cbStatus.SelectedIndex;
            Object selectedItem = cbStatus.SelectedItem;
            string status = selectedItem.ToString();

            return status;
        }
        #endregion

        #region CHECK IF DATE IS CHANGED
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtpf">from date value</param>
        /// <param name="dtpt">to date value</param>
        private void dtValueChanged(DateTimePicker dtpf, DateTimePicker dtpt, Boolean IsChanged)
        {
            if (IsChanged)
            {
                fromDate = dtpf.Value.ToString("yyyy/MM/dd");
                toDate = dtpt.Value.ToString("yyyy/MM/dd");
            }
            else
            {
                fromDate = "1900/01/01";
                toDate = dtpt.Value.ToString("yyyy/MM/dd");
            }
        }
        #endregion


    } //end of class
}

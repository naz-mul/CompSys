using System;
using System.Collections;
using System.Data;
using System.Data.OracleClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmFinaliseRepair : Form
    {

        #region GLOBAL VARIABLES

        private int TotalRowsChecked;
        private ArrayList aList;

        #endregion

        #region LOAD THE FORM
        /// <summary>
        /// 
        /// </summary>
        public frmFinaliseRepair()
        {
            InitializeComponent();       
        }
        #endregion

        #region LOAD DEFAULTS
        /// <summary>
        /// Populate datagrid view from the database
        /// Only populate repairs that are 'Fixing'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFinaliseRepair_Load(object sender, EventArgs e)
        {
            // Bind data when the form populates
            BindGrid("Resolved", "e.total");
        }
        #endregion

        #region DATA GRID BINDER
        /// <summary>
        /// Data grid binder
        /// </summary>
        private void BindGrid(String status, String OrderBy)
        {
            string strQuery =
                "SELECT r.rep_id as ID, " +
                       "c.surname     AS Customer, " +
                       "r.description AS Problem, " +
                       "r.devicetype  AS Device, " +
                       "e.total " +
                "FROM   repairs r " +
                "JOIN customers c " +
                    "ON r.cust_id = c.cust_id " +
                "LEFT JOIN estimates e " +
                        "ON e.rep_id = r.rep_id " +
                "WHERE  r.status = '" + status + "' " +
                "ORDER  BY " + OrderBy;

            Utils.ListingOnDataGrid(dgvListRepairs, strQuery);
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

        #region CLEAR ALL THE CHECKED ITEMS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
           DataGridViewCheckBoxCell oCell;

            foreach (DataGridViewRow row in dgvListRepairs.Rows)
            {
                oCell = row.Cells["Check"] as DataGridViewCheckBoxCell;
                bool bChecked = (null != oCell && null != oCell.Value && true == (bool)oCell.Value);
                if (true == bChecked)
                {
                    row.Cells["Check"].Value = false;
                }
            }

        }
        #endregion

        #region FINALISE REPAIR ITEM
        /// <summary>
        /// If there are 1 items or more in the grid
        ///     -- Get the rows checked
        ///     -- If checked rows > 0
        ///         -- Put each checked rows Part_ID into a String
        ///     -- Confirm if the user want to finalise the repairs selected
        ///     -- Display successful message or error message
        ///     -- Email confirmation
        ///     -- Bind the data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            String ListOfIDsSelected = "";

            // Check if the row count is at least 1
            if (dgvListRepairs.Rows.Count > 0)
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

                    DialogResult dr = MessageBox.Show("Do you want to finalise these repair(s) and email confirmation to the customer(s).",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        String query = "UPDATE REPAIRS SET status = 'Invoiced' " +
                                                "WHERE Rep_ID " +
                                                            "IN (" + ListOfIDsSelected + ")";
                        // Delete the items
                        Utils.UpdateData(query);

                        if (Utils.IsSuccessful())
                        {
                            // Email confirmation
                            EmailConfirmation();

                            dgvListRepairs.DataSource = null;
                            //re bind grid and fill from database again
                            BindGrid("Resolved", "e.total ASC");
                            dgvListRepairs.Refresh();

                            // Display successful message
                            MessageBox.Show("Selected repairs finalised successfully!");
                                                        
                        }
                        else
                        {
                            MessageBox.Show("Repair finalisation process was not successfull!");
                        }
                    } // end of delete confirmation
                }
                else
                {
                    MessageBox.Show("Please select at least ONE repair!");
                }
            } //end of checking data grid row count
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

                foreach (String RepID in aList)
                {
                    NewEmail = GetEmailAddress(StringQuery(RepID));
                    message.To.Add(new MailAddress(NewEmail));
                }
                message.To.Add(new MailAddress("Nazmul.Alam@students.ittralee.ie"));

                message.Subject = "CompuRite: your device is ready to collect";
                message.Body = "Dear CompuRite Customer, "
                                + "\nWe are very happy to confirm our Technical Team have successfully solved all of your device problems."
                                + "You can now collect your item from our shop at any time during business hours."
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
          
            // Bind data when the form populates
            BindGrid("Resolved", "r.rep_id");
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

            // Bind data when the form populates
            BindGrid("Resolved", "c.surname");
        }
        #endregion

        #region SORT BY PROBLEM
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbProb_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data when the form populates
            BindGrid("Resolved", "r.description");
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
            // Bind data when the form populates
            BindGrid("Resolved", "r.devicetype");
        }
        #endregion

        #region SORT BY TOTAL COST
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbTotal_CheckedChanged(object sender, EventArgs e)
        {

            // Bind data when the form populates
            BindGrid("Resolved", "e.total");
        }
        #endregion


    }
}

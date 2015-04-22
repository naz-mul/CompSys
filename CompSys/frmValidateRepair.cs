using System;
using System.Collections;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmValidateRepair : Form
    {
        
        #region GLOBAL VARIABLES

        private int TotalRowsChecked;
        private ArrayList aList;

        #endregion

        #region LOAD THE FORM
        /// <summary>
        /// 
        /// </summary>
        public frmValidateRepair()
        {
            InitializeComponent();
        }
        #endregion

        #region LOAD DEFAULTS
        /// <summary>
        /// Populate datagrid view from the database
        /// Only populate repairs that are 'Estimated'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmValidateRepair_Load(object sender, EventArgs e)
        {
            // Bind data when the form populates
            BindGrid("Estimated", "e.total ASC");
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
                "SELECT r.rep_id as ID, "+
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
                "ORDER  BY " + orderby;

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

        #region VALIDATE REPAIR ITEM
        /// <summary>
        /// If there are 1 items or more in the grid
        ///     -- Get the rows checked
        ///     -- If checked rows > 0
        ///         -- Put each checked rows Part_ID into a String
        ///     -- Confirm if the user want to validate the repairs selected
        ///     -- Display successful message or error message
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

                    DialogResult dr = MessageBox.Show("Do you want to validate these repair(s) " + ListOfIDsSelected,
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        String query = "UPDATE REPAIRS SET status = 'Validated' " +
                                                "WHERE Rep_ID " +
                                                            "IN (" + ListOfIDsSelected + ")";
                        // Delete the items
                        Utils.UpdateData(query);

                        if (Utils.IsSuccessful())
                        {
                            dgvListRepairs.DataSource = null;
                            //re bind grid and fill from database again
                            BindGrid("Estimated", "e.total ASC");
                            dgvListRepairs.Refresh();

                            // Display successful message
                            MessageBox.Show("Repairs validated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Repair validation process was not successfull!");
                        }
                    } // end of delete confirmation
                }
                else
                {
                    MessageBox.Show("Please select at least ONE item!");
                }
            } //end of checking data grid row count
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

        #region SORT BY REPAIR ID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbID_CheckedChanged(object sender, EventArgs e)
        {  
            BindGrid("Estimated", "r.rep_id");
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
            BindGrid("Estimated", "c.surname");
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
            
            BindGrid("Estimated", "r.description");

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
            BindGrid("Estimated", "r.devicetype");
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
            BindGrid("Estimated", "e.total");
        }
        #endregion

        #region PRINTING OUT
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print.PrintButtonClickEvent(printDocument, "Repairs listing from DataGridView");
        }

        

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Print.BeginPrintEventHandler(dgvListRepairs);
        }
        

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Print.PrintPageEvent(dgvListRepairs, e, "REPAIRS LISTING");
        }
        #endregion



    } // end of class
}

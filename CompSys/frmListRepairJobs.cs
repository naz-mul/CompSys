using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmListRepairJobs : Form
    {
        
        #region GLOBAL VARIABLES

        private int TotalRowsChecked;
        private ArrayList aList;

        #endregion

        #region LOAD FORM
        /// <summary>
        /// 
        /// </summary>
        public frmListRepairJobs()
        {
            InitializeComponent();
            
        }
        #endregion

        #region LOAD DEFAULTS
        /// <summary>
        /// Populate datagrid view from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmListRepairJobs_Load(object sender, EventArgs e)
        {
            // Set default status to validated
            cbStatus.SelectedIndex = cbStatus.Items.IndexOf("Validated");
            // Get the current status
            string status = StatusSelected();
            // Bind data grid
            BindGrid(status, "e.total ASC");

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
                "SELECT r.rep_id AS ID, " + 
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

            Utils.ListingOnDataGrid(dgvListJobs, strQuery);
        }
        #endregion

        ///
        ///<summary>
        /// SORTING DATA GRID ACCORDING TO THE RADIO BUTTON CHANGES
        /// </summary>
        ///

        #region CHECK WHICH STATUS IS SELECTED
        /// <summary>
        /// Returns String value of the item selected
        /// </summary>
        /// <returns>item selected</returns>
        private String StatusSelected()
        {
            //int selectedIndex = cbStatus.SelectedIndex;
            Object selectedItem = cbStatus.SelectedItem;
            String status = selectedItem.ToString();

            if (status.Equals("Validated"))
            {
                this.btnFixing.Location = new System.Drawing.Point(568, 499);
                btnFixing.Visible = true;
                btnFixed.Visible = false;
            }     
            else if (status.Equals("Fixing"))
            {
                btnFixing.Visible = false;
                btnFixed.Visible = true;
            }
            else
            {
                btnFixing.Visible = false;
                btnFixed.Visible = false;
            }
                

            return status;

        }
        #endregion

        #region SORTS BY CUSTOMER NAME
        /// <summary>
        /// SORT BY LAST NAME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbName_CheckedChanged_1(object sender, EventArgs e)
        {
            // Get the current status
            string status = StatusSelected();
            // Bind data grid
            BindGrid(status, "c.surname");

        }
        #endregion       

        #region SORT BY DESCRIPTION
        /// <summary>
        /// SORT BY DESCRIPTION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbDescription_CheckedChanged(object sender, EventArgs e)
        {
            // Get the current status
            string status = StatusSelected();
            // Bind data grid
            BindGrid(status, "r.description");
        }
        #endregion

        #region SORT BY DEVICE TYPE
        /// <summary>
        /// SORT BY DEVICE TYPE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbDevice_CheckedChanged(object sender, EventArgs e)
        {
            // Get the current status
            string status = StatusSelected();
            // Bind data grid
            BindGrid(status, "r.devicetype");
        }
        #endregion

        #region SORT BY TOTAL
        /// <summary>
        /// SORT BY TOTAL COST
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbTotal_CheckedChanged(object sender, EventArgs e)
        {
            // Get the current status
            string status = StatusSelected();
            // Bind data grid
            BindGrid(status, "e.total");
        }
        #endregion

        #region POPULATE DATA GRID ON STATUS CHANGES
        /// <summary>
        /// If status changed from the default 'Fixed' to 'Resolved' or vice versa
        /// Display the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the current status
            string status = StatusSelected();
            // Bind data grid
            BindGrid(status, "e.total ASC");
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
   
        ///
        /// <summary>
        /// PRINT OUT START
        /// </summary>
        ///

        #region HANDLES THE PRINT PAGE EVENT
        /// <summary>
        /// Handles the print page event of print document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printRepairJobs_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Print.PrintPageEvent(dgvListJobs, e, "JOBS LISTING");

        }
        #endregion

        #region HANDLES THE PRINT BUTTON CLICK EVENT
        /// <summary>
        /// Handles the print button click event
        /// Asks the user to Preview or Print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print.PrintButtonClickEvent(printRepairJobs, "Jobs listing from DataGridView");

        }
        #endregion

        #region HANDLES THE BEGIN PRINT EVENT
        /// <summary>
        /// Handles the begin print event of print document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printRepairJobs_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Print.BeginPrintEventHandler(dgvListJobs);
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

            foreach (DataGridViewRow row in dgvListJobs.Rows)
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

        #region SET REPAIR STATUS TO FIXING
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFixing_Click(object sender, EventArgs e)
        {
            String ListOfIDsSelected = "";

            // Check if the row count is at least 1
            if (dgvListJobs.Rows.Count > 0)
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

                    DialogResult dr = MessageBox.Show("Do you want to change status to 'Fixing' for repair(s) " + ListOfIDsSelected,
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        String query = "UPDATE Repairs Set Status = 'Fixing' " +
                                                "WHERE Rep_ID " +
                                                            "IN (" + ListOfIDsSelected + ")";
                        // Delete the items
                        Utils.UpdateData(query);

                        if (Utils.IsSuccessful())
                        {
                            dgvListJobs.DataSource = null;
                            //re bind grid and fill from database again
                            // Get the current status
                            string status = StatusSelected();
                            // Bind data grid
                            BindGrid(status, "e.total ASC");
                            dgvListJobs.Refresh();

                            // Display successful message
                            MessageBox.Show("Repair status change to 'Fixing' was successful!");
                        }
                        else
                        {
                            MessageBox.Show("Repair status change to 'Fixing' was not successful!");
                        }
                    } // end of delete confirmation
                }
                else
                {
                    MessageBox.Show("Please select at least ONE item!");
                }
            }
        }
        #endregion

        #region SET REPAIR STATUS TO RESOLVED
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFixed_Click(object sender, EventArgs e)
        {
            String ListOfIDsSelected = "";

            // Check if the row count is at least 1
            if (dgvListJobs.Rows.Count > 0)
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

                    DialogResult dr = MessageBox.Show("Do you want to change status to 'Resolved' for repair(s) " + ListOfIDsSelected,
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        String query = "UPDATE Repairs Set Status = 'Resolved' " +
                                                "WHERE Rep_ID " +
                                                            "IN (" + ListOfIDsSelected + ")";
                        // Delete the items
                        Utils.UpdateData(query);

                        if (Utils.IsSuccessful())
                        {
                            dgvListJobs.DataSource = null;
                            //re bind grid and fill from database again
                            // Get the current status
                            string status = StatusSelected();
                            // Bind data grid
                            BindGrid(status, "e.total ASC");
                            dgvListJobs.Refresh();

                            // Display successful message
                            MessageBox.Show("Repair status change to 'Resolved' was successful!");
                        }
                        else
                        {
                            MessageBox.Show("Repair status change to 'Resolved' was not successful!");
                        }
                    } // end of delete confirmation
                }
                else
                {
                    MessageBox.Show("Please select at least ONE item!");
                }
            }
        }
        #endregion


    }
}

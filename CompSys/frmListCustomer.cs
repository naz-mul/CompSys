using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmListCustomer : Form
    {
        #region LOAD THE FORM
        /// <summary>
        /// 
        /// </summary>
        public frmListCustomer()
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
        private void frmListCustomer_Load(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = cbStatus.Items.IndexOf("Active");
            string strQuery = "SELECT Cust_ID AS ID, Surname, Forename, TO_CHAR(DOB, 'DD/MM/YYYY') AS DOB, Address1 AS Street, Town, Telephone AS Tel FROM Customers WHERE Status = 'A'";

            Utils.ListingOnDataGrid(dgvListCust, strQuery);

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
            string status = selectedItem.ToString();

            if (status.Equals("Inactive"))
                status = "NA";
            else
                status = "A";

            return status;
        }
        #endregion

        #region SORTS BY LAST NAME
        /// <summary>
        /// SORT BY LAST NAME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbLastname_CheckedChanged(object sender, EventArgs e)
        {
            string status = StatusSelected();

            string strQuery = "SELECT Cust_ID AS ID, Surname, Forename, TO_CHAR(DOB, 'DD/MM/YYYY') AS DOB, Address1 AS Street, Town, Telephone AS Tel FROM Customers WHERE Status = '" + status + "' ORDER BY surname";
            //MessageBox.Show(strQuery);
            Utils.ListingOnDataGrid(dgvListCust, strQuery);
        }
        #endregion

        #region SORTS BY FIRST NAME
        /// <summary>
        /// SORT BY FIRST NAME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbFirstname_CheckedChanged(object sender, EventArgs e)
        {
            string status = StatusSelected();

            string strQuery = "SELECT Cust_ID AS ID, Surname, Forename, TO_CHAR(DOB, 'DD/MM/YYYY') AS DOB, Address1 AS Street, Town, Telephone AS Tel FROM Customers WHERE Status = '" + status + "' ORDER BY forename";
            //MessageBox.Show(strQuery);
            Utils.ListingOnDataGrid(dgvListCust, strQuery);
        }
        #endregion

        #region SORTS BY TOWN
        /// <summary>
        /// SORTS BY TOWN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbTown_CheckedChanged(object sender, EventArgs e)
        {
            string status = StatusSelected();

            string strQuery = "SELECT Cust_ID AS ID, Surname, Forename, TO_CHAR(DOB, 'DD/MM/YYYY') AS DOB, Address1 AS Street, Town, Telephone AS Tel FROM Customers WHERE Status = '" + status + "' ORDER BY town";
            //MessageBox.Show(strQuery);
            Utils.ListingOnDataGrid(dgvListCust, strQuery);
        }
        #endregion

        #region SORTS BY REGISTRATION DATE
        /// <summary>
        /// SORTS BY REGISTRATION DATE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbRegDate_CheckedChanged(object sender, EventArgs e)
        {
            string status = StatusSelected();

            string strQuery = "SELECT Cust_ID AS ID, Surname, Forename, TO_CHAR(DOB, 'DD/MM/YYYY') AS DOB, Address1 AS Street, Town, TO_CHAR(RegDate, 'DD/MM/YYYY') AS RegDate FROM Customers WHERE Status = '" + status + "' ORDER BY RegDate";
            //MessageBox.Show(strQuery);
            Utils.ListingOnDataGrid(dgvListCust, strQuery);
        }
        #endregion

        #region POPULATE DATA GRID ON STATUS CHANGES
        /// <summary>
        /// If status changed from the default 'Active' to 'Inactive' or vice versa
        /// Display the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = StatusSelected();
            string strQuery = "SELECT Cust_ID AS ID, Surname, Forename, TO_CHAR(DOB, 'DD/MM//YYYY') AS DOB, Address1 AS Street, Town, Telephone AS Tel FROM Customers WHERE Status = '" + status + "'";

            Utils.ListingOnDataGrid(dgvListCust, strQuery);
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
        private void printCustomerList_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Print.PrintPageEvent(dgvListCust, e, "CUSTOMER LISTING");
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
            Print.PrintButtonClickEvent(printCustomerList, "Customer listing from DataGridView");

        }
        #endregion

        #region HANDLES THE BEGIN PRINT EVENT
        /// <summary>
        /// Handles the begin print event of print document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printCustomerList_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Print.BeginPrintEventHandler(dgvListCust);
        }
        #endregion
    
    }
}

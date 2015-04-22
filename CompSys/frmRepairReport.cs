using System;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmRepairReport : Form
    {
        public frmRepairReport()
        {
            InitializeComponent();
        }

        #region LOAD DEFAULTS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRepairReport_Load(object sender, EventArgs e)
        {
            // Bind data grid
            string status = "WHERE  r.status = 'New' OR r.status = 'Estimated' OR r.status = 'Validated' OR r.status = 'Fixing' OR r.status = 'Resolved' OR r.status = 'Invoiced' OR r.status = 'Paid'";
            BindGrid(status, "r.repairdate");

            // Get sum total estimate
            string query = "SELECT SUM(Total) AS Total FROM Estimates";
            tbTotal.Text = Utils.GetSingleValue(query, "Total");
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
                "SELECT r.rep_id                              AS ID, " +
                       "TO_CHAR(r.repairdate, 'DD/MM/YYYY')   AS RepDate, " +
                       "c.surname                             AS Customer, " +
                       "r.description                         AS Problem, " +
                       "TO_CHAR(e.estimatedate, 'DD/MM/YYYY') AS EstDate, " +
                       "e.total, " +
                       "r.status " +
                "FROM   repairs r " +
                "JOIN customers c " +
                    "ON r.cust_id = c.cust_id " +
                "LEFT JOIN estimates e " +
                        "ON e.rep_id = r.rep_id " +
                 status +
                "ORDER  BY " + orderby;

            Utils.ListingOnDataGrid(dgvListJobs, strQuery);
        }
        #endregion

        #region SORT DATA
        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            string status = "WHERE  r.status = 'New' OR r.status = 'Estimated' OR r.status = 'Validated' OR r.status = 'Fixing' OR r.status = 'Resolved' OR r.status = 'Invoiced' OR r.status = 'Paid'";
            // Bind data grid
            BindGrid(status, "r.rep_id");
        }

        private void rbRegDate_CheckedChanged(object sender, EventArgs e)
        {
            string status = "WHERE  r.status = 'New' OR r.status = 'Estimated' OR r.status = 'Validated' OR r.status = 'Fixing' OR r.status = 'Resolved' OR r.status = 'Invoiced' OR r.status = 'Paid'";
            // Bind data grid
            BindGrid(status, "r.RepairDate");
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            string status = "WHERE  r.status = 'New' OR r.status = 'Estimated' OR r.status = 'Validated' OR r.status = 'Fixing' OR r.status = 'Resolved' OR r.status = 'Invoiced' OR r.status = 'Paid'";
            // Bind data grid
            BindGrid(status, "c.surname");
        }

        private void rbEstDate_CheckedChanged(object sender, EventArgs e)
        {
            string status = "WHERE  r.status = 'New' OR r.status = 'Estimated' OR r.status = 'Validated' OR r.status = 'Fixing' OR r.status = 'Resolved' OR r.status = 'Invoiced' OR r.status = 'Paid'";
            // Bind data grid
            BindGrid(status, "e.estimatedate");
        }

        private void rbTotal_CheckedChanged(object sender, EventArgs e)
        {
            string status = "WHERE  r.status = 'New' OR r.status = 'Estimated' OR r.status = 'Validated' OR r.status = 'Fixing' OR r.status = 'Resolved' OR r.status = 'Invoiced' OR r.status = 'Paid'";
            // Bind data grid
            BindGrid(status, "e.total");
        }

        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            string status = "WHERE  r.status = 'New' OR r.status = 'Estimated' OR r.status = 'Validated' OR r.status = 'Fixing' OR r.status = 'Resolved' OR r.status = 'Invoiced' OR r.status = 'Paid'";
            // Bind data grid
            BindGrid(status, "r.status");
        }
        #endregion

        #region PRINTING OUT
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print.PrintButtonClickEvent(printDocument, "Jobs listing from DataGridView");
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Print.PrintPageEvent(dgvListJobs, e, "JOBS LISTING");
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Print.BeginPrintEventHandler(dgvListJobs);
        }

        #endregion
        

    }
}

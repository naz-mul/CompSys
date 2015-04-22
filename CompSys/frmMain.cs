using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmMain : Form
    {

        #region GLOBAL VARIABLES 
  
        private OracleConnection con;
        private OracleCommand com;
        private string constr;
        private ToolTip tooltip = new ToolTip();

        #endregion

        #region INTIALIZE COMPONENT
        /// <summary>
        /// 
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            this.userToolStripMenuItem.ToolTipText = frmLogin.username;
            this.lblRepair.Text = "Repair Summary " + DateTime.Now.Year.ToString();
        }
        #endregion

        #region LOAD DEFAULTS
        /// <summary>
        /// Loads the defaults
        /// 1) Binds pie chart data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            Bindchart();

        }
        #endregion

        ///
        ///<summary>
        ///GET STARTED MENUS
        ///</summary>
        ///

        #region ADD NEW CUSTOMER
        /// <summary>
        /// Opens add new customer module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainAddCustomer_Click(object sender, EventArgs e)
        {
            Form form = new frmNewCustomer();
            form.ShowDialog();
        }
        #endregion

        #region ADD NEW REPAIR
        /// <summary>
        /// Opens new repair module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainNewRepair_Click(object sender, EventArgs e)
        {
            Form form = new frmNewRepair();
            form.ShowDialog();
        }
        #endregion

        #region ADD NEW INVOICE
        /// <summary>
        /// Opens new invoice module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainNewInvoice_Click(object sender, EventArgs e)
        {
            Form form = new frmIssueInvoice();
            form.ShowDialog();
        }
        #endregion

        #region ADD NEW ESTIMATE
        /// <summary>
        /// Opens new estimate module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewEstimateMain_Click(object sender, EventArgs e)
        {
            Form form = new frmSetEstimate();
            form.ShowDialog();
        }
        #endregion

        ///
        ///<summary>
        /// TOOL STRIP MENU ITEMS
        /// </summary>
        ///

        #region NEW STAFF
        /// <summary>
        /// Open new staff module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmNewStaff();
            form.ShowDialog();
        }
        #endregion

        #region AMEND STAFF
        /// <summary>
        /// Open amend staff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void amendStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = new frmAmendStaff();
            form.ShowDialog();
        }
        #endregion

        #region LIST STAFF
        /// <summary>
        /// Open list staff module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmListStaff();
            form.ShowDialog();
        }
        #endregion

        #region NEW CUSTOMER
        /// <summary>
        /// Open new customer module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmNewCustomer();
            form.ShowDialog();
        }
        #endregion

        #region AMEND CUSTOMER
        /// <summary>
        /// Open amend customer module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void amendCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmAmendCustomer();
            form.ShowDialog();
        }
        #endregion

        #region QUERY CUSTOMER
        /// <summary>
        /// Open query customer module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queryCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmQueryCustomer();
            form.ShowDialog();
        }
        #endregion

        #region LIST CUSTOMERS
        /// <summary>
        /// Open list customers module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmListCustomer();
            form.ShowDialog();
        }
        #endregion


        private void newRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewRepair form = new frmNewRepair();
            form.ShowDialog();
        }

        private void setEstimateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetEstimate form = new frmSetEstimate();
            form.ShowDialog();
        }

        private void validateRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidateRepair form = new frmValidateRepair();
            form.ShowDialog();
        }

        private void finaliseRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinaliseRepair form = new frmFinaliseRepair();
            form.ShowDialog();
        }

        private void collectRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCollectRepair form = new frmCollectRepair();
            form.ShowDialog();
        }

        private void repairReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepairReport form = new frmRepairReport();
            form.ShowDialog();
        }


        #region LIST REPAIR JOBS
        /// <summary>
        /// Open list repair jobs module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listRepairJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmListRepairJobs();
            form.ShowDialog();
        }
        #endregion

        #region ISSUE INVOICE
        /// <summary>
        /// Open Issue Invoice Module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void issueInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueInvoice form = new frmIssueInvoice();
            form.ShowDialog();
        }
        #endregion

        #region INCOME ANALYSIS
        /// <summary>
        /// Open issuen analysis module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void incomeAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncomeAnalysis form = new frmIncomeAnalysis();
            form.ShowDialog();
        }
        #endregion
        
        #region INVENTORY
        /// <summary>
        /// Open inventory module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setRepairRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmInventory();
            form.ShowDialog();
        }
        #endregion

        #region LOGOUT
        /// <summary>
        /// This method verfies whether the user wants to logout or not.
        /// Upon click YES to the confirmation message, the Application RESTARTS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Do you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                Application.Restart();
            }

        }
        #endregion

        ///
        ///<summary>
        /// PIE CHART BINDER
        /// </summary>
        /// 

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
                string strQuery = "SELECT * FROM Total_Repairs";
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
                chartMain.Series[0].Points.DataBindXY(XPointMember, YPointMember);

                /*// Disable labels on the chart
                for (var i = 0; i < chartMain.Series.Count; i++)
                    for (var j = 0; j < chartMain.Series[i].Points.Count; j++)
                        chartMain.Series[i].Points[j]["PieLabelStyle"] = "Disabled"; */

                //Show YValue on the chart only
                chartMain.Series[0].IsValueShownAsLabel = true;

                //Hide Xvalue
                //chartMain.Series[0].LegendText = "#VALY";

                //Show ToolTip
                chartMain.Series[0].ToolTip = "#VALX";
                
                con.Close();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion


    
    } //end of class       
}

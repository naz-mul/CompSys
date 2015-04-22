using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CompSys
{
    public partial class frmIncomeAnalysis : Form
    {

        public frmIncomeAnalysis()
        {
            InitializeComponent();
        }

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
                OracleConnection sqlCon = new OracleConnection(Utils.OracleConnectionString());
                
                String varname1 = "";
                varname1 = varname1 + "select to_char(r.repairdate, 'MM') AS Month, Count(r.rep_id) as TotalRepairs, SUM(e.total) AS TotalEarnings " + "\n";
                varname1 = varname1 + "from repairs r join estimates e " + "\n";
                varname1 = varname1 + "on r.rep_id = e.rep_id " + "\n";
                varname1 = varname1 + "WHERE EXTRACT(YEAR FROM RepairDate) = EXTRACT(YEAR FROM sysdate) " + "\n";
                varname1 = varname1 + "group by to_char(r.repairdate, 'MM') " + "\n";
                varname1 = varname1 + "order by to_char(r.repairdate, 'MM')";

                Dictionary<String, int> callSummariesByTypeOfCall =
                    new Dictionary<String, int>();

                OracleCommand comm = new OracleCommand(varname1, sqlCon);
                comm.CommandType = CommandType.Text;

                sqlCon.Open();

                OracleDataReader dr = comm.ExecuteReader();

                // Get the data into a dictionary
                while (dr.Read())
                {
                    String calltype = dr["TotalEarnings"].ToString();
                    int summary = int.Parse(dr["TotalRepairs"].ToString(), CultureInfo.InvariantCulture);
                    callSummariesByTypeOfCall[calltype] = summary;
                }

                // Do any other processing you need here

                // Bind the data onto the Series
                Series series = new Series
                {
                    Name = "TotalRepairs",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column
                };

                series.Points.DataBindXY(
                    callSummariesByTypeOfCall.Keys,
                    callSummariesByTypeOfCall.Values);
                chart1.Series.Add(series);
                chart1.Invalidate();

                //pnlBar.Controls.Add(chart1);
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        private void frmIncomeAnalysis_Load(object sender, EventArgs e)
        {
            Bindchart();
        }
    }
}

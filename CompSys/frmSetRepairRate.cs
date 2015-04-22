using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmSetRepairRate : Form
    {
        public frmSetRepairRate()
        {
            InitializeComponent();
        }

        private void cbCountiesNewStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbDescSR_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCountyNewStaff_Click(object sender, EventArgs e)
        {

        }

        private void frmSetRepairRate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'compuRite.PARTS' table. You can move, or remove it, as needed.
            //this.pARTSTableAdapter.Fill(this.compuRite.PARTS);

        }

        private void btnBackListStaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearSR_Click(object sender, EventArgs e)
        {
          
            tbDescSR.Text = String.Empty;
            tbVendorSR.Text = String.Empty;
            tbQuantitySR.Text = String.Empty;
            tbPriceSR.Text = String.Empty;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

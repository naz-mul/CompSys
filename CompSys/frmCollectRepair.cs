using System;
using System.Collections;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CompSys
{
    public partial class frmCollectRepair : Form
    {
        #region GLOBAL VARIABLES

                // for Invoice Head:
        private string InvTitle;
        private string InvSubTitle1;
        private string InvSubTitle2;
        private string InvSubTitle3;
        private string InvImage;

        // for Report:
        private int CurrentY;
        private int CurrentX;
        private int leftMargin;
        private int rightMargin;
        private int topMargin;
        private int bottomMargin;
        private int InvoiceWidth;
        private int InvoiceHeight;

        private bool ReadInvoice;
        private int AmountPosition;

        private int TotalRowsChecked;
        private String Id_Selected;
        private ArrayList aList;

        // Font and Color:------------------
        // Title Font
        private Font InvTitleFont = new Font("Arial", 24, FontStyle.Regular);
        // Title Font height
        private int InvTitleHeight;
        // SubTitle Font
        private Font InvSubTitleFont = new Font("Arial", 14, FontStyle.Regular);
        // SubTitle Font height
        private int InvSubTitleHeight;
        // Invoice Font
        private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        // Invoice Font height
        private int InvoiceFontHeight;
        // Blue Color
        private SolidBrush BlueBrush = new SolidBrush(Color.Blue);
        // Red Color
        private SolidBrush RedBrush = new SolidBrush(Color.Red);
        // Black Color
        private SolidBrush BlackBrush = new SolidBrush(Color.Black);

        #endregion

        #region LOAD FORM
        public frmCollectRepair()
        {
            InitializeComponent();                              
        }
        #endregion

        #region LOAD DEFAULTS
        private void frmCollectRepair_Load(object sender, EventArgs e)
        {
            tabCollectRepair.TabPages.Remove(payTab);
            // Bind data grid view
            BindGrid("Invoiced", "r.repairdate");
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

        #region CHOOSE REPAIR
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

                FillListViewBoxFromDatabase();
                FillTextBoxFromDatabase();

                String estQuery = "SELECT * FROM Estimates WHERE Rep_ID = " + Id_Selected;
                String repQuery = "SELECT * FROM Repairs WHERE Rep_ID = " + Id_Selected;

                tbSubtotal.Text = GetSubTotal();
                tbVat.Text = Utils.GetSingleValue(estQuery, "VAT");
                tbDiscount.Text = Utils.GetSingleValue(estQuery, "Discount");
                tbTotal.Text = Utils.GetSingleValue(estQuery, "Total");
                CollectedDate.Value = DateTime.Now;
                tbRepairID.Text = Id_Selected;

                tabCollectRepair.TabPages.Remove(chooseTab);
                tabCollectRepair.TabPages.Insert(0, payTab);
                tabCollectRepair.SelectedTab = payTab;

                //tabControl.SelectedIndex = 2;
            }
            else if (TotalRowsChecked > 1)
            {
                // Get the Part_ID number
                foreach (String s in aList)
                {
                    ListOfIDsSelected += s + ", ";
                }

                ListOfIDsSelected = ListOfIDsSelected.Substring(0, ListOfIDsSelected.Length - 2);

                MessageBox.Show("Only one repair can be collected at a time. \nPlease make sure you only checked ONLY ONE repair!" +
                                "\nCurrently you selected these repairs: " + ListOfIDsSelected + ".",
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select ONE repair!",
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region FILL LIST VIEW BOX
        /// <summary>
        /// 
        /// </summary>
        private void FillListViewBoxFromDatabase()
        {
            try
            {
                listViewBox.View = View.Details;
                OracleConnection con = new OracleConnection(Utils.OracleConnectionString());
                String query = "SELECT  p.part_id, " +
                                      " p.part_name, " +
                                      " ep.quantity, " +
                                      " ep.retailprice " +
                               "FROM    parts p " +
                                      " JOIN estparts ep " +
                                      "     ON p.part_id = ep.part_id " +
                                      " LEFT JOIN repairs r " +
                                      "         ON ep.rep_id = r.rep_id " +
                               "WHERE   r.rep_id = " + Id_Selected;
                OracleDataAdapter ada = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["Part_ID"].ToString());
                    listitem.SubItems.Add(dr["Part_Name"].ToString());
                    listitem.SubItems.Add(dr["Quantity"].ToString());
                    listitem.SubItems.Add(dr["RetailPrice"].ToString());
                    listViewBox.Items.Add(listitem);
                }

                con.Close();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
            }
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

        #region FILL TEXT BOXES FROM DATABASE
        /// <summary>
        /// 
        /// </summary>
        private void FillTextBoxFromDatabase()
        {
            try
            {
                listViewBox.View = View.Details;
                OracleConnection con = new OracleConnection(Utils.OracleConnectionString());
                String query = "SELECT  c.surname, " +
                                      " c.forename, " +
                                      " c.address1, " +
                                      " c.address2, " +
                                      " c.town, " +
                                      " c.county, " +
                                      " c.telephone, " +
                                      " c.email " +
                               "FROM    customers c " +
                                      " JOIN repairs r " +
                                      "     ON c.cust_id = r.cust_id " +
                               "WHERE   r.rep_id = " + Id_Selected;
                OracleDataAdapter ada = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                StringBuilder result = new StringBuilder();
                int i = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (i == 0)
                            result.Append(dr[dc].ToString().Trim() + " ");
                        else
                            result.AppendLine(dr[dc].ToString().Trim());
                        i = 1;
                    }
                }

                BillToTextBox.Text = result.ToString();

                con.Close();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region MAKE PAYMENT
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCollect_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbTotal.Text.Trim()))
            {
               
                OracleTransaction transaction = null;
                OracleConnection con = null;

                // they will be used to decide whether to commit or rollback the transaction
                bool debitResult = false;

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
                        String date = CollectedDate.Value.ToString("dd-MMM-yyyy");
                        String queryEstimates = "UPDATE REPAIRS SET Status = 'Paid', CollectionDate =  '" + date +
                                                "' WHERE Rep_Id = " + Id_Selected;

                        cmd.CommandText = queryEstimates;   // Query here

                        // assosiate this command with transaction
                        cmd.Transaction = transaction;

                        debitResult = cmd.ExecuteNonQuery() == 1;
                    }

                    if (debitResult)
                    {
                        transaction.Commit();
                        
                        DialogResult dr = MessageBox.Show("Payment made successfully!\nDo you want print a receipt?",
                            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dr == DialogResult.Yes)
                        {
                            
                            PrintReport();
                            this.Close();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }

                catch (OracleException ex)
                {
                    MessageBox.Show("Sorry!\n" + ex.Message);
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
                MessageBox.Show("There is nothing to pay for this repair!");
        }
        #endregion

        #region RECEIPT PRINTING

        private void ReadInvoiceHead()
        {
            //Titles and Image of invoice:
            InvTitle = "PC Solutions";
            InvSubTitle1 = "Pembroke Street";
            InvSubTitle2 = "Tralee, Co Kerry";
            InvSubTitle3 = "Phone (066) 711 8242";
            InvImage = Application.StartupPath + @"\Images\" + "InvPic.jpg";

        }

        private void SetInvoiceHead(Graphics g)
        {
            ReadInvoiceHead();

            CurrentY = topMargin;
            CurrentX = leftMargin;
            int ImageHeight = 0;

            // Draw Invoice image:
            if (System.IO.File.Exists(InvImage))
            {
                Bitmap oInvImage = new Bitmap(InvImage);
                // Set Image Left to center Image:
                int xImage = CurrentX + (InvoiceWidth - oInvImage.Width) / 2;
                ImageHeight = oInvImage.Height; // Get Image Height
                g.DrawImage(oInvImage, xImage, CurrentY);
            }

            InvTitleHeight = (int)(InvTitleFont.GetHeight(g));
            InvSubTitleHeight = (int)(InvSubTitleFont.GetHeight(g));

            // Get Titles Length:
            int lenInvTitle = (int)g.MeasureString(InvTitle, InvTitleFont).Width;
            int lenInvSubTitle1 = (int)g.MeasureString(InvSubTitle1, InvSubTitleFont).Width;
            int lenInvSubTitle2 = (int)g.MeasureString(InvSubTitle2, InvSubTitleFont).Width;
            int lenInvSubTitle3 = (int)g.MeasureString(InvSubTitle3, InvSubTitleFont).Width;
            // Set Titles Left:
            int xInvTitle = CurrentX + (InvoiceWidth - lenInvTitle) / 2;
            int xInvSubTitle1 = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2;
            int xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            int xInvSubTitle3 = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2;

            // Draw Invoice Head:
            if (InvTitle != "")
            {
                CurrentY = CurrentY + ImageHeight;
                g.DrawString(InvTitle, InvTitleFont, BlueBrush, xInvTitle, CurrentY);
            }
            if (InvSubTitle1 != "")
            {
                CurrentY = CurrentY + InvTitleHeight;
                g.DrawString(InvSubTitle1, InvSubTitleFont, BlueBrush, xInvSubTitle1, CurrentY);
            }
            if (InvSubTitle2 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle2, InvSubTitleFont, BlueBrush, xInvSubTitle2, CurrentY);
            }
            if (InvSubTitle3 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle3, InvSubTitleFont, BlueBrush, xInvSubTitle3, CurrentY);
            }

            // Draw line:
            CurrentY = CurrentY + InvSubTitleHeight + 8;
            g.DrawLine(new Pen(Brushes.Black, 2), CurrentX, CurrentY, rightMargin, CurrentY);
        }

        private void SetOrderData(Graphics g)
        {// Set Company Name, City, Salesperson, Order ID and Order Date
            string FieldValue = "";
            InvoiceFontHeight = (int)(InvoiceFont.GetHeight(g));
            // Set Company Name:
            CurrentX = leftMargin;
            CurrentY = CurrentY + 8;
            FieldValue = BillToTextBox.Lines[0];
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            // Set Address:
            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = BillToTextBox.Lines[1];
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            // Set Order ID:
            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = BillToTextBox.Lines[3];
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = BillToTextBox.Lines[4];
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            // Set Contact Details:
            CurrentX = CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 16;
            FieldValue = BillToTextBox.Lines[5];
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
           

            // Draw line:
            CurrentY = CurrentY + InvoiceFontHeight + 8;
            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);
        }

        private void SetInvoiceData(Graphics g, System.Drawing.Printing.PrintPageEventArgs e)
        {// Set Invoice Table:
            string FieldValue = "";
            decimal Amount = 0;

            // Set Table Head:
            int xProductID = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("Product ID", InvoiceFont, BlueBrush, xProductID, CurrentY);

            int xProductName = xProductID + (int)g.MeasureString("Product ID", InvoiceFont).Width + 4;
            g.DrawString("Product Name", InvoiceFont, BlueBrush, xProductName, CurrentY);

            int xQuantity = xProductName + (int)g.MeasureString("Product Name", InvoiceFont).Width + 72;
            g.DrawString("Quantity", InvoiceFont, BlueBrush, xQuantity, CurrentY);

            AmountPosition = xQuantity + (int)g.MeasureString("Quantity", InvoiceFont).Width + 4;
            g.DrawString("Price", InvoiceFont, BlueBrush, AmountPosition, CurrentY);

            // Set Invoice Table:
            CurrentY = CurrentY + InvoiceFontHeight + 8;
            int i = 0;
            while (i < listViewBox.Items.Count)
            {          
                // Part ID
                FieldValue = listViewBox.Items[i].SubItems[0].Text.ToString();
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductID, CurrentY);
                
                //Part Name
                FieldValue = listViewBox.Items[i].SubItems[1].Text;
                // if Length of (Product Name) > 20, Draw 20 character only
                if (FieldValue.Length > 20)
                    FieldValue = FieldValue.Remove(20, FieldValue.Length - 20);
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductName, CurrentY);
                // Quantity
                FieldValue = listViewBox.Items[i].SubItems[2].Text;
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xQuantity, CurrentY);
                // Price
                Amount = Convert.ToDecimal(listViewBox.Items[i].SubItems[3].Text);
                // Format Extended Price and Align to Right:
                FieldValue = String.Format("{0:0.00}", Amount);
                int xAmount = AmountPosition + (int)g.MeasureString("Price", InvoiceFont).Width;
                xAmount = xAmount - (int)g.MeasureString(FieldValue, InvoiceFont).Width;
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xAmount, CurrentY);
                
                CurrentY = CurrentY + InvoiceFontHeight; 
                i++;
            }

            SetInvoiceTotal(g);           

            g.Dispose();
        }

        private void SetInvoiceTotal(Graphics g)
        {// Set Invoice Total:
            // Draw line:
            CurrentY = CurrentY + 8;
            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);
            // Get Right Edge of Invoice:
            int xRightEdg = AmountPosition + (int)g.MeasureString("Price €", InvoiceFont).Width;

            // Write Sub Total:
            int xSubTotal = AmountPosition - (int)g.MeasureString("Sub Total: ", InvoiceFont).Width;
            CurrentY = CurrentY + 8;
            g.DrawString("Sub Total", InvoiceFont, RedBrush, xSubTotal, CurrentY);
            string TotalValue = String.Format("{0:0.00}", tbSubtotal.Text);
            int xTotalValue = xRightEdg - (int)g.MeasureString(TotalValue, InvoiceFont).Width;
            g.DrawString(TotalValue, InvoiceFont, BlackBrush, xTotalValue, CurrentY);

            // Write VAT
            int xVAT = AmountPosition - (int)g.MeasureString("VAT %: ", InvoiceFont).Width;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("VAT %: ", InvoiceFont, RedBrush, xVAT, CurrentY);
            string VAT = String.Format("{0:0}", tbVat.Text);
            int xVATValue = xRightEdg - (int)g.MeasureString(VAT, InvoiceFont).Width;
            g.DrawString(VAT, InvoiceFont, BlackBrush, xVATValue, CurrentY);

            // Write Discount
            int xDiscount = AmountPosition - (int)g.MeasureString("Discount: ", InvoiceFont).Width;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("Discount: ", InvoiceFont, RedBrush, xDiscount, CurrentY);
            string DiscountValue = String.Format("{0:0.00}", tbDiscount.Text);
            int xDiscountValue = xRightEdg - (int)g.MeasureString(DiscountValue, InvoiceFont).Width;
            g.DrawString(DiscountValue, InvoiceFont, BlackBrush, xDiscountValue, CurrentY);

            // Write Invoice Total:
            int xInvoiceTotal = AmountPosition - (int)g.MeasureString("Total", InvoiceFont).Width;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("Total", InvoiceFont, RedBrush, xInvoiceTotal, CurrentY);
            string InvoiceValue = String.Format("{0:0.00}", tbTotal.Text);
            int xInvoiceValue = xRightEdg - (int)g.MeasureString(InvoiceValue, InvoiceFont).Width;
            g.DrawString(InvoiceValue, InvoiceFont, BlackBrush, xInvoiceValue, CurrentY);
        }

        // Result of the Event 'PrintPage'
        private void prnDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            leftMargin = (int)e.MarginBounds.Left;
            rightMargin = (int)e.MarginBounds.Right;
            topMargin = (int)e.MarginBounds.Top;
            bottomMargin = (int)e.MarginBounds.Bottom;
            InvoiceWidth = (int)e.MarginBounds.Width;
            InvoiceHeight = (int)e.MarginBounds.Height;

            if (!ReadInvoice)
                //ReadInvoiceData();

            SetInvoiceHead(e.Graphics); // Draw Invoice Head
            SetOrderData(e.Graphics); // Draw Order Data
            SetInvoiceData(e.Graphics, e); // Draw Invoice Data

            ReadInvoice = true;
        }


        private void PrintReport()
        {
            try
            {
                prnDialog.Document = this.prnDocument;
                DialogResult ButtonPressed = prnDialog.ShowDialog();
                // If user Click 'OK', Print Invoice
                if (ButtonPressed == DialogResult.OK)
                    prnDocument.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        #endregion

        #region SORTING DATA
        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("Invoiced", "r.rep_id");
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("Invoiced", "c.surname");
        }

        private void rbProb_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("Invoiced", "r.description");
        }

        private void rbDevice_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("Invoiced", "r.devicetype");
        }

        private void rbModel_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("Invoiced", "r.model");
        }

        private void rbRepDate_CheckedChanged(object sender, EventArgs e)
        {
            // Bind data grid view
            BindGrid("Invoiced", "r.repairdate");
        }
        #endregion

    }
}

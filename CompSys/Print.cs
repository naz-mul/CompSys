using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CompSys
{
    class Print
    {
       
        #region PRINTING OUT UTILITY METHODS - NOTHING SHOULD BE AMENDED

        #region GLOBAL VARIABLES NEEDED FOR PRINTING
        private static StringFormat strFormat; //Used to format the grid rows.
        private static ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        private static ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        private static int iCellHeight = 0; //Used to get/set the datagridview cell height
        private static int iTotalWidth = 0; //
        private static int iRow = 0;//Used as counter
        private static bool bFirstPage = false; //Used to check whether we are printing first page
        private static bool bNewPage = false;// Used to check whether we are printing a new page
        private static int iHeaderHeight = 0; //Used for the header height
        #endregion

        #region Print Page Event
        /// <summary>
        /// Handles the print page event of print document
        /// </summary>
        /// <param name="grid">The datagrid to print</param>
        /// <param name="e">Event Listener</param>
        /// <param name="header">The heading for the page</param>
        public static void PrintPageEvent(DataGridView grid, System.Drawing.Printing.PrintPageEventArgs e, string header)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in grid.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                            (double)iTotalWidth * (double)iTotalWidth *
                            ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                            GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headers
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= grid.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = grid.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allows more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString(header,
                                new Font(grid.Font, FontStyle.Bold),
                                Brushes.Red, e.MarginBounds.Left,
                                e.MarginBounds.Top - e.Graphics.MeasureString(header,
                                new Font(grid.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Height - 20);

                            String strDate = DateTime.Now.ToLongDateString() + " " +
                                DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate,
                                new Font(grid.Font, FontStyle.Bold), Brushes.Red,
                                e.MarginBounds.Left +
                                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                new Font(grid.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString(header,
                                new Font(new Font(grid.Font, FontStyle.Bold),
                                FontStyle.Bold), e.MarginBounds.Width).Height - 20);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in grid.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.Black),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight + 5));

                                e.Graphics.DrawRectangle(Pens.Red,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight + 5));

                                e.Graphics.DrawString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight + 5), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight + 5;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(),
                                    Cel.InheritedStyle.Font,
                                    new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount],
                                    (float)iTopMargin,
                                    (int)arrColumnWidths[iCount], (float)iCellHeight),
                                    strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iCellHeight));
                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }
                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Print Button Click Event
        /// <summary>
        /// Handles the print button click event
        /// </summary>
        /// <param name="printDoc">The generated document to print</param>
        /// <param name="PrintDocName">Name of the print document</param>
        public static void PrintButtonClickEvent(PrintDocument printDoc, string PrintDocName)
        {

            DialogResult dr = MessageBox.Show("Do you want to see a print preview?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                //Open the print preview dialog
                PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
                objPPdialog.Document = printDoc;
                objPPdialog.PrintPreviewControl.AutoZoom = false;
                ToolStripSplitButton zoomButton = ((ToolStrip)objPPdialog.Controls[1]).Items[1] as ToolStripSplitButton;
                zoomButton.DropDownItems[4].PerformClick();//Check the 100% item in the zoom list
                ((Form)objPPdialog).WindowState = FormWindowState.Maximized;
                objPPdialog.ShowDialog();
            }
            else
            {
                //Open the print dialog
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;
                printDialog.UseEXDialog = true;
                //Get the document
                if (DialogResult.OK == printDialog.ShowDialog())
                {
                    printDoc.DocumentName = PrintDocName;
                    printDoc.Print();
                }
            }
        }
        #endregion

        #region Begin Print Event Handler
        /// <summary>
        /// Handles the begin print event of print document
        /// </summary>
        /// <param name="grid">The data grid</param>
        public static void BeginPrintEventHandler(DataGridView grid)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in grid.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        
        #endregion




        #region INVOKING - ADD APPROPRIATE ARGUMENTS

        /*
        private void printRepairJobs_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Print.PrintPageEvent(dgvListJobs, e, "JOBS LISTING");

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print.PrintButtonClickEvent(printRepairJobs, "Jobs listing from DataGridView");

        }


        private void printRepairJobs_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Print.BeginPrintEventHandler(dgvListJobs);
        }
        */

        #endregion

    }
}

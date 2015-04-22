using System;
using System.Collections;
using System.Linq;
using System.Data.OracleClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CompSys
{
    class Utils
    {
        #region GLOBAL VARIABLES

        private static Boolean valid; // keeps an account of the insert/update/delete

        #endregion

        #region ORACLE CONNECTION STRING GENERATOR
        /// <summary>
        /// 1) Reads a text file from the local directory
        /// 2) Extracts substrings from the text and assigns them to the appropriate variables
        /// </summary>
        /// <returns>string output of the oracle connection</returns>
        public static string OracleConnectionString()
        {
           
            return frmLogin.oracle;
        }
        #endregion

        #region METHODS FOR STORING ORACLE CONNECTION SETTINGS INTO A TEXT FILE

        #region ASK THE USER FOR DATABASE DETAILS
        /// <summary>
        /// Asks user to enter oracle connection details
        /// DataSource, Username, Password
        /// </summary>
        /// <param name="location">The location of the database - college/home</param>
        public static void SetOracleConnectionDetails(string location)
        {
            Orcl oracle = new Orcl();

            oracle.dataSource = Microsoft.VisualBasic.Interaction.InputBox("Please enter the Oracle Data Source", "Oracle Data Source", "Oracle", -1, -1);
            oracle.username = Microsoft.VisualBasic.Interaction.InputBox("Please enter your username for the database connection", "Enter your username", "t00152975", -1, -1);
            oracle.password = Microsoft.VisualBasic.Interaction.InputBox("Please enter your password for the database connection", "Enter your password", "", -1, -1);

            WriteToFile(location, oracle.dataSource, oracle.username, oracle.password);
        }
        #endregion

        #region WRITE THE DATABASE INFORMATION TO A TEXT FILE
        /// <summary>
        /// Writes connection string to a text file
        /// </summary>
        /// <param name="path">The path to write the file</param>
        /// <param name="data">Oracle Data Source</param>
        /// <param name="user">Oracle Username</param>
        /// <param name="pass">Oracle Password</param>
        public static void WriteToFile(string path, string data, string user, string pass)
        {

            // Create a file to write to. 
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(data);
                sw.WriteLine(user);
                sw.WriteLine(pass);
            }

        }
        #endregion

        #region READS A TEXT FILE (Alternative)
        /// <summary>
        /// Reading a text file
        /// </summary>
        /// <param name="path">The file location</param>
        /// <returns>Concatenated string</returns>
        public static ArrayList ReadFromFile(string path)
        {
            ArrayList user = new ArrayList();
            // Open the file to read from. 
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    user.Add(s);
                }
            }
            //Console.WriteLine(user[0].ToString());
            return user;
        }
        #endregion

        #endregion

        #region LOGIN INTO THE SYSTEM
        /// <summary>
        /// This method is used to login to the system
        /// </summary>
        /// <param name="user">Username</param>
        /// <param name="pass">Password</param>
        /// <returns>returns true if the login is successful</returns>
        public static Boolean LoginFromDatabase(TextBox user, TextBox pass)
        {
            OracleDataAdapter orada;
            string oradb;
            string strQuery;
            DataTable dt;
            int RowCount;
            int i = 0;
            valid = false;

            try
            {
                string username = user.Text.Trim();
                string password = pass.Text.Trim();

                // Create an instance of an oracle Connection
                oradb = OracleConnectionString();
                //connectionString(oradb);

                // Create an instance of an Oracle Command to be executed
                OracleConnection connect = new OracleConnection(oradb);

                strQuery = "SELECT * FROM Staff WHERE USERNAME='" + username + "' AND PASSWORD='" + password + "'";
                OracleCommand cmd = new OracleCommand(strQuery, connect);

                // Specify that the command type is a string
                cmd.CommandType = CommandType.Text;

                // Check if the connection is alive
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                // Create a data adapter to contain the results of the query
                orada = new OracleDataAdapter(cmd);

                // Create a data table to store the data
                dt = new DataTable();

                // Fill up data into the data table
                orada.Fill(dt);

                // Count the rows in the data table
                RowCount = dt.Rows.Count;

                // Iterate through the table
                while (!valid && i < RowCount)
                {
                    // If username and password matches
                    if (username == dt.Rows[i]["USERNAME"].ToString().Trim() && password == dt.Rows[i]["PASSWORD"].ToString().Trim())
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }

                    i++;
                }

                // Close the connection stream
                connect.Close();
            }
            catch (OracleException ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

            return valid;
        } // end of login method
        #endregion

        #region LISTING ON DATA GRID VIEW
        /// <summary>
        /// This method lists data on the DataGridView
        /// </summary>
        /// <param name="grd">The DataGridView to list data</param>
        /// <param name="query">The oracle db query</param>
        public static void ListingOnDataGrid(DataGridView grd, string query)
        {
            string oradb = OracleConnectionString();
            try
            {
                valid = true;
                //Create an instance of an oracle Connection 
                OracleConnection conn = new OracleConnection(oradb);

                //Create an instance of an Oracle Command to be executed on 
                //the connection string conn
                OracleCommand cmd = new OracleCommand(query, conn);
                //Specify that the command type is a string 
                cmd.CommandType = CommandType.Text;

                //Create a data adapter to contain the results of the query 
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //create a dataset to hold the records returned by the query 
                DataSet ds = new DataSet();

                //fill the dataset with the contents of the data adapter
                da.Fill(ds, "ss");

                // Check if the data table is empty
                if (ds.Tables[0].Rows.Count == 0)
                {
                    valid = false;
                }
                else
                {
                    //bind the DataGridView to the results (contents of the dataset) 
                    grd.DataSource = ds.Tables["ss"];  // dataGridView1.DataBind();                   
                }

                conn.Close();
            }
            catch (OracleException ex)
            {
                //MessageBox.Show("No Record Found");
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region INSERTING INTO THE DATABASE
        /// <summary>
        /// This method inserts data into the database
        /// </summary>
        /// <param name="strSQL">The oracle db query</param>
        public static void InsertData(string strSQL)
        {
            valid = true;
            try
            {
                //Define Connection String 
                String oradb = OracleConnectionString();

                //Connect to Database 
                OracleConnection conn = new OracleConnection(oradb);

                conn.Open();

                //OracleCommand 
                OracleCommand cmd = conn.CreateCommand();
                cmd = conn.CreateCommand();

                cmd.CommandText = strSQL;

                //Execute SQL Query
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount < 1)
                {
                    valid = false;
                }

                //Close Database 
                conn.Close();
            }
            catch (OracleException ex)
            {
                valid = false;
                System.Windows.MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region UPDATE DATABASE ENTRIES
        /// <summary>
        /// This method updates data into the database
        /// </summary>
        /// <param name="strSQL">Oracle DB query</param>
        public static void UpdateData(string strSQL)
        {
            valid = true;
            try
            {
                //Define Connection String 
                String oradb = OracleConnectionString();

                //Connect to Database 
                OracleConnection conn = new OracleConnection(oradb);

                conn.Open();

                //OracleCommand 
                OracleCommand cmd = conn.CreateCommand();
                cmd = conn.CreateCommand();

                cmd.CommandText = strSQL;

                //Execute SQL Query
                int rowCount = cmd.ExecuteNonQuery();
                //System.Windows.Forms.MessageBox.Show(rowCount.ToString());

                if (rowCount < 1)
                {
                    valid = false;
                }
                //Close Database 
                conn.Close();
            }
            catch (OracleException ex)
            {
                valid = false;
                System.Windows.MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region GETS THE MAX ID FROM THE DATABASE
        /// <summary>
        /// This method gets the max id from the database
        /// If the table is empty, the method returns 1, otherwise the next incremented ID
        /// Used for insert, update
        /// </summary>
        /// <param name="strSQL">Oracle DB Query</param>
        /// <returns>string output of the max id</returns>
        public static string GetNextID(string strSQL)
        {
            string nextID = "";
            try
            {
                //Define database connection string
                String oradb = OracleConnectionString();

                //Create Oracle connection
                OracleConnection conn = new OracleConnection(oradb);

                //Define SQL query
                //String strSQL = "SELECT MAX(Cust_ID) FROM Customers";

                //Define Oracle command
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                conn.Open();

                //Execute SQL query and determine value returned
                //If no Stock records found, set next StockNo to 1
                if (cmd.ExecuteScalar().ToString().Equals(""))
                {
                    nextID = String.Format("1", "0000");
                }
                //Otherwise, set next StockNo to MAX + 1
                else
                {
                    nextID = String.Format(((decimal)cmd.ExecuteScalar() + 1).ToString(), "0000");
                }

                //Close DB connection
                conn.Close();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
            }

            return nextID;
        }
        #endregion

        #region GETS SINGLE VALUE
        /// <summary>
        /// This method gets a single value from the database
        /// If the table is empty, the method returns 1, otherwise the next incremented ID
        /// Used for insert, update
        /// </summary>
        /// <param name="strSQL">Oracle DB Query</param>
        /// <returns>string output of the max id</returns>
        public static String GetSingleValue(String strSQL, String ColName)
        {
            String GetSingleValue = "";

            try
            {              
                //Define database connection string
                String oradb = OracleConnectionString();

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
                    GetSingleValue = dt.Rows[0][ColName].ToString().Trim();
                }

                //Close DB connection
                conn.Close();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
            }

            return GetSingleValue;
        }
        #endregion

        #region VALIDATION METHODS

        /* This method checkes if insert was successful */
        public static Boolean IsSuccessful()
        {
            return valid;
        }
        //
        // This method returns true if the string contains letters and digits
        //
        public static bool IsAlphaNumeric(string str)
        {
            bool valid = true;

            Regex rgx = new Regex("^(([a-zA-Z0-9_][a-zA-Z0-9_ ])*[a-zA-Z0-9_]){0,50}$"); //^(?!.*?\\s{2})[A-Za-z ]{1,50}$
            if (rgx.IsMatch(str))
            {
                valid = false;
            }

            return valid;
        }

        //
        // This method returns true if the string contains letters only
        //
        public static bool IsAllLetter(string str)
        {
            bool valid = true;

            Regex rgx = new Regex("^(([a-zA-Z_][a-zA-Z_ ])*[a-zA-Z_]){0,50}$"); //^(?!.*?\\s{2})[A-Za-z ]{1,50}$
            if (rgx.IsMatch(str))
            {
                valid = false;
            }

            return valid;
        }
        //
        // This method returns true if the string contains digits only
        //
        public static bool IsAllDigits(string str)
        {
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns>returns true if the email is valid</returns>
        public static bool IsValidEmail(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //
        // This method returns true if these cases are true
        // at least 5-20 characters
        // 2 letters
        // 2 digits
        // 1 Uppercase
        // 1 Lowercase
        //
        public static bool IsValidPassword(string p)
        {
            return p.Length > 5 && p.Length < 21 && p.Count(c => char.IsDigit(c)) >= 2 && p.Count(c => char.IsUpper(c)) >= 1 && p.Count(c => char.IsLower(c)) >= 1;
        }

        //
        //Check if string contains whitespace
        //
        public static bool IsWhiteSpace(string s)
        {
            var regex = new Regex("^[\\-_]$");
            return regex.IsMatch(s);
        }

        #region INTEGER NUMBER VALIDATION
        /// <summary>
        /// Check if the String input is a Integer
        /// </summary>
        /// <param name="s"></param>
        /// <returns>True if the input is an Integer</returns>
        public static Boolean IsInt(String s)
        {
            try {
                Convert.ToInt32(s);
            }
            catch (FormatException)
            {
                return false;
            }   
            return true;
        }
        #endregion

        #region DOUBLE NUMBER VALIDATION
        /// <summary>
        /// Check if the String input is a Double
        /// </summary>
        /// <param name="s"></param>
        /// <returns>True if the input is double</returns>
        public static Boolean IsDouble(String s)
        {
            try
            {
                Convert.ToDouble(s);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }
        #endregion


        #endregion

        #region AUTOCOMPLETE TEXTBOXES
        /// <summary>
        /// 
        /// </summary>
        /// <param name="textbox">The textbox to auto complete</param>
        /// <param name="strQuery">Oracle string query</param>
        /// <param name="column">The table column</param>
        /// <returns></returns>

        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
        public static AutoCompleteStringCollection AutoComplete(TextBox textbox, string strQuery, string column)
        {
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();

            try
            {
                string oradb = OracleConnectionString();

                // Create an instance of an Oracle Command to be executed
                OracleConnection connect = new OracleConnection(oradb);

                //strQuery = "SELECT * FROM Staff WHERE forename LIKE '%" + textbox.Text.Trim() + "%'";
                //MessageBox.Show(strQuery);

                OracleCommand cmd = new OracleCommand(strQuery, connect);

                // Specify that the command type is a string
                cmd.CommandType = CommandType.Text;

                // Check if the connection is alive
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                // Create a data adapter to contain the results of the query
                OracleDataAdapter orada = new OracleDataAdapter(cmd);

                // Create a data table to store the data
                DataTable dt = new DataTable();

                // Fill up data into the data table
                orada.Fill(dt);

                // Count the rows in the data table
                int RowCount = dt.Rows.Count;

                //string row = RowCount.ToString();
                //MessageBox.Show(row);

                orada.Dispose();
                cmd.Dispose();

                if (RowCount > 0)
                {
                    int i = 0;
                    while (i < RowCount)
                    {
                        namesCollection.Add(dt.Rows[i][column.ToUpper()].ToString().Trim());
                        i++;
                    }
                }

                connect.Close();
            }
            catch (OracleException e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
            catch (AccessViolationException ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

            //textbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            //textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //textbox.AutoCompleteCustomSource = namesCollection;

            return namesCollection;
        }
        #endregion

        #region UPPERCASES FIRST LETTERS IN A STRING
        public static string UppercaseFirstLetter(string value)
        {
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
        #endregion

        #region CLEARS ALL THE CONTENTS FROM THE TEXTBOXES
        /// <summary>
        /// This method clears the texts from all the textboxes in the from
        /// </summary>
        /// <param name="con">The 'Control' object</param>
        public static void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        #endregion

    } // end of class
}

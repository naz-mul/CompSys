using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompSys
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]     
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            //Open main window      
            Form fLogin = new frmLogin();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
            else
            {
                Application.Exit();
            }
            
            //Application.Run(new frmQueryCustomer());
         
       }
    }
}

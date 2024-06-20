using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // initializing database
            DBConfig.InitializeDatabase();

            // deleting empty tables
            DBConfig.DeleteEmptyTables();

            Application.Run(new Auth.AuthForm());
            //Application.Run(new Employee.EmployeeMainForm());
        }
    }
}

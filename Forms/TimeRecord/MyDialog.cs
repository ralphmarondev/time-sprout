using System;
using System.Data.SQLite;
using System.Windows.Forms;
using TimeSprout.Core.DB;
using TimeSprout.Forms.TimeRecord.Model;

namespace TimeSprout.Forms.TimeRecord
{
    public partial class MyDialog : Form
    {
        private string employeeId, currentDate;
        public MyDialog()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;

            // making it readOnly
            //dateTimePicker1.Enabled = false;
        }

        public MyDialog(string _currentDate)
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Now;
            currentDate = _currentDate;
        }

        public MyDialog(string _employeeId, string _currentDate)
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Now;
            employeeId = _employeeId;
            currentDate = _currentDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TimeRecordDataClass record = new TimeRecordDataClass
            {
                ID = tbID.Text,
                EmployeeName = tbName.Text,
                CurrentProject = tbCurrentProject.Text,
                AmTimeIn = lblAmIn.Text,
                AmTimeOut = lblAmOut.Text,
                PmTimeIn = lblPmIn.Text,
                PmTimeOut = lblPmOut.Text,
                OtTimeIn = lblOtIn.Text,
                OtTimeOut = lblOtOut.Text,
                RecordDate = currentDate
            };
            Console.WriteLine($"Printing records for {currentDate}...");
            Console.WriteLine($"Id: {record.ID}, name: {record.EmployeeName}, currentProject: {record.CurrentProject}, amIn: {record.AmTimeIn}, amOut: {record.AmTimeOut}, pmIn: {record.PmTimeIn}, pmOut: {record.PmTimeOut}, otIn: {record.OtTimeIn}, otOut: {record.OtTimeOut}");

            if (DBTimeRecord.IsEmployeeRecordExists(currentDate: currentDate, id: record.ID))
            {
                DBTimeRecord.UpdateEmployeeTimeRecord(currentDate: currentDate, id: record.ID, amIn: record.AmTimeIn, amOut: record.AmTimeOut, pmIn: record.PmTimeIn, pmOut: record.PmTimeOut, otIn: record.OtTimeIn, otOut: record.OtTimeOut);
            }
            else
            {
                DBTimeRecord.CreateEmployeeTimeRecord(currentDate: currentDate, id: record.ID, name: record.EmployeeName, currentProject: record.CurrentProject, amIn: record.AmTimeIn, amOut: record.AmTimeOut, pmIn: record.PmTimeIn, pmOut: record.PmTimeOut, otIn: record.OtTimeIn, otOut: record.OtTimeOut);
            }
            Close();
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tbID.Text);
            bool exists = false;
            // read from database for such user with the given id
            // if found set it immediately inside the [tbName] and [tbCurrentProject]
            if (tbID.Text.Length > 0)
            {
                try
                {
                    using (var connection = new SQLiteConnection(DBConfig.connectionString))
                    {
                        connection.Open();

                        Console.WriteLine("Selecting count of employees with such id");
                        string countQuery = "SELECT COUNT(*) FROM employees WHERE id = @id";
                        using (var countCommand = new SQLiteCommand(countQuery, connection))
                        {
                            countCommand.Parameters.AddWithValue("@id", tbID.Text);

                            long count = (long)countCommand.ExecuteScalar();
                            exists = count > 0;
                        }

                        Console.WriteLine("Checking if count > 0");
                        if (exists)
                        {
                            Console.WriteLine("Count is greater than zero!");
                            string readQuery = "SELECT name, currentProject FROM employees WHERE id = @id;";
                            using (var readCommand = new SQLiteCommand(readQuery, connection))
                            {
                                readCommand.Parameters.AddWithValue("@id", tbID.Text);

                                Console.WriteLine("Reading name and curreent project.");
                                using (SQLiteDataReader reader = readCommand.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        tbName.Text = reader["name"].ToString();
                                        tbCurrentProject.Text = reader["currentProject"].ToString();
                                        Console.WriteLine($"name: {tbName.Text}, currentProject: {tbCurrentProject.Text}");
                                    }
                                    else
                                    {
                                        tbName.Text = "EMPLOYEE NOT EXIST";
                                        tbCurrentProject.Text = "EMPLOYEE NOT EXIST";
                                        Console.WriteLine("No data returned for the given id.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            tbName.Text = "EMPLOYEE NOT EXIST";
                            tbCurrentProject.Text = "EMPLOYEE NOT EXIST";
                            Console.WriteLine("Employee with given ID does not exist.");
                        }
                        Console.WriteLine("Done..");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                tbName.Text = "EMPLOYEE NAME";
                tbCurrentProject.Text = "CURRENT PROJECT";
            }
        }

        private void tbID_Leave(object sender, EventArgs e)
        {
            tbID_TextChanged(sender, e);
        }


        #region TIME_IN_AND_TIME_OUT
        private string GetCurrentTime()
        {
            DateTime _currentTime = DateTime.Now;
            string formattedTime = _currentTime.ToString("hh:mm");

            if (_currentTime.Hour < 10)
            {
                formattedTime = "0" + formattedTime;
            }

            Console.WriteLine($"Time now is: {formattedTime}");
            return formattedTime;
        }
        private void btnAmIn_Click(object sender, EventArgs e)
        {
            lblAmIn.Text = GetCurrentTime();
        }
        private void btnAmOut_Click(object sender, EventArgs e)
        {
            lblAmOut.Text = GetCurrentTime();
        }

        private void btnPmIn_Click(object sender, EventArgs e)
        {
            lblPmIn.Text = GetCurrentTime();
        }

        private void btnPmOut_Click(object sender, EventArgs e)
        {
            lblPmOut.Text = GetCurrentTime();
        }

        private void btnOtIn_Click(object sender, EventArgs e)
        {
            lblOtIn.Text = GetCurrentTime();
        }

        private void btnOtOut_Click(object sender, EventArgs e)
        {
            lblOtOut.Text = GetCurrentTime();
        }
        #endregion TIME_IN_AND_TIME_OUT


    }
}

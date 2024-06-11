using System;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;
using TimeSprout.Core.DB;
using TimeSprout.Core.Model;

namespace TimeSprout.Admin.Forms.TimeRecord.Forms
{
    public partial class CreateNewRecord : Form
    {
        private string currentDate;
        public CreateNewRecord()
        {
            InitializeComponent();
        }

        public CreateNewRecord(string _currentDate)
        {
            InitializeComponent();
            currentDate = _currentDate;

            // parse date with the currentDate passed
            Console.WriteLine($"Trying to parese the dateTimePicker with value: {currentDate}");
            DateTime parseDateTime;
            if (DateTime.TryParseExact(currentDate, "MMddyyyy", null, System.Globalization.DateTimeStyles.None, out parseDateTime))
            {
                dateTimePicker1.Value = parseDateTime;
                Console.WriteLine("Parsed successfully.");
            }
            else
            {
                Console.WriteLine("Cannot parse date.");
                dateTimePicker1.Value = DateTime.Now;
            }
        }


        private void CreateNewRecord_Load(object sender, EventArgs e)
        {
            // parse date with the currentDate passed
            DateTime parseDateTime;
            if (DateTime.TryParseExact(currentDate, "MMddyyyy", null, System.Globalization.DateTimeStyles.None, out parseDateTime))
            {
                dateTimePicker1.Value = parseDateTime;
            }
            else
            {
                Console.WriteLine("Cannot parse date.");
                dateTimePicker1.Value = DateTime.Now;
            }

            lblDayOfWeek.Text = dateTimePicker1.Value.ToString("dddd");

            // TODO: select all employee and add them on tbID
            PopulateTbIdComboBox();
        }


        #region TB_ID
        private void PopulateTbIdComboBox()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(DBConfig.connectionString);
                {
                    connection.Open();

                    string query = "SELECT id FROM employees";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tbId.Items.Add(reader["id"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        private void tbId_TextChanged(object sender, EventArgs e)
        {

            try
            {
                Console.WriteLine("Checking if employee exists on database or has already a record for this day...");
                //EmployeeModel employee = null;
                if (DBTimeRecord.IsEmployeeTimeRecordExists(_currentDate: currentDate, _id: tbId.Text))
                {
                    Console.WriteLine("Employee has a record for this day.");
                    MessageBox.Show($"Employee with id: [{tbId.Text}], already has an record for this day. You can update it by searching his/her name if you cannot find it using the search field.");
                }
                else
                {
                    Console.WriteLine($"Checking if employees with id: {tbId.Text} exists...");
                    if (DBEmployee.IsEmployeeIdTaken(_id: tbId.Text))
                    {
                        Console.WriteLine($"Id: {tbId.Text} is taken.");
                        EmployeeModel employee = new EmployeeModel(_id: tbId.Text, _name: "", _password: "", _currentProject: "");
                        employee = DBEmployee.ReadEmployeeDetails(_id: tbId.Text);

                        if (employee != null)
                        {
                            tbEmployeeName.Text = employee.name;
                            tbCurrentProject.Text = employee.currentProject;
                        }
                        else
                        {
                            MessageBox.Show("Employee with that id does not exist in the database.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee with that id does not exists on the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error [tbId_Leave]: {ex.Message}");
            }

        }
        #endregion TB_ID


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBTimeRecord.IsEmployeeTimeRecordExists(_currentDate: currentDate, _id: tbId.Text))
            {
                MessageBox.Show("Record already exists. You can search it using the search field if you cannot find it.");
                Hide();
            }
            else
            {
                if (tbId.Text == string.Empty || tbEmployeeName.Text == string.Empty || tbEmployeeName.Text == string.Empty)
                {
                    MessageBox.Show("Please fill in all fields.");
                }
                else
                {
                    Console.WriteLine($"Checking if employee: {tbId.Text} exists in database...");
                    if (DBEmployee.IsEmployeeIdTaken(_id: tbId.Text))
                    {
                        Console.WriteLine("Emloyee is valid.");

                        // TODO: CHECK IF THE TIME ARE CORRECT.
                        Console.WriteLine($"Is time in and out valid: {isTimeInOutValid()}. Implement this!");

                        DBTimeRecord.CreateEmployeeTimeRecord(_currentDate: currentDate,
                            _record: new TimeRecordModel(_id: tbId.Text, _employeeName: tbEmployeeName.Text,
                            _currentProject: tbCurrentProject.Text, _amTimeIn: tbAmTimeIn.Text, _amTimeOut: tbAmTimeOut.Text,
                            _pmTimeIn: tbPmTimeIn.Text, _pmTimeOut: tbPmTimeOut.Text, _otTimeIn: tbOtTimeIn.Text, _otTimeOut: tbOtTimeOut.Text));

                        Close();
                        Console.WriteLine("Saved.");
                    }
                    else
                    {
                        MessageBox.Show("Failed! Invalid Id.");
                    }
                }
            }
        }

        private void tbId1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tbId.Text);

            //if (DBEmployee.IsEmployeeIdTaken(_id: tbId.Text))
            //{
            //    EmployeeModel employee = DBEmployee.ReadEmployeeDetails(_id: tbId.Text);

            //    tbEmployeeName.Text = employee.name;
            //    tbCurrentProject.Text = employee.currentProject;
            //}
        }


        private void tbId1_Leave(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Checking if employee exists on database or has already a record for this day...");
                //EmployeeModel employee = null;
                if (DBTimeRecord.IsEmployeeTimeRecordExists(_currentDate: currentDate, _id: tbId.Text))
                {
                    Console.WriteLine("Employee has a record for this day.");
                    MessageBox.Show($"Employee with id: [{tbId.Text}], already has an record for this day. You can update it by searching his/her name if you cannot find it using the search field.");
                }
                else
                {
                    Console.WriteLine($"Checking if employees with id: {tbId.Text} exists...");
                    if (DBEmployee.IsEmployeeIdTaken(_id: tbId.Text))
                    {
                        Console.WriteLine($"Id: {tbId.Text} is taken.");
                        EmployeeModel employee = new EmployeeModel(_id: tbId.Text, _name: "", _password: "", _currentProject: "");
                        employee = DBEmployee.ReadEmployeeDetails(_id: tbId.Text);

                        if (employee != null)
                        {
                            tbEmployeeName.Text = employee.name;
                            tbCurrentProject.Text = employee.currentProject;
                        }
                        else
                        {
                            MessageBox.Show("Employee with that id does not exist in the database.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee with that id does not exists on the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error [tbId_Leave]: {ex.Message}");
            }

        }


        #region TIME_IN_OUT
        private string getCurrentTime()
        {
            DateTime _currentTime = DateTime.Now;
            string formattedTime = _currentTime.ToString("hh:mm");

            //if (_currentTime.Hour < 10)
            //{
            //    formattedTime = "0" + formattedTime;
            //}

            Console.WriteLine($"Time now is: {formattedTime}");
            return formattedTime;
        }
        private void btnAmTimeIn_Click(object sender, EventArgs e)
        {
            tbAmTimeIn.Text = getCurrentTime();
        }

        private void btnAmTimeOut_Click(object sender, EventArgs e)
        {
            tbAmTimeOut.Text = getCurrentTime();
        }

        private void btnPmTimeIn_Click(object sender, EventArgs e)
        {
            tbPmTimeIn.Text = getCurrentTime();
        }

        private void btnPmTimeOut_Click(object sender, EventArgs e)
        {
            tbPmTimeOut.Text = getCurrentTime();
        }

        private void btnOtTimeIn_Click(object sender, EventArgs e)
        {
            tbOtTimeIn.Text = getCurrentTime();
        }

        private void btnOtTimeOut_Click(object sender, EventArgs e)
        {
            tbOtTimeOut.Text = getCurrentTime();
        }

        #endregion TIME_IN_OUT


        #region VALIDATION
        private bool isTimeInOutValid()
        {
            DateTime amTimeIn, amTimeOut, pmTimeIn, pmTimeOut;
            string timeFormat = "hh:mm";

            bool isAmTimeInValid = DateTime.TryParseExact(tbAmTimeIn.Text, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out amTimeIn);
            bool isAmTimeOutValid = DateTime.TryParseExact(tbAmTimeOut.Text, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out amTimeOut);
            bool isPmTimeInValid = DateTime.TryParseExact(tbPmTimeIn.Text, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out pmTimeIn);
            bool isPmTimeOutValid = DateTime.TryParseExact(tbPmTimeOut.Text, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out pmTimeOut);

            if (isAmTimeInValid && isAmTimeOutValid && isPmTimeInValid && isPmTimeOutValid)
            {
                if (amTimeIn.Hour == 12) amTimeIn = amTimeIn.AddHours(-12);
                if (amTimeOut.Hour == 12) amTimeOut = amTimeOut.AddHours(-12);
                if (pmTimeIn.Hour == 12) pmTimeIn = pmTimeIn.AddHours(12);
                if (pmTimeOut.Hour == 12) pmTimeOut = pmTimeOut.AddHours(12);

                // checking if am time in - out is valid [8am >= time < 12pm]
                DateTime amStartTime = DateTime.ParseExact("08:00", timeFormat, CultureInfo.InvariantCulture);
                DateTime amEndTime = DateTime.ParseExact("12:00", timeFormat, CultureInfo.InvariantCulture);

                if (amTimeIn >= amStartTime && amTimeOut < amEndTime)
                {
                    Console.WriteLine("Valid am field. Time in is greater than or equal to 6am and lesst that 12 noon.");
                }
                else
                {
                    Console.WriteLine("Invalid Am time.");
                    return false;
                }

                // checking if pm time in - out is valid [1pm >= time < 6pm]
                DateTime pmStartTime = DateTime.ParseExact("13:00", "hh:mm", CultureInfo.InvariantCulture);
                DateTime pmEndTime = DateTime.ParseExact("18:00", "hh:mm", CultureInfo.InvariantCulture);

                if (pmTimeIn >= pmStartTime && pmTimeOut < pmEndTime)
                {
                    Console.WriteLine("Valide pm fields. Time in is greater than or equal 10 1pm and less than 6pm.");
                }
                else
                {
                    Console.WriteLine("Invalid Pm Time");
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
        #endregion VALIDATION

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDayOfWeek.Text = dateTimePicker1.Value.ToString("dddd");

            currentDate = dateTimePicker1.Value.ToString("MMddyyyy");
        }
    }
}

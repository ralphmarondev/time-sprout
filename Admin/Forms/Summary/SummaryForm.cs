using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using TimeSprout.Admin.Forms.TimeRecord.Dialog;
using TimeSprout.Core.DB;
using TimeSprout.Core.Model;

namespace TimeSprout.Admin.Forms.Summary
{
    public partial class SummaryForm : Form
    {
        private string username, password, fullName;

        public SummaryForm()
        {
            InitializeComponent();
        }

        public SummaryForm(string _username, string _password, string _fullName)
        {
            InitializeComponent();

            username = _username;
            password = _password;
            fullName = _fullName;
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            SetupEmployeeDetails();
            SetupCurrentDate();

            _currentDate = dateTimePicker2.Value;
            PopulateDataGridViewWithRecordToday(_currentDate);
        }


        #region ON_LOAD
        private void SetupEmployeeDetails()
        {
            lblAdminName.Text = fullName;
        }
        private void SetupCurrentDate()
        {
            dateTimePicker2.Value = DateTime.Now;
            // Set the DateTimePicker format to Custom
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            // Define the custom format string
            dateTimePicker2.CustomFormat = "dd/MM/yyyy - ddd";

            tbCurrentDate.Text = dateTimePicker2.Value.ToString("dd/MM/yyyy - ddd");
        }

        private void PopulateDataGridView()
        {
            dataGridView1.Controls.Clear();
            DateTime startDate = new DateTime(2024, 6, 14);
            DateTime endDate = DateTime.Now;

            DataTable summaryData = GetSummaryData(startDate, endDate);
            dataGridView1.DataSource = summaryData;

            dataGridView1.Columns["Date"].HeaderText = "Date";
            dataGridView1.Columns["id"].HeaderText = "Employee ID";
            dataGridView1.Columns["name"].HeaderText = "Employee Name";
            dataGridView1.Columns["currentProject"].HeaderText = "Current Project";
            dataGridView1.Columns["workingHour"].HeaderText = "Worked Hour";
            dataGridView1.Columns["overtime"].HeaderText = "Overtime";
        }

        private DataTable GetSummaryData(DateTime startDate, DateTime endDate)
        {
            DataTable summary = new DataTable();
            // Define the structure of your summary DataTable with all columns as strings
            summary.Columns.Add("Date", typeof(string));
            summary.Columns.Add("id", typeof(string));
            summary.Columns.Add("name", typeof(string));
            summary.Columns.Add("currentProject", typeof(string));
            summary.Columns.Add("workingHour", typeof(string));
            summary.Columns.Add("overtime", typeof(string));


            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                string tableName = $"record_{date:ddMMyyyy}";
                string query = $"SELECT id AS id, name AS name, currentProject AS CurrentProject, workingHour AS workingHour, overtime AS overtime FROM {tableName};";

                using (SQLiteConnection connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        try
                        {

                            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                            {
                                DataTable dailyDataTable = new DataTable();
                                adapter.Fill(dailyDataTable);

                                foreach (DataRow row in dailyDataTable.Rows)
                                {
                                    DataRow newRow = summary.NewRow();
                                    newRow["Date"] = date.ToString("dd-MM-yyyy");
                                    newRow["id"] = row["id"].ToString();
                                    newRow["name"] = row["name"].ToString();
                                    newRow["currentProject"] = row["CurrentProject"].ToString();
                                    newRow["workingHour"] = row["workingHour"].ToString();
                                    newRow["overtime"] = row["overtime"].ToString();

                                    summary.Rows.Add(newRow);
                                }
                            }
                            //summary.Merge(dailyDataTable);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error accessing table {tableName}: {ex.Message}");
                        }
                    }
                }
            }

            return summary;
        }

        // HACK: HANDLING CELL CLICK
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string date = row.Cells["Date"].Value.ToString().Replace("-", "");
                string id = row.Cells["id"].Value.ToString();

                // get data
                TimeRecordModel record = DBTimeRecord.ReadEmployeeTimeRecord(_currentDate: date, _id: id);

                UpdateDeleteTimeRecord updateDeleteTimeRecord = new UpdateDeleteTimeRecord(
                    _id: record.id,
                    _name: record.employeeName,
                    _currentProject: record.currentProject,
                    _amTimeIn: record.amTimeIn,
                    _amTimeOut: record.amTimeOut,
                    _pmTimeIn: record.pmTimeIn,
                    _pmTimeOut: record.pmTimeOut,
                    _otTimeIn: record.otTimeIn,
                    _otTimeOut: record.otTimeOut,
                    _workinghour: record.workingHour,
                    _overtime: record.overtime,
                    _date: date);

                updateDeleteTimeRecord.StartPosition = FormStartPosition.CenterParent;
                updateDeleteTimeRecord.ShowDialog(this);

                PopulateDataGridViewWithRecordToday(_currentDate);
            }
        }
        #endregion ON_LOAD



        DateTime _currentDate;
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // TODO: ONLY SHOW TIME RECORD ON THAT SPECIFIC DAY
            _currentDate = dateTimePicker2.Value;
            PopulateDataGridViewWithRecordToday(_currentDate);
        }

        #region RecordForToday
        private void PopulateDataGridViewWithRecordToday(DateTime _currentDate)
        {
            dataGridView1.Controls.Clear();

            DataTable summaryData = GetSummaryDataWithRecordToday(_currentDate);
            dataGridView1.DataSource = summaryData;

            dataGridView1.Columns["Date"].HeaderText = "Date";
            dataGridView1.Columns["id"].HeaderText = "Employee ID";
            dataGridView1.Columns["name"].HeaderText = "Employee Name";
            dataGridView1.Columns["currentProject"].HeaderText = "Current Project";
            dataGridView1.Columns["workingHour"].HeaderText = "Worked Hour";
            dataGridView1.Columns["overtime"].HeaderText = "Overtime";
        }

        private DataTable GetSummaryDataWithRecordToday(DateTime _currentDate)
        {
            DataTable summary = new DataTable();
            // Define the structure of your summary DataTable with all columns as strings
            summary.Columns.Add("Date", typeof(string));
            summary.Columns.Add("id", typeof(string));
            summary.Columns.Add("name", typeof(string));
            summary.Columns.Add("currentProject", typeof(string));
            summary.Columns.Add("workingHour", typeof(string));
            summary.Columns.Add("overtime", typeof(string));


            string formattedDate = _currentDate.ToString("ddMMyyyy");

            string tableName = $"record_{formattedDate}";
            string query = $"SELECT id AS id, name AS name, currentProject AS CurrentProject, workingHour AS workingHour, overtime AS overtime FROM {tableName};";

            using (SQLiteConnection connection = new SQLiteConnection(DBConfig.connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dailyDataTable = new DataTable();
                            adapter.Fill(dailyDataTable);

                            foreach (DataRow row in dailyDataTable.Rows)
                            {
                                DataRow newRow = summary.NewRow();
                                newRow["Date"] = _currentDate.ToString("dd-MM-yyyy");
                                newRow["id"] = row["id"].ToString();
                                newRow["name"] = row["name"].ToString();
                                newRow["currentProject"] = row["CurrentProject"].ToString();
                                newRow["workingHour"] = row["workingHour"].ToString();
                                newRow["overtime"] = row["overtime"].ToString();

                                summary.Rows.Add(newRow);
                            }
                        }
                        //summary.Merge(dailyDataTable);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error accessing table {tableName}: {ex.Message}");
                    }
                }
            }
            return summary;
        }
        #endregion RecordForToday



        #region Utils
        private string GetFormattedDate()
        {
            DateTime selectedDate = dateTimePicker2.Value;
            string formattedDate = selectedDate.ToString("ddMMyyyy");

            Console.WriteLine($"Formatted date: {formattedDate}");
            return formattedDate;
        }
        #endregion Utils



        #region Export
        private void btnExport_Click(object sender, EventArgs e)
        {
            string excelPath = $"..\\full_timerecord.xlsx";

            try
            {
                var workbook = new XLWorkbook();

                using (var connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    string queryTableNames = "SELECT name FROM sqlite_master WHERE type = 'table' AND name LIKE 'record_%'";

                    using (var commandTableNames = new SQLiteCommand(queryTableNames, connection))
                    {
                        using (var reader = commandTableNames.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tableName = reader["name"].ToString();

                                string queryData = $"SELECT * FROM {tableName}";

                                using (var commandData = new SQLiteCommand(queryData, connection))
                                {
                                    using (var adapter = new SQLiteDataAdapter(commandData))
                                    {
                                        DataTable dataTable = new DataTable();
                                        adapter.Fill(dataTable);

                                        workbook.Worksheets.Add(dataTable, tableName);
                                    }
                                }

                            }
                        }
                    }
                }

                workbook.SaveAs(excelPath);

                Console.WriteLine($"Data exported to {excelPath} successfully.");
                MessageBox.Show("Data exported successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        #endregion Export
    }
}

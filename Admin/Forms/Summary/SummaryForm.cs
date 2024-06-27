using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using TimeSprout.Admin.Forms.TimeRecord.Dialog;
using TimeSprout.Core.DB;
using TimeSprout.Core.Model;

namespace TimeSprout.Admin.Forms.Summary
{
    public partial class SummaryForm : Form
    {
        private string username, password, fullName;
        private string startTime, endTime;

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
            SetupStartEndTime();

            PopulateDataGridViewWithRecordToday(dtStartDateTime.Value);
        }


        #region ON_LOAD
        private void SetupEmployeeDetails()
        {
            lblAdminName.Text = fullName;
        }
        private void SetupCurrentDate()
        {
            dtStartDateTime.Value = DateTime.Now;
            dtEndDateTime.Value = DateTime.Now;
            // Set the DateTimePicker format to Custom
            dtStartDateTime.Format = DateTimePickerFormat.Custom;
            dtEndDateTime.Format = DateTimePickerFormat.Custom;

            // Define the custom format string
            dtStartDateTime.CustomFormat = "dd/MM/yyyy - ddd";
            dtEndDateTime.CustomFormat = "dd/MM/yyyy - ddd";

            tbCurrentDate.Text = dtStartDateTime.Value.ToString("dd/MM/yyyy - ddd");
        }

        private void SetupStartEndTime()
        {
            startTime = dtStartDateTime.Value.ToString("ddMMyyyy");
            endTime = dtEndDateTime.Value.ToString("ddMMyyyy");
        }
        #endregion ON_LOAD



        #region WIthStartEndTime
        private void PopulateDataGridView()
        {
            dataGridView1.Controls.Clear();
            //DateTime startDate = new DateTime(2024, 6, 14);
            //DateTime endDate = DateTime.Now;
            Console.WriteLine($"Populating datagridview from: {dtStartDateTime.Value} to {dtEndDateTime.Value}");
            DataTable summaryData = GetSummaryData(startDate: dtStartDateTime.Value, endDate: dtEndDateTime.Value);
            dataGridView1.DataSource = summaryData;

            dataGridView1.Columns["Date"].HeaderText = "Date";
            dataGridView1.Columns["id"].HeaderText = "Employee ID";
            dataGridView1.Columns["name"].HeaderText = "Employee Name";
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
            summary.Columns.Add("workingHour", typeof(string));
            summary.Columns.Add("overtime", typeof(string));

            Console.WriteLine($"From: {startDate} to {endDate}");

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                string tableName = $"record_{date:ddMMyyyy}";
                string query = $"SELECT id AS id, name AS name, workingHour AS workingHour, overtime AS overtime FROM {tableName};";

                string _empId = tbEmpID.Text.Trim();
                if (!string.IsNullOrEmpty(_empId))
                {
                    query = $"SELECT id AS id, name AS name, workingHour AS workingHour, overtime AS overtime FROM {tableName} WHERE id = @id;";
                }

                using (SQLiteConnection connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", _empId);
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
        #endregion WithStartEndTime



        #region RecordForToday
        private void PopulateDataGridViewWithRecordToday(DateTime _currentDate)
        {
            dataGridView1.Controls.Clear();

            DataTable summaryData = GetSummaryDataWithRecordToday(_currentDate: _currentDate);
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

            string _empId = tbEmpID.Text.Trim();
            if (!string.IsNullOrEmpty(_empId))
            {
                query = $"SELECT id AS id, name AS name, currentProject AS CurrentProject, workingHour AS workingHour, overtime AS overtime FROM {tableName} WHERE id = @id;";
            }

            using (SQLiteConnection connection = new SQLiteConnection(DBConfig.connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", _empId);
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




        #region DataGridView_ClickEvent

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

                PopulateDataGridViewWithRecordToday(dtStartDateTime.Value);
            }
        }
        #endregion DataGridView_ClickEvent




        #region DateTimePicker_ValueChanged

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            SetupStartEndTime();
            // compare start and end time
            if (dtEndDateTime.Value > dtStartDateTime.Value)
            {
                PopulateDataGridView();
            }
            else
            {
                PopulateDataGridViewWithRecordToday(dtStartDateTime.Value);
            }
        }
        private void dbEndDateTime_ValueChanged(object sender, EventArgs e)
        {
            SetupStartEndTime();
            // compare start and end time
            if (dtEndDateTime.Value > dtStartDateTime.Value)
            {
                PopulateDataGridView();
            }
            else
            {
                PopulateDataGridViewWithRecordToday(dtStartDateTime.Value);
            }
        }
        #endregion DateTimePicker_ValueChanged



        #region Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SetupStartEndTime();
            // compare start and end time
            if (dtEndDateTime.Value > dtStartDateTime.Value)
            {
                PopulateDataGridView();
            }
            else
            {
                PopulateDataGridViewWithRecordToday(dtStartDateTime.Value);
            }
        }
        #endregion Search



        #region Utils
        private string GetFormattedDate()
        {
            DateTime selectedDate = dtStartDateTime.Value;
            string formattedDate = selectedDate.ToString("ddMMyyyy");

            Console.WriteLine($"Formatted date: {formattedDate}");
            return formattedDate;
        }
        #endregion Utils



        #region Export
        // export only with the given parameters
        private void btnExport_Click(object sender, EventArgs e)
        {
            exportContentOfDataGridView();
        }

        private void exportContentOfDataGridView()
        {
            string _tbEmpId = tbEmpID.Text.Trim();
            string excelPath = $"..\\{startTime}-{endTime}-{_tbEmpId}_timerecord.xlsx";

            try
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // Add column headers
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                }

                // Add rows
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                workbook.SaveAs(excelPath);

                Console.WriteLine($"Data exported to {excelPath} successfully.");
                MessageBox.Show("Data exported successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void exportFromQuery()
        {
            string excelPath = $"..\\{startTime}-{endTime}_timerecord.xlsx";
            DateTime startDateTime = DateTime.ParseExact(startTime, "ddMMyyyy", CultureInfo.InvariantCulture);
            DateTime endDateTime = DateTime.ParseExact(endTime, "ddMMyyyy", CultureInfo.InvariantCulture);

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
                                string datePart = tableName.Replace("record_", "");

                                if (DateTime.TryParseExact(datePart, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime tableDate))
                                {
                                    if (tableDate >= startDateTime && tableDate <= endDateTime)
                                    {
                                        string queryData = $"SELECT * FROM {tableName}";  // Replace datetimeColumn with your actual column name

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
                    }
                }

                workbook.SaveAs(excelPath);

                Console.WriteLine($"Data exported to {excelPath} successfully.");
                MessageBox.Show("Data exported successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        // export all
        private void button1_Click(object sender, EventArgs e)
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



        #region DRAG_AND_DROP_TITLE
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.ParentForm.Location;
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                AdminMainForm mainForm = this.ParentForm as AdminMainForm;

                if (mainForm != null)
                {
                    mainForm.Location = Point.Add(dragFormPoint, new Size(diff));
                }
            }
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion DRAG_AND_DROP_TITLE

        #region TopBar
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            AdminMainForm mainForm = this.ParentForm as AdminMainForm;

            if (mainForm != null)
            {
                mainForm.ToggleFullScreen();
            }
        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            AdminMainForm mainForm = this.ParentForm as AdminMainForm;

            if (mainForm != null)
            {
                mainForm.LogoutForm();
            }
        }

        private void btnToggleNavPanel_Click(object sender, EventArgs e)
        {
            AdminMainForm mainForm = this.ParentForm as AdminMainForm;

            if (mainForm != null)
            {
                mainForm.ToggleNavigationPanel();
            }
        }
        #endregion TopBar


    }
}

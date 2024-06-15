using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Employee.Forms.Summary
{
    public partial class SumarryForm : Form
    {
        private string id, name, password, currentProject;

        public SumarryForm()
        {
            InitializeComponent();

            // for testing only :)
            id = "2024-001";
        }

        public SumarryForm(string _id, string _name, string _password, string _currentProject)
        {
            InitializeComponent();

            id = _id;
            name = _name;
            password = _password;
            currentProject = _currentProject;
        }

        private void SumarryForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Summary Form loaded.");
            SetupEmployeeDetails();
            SetupCurrentDate();
            PopulateDataGridView();
        }

        private void SetupEmployeeDetails()
        {
            lblEmployeeName.Text = name;
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
            DateTime startDate = new DateTime(2024, 6, 14);
            DateTime endDate = DateTime.Now;

            DataTable summaryData = GetSummaryData(startDate, endDate);
            dataGridView1.DataSource = summaryData;

            dataGridView1.Columns["Date"].HeaderText = "Date";
            dataGridView1.Columns["currentProject"].HeaderText = "Current Project";
            dataGridView1.Columns["workingHour"].HeaderText = "Worked Hour";
            dataGridView1.Columns["overtime"].HeaderText = "Overtime";
        }

        private DataTable GetSummaryData(DateTime startDate, DateTime endDate)
        {
            DataTable summary = new DataTable();
            // Define the structure of your summary DataTable with all columns as strings
            summary.Columns.Add("Date", typeof(string));
            summary.Columns.Add("currentProject", typeof(string));
            summary.Columns.Add("workingHour", typeof(string));
            summary.Columns.Add("overtime", typeof(string));


            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                string tableName = $"record_{date:ddMMyyyy}";
                string query = $"SELECT currentProject AS CurrentProject, workingHour AS workingHour, overtime AS overtime FROM {tableName} WHERE id = @id;";

                if (!TableExists(tableName))
                {
                    Console.WriteLine($"Table {tableName} does not exists.");
                    //continue;
                }

                using (SQLiteConnection connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        try
                        {

                            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                            {
                                DataTable dailyDataTable = new DataTable();
                                adapter.Fill(dailyDataTable);

                                foreach (DataRow row in dailyDataTable.Rows)
                                {
                                    DataRow newRow = summary.NewRow();
                                    newRow["Date"] = date.ToString("dd/MM/yyyy");
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

        private bool TableExists(string _tableName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DBConfig.connectionString))
            {
                string query = $"SELECT COUNT(*) FROM INFORMATION_SCHEME.TALBES WHERE TABLE_NAME = '{_tableName}'";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error checking table existence: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        // HACK: HANDLING CELL CLICK
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row index is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Extract data from the clicked row
                string date = row.Cells["Date"].Value.ToString();
                string currentProject = row.Cells["currentProject"].Value.ToString();
                string workingHour = row.Cells["workingHour"].Value.ToString();
                string overtime = row.Cells["overtime"].Value.ToString();

                // Display data in a MessageBox
                string message = $"Date: {date}\nName: {name}\nCurrent Project: {currentProject}\n" +
                                 $"Working Hour: {workingHour}\nOvertime: {overtime}";

                MessageBox.Show(message, "Row Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



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

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                EmployeeMainForm mainForm = this.ParentForm as EmployeeMainForm;

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



        #region EXPORT
        private void btnExport_Click(object sender, EventArgs e)
        {

        }
        #endregion EXPORT



        #region TOP_BAR
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            EmployeeMainForm mainForm = this.ParentForm as EmployeeMainForm;

            if (mainForm != null)
            {
                mainForm.ToggleFullScreen();
            }
        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            EmployeeMainForm mainForm = this.ParentForm as EmployeeMainForm;

            if (mainForm != null)
            {
                // TODO: IMPLEMENT THIS!
            }
        }

        private void btnToggleNavPanel_Click(object sender, EventArgs e)
        {
            EmployeeMainForm mainForm = this.ParentForm as EmployeeMainForm;

            if (mainForm != null)
            {
                mainForm.ToggleNavigationPanel();
            }
        }

        private void btnEmployeeInfo_Click(object sender, EventArgs e)
        {
            EmployeeMainForm mainForm = this.ParentForm as EmployeeMainForm;

            if (mainForm != null)
            {
                mainForm.ShowEmployeeDetails();
            }
        }
        #endregion TOP_BAR

    }
}

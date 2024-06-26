﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using TimeSprout.Admin.Forms.Employees.Dialog;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.Employees
{
    public partial class EmployeeForm : Form
    {
        private string username, password, fullName;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(string _name, string _password, string _fullName)
        {
            InitializeComponent();

            username = _name;
            password = _password;
            fullName = _fullName;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            SetupEmployeeDetails();
            PopulateDataGridView();
        }


        #region ON_LOAD
        private void SetupEmployeeDetails()
        {
            lblAdminName.Text = fullName;
        }
        private void PopulateDataGridView()
        {
            dataGridView1.Controls.Clear();
            DataTable summaryData = GetSummaryData();
            dataGridView1.DataSource = summaryData;

            dataGridView1.Columns["id"].HeaderText = "Employee ID";
            dataGridView1.Columns["name"].HeaderText = "Employee Name";
            dataGridView1.Columns["currentProject"].HeaderText = "Current Project";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row index is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Extract data from the clicked row
                string id = row.Cells["id"].Value.ToString();
                string name = row.Cells["name"].Value.ToString();
                string currentProject = row.Cells["currentProject"].Value.ToString();

                UpdateDeleteNewEmployee updateDelete = new UpdateDeleteNewEmployee(
                    _id: id,
                    _name: name,
                    _currentProject: currentProject);
                updateDelete.StartPosition = FormStartPosition.CenterParent;
                updateDelete.ShowDialog(this);

                PopulateDataGridView();
            }
        }

        private DataTable GetSummaryData()
        {
            DataTable summary = new DataTable();
            // Define the structure of your summary DataTable with all columns as strings
            summary.Columns.Add("id", typeof(string));
            summary.Columns.Add("name", typeof(string));
            summary.Columns.Add("currentProject", typeof(string));

            try
            {
                string selectQuery = "SELECT id AS id, name AS name, currentProject AS currentProject FROM employees;";
                using (SQLiteConnection connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                DataRow newRow = summary.NewRow();
                                newRow["id"] = row["id"].ToString();
                                newRow["name"] = row["name"].ToString();
                                newRow["currentProject"] = row["currentProject"].ToString();

                                summary.Rows.Add(newRow);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return summary;
        }
        #endregion ON_LOAD



        #region Actions
        private void tbEmployeeeId_MouseLeave(object sender, EventArgs e)
        {
            if (DBEmployee.IsEmployeeIdTaken(tbEmployeeId.Text.Trim()))
            {
                PopulateSearchedDataGridView(_id: tbEmployeeId.Text.Trim());
                tbEmployeeId.Text = "";
            }
            else
            {
                dataGridView1.Controls.Clear();
                tbEmployeeId.Text = "";
                PopulateDataGridView();
            }
        }

        private void tbEmployeeId_TextChanged(object sender, EventArgs e)
        {
            if (DBEmployee.IsEmployeeIdTaken(tbEmployeeId.Text.Trim()))
            {
                PopulateSearchedDataGridView(_id: tbEmployeeId.Text.Trim());
            }
            else
            {
                dataGridView1.Controls.Clear();
            }
        }


        private void PopulateSearchedDataGridView(string _id)
        {
            dataGridView1.Controls.Clear();
            DataTable summaryData = GetSearchedSummaryData(_id);
            dataGridView1.DataSource = summaryData;

            dataGridView1.Columns["id"].HeaderText = "Employee ID";
            dataGridView1.Columns["name"].HeaderText = "Employee Name";
            dataGridView1.Columns["currentProject"].HeaderText = "Current Project";
        }

        private DataTable GetSearchedSummaryData(string _id)
        {
            DataTable summary = new DataTable();
            // Define the structure of your summary DataTable with all columns as strings
            summary.Columns.Add("id", typeof(string));
            summary.Columns.Add("name", typeof(string));
            summary.Columns.Add("currentProject", typeof(string));

            try
            {
                string selectQuery = "SELECT id AS id, name AS name, currentProject AS currentProject FROM employees WHERE id = @id;";
                using (SQLiteConnection connection = new SQLiteConnection(DBConfig.connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                DataRow newRow = summary.NewRow();
                                newRow["id"] = row["id"].ToString();
                                newRow["name"] = row["name"].ToString();
                                newRow["currentProject"] = row["currentProject"].ToString();

                                summary.Rows.Add(newRow);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return summary;
        }
        #endregion Actions



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



        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateNewEmployee newEmployee = new CreateNewEmployee();

            newEmployee.StartPosition = FormStartPosition.CenterParent;
            newEmployee.ShowDialog(this);

            PopulateDataGridView();
        }

    }
}

using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using TimeSprout.Admin.Forms.Project.Dialog;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.Project
{
    public partial class ProjectForm : Form
    {
        private string username, password, fullName;
        public ProjectForm(string _username, string _password, string _fullName)
        {
            InitializeComponent();

            username = _username;
            password = _password;
            fullName = _fullName;
        }


        #region ON_LOAD
        private void ProjectForm_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = fullName;

            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            DataTable summaryData = GetSummaryData();
            dataGridView1.DataSource = summaryData;

            dataGridView1.Columns["id"].HeaderText = "Project ID";
            dataGridView1.Columns["name"].HeaderText = "Project Name";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row index is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Extract data from the clicked row
                string id = row.Cells["id"].Value.ToString();
                string name = row.Cells["name"].Value.ToString();

                UpdateDeleteProject updateDelete = new UpdateDeleteProject(
                    _id: id,
                    _name: name);
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

            try
            {
                string selectQuery = "SELECT id AS id, name AS name FROM projects;";
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



        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateNewProject newProject = new CreateNewProject();

            newProject.StartPosition = FormStartPosition.CenterParent;
            newProject.ShowDialog(this);

            PopulateDataGridView();
        }
    }
}

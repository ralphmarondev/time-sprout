using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using TimeSprout.Admin.Forms.Settings.Dialog;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.Settings
{
    public partial class SettingsForm : Form
    {
        private string username, fullName, password;

        public SettingsForm(
            string _username,
            string _fullName,
            string _password)
        {
            InitializeComponent();

            username = _username;
            fullName = _fullName;
            password = _password;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = fullName;

            PopulateDataGridView();
        }



        #region ON_LOAD
        private void PopulateDataGridView()
        {
            DataTable summaryData = GetSummaryData();
            dataGridView1.DataSource = summaryData;

            dataGridView1.Columns["fullName"].HeaderText = "Full Name";
            dataGridView1.Columns["username"].HeaderText = "Username";
            dataGridView1.Columns["password"].HeaderText = "Password";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row index is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Extract data from the clicked row
                string _ufullName = row.Cells["fullName"].Value.ToString();
                string _uusername = row.Cells["username"].Value.ToString();
                string _upassword = row.Cells["password"].Value.ToString();

                UpdateDeleteUser updateUser = new UpdateDeleteUser(
                    _fullName: _ufullName,
                    _username: _uusername,
                    _password: _upassword);
                updateUser.StartPosition = FormStartPosition.CenterParent;
                updateUser.ShowDialog(this);

                PopulateDataGridView();
            }
        }

        private DataTable GetSummaryData()
        {
            DataTable summary = new DataTable();
            // Define the structure of your summary DataTable with all columns as strings
            summary.Columns.Add("fullName", typeof(string));
            summary.Columns.Add("username", typeof(string));
            summary.Columns.Add("password", typeof(string));

            try
            {
                string selectQuery = "SELECT fullName AS fullName, username AS username, password AS password FROM users;";
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
                                newRow["fullName"] = row["fullName"].ToString();
                                newRow["username"] = row["username"].ToString();
                                newRow["password"] = row["password"].ToString();

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



        private void btnNewUser_Click(object sender, EventArgs e)
        {
            CreateNewUser newUser = new CreateNewUser();

            newUser.StartPosition = FormStartPosition.CenterParent;
            newUser.ShowDialog(this);

            PopulateDataGridView();
        }

    }
}

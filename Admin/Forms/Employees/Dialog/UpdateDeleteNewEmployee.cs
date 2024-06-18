using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.Employees.Dialog
{
    public partial class UpdateDeleteNewEmployee : Form
    {
        string id, name, password, currentProject;

        public UpdateDeleteNewEmployee()
        {
            InitializeComponent();
        }

        public UpdateDeleteNewEmployee(string _id, string _name, string _password, string _currentProject)
        {
            InitializeComponent();

            id = _id;
            name = _name;
            password = _password;
            currentProject = _currentProject;
        }

        private void UpdateDeleteNewEmployee_Load(object sender, EventArgs e)
        {
            Console.WriteLine("UpdateDeleteEmployee form loaded successfully.");

            SetFieldsWithValues();

            updatePanel.Visible = true;
            deletePanel.Visible = false;
        }


        #region ONLOAD
        private void SetFieldsWithValues()
        {
            tbId.Text = id;
            tbName.Text = name;
            tbPassword.Text = password;
            tbCurrentProject.Text = currentProject;

            tbIdDel.Text = id;
            tbNameDel.Text = name;
        }
        #endregion ONLOAD



        #region ACTION
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBEmployee.DeleteEmployeeDetails(id);
                MessageBox.Show(caption: "Delete Employee", text: $"Employee: '{id}' deleted successfully.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(caption: "Delete Employee", text: $"Failed deleting: '{id}'.\nError: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // TODO: UPDATE ALL RECORDS OF EMPLOYEES ON TIME RECORD TOO
            try
            {
                if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbCurrentProject.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                }
                else
                {
                    DBEmployee.UpdateEmployeeDetails(
                        employee: new Core.Model.EmployeeModel(
                            _id: id,
                            _name: tbName.Text.Trim(),
                            _password: tbPassword.Text.Trim(),
                            _currentProject: tbCurrentProject.Text.Trim()
                            ));
                    MessageBox.Show(caption: "Update Employee", text: $"Employee: '{id}' updated successfully.");

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(caption: "Update Employee", text: $"Failed updating: '{id}'.\nError: {ex.Message}");

            }
        }
        #endregion ACTION



        #region NAVIGATION
        private void btnUpdateNav_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = true;
            deletePanel.Visible = false;
        }

        private void btnDeleteNav_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;
            deletePanel.Visible = true;
        }
        #endregion NAVIGATION
    }
}

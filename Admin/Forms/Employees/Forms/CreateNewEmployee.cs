using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.Employees.Forms
{
    public partial class CreateNewEmployee : Form
    {
        public CreateNewEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DBEmployee.IsEmployeeIdTaken(_id: tbId.Text))
            {
                MessageBox.Show("Employee with such id already exists on the database. Please try different one.");
            }
            else
            {
                DBEmployee.CreateNewEmployee(new Core.Model.EmployeeModel(
                    _id: tbId.Text,
                    _name: tbName.Text,
                    _password: tbPassword.Text,
                    _currentProject: tbCurrentProject.Text));

                Hide();
            }
        }
    }
}

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
            DBEmployee.CreateNewEmployee(new Core.Model.EmployeeModel(
                _id: tbId.Text,
                _name: tbName.Text,
                _password: tbPassword.Text,
                _currentProject: tbCurrentProject.Text));

            Hide();
        }
    }
}

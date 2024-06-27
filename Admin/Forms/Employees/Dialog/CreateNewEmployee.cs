using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.Employees.Dialog
{
    public partial class CreateNewEmployee : Form
    {
        public CreateNewEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = tbId.Text.Trim();
            string name = tbName.Text.Trim();
            string currentProject = tbCurrentProject.Text.Trim();

            if (id == string.Empty || name == string.Empty || currentProject == string.Empty)
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                if (!DBEmployee.IsEmployeeIdTaken(id))
                {
                    DBEmployee.CreateNewEmployee(
                        new Core.Model.EmployeeModel(
                            _id: id,
                            _name: name,
                            _currentProject: currentProject
                            ));
                    MessageBox.Show("Saved.");
                    Close();
                }
                else
                {
                    MessageBox.Show($"ID: '{id}' is already taken. Try another one.");
                }
            }
        }
    }
}

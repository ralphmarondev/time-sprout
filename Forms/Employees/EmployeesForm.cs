using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimeSprout.Core.DB;
using TimeSprout.Forms.Employees.Model;

namespace TimeSprout.Forms.Employees
{
    public partial class EmployeesForm : Form
    {
        private List<EmployeeDataClass> employees = new List<EmployeeDataClass>();
        public EmployeesForm()
        {
            InitializeComponent();

            populatePanelWithEmployees();
        }

        private void ReadAllDataFromDB()
        {
            employees.Clear();
            employees = DBEmployee.FetchEmployees();
        }

        private void populatePanelWithEmployees()
        {
            ReadAllDataFromDB();

            List<UserControlEmployee> userControls = new List<UserControlEmployee>();
            employeesPanel.Controls.Clear();

            foreach (var employee in employees)
            {
                UserControlEmployee userControl = new UserControlEmployee(employee.ID, employee.Name, employee.CurrentProject);
                userControls.Add(userControl);
            }

            foreach (var userControl in userControls)
            {
                userControl.Dock = DockStyle.Top;
                userControl.Width = int.MaxValue; // fillMaxWidth()
                                                  //userControl.BackColor = ColorPalette.AccentLavender;

                userControl.UpdatedClicked += UserControl_UpdateClicked;
                userControl.DeleteClicked += UserControl_DeleteClicked;

                employeesPanel.Controls.Add(userControl);
            }

        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            // showing form on the center of the parent form, and disallowing
            // access to the parent form until closed.
            CreateNewEmployeeForm createNewEmployeeForm = new CreateNewEmployeeForm();
            createNewEmployeeForm.StartPosition = FormStartPosition.CenterScreen;
            createNewEmployeeForm.FormClosed += CreateNewEmployeeForm_FormClosed;
            createNewEmployeeForm.ShowDialog(this);
        }

        private void CreateNewEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            populatePanelWithEmployees();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Searching for: '" + tbUserID.Text + "'");
        }

        #region UPDATE_DELETE
        private void UserControl_UpdateClicked(object sender, EventArgs e)
        {
            populatePanelWithEmployees();
        }

        private void UserControl_DeleteClicked(object sender, EventArgs e)
        {
            populatePanelWithEmployees();
        }

        #endregion UPDATE_DELETE
    }
}
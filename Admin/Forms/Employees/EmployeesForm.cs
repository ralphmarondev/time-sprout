using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimeSprout.Admin.Forms.Employees.Forms;
using TimeSprout.Admin.Forms.Employees.MyControls;
using TimeSprout.Core.DB;
using TimeSprout.Core.Model;

namespace TimeSprout.Admin.Forms.Employees
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            populatePanelWithEmployeeUserControl();
        }

        #region ON_LOAD
        private List<EmployeeModel> employees = new List<EmployeeModel>();

        private void populatePanelWithEmployeeUserControl()
        {
            employees.Clear();
            employees = DBEmployee.FetchAllEmployees();

            List<EmployeeUserControl> userControls = new List<EmployeeUserControl>();
            listEmployeesPanel.Controls.Clear();

            foreach (var employee in employees)
            {
                EmployeeUserControl userControl = new EmployeeUserControl(
                    _id: employee.id,
                    _employeeName: employee.name,
                    _currentProject: employee.currentProject,
                    _password: employee.password);

                userControls.Add(userControl);
            }

            foreach (var userControl in userControls)
            {
                userControl.Dock = DockStyle.Top;
                userControl.Width = int.MaxValue;

                listEmployeesPanel.Controls.Add(userControl);
            }
            #endregion ON_LOAD
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var createNewEmployee = new CreateNewEmployee();

            createNewEmployee.StartPosition = FormStartPosition.CenterParent;
            createNewEmployee.ShowDialog(this);
        }
    }
}
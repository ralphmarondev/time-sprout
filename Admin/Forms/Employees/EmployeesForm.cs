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

                // HACK: refreshing the list when delete operation is done
                userControl.DeleteButtonClicked += EmployeeUserControl_DeleteButtonClicked;
                userControl.UpdateButtonClicked += EmployeeUserControl_UpdateButtonClicked;

                userControls.Add(userControl);
            }

            foreach (var userControl in userControls)
            {
                userControl.Dock = DockStyle.Top;
                userControl.Width = int.MaxValue;

                listEmployeesPanel.Controls.Add(userControl);
            }
        }

        // HACK: CALL THIS ON SEARCH
        private void populatePanelWithEmployeeUserControlById(string _id)
        {
            employees.Clear();
            employees = DBEmployee.FetchAllEmployeesById(_id: _id);

            List<EmployeeUserControl> userControls = new List<EmployeeUserControl>();
            listEmployeesPanel.Controls.Clear();

            foreach (var employee in employees)
            {
                EmployeeUserControl userControl = new EmployeeUserControl(
                    _id: employee.id,
                    _employeeName: employee.name,
                    _currentProject: employee.currentProject,
                    _password: employee.password);

                // HACK: refreshing the list when delete operation is done
                userControl.DeleteButtonClicked += EmployeeUserControl_DeleteButtonClicked;
                userControl.UpdateButtonClicked += EmployeeUserControl_UpdateButtonClicked;

                userControls.Add(userControl);
            }

            foreach (var userControl in userControls)
            {
                userControl.Dock = DockStyle.Top;
                userControl.Width = int.MaxValue;

                listEmployeesPanel.Controls.Add(userControl);
            }
        }

        #endregion ON_LOAD


        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateNewEmployee createNewEmployee = new CreateNewEmployee();

            // HACK: adding form closed event :)
            createNewEmployee.FormClosed += RefreshingList_FormEvent;

            createNewEmployee.StartPosition = FormStartPosition.CenterParent;
            createNewEmployee.ShowDialog(this);
        }

        // HACK: refresh the list when the new form is closed
        private void RefreshingList_FormEvent(object sender, EventArgs e)
        {
            populatePanelWithEmployeeUserControl();
        }

        private void EmployeeUserControl_DeleteButtonClicked(object sender, EventArgs e)
        {
            EmployeeUserControl userControl = sender as EmployeeUserControl;

            if (userControl != null)
            {
                // deleting employee
                DBEmployee.DeleteEmployeeDetails(_id: userControl.EmployeeId);
                populatePanelWithEmployeeUserControl();
            }
        }

        private void EmployeeUserControl_UpdateButtonClicked(object sender, EventArgs e)
        {
            EmployeeUserControl userControl = sender as EmployeeUserControl;

            if (userControl != null)
            {

                UpdateEmployee updateForm = new UpdateEmployee(
                    _id: userControl.EmployeeId,
                    _name: userControl.EmployeeName,
                    _password: userControl.EmployeePassword,
                    _currentProject: userControl.CurrentProject);

                // HACK: closed event
                updateForm.FormClosed += RefreshingList_FormEvent;

                updateForm.StartPosition = FormStartPosition.CenterParent;
                updateForm.ShowDialog(this);
            }
        }

        private void tbId_Leave(object sender, EventArgs e)
        {
            if (tbId.Text.Trim().Length > 0)
            {
                lblRefreshEmpId.Visible = true;
                lblRefreshEmpId.Text = $"results for '{tbId.Text}' click to close";

                // search from db where id = @id
                populatePanelWithEmployeeUserControlById(_id: tbId.Text);
                // tbId.Text = "";
            }
            else
            {
                populatePanelWithEmployeeUserControl();
            }
        }

        private void lblRefreshEmpId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            populatePanelWithEmployeeUserControl();
            tbId.Text = "";
            lblRefreshEmpId.Visible = false;
        }
    }
}
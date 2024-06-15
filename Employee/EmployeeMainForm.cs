using System;
using System.Windows.Forms;
using TimeSprout.Core.Model;

namespace TimeSprout.Employee
{
    public partial class EmployeeMainForm : Form
    {
        public EmployeeMainForm()
        {
            InitializeComponent();
            id = "2024-001";
        }

        public EmployeeMainForm(string _id)
        {
            InitializeComponent();
            id = "2024-002";
        }

        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {
            GetEmployeeDetails(id);
            OpenFormInPanel(new Forms.TimeRecord.TimeRecordForm(
                _id: id,
                _name: name,
                _password: password,
                _currentProject: currentProject
                ));
        }

        /// <summary>
        /// ONLOAD: 
        ///     - GET EMPLOYEE DETAILS [ID, NAME, PASSWORD, CURRENT_PROJECT]
        /// </summary>
        #region ONLOAD
        #region EMPLOYEE_DETAILS
        private string id, name, password, currentProject;
        private void GetEmployeeDetails(string _id)
        {
            EmployeeModel employee = Core.DB.DBEmployee.ReadEmployeeDetails(_id: _id);
            id = employee.id;
            name = employee.name;
            password = employee.password;
            currentProject = employee.currentProject;
        }

        #endregion EMPLOYEE_DETAILS

        #endregion ONLOAD



        #region NAVIGATIONS
        private void OpenFormInPanel(Form form)
        {
            foreach (Control control in panelNavigation.Controls)
            {
                if (control is Form)
                {
                    ((Form)control).Close();
                }
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            mainPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnTimeInOut_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Forms.TimeRecord.TimeRecordForm(
               _id: id,
               _name: name,
               _password: password,
               _currentProject: currentProject
               ));
        }
        private void btnSummary_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Forms.Summary.SumarryForm(_id: id, _name: name, _password: password, _currentProject: currentProject));
        }



        #endregion NAVIGATIONS

        #region TOP_BAR

        internal void ToggleFullScreen()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // full screen
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        internal void ToggleNavigationPanel()
        {
            if (panelNavigation.Visible)
            {
                panelNavigation.Visible = false;
            }
            else
            {
                panelNavigation.Visible = true;
            }
        }

        internal void ShowEmployeeDetails()
        {
            string message = $"ID: {id}\nName: {name}\nPassword: {password}\nCurrent Project: {currentProject}\n\n=====Nothing Follows=====";
            MessageBox.Show(caption: "Employee Details", text: message);
        }

        #endregion TOP_BAR

    }
}

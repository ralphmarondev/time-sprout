using System.Collections.Generic;
using System.Windows.Forms;
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

        void populatePanelWithEmployees()
        {
            employees.Clear();
            employees.Add(new EmployeeDataClass(
                id: "20240604-001",
                name: "Ralph Maron Eda",
                password: "IsCute",
                currentProject: "Earth 2.0")
                );
            employees.Add(new EmployeeDataClass(
                id: "20240604-002",
                name: "Jackie Ferreras",
                password: "IsAlsoCute",
                currentProject: "Earth 2.1")
                );

            List<UserControlEmployee> userControls = new List<UserControlEmployee>();

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

                employeesPanel.Controls.Add(userControl);
            }

        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            // showing form on the center of the parent form, and disallowing
            // access to the parent form until closed.
            var createNewEmployeeForm = new CreateNewEmployeeForm();

            createNewEmployeeForm.StartPosition = FormStartPosition.CenterScreen;

            createNewEmployeeForm.ShowDialog(this);
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Searching for: '" + tbUserID.Text + "'");
        }
    }
}
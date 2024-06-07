using System.Windows.Forms;
using TimeSprout.Admin.Forms.Employees.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.Employees.MyControls
{
    public partial class EmployeeUserControl : UserControl
    {
        public EmployeeUserControl()
        {
            InitializeComponent();
        }

        public EmployeeUserControl(string _id, string _employeeName, string _currentProject, string _password)
        {
            InitializeComponent();

            lblEmployeeId.Text = _id;
            lblEmployeeName.Text = _employeeName;
            lblCurrentProject.Text = _currentProject;
            lblEmployeePassword.Text = _password;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            DBEmployee.DeleteEmployeeDetails(_id: lblEmployeeId.Text);
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            UpdateEmployee updateForm = new UpdateEmployee(_id: lblEmployeeId.Text,
                _name: lblEmployeeName.Text,
                _password: lblEmployeePassword.Text,
                _currentProject: lblCurrentProject.Text);

            updateForm.StartPosition = FormStartPosition.CenterParent;
            updateForm.ShowDialog(this);
        }
    }
}

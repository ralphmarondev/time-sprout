using System;
using System.Windows.Forms;

namespace TimeSprout.Admin.Forms.Employees.MyControls
{
    public partial class EmployeeUserControl : UserControl
    {
        public event EventHandler DeleteButtonClicked;
        public event EventHandler UpdateButtonClicked;

        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string CurrentProject { get; set; }
        public string EmployeePassword { get; set; }

        public EmployeeUserControl()
        {
            InitializeComponent();
        }

        public EmployeeUserControl(string _id, string _employeeName, string _currentProject, string _password)
        {
            InitializeComponent();

            EmployeeId = _id;
            EmployeeName = _employeeName;
            CurrentProject = _currentProject;
            EmployeePassword = _password;
        }


        private void EmployeeUserControl_Load(object sender, EventArgs e)
        {
            lblEmployeeId.Text = EmployeeId;
            lblEmployeeName.Text = EmployeeName;
            lblCurrentProject.Text = CurrentProject;
            lblEmployeePassword.Text = EmployeePassword;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            UpdateButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

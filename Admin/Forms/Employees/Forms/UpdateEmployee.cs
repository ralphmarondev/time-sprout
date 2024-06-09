using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.Employees.Forms
{
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        public UpdateEmployee(string _id, string _name, string _password, string _currentProject)
        {
            InitializeComponent();

            tbId.Text = _id;
            tbName.Text = _name;
            tbPassword.Text = _password;
            tbCurrentProject.Text = _currentProject;
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            DBEmployee.UpdateEmployeeDetails(new Core.Model.EmployeeModel(
                _id: tbId.Text,
                _name: tbName.Text,
                _password: tbPassword.Text,
                _currentProject: tbCurrentProject.Text));

            this.Close();
        }

        #region ON_CLOSE
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // trigger event
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }
        #endregion ON_CLOSE

        public event EventHandler FormClosedEvent;
    }
}

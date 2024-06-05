using System;
using System.Windows.Forms;

namespace TimeSprout.Forms.Employees
{
    public partial class UserControlEmployee : UserControl
    {
        public string ID { get; set; }
        public string NameEmp { get; set; }
        public string CurrentProject { get; set; }

        public UserControlEmployee()
        {
            InitializeComponent();
        }

        public UserControlEmployee(
            string id, string name, string currentProject)
        {
            InitializeComponent();
            lblID.Text = id;
            lblName.Text = name;
            lblCurrentProject.Text = currentProject;
        }

        public EventHandler UpdatedClicked;
        public EventHandler DeleteClicked;
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            var createNewEmployeeForm = new UpdateEmployeeForm(
                id: lblID.Text,
                name: lblName.Text,
                currentProject: lblCurrentProject.Text,
                password: "password_is_hidden");

            createNewEmployeeForm.StartPosition = FormStartPosition.CenterScreen;

            // subscribe to the form closed event of the update form
            createNewEmployeeForm.FormClosed += UpdateEmployeeForm_FormClosed;

            createNewEmployeeForm.ShowDialog(this);
        }

        private void UpdateEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdatedClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var deleteEmployeeForm = new DeleteEmployeeForm(lblID.Text);

            deleteEmployeeForm.StartPosition = FormStartPosition.CenterScreen;

            deleteEmployeeForm.FormClosed += DeleteEmployeeForm_FormClosed;
            deleteEmployeeForm.ShowDialog(this);
        }

        private void DeleteEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

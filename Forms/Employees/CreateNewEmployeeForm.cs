using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Forms.Employees
{
    public partial class CreateNewEmployeeForm : Form
    {
        // custom event
        public event EventHandler DataSaved;

        public CreateNewEmployeeForm()
        {
            InitializeComponent();
        }

        public CreateNewEmployeeForm(
            string id, string name, string password, string currentProject)
        {
            InitializeComponent();

            tbId.Text = id;
            tbName.Text = name;
            tbPassword.Text = password;
            tbCurrentProject.Text = currentProject;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = tbId.Text;
            string name = tbName.Text;
            string password = tbPassword.Text;
            string currentProject = tbCurrentProject.Text;

            Console.WriteLine($"Saving to db... ID: [{id}], name: [{name}], password: [{password}], currentProject: [{currentProject}].");
            // update_data_in_db();
            DBEmployee.CreateNewEmployee(id, name, password, currentProject);
            Close();
        }
    }
}

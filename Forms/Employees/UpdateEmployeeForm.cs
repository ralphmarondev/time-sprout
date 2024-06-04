using System;
using System.Windows.Forms;

namespace TimeSprout.Forms.Employees
{
    public partial class UpdateEmployeeForm : Form
    {
        public UpdateEmployeeForm()
        {
            InitializeComponent();
        }

        public UpdateEmployeeForm(
            string id, string name, string password, string currentProject)
        {
            InitializeComponent();

            tbId.Text = id;
            tbName.Text = name;
            tbPassword.Text = password;
            tbCurrentProject.Text = currentProject;
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            string id = tbId.Text;
            string name = tbName.Text;
            string password = tbPassword.Text;
            string currentProject = tbCurrentProject.Text;

            Console.WriteLine($"Updating id: [{id}] from db... name: [{name}], password: [{password}], currentProject: [{currentProject}].");
            // update_data_in_db();

            MessageBox.Show("[" + id + "] is updated successfully.");
            Close();
        }
    }
}

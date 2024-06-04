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

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            var createNewEmployeeForm = new UpdateEmployeeForm(
                id: lblID.Text,
                name: lblName.Text,
                currentProject: lblCurrentProject.Text,
                password: "password_is_hidden");

            createNewEmployeeForm.StartPosition = FormStartPosition.CenterScreen;

            createNewEmployeeForm.ShowDialog(this);
        }
    }
}

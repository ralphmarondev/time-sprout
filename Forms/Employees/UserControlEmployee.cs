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
    }
}

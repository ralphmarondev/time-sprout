using System;
using System.Windows.Forms;

namespace TimeSprout.Admin.Forms.TimeRecord.Dialog
{
    public partial class SelectEmployee : Form
    {
        public string EmployeeId { get; private set; }
        public string EmployeeName { get; private set; }
        public string EmployeeCurrentProject { get; private set; }

        public SelectEmployee()
        {
            InitializeComponent();
        }

        private void SelectEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            EmployeeId = tbId.Text;
            EmployeeName = tbName.Text;
            EmployeeCurrentProject = tbCurProj.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

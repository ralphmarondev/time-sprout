using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Forms.Employees
{
    public partial class DeleteEmployeeForm : Form
    {
        private string employeeID;
        public DeleteEmployeeForm(string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;

            this.lblID.Text = lblID.Text + employeeID;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBEmployee.DeleteEmployee(employeeID);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

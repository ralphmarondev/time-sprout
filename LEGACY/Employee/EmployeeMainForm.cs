using System.Drawing;
using System.Windows.Forms;
using TimeSprout.Employee.DB;
using TimeSprout.Employee.Model;

namespace TimeSprout.Employee
{
    public partial class EmployeeMainForm : Form
    {
        private Color defaultColor = Color.FromArgb(106, 27, 154);
        private Color selectedColor = Color.DeepPink;
        private string id, currentDate;
        private EmployeeDataClass employeeData = null;
        public EmployeeMainForm(string _id)
        {
            InitializeComponent();

            id = _id;
        }

        private void EmployeeMainForm_Load(object sender, System.EventArgs e)
        {
            employeeData = DBEmployeeTimeRecord.ReadEmployeeTimeRecord(tableName: currentDate, _id: id);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {

        }


        #region HELPERS
        private void GetDetails()
        {

        }
        #endregion HELPERS


        #region NAVIGATION_BUTTONS
        private void btnTimeRecord_Click(object sender, System.EventArgs e)
        {
            btnTimeRecord.BackColor = selectedColor;
            btnSummary.BackColor = defaultColor;
            btnExport.BackColor = defaultColor;
        }

        private void btnSummary_Click(object sender, System.EventArgs e)
        {
            btnTimeRecord.BackColor = defaultColor;
            btnSummary.BackColor = selectedColor;
            btnExport.BackColor = defaultColor;
        }

        private void btnExport_Click(object sender, System.EventArgs e)
        {
            btnTimeRecord.BackColor = defaultColor;
            btnSummary.BackColor = defaultColor;
            btnExport.BackColor = selectedColor;
        }
        #endregion NAVIGATION_BUTTONS


    }
}

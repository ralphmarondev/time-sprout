using System.Windows.Forms;
using TimeSprout.Admin.Forms.TimeRecord.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.TimeRecord.MyControls
{
    public partial class TimeRecordUserControl : UserControl
    {
        private string currentDate;
        public TimeRecordUserControl()
        {
            InitializeComponent();
        }

        public TimeRecordUserControl(string _currentDate, string _id, string _employeeName, string _currentProject, string _amTimeIn, string _amTimeOut, string _pmTimeIn, string _pmTimeOut, string _otTimeIn, string _otTimeOut)
        {
            InitializeComponent();

            currentDate = _currentDate;

            lblId.Text = _id;
            lblEmployeeName.Text = _employeeName;
            lblCurrentProject.Text = _currentProject;
            lblAmTimeIn.Text = _amTimeIn;
            lblAmTimeOut.Text = _amTimeOut;
            lblPmTimeIn.Text = _pmTimeIn;
            lblPmTimeOut.Text = _pmTimeOut;
            lblOtTimeIn.Text = _otTimeIn;
            lblOtTimeOut.Text = _otTimeOut;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            DBTimeRecord.DeleteEmployeeTimeRecord(_currentDate: currentDate, _id: lblId.Text);
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var updateTimeRecord = new UpdateTimeRecord(
                _currentDate: currentDate,
                _id: lblId.Text, _employeeName: lblEmployeeName.Text, _currentProject: lblCurrentProject.Text,
                _amTimeIn: lblAmTimeIn.Text, _amTimeOut: lblAmTimeOut.Text, _pmTimeIn: lblPmTimeIn.Text,
                _pmTimeOut: lblPmTimeOut.Text, _otTimeIn: lblOtTimeIn.Text, _otTimeOut: lblOtTimeOut.Text);

            updateTimeRecord.StartPosition = FormStartPosition.CenterParent;
            updateTimeRecord.ShowDialog(this);
        }
    }
}

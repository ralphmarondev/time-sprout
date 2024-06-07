using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;
using TimeSprout.Core.Model;

namespace TimeSprout.Admin.Forms.TimeRecord.Forms
{
    public partial class CreateNewRecord : Form
    {
        private string currentDate;
        public CreateNewRecord()
        {
            InitializeComponent();
        }

        public CreateNewRecord(string _currentDate)
        {
            InitializeComponent();
            currentDate = _currentDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBTimeRecord.CreateEmployeeTimeRecord(_currentDate: currentDate,
                _record: new TimeRecordModel(_id: tbId.Text, _employeeName: tbEmployeeName.Text,
                _currentProject: tbCurrentProject.Text, _amTimeIn: tbAmTimeIn.Text, _amTimeOut: tbAmTimeOut.Text,
                _pmTimeIn: tbPmTimeIn.Text, _pmTimeOut: tbPmTimeOut.Text, _otTimeIn: tbOtTimeIn.Text, _otTimeOut: tbOtTimeOut.Text));

            Hide();
        }
    }
}

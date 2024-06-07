using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;
using TimeSprout.Core.Model;

namespace TimeSprout.Admin.Forms.TimeRecord.Forms
{
    public partial class UpdateTimeRecord : Form
    {
        string currentDate;
        public UpdateTimeRecord()
        {
            InitializeComponent();
        }

        public UpdateTimeRecord(string _currentDate, string _id, string _employeeName, string _currentProject, string _amTimeIn, string _amTimeOut, string _pmTimeIn, string _pmTimeOut, string _otTimeIn, string _otTimeOut)
        {
            InitializeComponent();

            currentDate = _currentDate;

            tbId.Text = _id;
            tbEmployeeName.Text = _employeeName;
            tbCurrentProject.Text = _currentProject;
            tbAmTimeIn.Text = _amTimeIn;
            tbAmTimeOut.Text = _amTimeOut;
            tbPmTimeIn.Text = _pmTimeIn;
            tbPmTimeOut.Text = _pmTimeOut;
            tbOtTimeIn.Text = _otTimeIn;
            tbOtTimeOut.Text = _otTimeOut;
        }

        private void UpdateTimeRecord_Load(object sender, EventArgs e)
        {
            // set the value of dateTimePicker to the current Date
            tbId.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"current date: {currentDate}");
            DBTimeRecord.UpdateEmployeeTimeRecord(_currentDate: currentDate,
                _record: new TimeRecordModel(
                    _id: tbId.Text, _employeeName: tbEmployeeName.Text,
                    _currentProject: tbCurrentProject.Text, _amTimeIn: tbAmTimeIn.Text,
                    _amTimeOut: tbAmTimeOut.Text,
                    _pmTimeIn: tbPmTimeIn.Text, _pmTimeOut: tbPmTimeOut.Text,
                    _otTimeIn: tbOtTimeIn.Text, _otTimeOut: tbOtTimeOut.Text));
            Hide();
        }
    }
}

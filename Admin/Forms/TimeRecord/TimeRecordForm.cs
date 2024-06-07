using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimeSprout.Admin.Forms.TimeRecord.Forms;
using TimeSprout.Admin.Forms.TimeRecord.MyControls;
using TimeSprout.Core.DB;
using TimeSprout.Core.Model;

namespace TimeSprout.Admin.Forms
{
    public partial class TimeRecordForm : Form
    {
        string currentDate = "06072024";
        public TimeRecordForm()
        {
            InitializeComponent();
        }

        private void TimeRecordForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            // initialize variables
            currentDate = dateTimePicker1.Value.ToString("MMddyyyy");

            // popluate with employees
            populatePanelWithTimeRecordUserControl();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // open create new time record
            var newTimeRecord = new CreateNewRecord(_currentDate: currentDate);
            newTimeRecord.StartPosition = FormStartPosition.CenterParent;
            newTimeRecord.ShowDialog(this);
        }

        #region onLoad
        private List<TimeRecordModel> timeRecords = new List<TimeRecordModel>();
        private void populatePanelWithTimeRecordUserControl()
        {
            timeRecords.Clear();
            timeRecords = DBTimeRecord.FetchAllEmployeeTimeRecords(_currentDate: currentDate);

            List<TimeRecordUserControl> userControls = new List<TimeRecordUserControl>();
            listTimeRecordPanel.Controls.Clear();

            foreach (var t in timeRecords)
            {
                TimeRecordUserControl userControl = new TimeRecordUserControl(
                    _currentDate: currentDate,
                    _id: t.id, _employeeName: t.employeeName, _currentProject: t.currentProject, _amTimeIn: t.amTimeIn,
                    _amTimeOut: t.amTimeOut, _pmTimeIn: t.pmTimeIn, _pmTimeOut: t.pmTimeOut, _otTimeIn: t.otTimeIn, _otTimeOut: t.otTimeOut);
                userControls.Add(userControl);
            }

            foreach (var userControl in userControls)
            {
                userControl.Dock = DockStyle.Top;
                userControl.Width = int.MaxValue;

                listTimeRecordPanel.Controls.Add(userControl);
            }
        }
        #endregion onLoad

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            currentDate = dateTimePicker1.Value.ToString("MMddyyyy");
            Console.WriteLine($"Updated value of current date to: {currentDate}");

            Console.WriteLine("Updating list of records...");
            populatePanelWithTimeRecordUserControl();
        }
    }
}

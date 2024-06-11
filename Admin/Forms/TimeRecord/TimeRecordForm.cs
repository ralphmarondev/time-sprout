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
            lblDayOfWeek.Text = dateTimePicker1.Value.ToString("dddd");

            // popluate with employees
            populatePanelWithTimeRecordUserControl();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // open create new time record
            var newTimeRecord = new CreateNewRecord(_currentDate: currentDate);

            newTimeRecord.FormClosed += TimeRecordList_RefreshEvent;
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

                userControl.DeleteButtonClicked += TimeRecordList_RefreshEvent;
                userControl.UpdateButtonClicked += TimeRecordList_RefreshEvent;

                userControls.Add(userControl);
            }

            foreach (var userControl in userControls)
            {
                userControl.Dock = DockStyle.Top;
                userControl.Width = int.MaxValue;

                listTimeRecordPanel.Controls.Add(userControl);
            }

            // TODO: show that there is no data yet if the list is empty
            if (timeRecords.Count < 1)
            {
                listTimeRecordPanel.Controls.Add(new NoDataUserControl());
            }
        }

        // HACK: on search by id
        private void populatePanelWithTimeRecordUserControlById(string _id)
        {
            timeRecords.Clear();
            timeRecords = DBTimeRecord.FetchAllEmployeeTimeRecordsById(_currentDate: currentDate, _id: _id);

            List<TimeRecordUserControl> userControls = new List<TimeRecordUserControl>();
            listTimeRecordPanel.Controls.Clear();

            foreach (var t in timeRecords)
            {
                TimeRecordUserControl userControl = new TimeRecordUserControl(
                    _currentDate: currentDate,
                    _id: t.id, _employeeName: t.employeeName, _currentProject: t.currentProject, _amTimeIn: t.amTimeIn,
                    _amTimeOut: t.amTimeOut, _pmTimeIn: t.pmTimeIn, _pmTimeOut: t.pmTimeOut, _otTimeIn: t.otTimeIn, _otTimeOut: t.otTimeOut);

                userControl.DeleteButtonClicked += TimeRecordList_RefreshEvent;
                userControl.UpdateButtonClicked += TimeRecordList_RefreshEvent;

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
            lblDayOfWeek.Text = dateTimePicker1.Value.ToString("dddd");

            Console.WriteLine($"Updated value of current date to: {currentDate}");
            TimeRecordList_RefreshEvent(sender, e);

            Console.WriteLine("Updating list of records...");
            populatePanelWithTimeRecordUserControl();
        }

        #region REFRESH
        private void TimeRecordList_RefreshEvent(object sender, EventArgs e)
        {
            populatePanelWithTimeRecordUserControl();
        }
        #endregion REFRESH

        private void tbID_Leave(object sender, EventArgs e)
        {

            if (tbID.Text.Trim().Length > 0)
            {
                lblRefreshEmpId.Visible = true;
                lblRefreshEmpId.Text = $"results for '{tbID.Text}' click to close";

                // search from db where id = @id
                populatePanelWithTimeRecordUserControlById(_id: tbID.Text);
            }
            else
            {
                populatePanelWithTimeRecordUserControl();
            }
        }

        private void lblRefreshEmpId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            populatePanelWithTimeRecordUserControl();
            tbID.Text = "";
            lblRefreshEmpId.Visible = false;
        }
    }
}

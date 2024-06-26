﻿using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;
using TimeSprout.Core.Model;

namespace TimeSprout.Admin.Forms.TimeRecord.Dialog
{
    public partial class UpdateDeleteTimeRecord : Form
    {
        private string id, name, currentProject, amTimeIn, amTimeOut;
        private string pmTimeIn, pmTimeOut, otTimeIn, otTimeOut, workingHour, overtime;
        private string currentDate;

        public UpdateDeleteTimeRecord(
            string _id,
            string _name,
            string _currentProject,
            string _amTimeIn,
            string _amTimeOut,
            string _pmTimeIn,
            string _pmTimeOut,
            string _otTimeIn,
            string _otTimeOut,
            string _workinghour,
            string _overtime,
            string _date)
        {
            InitializeComponent();

            id = _id;
            name = _name;
            currentProject = _currentProject;
            amTimeIn = _amTimeIn;
            amTimeOut = _amTimeOut;
            pmTimeIn = _pmTimeIn;
            pmTimeOut = _pmTimeOut;
            otTimeIn = _otTimeIn;
            otTimeOut = _otTimeOut;
            overtime = _overtime;
            workingHour = _workinghour;

            currentDate = _date;
        }

        private void UpdateDeleteTimeRecord_Load(object sender, EventArgs e)
        {
            Console.WriteLine("UpdateDeleteTimeRecord loaded successfully.");

            tbEmployeeId.Text = id;
            tbName.Text = name;
            tbCurrentProject.Text = currentProject;
            tbCurrentDate.Text = currentDate;

            tbAmTimeIn.Text = amTimeIn;
            tbAmTimeOut.Text = amTimeOut;
            tbPmTimeIn.Text = pmTimeIn;
            tbPmTimeOut.Text = pmTimeOut;
            tbOtTimeIn.Text = otTimeIn;
            tbOtTimeOut.Text = otTimeOut;
            lblWorkedHour.Text = workingHour;
            lblOvertime.Text = overtime;

            TimeInTimeOutCheck();
            UpdateTotalWorkHours();

            panelUpdate.Visible = true;
            panelDelete.Visible = false;

            tbDelEmpId.Text = id;
            tbDelEmpName.Text = name;
            tbDelCurrProj.Text = currentProject;
            tbDelCurrentDate.Text = currentDate;
            lblDelTotalHours.Text += workingHour;
            lblDelOvertime.Text += overtime;
        }




        #region ACTIONS
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTimeRecord();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Deleting record of '{id}' on '{currentDate}'");
            DBTimeRecord.DeleteEmployeeTimeRecord(
                _currentDate: currentDate,
                _id: id);
            Console.WriteLine("Done.");
            MessageBox.Show("Deleted successfully!");
            Close();
        }
        #endregion ACTIONS



        #region Update
        private void UpdateTimeRecord()
        {
            try
            {
                Console.WriteLine("Updating...");
                if (id == string.Empty || name == string.Empty || currentProject == string.Empty)
                {
                    MessageBox.Show("Please fill in all fields.");
                }
                else
                {
                    if (DBEmployee.IsEmployeeIdTaken(_id: id))
                    {
                        if (!DBTimeRecord.IsEmployeeTimeRecordExists(_currentDate: currentDate, _id: id))
                        {

                            UpdateTotalWorkHours();
                            DBTimeRecord.CreateEmployeeTimeRecord(
                                _currentDate: currentDate,
                                _record: new TimeRecordModel(
                                    _id: id,
                                    _employeeName: name,
                                    _currentProject: currentProject,
                                    _amTimeIn: tbAmTimeIn.Text,
                                    _amTimeOut: tbAmTimeOut.Text,
                                    _pmTimeIn: tbPmTimeIn.Text,
                                    _pmTimeOut: tbPmTimeOut.Text,
                                    _otTimeIn: tbOtTimeIn.Text,
                                    _otTimeOut: tbOtTimeOut.Text,
                                    _workingHour: lblWorkedHour.Text,
                                    _overtime: lblOvertime.Text
                                    ));
                        }
                        else
                        {
                            UpdateTotalWorkHours();
                            DBTimeRecord.UpdateEmployeeTimeRecord(_currentDate: currentDate,
                                _record: new TimeRecordModel(
                                    _id: id,
                                    _employeeName: name,
                                    _currentProject: currentProject,
                                    _amTimeIn: tbAmTimeIn.Text,
                                    _amTimeOut: tbAmTimeOut.Text,
                                    _pmTimeIn: tbPmTimeIn.Text,
                                    _pmTimeOut: tbPmTimeOut.Text,
                                    _otTimeIn: tbOtTimeIn.Text,
                                    _otTimeOut: tbOtTimeOut.Text,
                                    _workingHour: lblWorkedHour.Text,
                                    _overtime: lblOvertime.Text
                                    ));
                        }
                    }
                }
                MessageBox.Show("Saved!");
                Console.WriteLine("Done.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed. Error: {ex.Message}");
                Console.WriteLine($"Failed saving. Error: {ex.Message}");
            }
        }

        private string GetCurrentTime()
        {
            DateTime _currentTime = DateTime.Now;
            string formattedTime = _currentTime.ToString("hh:mm");

            //Console.WriteLine($"Time now is: {formattedTime}");
            return formattedTime;
        }

        private enum TimePeriod
        {
            Morning,
            Afternoon,
            Evening
        }

        private TimePeriod GetCurrentTimePeriod()
        {

            int AfternoonCutoffHour = 12; // After 12:00 PM is considered afternoon
            int EveningCutoffHour = 17;   // After 5:00 PM is considered evening

            DateTime currentTime = DateTime.Now;

            int currentHour = currentTime.Hour;

            if (currentHour < AfternoonCutoffHour)
            {
                return TimePeriod.Morning;
            }
            else if (currentHour < EveningCutoffHour)
            {
                return TimePeriod.Afternoon;
            }
            else
            {
                return TimePeriod.Evening;
            }
        }

        private void TimeInTimeOutCheck()
        {
            TimePeriod period = GetCurrentTimePeriod();

            if (period == TimePeriod.Morning)
            {
                btnAmTimeIn.Enabled = true;
                btnAmTimeOut.Enabled = true;

                btnPmTimeIn.Enabled = false;
                btnPmTimeOut.Enabled = false;

                btnOtTimeIn.Enabled = false;
                btnOtTimeOut.Enabled = false;
            }
            else if (period == TimePeriod.Afternoon)
            {
                btnAmTimeIn.Enabled = false;
                btnAmTimeOut.Enabled = false;

                btnPmTimeIn.Enabled = true;
                btnPmTimeOut.Enabled = true;

                btnOtTimeIn.Enabled = false;
                btnOtTimeOut.Enabled = false;
            }
            else
            {
                btnAmTimeIn.Enabled = false;
                btnAmTimeOut.Enabled = false;

                btnPmTimeIn.Enabled = false;
                btnPmTimeOut.Enabled = false;

                btnOtTimeIn.Enabled = true;
                btnOtTimeOut.Enabled = true;
            }
        }
        #endregion Update



        #region CALCULATING_TOTAL_WORKING_HOUR
        private void UpdateTotalWorkHours()
        {
            TimeSpan totalWorkingHours = CalculateTotalWorkingHours();
            TimeSpan totalOvertimeHours = CalculateTotalOverTime();

            lblWorkedHour.Text = totalWorkingHours.ToString(@"hh\:mm"); // "08:30" ;
            lblOvertime.Text = totalOvertimeHours.ToString(@"hh\:mm");

            //totalWorkedHour = totalWorkingHours.ToString(@"hh\:mm");
            //totalOvertime = totalOvertimeHours.ToString(@"hh\:mm");
        }
        private TimeSpan CalculateTotalWorkingHours()
        {
            string _amTimeIn = tbAmTimeIn.Text;
            string _amTimeOut = tbAmTimeOut.Text;
            string _pmTimeIn = tbPmTimeIn.Text;
            string _pmTimeOut = tbPmTimeOut.Text;


            TimeSpan totalWorkingHours = TimeSpan.Zero;

            // morning
            if (!string.IsNullOrEmpty(_amTimeIn) && !string.IsNullOrEmpty(_amTimeOut))
            {

                TimeSpan amTimeIn = TimeSpan.Parse(_amTimeIn);
                TimeSpan amTimeOut = TimeSpan.Parse(_amTimeOut);
                TimeSpan amWorkingHours = amTimeOut - amTimeIn;

                // HACK: WILL ONLY ADD IF TIME OUT IS GREATER THAN TIME IN
                if (amTimeOut > amTimeIn)
                    totalWorkingHours += amWorkingHours;
                else
                    Console.WriteLine($"TimeIn: {amTimeIn} is greater than timeout: {amTimeOut}.");
            }

            // afternoon
            if (!string.IsNullOrEmpty(_pmTimeIn) && !string.IsNullOrEmpty(_pmTimeOut))
            {
                TimeSpan pmTimeIn = TimeSpan.Parse(_pmTimeIn);
                TimeSpan pmTimeOut = TimeSpan.Parse(_pmTimeOut);
                TimeSpan pmWorkingHours = pmTimeOut - pmTimeIn;

                // HACK: WILL ONLY ADD IF TIME OUT IS GREATER THAN TIME IN
                if (pmTimeOut > pmTimeIn)
                    totalWorkingHours += pmWorkingHours;
                else
                    Console.WriteLine($"TimeIn: {pmTimeIn} is greater than timeout: {pmTimeOut}.");
            }

            Console.WriteLine($"Total working time: {totalWorkingHours}");
            return totalWorkingHours;
        }

        private TimeSpan CalculateTotalOverTime()
        {
            string _otTimeIn = tbOtTimeIn.Text;
            string _otTimeOut = tbOtTimeOut.Text;

            TimeSpan totalOverTime = TimeSpan.Zero;

            if (!string.IsNullOrEmpty(_otTimeIn) && !string.IsNullOrEmpty(_otTimeOut))
            {
                TimeSpan otTimeIn = TimeSpan.Parse(_otTimeIn);
                TimeSpan otTimeOut = TimeSpan.Parse(_otTimeOut);
                TimeSpan otWorkingHours = otTimeOut - otTimeIn;

                if (otTimeOut > otTimeIn)
                    totalOverTime += otWorkingHours;
                else
                    Console.WriteLine($"TimeIn: {otTimeIn} is greater than timeout: {otTimeOut}.");

            }

            Console.WriteLine($"Total over time: {totalOverTime}");
            return totalOverTime;
        }
        #endregion CALCULATING_TOTAL_WORKING_HOUR



        #region NavigationBar
        private void btnUpdateNav_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = true;
            panelDelete.Visible = false;
        }

        private void btnDeleteNav_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
            panelUpdate.Visible = false;
        }
        #endregion NavigationBar



        #region TimeInTimeOut
        private void btnAmTimeIn_Click(object sender, EventArgs e)
        {
            tbAmTimeIn.Text = GetCurrentTime();
        }

        private void btnAmTimeOut_Click(object sender, EventArgs e)
        {
            tbAmTimeOut.Text = GetCurrentTime();
        }

        private void btnPmTimeIn_Click(object sender, EventArgs e)
        {
            tbPmTimeIn.Text = GetCurrentTime();
        }

        private void btnPmTimeOut_Click(object sender, EventArgs e)
        {
            tbPmTimeOut.Text = GetCurrentTime();
        }

        private void btnOtTimeIn_Click(object sender, EventArgs e)
        {
            tbOtTimeIn.Text = GetCurrentTime();
        }

        private void btnOtTimeOut_Click(object sender, EventArgs e)
        {
            tbOtTimeOut.Text = GetCurrentTime();
        }

        #endregion TimeInTimeOut
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimeSprout.Forms.TimeRecord.Model;

namespace TimeSprout.Forms.TimeRecord
{
    public partial class TimeRecordForm : Form
    {
        public TimeRecordForm()
        {
            InitializeComponent();
            SetTextBoxDateOfWeek();
            populatePanelWithEmployees();
        }

        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value;

            // Update the textbox with the day of the week
            tbDayOfWeek.Text = selectedDate.ToString("dddd");
        }

        private void SetTextBoxDateOfWeek()
        {
            DateTime selectedDate = dateTimePicker1.Value;
            tbDayOfWeek.Text = selectedDate.ToString("dddd");
        }

        private List<TimeRecordDataClass> employees = new List<TimeRecordDataClass>();
        void populatePanelWithEmployees()
        {
            employees.Clear();
            employees.Add(
                new TimeRecordDataClass(
                date: "2024-06-04",
                id: "2024-01",
                employeeName: "Ralph Maron Eda",
                currentProject: "Earth 2.0",
                amTimeIn: "8:10",
                amTimeOut: "12:00",
                pmTimeIn: "1:20",
                pmTimeOut: "6:00",
                otTimeIn: "7:30",
                otTimeOut: "10:50")
                );
            employees.Add(
                new TimeRecordDataClass(
                date: "2024-06-04",
                id: "2024-02",
                employeeName: "Jackie Ferreras",
                currentProject: "Earth 2.1",
                amTimeIn: "8:00",
                amTimeOut: "12:00",
                pmTimeIn: "1:00",
                pmTimeOut: "6:00",
                otTimeIn: "7:00",
                otTimeOut: "10:00")
                );

            List<UserControlTimeRecord> userControls = new List<UserControlTimeRecord>();

            foreach (var employee in employees)
            {
                UserControlTimeRecord userControl = new UserControlTimeRecord(
                    recordDate: employee.RecordDate,
                    iD: employee.ID,
                    employeeName: employee.EmployeeName,
                    currentProject: employee.CurrentProject,
                    amTimeIn: employee.AmTimeIn,
                    amTimeOut: employee.AmTimeOut,
                    pmTimeIn: employee.PmTimeIn,
                    pmTimeOut: employee.AmTimeOut,
                    otTimeIn: employee.AmTimeOut,
                    otTimeOut: employee.AmTimeOut
                    );
                userControls.Add(userControl);
            }

            foreach (var userControl in userControls)
            {
                userControl.Dock = DockStyle.Top;
                userControl.Width = int.MaxValue; // fillMaxWidth()
                //userControl.BackColor = ColorPalette.AccentLavender;

                employeesPanel.Controls.Add(userControl);
            }

        }

    }
}

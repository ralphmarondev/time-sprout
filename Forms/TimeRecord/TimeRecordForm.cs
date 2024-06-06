using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimeSprout.Core.DB;
using TimeSprout.Forms.TimeRecord.Model;

namespace TimeSprout.Forms.TimeRecord
{
    public partial class TimeRecordForm : Form
    {
        private string currentDate = "";
        public TimeRecordForm()
        {
            InitializeComponent();
            SetTextBoxDateOfWeek();
            populatePanelWithEmployees();

            // assigning current date
            DateTime selectedDate = dateTimePicker1.Value;

            currentDate = selectedDate.ToString("ddMMyyyy");
            Console.WriteLine($"Current date: {currentDate}");
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
            employeesPanel.Controls.Clear();
            // Read from database]
            employees = DBTimeRecord.FetchAllTimeRecords(currentDate: currentDate);

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

                // adding click event on the usercontrol
                userControl.ButtonClicked += UserControl_ButtonClicked;

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

        private void UserControl_ButtonClicked(object sender, EventArgs e)
        {
            this.Enabled = false;

            // open the child form
            var childForm = new MyDialog();
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.FormClosed += ChildForm_FormClosed;
            childForm.ShowDialog(this);

            this.Enabled = true;

            // refresh list
            populatePanelWithEmployees();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // refresh the list
            Console.WriteLine("Refresing list...");
            populatePanelWithEmployees();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var createNewTimeRecord = new MyDialog();

            createNewTimeRecord.StartPosition = FormStartPosition.CenterParent;
            createNewTimeRecord.ShowDialog(this);
        }
    }
}

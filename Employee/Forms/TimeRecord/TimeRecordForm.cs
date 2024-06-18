using System;
using System.Drawing;
using System.Windows.Forms;
using TimeSprout.Core.DB;
using TimeSprout.Core.Model;

namespace TimeSprout.Employee.Forms.TimeRecord
{
    public partial class TimeRecordForm : Form
    {
        private string id, name, password, currentProject;
        private string currentDate;
        private string totalWorkedHour, totalOvertime;

        public TimeRecordForm(string _id, string _name, string _password, string _currentProject)
        {
            InitializeComponent();

            id = _id;
            name = _name;
            password = _password;
            currentProject = _currentProject;
        }

        private void TimeRecordForm_Load(object sender, EventArgs e)
        {
            SetupCurrentDate();
            SetUpEmployeeDetails();
            currentDate = GetFormattedDate();

            Console.WriteLine($"Time Record Form loaded...\nWe got: [id: {id}, name: {name}, password: {password}, currentProject: {currentProject}]");
            GetRecordForThisDay();
            UpdateTotalWorkHours();

            // disable button depending on what time it is now
            TimeInTimeOutCheck();
        }

        #region ON_LOAD
        private void SetUpEmployeeDetails()
        {
            lblEmployeeName.Text = name;
            tbEmployeeId.Text = id;
            tbCurrentProject.Text = currentProject;
        }
        private void SetupCurrentDate()
        {
            dateTimePicker2.Value = DateTime.Now;
            // Set the DateTimePicker format to Custom
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            // Define the custom format string
            dateTimePicker2.CustomFormat = "dd/MM/yyyy - ddd";

            tbCurrentDate.Text = dateTimePicker2.Value.ToString("dd/MM/yyyy - ddd");
        }

        private string GetFormattedDate()
        {
            DateTime selectedDate = dateTimePicker2.Value;
            string formattedDate = selectedDate.ToString("ddMMyyyy");

            Console.WriteLine($"Formatted date: {formattedDate}");
            return formattedDate;
        }

        private void GetRecordForThisDay()
        {
            if (DBTimeRecord.IsEmployeeTimeRecordExists(_currentDate: currentDate, _id: id))
            {
                TimeRecordModel record = DBTimeRecord.ReadEmployeeTimeRecord(_currentDate: currentDate, _id: id);

                tbAmTimeIn.Text = record.amTimeIn;
                tbAmTimeOut.Text = record.amTimeOut;
                tbPmTimeIn.Text = record.pmTimeIn;
                tbPmTimeOut.Text = record.pmTimeOut;
                tbOtTimeIn.Text = record.otTimeIn;
                tbOtTimeOut.Text = record.otTimeOut;
                lblWorkedHour.Text = record.workingHour;
                lblOvertime.Text = record.overtime;

                Console.WriteLine($"Record for currentDate: {currentDate} exists. Setting things up...");
                Console.WriteLine($"Time In/Out: [amIn: {tbAmTimeIn.Text}, amOut: {tbAmTimeOut.Text}]");
                Console.WriteLine($"Time In/Out: [pmIn: {tbPmTimeIn.Text}, pmOut: {tbPmTimeOut.Text}]");
                Console.WriteLine($"Time In/Out: [otIn: {tbOtTimeIn.Text}, otOut: {tbOtTimeOut.Text}]");
                Console.WriteLine($"Working hour: {lblWorkedHour.Text}, Overtime: {lblOvertime.Text}");
            }
            else
            {
                Console.WriteLine($"Record for currentDate: {currentDate} does not exist.");
            }
        }
        #endregion ON_LOAD


        #region DRAG_AND_DROP_TITLE
        private bool dragging = false;
        private System.Drawing.Point dragCursorPoint;
        private System.Drawing.Point dragFormPoint;

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.ParentForm.Location;
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                System.Drawing.Point diff = System.Drawing.Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                EmployeeMainForm mainForm = this.ParentForm as EmployeeMainForm;

                if (mainForm != null)
                {
                    mainForm.Location = System.Drawing.Point.Add(dragFormPoint, new Size(diff));
                }
            }
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion DRAG_AND_DROP_TITLE


        #region TOP_BAR
        private void btnLogout2_Click(object sender, EventArgs e)
        {
            EmployeeMainForm mainForm = this.ParentForm as EmployeeMainForm;

            if (mainForm != null)
            {
                mainForm.LogoutForm();
            }
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            EmployeeMainForm mainForm = this.ParentForm as EmployeeMainForm;

            if (mainForm != null)
            {
                mainForm.ToggleFullScreen();
            }
        }

        private void btnToggleNavPanel_Click(object sender, EventArgs e)
        {
            EmployeeMainForm mainForm = this.ParentForm as EmployeeMainForm;

            if (mainForm != null)
            {
                mainForm.ToggleNavigationPanel();
            }
        }

        private void btnEmployeeInfo_Click(object sender, EventArgs e)
        {
            EmployeeMainForm mainForm = this.ParentForm as EmployeeMainForm;

            if (mainForm != null)
            {
                mainForm.ShowEmployeeDetails();
            }
        }
        #endregion TOP_BAR



        #region SAVING_RECORD
        private string GetCurrentTime()
        {
            DateTime _currentTime = DateTime.Now;
            string formattedTime = _currentTime.ToString("hh:mm");

            Console.WriteLine($"Time now is: {formattedTime}");
            return formattedTime;
        }

        #region TimeFrame
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
        #endregion TimeFrame

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
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

                            Console.WriteLine($"Saving...");
                            MessageBox.Show("Saved.");
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

                            Console.WriteLine($"Updating...\n");
                            MessageBox.Show("Saved.");
                        }
                        Console.WriteLine($"Employee details: [id: {id}, name: {name}, currentProject: {currentProject}]");
                        Console.WriteLine($"Time In/Out: [amIn: {tbAmTimeIn.Text}, amOut: {tbAmTimeOut.Text}");
                        Console.WriteLine($"Time In/Out: [pmIn: {tbPmTimeIn.Text}, pmOut: {tbPmTimeOut.Text}");
                        Console.WriteLine($"Time In/Out: [otIn: {tbOtTimeIn.Text}, otOut: {tbOtTimeOut.Text}");
                        Console.WriteLine("Saved.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed saving. Error: {ex.Message}");
            }
        }

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
        #endregion SAVING_RECORD



        #region CALCULATING_TOTAL_WORKING_HOUR
        private void UpdateTotalWorkHours()
        {
            TimeSpan totalWorkingHours = CalculateTotalWorkingHours();
            TimeSpan totalOvertimeHours = CalculateTotalOverTime();

            lblWorkedHour.Text = totalWorkingHours.ToString(@"hh\:mm"); // "08:30" ;
            lblOvertime.Text = totalOvertimeHours.ToString(@"hh\:mm");

            totalWorkedHour = totalWorkingHours.ToString(@"hh\:mm");
            totalOvertime = totalOvertimeHours.ToString(@"hh\:mm");
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
    }
}

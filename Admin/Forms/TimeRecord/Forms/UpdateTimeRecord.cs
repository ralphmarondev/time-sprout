using System;
using System.Drawing;
using System.Runtime.InteropServices;
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
            // parse date with the currentDate passed
            DateTime parseDateTime;
            if (DateTime.TryParseExact(currentDate, "MMddyyyy", null, System.Globalization.DateTimeStyles.None, out parseDateTime))
            {
                dateTimePicker1.Value = parseDateTime;
            }
            else
            {
                Console.WriteLine("Cannot parse date.");
                dateTimePicker1.Value = DateTime.Now;
            }

            // setting the date time picker readonly

            SendMessage(dateTimePicker1.Handle, DTM_SETMCCOLOR, (IntPtr)MCSC_MONTHBK, (IntPtr)SystemColors.Control.ToArgb());
            // setting the label
            lblDayOfWeek.Text = dateTimePicker1.Value.ToString("dddd");
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private const int DTM_SETMCCOLOR = 0x1006;
        private const int MCSC_MONTHBK = 0; // MonthCal_SetColor index for the background color of the month calendar control

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
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // updating day of the week and current date
            lblDayOfWeek.Text = dateTimePicker1.Value.ToString("dddd");

            currentDate = dateTimePicker1.Value.ToString("MMddyyyy");
        }


        #region TIME_IN_OUT
        private string getCurrentTime()
        {
            DateTime _currentTime = DateTime.Now;
            string formattedTime = _currentTime.ToString("hh:mm");

            Console.WriteLine($"Time now is: {formattedTime}");
            return formattedTime;
        }
        private void btnAmTimeIn_Click(object sender, EventArgs e)
        {
            tbAmTimeIn.Text = getCurrentTime();
        }

        private void btnAmTimeOut_Click(object sender, EventArgs e)
        {
            tbAmTimeOut.Text = getCurrentTime();
        }

        private void btnPmTimeIn_Click(object sender, EventArgs e)
        {
            tbPmTimeIn.Text = getCurrentTime();
        }

        private void btnPmTimeOut_Click(object sender, EventArgs e)
        {
            tbPmTimeOut.Text = getCurrentTime();
        }

        private void btnOtTimeIn_Click(object sender, EventArgs e)
        {
            tbOtTimeIn.Text = getCurrentTime();
        }

        private void btnOtTimeOut_Click(object sender, EventArgs e)
        {
            tbOtTimeOut.Text = getCurrentTime();
        }
        #endregion TIME_IN_OUT

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            // Prevent the calendar from popping up
            //((HandledMouseEventArgs)e).Handled = true; // HACK: UNCOMMENT THIS IF YOU WANT TO CRASH YOU COMPUTER ON TRYING TO DROP DOWN THE DATETIMEPICKER :)
        }
    }
}

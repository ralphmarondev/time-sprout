using System;
using System.Windows.Forms;

namespace TimeSprout.Forms.TimeRecord
{
    public partial class TimeRecordForm : Form
    {
        public TimeRecordForm()
        {
            InitializeComponent();
            SetTextBoxDateOfWeek();
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
    }
}

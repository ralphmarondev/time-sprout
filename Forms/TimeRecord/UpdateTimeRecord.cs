using System;
using System.Windows.Forms;

namespace TimeSprout.Forms.TimeRecord
{
    public partial class UpdateTimeRecord : Form
    {
        public UpdateTimeRecord(string currentDate, string id, string name, string currentProject, string amIn, string amOut, string pmIn, string pmOut, string otIn, string otOut)
        {
            InitializeComponent();

            DateTime parseDateTime;
            if (DateTime.TryParseExact(currentDate, "ddMMyyyy", null, System.Globalization.DateTimeStyles.None, out parseDateTime))
            {
                dateTimePicker1.Value = parseDateTime;
            }
            else
            {
                Console.WriteLine("Cannot parse date.");
                dateTimePicker1.Value = DateTime.Now;
            }

            lblAmIn.Text = amIn;
            lblAmOut.Text = amOut;
            lblPmIn.Text = pmIn;
            lblPmOut.Text = pmOut;
            lblOtIn.Text = otIn;
            lblOtOut.Text = otOut;
        }

        private string GetCurrentTime()
        {
            DateTime _currentTime = DateTime.Now;
            string formattedTime = _currentTime.ToString("hh:mm");

            if (_currentTime.Hour < 10)
            {
                formattedTime = "0" + formattedTime;
            }

            Console.WriteLine($"Time now is: {formattedTime}");
            return formattedTime;
        }

        private void btnAmIn_Click(object sender, EventArgs e)
        {

        }

        private void btnAmOut_Click(object sender, EventArgs e)
        {

        }

        private void btnPmIn_Click(object sender, EventArgs e)
        {

        }

        private void btnPmOut_Click(object sender, EventArgs e)
        {

        }

        private void btnOtIn_Click(object sender, EventArgs e)
        {

        }

        private void btnOtOut_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

namespace TimeSprout.Admin.Forms.TimeRecord
{
    public partial class TimeRecordForm : Form
    {
        private string username, password, fullName;

        public TimeRecordForm()
        {
            InitializeComponent();
        }

        public TimeRecordForm(string _username, string _password, string _fullName)
        {
            InitializeComponent();

            username = _username;
            password = _password;
            fullName = _fullName;
        }

        private void TimeRecordForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("TimeRecordForm is loaded.");

            lblEmployeeName.Text = fullName;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}

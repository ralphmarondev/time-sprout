using System;
using System.Windows.Forms;

namespace TimeSprout.Admin.Forms.TimeRecord.Dialog
{
    public partial class UpdateDeleteTimeRecord : Form
    {
        private string id, name, currentProject, amTimeIn, amTimeOut;
        private string pmTimeIn, pmTimeOut, otTimeIn, otTimeOut, workingHour, overtime;
        private string date;

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

            date = _date;
        }

        private void UpdateDeleteTimeRecord_Load(object sender, EventArgs e)
        {
            Console.WriteLine("UpdateDeleteTimeRecord loaded successfully.");

            tbEmployeeId.Text = id;
            tbName.Text = name;
            tbCurrentProject.Text = currentProject;
            tbCurrentDate.Text = date;

            tbAmTimeIn.Text = amTimeIn;
            tbAmTimeOut.Text = amTimeOut;
            tbPmTimeIn.Text = pmTimeIn;
            tbPmTimeOut.Text = pmTimeOut;
            tbOtTimeIn.Text = otTimeIn;
            tbOtTimeOut.Text = otTimeOut;
            lblWorkedHour.Text = workingHour;
            lblOvertime.Text = overtime;
        }


        #region ACTIONS
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        #endregion ACTIONS
    }
}

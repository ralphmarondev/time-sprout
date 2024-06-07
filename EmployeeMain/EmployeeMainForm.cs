using System;
using System.Drawing;
using System.Windows.Forms;
using TimeSprout.Forms.TimeRecord.Model;

namespace TimeSprout.Main
{
    public partial class EmployeeMainForm : Form
    {
        string id, currentDate, name, currentProject;
        bool recordExists;
        TimeRecordDataClass recordDataClass;

        public EmployeeMainForm(string _id)
        {
            InitializeComponent();

            id = _id;
            name = EmployeeMainFromDBHelper.GetEmployeeName();
            currentProject = EmployeeMainFromDBHelper.GetEmployeeCurrentProject();

            currentDate = dateTimePicker1.Value.ToString("ddMMyyyy");
            recordExists = (TimeSprout.Core.DB.DBTimeRecord.IsEmployeeRecordExists(currentDate: currentDate, id: id));

            lblGreetings.Text = $"Hello, {name} ({id})";
            btnEmployeeSummary.FlatAppearance.BorderSize = 1;
            btnEmployeeSummary.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 255);
        }

        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {
            // read the data of id if exists in database
            if (recordExists)
            {
                // get all time in/out only and assign to the labels, also disable the button of that label
                recordDataClass = Core.DB.DBTimeRecord.ReadEmployeeTimeRecord(currentDate: currentDate, id: id);
                tbAmIn.Text = recordDataClass.AmTimeIn;
                tbAmOut.Text = recordDataClass.AmTimeOut;
                tbPmIn.Text = recordDataClass.PmTimeIn;
                tbPmOut.Text = recordDataClass.PmTimeOut;
                tbOtIn.Text = recordDataClass.OtTimeIn;
                tbOtOut.Text = recordDataClass.OtTimeOut;
            }
            else
            {
                Console.WriteLine("Failed reading record or record does not exist.");
            }
        }

        private void btnEmployeeSummary_Click(object sender, EventArgs e)
        {
            btnTimeRecord.FlatAppearance.BorderSize = 0;
            btnExport.FlatAppearance.BorderSize = 0;

            btnEmployeeSummary.FlatAppearance.BorderSize = 1;
            btnEmployeeSummary.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 255);
        }

        private void btnTimeRecord_Click(object sender, EventArgs e)
        {
            btnEmployeeSummary.FlatAppearance.BorderSize = 0;
            btnExport.FlatAppearance.BorderSize = 0;

            btnTimeRecord.FlatAppearance.BorderSize = 1;
            btnTimeRecord.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 255);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport.FlatAppearance.BorderSize = 1;
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 255);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // create new record if not exists otherwise update
            if (recordExists)
            {
                TimeSprout.Core.DB.DBTimeRecord.UpdateEmployeeTimeRecord(currentDate: currentDate, id: id, amIn: tbAmIn.Text, amOut: tbAmOut.Text, pmIn: tbPmIn.Text, pmOut: tbPmOut.Text, otIn: tbOtIn.Text, otOut: tbOtOut.Text);
            }
            else
            {
                TimeSprout.Core.DB.DBTimeRecord.CreateEmployeeTimeRecord(currentDate: currentDate, id: id, name: name, currentProject: currentProject, amIn: tbAmIn.Text, amOut: tbAmOut.Text, pmIn: tbPmIn.Text, pmOut: tbPmOut.Text, otIn: tbOtIn.Text, otOut: tbOtOut.Text);
            }
        }
    }
}

internal static class EmployeeMainFromDBHelper
{
    internal static string GetEmployeeName()
    {
        return "Ralph Maron Eda";
    }

    internal static string GetEmployeeCurrentProject()
    {
        return "Earth 2.0";
    }
}
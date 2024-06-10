using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.Export
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private void btnExportAllData_Click(object sender, EventArgs e)
        {
            DBExport.ExportAllDataFromDatabase();
        }

        private void btnExportByDate_Click(object sender, EventArgs e)
        {
            string currentDate = dateTimePicker1.Value.ToString("MMddyyyy");
            DBExport.ExportFromDatabaseByDate(_date: currentDate);
        }

        private void btnExportByTable_Click(object sender, EventArgs e)
        {
            DBExport.ExportFromDatabaseByTable(_tableName: tbTableName.Text);
        }
    }
}

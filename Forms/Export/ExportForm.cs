using System;
using System.Windows.Forms;
using TimeSprout.Core.EXCEL;

namespace TimeSprout.Forms.Export
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //var tableName = tbDate.Text;
            //tableName = "users"; // exporting the content of users
            //DatabaseToExcel.DatabaseToExcelExporter(tableName: tableName);

            // Exporting all tables to excel
            DatabaseToExcel.DatabaseToExcelExporter_AllTables();
        }
    }
}

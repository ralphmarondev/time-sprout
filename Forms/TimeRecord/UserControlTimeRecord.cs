using System.Windows.Forms;

namespace TimeSprout.Forms.TimeRecord
{
    public partial class UserControlTimeRecord : UserControl
    {
        public UserControlTimeRecord()
        {
            InitializeComponent();
        }
        public string RecordDate { get; set; }

        public string ID { get; set; }
        public string EmployeeName { get; set; }
        public string CurrentProject { get; set; }
        public string AmTimeIn { get; set; }
        public string AmTimeOut { get; set; }
        public string PmTimeIn { get; set; }
        public string PmTimeOut { get; set; }
        public string OtTimeIn { get; set; }
        public string OtTimeOut { get; set; }

        public UserControlTimeRecord(string recordDate, string iD, string employeeName, string currentProject, string amTimeIn, string amTimeOut, string pmTimeIn, string pmTimeOut, string otTimeIn, string otTimeOut)
        {
            InitializeComponent();

            lblRecordDate.Text = recordDate;
            lblID.Text = iD;
            lblName.Text = employeeName;
            lblAmTimeIn.Text = amTimeIn;
            lblAmTimeOut.Text = amTimeOut;
            lblPmTimeIn.Text = pmTimeIn;
            lblPmTimeOut.Text = pmTimeOut;
            lblOtTimeIn.Text = otTimeIn;
            lblOtTimeOut.Text = otTimeOut;
        }
    }
}

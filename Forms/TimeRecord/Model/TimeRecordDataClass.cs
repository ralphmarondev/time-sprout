namespace TimeSprout.Forms.TimeRecord.Model
{
    public class TimeRecordDataClass
    {
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

        public TimeRecordDataClass() { }
        public TimeRecordDataClass(string date, string id, string employeeName, string currentProject,
            string amTimeIn, string amTimeOut, string pmTimeIn, string pmTimeOut, string otTimeIn,
            string otTimeOut)
        {
            RecordDate = date;
            ID = id;
            EmployeeName = employeeName;
            CurrentProject = currentProject;
            AmTimeIn = amTimeIn;
            AmTimeOut = amTimeOut;
            PmTimeIn = pmTimeIn;
            PmTimeOut = pmTimeOut;
            OtTimeIn = otTimeIn;
            OtTimeOut = otTimeOut;
        }
    }
}

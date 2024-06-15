namespace TimeSprout.Core.Model
{
    internal class TimeRecordModel
    {
        public string id { get; set; }
        public string employeeName { get; set; }
        public string currentProject { get; set; }
        public string amTimeIn { get; set; }
        public string amTimeOut { get; set; }
        public string pmTimeIn { get; set; }
        public string pmTimeOut { get; set; }
        public string otTimeIn { get; set; }
        public string otTimeOut { get; set; }
        public string workingHour { get; set; }
        public string overtime { get; set; }

        public TimeRecordModel() { }

        public TimeRecordModel(string _id, string _employeeName, string _currentProject, string _amTimeIn, string _amTimeOut, string _pmTimeIn, string _pmTimeOut, string _otTimeIn, string _otTimeOut,
            string _workingHour, string _overtime)
        {
            this.id = _id;
            this.employeeName = _employeeName;
            this.currentProject = _currentProject;
            this.amTimeIn = _amTimeIn;
            this.amTimeOut = _amTimeOut;
            this.pmTimeIn = _pmTimeIn;
            this.pmTimeOut = _pmTimeOut;
            this.otTimeIn = _otTimeIn;
            this.otTimeOut = _otTimeOut;
            this.workingHour = workingHour;
            this.overtime = overtime;
        }
    }
}

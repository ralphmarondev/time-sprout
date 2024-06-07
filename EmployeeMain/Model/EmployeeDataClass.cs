namespace TimeSprout.EmployeeMain.Model
{
    internal class EmployeeDataClass
    {
        public string id { get; set; }
        public string name { get; set; }
        public string currentProject { get; set; }
        public string amIn { get; set; }
        public string amOut { get; set; }
        public string pmIn { get; set; }
        public string pmOut { get; set; }
        public string otIn { get; set; }
        public string otOut { get; set; }

        public EmployeeDataClass(string _id, string _name, string _currentProject, string _amIn, string _amOut, string _pmIn, string _pmOut, string _otIn, string _otOut)
        {
            id = _id;
            name = _name;
            currentProject = _currentProject;
            amIn = _amIn;
            amOut = _amOut;
            pmIn = _pmIn;
            pmOut = _pmOut;
            otIn = _otIn;
            otOut = _otOut;
        }
    }
}

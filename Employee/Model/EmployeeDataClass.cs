namespace TimeSprout.Employee.Model
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

        public EmployeeDataClass() { }
        public EmployeeDataClass(string id, string name, string currentProject, string amIn, string amOut, string pmIn, string pmOut, string otIn, string otOut)
        {
            this.id = id;
            this.name = name;
            this.currentProject = currentProject;
            this.amIn = amIn;
            this.amOut = amOut;
            this.pmIn = pmIn;
            this.pmOut = pmOut;
            this.otIn = otIn;
            this.otOut = otOut;
        }
    }
}

namespace TimeSprout.Core.Model
{
    internal class EmployeeModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string currentProject { get; set; }

        public EmployeeModel() { }

        public EmployeeModel(string _id, string _name, string _currentProject)
        {
            this.id = _id;
            this.name = _name;
            this.currentProject = _currentProject;
        }
    }
}

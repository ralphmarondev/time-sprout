namespace TimeSprout.Forms.Employees.Model
{
    public class EmployeeDataClass
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string CurrentProject { get; set; }

        public EmployeeDataClass() { }

        public EmployeeDataClass(string id, string name, string password, string currentProject)
        {
            ID = id;
            Name = name;
            Password = password;
            CurrentProject = currentProject;
        }
    }
}

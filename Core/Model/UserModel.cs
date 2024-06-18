namespace TimeSprout.Core.Model
{
    internal class UserModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }

        public UserModel(string _username, string _password, string _fullName)
        {
            username = _username;
            password = _password;
            fullName = _fullName;
        }
    }
}

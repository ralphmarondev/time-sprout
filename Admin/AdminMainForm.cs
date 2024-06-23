using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;
using TimeSprout.Core.Model;

namespace TimeSprout.Admin
{
    public partial class AdminMainForm : Form
    {
        private string username, password, fullName;
        public AdminMainForm()
        {
            InitializeComponent();
        }

        public AdminMainForm(string _username)
        {
            InitializeComponent();
            username = _username;
        }

        private void AdminMainForm_Load(object sender, System.EventArgs e)
        {
            GetAdminDetails(_username: username);

            OpenFormInPanel(new Forms.Summary.SummaryForm(
                _username: username,
                _password: password,
                _fullName: fullName));
            Console.WriteLine($"Username: {username}\nPassword: {password}\nFull Name: {fullName}");
        }



        #region ON_LOAD
        private void GetAdminDetails(string _username)
        {
            UserModel user = DBUsers.ReadUserWhereUsername(username);
            if (user != null)
            {
                username = user.username;
                password = user.password;
                fullName = user.fullName;
            }
        }

        #endregion ON_LOAD



        #region NAVIGATION
        private void OpenFormInPanel(Form form)
        {
            foreach (System.Windows.Forms.Control control in panelNavigation.Controls)
            {
                if (control is Form)
                {
                    ((Form)control).Close();
                }
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            mainPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }


        private void btnSummary_Click(object sender, System.EventArgs e)
        {
            OpenFormInPanel(new Forms.Summary.SummaryForm(
                _username: username,
                _password: password,
                _fullName: fullName));
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Admin.Forms.Employees.EmployeeForm(
                _name: username,
                _password: password,
                _fullName: fullName));
        }

        private void btnTimeInOut_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Admin.Forms.TimeRecord.TimeRecordForm());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Admin.Forms.Settings.SettingsForm(
                _username: username,
                _password: password,
                _fullName: fullName));
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutForm();
        }
        #endregion NAVIGATION



        #region TOP_BAR
        internal void LogoutForm()
        {
            Auth.AuthForm authForm = new Auth.AuthForm();

            authForm.Show();
            Close();
        }
        #endregion TOP_BAR
    }
}

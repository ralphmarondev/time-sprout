using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Employee.Forms.Settings
{
    public partial class SettingsForm : Form
    {
        private string id, name, currentProject, password;

        public SettingsForm(string _id, string _name, string _currentProject, string _password)
        {
            InitializeComponent();

            id = _id;
            name = _name;
            currentProject = _currentProject;
            password = _password;
        }



        #region ON_LOAD
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            panelUpdatePass.Visible = false;
            panelDetails.Visible = true;

            SetupFields();
        }

        private void SetupFields()
        {
            tbId.Text = id;
            tbName.Text = name;
            tbCurrentProject.Text = currentProject;
            tbPassword.Text = password;

            lblEmployeeName.Text = name;
        }
        #endregion ON_LOAD



        #region ACTIONS
        private void btnShowUpdate_Click(object sender, EventArgs e)
        {
            if (btnShowUpdate.Text == "UPDATE PASSWORD")
            {
                panelUpdatePass.Visible = true;
                //panelDetails.Visible = false;

                btnShowUpdate.Text = "CANCEL";
            }
            else
            {
                panelUpdatePass.Visible = false;
                //panelDetails.Visible = true;

                btnShowUpdate.Text = "UPDATE PASSWORD";
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string password = tbNewPassword.Text.Trim();
            string confirmPassword = tbConfirmPassword.Text.Trim();

            if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("Password did not match.");
            }
            else
            {
                DBEmployee.UpdateEmployeePassword(_id: id, _password: password);
                panelUpdatePass.Visible = false;
                panelDetails.Visible = true;
                tbPassword.Text = password;

                MessageBox.Show("Password updated successfully.\nYou need to login again.");
                // logout
                Close();
                Auth.AuthForm authForm = new Auth.AuthForm();

                authForm.Show();
            }
        }
        #endregion ACTIONS



        #region TOP_BAR
        // TODO: IMPLEMENT TOP BAR FUNCTIONALITY FOR THIS
        #endregion TOP_BAR
    }
}

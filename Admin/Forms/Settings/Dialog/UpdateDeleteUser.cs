using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.Settings.Dialog
{
    public partial class UpdateDeleteUser : Form
    {
        private string fullName, username, oldPassword;

        public UpdateDeleteUser(
            string _fullName,
            string _username,
            string _password)
        {
            InitializeComponent();

            fullName = _fullName;
            username = _username;
            oldPassword = _password;
        }

        private void UpdateDeleteUser_Load(object sender, EventArgs e)
        {
            tbFullName.Text = fullName;
            tbUsername.Text = username;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newPassword = tbNewPassword.Text.Trim();
            string confirmPassword = tbConfirmPassword.Text.Trim();
            string _fullName = tbFullName.Text.Trim();
            string _username = tbUsername.Text.Trim();

            if (!string.IsNullOrEmpty(fullName) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(newPassword))
            {
                if (newPassword.Equals(confirmPassword))
                {
                    DBUsers.UpdateUser(
                        username: _username,
                        password: newPassword,
                        fullName: _fullName);
                    MessageBox.Show("User details updated successfully.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Password did not match.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
    }
}

using System;
using System.Windows.Forms;
using TimeSprout.Core.DB;

namespace TimeSprout.Admin.Forms.Settings.Dialog
{
    public partial class CreateNewUser : Form
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = tbFullName.Text.Trim();
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            string password2 = tbConfirmPassword.Text.Trim();

            if (!string.IsNullOrEmpty(fullName) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (!password.Equals(password2))
                {
                    MessageBox.Show("Password did not match.");
                }
                else
                {
                    // TODO: save new user
                    DBUsers.CreateNewUser(
                        username: username,
                        password: password,
                        fullName: fullName);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }
    }
}

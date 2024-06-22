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
            btnDetailsNav_Click(sender, e);
        }



        #region Navigation
        private void btnDetailsNav_Click(object sender, EventArgs e)
        {
            // for update
            tbFullName.Text = fullName;
            tbUsername.Text = username;

            // for details
            tbDetailFullName.Text = fullName;
            tbDetailUsername.Text = username;
            tbDetailPassword.Text = oldPassword;

            panelUpdate.Visible = false;
            panelDetails.Visible = true;

            btnClose.Visible = true;
            btnDelete.Visible = false;
        }

        private void btnDeleteNav_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            panelDetails.Visible = true;

            btnClose.Visible = false;
            btnDelete.Visible = true;
        }

        private void btnUpdateNav_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = true;
            panelDetails.Visible = false;
        }
        #endregion Navigation



        #region Actions
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newPassword = tbNewPassword.Text.Trim();
            string confirmPassword = tbConfirmPassword.Text.Trim();
            string _fullName = tbFullName.Text.Trim();

            if (!string.IsNullOrEmpty(fullName) &&
                !string.IsNullOrEmpty(newPassword))
            {
                if (newPassword.Equals(confirmPassword))
                {
                    DBUsers.UpdateUser(
                        username: username,
                        password: newPassword,
                        fullName: _fullName);
                    MessageBox.Show("User details updated successfully.");
                    Close();

                    fullName = _fullName;
                    oldPassword = newPassword;

                    // go back to details
                    btnDetailsNav_Click(sender, e);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBUsers.DeleteUser(username: tbDetailUsername.Text.Trim());
                MessageBox.Show("User deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            Close();
        }
        #endregion

    }
}

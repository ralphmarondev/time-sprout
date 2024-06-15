using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TimeSprout.Core.DB;
using TimeSprout.Employee;

namespace TimeSprout.Auth
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            tbStatus.Text = "EMPLOYEE";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*EMPLOYEE
                ADMIN*/
            if (tbStatus.Text == "ADMIN")
            {
                //if (DBUsers.IsUserExists(username: tbUsername.Text, password: tbPassword.Text))
                //{
                //    Console.WriteLine("Login successfully...");
                //    AdminMainForm adminMainForm = new AdminMainForm(tbUsername.Text);

                //    Hide();
                //    adminMainForm.ShowDialog();
                //}
                //else
                //{
                //    MessageBox.Show("Incorrent Password :)", "Loggin in as Admin.");
                //}
            }
            else
            {
                // GO TO EMPLOYEE FORM
                // TODO: IMPLEMENT THIS LATER
                if (DBEmployee.IsEmployeeExists(_id: tbUsername.Text, _password: tbPassword.Text))
                {
                    Console.WriteLine($"Login as [{tbUsername.Text}] successfully.");

                    EmployeeMainForm employeeMainForm = new EmployeeMainForm(tbUsername.Text);

                    Hide();
                    employeeMainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrent Password :)", "Logging in as Employee.");
                }
            }
        }



        #region DRAG_AND_DROP_TITLE

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion DRAG_AND_DROP_TITLE



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            // making status combo box readonly
            e.Handled = true;
        }
    }
}

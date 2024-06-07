using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TimeSprout.Admin;
using TimeSprout.Core.DB;

namespace TimeSprout.Auth
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            tbStatus.Text = "ADMIN";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*EMPLOYEE
                ADMIN*/
            if (tbStatus.Text == "ADMIN")
            {
                if (DBUsers.IsUserExists(username: tbUsername.Text, password: tbPassword.Text))
                {
                    Console.WriteLine("Login successfully...");
                    AdminMainForm adminMainForm = new AdminMainForm(tbUsername.Text);

                    Hide();
                    adminMainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrent Password :)");
                }
            }
            else
            {
                // GO TO EMPLOYEE FORM
                // TODO: IMPLEMENT THIS LATER
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
    }
}

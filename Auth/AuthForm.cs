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
            tbStatus.Text = "EMPLOYEE";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DBUsers.IsUserExists(username: tbUsername.Text.Trim(), password: tbPassword.Text.Trim()))
            {
                Console.WriteLine("Login successfully...");
                AdminMainForm adminMainForm = new AdminMainForm(tbUsername.Text.Trim());

                adminMainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrent Password!", "Logging in as Admin.");
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

        private void AuthForm_Load(object sender, EventArgs e)
        {
            //tbUsername.Text = "root";
            //tbStatus.Text = "ADMIN";
            //tbPassword.Text = "toor";
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "2024-001";
            tbStatus.Text = "EMPLOYEE";
            tbPassword.Text = "ispretty";
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "2024-002";
            tbStatus.Text = "EMPLOYEE";
            tbPassword.Text = "iscute";
        }

        private void btnroot_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "root";
            tbStatus.Text = "ADMIN";
            tbPassword.Text = "toor";
        }
    }
}

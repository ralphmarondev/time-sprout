using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TimeSprout.Core.DB;
using TimeSprout.Core.Utils;

namespace TimeSprout
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }


        #region DRAGGING_FROM_WITH_LABEL
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

        #endregion DRAGGING_FROM_WITH_LABEL


        private void tbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Suppress any key presses to make the ComboBox readonly
            e.Handled = true;
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            Console.WriteLine($"Username: {tbUsername.Text}, Status: {tbStatus.Text}, Password: {tbPassword.Text}");

            if (DBUsers.IsUserExists(username: tbUsername.Text, password: tbPassword.Text))
            {
                Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = ColorPalette.AccentLavender;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = ColorPalette.PrimaryPurple;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

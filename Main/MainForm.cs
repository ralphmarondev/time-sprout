using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TimeSprout.Forms.Employees;
using TimeSprout.Forms.TimeRecord;

namespace TimeSprout
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            OpenFormInPanel(new EmployeesForm(), "Hello world");
        }
        public MainForm(string username)
        {
            lblGreetings.Text = $"Hello, {username}";
        }

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

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnToggleNavBar_Click(object sender, EventArgs e)
        {
            if (navBarPanel.Visible)
                navBarPanel.Visible = false;
            else
                navBarPanel.Visible = true;
        }

        // opening form inside a panel
        private void OpenFormInPanel(Form form, string formTitle)
        {
            // close any previously opened form
            foreach (Control control in navBarPanel.Controls)
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

            // update the label with the current for subititle
            lblDestination.Text = $"{formTitle}";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new TimeRecordForm(), "Time Record");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new EmployeesForm(), "Employees");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            AuthForm authForm = new AuthForm();
            authForm.Show();
        }
    }
}

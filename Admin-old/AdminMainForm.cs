﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TimeSprout.Admin.Forms;
using TimeSprout.Admin.Forms.Employees;
using TimeSprout.Admin.Forms.Export;
using TimeSprout.Admin.Forms.Records;
using TimeSprout.Auth;

namespace TimeSprout.Admin
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        public AdminMainForm(string _name)
        {
            InitializeComponent();

            lblGreetings.Text = $"Hello, {_name}";
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new TimeRecordForm(), "Home");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
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



        #region NAVIGATIONS
        private void OpenFormInPanel(Form form, string formTitle)
        {
            foreach (Control control in navigationPanel.Controls)
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new TimeRecordForm(), "Home");
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new EmployeesForm(), "Employee");
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new RecordForm(), "Records");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new ExportForm(), "Export");
        }
        private void btnToggleNavBar_Click(object sender, EventArgs e)
        {
            navigationPanel.Visible = !navigationPanel.Visible;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion NAVIGATIONS
    }
}
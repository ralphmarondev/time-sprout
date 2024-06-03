using System;
using System.Windows.Forms;

namespace TimeSprout
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            mainForm.ShowDialog();
        }
    }
}

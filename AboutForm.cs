using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace MotionSentinel
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            lblVersion.Text = $"Version: {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/xpit-gamer/MotionSentinel",
                UseShellExecute = true
            });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

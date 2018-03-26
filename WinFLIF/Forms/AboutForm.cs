using System.Diagnostics;
using System.Windows.Forms;
using WinFLIF.Properties;

namespace WinFLIF.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            this.Icon = Resources.WinFLIF;
            this.Text = "About";
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Zaczero/WinFLIF");
        }
    }
}

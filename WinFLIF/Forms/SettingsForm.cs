using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFLIF.Properties;

namespace WinFLIF.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            this.Icon = Resources.WinFLIF;
            this.Text = "WinFLIF Settings";

            this.effortNum.Value = Settings.Default.flif_effort;
            this.qualityNum.Value = Settings.Default.flif_quality;
            this.argsBox.Text = Settings.Default.flif_arguments;
        }

        private void helpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var processInfo = new ProcessStartInfo("cmd.exe")
            {
                Arguments = $"/K \"{FlifConverter.FlifBinary}\"",
            };

            Process.Start(processInfo);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Settings.Default.flif_effort = (int) this.effortNum.Value;
            Settings.Default.flif_quality = (int) this.qualityNum.Value;
            Settings.Default.flif_arguments = this.argsBox.Text;
            Settings.Default.Save();
            Close();
        }
    }
}

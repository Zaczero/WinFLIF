using System;
using System.Linq;
using System.Windows.Forms;
using WinFLIF.Properties;

namespace WinFLIF.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Icon = Resources.WinFLIF;
            this.Text = "WinFLIF";

            this.dropPanel.Click += DropOnClick;
            this.dropPicture.Click += DropOnClick;
            this.dropLabel.Click += DropOnClick;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            this.dropPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void aboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
            aboutForm.Dispose();
        }

        private void dropPanel_MouseEnter(object sender, EventArgs e)
        {
            this.dropPanel.BorderStyle = BorderStyle.Fixed3D;
        }

        private void dropPanel_MouseLeave(object sender, EventArgs e)
        {
            if (this.dropPanel.ClientRectangle.Contains(this.dropPanel.PointToClient(Cursor.Position)))
            {
                return;
            }

            this.dropPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private async void DropOnClick(object sender, EventArgs eventArgs)
        {
            if (this.convertProgress.Visible)
            {
                return;
            }

            var ofd = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = true,
                Filter = "Image files (*.flif, *.png)|*.flif;*.png",
            };

            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                this.convertProgress.Visible = true;
                await ConvertProvider.Convert(this.convertProgress, ofd.FileNames);
                this.convertProgress.Visible = false;
            }

            ofd.Dispose();
        }

        private void MainForm_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private async void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (this.convertProgress.Visible)
            {
                return;
            }

            var paths = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (paths == null || !paths.Any())
            {
                return;
            }

            this.convertProgress.Visible = true;
            await ConvertProvider.Convert(this.convertProgress, paths);
            this.convertProgress.Visible = false;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                this.dropPanel.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void MainForm_DragLeave(object sender, EventArgs e)
        {
            this.dropPanel.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}

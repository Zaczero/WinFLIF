namespace WinFLIF.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.dropPanel = new System.Windows.Forms.Panel();
            this.convertProgress = new System.Windows.Forms.ProgressBar();
            this.dropLabel = new System.Windows.Forms.Label();
            this.dropPicture = new System.Windows.Forms.PictureBox();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.settingsLink = new System.Windows.Forms.LinkLabel();
            this.dropPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(140, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "WinFLIF";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(239)))), ((int)(((byte)(207)))));
            this.subtitleLabel.Location = new System.Drawing.Point(17, 50);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(182, 13);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "FLIF image converter for Windows";
            // 
            // dropPanel
            // 
            this.dropPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.dropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropPanel.Controls.Add(this.convertProgress);
            this.dropPanel.Controls.Add(this.dropLabel);
            this.dropPanel.Controls.Add(this.dropPicture);
            this.dropPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropPanel.Location = new System.Drawing.Point(12, 79);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(260, 270);
            this.dropPanel.TabIndex = 2;
            this.dropPanel.MouseEnter += new System.EventHandler(this.dropPanel_MouseEnter);
            this.dropPanel.MouseLeave += new System.EventHandler(this.dropPanel_MouseLeave);
            // 
            // convertProgress
            // 
            this.convertProgress.Location = new System.Drawing.Point(63, 195);
            this.convertProgress.Name = "convertProgress";
            this.convertProgress.Size = new System.Drawing.Size(132, 5);
            this.convertProgress.TabIndex = 2;
            this.convertProgress.Visible = false;
            // 
            // dropLabel
            // 
            this.dropLabel.AutoSize = true;
            this.dropLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dropLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.dropLabel.Location = new System.Drawing.Point(89, 163);
            this.dropLabel.Name = "dropLabel";
            this.dropLabel.Size = new System.Drawing.Size(82, 13);
            this.dropLabel.TabIndex = 1;
            this.dropLabel.Text = "drag and drop";
            // 
            // dropPicture
            // 
            this.dropPicture.BackgroundImage = global::WinFLIF.Properties.Resources.dropIcon;
            this.dropPicture.Location = new System.Drawing.Point(90, 85);
            this.dropPicture.Name = "dropPicture";
            this.dropPicture.Size = new System.Drawing.Size(80, 80);
            this.dropPicture.TabIndex = 0;
            this.dropPicture.TabStop = false;
            // 
            // aboutLink
            // 
            this.aboutLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(239)))), ((int)(((byte)(207)))));
            this.aboutLink.AutoSize = true;
            this.aboutLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(219)))));
            this.aboutLink.Location = new System.Drawing.Point(233, 34);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(39, 13);
            this.aboutLink.TabIndex = 3;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "About";
            this.aboutLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(219)))));
            this.aboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLink_LinkClicked);
            // 
            // settingsLink
            // 
            this.settingsLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(239)))), ((int)(((byte)(207)))));
            this.settingsLink.AutoSize = true;
            this.settingsLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(219)))));
            this.settingsLink.Location = new System.Drawing.Point(223, 50);
            this.settingsLink.Name = "settingsLink";
            this.settingsLink.Size = new System.Drawing.Size(49, 13);
            this.settingsLink.TabIndex = 4;
            this.settingsLink.TabStop = true;
            this.settingsLink.Text = "Settings";
            this.settingsLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(219)))));
            this.settingsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.settingsLink_LinkClicked);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.settingsLink);
            this.Controls.Add(this.aboutLink);
            this.Controls.Add(this.dropPanel);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(219)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainForm_DragOver);
            this.DragLeave += new System.EventHandler(this.MainForm_DragLeave);
            this.dropPanel.ResumeLayout(false);
            this.dropPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Panel dropPanel;
        private System.Windows.Forms.PictureBox dropPicture;
        private System.Windows.Forms.Label dropLabel;
        private System.Windows.Forms.LinkLabel aboutLink;
        private System.Windows.Forms.ProgressBar convertProgress;
        private System.Windows.Forms.LinkLabel settingsLink;
    }
}


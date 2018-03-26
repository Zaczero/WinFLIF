namespace WinFLIF.Forms
{
    partial class SettingsForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.effortGroup = new System.Windows.Forms.GroupBox();
            this.effortNum = new System.Windows.Forms.NumericUpDown();
            this.effortLabel = new System.Windows.Forms.Label();
            this.qualityGroup = new System.Windows.Forms.GroupBox();
            this.qualityNum = new System.Windows.Forms.NumericUpDown();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.argsGroup = new System.Windows.Forms.GroupBox();
            this.helpLink = new System.Windows.Forms.LinkLabel();
            this.argsBox = new System.Windows.Forms.TextBox();
            this.argsLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.effortGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effortNum)).BeginInit();
            this.qualityGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualityNum)).BeginInit();
            this.argsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // effortGroup
            // 
            this.effortGroup.Controls.Add(this.effortNum);
            this.effortGroup.Controls.Add(this.effortLabel);
            this.effortGroup.Location = new System.Drawing.Point(12, 12);
            this.effortGroup.Name = "effortGroup";
            this.effortGroup.Size = new System.Drawing.Size(318, 70);
            this.effortGroup.TabIndex = 0;
            this.effortGroup.TabStop = false;
            this.effortGroup.Text = "Effort";
            // 
            // effortNum
            // 
            this.effortNum.Location = new System.Drawing.Point(9, 37);
            this.effortNum.Name = "effortNum";
            this.effortNum.Size = new System.Drawing.Size(300, 22);
            this.effortNum.TabIndex = 1;
            // 
            // effortLabel
            // 
            this.effortLabel.AutoSize = true;
            this.effortLabel.Location = new System.Drawing.Point(6, 18);
            this.effortLabel.Name = "effortLabel";
            this.effortLabel.Size = new System.Drawing.Size(303, 13);
            this.effortLabel.TabIndex = 0;
            this.effortLabel.Text = "0=fast/poor compression, 100=slowest/best? (default: 60)";
            // 
            // qualityGroup
            // 
            this.qualityGroup.Controls.Add(this.qualityNum);
            this.qualityGroup.Controls.Add(this.qualityLabel);
            this.qualityGroup.Location = new System.Drawing.Point(12, 88);
            this.qualityGroup.Name = "qualityGroup";
            this.qualityGroup.Size = new System.Drawing.Size(318, 70);
            this.qualityGroup.TabIndex = 2;
            this.qualityGroup.TabStop = false;
            this.qualityGroup.Text = "Quality";
            // 
            // qualityNum
            // 
            this.qualityNum.Location = new System.Drawing.Point(9, 37);
            this.qualityNum.Name = "qualityNum";
            this.qualityNum.Size = new System.Drawing.Size(300, 22);
            this.qualityNum.TabIndex = 1;
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(6, 18);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(215, 13);
            this.qualityLabel.TabIndex = 0;
            this.qualityLabel.Text = "lossy compression; default: 100 (lossless)";
            // 
            // argsGroup
            // 
            this.argsGroup.Controls.Add(this.helpLink);
            this.argsGroup.Controls.Add(this.argsBox);
            this.argsGroup.Controls.Add(this.argsLabel);
            this.argsGroup.Location = new System.Drawing.Point(12, 164);
            this.argsGroup.Name = "argsGroup";
            this.argsGroup.Size = new System.Drawing.Size(318, 70);
            this.argsGroup.TabIndex = 3;
            this.argsGroup.TabStop = false;
            this.argsGroup.Text = "FLIF arguments";
            // 
            // helpLink
            // 
            this.helpLink.AutoSize = true;
            this.helpLink.Location = new System.Drawing.Point(248, 18);
            this.helpLink.Name = "helpLink";
            this.helpLink.Size = new System.Drawing.Size(61, 13);
            this.helpLink.TabIndex = 3;
            this.helpLink.TabStop = true;
            this.helpLink.Text = "show help";
            this.helpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLink_LinkClicked);
            // 
            // argsBox
            // 
            this.argsBox.Location = new System.Drawing.Point(9, 37);
            this.argsBox.Name = "argsBox";
            this.argsBox.Size = new System.Drawing.Size(300, 22);
            this.argsBox.TabIndex = 2;
            // 
            // argsLabel
            // 
            this.argsLabel.AutoSize = true;
            this.argsLabel.Location = new System.Drawing.Point(6, 18);
            this.argsLabel.Name = "argsLabel";
            this.argsLabel.Size = new System.Drawing.Size(184, 13);
            this.argsLabel.TabIndex = 0;
            this.argsLabel.Text = "optional command line arguments";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(256, 240);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(175, 240);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(343, 275);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.argsGroup);
            this.Controls.Add(this.qualityGroup);
            this.Controls.Add(this.effortGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.effortGroup.ResumeLayout(false);
            this.effortGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effortNum)).EndInit();
            this.qualityGroup.ResumeLayout(false);
            this.qualityGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualityNum)).EndInit();
            this.argsGroup.ResumeLayout(false);
            this.argsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox effortGroup;
        private System.Windows.Forms.Label effortLabel;
        private System.Windows.Forms.NumericUpDown effortNum;
        private System.Windows.Forms.GroupBox qualityGroup;
        private System.Windows.Forms.NumericUpDown qualityNum;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.GroupBox argsGroup;
        private System.Windows.Forms.LinkLabel helpLink;
        private System.Windows.Forms.TextBox argsBox;
        private System.Windows.Forms.Label argsLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}
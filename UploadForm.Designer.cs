﻿namespace uploader
{
    partial class UploadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadForm));
            this.settingsGroup = new DarkUI.Controls.DarkGroupBox();
            this.sha2Textbox = new DarkUI.Controls.DarkTextBox();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.shaTextbox = new DarkUI.Controls.DarkTextBox();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.mdTextbox = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.uploadButton = new DarkUI.Controls.DarkButton();
            this.statusLabel = new DarkUI.Controls.DarkLabel();
            this.Back = new System.Windows.Forms.Button();
            this.settingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsGroup
            // 
            this.settingsGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.settingsGroup.Controls.Add(this.sha2Textbox);
            this.settingsGroup.Controls.Add(this.darkLabel3);
            this.settingsGroup.Controls.Add(this.shaTextbox);
            this.settingsGroup.Controls.Add(this.darkLabel2);
            this.settingsGroup.Controls.Add(this.mdTextbox);
            this.settingsGroup.Controls.Add(this.darkLabel1);
            this.settingsGroup.Location = new System.Drawing.Point(0, 12);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(359, 110);
            this.settingsGroup.TabIndex = 0;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "File information";
            this.settingsGroup.Enter += new System.EventHandler(this.settingsGroup_Enter);
            // 
            // sha2Textbox
            // 
            this.sha2Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.sha2Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sha2Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha2Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.sha2Textbox.Location = new System.Drawing.Point(73, 21);
            this.sha2Textbox.Name = "sha2Textbox";
            this.sha2Textbox.Size = new System.Drawing.Size(280, 19);
            this.sha2Textbox.TabIndex = 5;
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(6, 23);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(57, 13);
            this.darkLabel3.TabIndex = 4;
            this.darkLabel3.Text = "File Name:";
            // 
            // shaTextbox
            // 
            this.shaTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.shaTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shaTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.shaTextbox.Location = new System.Drawing.Point(73, 72);
            this.shaTextbox.Name = "shaTextbox";
            this.shaTextbox.Size = new System.Drawing.Size(280, 20);
            this.shaTextbox.TabIndex = 3;
            this.shaTextbox.TextChanged += new System.EventHandler(this.shaTextbox_TextChanged);
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(16, 79);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(38, 13);
            this.darkLabel2.TabIndex = 2;
            this.darkLabel2.Text = "SHA1:";
            // 
            // mdTextbox
            // 
            this.mdTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.mdTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.mdTextbox.Location = new System.Drawing.Point(73, 46);
            this.mdTextbox.Name = "mdTextbox";
            this.mdTextbox.Size = new System.Drawing.Size(280, 20);
            this.mdTextbox.TabIndex = 1;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(1, 48);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(62, 13);
            this.darkLabel1.TabIndex = 0;
            this.darkLabel1.Text = "CheckSum:";
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(0, 128);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Padding = new System.Windows.Forms.Padding(5);
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 1;
            this.uploadButton.Text = "Upload";
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.statusLabel.Location = new System.Drawing.Point(81, 133);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(27, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Idle.";
            // 
            // Back
            // 
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(356, -3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(27, 24);
            this.Back.TabIndex = 20;
            this.Back.Text = "X";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // UploadForm
            // 
            this.AcceptButton = this.uploadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 156);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.settingsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VirusTotal Uploader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UploadForm_FormClosing);
            this.Load += new System.EventHandler(this.UploadForm_Load);
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkGroupBox settingsGroup;
        private DarkUI.Controls.DarkButton uploadButton;
        private DarkUI.Controls.DarkLabel statusLabel;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox sha2Textbox;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkTextBox shaTextbox;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkTextBox mdTextbox;
        private System.Windows.Forms.Button Back;
    }
}
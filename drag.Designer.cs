namespace uploader
{
    partial class drag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drag));
            this.moreLabel = new DarkUI.Controls.DarkLabel();
            this.dragLabel = new DarkUI.Controls.DarkLabel();
            this.SuspendLayout();
            // 
            // moreLabel
            // 
            this.moreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moreLabel.BackColor = System.Drawing.Color.Transparent;
            this.moreLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.moreLabel.Location = new System.Drawing.Point(330, 568);
            this.moreLabel.Name = "moreLabel";
            this.moreLabel.Size = new System.Drawing.Size(86, 23);
            this.moreLabel.TabIndex = 1;
            this.moreLabel.Text = "More";
            this.moreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moreLabel.Click += new System.EventHandler(this.moreLabel_Click);
            // 
            // dragLabel
            // 
            this.dragLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragLabel.BackColor = System.Drawing.Color.Transparent;
            this.dragLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dragLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dragLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dragLabel.Location = new System.Drawing.Point(211, 226);
            this.dragLabel.Name = "dragLabel";
            this.dragLabel.Size = new System.Drawing.Size(333, 124);
            this.dragLabel.TabIndex = 0;
            this.dragLabel.Text = "Click to select file";
            this.dragLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dragLabel.Click += new System.EventHandler(this.dragLabel_Click);
            // 
            // drag
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(749, 600);
            this.Controls.Add(this.moreLabel);
            this.Controls.Add(this.dragLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "drag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VirusTotal Uploader";
            this.Load += new System.EventHandler(this.drag_Load);
            this.Shown += new System.EventHandler(this.drag_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.drag_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.drag_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkLabel moreLabel;
        private DarkUI.Controls.DarkLabel dragLabel;
    }
}


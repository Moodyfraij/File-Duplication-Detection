namespace HW
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTitel = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Reporting = new System.Windows.Forms.Button();
            this.UPfile = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.Button();
            this.HDscan = new System.Windows.Forms.Button();
            this.Dfinder = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Reporting);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Dfinder);
            this.panel1.Controls.Add(this.About);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 600);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.UPfile);
            this.panel2.Controls.Add(this.Path);
            this.panel2.Controls.Add(this.HDscan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 317);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel3.BackgroundImage = global::HW.Properties.Resources.pngwing_com__5_;
            this.panel3.Controls.Add(this.panelTitel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(164, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(743, 600);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panelTitel
            // 
            this.panelTitel.Controls.Add(this.buttonMinimize);
            this.panelTitel.Controls.Add(this.Exit);
            this.panelTitel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitel.Location = new System.Drawing.Point(0, 0);
            this.panelTitel.Name = "panelTitel";
            this.panelTitel.Size = new System.Drawing.Size(743, 27);
            this.panelTitel.TabIndex = 8;
            this.panelTitel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitel_MouseDown_1);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMinimize.Image = global::HW.Properties.Resources._0011;
            this.buttonMinimize.Location = new System.Drawing.Point(681, -1);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(30, 25);
            this.buttonMinimize.TabIndex = 10;
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.Image = global::HW.Properties.Resources.icons8_exit_30;
            this.Exit.Location = new System.Drawing.Point(717, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 25);
            this.Exit.TabIndex = 9;
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(136, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 107);
            this.label1.TabIndex = 6;
            this.label1.Text = "Duplication Detection";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Reporting
            // 
            this.Reporting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.Reporting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Reporting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reporting.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Reporting.Image = ((System.Drawing.Image)(resources.GetObject("Reporting.Image")));
            this.Reporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reporting.Location = new System.Drawing.Point(0, 395);
            this.Reporting.Name = "Reporting";
            this.Reporting.Size = new System.Drawing.Size(160, 78);
            this.Reporting.TabIndex = 6;
            this.Reporting.Text = "  API Scan";
            this.Reporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reporting.UseVisualStyleBackColor = false;
            this.Reporting.Click += new System.EventHandler(this.Reporting_Click_1);
            // 
            // UPfile
            // 
            this.UPfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.UPfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.UPfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UPfile.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UPfile.Image = global::HW.Properties.Resources.duplicate;
            this.UPfile.Location = new System.Drawing.Point(0, 210);
            this.UPfile.Name = "UPfile";
            this.UPfile.Size = new System.Drawing.Size(160, 105);
            this.UPfile.TabIndex = 7;
            this.UPfile.Text = "Upload File";
            this.UPfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip2.SetToolTip(this.UPfile, "This scan will search the uploaded files for duplicates.");
            this.toolTip1.SetToolTip(this.UPfile, "This scan will search the uploaded files for duplicates.");
            this.toolTip3.SetToolTip(this.UPfile, "This scan will search the uploaded files for duplicates.");
            this.UPfile.UseVisualStyleBackColor = false;
            this.UPfile.Click += new System.EventHandler(this.UPfile_Click);
            // 
            // Path
            // 
            this.Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.Path.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Path.Dock = System.Windows.Forms.DockStyle.Top;
            this.Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Path.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Path.Image = ((System.Drawing.Image)(resources.GetObject("Path.Image")));
            this.Path.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Path.Location = new System.Drawing.Point(0, 105);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(160, 105);
            this.Path.TabIndex = 6;
            this.Path.Text = "Specific   Path";
            this.Path.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip2.SetToolTip(this.Path, "This scan will search a specific folder or directory for duplicate files.");
            this.toolTip1.SetToolTip(this.Path, "This scan will search a specific folder or directory for duplicate files.");
            this.toolTip3.SetToolTip(this.Path, "This scan will search a specific folder or directory for duplicate files.");
            this.Path.UseVisualStyleBackColor = false;
            this.Path.Click += new System.EventHandler(this.Path_Click);
            // 
            // HDscan
            // 
            this.HDscan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.HDscan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HDscan.Dock = System.Windows.Forms.DockStyle.Top;
            this.HDscan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HDscan.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDscan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HDscan.Image = ((System.Drawing.Image)(resources.GetObject("HDscan.Image")));
            this.HDscan.Location = new System.Drawing.Point(0, 0);
            this.HDscan.Name = "HDscan";
            this.HDscan.Size = new System.Drawing.Size(160, 105);
            this.HDscan.TabIndex = 5;
            this.HDscan.Text = "Hard Disk";
            this.HDscan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HDscan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip2.SetToolTip(this.HDscan, "This scan will search your entire hard disk for duplicate files.");
            this.toolTip1.SetToolTip(this.HDscan, "This scan will search your entire hard disk for duplicate files.");
            this.toolTip3.SetToolTip(this.HDscan, "This scan will search your entire hard disk for duplicate files.");
            this.HDscan.UseVisualStyleBackColor = false;
            this.HDscan.Click += new System.EventHandler(this.HDscan_Click);
            // 
            // Dfinder
            // 
            this.Dfinder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.Dfinder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dfinder.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dfinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dfinder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dfinder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Dfinder.Image = ((System.Drawing.Image)(resources.GetObject("Dfinder.Image")));
            this.Dfinder.Location = new System.Drawing.Point(0, 0);
            this.Dfinder.Name = "Dfinder";
            this.Dfinder.Size = new System.Drawing.Size(160, 78);
            this.Dfinder.TabIndex = 4;
            this.Dfinder.Text = "Duplication Finder";
            this.Dfinder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dfinder.UseVisualStyleBackColor = false;
            this.Dfinder.Click += new System.EventHandler(this.Dfinder_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.About.Image = global::HW.Properties.Resources.icons8_about_75;
            this.About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.Location = new System.Drawing.Point(0, 518);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(160, 78);
            this.About.TabIndex = 3;
            this.About.Text = " About";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(907, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplication Detection";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelTitel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UPfile;
        private System.Windows.Forms.Button Path;
        private System.Windows.Forms.Button HDscan;
        private System.Windows.Forms.Button Dfinder;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Reporting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitel;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button Exit;
    }
}
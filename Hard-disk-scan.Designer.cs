namespace HW
{
    partial class Hard_disk_scan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hard_disk_scan));
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.labelTitel = new System.Windows.Forms.Label();
            this.groupBoxSearchLO = new System.Windows.Forms.GroupBox();
            this.labelselectfolder = new System.Windows.Forms.Label();
            this.actionon01 = new System.Windows.Forms.Button();
            this.buttonfileselect = new System.Windows.Forms.Button();
            this.groupBoxDFound = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.radiodelete = new System.Windows.Forms.RadioButton();
            this.runButton = new System.Windows.Forms.Button();
            this.radioarchive = new System.Windows.Forms.RadioButton();
            this.listDfinder = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.collastmodify = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDfind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quarantineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aPIScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Back = new System.Windows.Forms.Button();
            this.groupBoxSearchLO.SuspendLayout();
            this.groupBoxDFound.SuspendLayout();
            this.panel1.SuspendLayout();
            this.lvContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitel.AutoEllipsis = true;
            this.labelTitel.AutoSize = true;
            this.labelTitel.BackColor = System.Drawing.Color.Transparent;
            this.labelTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTitel.Location = new System.Drawing.Point(252, 0);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(253, 46);
            this.labelTitel.TabIndex = 15;
            this.labelTitel.Text = "Hard Disk Scan";
            this.labelTitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxSearchLO
            // 
            this.groupBoxSearchLO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSearchLO.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearchLO.Controls.Add(this.labelselectfolder);
            this.groupBoxSearchLO.Controls.Add(this.actionon01);
            this.groupBoxSearchLO.Controls.Add(this.buttonfileselect);
            this.groupBoxSearchLO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchLO.ForeColor = System.Drawing.Color.White;
            this.groupBoxSearchLO.Location = new System.Drawing.Point(3, 118);
            this.groupBoxSearchLO.Name = "groupBoxSearchLO";
            this.groupBoxSearchLO.Size = new System.Drawing.Size(507, 127);
            this.groupBoxSearchLO.TabIndex = 20;
            this.groupBoxSearchLO.TabStop = false;
            this.groupBoxSearchLO.Text = "Search Path:";
            // 
            // labelselectfolder
            // 
            this.labelselectfolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelselectfolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelselectfolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelselectfolder.Location = new System.Drawing.Point(110, 34);
            this.labelselectfolder.Name = "labelselectfolder";
            this.labelselectfolder.Size = new System.Drawing.Size(386, 31);
            this.labelselectfolder.TabIndex = 33;
            this.labelselectfolder.Text = "Select Path:";
            this.labelselectfolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // actionon01
            // 
            this.actionon01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.actionon01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.actionon01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actionon01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionon01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.actionon01.Image = global::HW.Properties.Resources.icons8_search_16__1_;
            this.actionon01.Location = new System.Drawing.Point(426, 98);
            this.actionon01.Name = "actionon01";
            this.actionon01.Size = new System.Drawing.Size(75, 23);
            this.actionon01.TabIndex = 21;
            this.actionon01.Text = "Scan";
            this.actionon01.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.actionon01.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.actionon01.UseVisualStyleBackColor = false;
            this.actionon01.Click += new System.EventHandler(this.actionon01_Click);
            // 
            // buttonfileselect
            // 
            this.buttonfileselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonfileselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonfileselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfileselect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonfileselect.Image = ((System.Drawing.Image)(resources.GetObject("buttonfileselect.Image")));
            this.buttonfileselect.Location = new System.Drawing.Point(3, 34);
            this.buttonfileselect.Name = "buttonfileselect";
            this.buttonfileselect.Size = new System.Drawing.Size(101, 31);
            this.buttonfileselect.TabIndex = 18;
            this.buttonfileselect.Text = "Select path";
            this.buttonfileselect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonfileselect.UseVisualStyleBackColor = false;
            this.buttonfileselect.Click += new System.EventHandler(this.buttonfileselect_Click);
            // 
            // groupBoxDFound
            // 
            this.groupBoxDFound.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDFound.Controls.Add(this.panel1);
            this.groupBoxDFound.Controls.Add(this.listDfinder);
            this.groupBoxDFound.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxDFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDFound.ForeColor = System.Drawing.Color.White;
            this.groupBoxDFound.Location = new System.Drawing.Point(0, 251);
            this.groupBoxDFound.Name = "groupBoxDFound";
            this.groupBoxDFound.Size = new System.Drawing.Size(749, 349);
            this.groupBoxDFound.TabIndex = 21;
            this.groupBoxDFound.TabStop = false;
            this.groupBoxDFound.Text = "Duplicates found:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Controls.Add(this.radiodelete);
            this.panel1.Controls.Add(this.runButton);
            this.panel1.Controls.Add(this.radioarchive);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 28);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.ForeColor = System.Drawing.Color.Black;
            this.btnSelectAll.Location = new System.Drawing.Point(518, 2);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(122, 23);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Select All D Files";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // radiodelete
            // 
            this.radiodelete.AutoSize = true;
            this.radiodelete.ForeColor = System.Drawing.Color.Black;
            this.radiodelete.Location = new System.Drawing.Point(95, 3);
            this.radiodelete.Name = "radiodelete";
            this.radiodelete.Size = new System.Drawing.Size(68, 22);
            this.radiodelete.TabIndex = 5;
            this.radiodelete.TabStop = true;
            this.radiodelete.Text = "Delete";
            this.radiodelete.UseVisualStyleBackColor = true;
            this.radiodelete.CheckedChanged += new System.EventHandler(this.radiodelete_CheckedChanged);
            // 
            // runButton
            // 
            this.runButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.ForeColor = System.Drawing.Color.Black;
            this.runButton.Location = new System.Drawing.Point(646, 2);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(88, 23);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Execute";
            this.runButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // radioarchive
            // 
            this.radioarchive.AutoSize = true;
            this.radioarchive.ForeColor = System.Drawing.Color.Black;
            this.radioarchive.Location = new System.Drawing.Point(15, 3);
            this.radioarchive.Name = "radioarchive";
            this.radioarchive.Size = new System.Drawing.Size(74, 22);
            this.radioarchive.TabIndex = 4;
            this.radioarchive.TabStop = true;
            this.radioarchive.Text = "Archive";
            this.radioarchive.UseVisualStyleBackColor = true;
            // 
            // listDfinder
            // 
            this.listDfinder.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listDfinder.BackColor = System.Drawing.Color.White;
            this.listDfinder.CheckBoxes = true;
            this.listDfinder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colCheckSum,
            this.collastmodify,
            this.columnDfind});
            this.listDfinder.Dock = System.Windows.Forms.DockStyle.Top;
            this.listDfinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDfinder.FullRowSelect = true;
            this.listDfinder.GridLines = true;
            this.listDfinder.HideSelection = false;
            this.listDfinder.Location = new System.Drawing.Point(3, 20);
            this.listDfinder.Name = "listDfinder";
            this.listDfinder.Size = new System.Drawing.Size(743, 295);
            this.listDfinder.TabIndex = 0;
            this.listDfinder.UseCompatibleStateImageBehavior = false;
            this.listDfinder.View = System.Windows.Forms.View.Details;
            this.listDfinder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listDfinder_MouseClick);
            // 
            // colFileName
            // 
            this.colFileName.Text = "File Path";
            this.colFileName.Width = 272;
            // 
            // colCheckSum
            // 
            this.colCheckSum.Text = "File CheckSum";
            this.colCheckSum.Width = 190;
            // 
            // collastmodify
            // 
            this.collastmodify.Text = "Last Modify";
            this.collastmodify.Width = 166;
            // 
            // columnDfind
            // 
            this.columnDfind.Text = "Duplicate Find";
            this.columnDfind.Width = 111;
            // 
            // lvContextMenuStrip
            // 
            this.lvContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.quarantineToolStripMenuItem,
            this.toolStripSeparator1,
            this.aPIScanToolStripMenuItem});
            this.lvContextMenuStrip.Name = "contextMenuStrip1";
            this.lvContextMenuStrip.Size = new System.Drawing.Size(140, 148);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(136, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.archiveToolStripMenuItem.Text = "Archive";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.archiveToolStripMenuItem_Click);
            // 
            // quarantineToolStripMenuItem
            // 
            this.quarantineToolStripMenuItem.Name = "quarantineToolStripMenuItem";
            this.quarantineToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.quarantineToolStripMenuItem.Text = "Quarantine";
            this.quarantineToolStripMenuItem.Click += new System.EventHandler(this.quarantineToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // aPIScanToolStripMenuItem
            // 
            this.aPIScanToolStripMenuItem.Name = "aPIScanToolStripMenuItem";
            this.aPIScanToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aPIScanToolStripMenuItem.Text = "API Scan";
            this.aPIScanToolStripMenuItem.Click += new System.EventHandler(this.scanWithVirusTotalToolStripMenuItem_Click);
            // 
            // Back
            // 
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Image = global::HW.Properties.Resources.icons8_exit_30;
            this.Back.Location = new System.Drawing.Point(-1, -2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(27, 24);
            this.Back.TabIndex = 19;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Hard_disk_scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(749, 600);
            this.Controls.Add(this.groupBoxDFound);
            this.Controls.Add(this.groupBoxSearchLO);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.labelTitel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hard_disk_scan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hard_disk_scan";
            this.Load += new System.EventHandler(this.Hard_disk_scan_Load);
            this.groupBoxSearchLO.ResumeLayout(false);
            this.groupBoxDFound.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.lvContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Button buttonfileselect;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.GroupBox groupBoxSearchLO;
        private System.Windows.Forms.GroupBox groupBoxDFound;
        private System.Windows.Forms.ListView listDfinder;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader collastmodify;
        private System.Windows.Forms.ColumnHeader colCheckSum;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.ContextMenuStrip lvContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.Button actionon01;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.ColumnHeader columnDfind;
        private System.Windows.Forms.Label labelselectfolder;
        private System.Windows.Forms.RadioButton radiodelete;
        private System.Windows.Forms.RadioButton radioarchive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aPIScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quarantineToolStripMenuItem;
    }
}
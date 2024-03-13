namespace HW
{
    partial class Uploadfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uploadfile));
            this.labelTitel = new System.Windows.Forms.Label();
            this.groupBoxDFound = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radiodelete = new System.Windows.Forms.RadioButton();
            this.radioarchive = new System.Windows.Forms.RadioButton();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.listDfinder = new System.Windows.Forms.ListView();
            this.colFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.collastmodify = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDFinde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxSearchLO = new System.Windows.Forms.GroupBox();
            this.labelselectfolder = new System.Windows.Forms.Label();
            this.actionon = new System.Windows.Forms.Button();
            this.buttonselectfile = new System.Windows.Forms.Button();
            this.buttonseletfolder = new System.Windows.Forms.Button();
            this.labelselectfile = new System.Windows.Forms.Label();
            this.lvContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quarantineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aPIScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Back = new System.Windows.Forms.Button();
            this.groupBoxDFound.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxSearchLO.SuspendLayout();
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
            this.labelTitel.Location = new System.Drawing.Point(230, -1);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(275, 46);
            this.labelTitel.TabIndex = 17;
            this.labelTitel.Text = "Upload File Scan";
            this.labelTitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.groupBoxDFound.TabIndex = 32;
            this.groupBoxDFound.TabStop = false;
            this.groupBoxDFound.Text = "Duplicates found:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radiodelete);
            this.panel1.Controls.Add(this.radioarchive);
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Controls.Add(this.runButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 28);
            this.panel1.TabIndex = 1;
            // 
            // radiodelete
            // 
            this.radiodelete.AutoSize = true;
            this.radiodelete.ForeColor = System.Drawing.Color.Black;
            this.radiodelete.Location = new System.Drawing.Point(89, 3);
            this.radiodelete.Name = "radiodelete";
            this.radiodelete.Size = new System.Drawing.Size(68, 22);
            this.radiodelete.TabIndex = 11;
            this.radiodelete.TabStop = true;
            this.radiodelete.Text = "Delete";
            this.radiodelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radiodelete.UseVisualStyleBackColor = true;
            // 
            // radioarchive
            // 
            this.radioarchive.AutoSize = true;
            this.radioarchive.ForeColor = System.Drawing.Color.Black;
            this.radioarchive.Location = new System.Drawing.Point(9, 3);
            this.radioarchive.Name = "radioarchive";
            this.radioarchive.Size = new System.Drawing.Size(74, 22);
            this.radioarchive.TabIndex = 10;
            this.radioarchive.TabStop = true;
            this.radioarchive.Text = "Archive";
            this.radioarchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioarchive.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.ForeColor = System.Drawing.Color.Black;
            this.btnSelectAll.Location = new System.Drawing.Point(525, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(122, 23);
            this.btnSelectAll.TabIndex = 9;
            this.btnSelectAll.Text = "Select All D Files";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // runButton
            // 
            this.runButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.ForeColor = System.Drawing.Color.Black;
            this.runButton.Location = new System.Drawing.Point(653, 3);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(81, 23);
            this.runButton.TabIndex = 8;
            this.runButton.Text = "Execute";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // listDfinder
            // 
            this.listDfinder.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listDfinder.BackColor = System.Drawing.Color.White;
            this.listDfinder.CheckBoxes = true;
            this.listDfinder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFilePath,
            this.colCheckSum,
            this.collastmodify,
            this.colDFinde});
            this.listDfinder.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // colFilePath
            // 
            this.colFilePath.Text = "File Path";
            this.colFilePath.Width = 272;
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
            // colDFinde
            // 
            this.colDFinde.Text = "Duplicate Find";
            this.colDFinde.Width = 111;
            // 
            // groupBoxSearchLO
            // 
            this.groupBoxSearchLO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchLO.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearchLO.Controls.Add(this.labelselectfolder);
            this.groupBoxSearchLO.Controls.Add(this.actionon);
            this.groupBoxSearchLO.Controls.Add(this.buttonselectfile);
            this.groupBoxSearchLO.Controls.Add(this.buttonseletfolder);
            this.groupBoxSearchLO.Controls.Add(this.labelselectfile);
            this.groupBoxSearchLO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchLO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxSearchLO.Location = new System.Drawing.Point(3, 100);
            this.groupBoxSearchLO.Name = "groupBoxSearchLO";
            this.groupBoxSearchLO.Size = new System.Drawing.Size(505, 145);
            this.groupBoxSearchLO.TabIndex = 31;
            this.groupBoxSearchLO.TabStop = false;
            this.groupBoxSearchLO.Text = "Select Path:";
            // 
            // labelselectfolder
            // 
            this.labelselectfolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelselectfolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelselectfolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelselectfolder.Location = new System.Drawing.Point(111, 65);
            this.labelselectfolder.Name = "labelselectfolder";
            this.labelselectfolder.Size = new System.Drawing.Size(388, 31);
            this.labelselectfolder.TabIndex = 32;
            this.labelselectfolder.Text = "Selected Path:";
            this.labelselectfolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // actionon
            // 
            this.actionon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.actionon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actionon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.actionon.Image = global::HW.Properties.Resources.icons8_search_16__1_1;
            this.actionon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.actionon.Location = new System.Drawing.Point(423, 116);
            this.actionon.Name = "actionon";
            this.actionon.Size = new System.Drawing.Size(75, 23);
            this.actionon.TabIndex = 19;
            this.actionon.Text = "Scan";
            this.actionon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.actionon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.actionon.UseVisualStyleBackColor = false;
            this.actionon.Click += new System.EventHandler(this.actionon_Click);
            // 
            // buttonselectfile
            // 
            this.buttonselectfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonselectfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonselectfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonselectfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonselectfile.Image = global::HW.Properties.Resources.icons8_file_24__1_;
            this.buttonselectfile.Location = new System.Drawing.Point(3, 30);
            this.buttonselectfile.Name = "buttonselectfile";
            this.buttonselectfile.Size = new System.Drawing.Size(101, 31);
            this.buttonselectfile.TabIndex = 20;
            this.buttonselectfile.Text = "Upload File";
            this.buttonselectfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonselectfile.UseVisualStyleBackColor = false;
            this.buttonselectfile.Click += new System.EventHandler(this.buttonselectfile_Click);
            // 
            // buttonseletfolder
            // 
            this.buttonseletfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonseletfolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonseletfolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonseletfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonseletfolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonseletfolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonseletfolder.Image")));
            this.buttonseletfolder.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonseletfolder.Location = new System.Drawing.Point(4, 67);
            this.buttonseletfolder.Name = "buttonseletfolder";
            this.buttonseletfolder.Size = new System.Drawing.Size(101, 31);
            this.buttonseletfolder.TabIndex = 26;
            this.buttonseletfolder.Text = "Select Folder";
            this.buttonseletfolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonseletfolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonseletfolder.UseVisualStyleBackColor = false;
            this.buttonseletfolder.Click += new System.EventHandler(this.buttonseletfolder_Click);
            // 
            // labelselectfile
            // 
            this.labelselectfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelselectfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelselectfile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelselectfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelselectfile.Location = new System.Drawing.Point(110, 29);
            this.labelselectfile.Name = "labelselectfile";
            this.labelselectfile.Size = new System.Drawing.Size(388, 31);
            this.labelselectfile.TabIndex = 19;
            this.labelselectfile.Text = "Selected file:";
            this.labelselectfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvContextMenuStrip
            // 
            this.lvContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.quarantineToolStripMenuItem,
            this.toolStripSeparator2,
            this.aPIScanToolStripMenuItem});
            this.lvContextMenuStrip.Name = "contextMenuStrip1";
            this.lvContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(136, 6);
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
            this.Back.Image = global::HW.Properties.Resources.icons8_exit_302;
            this.Back.Location = new System.Drawing.Point(-1, -1);
            this.Back.Margin = new System.Windows.Forms.Padding(0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(27, 24);
            this.Back.TabIndex = 21;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Uploadfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BackgroundImage = global::HW.Properties.Resources.pngwing_com__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(749, 600);
            this.Controls.Add(this.groupBoxDFound);
            this.Controls.Add(this.groupBoxSearchLO);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.labelTitel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uploadfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uploadfile";
            this.Load += new System.EventHandler(this.Uploadfile_Load);
            this.groupBoxDFound.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxSearchLO.ResumeLayout(false);
            this.lvContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button buttonselectfile;
        private System.Windows.Forms.GroupBox groupBoxDFound;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radiodelete;
        private System.Windows.Forms.RadioButton radioarchive;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.ListView listDfinder;
        private System.Windows.Forms.ColumnHeader colFilePath;
        private System.Windows.Forms.ColumnHeader colCheckSum;
        private System.Windows.Forms.ColumnHeader collastmodify;
        private System.Windows.Forms.ColumnHeader colDFinde;
        private System.Windows.Forms.GroupBox groupBoxSearchLO;
        private System.Windows.Forms.Label labelselectfolder;
        private System.Windows.Forms.Button actionon;
        private System.Windows.Forms.Button buttonseletfolder;
        private System.Windows.Forms.Label labelselectfile;
        private System.Windows.Forms.ContextMenuStrip lvContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aPIScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quarantineToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
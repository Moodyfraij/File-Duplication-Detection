using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO.Compression;
using System.Linq;
using uploader;

namespace HW
{
    public partial class Hard_disk_scan : Form
    {
        public Hard_disk_scan()
        {
            InitializeComponent();
        }

        private void actionon01_Click(object sender, EventArgs e)
        {
            string selectedPath = labelselectfolder.Text;

            // Check if a valid path is selected
            if (!string.IsNullOrWhiteSpace(selectedPath) && Directory.Exists(selectedPath))
            {
                List<FileData> fileDataList = new List<FileData>();

                // Retrieve files and folders within the selected path
                ProcessDirectory(selectedPath, fileDataList);

                // Sort the file data list by checksum
                fileDataList.Sort((x, y) => x.Checksum.CompareTo(y.Checksum));

                // Mark duplicates
                MarkDuplicates(fileDataList);

                // Clear the ListView control
                listDfinder.Items.Clear();

                // Dictionary to store unique colors for each checksum
                Dictionary<string, Color> checksumColors = new Dictionary<string, Color>();

                // List of color options
                List<Color> colorOptions = new List<Color> {
            Color.Brown, Color.LightCoral, Color.LightGreen, Color.LightBlue,
            Color.Pink, Color.LightGray, Color.LightSteelBlue, Color.LightSeaGreen};

                int colorIndex = 0;

                foreach (FileData file in fileDataList)
                {
                    ListViewItem item = new ListViewItem(file.Path);
                    item.SubItems.Add(file.Checksum);
                    item.SubItems.Add(file.LastModified.ToString());

                    if (file.IsDuplicate)
                    {
                        // Assign a color to each unique checksum
                        if (!checksumColors.ContainsKey(file.Checksum))
                        {
                            checksumColors[file.Checksum] = colorOptions[colorIndex];
                            colorIndex = (colorIndex + 1) % colorOptions.Count;
                        }

                        item.SubItems.Add("Duplicate Find");
                        item.BackColor = checksumColors[file.Checksum];
                        listDfinder.Items.Add(item);
                        panel1.Visible = true;
                    }
                }

                // Check if duplicates were found
                if (colorIndex > 0)
                {
                    MessageBox.Show("Duplicates found.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No duplicates found.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Partition path.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
      
        private void ProcessDirectory(string path, List<FileData> fileDataList)
        {
            try
            {
                // Process files in the current directory
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    string checksum = CalculateChecksum(file);
                    FileInfo fileInfo = new FileInfo(file);
                    fileDataList.Add(new FileData(file, checksum, fileInfo.LastWriteTime, false));
                }

                // Recursively process subdirectories
                string[] directories = Directory.GetDirectories(path);
                foreach (string directory in directories)
                {
                    ProcessDirectory(directory, fileDataList);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during directory traversal
                Console.WriteLine("Error processing directory: " + ex.Message);
            }
        }

        private void MarkDuplicates(List<FileData> fileDataList)
        {
            // Dictionary to track duplicate checksums
            Dictionary<string, bool> checksumDict = new Dictionary<string, bool>();

            foreach (FileData fileData in fileDataList)
            {
                // Check if the checksum already exists in the dictionary
                if (checksumDict.ContainsKey(fileData.Checksum))
                {
                    // Mark both the current file and the duplicate file as duplicates
                    fileData.IsDuplicate = true;
                    FileData duplicateFileData = fileDataList.Find(fd => fd.Checksum == fileData.Checksum);
                    duplicateFileData.IsDuplicate = true;
                }
                else
                {
                    // Add the checksum to the dictionary
                    checksumDict[fileData.Checksum] = true;
                }
            }
        }

        private string CalculateChecksum(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLower();
                }
            }
        }

        // Custom class to hold file data
        public class FileData
        {
            public string Path { get; set; }
            public string Checksum { get; set; }
            public DateTime LastModified { get; set; }
            public bool IsDuplicate { get; set; }

            public FileData(string path, string checksum, DateTime lastModified, bool isDuplicate)
            {
                Path = path;
                Checksum = checksum;
                LastModified = lastModified;
                IsDuplicate = isDuplicate;
            }
        }
        ////
        private void buttonfileselect_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            System.Windows.Forms.ComboBox comboBox1 = new System.Windows.Forms.ComboBox();

            foreach (DriveInfo drive in allDrives)
            {
                if (drive.DriveType == DriveType.Fixed)
                {
                    comboBox1.Items.Add(drive.Name);
                }
            }

            if (comboBox1.Items.Count > 0)
            {
                bool isValidSelection = false;

                while (!isValidSelection)
                {
                    System.Windows.Forms.Form driveDialog = new System.Windows.Forms.Form();
                    driveDialog.Text = "Select Partition:";
                    driveDialog.Width = 250;
                    driveDialog.Height = 150;
                    driveDialog.Icon = SystemIcons.Application;
                    driveDialog.StartPosition = FormStartPosition.CenterScreen;

                    System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
                    label1.Text = "Select Partition:";
                    label1.Left = 10;
                    label1.Top = 10;
                    label1.Width = 150;
                    label1.Height = 20;

                    comboBox1.Left = 10;
                    comboBox1.Top = 30;
                    comboBox1.Width = 200;
                    comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                    System.Windows.Forms.Button okButton = new System.Windows.Forms.Button();
                    okButton.Text = "OK";
                    okButton.Left = 140;
                    okButton.Top = 60;
                    okButton.DialogResult = System.Windows.Forms.DialogResult.OK;

                    System.Windows.Forms.Button cancelButton = new System.Windows.Forms.Button();
                    cancelButton.Text = "Cancel";
                    cancelButton.Left = 60;
                    cancelButton.Top = 60;
                    cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;

                    driveDialog.Controls.Add(label1);
                    driveDialog.Controls.Add(comboBox1);
                    driveDialog.Controls.Add(okButton);
                    driveDialog.Controls.Add(cancelButton);

                    if (driveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (comboBox1.SelectedItem != null)
                        {
                            string selectedDrive = comboBox1.SelectedItem.ToString();
                            string rootDirectory = Path.GetPathRoot(selectedDrive);
                            labelselectfolder.Text = rootDirectory;
                            isValidSelection = true;
                        }
                        else
                        {
                            MessageBox.Show("No partition selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // User canceled the partition selection
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No Partition found.");
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (this.listDfinder.Items.Count > 0)
            {
                bool state;
                string label;

                if (this.btnSelectAll.Tag == null || this.btnSelectAll.Tag.Equals("Select All"))
                {
                    this.btnSelectAll.Tag = "Deselect All";
                    label = "Deselect All";
                    state = true;
                }
                else
                {
                    this.btnSelectAll.Tag = "Select All";
                    label = "Select All";
                    state = false;
                }

                Dictionary<string, List<ListViewItem>> checksumGroups = new Dictionary<string, List<ListViewItem>>();
                foreach (ListViewItem item in this.listDfinder.Items)
                {
                    string filePath = item.Text; 
                    string checksum = CalculateChecksum(filePath);

                    if (!checksumGroups.ContainsKey(checksum))
                    {
                        checksumGroups.Add(checksum, new List<ListViewItem>());
                    }

                    checksumGroups[checksum].Add(item);
                }

                foreach (var checksumGroup in checksumGroups)
                {
                    List<ListViewItem> duplicates = checksumGroup.Value;
                    bool isFirstUnselected = true;

                    foreach (ListViewItem item in duplicates)
                    {
                        item.Checked = isFirstUnselected ? false : state;
                        isFirstUnselected = false;
                    }
                }

                this.btnSelectAll.Text = label;
            }
            else
            {
                MessageBox.Show("There is nothing to select!", "Warning");
            }
        }

        private void listDfinder_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.listDfinder.FocusedItem != null && this.listDfinder.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    lvContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listDfinder.FocusedItem != null)
            {
                string fileName = listDfinder.FocusedItem.SubItems[0].Text;
                string filePath = listDfinder.FocusedItem.SubItems[1].Text;

                try
                {
                    using (Process openFile = new Process())
                    {
                        openFile.StartInfo.FileName = System.IO.Path.Combine(filePath, fileName);
                        openFile.Start();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // Handle the error as needed
                }
            }
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listViewItem = this.listDfinder.FocusedItem;
            string filePath = listViewItem.SubItems[1].Text;
            string fileName = listViewItem.SubItems[0].Text;
            string fullPath = System.IO.Path.Combine(filePath, fileName);
            Process openFileLocation = new Process();
            openFileLocation.StartInfo.FileName = "explorer.exe";
            openFileLocation.StartInfo.Arguments = $@"/select,""{fullPath}""";
            openFileLocation.Start();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listDfinder.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected file(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listDfinder.SelectedItems)
                    {
                        string filePath = item.Text;
                        File.Delete(filePath);
                    }

                    MessageBox.Show("File(s) deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetProgramState();
                }
            }
            else
            {
                MessageBox.Show("No file selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listDfinder.SelectedItems.Count > 0)
            {
                string selectedFolderPath = labelselectfolder.Text;

                if (Directory.Exists(selectedFolderPath))
                {
                    string archiveName = "archive"; // Base name for the archive file
                    string archiveExtension = ".zip"; // Archive file extension
                    string archivePath = GetUniqueArchivePath(selectedFolderPath, archiveName, archiveExtension);

                    using (ZipArchive archive = ZipFile.Open(archivePath, ZipArchiveMode.Create))
                    {
                        foreach (ListViewItem item in listDfinder.SelectedItems)
                        {
                            string filePath = item.Text;
                            string fileName = Path.GetFileName(filePath);
                            archive.CreateEntryFromFile(filePath, fileName);
                            // Delete the selected files after archiving
                            File.Delete(filePath);
                        }
                    }


                    MessageBox.Show("Files archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetProgramState();
                }
                else
                {
                    MessageBox.Show("Please select a valid folder.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No file selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void quarantineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listDfinder.SelectedItems.Count >= 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to quarantine the selected file(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listDfinder.SelectedItems)
                    {
                        string filePath = item.Text;
                        string newFilePath = Path.ChangeExtension(filePath, ".rma");
                        File.Move(filePath, newFilePath);
                    }

                    MessageBox.Show("File(s) quarantined successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetProgramState();
                }
            }
            else
            {
                MessageBox.Show("No file selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //// API right click 
        private void scanWithVirusTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listDfinder.CheckedItems.Count < 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to upload the selected files to be scanned by VirusTotal?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var settings = Settings.LoadSettings();
                    var dragForm = Application.OpenForms.OfType<drag>().FirstOrDefault();
                    if (dragForm == null)
                    {
                        dragForm = new drag();
                        dragForm.Show();
                        dragForm.Close();

                        foreach (ListViewItem item in listDfinder.SelectedItems)
                        {
                            var uploadForm = new UploadForm(dragForm, settings, true, item.Text);
                            uploadForm.Show();
                            dragForm.Close();
                        }

                        ResetProgramState();
                    }


                }
            }
            else if (listDfinder.CheckedItems.Count >= 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to upload the selected files to be scanned by VirusTotal?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var settings = Settings.LoadSettings();
                    var dragForm = Application.OpenForms.OfType<drag>().FirstOrDefault();
                    if (dragForm == null)
                    {
                        dragForm = new drag();
                        dragForm.Show();
                        dragForm.Close();

                        foreach (ListViewItem item in listDfinder.CheckedItems)
                        {
                            var uploadForm = new UploadForm(dragForm, settings, true, item.Text);
                            uploadForm.Show();
                            dragForm.Close();
                        }

                        ResetProgramState();
                    }


                }
            }
            else if (listDfinder.CheckedItems.Count == 0)
            {
                MessageBox.Show("No file selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (radioarchive.Checked)
            {
                if (this.listDfinder.CheckedItems.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Archive the selected file(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Archive the selected files
                    string archiveName = "archive"; // Base name for the archive file
                    string archiveExtension = ".zip"; // Archive file extension
                    List<string> selectedFiles = GetSelectedFiles();

                    string scanFolderPath = labelselectfolder.Text; // Get the folder path from the label control
                    string archivePath = GetUniqueArchivePath(scanFolderPath, archiveName, archiveExtension);

                    using (ZipArchive archive = ZipFile.Open(archivePath, ZipArchiveMode.Create))
                    {
                        foreach (string file in selectedFiles)
                        {
                            string fileName = Path.GetFileName(file);
                            archive.CreateEntryFromFile(file, fileName);
                        }
                    }

                    // Delete the selected files after archiving
                    foreach (string file in selectedFiles)
                    {
                        File.Delete(file);
                    }
                    panel1.Visible = false;

                }
                else if (this.listDfinder.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select files. ", "Warning");

                }
            }

            else if (radiodelete.Checked)
            {
                if (this.listDfinder.CheckedItems.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected file(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Delete the selected files
                        List<string> selectedFiles = GetSelectedFiles();

                        foreach (string file in selectedFiles)
                        {
                            File.Delete(file);
                        }
                    }
                    panel1.Visible = false;
                }
                else if (this.listDfinder.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select files. ", "Warning");

                }
            }

            else
            {
                MessageBox.Show("Please select an action.", "Warning");
                return;
            }
            // Reset program state
            ResetProgramState();
        }

        private List<string> GetSelectedFiles()
        {
            List<string> selectedFiles = new List<string>();

            foreach (ListViewItem item in listDfinder.CheckedItems)
            {
                string filePath = item.Text; // Assuming the file path is stored as the ListViewItem's Text property
                selectedFiles.Add(filePath);
            }

            return selectedFiles;
        }

        private string GetUniqueArchivePath(string scanFolderPath, string baseName, string extension)
        {
            string uniquePath = Path.Combine(scanFolderPath, baseName + DateTime.Now.ToString("yyyyMMddHHmmss") + extension);
            return uniquePath;
        }

        private void ResetProgramState()
        {
            // Reset checkboxes
            radioarchive.Checked = false;
            radiodelete.Checked = false;

            // Clear ListView control
            listDfinder.Items.Clear();

            // Reset Select All button
            btnSelectAll.Tag = "Select All";
            btnSelectAll.Text = "Select All";
        }

        private void Hard_disk_scan_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radiodelete_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

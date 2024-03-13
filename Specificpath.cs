using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using uploader;

namespace HW.Resources
{
    public partial class Specificpath : Form
    {

        public Specificpath()
        {
            InitializeComponent();
        }
        // for the duplicatefile using checksum
        private void actionon_Click(object sender, EventArgs e)
        {
            ResetProgramState();
            string folderPath = labelselectfolder.Text;

            if (!string.IsNullOrWhiteSpace(folderPath) && Directory.Exists(folderPath))
            {
                List<DuplicateFile> duplicateFiles = FindDuplicateFiles(folderPath);
                listDfinder.Items.Clear();

                Dictionary<string, Color> checksumColors = new Dictionary<string, Color>(); // To store unique colors for each checksum
                List<Color> colorOptions = new List<Color> { Color.LightPink, Color.LightCoral, Color.LightGreen, Color.LightBlue, Color.Pink, Color.LightGray, Color.LightSteelBlue, Color.LightSeaGreen }; // Add more colors if needed

                int colorIndex = 0;

                foreach (DuplicateFile file in duplicateFiles)
                {
                    ListViewItem item = new ListViewItem(file.FilePath);
                    item.SubItems.Add(file.Checksum);
                    item.SubItems.Add(file.LastModified.ToString());

                    if (file.NumDuplicates > 0)
                    {
                        if (!checksumColors.ContainsKey(file.Checksum))
                        {
                            checksumColors[file.Checksum] = colorOptions[colorIndex];
                            colorIndex = (colorIndex + 1) % colorOptions.Count;
                        }

                        item.SubItems.Add("Duplicate found");
                        item.BackColor = checksumColors[file.Checksum];
                        listDfinder.Items.Add(item);
                        panel1.Visible = true;
                    }
                }

                if (listDfinder.Items.Count == 0)
                {
                    MessageBox.Show("No Duplicate File Found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show("duplicates found.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid folder path.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        static List<DuplicateFile> FindDuplicateFiles(string folderPath)
        {
            Dictionary<string, List<string>> fileChecksums = new Dictionary<string, List<string>>();
            List<DuplicateFile> duplicateFiles = new List<DuplicateFile>();

            string[] files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                string checksum = CalculateChecksum(file);
                DateTime lastModified = File.GetLastWriteTime(file);

                if (fileChecksums.ContainsKey(checksum))
                {
                    // Found a duplicate file
                    fileChecksums[checksum].Add(file);
                }
                else
                {
                    fileChecksums.Add(checksum, new List<string> { file });
                }
                duplicateFiles.Add(new DuplicateFile { FilePath = file, Checksum = checksum, LastModified = lastModified });

            }

            foreach (var entry in fileChecksums)
            {
                if (entry.Value.Count > 1)
                {
                    string checksum = entry.Key;
                    int numDuplicates = entry.Value.Count;

                    foreach (string file in entry.Value)
                    {
                        foreach (DuplicateFile duplicateFile in duplicateFiles)
                        {
                            if (duplicateFile.FilePath == file)
                            {
                                duplicateFile.NumDuplicates = numDuplicates;
                                break;
                            }
                        }
                    }
                }
            }
            // Sort duplicateFiles by checksum
            duplicateFiles.Sort((x, y) => x.Checksum.CompareTo(y.Checksum));
            return duplicateFiles;
        }
        static string CalculateChecksum(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }       

        class DuplicateFile
        {
            public string FilePath { get; set; }
            public string Checksum { get; set; }
            public int NumDuplicates { get; set; }
            public DateTime LastModified { get; set; }
        }

        private void buttonseletfolder_Click(object sender, EventArgs e)
        {
            bool isValidSelection = false;

            while (!isValidSelection)
            {
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string selectedPath = folderDialog.SelectedPath;

                        // Check if the selected path is a folder
                        if (Directory.Exists(selectedPath))
                        {
                            // Check if the selected path is a root folder or a partition
                            string rootPath = Path.GetPathRoot(selectedPath);
                            if (rootPath == selectedPath)
                            {
                                MessageBox.Show("Please select a folder, not a partition.", "Invalid Selection",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                labelselectfolder.Text = selectedPath;
                                isValidSelection = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please specify a valid folder.", "Invalid Selection",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        // User canceled the folder selection
                        break;
                    }
                }
            }
        }
        private void btnSelectAll_Click_1(object sender, EventArgs e)
        {
            if (this.listDfinder.Items.Count >= 1)
            {
                bool state;
                string label;

                if (this.btnSelectAll.Tag == null || this.btnSelectAll.Tag.Equals("Select All D Files"))
                {
                    this.btnSelectAll.Tag = "DeSelect All D Files";
                    label = "DeSelect All D Files";
                    state = true;
                }
                else
                {
                    this.btnSelectAll.Tag = "Select All D Files";
                    label = "Select All D Files";
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

        //for the run button archive and delete options 
        private List<string> GetSelectedFiles()
        {
            List<string> selectedFiles = new List<string>();

            foreach (ListViewItem item in listDfinder.CheckedItems)
            {
                string filePath = item.Text;
                selectedFiles.Add(filePath);
            }

            return selectedFiles;
        }
        private void runButton_Click_1(object sender, EventArgs e)
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

        //right click menu
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
            if (listDfinder.SelectedItems.Count >= 1)
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
        private string GetUniqueArchivePath(string scanFolderPath, string baseName, string extension)
        {
            string uniquePath = Path.Combine(scanFolderPath, baseName + DateTime.Now.ToString("yyyyMMddHHmmss") + extension);
            return uniquePath;
        }

        private void quarantineToolStripMenuItem1_Click(object sender, EventArgs e)
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

        ////////////////////////////////////////////////////////////////////////////
        //test of API right click 
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

        ////////////////////////////////////////////////////////////////////////////
        private void groupBoxDFound_Enter(object sender, EventArgs e)
        {

        }

        //ResetProgramState for reset the results
        private void ResetProgramState()
        {
            // Reset checkboxes
            radioarchive.Checked = false;
            radiodelete.Checked = false;
            // Clear ListView control
            listDfinder.Items.Clear();

            // Reset Select All button
            btnSelectAll.Tag = "Select All D Files";
            btnSelectAll.Text = "Select All D Files";
        }

        private void Specificpath_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
     
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

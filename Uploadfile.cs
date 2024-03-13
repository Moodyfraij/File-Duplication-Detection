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
namespace HW
{
    public partial class Uploadfile : Form
    {
        private string selectedFilePath;
        private string selectedFileChecksum;
        private string selectedFolderPath;

        public Uploadfile()
        {
            InitializeComponent();
        }
        private void actionon_Click(object sender, EventArgs e)
        {
            ResetProgramState();

            if (!string.IsNullOrEmpty(selectedFilePath) && !string.IsNullOrEmpty(selectedFolderPath))
            {
                try
                {
                    // Calculate checksum of the selected file
                    string selectedFileChecksum = CalculateChecksum(selectedFilePath);

                    // Get files in the selected folder or partition
                    List<FileData> fileDataList = new List<FileData>();
                    ProcessDirectory(selectedFolderPath, fileDataList);

                    // Find files with matching checksum
                    List<FileData> matchingFiles = fileDataList.Where(file => file.Checksum.Equals(selectedFileChecksum)).ToList();

                    // Store unique colors for each checksum
                    Dictionary<string, Color> checksumColors = new Dictionary<string, Color>();

                    // Add more colors if needed
                    List<Color> colorOptions = new List<Color> { Color.LightPink, Color.LightCoral, Color.LightGreen, Color.LightBlue, Color.Pink, Color.LightGray, Color.LightSteelBlue, Color.LightSeaGreen };

                    int colorIndex = 0;

                    // Display the matching files
                    listDfinder.Items.Clear();
                    foreach (FileData file in matchingFiles)
                    {
                        ListViewItem item = new ListViewItem(file.Path);
                        item.SubItems.Add(file.Checksum);
                        item.SubItems.Add(file.LastModified.ToString());

                        // Assign a color to the file based on its checksum
                        if (checksumColors.ContainsKey(file.Checksum))
                        {
                            item.BackColor = checksumColors[file.Checksum];
                        }
                        else
                        {
                            checksumColors[file.Checksum] = colorOptions[colorIndex];
                            item.BackColor = colorOptions[colorIndex];
                            colorIndex = (colorIndex + 1) % colorOptions.Count;
                        }

                        item.SubItems.Add("Duplicate Found");
                        listDfinder.Items.Add(item);
                        panel1.Visible = true;

                    }

                    // Check if any matching files were found
                    if (listDfinder.Items.Count > 0)
                    {
                        MessageBox.Show("Duplicate files found.", "Note", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("No Duplicate files found.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        panel1.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error comparing checksum with files: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select both a file and a folder or partition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        static string CalculateChecksum(string filePath)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Error calculating checksum: " + ex.Message);
            }
        }
        public class FileData
        {
            public string Path { get; set; }
            public string Checksum { get; set; }
            public DateTime LastModified { get; set; }
            public bool IsDuplicate { get; set; }
            public Color Color { get; set; } // New property to store the color

            public FileData(string path, string checksum, DateTime lastModified, bool isDuplicate)
            {
                Path = path;
                Checksum = checksum;
                LastModified = lastModified;
                IsDuplicate = isDuplicate;
            }
        }

        //SELECT FILE AND FOLDER
        private void buttonselectfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog1.FileName;
                selectedFileChecksum = CalculateChecksum(selectedFilePath);
                labelselectfile.Text = selectedFilePath;
            }
        }

        private void buttonseletfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = " ";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFolderPath = folderBrowserDialog.SelectedPath;
                labelselectfolder.Text = selectedFolderPath;

            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (listDfinder.Items.Count > 0)
            {
                bool state;
                string label;

                if (btnSelectAll.Tag == null || btnSelectAll.Tag.Equals("Select All D Files"))
                {
                    btnSelectAll.Tag = "DeSelect All D Files";
                    label = "DeSelect All D Files";
                    state = true;
                }
                else
                {
                    btnSelectAll.Tag = "Select All D Files";
                    label = "Select All D Files";
                    state = false;
                }

                foreach (ListViewItem item in listDfinder.Items)
                {
                    item.Checked = state;
                }

                btnSelectAll.Text = label;
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

        //merge test
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

        ////////  right click options 
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

        private string GetUniqueArchivePath(string scanFolderPath, string baseName, string extension)
        {
            string uniquePath = Path.Combine(scanFolderPath, baseName + DateTime.Now.ToString("yyyyMMddHHmmss") + extension);
            return uniquePath;
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

        private void Uploadfile_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DarkUI.Forms;
namespace uploader
{
    public partial class drag : DarkForm
    {
        private SettingsForm _settingsForm = new SettingsForm();

        public drag()
        {
            InitializeComponent();

        }
        private void drag_Load(object sender, EventArgs e)
        {
            // Set working directory to exe location because of language files
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //LocalizationHelper.Export();

            LocalizationHelper.Update();

            moreLabel.Text = LocalizationHelper.Base.drag_More;
        }

        private void moreLabel_Click(object sender, EventArgs e)
        {
            if (_settingsForm.IsDisposed)
            {
                _settingsForm = new SettingsForm();
            }
            _settingsForm.Show();
        }

        private void drag_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void drag_DragDrop(object sender, DragEventArgs e)
        {
            var settings = Settings.LoadSettings();

            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                var uploadForm = new UploadForm(this, settings, true, file);
                uploadForm.Show();
                this.Hide();
            }
        }

        private void drag_Shown(object sender, EventArgs e)
        {
            var settings = Settings.LoadSettings();
            var args = Environment.GetCommandLineArgs();

            if (args.Length == 2)
            {
                var file = args[1]; // Second argument because .NET puts program filename to the first
                var uploadForm = new UploadForm(this, settings, false, file);
                uploadForm.Show();
                this.Hide();
            }
        }
        private void dragLabel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the initial directory and filter for the file dialog
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "All Files (*.*)|*.*";

                // Show the file dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var settings = Settings.LoadSettings();

                    // Get the selected file path
                    string selectedFile = openFileDialog.FileName;

                    // Create a new instance of the UploadForm and show it
                    var uploadForm = new UploadForm(this, settings, true, selectedFile);
                    uploadForm.Show();
                    this.Hide();
                }
            }
        }
        ////
       
    }
}

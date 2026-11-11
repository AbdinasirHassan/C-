using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        private readonly TextBox outputBox = new TextBox();
        private readonly Label selectedFileLabel = new Label();
        private string selectedFilePath;

        public Form1()
        {
            InitializeComponent();
            BuildInterface();
        }

        private void BuildInterface()
        {
            Text = "File Handling Assignment";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(820, 570);
            MinimumSize = new Size(760, 520);
            Font = new Font("Segoe UI", 10F);

            var title = new Label
            {
                Text = "FILE HANDLING ASSIGNMENT",
                Font = new Font("Segoe UI", 19F, FontStyle.Bold),
                ForeColor = Color.FromArgb(28, 68, 112),
                AutoSize = true,
                Location = new Point(24, 18)
            };
            var subtitle = new Label
            {
                Text = "Create, read with different methods, and delete a text file.",
                AutoSize = true,
                ForeColor = Color.DimGray,
                Location = new Point(27, 58)
            };
            var readAllButton = MakeButton("ReadAllText", 25, 105, 145, ReadAllText_Click);
            var readLinesButton = MakeButton("ReadAllLines", 180, 105, 145, ReadAllLines_Click);
            var streamReaderButton = MakeButton("StreamReader", 335, 105, 145, StreamReader_Click);
            var createButton = MakeButton("Create / Write File", 490, 105, 145, CreateFile_Click);
            var deleteButton = MakeButton("Delete File", 645, 105, 145, DeleteFile_Click);

            selectedFileLabel.Text = "No file selected. Choose a reading or delete action to select a file.";
            selectedFileLabel.Location = new Point(27, 155);
            selectedFileLabel.Size = new Size(760, 28);
            selectedFileLabel.ForeColor = Color.FromArgb(75, 75, 75);

            outputBox.Location = new Point(27, 190);
            outputBox.Size = new Size(760, 345);
            outputBox.Multiline = true;
            outputBox.ScrollBars = ScrollBars.Both;
            outputBox.WordWrap = false;
            outputBox.ReadOnly = true;
            outputBox.Font = new Font("Consolas", 10F);
            outputBox.BackColor = Color.White;

            Controls.AddRange(new Control[] { title, subtitle, readAllButton, readLinesButton,
                streamReaderButton, createButton, deleteButton, selectedFileLabel, outputBox });
        }

        private Button MakeButton(string text, int x, int y, int width, EventHandler handler)
        {
            var button = new Button
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(width, 38),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(37, 99, 150),
                ForeColor = Color.White,
                UseVisualStyleBackColor = false
            };
            button.Click += handler;
            return button;
        }

        // StreamWriter creates the file if it does not exist, then writes the user's text.
        private void CreateFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Create a text file";
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.FileName = "assignment-notes.txt";
                dialog.OverwritePrompt = true;
                if (dialog.ShowDialog() != DialogResult.OK) return;

                string text = outputBox.Text;
                if (string.IsNullOrWhiteSpace(text))
                    text = "File Handling Assignment\r\nCreated with StreamWriter.\r\n";

                try
                {
                    using (var writer = new StreamWriter(dialog.FileName, false, Encoding.UTF8))
                    {
                        writer.Write(text);
                    }
                    selectedFilePath = dialog.FileName;
                    selectedFileLabel.Text = "Current file: " + selectedFilePath;
                    outputBox.Text = "File created and written successfully.\r\n" + selectedFilePath;
                }
                catch (IOException ex) { ShowFileError(ex); }
                catch (UnauthorizedAccessException ex) { ShowFileError(ex); }
            }
        }

        // File.ReadAllText reads the complete file into one string.
        private void ReadAllText_Click(object sender, EventArgs e)
        {
            string path = ChooseFile();
            if (path == null) return;
            try
            {
                outputBox.Text = "METHOD: File.ReadAllText\r\n\r\n" + File.ReadAllText(path);
            }
            catch (IOException ex) { ShowFileError(ex); }
            catch (UnauthorizedAccessException ex) { ShowFileError(ex); }
        }

        // File.ReadAllLines returns a string array, with one array item for each line.
        private void ReadAllLines_Click(object sender, EventArgs e)
        {
            string path = ChooseFile();
            if (path == null) return;
            try
            {
                string[] lines = File.ReadAllLines(path);
                var result = new StringBuilder("METHOD: File.ReadAllLines\r\n\r\n");
                for (int i = 0; i < lines.Length; i++)
                    result.AppendLine((i + 1) + ": " + lines[i]);
                outputBox.Text = result.ToString();
            }
            catch (IOException ex) { ShowFileError(ex); }
            catch (UnauthorizedAccessException ex) { ShowFileError(ex); }
        }

        // StreamReader reads line by line and is useful for processing larger files.
        private void StreamReader_Click(object sender, EventArgs e)
        {
            string path = ChooseFile();
            if (path == null) return;
            try
            {
                var result = new StringBuilder("METHOD: StreamReader.ReadLine\r\n\r\n");
                using (var reader = new StreamReader(path))
                {
                    string line;
                    int lineNumber = 1;
                    while ((line = reader.ReadLine()) != null)
                    {
                        result.AppendLine(lineNumber + ": " + line);
                        lineNumber++;
                    }
                }
                outputBox.Text = result.ToString();
            }
            catch (IOException ex) { ShowFileError(ex); }
            catch (UnauthorizedAccessException ex) { ShowFileError(ex); }
        }

        // File.Delete removes only the file the user selected after confirmation.
        private void DeleteFile_Click(object sender, EventArgs e)
        {
            string path = ChooseFile();
            if (path == null) return;

            DialogResult answer = MessageBox.Show(
                "Permanently delete this file?\r\n" + path,
                "Confirm file deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer != DialogResult.Yes) return;

            try
            {
                File.Delete(path);
                if (string.Equals(path, selectedFilePath, StringComparison.OrdinalIgnoreCase))
                {
                    selectedFilePath = null;
                    selectedFileLabel.Text = "No file selected.";
                }
                outputBox.Text = "File deleted successfully.\r\n" + path;
            }
            catch (IOException ex) { ShowFileError(ex); }
            catch (UnauthorizedAccessException ex) { ShowFileError(ex); }
        }

        private string ChooseFile()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Select a file";
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.CheckFileExists = true;
                if (dialog.ShowDialog() != DialogResult.OK) return null;

                selectedFilePath = dialog.FileName;
                selectedFileLabel.Text = "Current file: " + selectedFilePath;
                return selectedFilePath;
            }
        }

        private void ShowFileError(Exception ex)
        {
            MessageBox.Show("The file operation could not be completed.\r\n" + ex.Message,
                "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

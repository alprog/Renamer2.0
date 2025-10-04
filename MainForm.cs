using System.Diagnostics;
using System.Drawing;

namespace Renamer2
{
    public partial class MainForm : Form
    {
        public List<FileRecord> Records = new List<FileRecord>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void SelectInputButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                InputPathCombo.Text = dialog.SelectedPath;
                Refresh();
            }
        }

        private bool IsInputFolderValid => Directory.Exists(InputPathCombo.Text);

        private int Parse(string text)
        {
            int result;
            if (Int32.TryParse(text, out result))
            {
                return result;
            }

            return -1;
        }

        private int UseModCount => Parse(UseModTextBox.Text);
        private int UseStartIndex => Parse(UseStartTextBox.Text);
        private int RenameStartIndex => Parse(RenameStartTextBox.Text);

        private void InputPathCombo_TextChanged(object sender, EventArgs e)
        {
            InputPathCombo.BackColor = IsInputFolderValid ? Color.White : Color.Red;
            RefreshTargetFolderTextBox();
            Refresh(true);
        }

        private void RefreshTargetFolderTextBox()
        {
            TargetFolderTextBox.Text = CalcTargetFolderPath();
            TargetFolderTextBox.SelectionStart = TargetFolderTextBox.Text.Length;
        }

        private void TargetFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            var path = TargetFolderTextBox.Text;
            var parentPath = Path.Combine(path, "..");
            bool isValid = !Directory.Exists(path) && Directory.Exists(parentPath);
            TargetFolderTextBox.BackColor = isValid ? Color.White : Color.Red;
            Refresh();
        }

        private void InputPatternText_TextChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void LeftModText_TextChanged(object sender, EventArgs e)
        {
            UseModTextBox.BackColor = UseModCount > 0 ? Color.White : Color.Red;
            Refresh();
        }

        private void UseStartText_TextChanged(object sender, EventArgs e)
        {
            UseStartTextBox.BackColor = UseStartIndex >= 0 ? Color.White : Color.Red;
            Refresh();
        }

        private void UseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void RenameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void RenameStartTextBox_TextChanged(object sender, EventArgs e)
        {
            RenameStartTextBox.BackColor = RenameStartIndex >= 0 ? Color.White : Color.Red;
            Refresh();
        }

        private void RenamePatternTextBox_TextChanged(object sender, EventArgs e)
        {
            RenamePatternTextBox.BackColor = RenamePatternTextBox.Text.Contains('#') ? Color.White : Color.Red;
            Refresh();
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var index = ListView.SelectedIndices[0];
                var record = Records[index];
                var bitmap = Bitmap.FromFile(record.OriginFileInfo.FullName);

                PreviewPictureBox.Image = bitmap;
            }
            catch
            {
                PreviewPictureBox.Image = null;
            }
        }

        private string CalcTargetFolderPath()
        {
            int index = 1;
            while (true)
            {
                var path = Path.Combine(InputPathCombo.Text, "RenameExport" + index);
                if (Directory.Exists(path))
                {
                    index++;
                }
                else
                {
                    return path;
                }
            }
        }

        private void Refresh(bool refreshPattern = false)
        {
            PreviewPictureBox.Image = null;
            RebuildRecordList();
            if (refreshPattern)
            {
                RefreshRenamePatternTextBox();
            }
            ApplyConversion();
            RefreshListView();
            RefreshButtonState();
        }

        private void RebuildRecordList()
        {
            Records.Clear();

            if (IsInputFolderValid)
            {
                var directoryInfo = new DirectoryInfo(InputPathCombo.Text);
                var files = directoryInfo.GetFiles(InputPatternTextBox.Text);
                foreach (var fileInfo in files)
                {
                    Records.Add(new FileRecord(fileInfo));
                }
            }
        }

        private void RefreshRenamePatternTextBox()
        {
            if (Records.Count > 0)
            {
                var patternText = Path.GetFileNameWithoutExtension(Records[0].OriginFileInfo.Name);

                var array = patternText.ToCharArray();
                bool started = false;
                for (int i = patternText.Length - 1; i >= 0; i--)
                {
                    if (Char.IsDigit(array[i]))
                    {
                        started = true;
                        array[i] = '#';
                    }
                    else if (started)
                    {
                        break;
                    }
                }

                RenamePatternTextBox.Text = new string(array);
            }
        }

        private bool ReplacePattern(ref string format)
        {
            for (int i = 8; i >= 1; i--)
            {
                var pattern = new String('#', i);
                if (format.Contains(pattern))
                {
                    format = format.Replace(pattern, "{0:D" + i + "}");
                    return true;
                }
            }
            return false;
        }

        private void ApplyConversion()
        {
            if (UseModCount > 0 && UseStartIndex >= 0)
            {
                for (int i = 0; i < Records.Count; i++)
                {
                    var record = Records[i];
                    record.Use = i >= UseStartIndex && (i - UseStartIndex) % UseModCount == 0;
                }
            }

            if (RenameCheckBox.Checked)
            {
                var renamePattern = RenamePatternTextBox.Text;
                ReplacePattern(ref renamePattern);

                var index = RenameStartIndex;
                foreach (var record in Records)
                {
                    if (record.Use)
                    {
                        record.Rename(renamePattern, index++);
                    }
                }
            }
        }

        private void RefreshListView()
        {
            ListView.Items.Clear();
            for (int i = 0; i < Records.Count; i++)
            {
                var record = Records[i];
                var item = new ListViewItem(i.ToString());

                item.SubItems.Add(record.OriginFileInfo.Name);

                item.ForeColor = record.Use ? Color.Black : Color.Red;
                if (record.Use)
                {
                    item.SubItems.Add(record.NewFileName);
                }
                ListView.Items.Add(item);
            }
        }

        private void RefreshButtonState()
        {
            PerformButton.Enabled = false;

            if (Records.Count == 0)
            {
                return;
            }

            foreach (var control in this.Controls)
            {
                if (control is TextBox textbox)
                {
                    if (textbox.BackColor == Color.Red)
                    {
                        return;
                    }
                }
            }

            foreach (var record in this.Records)
            {
                if (record.Use)
                {
                    PerformButton.Enabled = true;
                    return;
                }
            }
        }

        private void PerformButton_Click(object sender, EventArgs e)
        {
            var targetDirectory = Directory.CreateDirectory(TargetFolderTextBox.Text);

            foreach (var record in Records)
            {
                if (record.Use)
                {
                    var destFilePath = Path.Combine(targetDirectory.FullName, record.NewFileName);
                    record.OriginFileInfo.CopyTo(destFilePath);
                }
            }

            //var result = MessageBox.Show("Готово! Открыть папку с результатом?", "Renamer", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    Process.Start("explorer.exe", targetDirectory.FullName);
            //}

            RefreshTargetFolderTextBox();
        }
    }
}

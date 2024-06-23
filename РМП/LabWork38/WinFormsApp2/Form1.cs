using System.Drawing.Printing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Task1 : System.Windows.Forms.Form
    {
        private int pageSize = 5;
        private List<FileInfo> allFiles;
        public Task1()
        {
            InitializeComponent();
            allFiles = GetFilesFromDirectory();
            numericUpDown.Maximum = allFiles.Count;
            LoadFiles();
        } 
        private void UpdateInfoLabel()
        {
            label.Text = $"Показано {dataGridView.RowCount} из {allFiles.Count} записей";
        }
        private List<FileInfo> GetFilesFromDirectory()
        {
            string directoryPath = Environment.CurrentDirectory;
            return new DirectoryInfo(directoryPath).GetFiles().OrderBy(f => f.FullName).ToList();
        }

        private void LoadFiles()
        {
            int endIndex = Math.Min(pageSize, allFiles.Count);
            List<FileInfo> displayedFiles = allFiles.GetRange(0, endIndex);

            dataGridView.DataSource = displayedFiles;
            UpdateInfoLabel();
            nextButton.Enabled = Math.Min(pageSize, allFiles.Count) < allFiles.Count;
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            pageSize += 3;
            LoadFiles();
        }
        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            pageSize = Convert.ToInt32(numericUpDown.Value);
            LoadFiles();
        }
    }
}

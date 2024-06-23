using System.Drawing.Printing;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace Task3
{
    public partial class Task2 : System.Windows.Forms.Form
    {
        private int currentPage = 1;
        private int pageSize = 5;
        private List<FileInfo> allFiles;
        private int totalPages;
        public Task2()
        {
            InitializeComponent();
            allFiles = GetFilesFromDirectory();
            pageTextBox.Text = currentPage.ToString();
            totalPages = (int)Math.Ceiling((double)allFiles.Count / pageSize);
            LoadFiles();
        }
        private void UpdateInfoLabel()
        {
            label.Text = $"Показано {dataGridView.RowCount} из {allFiles.Count} записей";
        }
        private List<FileInfo> GetFilesFromDirectory()
        {
            string directoryPath = Environment.CurrentDirectory;
            return new DirectoryInfo(directoryPath).GetFiles().OrderBy(file => file.FullName).ToList();
        }

        private void LoadFiles()
        {
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = startIndex + pageSize;
            List<FileInfo> displayedFiles = allFiles.GetRange(startIndex, Math.Min(endIndex, allFiles.Count) - startIndex);

            dataGridView.DataSource = displayedFiles;
            UpdateInfoLabel();

            firstButton.Enabled = currentPage > 1;
            previousButton.Enabled = currentPage > 1;
            nextButton.Enabled = currentPage < totalPages;
            lastButton.Enabled = currentPage < totalPages;
            pageTextBox.Text = currentPage.ToString();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadFiles();
        }
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadFiles();
        }
        private void FirstButton_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadFiles();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadFiles();
        }
        private void PageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(pageTextBox.Text, out int targetPage) && targetPage > 0)
            {
                int totalPages = Convert.ToInt32(Math.Ceiling((double)allFiles.Count / pageSize));
                currentPage = Math.Min(targetPage, totalPages);
                LoadFiles();
            }
            else if (targetPage <= 0)
            {
                currentPage = 1;
                LoadFiles();
            }
        }
    }
}

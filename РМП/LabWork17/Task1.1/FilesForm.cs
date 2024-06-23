namespace Task1._1
{
    public partial class FilesForm : Form
    {
        FileInfo[] GetFiles(string directoryName)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryName);
            return directory.GetFiles("*", SearchOption.AllDirectories);
        }

        public FilesForm()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(PathTextBox.Text)
                .Select(file => new
                {
                    file.Name,
                    file.DirectoryName,
                    Size = file.Length,
                    file.CreationTime
                })
                .OrderBy(file => file.Name)
                .ThenByDescending(file => file.CreationTime);
            DataFiles.DataSource = files.ToList();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(PathTextBox.Text)
                .Select(file => new { file.Extension })
                .Distinct();
            DataFiles.DataSource = files.ToList();
        }

        private void Task3Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(PathTextBox.Text)
                .GroupBy(file => file.Extension)
                .Select(fileGroup => new
                {
                    Extension = fileGroup.Key,
                    Count = fileGroup.Count(),
                });
            DataFiles.DataSource = files.ToList();
        }

        private void Task4Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(PathTextBox.Text)
                .Where(file => file.Name.Contains(FileNameTextBox.Text))
                .Select(file => new
                {
                    file.Name,
                    file.DirectoryName,
                    Size = file.Length,
                    file.CreationTime
                });
            DataFiles.DataSource = files.ToList();
        }

        private void Task5Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(PathTextBox.Text)
                .Where(file => file.CreationTime.Day == DateTime.Now.Day)
                .OrderByDescending(file => file.CreationTime)
                .Take(5);
            DataFiles.DataSource = files.ToList();
        }
    }
}

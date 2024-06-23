using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DirectoryInfo directory = new("C:\\Temp\\МДК.01.01\\2024\\4\\2");
        FileInfo[] files;

        public MainWindow()
        {
            InitializeComponent();
            files = directory.GetFiles("*", SearchOption.AllDirectories);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void ClearFilterButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Clear();
            Filter();
        }

        private void Filter()
        {
            var result = files.Where(f => f.Name.ToLower().Contains(TextBox.Text.ToLower()));
            FilesDataGrid.ItemsSource = result;
            CountRowsStatusBarItem.Content = $"Показано {result.Count()} из {files.Length} записей";
            if (result.Count() == 0)
                NotFoundLabel.Visibility = Visibility.Visible;
        }
    }
}
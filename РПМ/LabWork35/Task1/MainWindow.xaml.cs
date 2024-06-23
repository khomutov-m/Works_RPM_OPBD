using Microsoft.Win32;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "тестовые файлы|*.txt;*.cs;*.html;*.css;*.js;*.sql",
                Title = "Выбор файла",
            };
            if (dialog.ShowDialog() != true)
                return;
            Title = dialog.SafeFileName;
            TextBox.Text = File.ReadAllText(dialog.FileName);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "тестовые файлы|*.txt;*.cs;*.html;*.css;*.js;*.sql",
                Title = "Выбор файла",
            };
            if (dialog.ShowDialog() != true)
                return;
            File.WriteAllText(dialog.FileName, TextBox.Text);
            MessageBox.Show("Урааа, файл сохранен", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть приложение?", "Подтверждение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
                e.Cancel = true;
        }
    }
}
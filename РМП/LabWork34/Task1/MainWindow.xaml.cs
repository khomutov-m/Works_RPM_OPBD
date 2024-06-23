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
            StartTimeStatusBarItem.Content = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CountRowsStatusBarItem.Content = $"Количество символов: {TextBox.Text.Length}";
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            if(statusBar != null) 
                statusBar.Visibility = Visibility.Visible;
        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            statusBar.Visibility = Visibility.Collapsed;
        }

        private void ScaleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (PercentStatusBarItem != null)
                PercentStatusBarItem.Content = $"Масштаб: {Math.Round(ScaleSlider.Value,0)}%";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = string.Empty;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (NumbersStackPanel.Width == 30)
                NumbersStackPanel.Width = 60;
            else
                NumbersStackPanel.Width = 30;
        }
    }
}
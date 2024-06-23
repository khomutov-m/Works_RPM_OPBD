using System.Windows;
using Task1.Pages;

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
            ContentFrame.Navigate(new MainPage());
            Manager.MainFrame = ContentFrame;
        }

        private void ContentFrame_ContentRendered(object sender, EventArgs e)
        {
            if (Manager.MainFrame.CanGoBack)
                GoBackButton.Visibility = Visibility.Visible;
            else
                GoBackButton.Visibility = Visibility.Collapsed;
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}
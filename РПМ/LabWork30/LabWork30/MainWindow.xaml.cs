using System.Windows;

namespace LabWork30
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

        private void AgreeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SubscribeButton.IsEnabled = true;
        }

        private void AgreeCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            SubscribeButton.IsEnabled = false;
        }
    }
}
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3
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

        private void SizeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.FontSize = Convert.ToInt32((sender as RadioButton).Content);
        }

        private void LeftAligmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Left;
        }

        private void CenterAligmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Center;
        }

        private void RightAligmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Right;
        }
    }
}
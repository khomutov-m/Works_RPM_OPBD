using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Task_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        byte red;
        byte green;
        byte blue;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor();
        }

        private void ChangeColor()
        {
            red = RedCheckBox.IsChecked == true ? (byte)RedSlider.Value : (byte)0;
            green = GreenCheckBox.IsChecked == true ? (byte)GreenSlider.Value : (byte)0;
            blue = BlueCheckBox.IsChecked == true ? (byte)BlueSlider.Value : (byte)0;
            Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }
    }
}
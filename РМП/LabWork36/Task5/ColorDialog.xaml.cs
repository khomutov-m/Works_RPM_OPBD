using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Task5
{
    /// <summary>
    /// Логика взаимодействия для ColorDialog.xaml
    /// </summary>
    public partial class ColorDialog : Window
    {
        public SolidColorBrush ColorValue => new(Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value));

        public ColorDialog()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void StackPanel_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rectangle.Fill = ColorValue;
        }
    }
}

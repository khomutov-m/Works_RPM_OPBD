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

namespace Task4
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

        private void DarkThemeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ChangeTheme("DarkTheme");
        }

        private void WhiteThemeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ChangeTheme("WhiteTheme");
        }

        private void ChangeTheme(string themeName)
        {
            var uriDict = new Uri($"Themes/{themeName}.xaml", UriKind.Relative);
            ResourceDictionary dictionary = Application.LoadComponent(uriDict) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}
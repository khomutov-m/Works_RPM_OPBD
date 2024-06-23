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

        private void ShowProductsButton_Click(object sender, RoutedEventArgs e)
        {
            string products = "";
            foreach (CheckBox item in ProductsListBox.Items)
            {
                if(item.IsChecked == true)
                    products += $"{item.Content}\n";
            }
            MessageBox.Show(products);
        }
    }
}
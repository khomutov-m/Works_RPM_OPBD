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

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> users = new List<User>
            {
                new User{Login="doc", Password="123", Id=1},
                new User{Login="dog", Password="uut2", Id=2},
                new User{Login="cat", Password="1h3", Id=3},
                new User{Login="user", Password="aksdjfkl3", Id=4},
                new User{Login="nouser", Password="121212", Id=5}
            };
            UsersComboBox.ItemsSource = users;
            UsersListBox.ItemsSource = users;
            UsersListView.ItemsSource = users;

        }

        private void ShowSelectedUsersButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
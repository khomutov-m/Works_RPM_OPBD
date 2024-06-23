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
        private void UsersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User selectedUser = UsersComboBox.SelectedItem as User;
            SelectionComboBoxLabel.Content = $"Выбранные элементы:\nИдентификатор: {selectedUser.Id}\nЛогин: {selectedUser.Login}\nПароль: {selectedUser.Password}";

        }

        private void UsersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedUsers = "Выбранные элементы";
            foreach (User user in UsersListBox.SelectedItems)
            {
                selectedUsers += $"\n{user.Login}";
            }
            SelectionListBoxLabel.Content = selectedUsers;
        }

        private void UsersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedUsers = "Выбранные элементы";
            foreach (User user in UsersListView.SelectedItems)
            {
                selectedUsers += $"\n{user.Login}";
            }
            SelectionListViewLabel.Content = selectedUsers;
        }
    }
}
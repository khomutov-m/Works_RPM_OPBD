using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if(LoginTextBox.Text=="admin" && PasswordBox.Password=="qwerty") 
            { 
                AdminWindow adminWindow = new AdminWindow();
                Hide();
                adminWindow.ShowDialog();
                ShowDialog();
                return;
            }
            if (LoginTextBox.Text == "manager" && PasswordBox.Password == "12345")
            {
                ManagerWindow managerWindow = new ManagerWindow();
                Hide();
                managerWindow.ShowDialog(); 
                ShowDialog();
                return;
            }
            MessageBox.Show("Пользователя не существует", "Некорректные данные", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

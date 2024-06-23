using System.Windows;
using System.Windows.Controls;

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
            DatePicker.DisplayDateEnd = DateTime.Now;
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(LoginTextBox.Text) &&
                    !String.IsNullOrEmpty(PasswordBox.Password) &&
                    String.IsNullOrEmpty(PersonalInformationTextBox.Text) &&
                    PasswordBox.Password == ConfirmationPasswordBox.Password)
                MessageBox.Show($"{LoginTextBox.Text}, вы зарегистрированы");
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            AgeLabel.Content = $"Ваш возраст: {DateTime.Now.Year - DatePicker.SelectedDate.Value.Year}";
        }
    }
}
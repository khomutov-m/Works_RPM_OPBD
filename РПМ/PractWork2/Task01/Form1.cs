using System;
using System.IO;
using System.Windows.Forms;

namespace Task01
{
    public partial class RegistrationForm : Form
    {
        static string fileName = Path.Combine(Environment.CurrentDirectory, "logins.csv");

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(LoginTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Логин и пароль не могут быть пустыми");
                return;
            }
            if (!File.Exists(fileName)) 
            {
                MessageBox.Show("Файл не существует");
                return;
            }
            var rows = File.ReadAllLines(fileName);
            foreach (var row in rows)
            {
                string[] words = row.Split(';');
                if (words[0] == LoginTextBox.Text)
                {
                    LoginTextBox.Text = "";
                    MessageBox.Show("Данный пользователь уже зарегистрирован");
                    return;
                }
            }
            File.AppendAllText(fileName, $"{LoginTextBox.Text};{PasswordTextBox.Text};{DateTime.Now.ToShortDateString()}\n");
        }
    }
}

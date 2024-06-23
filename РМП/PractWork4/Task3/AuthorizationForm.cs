using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Task3
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            string[] userData = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "userData.txt"));
            if (userData[0] == LoginTextBox.Text && userData[1] == PasswordTextBox.Text)
            {
                SettingsForm settingsForm = new SettingsForm();
                settingsForm.ShowDialog();
            }
            else
                throw new Exception("Некорректные данные");
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }
    }
}

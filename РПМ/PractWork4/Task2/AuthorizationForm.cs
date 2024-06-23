using System;
using System.Configuration;
using System.Windows.Forms;

namespace Task2
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings.Get(Name = "Login") == LoginTextBox.Text && ConfigurationManager.AppSettings.Get(Name = "Password") == PasswordTextBox.Text)
            {
                SettingsForm settingsForm = new SettingsForm(ConfigurationManager.AppSettings.Get(Name = "Login"), ConfigurationManager.AppSettings.Get(Name = "Password"), ConfigurationManager.AppSettings.Get(Name = "Email"));
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

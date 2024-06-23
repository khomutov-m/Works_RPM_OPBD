using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(string login, string password, string email)
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings.Set(Name = "Login", LoginTextBox.Text);
            ConfigurationManager.AppSettings.Set(Name = "Password", PasswordTextBox.Text);
            ConfigurationManager.AppSettings.Set(Name = "Email", EmailTextBox.Text);
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            if(LoginTextBox.Text == Properties.Settings.Default.Login && PasswordTextBox.Text == Properties.Settings.Default.Password) 
            { 
                SettingsForm settingsForm = new SettingsForm(Properties.Settings.Default.Login, Properties.Settings.Default.Password, Properties.Settings.Default.Email);
                settingsForm.ShowDialog();
            }
            else
            {
                throw new Exception("Некорректные данные");
            }

        }
    }
}

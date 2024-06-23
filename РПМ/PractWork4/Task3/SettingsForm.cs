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
using System.IO;
using System.Security.Cryptography;

namespace Task3
{
    public partial class SettingsForm : Form
    {
        private string[] userData; 
        public SettingsForm()
        {
            InitializeComponent();
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            userData = new string[3];
            userData[0] = LoginTextBox.Text;
            userData[1] = HashingPassword(PasswordTextBox.Text);
            userData[2] = EmailTextBox.Text;
            File.WriteAllLines(Path.Combine(Environment.CurrentDirectory, "userData.txt"), userData);
        }

        private string HashingPassword(string password)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashedBytes = SHA256.Create().ComputeHash(inputBytes);
            int decimalHash = Convert.ToInt32(hashedBytes.ToString(), 2);
            return decimalHash.ToString("X");
        }
    }
}

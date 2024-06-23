using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class User(string login, string password, string confirmPassword)
    {
        private string _login = login;
        private string _password = password;
        private string _confirmPassword = confirmPassword;

        public bool IsCorrectUserData()
        {
            bool isLoginCorrect = !string.IsNullOrWhiteSpace(_login);
            bool isPasswordCorrect = !string.IsNullOrWhiteSpace(_password);
            bool isConfirmCorrect = _password == _confirmPassword;
            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }
    }
}

namespace Task3
{
    internal class User : InfoEventArgs
    {
        private string _login;
        private string _password;
        public event EventHandler<InfoEventArgs> PropertyChanged;

        public string Login
        {
            get => _login;
            set
            {
                if (_login != value && !string.IsNullOrEmpty(value))
                {
                    _login = value;
                }
                OnPropertyLoginChanged(_login);
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value && value.Length > 5 && value.Length < 20)
                {
                    _password = value;
                }
                OnPropertyPasswordChanged(_password);
            }
        }

        public void OnPropertyLoginChanged(string value)
        {
            InfoEventArgs info = new();
            info.NameProperty = "логин";
            info.DateChange = DateTime.Now;
            if (string.IsNullOrEmpty(value))
            {
                info.TextError = "Ошибка: логин не может быть пустым";
            }
            else
            {
                info.TextError = "";
            }
            PropertyChanged?.Invoke(this, info);
        }

        public void OnPropertyPasswordChanged(string value)
        {
            InfoEventArgs info = new();
            info.NameProperty = "пароль";
            info.DateChange = DateTime.Now;
            if (string.IsNullOrEmpty(value) || value.Length < 6 || value.Length > 20)
            {
                info.TextError = "Ошибка: пароль не может быть меньше 6 или больше 20";
            }
            else
            {
                info.TextError = "";
            }
            PropertyChanged?.Invoke(this, info);
        }
    }
}

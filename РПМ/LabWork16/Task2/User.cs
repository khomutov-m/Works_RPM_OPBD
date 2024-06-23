namespace Task2
{
    internal class User
    {
        private string _login;
        private string _password;

        public string Login
        {
            get => _login; 
            set
            {
                if (_login != value && !string.IsNullOrEmpty(value))
                {
                    _login = value;
                    OnDataChanged();
                }
            }
        }

        public string Password
        {
            get => _password; 
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnDataChanged();
                }
            }
        }

        public event EventHandler DataChanged;

        public void OnDataChanged()
        {
            DataChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

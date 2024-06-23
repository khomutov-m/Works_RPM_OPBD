namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new() { Login = "dog", Password = "123" };
            user.PropertyChanged += User_PropertyChanged;
            user.Login = "";
            user.Password = "pass";
        }

        private static void User_PropertyChanged(object? sender, InfoEventArgs e)
        {
            Console.WriteLine($"{e.DateChange}: у пользователя {((User)sender).Login} изменено {e.NameProperty}.\n{e.TextError}");
        }
    }
}

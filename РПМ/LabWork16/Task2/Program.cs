namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new() { Login = "dog", Password = "123" };
            user.DataChanged += User_DataChanged;
            user.Login = "Duck";
            user.Password = "password";
        }

        private static void User_DataChanged(object? sender, EventArgs e)
        {
            User user = sender as User;
            Console.WriteLine($"Изменены данные пользователя со следующим логином: {user.Login}");
        }
    }
}

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new() { Login = "dog", Password = "123" };
            user.PropertyChanged += User_PropertyChanged;
            user.Login = "Duck";
            user.Password = "password";
            user.Login = "Duck";
        }

        private static void User_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine($"{e.PropertyName} изменён.");
        }
    }
}

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();

            Console.WriteLine("Введите подтверждение пароля");
            string confirmPassword = Console.ReadLine();

            Console.WriteLine(IsCorrectUserData(login, password, confirmPassword));
            User user = new(login, password, confirmPassword);
            Console.WriteLine(user.IsCorrectUserData());
        }

        private static bool IsCorrectUserData(string login, string password, string confirmPassword)
        {
            bool isLoginCorrect = !string.IsNullOrWhiteSpace(login);
            bool isPasswordCorrect = !string.IsNullOrWhiteSpace(password);
            bool isConfirmCorrect = password == confirmPassword;
            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }
    }
}

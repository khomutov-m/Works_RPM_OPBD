namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDaysCount(13, 2024));
        }

        private static int GetDaysCount(int month, int year)
        {
            bool leapYear = year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
            int[] daysInMonths = { 31, leapYear ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return month > 12 || month < 1 ? throw new ArgumentException("Некорректный номер месяца") : daysInMonths[month - 1];
        }
    }
}

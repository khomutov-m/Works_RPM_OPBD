namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(3, 6));
            Console.WriteLine(GetAreaRing(9, 8));
            Console.WriteLine(GetSeriesSum(100));
            Console.WriteLine(GetSize(99000000000));
            Console.WriteLine(GetDaysCount(2, 2024));
            Console.WriteLine(GetPower(5, 4));
        }
        static int GetSum(int a, int b) => a + b;

        static double GetAreaRing(double outerRadius, double innerRadius)
        {
            double result = Math.PI * (outerRadius - innerRadius) * (innerRadius + outerRadius);
            return result < 0 ? -result : result;
        }

        static double GetSeriesSum(int n)
            => (1 + n) * n / 2;

        static string GetSize(ulong bytes)
            => bytes < 1024 ? $"{bytes} Б" :
                bytes < 1 << 20 ? $"{bytes >> 10} КБ" :
                bytes < 1 << 30 ? $"{bytes >> 20} МБ" :
                $"{bytes >> 30} ГБ";

        static int GetDaysCount(int month, int year)
        {
            if (month < 1 || month > 12)
                return -1;
            if (month == 2)
                return year % 400 == 0 || year % 100 != 0 && year % 4 == 0 ? 29 : 28;
            return month < 8 && month % 2 == 0 ? 30 : month >= 8 && month % 2 == 1 ? 30 : 31;
        }

        static double GetPower(double x, int n)
        {
            if (n == 0)
                return 1;
            if (n > 0)
            {
                double temp = GetPower(x, n / 2);
                temp = temp * temp;
                return n % 2 == 0 ? temp : x * temp;
            }
            return -1;
        }
    }
}
//int[] daysInMonths = { 31, year % 400 == 0 || year % 100 != 0 && year % 4 == 0 ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
//return month > 12 || month < 1 ? -1 : daysInMonths[month - 1];
//
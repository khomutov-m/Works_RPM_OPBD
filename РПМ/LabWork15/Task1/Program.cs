namespace Task1
{
    internal class Program
    {
        delegate int Function(int x);

        static void Main(string[] args)
        {
            Function func = Square;
            Console.WriteLine($"Квадрат:{func?.Invoke(5)}");
            func = Factorial;
            Console.WriteLine($"Факториал: {func?.Invoke(5)}");
            func = Mod;
            Console.WriteLine($"Модуль: {func?.Invoke(-5)}");

            Function[] functions = { Square, Factorial, Mod };
            foreach (Function function in functions)
            {
                Console.WriteLine(function(5));
            }
        }

        static int Square(int x)
            => x * x;

        static int Mod(int x)
            => x > 0 ? x : -x;

        static int Factorial(int x)
        {
            return x < 0 ? -1 : x < 2 ? 1 : x * Factorial(x - 1);
        }
    }
}

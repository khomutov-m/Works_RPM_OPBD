namespace Task2
{
    internal class Program
    {
        delegate void Mathematics(int a, int b);

        static void Main(string[] args)
        {
            Mathematics mathematics = (int a, int b) => Console.WriteLine($"Сумма: {a + b}");
            mathematics += (int a, int b) => Console.WriteLine($"Разность: {a - b}");
            mathematics += (int a, int b) => Console.WriteLine($"Произведение: {a * b}");
            mathematics += (int a, int b) => Console.WriteLine($"Частное: {a / b}");
            mathematics?.Invoke(14, 7);
        }
    }
}

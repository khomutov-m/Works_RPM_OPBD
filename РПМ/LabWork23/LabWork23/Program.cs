using LabWorkLibrary;
using Microsoft.Win32;
using System;

namespace LabWork23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Константа: {Maths.BINARY_FACTOR}");
            Console.WriteLine($"Сумма: {Maths.Sum(5, 6)}");
            Console.WriteLine($"Разность: {Maths.Difference(9, 3)}");
            Console.WriteLine($"Произведение: {Maths.Multiplication(2.3, 8)}");
            Console.WriteLine($"Частное: {Maths.Quotient(8, 0)}");
            Console.WriteLine($"Площадь прямоугольника: {Maths.RectangleArea(0, 7)}");
            Console.ReadKey();
            User user = new User { Role = Role.Admin };
        }
    }
}

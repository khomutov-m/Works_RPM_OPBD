namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new();
            Console.WriteLine(GetArea(rectangle));
        }

        static double GetArea(Figure figure)
        {
            if (figure is Circle circle)
            {
                Console.WriteLine("Введите радиус");
                circle.Radius = Convert.ToDouble(Console.ReadLine());
                return circle.Area();
            }
            if (figure is Rectangle rectangle)
            {
                Console.WriteLine("Введите высоту");
                rectangle.Height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ширину");
                rectangle.Width = Convert.ToDouble(Console.ReadLine());
                return rectangle.Area();
            }
            Ring ring = (Ring)figure;
            Console.WriteLine("Введите внешний радиус");
            ring.OuterRadius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите внутреннй радиус");
            ring.InnerRadius = Convert.ToDouble(Console.ReadLine());
            return ring.Area();
        }
    }
}

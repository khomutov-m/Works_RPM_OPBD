namespace Task3
{
    internal class Square(double side) : Figure
    {
        public double Side { get; set; } = side;

        public override string Name { get => "Квадрат"; }

        public override double Area() => Side * Side;

        public override double Perimeter() => Side * 4;

        public override void Print() => Console.WriteLine($"Фигура: {Name}\nДлина стороны: {Side}");
    }
}

namespace Task1
{
    internal class Ellipse(double smallSemiAxis, double largeSemiAxis) : IPrinter, IFigure
    {
        public double SmallSemiAxis { get; } = smallSemiAxis;
        public double LargeSemiAxis { get; } = largeSemiAxis;
        public string Name { get => "Эллипс"; }

        public double Area(double SmallSemiAxis, double LargeSemiAxis)
            => Math.Round(Math.PI * SmallSemiAxis * LargeSemiAxis, 2);

        public double Perimeter(double SmallSemiAxis, double LargeSemiAxis)
            => Math.Round(2 * Math.PI * Math.Sqrt((Math.Pow(SmallSemiAxis, 2) + Math.Pow(LargeSemiAxis, 2)) / 2), 2);

        public void Print()
            => Console.WriteLine($"Длина малой полуоси: {SmallSemiAxis}\nДлина большой полуоси: {LargeSemiAxis}");

        public void PrintFull()
            => Console.WriteLine($"Периметр: {Perimeter(SmallSemiAxis, LargeSemiAxis)}\nПлощадь: {Area(SmallSemiAxis, LargeSemiAxis)}");
    }
}

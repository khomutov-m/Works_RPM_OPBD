namespace Task1
{
    internal interface IFigure
    {
        public string Name { get => "Фигура"; }

        public double Area(double SmallSemiAxis, double LargeSemiAxis);

        public double Perimeter(double SmallSemiAxis, double LargeSemiAxis);

        public void PrintFull();
    }
}

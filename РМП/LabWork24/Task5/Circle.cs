namespace Task5
{
    internal class Circle : Figure
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return CircleArea(Radius);
        }
    }
}

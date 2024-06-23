namespace Task5
{
    internal class Ring : Figure
    {
        public double OuterRadius { get; set; }
        public double InnerRadius { get; set; }

        public override double Area()
        {
            return CircleArea(OuterRadius) - CircleArea(InnerRadius);
        }
    }
}

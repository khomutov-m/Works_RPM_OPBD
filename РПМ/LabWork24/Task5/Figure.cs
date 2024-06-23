namespace Task5
{
    internal abstract class Figure
    {
        public abstract double Area();

        public double CircleArea(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape = shapeFactory.GetShape("CIRCLE");
            shape.Draw();

            shape = shapeFactory.GetShape("RECTANGLE");
            shape.Draw();

            shape = shapeFactory.GetShape("SQUARE");
            shape.Draw();

            shape = shapeFactory.GetShape("TRIANGLE");
            shape.Draw();
        }
    }
}

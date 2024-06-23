namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();

            IShape redCircle = new RedShapeDecorator(new Circle());

            IShape redRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.Draw();

            IShape blackCircle = new BlackShapeDecorator(redCircle);
            IShape blackRectangle = new BlackShapeDecorator(new Rectangle());

            Console.WriteLine("\nCircle of black border");
            blackCircle.Draw();

            Console.WriteLine("\nRectangle of black border");
            blackRectangle.Draw();
        }
    }
}

namespace Task3
{
    internal class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

        public override void Draw()
        {
            decoratedShape.Draw();
            SetRedBorder();
        }

        private void SetRedBorder()
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}

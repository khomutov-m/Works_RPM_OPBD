using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class BlackShapeDecorator : ShapeDecorator
    {
        public BlackShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

        public override void Draw()
        {
            decoratedShape.Draw();
            SetBlackBorder();
        }

        private void SetBlackBorder()
        {
            Console.WriteLine("Border Color: Black");
        }
    }
}

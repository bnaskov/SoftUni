namespace Shapes
{
    using System;

    class Circle : BasicShape, IShape
    {
        public Circle (double radius) : base(radius, 1)
        {
        }

        public override double CalculateArea()
        {
            return Math.PI * this.Width * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Width;
        }
    }
}

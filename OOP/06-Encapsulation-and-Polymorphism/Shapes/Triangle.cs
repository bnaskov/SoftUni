namespace Shapes
{
    using System;

    class Triangle : BasicShape, IShape
    {
        private double angle;

        public Triangle(double width, double height, double angle)
            : base (width, height)
        {
        }

        public double Angle
        {
            get
            {
                return this.angle;
            }

            set
            {
                if (value < 0 || value > 180)
                {
                    throw new ArgumentOutOfRangeException(
                        "Angle", "The angle must be between 0 and 180 deg");
                }

                this.angle = value;
            }
        }

        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width + this.Height
                + Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height) 
                - (2 * this.Height * this.Width * Math.Cos(this.Angle * Math.PI / 180)));
        }
    }
}

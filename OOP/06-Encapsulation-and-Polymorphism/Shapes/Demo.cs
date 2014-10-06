using System;
using System.Collections.Generic;

namespace Shapes
{
    class Demo
    {
        static void Main()
        {
            var shapes = new IShape[]{
                new Triangle(5, 6, 90),
                new Rectangle(4, 5.5),
                new Circle(6)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape name: {0}, area: {1:0.00}, perimeter: {2:0.00}.", 
                    shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}

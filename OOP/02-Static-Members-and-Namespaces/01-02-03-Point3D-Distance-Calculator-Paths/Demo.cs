using System;
class Demo
{
    static void Main()
    {
        Point3D pointA = new Point3D(3.5, 2, 4.86);
        Point3D pointB = new Point3D(10, 5.2, 15);

        Console.WriteLine(pointA.ToString());
        Console.WriteLine(pointB.ToString());
        Console.WriteLine(Point3D.StartingPoint);

        Console.WriteLine(String.Format("{0:0.##}", DistanceCalculator.distCalculator(pointA, pointB)));

        Path3D path = new Path3D(pointA, pointB, Point3D.StartingPoint);
        Console.WriteLine("{0}", path);
    }
}

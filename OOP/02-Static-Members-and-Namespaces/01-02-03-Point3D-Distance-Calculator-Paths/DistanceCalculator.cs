using System;

class DistanceCalculator
{
    // additional info: http://en.wikipedia.org/wiki/Euclidean_distance
    // online calculator: http://www.calculatorsoup.com/calculators/geometry-solids/distance-two-points.php
    public static double distCalculator(Point3D a, Point3D b)
    {
        return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) + (a.Z - b.Z) * (a.Z - b.Z));
    }
}

﻿using System;

class Point3D
{
    private string name;
    private double x;
    private double y;
    private double z;

    private static readonly Point3D startingPoint; 

    static Point3D()
    {
        startingPoint = new Point3D(0, 0, 0);
    }

    public Point3D(double x, double y, double z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public double X
    {
        get { return this.x; }
        set { this.x = value; }
    }

    public double Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    public double Z
    {
        get { return this.z; }
        set { this.z = value; }
    }

    public static Point3D StartingPoint
    {
        get { return Point3D.startingPoint; }
    }

    public override string ToString()
    {
        return String.Format("x:{0:0.##}, y:{1:0.##}, z:{2:0.##}", this.X, this.Y, this.Z);
    }
}

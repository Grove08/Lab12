using System;

namespace Lab12
{
    static class Circle
    {
        static public double GetLength(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static public double GetArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static public bool IsPointInsideCircle(double x, double y, double x0, double y0, double radius)
        {
            double distance = Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2));

            return distance < radius;
        }
    }
}

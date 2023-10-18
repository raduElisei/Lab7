using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7;

public class Triangle
{
    public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        Vertex1 = new Point(x1, y1);
        Vertex2 = new Point(x2, y2);
        Vertex3 = new Point(x3, y3);
    }
    
    public Point Vertex1 { get; set; }
    public Point Vertex2 { get; set; }
    public Point Vertex3 { get; set; }

    public double CalculatePerimeter()
    {
        double a = Point.DistanceBetweenPoints(Vertex1, Vertex2);
        double b = Point.DistanceBetweenPoints(Vertex1, Vertex3);
        double c = Point.DistanceBetweenPoints(Vertex2, Vertex3);

        return a + b + c;
    }

    public double CalculateArea()
    {
        double s = CalculatePerimeter() / 2;

        double a = Point.DistanceBetweenPoints(Vertex1, Vertex2);
        double b = Point.DistanceBetweenPoints(Vertex1, Vertex3);
        double c = Point.DistanceBetweenPoints(Vertex2, Vertex3);

        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}

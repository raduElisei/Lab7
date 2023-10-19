using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7.CalculeGeometrice;

public class Rectangle
{
    public Rectangle(double x1, double y1, double length, double height)
    {
        Vertex = new Point(x1, y1);
        Length = length;
        Height = height;
    }

    public Point Vertex { get; set; }
    public double Length { get; set; }
    public double Height { get; set; }


    public double CalculatePerimeter()
    {
        return 2 * Length + 2 * Height;
    }

    public double CalculateArea()
    {
        return Length * Height;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7.CalculeGeometrice;

public class Square
{
    public Square(double x1, double y1, double length)
    {
        Vertex = new Point(x1, y1);
        Length = length;
    }

    public Point Vertex { get; set; }
    public double Length { get; set; }


    public double CalculatePerimeter()
    {
        return 4 * Length;
    }

    public double CalculateArea()
    {
        return Length * Length;
    }
}

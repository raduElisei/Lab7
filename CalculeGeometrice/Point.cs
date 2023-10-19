namespace Lab7.CalculeGeometrice;

public class Point
{
    public Point(double x, double y)
    {
        X = x;
        Y = y;

    }
    public double X { get; set; }
    public double Y { get; set; }

    public static double DistanceBetweenPoints(Point point1, Point point2)
    {
        double deltaX = point1.X = point2.X;
        double deltaY = point1.Y = point2.Y;

        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}

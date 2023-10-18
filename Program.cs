namespace Lab7;

internal class Program
{
    static void Main(string[] args)
    {
        //Management informatii personale

        Person p1 = new("Joe", "Johnson", DateTimeOffset.Now.AddYears(-30), new Address());

        p1.PrintPersonProperties();

        Address a1 = new()
        {
            City = "Paris",
            Country = "France",
            Street = "Champs Elysee",
            StreetNumber = "1"
        };

        Person p2 = new("Angela", "White", DateTimeOffset.Now.AddYears(-34), a1);

        p2.PrintPersonProperties();
        System.Console.WriteLine();

        // Calcule geometrice
        Triangle triangle = new Triangle(0, 0, -1, -3, 9, 11);
        double triangleArea = triangle.CalculateArea();
        double trianglePerimeter = triangle.CalculatePerimeter();
        System.Console.WriteLine($"{triangle.GetType().Name} has an area of {triangleArea} and a perimeter of {trianglePerimeter}");

        Rectangle rectangle = new Rectangle(3, 4, 5, 10);
        double rectangleArea = rectangle.CalculateArea();
        double rectanglePerimeter = rectangle.CalculatePerimeter();
        System.Console.WriteLine($"{rectangle.GetType().Name} has an area of {rectangleArea} and a perimeter of {rectanglePerimeter}");

        Square square = new Square(3, 4, 6);
        double squareArea = square.CalculateArea();
        double squarePerimeter = square.CalculatePerimeter();
        System.Console.WriteLine($"{square.GetType().Name} has an area of {squareArea} and a perimeter of {squarePerimeter}");
    }
}
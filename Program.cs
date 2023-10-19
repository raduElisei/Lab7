using Lab7.CalculeGeometrice;
using Lab7.Facturare;
using Lab7.ManagementInformatii;

namespace Lab7;

internal class Program
{
    static void Main(string[] args)
    {
        #region Management informatii personale

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

        #endregion

        #region Calcule geometrice

        Triangle triangle = new Triangle(0, 0, -1, -3, 9, 11);
        double triangleArea = triangle.CalculateArea();
        double trianglePerimeter = triangle.CalculatePerimeter();
        Console.WriteLine($"{triangle.GetType().Name} has an area of {triangleArea} and a perimeter of {trianglePerimeter}");

        Rectangle rectangle = new Rectangle(3, 4, 5, 10);
        double rectangleArea = rectangle.CalculateArea();
        double rectanglePerimeter = rectangle.CalculatePerimeter();
        Console.WriteLine($"{rectangle.GetType().Name} has an area of {rectangleArea} and a perimeter of {rectanglePerimeter}");

        Square square = new Square(3, 4, 6);
        double squareArea = square.CalculateArea();
        double squarePerimeter = square.CalculatePerimeter();
        Console.WriteLine($"{square.GetType().Name} has an area of {squareArea} and a perimeter of {squarePerimeter}");

        #endregion

        #region Facturare

        Product mere = new Product("mere", MeasurementUnit.kg, 3.5F, 7, 0.19F);
        Product lapte = new Product("lapte", MeasurementUnit.L, 2.0F, 6.5F, 0.19F);
        Product boxa = new Product("boxa", MeasurementUnit.piece, 1.0F, 120);

        List<Product> products = new()
        {
            mere,
            lapte,
            boxa
        };

        Supplier emag = new()
        {
            Name = "emag",
            CIF = "RO12345678",
            Address = new Address(),
            BankName = "BCR",
            IBAN = "DE89370400440532013000"
        };

        Buyer olx = new()
        {
            Name = "olx",
            CIF = "RO2222222",
            Address = new Address(),
            BankName = "Raiffeisen",
            IBAN = "RO71RZBR0000060007583456"
        };


        Invoice invoice = new(emag, olx, products);

        invoice.PrintInvoice();

        #endregion
    }
}
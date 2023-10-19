namespace Lab7.Facturare;

public class Invoice
{
    public Invoice()
    {
        NumberCounter++;
        Number = NumberCounter;
        Series = "SERIE" + Number;
    }

    public Invoice(Supplier supplier, Buyer buyer, List<Product> products)
    {
        NumberCounter++;
        Number = NumberCounter;
        Series = "SERIE" + Number;
        Supplier = supplier;
        Buyer = buyer;
        Products = products;
    }

    public static int NumberCounter { get; private set; }
    public string Series { get; private set; }
    public long Number { get; private set; }
    public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;
    public Supplier Supplier { get; set; }
    public Buyer Buyer { get; set; }
    public List<Product> Products { get; set; }

    public float PriceTotalWithoutVAT()
    {
        if (!Products.Any())
        {
            return 0.0F;
        }

        float sumTotal = 0.0F;

        foreach (var product in Products)
        {
            sumTotal += product.PriceWithoutVAT;
        }

        return sumTotal;
    }

    public float PriceTotalWithVAT()
    {
        if (!Products.Any())
        {
            return 0.0F;
        }

        float sumTotal = 0.0F;

        foreach (var product in Products)
        {
            sumTotal += product.PriceWithVAT;
        }

        return sumTotal;
    }

    public float PriceTotal()
    {
        return PriceTotalWithoutVAT() + PriceTotalWithVAT();
    }

    public void PrintInvoice()
    {
        if (!Products.Any())
        {
            Console.WriteLine("There are no products/services to print");
        }

        Console.WriteLine("Invoice");
        Console.WriteLine($"Series {Series}");
        Console.WriteLine($"Number {Number}");
        Console.WriteLine($"Buyer {Buyer}");
        Console.WriteLine($"Supplier {Supplier}");
        Console.WriteLine();
        string tableHead = String.Format("|{0,5}|{1,5}|{2,30}|{3,30}|", "No.", "Name", "Price Without VAT", "Price With VAT");
        Console.WriteLine(tableHead);

        int currentItem = 0;
        float noVatTotal = 0.0F;
        float total = 0.0F;

        foreach (var p in Products)
        {
            currentItem++;
            noVatTotal += p.PriceWithoutVAT;
            total += p.PriceTotal;

            string tableRow = String.Format("|{0,5}|{1,5}|{2,30}|{3,30}|", currentItem, p.ProductName, p.PriceWithoutVAT, p.PriceWithVAT);
            Console.WriteLine(tableRow);
        }

        Console.WriteLine($"Total without VAT is {noVatTotal}.");
        Console.WriteLine($"Total with VAT is {total}.");
        Console.WriteLine();
    }
}

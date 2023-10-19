namespace Lab7.Facturare;

public class Product
{
    public Product()
    {
    }

    public Product(string productName, MeasurementUnit measurementUnit, float quantity, float unitPrice, float vat = 0.19F)
    {
        ProductName = productName;
        MeasurementUnit = measurementUnit;
        Quantity = quantity;
        UnitPrice = unitPrice;
        VAT = VAT;
    }


    public string ProductName { get; set; }
    public MeasurementUnit MeasurementUnit { get; set; } = MeasurementUnit.piece;
    public float Quantity { get; set; } = 0;
    public float UnitPrice { get; set; } = 1;
    public float VAT { get; set; } = 0.19F;
    public float PriceWithoutVAT
    {
        get
        {
            return Quantity * UnitPrice;
        }
    }

    public float PriceWithVAT
    {
        get
        {
            return (Quantity * UnitPrice) * VAT;
        }
    }

    public float PriceTotal {
        get
        {
            return PriceWithoutVAT + PriceWithVAT;
        }
    }
}

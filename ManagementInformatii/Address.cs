namespace Lab7.ManagementInformatii;

public class Address
{
    public Address()
    {
        Country = string.Empty;
        City = string.Empty;
        County = string.Empty;
        Street = string.Empty;
        StreetNumber = string.Empty;
    }

    public Address(string country, string city, string county, string street, string streetNumber)
    {
        Country = country ?? string.Empty;
        City = city ?? string.Empty;
        County = county ?? string.Empty;
        Street = street ?? string.Empty;
        StreetNumber = streetNumber ?? string.Empty;
    }

    public string Country { get; set; }
    public string City { get; set; }
    public string County { get; set; }
    public string Street { get; set; }
    public string StreetNumber { get; set; }
}

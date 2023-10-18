namespace Lab7;

internal class Program
{
    static void Main(string[] args)
    {
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
    }
}
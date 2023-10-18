namespace Lab7;

public class Person
{
    public Person()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        DateOfBirth = DateTimeOffset.MinValue;
        Age = DateTimeOffset.UtcNow.Year - DateOfBirth.Year;
        Address = new();
    }

    public Person(string? firstName, string? lastName, DateTimeOffset? dateOfBirth, Address? address)
    {
        FirstName = firstName ?? string.Empty;
        LastName = lastName ?? string.Empty;
        DateOfBirth = dateOfBirth ?? DateTime.MinValue;
        Age = DateTimeOffset.UtcNow.Year - DateOfBirth.Year;
        Address = address ?? new();
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTimeOffset DateOfBirth { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }

    public void PrintPersonProperties()
    {
        Console.WriteLine($"This person's name is {FirstName} {LastName}.");
        Console.WriteLine($"He/she was born at {DateOfBirth.ToString("D")} and currently is {Age} years-old.");
        Console.WriteLine($"His/her address is {Address.Country}, {Address.County}, {Address.City}, {Address.Street} {Address.StreetNumber}.");
    }
}

using Microsoft.VisualBasic;

namespace Lab7.ManagementInformatii;

public class Person
{
    public Person()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        DateOfBirth = DateTimeOffset.MinValue;
        Address = new();
    }

    public Person(string firstName, string lastName, DateTimeOffset? dateOfBirth, Address address)
    {
        FirstName = firstName ?? string.Empty;
        LastName = lastName ?? string.Empty;
        DateOfBirth = dateOfBirth ?? DateTime.MinValue;
        Address = address ?? new();
    }

    public string FirstName { get; }
    public string LastName { get; }
    public DateTimeOffset DateOfBirth { get; }
    public long Age
    {
        get
        {
            return DateTimeCalculator.YearsDifference(DateTime.Today, DateOfBirth.Date);
        }
    }
    public Address Address { get; private set; }
}

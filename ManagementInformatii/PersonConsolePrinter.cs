using System.Text;

namespace Lab7.ManagementInformatii;

internal static class PersonConsolePrinter
{
    public static void Print(Person person)
    {
        if(person is null)
        {
            Console.WriteLine("Person does not exist.");
            return;
        }
        string addressString = GetAddressString(person.Address);
        Console.WriteLine($"This person's name is {person.FirstName} {person.LastName}.");
        Console.WriteLine($"He/she was born at {person.DateOfBirth:D} and currently is {person.Age} years-old.");
        Console.WriteLine($"His/her address is {addressString}.");
    }

    private static string GetAddressString(Address address)
    {
        if(address is null)
            return string.Empty;

        StringBuilder sb = new();
        bool otherAddressPartWrittenYet = false;
        WriteAddressPart(sb, address.Street, ref otherAddressPartWrittenYet);
        WriteAddressPart(sb, address.StreetNumber, ref otherAddressPartWrittenYet);
        WriteAddressPart(sb, address.City, ref otherAddressPartWrittenYet);
        WriteAddressPart(sb, address.County, ref otherAddressPartWrittenYet);
        WriteAddressPart(sb, address.Country, ref otherAddressPartWrittenYet);

        return sb.ToString();
    }

    private static void WriteAddressPart(StringBuilder builder, string addressPart, ref bool otherAddressPartWrittenYet)
    {
        if(!string.IsNullOrWhiteSpace(addressPart))
        {
            if(otherAddressPartWrittenYet)
                builder.Append(", ");

            builder.Append(addressPart);
            otherAddressPartWrittenYet = true;
        }
    }
}

namespace Lab7.ConturiBancare;

internal static class PersonValidator
{
    public static void ValidatePersonName(string personName)
    {
        if(string.IsNullOrWhiteSpace(personName))
        {
            throw new ArgumentNullException(nameof(personName), "A person name cannot be null/empty/whitespace.");
        }
    }
}

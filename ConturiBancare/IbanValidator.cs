namespace Lab7.ConturiBancare;

public class IbanValidator
{
    public static void ValidateIban(string iban)
    {
        if(string.IsNullOrWhiteSpace(iban))
        {
            throw new ArgumentNullException(nameof(iban), "The IBAN of an account cannot be null/empty/whitespace.");
        }

        for (int i = 0; i < iban.Length; i++)
        {
            if(!char.IsLetterOrDigit(iban[i]))
            {
                throw new FormatException($"The IBAN of an account can contain only letters and digits. Found invalid character {iban[i]}");
            }
        }
    }
}

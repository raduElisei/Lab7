using Lab7.ManagementInformatii;

namespace Lab7.Facturare;

public class FiscalEntity
{
    public string Name { get; set; }
    public string CIF { get; set; }
    public Address Address { get; set; }
    public string BankName { get; set; }
    public string IBAN { get; set; }
}

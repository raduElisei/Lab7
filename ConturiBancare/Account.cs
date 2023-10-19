using Lab7.Facturare;
using Lab7.ManagementInformatii;

namespace Lab7.ConturiBancare;

public class Account
{
        public Account(string name, string iban)
{
    PersonValidator.ValidatePersonName(name);
    IbanValidator.ValidateIban(iban);
    Name = name;
    Iban = iban;
}

    public string Name { get; set; }
    public string Iban { get; set; }
    public decimal CurrentValue { get; set; } = 0;
    public List<Transaction> TransactionList { get; set; }

    public void BankStatement(int days)
    {
        if (!TransactionList.Any())
        {
            Console.WriteLine("There are no transactions within this period");
        }

        Console.WriteLine("Bank statement");
        Console.WriteLine($"Account holder {Name}");
        Console.WriteLine();
        string tableHead = String.Format("|{0,5}|{1,30}|{2,10}|{3,10}|{4,30}|", "No.", "Date", "Type", "To/From", "Transaction value");
        Console.WriteLine(tableHead);

        foreach (var t in TransactionList)
        {
            if (t.DateCreated < DateTimeOffset.Now.AddDays(-days))
                continue;

            string tableRow = String.Format("|{0,5}|{1,30}|{2,10}|{3,10}|{4,30}|", t.OrderNumber, t.DateCreated, t.IsOutType ? "send" : "receive", t.ToFromAccount.Name, t.TransactionValue);
            Console.WriteLine(tableRow);
        }

        Console.WriteLine();
    }
}

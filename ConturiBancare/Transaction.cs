namespace Lab7.ConturiBancare;

public class Transaction
{
    public Transaction(int orderNumber, bool isOutType, Account toFromAccount, decimal balanceBeforeTransaction, decimal transactionValue, decimal balanceAfterTransaction)
    {
        OrderNumber = orderNumber;
        IsOutType = isOutType;
        ToFromAccount = toFromAccount;
        BalanceBeforeTransaction = balanceBeforeTransaction;
        TransactionValue = transactionValue;
        BalanceAfterTransaction = balanceAfterTransaction;
    }

    public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
    public int OrderNumber { get; set; }
    public bool IsOutType { get; set; }
    public Account ToFromAccount { get; set; }
    public decimal BalanceBeforeTransaction { get; set; }
    public decimal TransactionValue { get; set; }
    public decimal BalanceAfterTransaction { get; set; }
}

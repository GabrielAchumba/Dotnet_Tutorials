public class BankAccount
{
    private string _accountNumber;
    protected double _balance;
    public string OwnerName { get; private set; }

    public BankAccount(string accountNumber, string ownerName)
    {
        // Just creating a new bank account
        _accountNumber = accountNumber;
        OwnerName = ownerName;
        _balance = 0;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"{amount:C} deposited successfully");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public double GetBalance()
    {
        return _balance;
    }

    private void AuditTransaction()
    {
        Console.WriteLine("Transaction audited.");
    }
}
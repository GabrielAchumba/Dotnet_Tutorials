public class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string ownerName) : base(accountNumber, ownerName)
    {

    }

    public void AddInterest(double rate)
    {
        if (rate > 0)
        {
            _balance += _balance * (rate / 100);
            Console.WriteLine($"Interest added at {rate}% rate.");
        }
        else
        {
            Console.WriteLine("Invalid interest rate");
        }
    }
    
}
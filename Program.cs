using System;

// Operators
class Program
{

    static void Main(string[] args)
    {
        // create bank account;

        var account = new SavingsAccount("1234567890", "Gabriel Achumba");

        account.Deposit(100);
        Console.WriteLine($"Owner: {account.OwnerName}");
        Console.WriteLine($"Balance: {account.GetBalance():C}");

        account.AddInterest(5);
        Console.WriteLine($"Balance after interest: {account.GetBalance():C}");
        
    }
}
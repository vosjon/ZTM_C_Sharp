Account account1 = new Account("Paul");
Account account2 = new Account("Peter", 100);

Console.WriteLine(account1.Owner + " " + account1.Balance);
Console.WriteLine(account2.Owner + " " + account2.Balance);

public class Account
{
    public decimal Balance { get; set; }
    public string Owner { get; set; }

    public Account(string owner)
    {
        Owner = owner;
        Balance = 0;
    }

    public Account(string owner, decimal balance)
    {
        Owner = owner;
        Balance = balance;
    }
}
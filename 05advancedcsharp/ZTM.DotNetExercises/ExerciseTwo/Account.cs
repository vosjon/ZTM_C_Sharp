using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo;

public interface ISecurity
{
    int SecurityID { get; }
}

public static class SecurityExtensions
{
    public static bool HasSecurityID(this ISecurity security)
    {
        return security.SecurityID != 0;
    }
}

public interface IAccount
{
    string DisplayAccountInfo();
    decimal Deposit();
    decimal Withdrawal();
    void ReturnInterest();
}

public class Account
{
    public int Number { get; private set; }
    public decimal Amount { get; set; }

    public Account(int number, decimal amount)
    {
        Number = number;
        Amount = amount;
    }     

}

public class Checking : Account, IAccount, ISecurity
{
    public string Type { get; }
    public decimal Interest { get; }

    public Checking(int number, decimal amount) : base(number, amount)
    {
        Type = "Checking";
        Interest = 1.03m;
    }

    public int SecurityID
    {
        get
        {
            return 6287;
        }
    }
    public string DisplayAccountInfo()
    {
        return $"Account Number: {Number} Balance: {Amount}";
    }
    public decimal Deposit()
    {
        Console.Write("How much do you want to deposit into checking: ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        Amount += depositAmount;
        return Amount;
    }
    public decimal Withdrawal()
    {
        Console.Write("How much do you want to withdrawal from checking: ");
        decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
        Amount -= withdrawalAmount;
        return Amount;
    }
    public void ReturnInterest()
    {
        Console.WriteLine($"Interest for this account is 3%, the value in one year will be {Amount * Interest}");
    }
}

public class Premium : Account, IAccount, ISecurity
{
    public string Type { get; }
    public decimal Interest { get; }

    public Premium(int number, decimal amount) : base(number, amount)
    {
        Type = "Premium";
        Interest = 1.05m;
    }

    public int SecurityID
    {
        get
        {
            return 9312;
        }
    }
    public string DisplayAccountInfo()
    {
        return $"Account Number: {Number} Balance: {Amount}";
    }
    public decimal Deposit()
    {
        Console.Write("How much do you want to deposit into your premium account: ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        Amount += depositAmount;
        return Amount;
    }
    public decimal Withdrawal()
    {
        Console.Write("How much do you want to withdrawal from your premium account: ");
        decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
        Amount -= withdrawalAmount;
        return Amount;
    }
    public void ReturnInterest()
    {
        Console.WriteLine($"Interest for this account is 5%, the value in one year will be {Amount * Interest}");
    }
}
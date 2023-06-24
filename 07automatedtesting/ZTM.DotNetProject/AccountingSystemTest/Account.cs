using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystemTest;

public interface IAccount
{
    string DisplayAccountInfo();
    decimal Deposit(decimal value);
    decimal Withdrawal(decimal value);
    decimal ReturnInterest();
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

    public static decimal TransferToPremium(Checking checking, Premium premium, decimal value)
    {
        checking.Withdrawal(value);
        premium.Deposit(value);
        return premium.Amount;
    }

    public static decimal TransferToChecking(Checking checking, Premium premium, decimal value)
    {
        premium.Withdrawal(value);
        checking.Deposit(value);
        return checking.Amount;
    }

}

public class Checking : Account, IAccount
{
    public string Type { get; }
    public decimal Interest { get; }

    public Checking(int number, decimal amount) : base(number, amount)
    {
        Type = "Checking";
        Interest = 1.05m;
    }
    public string DisplayAccountInfo()
    {
        return $"Account Number: {Number} Balance: {Amount}";
    }
    public decimal Deposit(decimal value)
    {
        Amount += value;
        return Amount;
    }
    public decimal Withdrawal(decimal value)
    {
        Amount -= value;
        return Amount;
    }
    public decimal ReturnInterest()
    {
        return Amount * Interest;
    }
}

public class Premium : Account, IAccount
{
    public string Type { get; }
    public decimal Interest { get; }

    public Premium(int number, decimal amount) : base(number, amount)
    {
        Type = "Premium";
        Interest = 1.06m;
    }
    public string DisplayAccountInfo()
    {
        return $"Account Number: {Number} Balance: {Amount}";
    }
    public decimal Deposit(decimal value)
    {
        Amount += value;
        return Amount;
    }
    public decimal Withdrawal(decimal value)
    {
        Amount -= value;
        return Amount;
    }
    public decimal ReturnInterest()
    {
        return Amount * Interest;
    }
}

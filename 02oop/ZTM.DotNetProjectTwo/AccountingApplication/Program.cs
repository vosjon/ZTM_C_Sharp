using AccountingApplication;

Checking checking = new Checking(100, 200);
Premium premium = new Premium(200, 2000);

Console.WriteLine("Welcome to the Accounting System 1.0");


Console.Write("Please enter your name: ");
string name = Console.ReadLine();

Console.WriteLine($"Welcome, {name}, you currently have two accounts");
Console.WriteLine(checking.DisplayAccountInfo());
Console.WriteLine(premium.DisplayAccountInfo());

bool keepGoing = true;

while (keepGoing)
{
    Console.WriteLine("Main Menu");
    MainMenu();
}

void MainMenu()
{
    Console.WriteLine(@"Please enter the number of the choice you want.
1 - Display account info
2 - Deposit
3 - Withdrawal
4 - Transfer
5 - Interest
6 - Logout");

    Console.Write("Enter the number here: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine(checking.DisplayAccountInfo());
            Console.WriteLine(premium.DisplayAccountInfo());
            break;
        case 2:
            DepositMenu();
            break;
        case 3:
            WithdrawalMenu();
            break;
        case 4:
            TransferMenu();
            break;
        case 5:
            InterestMenu();
            break;
        default:
            keepGoing = false;
            break;
    }
}

void DepositMenu()
{
    Console.WriteLine("Welcome to the deposit menu:");
    Console.WriteLine("Which account would you like to deposit into?");
    Console.Write("Enter 1 for checking, 2 for premium: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        checking.Deposit();
        Console.WriteLine($"Your new balance is: {checking.Amount} \n");
    }
    if (choice == 2)
    {
        premium.Deposit();
        Console.WriteLine($"Your new balance is: {premium.Amount} \n");
    }
        
}

void WithdrawalMenu()
{
    Console.WriteLine("Welcome to the withdrawal menu:");
    Console.WriteLine("Which account would you like to withdrawal from?");
    Console.Write("Enter 1 for checking, 2 for premium: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        checking.Withdrawal();
        Console.WriteLine($"Your new balance is: {checking.Amount}\n");
    }
    if (choice == 2)
    {
        premium.Withdrawal();
        Console.WriteLine($"Your new balance is: {premium.Amount}\n");
    }
}

void TransferMenu()
{
    Console.WriteLine("Welcome to the transfer menu:");
    Console.WriteLine("Here is your current account info:");
    checking.DisplayAccountInfo();
    premium.DisplayAccountInfo();

    Console.WriteLine("\nWhich account would you like to transfer to?");
    Console.Write("Enter 1 to transfer from checking to premium, 2 to transfer from premium to checking: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Transfer(checking, premium);
        Console.WriteLine();
        Console.WriteLine($"New balance - Checking: ${checking.Amount} Premium: ${premium.Amount}\n");
    }
    if (choice == 2)
    {
        Transfer(premium, checking);
        Console.WriteLine();
        Console.WriteLine($"New balance - Premium: ${premium.Amount} Checking: ${checking.Amount}\n");
    }
}

decimal Transfer(Account account1, Account account2)
{
    Console.Write("How much do you want to transfer: ");
    decimal transferAmount = Convert.ToDecimal(Console.ReadLine());
    account1.Amount = account1.Amount - transferAmount;
    account2.Amount += transferAmount;
    return account2.Amount;
}

void InterestMenu()
{
    Console.WriteLine("Welcome to the interest menu:");
    Console.WriteLine("Which account would you like to see the interest on?");
    Console.Write("Enter 1 for checking, 2 for premium: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        checking.ReturnInterest();
    }
    if (choice == 2)
    {
        premium.ReturnInterest();
    }
}



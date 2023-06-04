// Challenge Three:
// Write a program that prints a happy birthday based on user input.
// Ask the user for his age and reply on the console with a happy birthday message mentioning the user input.

DateTime thisDay = DateTime.Today;

Console.WriteLine("Welcome to the Birthday Machine!");
Console.WriteLine("\nLet me ask you a quick question.");
Console.Write("What is your name? Enter here: ");
string name = Console.ReadLine();


bool wantBirthday = true;

while (wantBirthday)
{
    Console.WriteLine($"{name}, is today your birthday? Enter yes or no: ");
    string confirmBirthday = Console.ReadLine().ToLower();

    if (confirmBirthday == "yes")
    {
        HappyBirthday(name);
    }
    else if (confirmBirthday == "no")
    {
        Console.WriteLine("Well that's a bummer. Do you want it to be?");
        Console.Write(@"Enter 'yes' or 'no': ");
        string birthdayChoice = Console.ReadLine();

        if (birthdayChoice == "yes")
        {
            Console.WriteLine("I'm excited to announce that your new birthday is:");
            Console.WriteLine(thisDay.ToString("D"));
            Console.WriteLine();
            HappyBirthday(name);
        }
        else
        {
            Console.WriteLine($"\n{name}, I'm sorry to hear that. Stop by when you want to have a birthday anytime!");
            wantBirthday = false;
        }
    }

    Console.Write(@"Do you want to do this again? 'yes' or 'no': ");
    string finalChoice = Console.ReadLine();
    if (finalChoice == "no")
        wantBirthday = false;
    else
        continue;
}


Console.WriteLine($"Bye {name}!");

void HappyBirthday(string name)
{
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine($"Happy birthday dear {name}!");
    Console.WriteLine("Happy birthday to you!");
}
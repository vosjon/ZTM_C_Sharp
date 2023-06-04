// Final project for the C# Fundamentals section of the Zero to Mastery C#/.NET Bootcamp
// Console Based Calculator

using ConsoleBasedCalculator;

Console.WriteLine("-----------------------Welcome to the Console---------------------");
Calculator.DisplayTitle();

bool keepGoing = true;

while (keepGoing)
{
    Console.WriteLine(@"

Enter the number for the choice you would like to make:

1 - Add
2 - Subtract
3 - Multiply
4 - Divide
");
    Console.Write("Number: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nEnter number 1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nEnter number 2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            int addedNum = Calculator.Add(num1, num2);
            Console.WriteLine(addedNum);
            break;
        case 2:
            int subtractedNum = Calculator.Subtract(num1, num2);
            Console.WriteLine(subtractedNum);
            break;
        case 3:
            int multipliedNum = Calculator.Multiply(num1, num2);
            Console.WriteLine(multipliedNum);
            break;
        case 4:
            double dividedNum = Calculator.Divide((double)num1, (double)num2);
            Console.WriteLine(dividedNum);
            break;
        default:
            Console.WriteLine("You didn't put in the correct number.");
            break;
    }

    Console.Write("Would you like to make another calculation? yes or no: ");
    string again = Console.ReadLine().ToLower();
    if (again == "no")
    {
        keepGoing = false;
    }
    else
    {
        Console.Clear();
        continue;
    }
}

Console.WriteLine("Thanks for using the calculator!");
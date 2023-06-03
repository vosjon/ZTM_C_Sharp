// Challenge Two:
// Extend the previously created solution by only printing a message for values higher than 10.
// Decide what building block suits this problem best.

Console.WriteLine("This loop only displays values greater than 10!");

int count = 0;
while (count != 101)
{
    if (count > 10)
        Console.WriteLine($"Current count: {count}");

    count++;
}
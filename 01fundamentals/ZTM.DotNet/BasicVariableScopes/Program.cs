int age = 31;

if (age >= 27 && age <= 43)
{
    string generation = "Millenial";
    Console.WriteLine($"You're a {generation} because you are {age} years old.");
}
else
{
    string generation = "Unknown";
    Console.WriteLine($"Your generation is: {generation}");
}

// Generation cannot be accessed outside the scope of the if else block.
//Console.WriteLine(generation);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// Here is another example of the variable being out of scope.
// i cannot be accessed outside of the for loop.
//Console.WriteLine(i);
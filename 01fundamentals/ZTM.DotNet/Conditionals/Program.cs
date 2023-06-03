// if
int myLuckyNumber = 16;

if (myLuckyNumber == 16) 
{
    Console.WriteLine("You're lucky!");
}

Console.WriteLine("Conditionals are cool!");

// if - else
if (myLuckyNumber < 16) 
{
    Console.WriteLine("Your lucky number is lower than 16.");
}
else
{
    Console.WriteLine("Your lucky number is 16 or higher.");
}

// if - else if - else
string name = "Jonathan";

if (name == "Jonathan")
{
    Console.WriteLine("Hi, Jonathan!");
}
else if (name == "Cladio")
{
    Console.WriteLine("Hi, Cladio!");
}
else
{
    Console.WriteLine("Hi, nice to meet you!");
}

int version = 4;
string productVersion = version == 4 ? "4.0" : "3.0";
Console.WriteLine(productVersion);
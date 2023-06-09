Console.WriteLine(Math.Divide(6, 3));

int result = Math.Sum(99, 1);
Console.WriteLine(result);

Console.WriteLine(Math.PI);

class Person
{
    public Person(string name)
    {
        Name = name;
    }
    public string Name { get; private set; }

    public void PrintGreeting()
    {
        Console.WriteLine($"Hello, {Name}.");
    }

    public string GetGreeting()
    {
        return $"Hello, {Name}.";
    }
}

public static class Math
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static double PI
    {
        get { return 3.14d; }
    }
    public static double Divide(double a, double b) => a / b;
}
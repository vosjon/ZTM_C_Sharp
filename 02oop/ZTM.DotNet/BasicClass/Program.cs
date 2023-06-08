Person person1 = new Person("Jonathan");
Person person2 = new Person("Trish");

Console.WriteLine(person1.Name);
Console.WriteLine(person2.Name);


class Person
{
    public Person(string name)
    {
        Name = name;
    }
    public string Name { get; private set; }
}
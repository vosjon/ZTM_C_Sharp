Person person1 = new Person("James");
Employee employee2 = new Employee("Jessica", "CEO");

Console.WriteLine($"{person1.Name}: {person1.GetId()}");
Console.WriteLine($"{employee2.Name}: {employee2.GetId()}");
Console.WriteLine($"Employee: {employee2.Name} Salary: {employee2.GetSalary()}");

public interface ISalary
{
    decimal GetSalary();
}

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual string GetId()
    {
        return Name.ToLower();
    }
}

public class Employee : Person, ISalary
{
    public string Role { get; set; }
    public Employee(string name, string role) : base(name)
    {
        Role = role;
    }
    public override string GetId()
    {
        return $"{Role.ToLower()}-{base.GetId()}";
    }

    public decimal GetSalary()
    {
        return 2000;
    }
}
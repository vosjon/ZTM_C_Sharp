Person person = new Person();
Employee employee = new Employee();
Customer customer = new Customer();

person.Greeting();
employee.Greeting();
customer.Greeting();

public class Person
{
    public virtual void Greeting()
    {
        Console.WriteLine("Hi, I'm a regular person.");
    }
}

public class Employee : Person
{
    public override void Greeting()
    {
        Console.WriteLine("Hi, I'm an employee.");
    }
}

public class Customer : Person
{
    public override void Greeting()
    {
        Console.WriteLine("Hi, I'm a customer.");
    }
}
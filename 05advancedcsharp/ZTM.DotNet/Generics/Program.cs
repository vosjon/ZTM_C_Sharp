var cities = new RandomItemGenerator<string>();
cities.Add("Tehachapi");
cities.Add("Palmdale");
cities.Add("Redondo Beach");
cities.Add("Norfolk");

for (int i = 0; i < 10; i++)
{
    var randomCity = cities.Get();
    Console.WriteLine(randomCity);
}

var numbers = new RandomItemGenerator<int>();
numbers.Add(7);
numbers.Add(16);
numbers.Add(21);
numbers.Add(99);

for (int i = 0; i < 10; i++)
{
    var randomNum = numbers.Get();
    Console.WriteLine(randomNum);
}

public class RandomItemGenerator<T>
{
    private readonly List<T> _items = new List<T>();
    private readonly Random _random = new Random();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T Get()
    {
        var index = _random.Next(0, _items.Count);
        return _items[index];
    }
}
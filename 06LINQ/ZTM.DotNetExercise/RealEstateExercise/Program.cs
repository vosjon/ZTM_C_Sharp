var familyHomes = new List<House>
{
    new House(2500m, 1.0082m, "Parent's House"),
    new House(1500m, 1.0027m, "Brother's House"),
    new House(2300m, 1.0090m, "Sister's House"),
    new House(1800m, 1.0080m, "My House")
};

var estimatedPropertyTax = from familyHome in familyHomes
                           select familyHome;

var totalTax = 0m;
foreach (var house in estimatedPropertyTax)
{
    Console.WriteLine($"House: {house.Name} Estimated Property Tax: ${Math.Round(house.SquareFeet * house.TaxPerSize)}");
    totalTax += Math.Round(house.SquareFeet * house.TaxPerSize);
}

Console.WriteLine($"\nTotal tax for all properties is: ${totalTax}");

var largeHouses = familyHomes
    .Where(house => house.SquareFeet >= 2000m)
    .Select(house => house.SquareFeet);

Console.WriteLine("\nHouses over 2000 squarefeet:");
foreach (var house in largeHouses)
{
    Console.WriteLine(house);
}

// FirstOrDefault
var firstHouse = familyHomes.FirstOrDefault();
Console.WriteLine($"\nThe first home in the list is: {firstHouse.Name}");

// Orderby sqrfeet
Console.WriteLine("\nHouses ordered by squarefeet:");
foreach (var house in familyHomes.OrderBy(house => house.SquareFeet))
{
    Console.WriteLine($"{house.Name} - Squarefeet: {house.SquareFeet}");
}

Console.WriteLine("\nHouses ordered by squarefeet descending:");
foreach (var house in familyHomes.OrderByDescending(house => house.SquareFeet))
{
    Console.WriteLine($"{house.Name} - Squarefeet: {house.SquareFeet}");
}

public record House(decimal SquareFeet, decimal TaxPerSize, string Name);

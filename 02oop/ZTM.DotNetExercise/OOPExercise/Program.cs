using System.ComponentModel;

House myHouse = new House(1987, 1800);
House brotherInLawHouse = new House(2020, 3500);

bool sellable = myHouse.CanBeSold();
Console.WriteLine($"The house can be sold returns: {sellable}");

myHouse.SquareFootage();

string yearBuilt = myHouse.GetYearBuilt();
Console.WriteLine(yearBuilt);

bool inLawSellable = brotherInLawHouse.CanBeSold();
Console.WriteLine($"My brother in laws house can be sold returns: {inLawSellable}");

brotherInLawHouse.SquareFootage();

string broYearBuilt = brotherInLawHouse.GetYearBuilt();
Console.WriteLine(broYearBuilt);

public class House
{
    public int Year { get; private set; }
    public int Size { get; private set; }
    public House(int year, int size)
    {
        Year = year;
        Size = size;
    }

    private int HowOld()
    {
        return 2023 - Year;
    }
    
    public bool CanBeSold()
    {
        
        if (HowOld() > 15)
            return true; 
        else
            return false;
    }

    public void SquareFootage()
    {
        Console.WriteLine($"The house is {Size} square feet.");
    }

    public string GetYearBuilt()
    {
        return $"This house was built in {Year}.";
    }
}
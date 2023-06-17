using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingCalendar;

internal class Race
{
    public Race(string name, string date, string track, int number)
    {
        Name = name;
        Date = date;
        Track = track;
        Number = number;
    }
    public string Name { get; set; }
    public string Date { get; set; }
    public string Track { get; set; }
    public int Number { get; set; }

    public void AddDriver(Driver[] drivers, List<Driver> driverList, Stack<Driver> driverStack)
    {
        for (int i = 0; i < 25; i++)
        {
            if (i < 20)
            {
                var driver = driverList[i];
                drivers[i] = driver;
                Console.WriteLine($"Driver: {driver.Name} added to race {Number}");
            }
            else
            {
                var driver = driverList[i];
                driverStack.Push(driver);
                Console.WriteLine($"Driver: {driver.Name} added to the waitlist for race: {Number}");
            }
            
        }
    }

    public void ReplaceDriver(Stack<Driver> driverStack, Driver[] drivers)
    {
        Random random = new Random();
        int stackLength = driverStack.Count;

        for (int i = 0; i < stackLength; i++) 
        {
            var randomIndex = random.Next(0, drivers.Length);
            var removedDriver = drivers[randomIndex];
            Console.WriteLine($"Driver: {removedDriver.Name} cannot make the race.");

            var newDriver = driverStack.Pop();
            drivers[randomIndex] = newDriver;
            Console.WriteLine($"Driver: {newDriver.Name} will be taking the place of {removedDriver.Name}.");
        }
            
    }

    public void RaceAnnouncement(Driver[] drivers)
    {
        Console.WriteLine($"Welcome to the {Name} here at {Track}!");
        Console.WriteLine("Here is todays line up:");

        foreach (var driver in drivers)
        {
            Console.WriteLine($"\t{driver.Name}");
        }
    }
}

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
}

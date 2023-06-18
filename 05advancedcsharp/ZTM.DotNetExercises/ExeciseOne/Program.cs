using ExeciseOne;

Console.WriteLine("Welcome to the Racing Calendar!");

Console.WriteLine("\nHere are the upcoming races:");



Random random = new Random();
Driver winningDriver;

var races = new Queue<Race>();

var race1 = new Race("Beat the Heat", "17-Jun-23", "Rosamond Raceway", 1);
var race2 = new Race("Need for Speed", "24-Jun-23", "Los Angeles Speedway", 2);
var race3 = new Race("Bakersfield Thunder", "17-Jun-23", "Mechanics Bank Arena", 3);
var race4 = new Race("The Semi Final Showdown", "1-Jul-23", "San Diego Speed Track", 4);

races.Enqueue(race1);
races.Enqueue(race2);
races.Enqueue(race3);
races.Enqueue(race4);

var count = 1;
while (races.Count > 0)
{
    var race = races.Dequeue();
    Console.WriteLine($"Race {race.Number}: {race.Name}, Date: {race.Date}, Location: {race.Track}");
    count++;
}

var race1Array = new Driver[20];
var race2Array = new Driver[20];
var race3Array = new Driver[20];
var race4Array = new Driver[20];


var waitlist1 = new Stack<Driver>();
var waitlist2 = new Stack<Driver>();
var waitlist3 = new Stack<Driver>();
var waitlist4 = new Stack<Driver>();

var drivers = new List<Driver>();
var driver1 = new Driver("Chris Johnson");
drivers.Add(driver1);
var driver2 = new Driver("James Cross");
drivers.Add(driver2);
var driver3 = new Driver("Ricky Bobby");
drivers.Add(driver3);
var driver4 = new Driver("Buzz Lightyear");
drivers.Add(driver4);
var driver5 = new Driver("Brian Red");
drivers.Add(driver5);
var driver6 = new Driver("Emilio Estivez");
drivers.Add(driver6);
var driver7 = new Driver("Bobby Locks");
drivers.Add(driver7);
var driver8 = new Driver("Noodles McGee");
drivers.Add(driver8);
var driver9 = new Driver("Gatorade Zero");
drivers.Add(driver9);
var driver10 = new Driver("David Price");
drivers.Add(driver10);
var driver11 = new Driver("Marvin Ditch");
drivers.Add(driver11);
var driver12 = new Driver("Pete David");
drivers.Add(driver12);
var driver13 = new Driver("Sammy Valle");
drivers.Add(driver13);
var driver14 = new Driver("Willie Jones");
drivers.Add(driver14);
var driver15 = new Driver("Hector Lopez");
drivers.Add(driver15);
var driver16 = new Driver("Frank Zed");
drivers.Add(driver16);
var driver17 = new Driver("Nathan Crane");
drivers.Add(driver17);
var driver18 = new Driver("Ingred Platapus");
drivers.Add(driver18);
var driver19 = new Driver("Arthur Rank");
drivers.Add(driver19);
var driver20 = new Driver("Casey Wetback");
drivers.Add(driver20);
var driver21 = new Driver("Vince Savemart");
drivers.Add(driver21);
var driver22 = new Driver("Nigel Smartypants");
drivers.Add(driver22);
var driver23 = new Driver("Allen Vecks");
drivers.Add(driver23);
var driver24 = new Driver("Tony Upcross");
drivers.Add(driver24);
var driver25 = new Driver("Edward Norton");
drivers.Add(driver25);

Console.WriteLine();
race1.AddDriver(race1Array, drivers, waitlist1);

drivers.Reverse();

Console.WriteLine();
race2.AddDriver(race2Array, drivers, waitlist2);

drivers.Reverse();

Console.WriteLine();
race3.AddDriver(race3Array, drivers, waitlist3);

drivers.Reverse();

Console.WriteLine();
race4.AddDriver(race4Array, drivers, waitlist4);

race1.ReplaceDriver(waitlist1, race1Array);
Console.WriteLine();
race1.RaceAnnouncement(race1Array);
winningDriver = race1Array[random.Next(0, race1Array.Length)];
Console.WriteLine(winningDriver.HasWon());

race2.ReplaceDriver(waitlist2, race2Array);
Console.WriteLine();
race2.RaceAnnouncement(race2Array);
winningDriver = race2Array[random.Next(0, race2Array.Length)];
Console.WriteLine(winningDriver.HasWon());

race3.ReplaceDriver(waitlist3, race3Array);
Console.WriteLine();
race3.RaceAnnouncement(race3Array);
winningDriver = race3Array[random.Next(0, race3Array.Length)];
Console.WriteLine(winningDriver.HasWon());


race4.ReplaceDriver(waitlist4, race4Array); 
Console.WriteLine();
race4.RaceAnnouncement(race4Array);
winningDriver = race4Array[random.Next(0, race4Array.Length)];
Console.WriteLine(winningDriver.HasWon());

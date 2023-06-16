using RacingCalendar;

Console.WriteLine("Welcome to the Racing Calendar!");

Console.WriteLine("\nHere are the upcoming races:");

var races = new Queue<Race>();

var race1 = new Race("Beat the Heat", "17-Jun-23", "Rosamond", 1);
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

var race1Array = new Array[20];
var race3Array = new Array[20];
var race4Array = new Array[20];
var race5Array = new Array[20];


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

race1.AddDriver(race1Array, drivers, waitlist1);


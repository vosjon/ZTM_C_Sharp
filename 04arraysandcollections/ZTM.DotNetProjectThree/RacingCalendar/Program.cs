using RacingCalendar;

Console.WriteLine("Welcome to the Racing Calendar!");

Console.WriteLine("\nHere are the upcoming races:");

var races = new Queue<Race>();

var race1 = new Race("Beat the Heat", "17-Jun-23", "Rosamond");
var race2 = new Race("Need for Speed", "24-Jun-23", "Los Angeles Speedway");
var race3 = new Race("Bakersfield Thunder", "17-Jun-23", "Mechanics Bank Arena");
var race4 = new Race("The Semi Final Showdown", "1-Jul-23", "San Diego Speed Track");

races.Enqueue(race1);
races.Enqueue(race2);
races.Enqueue(race3);
races.Enqueue(race4);

var count = 1;
while (races.Count > 0)
{
    var race = races.Dequeue();
    Console.WriteLine($"Race {count}: {race.Name}, Date: {race.Date}, Location: {race.Track}");
    count++;
}
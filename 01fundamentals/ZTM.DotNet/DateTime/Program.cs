using System.Globalization;

DateTime dateOfBirth = new DateTime(1987, 10, 10);
Console.WriteLine(dateOfBirth.DayOfWeek);

// Computed Values
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
DateTime utcNow = DateTime.UtcNow;

// DateTime Parsing
DateTime localDate = DateTime.Parse("10.10.1987");
DateTime usDate = DateTime.Parse("10/10/1987", new CultureInfo("en-US"));

Console.WriteLine($"localDate: {localDate}, usDate: {usDate}");

// DateTime Formatting
Console.WriteLine(dateOfBirth.ToString());
Console.WriteLine(dateOfBirth.ToString(new CultureInfo("en-US")));
Console.WriteLine(dateOfBirth.ToString("yyyy-MM-dd"));
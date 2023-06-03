using System.Globalization;

string luckyNumber = "16";

int parsedLuckyNumber = int.Parse(luckyNumber);
Console.WriteLine(parsedLuckyNumber.GetType());

CultureInfo cultureInfo = new CultureInfo("de-DE");
double tempurature = double.Parse("30,7", cultureInfo);
Console.WriteLine(tempurature);

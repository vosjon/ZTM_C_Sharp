string message = "Hello World";
Console.WriteLine(message);

// empty string
string emptyMessage = string.Empty;

string stringWithDoubleQuote = "This is a string with a double quote: \" ";
Console.WriteLine(stringWithDoubleQuote);

string filepath = "C:\\temp";
Console.WriteLine(filepath);

string filepath2 = @"C:\temp";
Console.WriteLine(filepath2);

// string length
Console.WriteLine(filepath.Length);

// string concatenation
string firstName = "Jonathan";
string lastName = "Vos";

string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

// string interpolation
string fullNameInterpolated = $"{firstName} {lastName}";
Console.WriteLine(fullNameInterpolated);
Console.WriteLine($"The result is: {5 * 7}");

// substrings
string first5Characters = fullName.Substring(0, 3);
Console.WriteLine(first5Characters);
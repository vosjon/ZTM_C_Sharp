var content = "";
try
{
    content = File.ReadAllText("doc.txt");
    Console.WriteLine("The file has been read.");
}
catch (FileNotFoundException exception)
{
    Console.WriteLine($"ERROR: The file '{exception.FileName}' could not be found.");
}
finally
{
    Console.WriteLine($"The content length is: {content.Length}");
}
int? age = 7;

System.Nullable<int> age2 = null;

if (age.HasValue)
{
    Console.WriteLine(age.Value);
}
else
{
    Console.WriteLine("Age is not defined.");
}
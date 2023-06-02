// Implicit conversions: No special sytax, no data loss, no precision loss
// Explicit conversions: Casting, potential data loss, potential precision loss

int age = 31;
float weight = 78.8f;

Console.WriteLine($"age: {age}, weight: {weight}");

// implicit conversions
long myAge = age;

// explicit conversions
int lessWeight = (int)weight; // precision loss
int notMyAge = (int)myAge; // no precision loss

long bigNumber = 1111111111111111111;
int smallerType = (int)bigNumber;

Console.WriteLine(smallerType);
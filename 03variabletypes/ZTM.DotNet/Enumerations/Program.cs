﻿var temperature = new Tempurature(TempuratureUnit.Celcius, 10);

Console.WriteLine((int)TempuratureUnit.Celcius);
Console.WriteLine((int)TempuratureUnit.Fahrenheit);
Console.WriteLine((int)TempuratureUnit.Kelvin);

var temp2 = new Tempurature(TempuratureUnit.Fahrenheit, 100);
Console.WriteLine(temp2.Value);

enum TempuratureUnit
{
    Celcius,
    Fahrenheit,
    Kelvin
}

class Tempurature
{
    public Tempurature(TempuratureUnit unit, decimal value)
    {
        Unit = unit;
        Value = value;
    }
    public TempuratureUnit Unit { get; set; }
    public decimal Value { get; set; }
    public decimal ValueInCelsius 
    {
        get
        {
            if (Unit == TempuratureUnit.Celcius)
            {
                return Value;
            }
            if (Unit == TempuratureUnit.Fahrenheit)
            {
                return (Value - 32) * 5 / 9;
            }
            if (Unit == TempuratureUnit.Kelvin)
            {
                return Value - 273.15m;
            }

            return 0;
        }
    }
}
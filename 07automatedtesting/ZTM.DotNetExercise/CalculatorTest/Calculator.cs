using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest;

public static class Calculator
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public static double Divide(int num1, int num2)
    {
        return num1 / num2;
    }
}

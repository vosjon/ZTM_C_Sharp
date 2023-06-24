using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests;

public class Calculator
{
    public decimal Sum(decimal value1, decimal value2)
    {
        return value1 + value2;
    }
    public decimal Divide(decimal value1, decimal value2)
    {
        return value1 / value2;
    }
}

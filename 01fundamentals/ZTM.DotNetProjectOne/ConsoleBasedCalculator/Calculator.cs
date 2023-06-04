using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedCalculator
{
    public class Calculator
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

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static void DisplayTitle()
        {
            Console.WriteLine(@"

    __   ____  _         __  __ __  _       ____  ______   ___   ____  
   /  ] /    T| T       /  ]|  T  T| T     /    T|      T /   \ |    \ 
  /  / Y  o  || |      /  / |  |  || |    Y  o  ||      |Y     Y|  D  )
 /  /  |     || l___  /  /  |  |  || l___ |     |l_j  l_j|  O  ||    / 
/   \_ |  _  ||     T/   \_ |  :  ||     T|  _  |  |  |  |     ||    \ 
\     ||  |  ||     |\     |l     ||     ||  |  |  |  |  l     !|  .  Y
 \____jl__j__jl_____j \____j \__,_jl_____jl__j__j  l__j   \___/ l__j\_j
                                                                       

");
        }
    }
}

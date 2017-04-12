using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            int maxDenominator = 10000000;
            for (int denominator = 1; denominator <= maxDenominator; denominator += 2)
            {  
                if (denominator % 4 == 1)
                {
                    sum += 1;
                }
                else if (denominator % 4 == 3)
                {
                    sum -= 1;
                }
                else
                {   // remainder of 0 or 2
                    Console.WriteLine("The computer has gone crazy?!");
                }
            }
        }
    }
}

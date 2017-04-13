using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber, quotient, i = 1, j;
            int[] octalNumber = new int[100];
            Console.WriteLine("Enter a Decimal Number :");
            decimalNumber = int.Parse(Console.ReadLine());
            quotient = decimalNumber;
            while (quotient != 0)
            {
                octalNumber[i++] = quotient % 8;
                quotient = quotient / 8;
            }
            Console.Write("Equivalent Octal Number is ");
            for (j = i - 1; j > 0; j--)
                Console.Write(octalNumber[j]);
            Console.Read();
        }
    }
}
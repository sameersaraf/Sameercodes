using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ExtractDigit
    {
        static void Main(string[] args)
        {
            int n=1534785;
            while(n>0)
            {
                int Temp = n % 10;
                Console.Write("  ");
                Console.Write(Temp);
                n = n / 10;

            }
        }
    }
}

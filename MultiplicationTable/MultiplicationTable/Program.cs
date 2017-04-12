using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter an number for it table ");
            n = Int32.Parse(Console.ReadLine());
            for (i = 1; i <= 10; ++i)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
            }
            //Console.ReadKey();
        }
    }
}
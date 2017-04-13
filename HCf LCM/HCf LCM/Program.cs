using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCf_LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, i;
            int hcf = 0;
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            for (i = 1; i <= num1 || i <= num2; ++i)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    hcf = i;
                }
            }
            Console.Write("\nH.C.F  is : ");
            Console.WriteLine(hcf);
            Console.Read();
        }
    }
}
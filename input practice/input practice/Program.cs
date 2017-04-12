using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            float num2;
            //string char1;
            double Doo;
            Console.WriteLine("int");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("flot");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("string");
            string char1 = Console.ReadLine();
            Console.WriteLine("double");
            Doo = Int32.Parse(Console.ReadLine());

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(Doo);
            Console.WriteLine(char1);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str, reversedstring = " ";
            int Length;
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                reversedstring = reversedstring + Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse  String  Is  {0}", reversedstring);
          //  Console.ReadLine();
        }
    }
}
    
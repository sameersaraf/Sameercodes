using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vobles_check
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str;
            Str = Console.ReadLine();
           // Console.WriteLine(Str);
            int total = 0;

            Console.WriteLine("Enter a Sentence");
           

            for (int i = 0; i < Str.Length; i++)
            {
                if (Str.Contains("a") || Str.Contains("e") || Str.Contains("i") || Str.Contains("o") || Str.Contains("u"))
                {
                    total++;
                }
                
            }
            Console.WriteLine("Your total number of vowels is: {0}", total);
            Console.WriteLine("Your total number of vowels is: {0}", total);


            Console.ReadLine();
        }
    }
}

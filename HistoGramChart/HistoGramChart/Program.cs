using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoGramChart
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bins = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90,100 };
            for (int binNum = 0; binNum < bins.Length; binNum++)
            {
                Console.WriteLine(binNum);

                for (int starNum = 0; starNum < bins[binNum]; starNum++) ;
                {
                    Console.Write("*");

                }
                Console.WriteLine(" ");

            }
            int count=0;
            for (int level = 10; level >= 1; level--)
            {

                for (int binNum = 0; binNum < bins.Length; binNum++)
                {
                    if (count >= level)
            {
                Console.Write("*");

            }
                    else
                    {
                        Console.Write(binNum);
                    }

        }
            }
        }
    }
}

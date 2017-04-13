using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
           // int i = Int32.Parse(Console.ReadLine());
            string[] answer = new string[10];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = Console.ReadLine();
                if(answer==8)
                {
                    answer = answer + i;

                }
               
            }
           // answer[i] = Console.WriteLine();
        }
    }
}

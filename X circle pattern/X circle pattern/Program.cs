using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_circle_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column;


            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((row == 0 || row == 6) && column >= 0 && column <= 6) /*||column == 0||column==6||*/|| row+column==6||row-column==0)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}



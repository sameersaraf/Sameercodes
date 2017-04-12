using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            for(int row=1;row<=5;++row)
            {
                for(int col=1;col<=4;++col)
                {
                  if(row%2==0)
                    {
                        Console.Write(" ");
                    }
                   Console.Write("# ");

                        
                }
                Console.WriteLine(" ");

            }

        }
    }
}

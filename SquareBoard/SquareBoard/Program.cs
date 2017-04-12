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
            for(int row=1;row<=size;++row)
            {
                for(int col=1;col<=size;++col)
                {
                    Console.Write(" #");

                }
                Console.WriteLine(" ");

            }

        }
    }
}

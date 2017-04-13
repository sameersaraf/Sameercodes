using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = 54;
            int userGuess = 0;

            while (userGuess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("{0} is too high!", userGuess);
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("{0} is too low!", userGuess);
                }
                else
                {
                    Console.WriteLine("{0} is right! Congratulations.", userGuess);
                }
            }
        }
    }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string secretWord = "sameer";

            char[] secret = new char[secretWord.Length];

            Console.WriteLine("Welcome to Guess game!");

            Console.WriteLine("\nFirst Word.....\n");

            for (int i = 0; i < secret.Length; i++)
            {
                secret[i] = '_';
            }

            for (int i = 0; i < secret.Length; i++)
            {
                Console.Write(secret[i] + " ");
            }

            do
            {
                for (int i = 0; i < secretWord.Length; i++)
                {
                    Console.Write("\n\nPlease enter your guess : ");
                    char input = (Console.ReadLine().ToCharArray()[0]);

                    if (secretWord[i] == input)
                    {
                        secret[i] = input;

                        for (int x = 0; x < secret.Length; x++)
                        {
                            Console.Write(secret[x] + " ");
                        }
                    }
                    else
                    {
                        for (int j = 0; j < secret.Length; j++)
                        {
                            Console.Write(secret[i] + " ");
                        }
                    }
                }
                count++;

            } while (count < 5);
        }
    }
}
        
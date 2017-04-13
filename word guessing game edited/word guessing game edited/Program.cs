﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_guessing_game_edited
{
    class Program
    {
        static void Main(string[] args)
        {
            {


                string secreteWord = "sameer";

                //have a dash array equal to the number of the letters of the secret word
                char[] a = new char[secreteWord.Length];

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = '_';
                }

                // Tell the user the number of letters through the dashes
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + "  ");
                }

                // ask the user to guess
                Console.WriteLine();

                int count = 0;
                do
                {
                    Console.WriteLine("Enter your guess letter");
                    char input = Console.ReadLine().ToCharArray()[0];

                    for (int i = 0; i < secreteWord.Length; i++)
                    {
                        //if the user guessed right, replace the correct dash and display to the user
                        if (secreteWord[i] == input)
                        {
                            count++; //update the count to check when to exit
                            a[i] = input;  //here if the user guess correct, we replace the dash with the input

                            //now we display the dash array after it is modified
                            for (int j = 0; j < a.Length; j++)
                            {
                                Console.Write(a[j] + " ");
                            }
                        }
                    }
                    Console.WriteLine();
                }

                while (count < a.Length);
                Console.WriteLine("You guessed it right");
                Console.ReadLine();
            }
        }
    }
}

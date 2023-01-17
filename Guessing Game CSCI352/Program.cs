using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Guessing_Game_CSCI352
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("I am thinking of a number between 0 and 100");
            int guess_the_number = rand.Next(101);
            Console.WriteLine("Guess the number: ");
            // arbitrary number outside of possible random generated number
            int num_guess = -5;
            string input;
            int guess_count = 0;
            while (num_guess != guess_the_number)
            {
               input = Console.ReadLine();
               if (int.TryParse(input, out num_guess))
               {
                    guess_count++;
                    // correct guess
                    if (num_guess == guess_the_number)
                    {
                        Console.WriteLine("Correct! That took " + guess_count + " tries.");
                    }
                    // guess was too low
                    else if (num_guess < guess_the_number)
                    {
                        Console.WriteLine("Too low. Try again: ");
                    }
                    // too high
                    else
                    {
                        Console.WriteLine("Too high. Try again: ");
                    }
               }
            }
            
            Console.ReadKey();
        }
    }
}

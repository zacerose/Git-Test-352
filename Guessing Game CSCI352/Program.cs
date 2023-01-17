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
            // x is lower bounds, y is upper bounds on guessing game
            int x, y;
            Console.WriteLine("I am thinking of a number from x to y. What should x be? ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("What should y be (please make it larger than x) ");
            y = int.Parse(Console.ReadLine());

            // bounds from x inclusive to y inclusive
            int guess_the_number = rand.Next(x, y + 1);
            Console.WriteLine("I am thinking of a number from " + x + " to " + y + ".");
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

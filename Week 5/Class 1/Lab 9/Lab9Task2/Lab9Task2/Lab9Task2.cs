using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Task2
{
    class Lab9Task2
    {
        static void Main()
        {
        
            Random rand = new Random();
            int number = rand.Next(1, 11);
            int guess;
            Console.WriteLine("Guess a number between 1 and 10\n");
            do
            { 
                Console.Write("\nGuess:");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > 10) Console.WriteLine("\nPlease only enter numbers from 1 to 10");
                if (guess < 1) Console.WriteLine("\nPlease only enter numbers from 1 to 10");
            } while (number != guess) ;

            Console.WriteLine("\nYour guess is correct!");

            Console.ReadLine();
        }
    }
}

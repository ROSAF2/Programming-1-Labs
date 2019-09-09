using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Task3
{
    class Lab9Task3
    {
        static void Main()
        {

            Random rand = new Random();
            int secret = rand.Next(11);
            int guess;

            Console.WriteLine("Guess a number between 0 and 10\n");
            do
            {
                Console.Write("\nGuess:");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > 10) Console.WriteLine("\nPlease only enter numbers from 0 to 10");
                if (guess < 0) Console.WriteLine("\nPlease only enter numbers from 0 to 10");
            } while (secret != guess);

            Console.WriteLine("\nYour guess is correct!");

            Console.ReadLine();
        }
    }
}

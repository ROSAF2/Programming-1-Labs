using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int computer, guess, counter;
            string answer;

            Console.WriteLine("Guesing Game");

            do
            {
                computer = rand.Next(101);
                counter = 0;
                do
                {
                    Console.WriteLine("\nWhat is your guess?: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > computer) Console.WriteLine("Your guess is too High");
                    else if (guess < computer) Console.WriteLine("Your guess is too Low");
                    counter++;

                } while (guess != computer);

                Console.WriteLine("\nYour answer is correct, the number is {0} and it took you {1} attempts", computer, counter);

                Console.Write("\nPlay again? (y/n): ");
                answer = Console.ReadLine();
                answer = answer.ToLower();

            } while (answer[0] == 'y');

            Console.WriteLine("\nThanks for Playing");
            Console.ReadLine();
        }
    }
}

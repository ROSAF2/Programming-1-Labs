using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17Task2
{
    class Lab17Task2
    {
        static void Main()
        {
            Random rand = new Random();
            int randomNumber, userPoints, computerPoints, counter = 1;
            char user, result = ' ';
            string answer;

            Console.WriteLine("For Heads h, for Tails t");

            do
            {
                userPoints = 0;
                computerPoints = 0;

                Console.WriteLine("\n\tRound {0}", counter);

                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine("\nNumber {0}", i);
                    randomNumber = rand.Next(2);
                    if (randomNumber == 0) result = 'h';
                    else if (randomNumber == 1) result = 't';
                    Console.Write("What is your guess?: ");
                    user = Convert.ToChar(Console.ReadLine());
                    if (user == result) userPoints++;
                    else computerPoints++;
                }
                counter++;
                Console.WriteLine("\nThe resutls are: user {0}, computer {1}", userPoints, computerPoints);
                Console.Write("\nPlay again? (y/n): ");
                answer = Console.ReadLine();
                answer = answer.ToLower();

            } while (answer[0] == 'y');

            Console.WriteLine("\nThanks for playing.");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Task5V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int computer, upperLimit = 101, lowerLimit = 0, counter = 0;
            string answer;
            bool condition = true;


            Console.WriteLine("Guessing Game");
            Console.WriteLine("\nPlease think of a number between 1 and 100");
            Console.WriteLine("Press enter when ready: ");
            Console.ReadLine();

            do
            {
                computer = rand.Next(lowerLimit + 1, upperLimit);

                Console.Write("\nIs it {0}? (Y/H/L): ", computer);
                answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer[0] == 'y') condition = false;
                else if (answer[0] == 'h') upperLimit = computer;
                else if (answer[0] == 'l') lowerLimit = computer;
                counter++;
            } while (condition);

            Console.WriteLine("\nThe number is {0}", computer);
            Console.WriteLine("It took {0} attempts", counter);
            Console.ReadLine();
        }
    }
}

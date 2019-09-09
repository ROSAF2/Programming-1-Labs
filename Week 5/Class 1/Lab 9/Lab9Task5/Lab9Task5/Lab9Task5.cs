using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Task5
{
    class Lab9Task5
    {
        static void Main()
        {
            Random rand = new Random();
            int counter = 0, computer = rand.Next(1, 101);
            int lowerLimit=1, upperLimit = 101;
            char user;
            Console.WriteLine("\n\t\t\t\t\t Gessing Game");
            Console.WriteLine("\n\t\tChoose a number between 1 and 100");

            int some = rand.Next(1, 2);
            Console.WriteLine(some);

            do
            {
                Console.WriteLine("\nComputer's guess: {0}", computer);
                counter++;
                Console.Write("For High (Press H), Low (Press L), Correct (Press C): ");
                user = Convert.ToChar(Console.ReadLine());

                if (user == 'H') upperLimit=computer;
                else if (user == 'L') lowerLimit=computer+1;

                computer = rand.Next(lowerLimit,upperLimit);

            } while (user != 'C');


            Console.WriteLine("\nIt took {0} attempts to guess {1}",counter-1,computer);

            Console.ReadLine();
        }
    }
}

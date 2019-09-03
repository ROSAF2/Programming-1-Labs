using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Task4
{
    class Lab9Task4
    {
        static void Main()
        {
            Random rand = new Random();

            int counter=1, computer = rand.Next(1,101);
            int user;
            Console.WriteLine("\n\t\t\t\t\t Gessing Game");


                do
                {
                    Console.Write("\n\t\tWhat's your guess?: ");
                    user = Convert.ToInt32(Console.ReadLine());

                    if (computer < user) Console.WriteLine("\n\t\tYour Guess is High");
                    if (computer > user) Console.WriteLine("\n\t\tYour Guess is Low");

                    Console.WriteLine($"\t\tNumber of attempts {counter}");
                    if (counter == 7) Console.WriteLine("\n\t\tIt's been 7 attempts now, please try to implement a different approach");
                    counter++;

                } while (computer != user);

            Console.WriteLine("\n\t\tYour Guess is correct");

            Console.ReadLine();
        }
    }
}

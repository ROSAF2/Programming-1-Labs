using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab5Task3
{
    class Lab5Task3
    {
        static void Main()
        {
            Random rand = new Random();
            Console.WriteLine("Welcome to Heads and Tails!\n");
            Console.WriteLine("What's your guess?   Press h for Heads and Press t for tails\n");
            char coin;
            char guess = Convert.ToChar(Console.ReadLine());
            int computer= rand.Next(2);
            

            if (computer==0)
            {
                coin ='h';
                Console.WriteLine("\nComputer tossed a Head\n");
            }

            else
                    {
                coin ='t';
                Console.WriteLine("\nComputer tossed a Tail\n");
            }

            Thread.Sleep(1500);

            if (guess == coin) Console.WriteLine("\t\t\tYOU WON!");

            else Console.WriteLine("\t\t\tYOU LOST!");

            Thread.Sleep(4000);
        }
    }
}

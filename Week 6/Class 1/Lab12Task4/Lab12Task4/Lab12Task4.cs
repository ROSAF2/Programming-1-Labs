using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab12Task4
{
    class Lab12Task4
    {
        static void Main()
        {
            Console.WriteLine(" \tGuessing Game");
            int[] randArray = new int[7];
            int[] userArray = new int[7];
            int[] verArray = new int[7];

            Random rand = new Random();
            int i, right=0;

            randArray[6] = rand.Next(2);

            for (i = 0; i < 7; i++)
            {

                randArray[i] = rand.Next(1,11);

            }
            Console.WriteLine(" Memorize these 7 numbers");
            Console.WriteLine("");
            Console.WriteLine(" ____________________________");
            Console.WriteLine($"| {randArray[0]} | {randArray[1]} | {randArray[2]} | {randArray[3]} | {randArray[4]} | {randArray[5]} | {randArray[6]} |");

            Thread.Sleep(7000);
            Console.Clear();
            Console.WriteLine("\n\n\tTime's up!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(" Enter your guesses");

            for (i = 0; i < 7; i++)
            {

                Console.Write($"\nAnswer {i+1}: ");
                userArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(" \t   Results");
            Console.WriteLine("");
            Console.WriteLine(" ____________________________");
            Console.WriteLine($"| {randArray[0]} | {randArray[1]} | {randArray[2]} | {randArray[3]} | {randArray[4]} | {randArray[5]} | {randArray[6]} | Computer");
            Console.WriteLine($"| {userArray[0]} | {userArray[1]} | {userArray[2]} | {userArray[3]} | {userArray[4]} | {userArray[5]} | {userArray[6]} | Your Answer");
            Thread.Sleep(1000);

            for (i = 0; i < 7; i++)
            {

                verArray[i] = randArray[i] - userArray[i];

                if (verArray[i] != 0) right++;

            }
            right = 7 - right;
            Console.WriteLine("");
            Console.WriteLine($" You had {right} correct answers");
           
            Console.ReadLine();

        }
    }
}

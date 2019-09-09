using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Task4
{
    class Lab10Task4
    {
        static void Main()
        {
            Random rand = new Random();

            int value,heads=0,tails=0;

            for (int i = 1; i < 1001; i++)
            {
                value = rand.Next(2);
                if (value == 0) heads++;
                else tails++;
            }

            Console.WriteLine("Result: {0} heads and {1} tails!",heads,tails);

            Console.ReadLine();
        }
    }
}

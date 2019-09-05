using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15Task5
{
    class Lab15Task5
    {
        static void Main()
        {
           
            Console.Write("Please enter a starting letter: ");
            char start = Convert.ToChar(Console.ReadLine());

            Console.Write("\nPlease now enter an ending letter: ");
            char end = Convert.ToChar(Console.ReadLine());

            if (start > end) Console.WriteLine("\nPlease make sure they are in order");
            else Console.WriteLine($"\nfor start value {start} and stop value {end}");

            for (char j = start; j <= end; j++)
            {
                for (char i = start; i <= j; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

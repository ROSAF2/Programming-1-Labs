using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Exam4
{
    class Lab16Exam4
    {
        static void Main()
        {
            int integer, oddSum=0;

            Console.WriteLine("Positive Integers!");

            Console.Write("\nPlease enter a positive integer to evaluate: ");
            integer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (integer%2==0)
            {
                for (int i = 2; i <= integer; i+=2)
                {
                    Console.Write(" {0}",i);
                }
            }

            else
            {
                for (int i = 1; i <= integer; i+=2)
                {
                    oddSum = oddSum + i;
                }
                Console.WriteLine(oddSum);
            }

            Console.ReadLine();
        }
    }
}

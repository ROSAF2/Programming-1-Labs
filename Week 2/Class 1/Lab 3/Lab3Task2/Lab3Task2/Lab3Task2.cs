using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task2
{
    class Lab3Task2
    {
        static void Main()
        {
            //
            string milk;
            int milk1, milk2, milk3, count = 3;
            Double milkAverage;
            //
            Console.WriteLine("Please input three milk prices ");
            

            Console.WriteLine();
            Console.Write("First price: $");
            milk = Console.ReadLine();
            milk1 = Convert.ToInt32(milk);

            Console.WriteLine();
            Console.Write("Second price: $");
            milk = Console.ReadLine();
            milk2 = Convert.ToInt32(milk);

            Console.WriteLine();
            Console.Write("Third price: $");
            milk = Console.ReadLine();
            milk3 = Convert.ToInt32(milk);

            //Operation
            milkAverage = (double)(milk1 + milk2 + milk3) /count;
            Console.WriteLine();
            Console.WriteLine($"The average is: {milkAverage:C}");
            Console.ReadLine();
        }
    }
}

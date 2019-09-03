using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab3Task1
{
    class Lab3Task1
    {
        static void Main()
        {
            //
            string milk;
            Double milk1, milk2, milk3, milkAverage;
            int count = 3;
            //
            Console.WriteLine("Please input three milk prices ");
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.Write("First price: $");
            milk = Console.ReadLine();
            milk1 = Convert.ToDouble(milk);

            Console.WriteLine();
            Console.Write("Second price: $");
            milk = Console.ReadLine();
            milk2 = Convert.ToDouble(milk);

            Console.WriteLine();
            Console.Write("Third price: $");
            milk = Console.ReadLine();
            milk3 = Convert.ToDouble(milk);

            //Operation
            milkAverage = (milk1 + milk2 + milk3) / count;
            Console.WriteLine();
            Console.WriteLine($"The average is: {milkAverage:C}");
            Console.ReadLine();
        }
    }
}

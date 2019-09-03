using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Task_6
{
    class Program
    {
        static void Main()
        {
            string V, T, t;
            int V2, T2, t2, D;

            Console.WriteLine("Please provide the average speed of your trip: ");
            V = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Now the elapsed time: ");
            T = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Finally the non-travel time ");
            t = Console.ReadLine();
            Console.WriteLine();

            V2 = Convert.ToInt32(V);
            T2 = Convert.ToInt32(T);
            t2 = Convert.ToInt32(t);

            D = V2 * (T2 - t2);

            Console.WriteLine("The distance covered on your trip is: " + D + " km");

            Console.Read();
        }
    }
}

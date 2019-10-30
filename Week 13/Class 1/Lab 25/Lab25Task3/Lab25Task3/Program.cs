using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime before = DateTime.Now;

            Console.WriteLine("Input Details: ");
            Console.ReadLine();

            DateTime after = DateTime.Now;

            TimeSpan elapsedTime = after - before;

            Console.WriteLine($"It took you {elapsedTime.TotalSeconds:F2} seconds");

            Console.ReadLine();
        }
    }
}

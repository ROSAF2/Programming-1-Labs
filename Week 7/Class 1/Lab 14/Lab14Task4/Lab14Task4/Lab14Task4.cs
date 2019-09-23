using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Task4
{
    class Lab14Task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a line of text:");
            string line = Console.ReadLine();

            line = line.Replace('e', 'y');

            Console.WriteLine("\n{0}", line);


            Console.ReadLine();
        }
    }
}

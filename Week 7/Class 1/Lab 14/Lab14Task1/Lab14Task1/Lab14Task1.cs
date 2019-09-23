using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Task1
{
    class Lab14Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Please type a line of text: ");
            string line = Console.ReadLine();
            string[] splitLine = line.Split(' ');
            Console.WriteLine();

            foreach (var item in splitLine)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

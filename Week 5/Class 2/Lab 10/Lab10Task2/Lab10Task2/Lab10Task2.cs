using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Task2
{
    class Lab10Task2
    {
        static void Main()
        {
            Console.Write("Please input a starting character: ");
            char start = Convert.ToChar(Console.ReadLine());
            Console.Write("\nPlease input a ending character: ");
            char end = Convert.ToChar(Console.ReadLine());

            for (char i = start; i <= end; i++)
            {
                Console.Write(i);
            }

            Console.WriteLine("\n\nNumbers Version\n");
            Console.Write("Please input a starting character: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease input a ending character: ");
            int second = Convert.ToInt32(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                Console.Write(" {0}",i);
            }
            Console.ReadLine();
        }
    }
}

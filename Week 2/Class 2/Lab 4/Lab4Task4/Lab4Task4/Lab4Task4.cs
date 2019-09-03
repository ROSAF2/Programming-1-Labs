using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task4
{
    class Lab4Task4
    {
        static void Main()
        {
            double number,squared,cubed,forth,fifth;
            Console.WriteLine("Please provide a number:");
            number=double.Parse(Console.ReadLine());

            squared = Math.Pow(number,2);
            cubed = Math.Pow(number,3);
            forth = Math.Pow(number,4);
            fifth = Math.Pow(number,5);

            Console.WriteLine($"\n\t\t {squared:F2}\t\t{cubed:F2}\t\t{forth:F2}\t\t{fifth:F2}");
            Console.ReadLine();
        }
    }
}

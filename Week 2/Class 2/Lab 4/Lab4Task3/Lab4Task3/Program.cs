using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task3
{
    class Program
    {
        static void Main()
        {
            double radius, circumference;

            Console.WriteLine("\nPlease input the radius:");
            radius = double.Parse(Console.ReadLine());

            circumference = 2 * Math.PI * radius;

            Console.WriteLine($"\n\tThe value of the circumference is: {circumference:N2}");
            Console.ReadLine();
        }
    }
}

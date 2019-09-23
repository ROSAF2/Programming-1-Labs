using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19Task3
{
    class Lab19Task3
    {
        public static double Power(double baSe, int exponent) => Math.Pow(baSe, exponent);

        static void Main()
        {
            Console.WriteLine("Powers Calculator");

            Console.Write("\nValue of the base: ");
            double theBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nValue of the exponent: ");
            int theExponent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nThe result is: {Power(theBase, theExponent):F}");
            Console.ReadLine();
        }
    }
}

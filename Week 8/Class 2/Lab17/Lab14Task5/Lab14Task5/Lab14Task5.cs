using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Task5
{
    class Lab14Task5
    {
        static void Main(string[] args)
        {
            int baseNumber, exponent, accumulation = 1;

            Console.Write("Input the base: ");
            baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the exponent ");
            exponent = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= exponent; i++)
            {
                accumulation = accumulation * baseNumber;
            }

            Console.WriteLine("\n{0} to the power of {1} is {2}", baseNumber, exponent, accumulation);

            Console.ReadLine();
        }
    }
}

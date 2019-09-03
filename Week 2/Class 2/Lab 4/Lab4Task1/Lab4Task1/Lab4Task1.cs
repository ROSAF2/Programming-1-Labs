using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task1
{
    class Program
    {
        static void Main()
        {
            const double FACTOR=1.609344;
            double miles,km;

            Console.WriteLine("Please enter your miles: ");

            miles = Convert.ToDouble(Console.ReadLine());

            km = miles * FACTOR;

            Console.WriteLine($"That is {km:F4} kilometres");

            Console.ReadLine();

        }
    }
}

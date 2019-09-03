using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task5
{
    class Lab3Task5
    {
        static void Main()
        {
            double fahr, cel;

            Console.WriteLine("Please Enter your temperature value in Fahrenheit degrees \n");
            fahr = Convert.ToDouble(Console.ReadLine());

            cel=((fahr-32)*5)/9;

            Console.WriteLine($"That is equal to {cel:F2} Celsius degrees");
            Console.ReadLine();
        }
    }
}

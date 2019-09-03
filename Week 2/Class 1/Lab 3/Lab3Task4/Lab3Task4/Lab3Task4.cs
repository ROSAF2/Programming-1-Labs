using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task4
{
    class Lab3Task4
    {
        static void Main()
        {
            string lectura;
            int celcious;
            float fahrenheit;

            Console.WriteLine();
            Console.WriteLine("Input Celcious degrees: ");
            lectura = Console.ReadLine();
            celcious = Convert.ToInt32(lectura);
            Console.WriteLine();

            fahrenheit = (float)(celcious * 9) / 5 + 32;

            Console.WriteLine($"The Fahrenheit equivalent is: {fahrenheit} ");

            Console.ReadLine();




        }
    }
}

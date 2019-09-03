using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task3
{
    class Program
    {
        static void Main()
        {
            string lectura;
            double precio1, precio2, porcentaje;

            Console.WriteLine();
            Console.WriteLine("What's the original price of the item? ");
            lectura=Console.ReadLine();
            precio1 = Convert.ToDouble(lectura);
            Console.WriteLine();
            Console.WriteLine("What's the new price of the item? ");
            lectura = Console.ReadLine();
            precio2 = Convert.ToDouble(lectura);

            porcentaje = (precio2 - precio1) / precio1;

            Console.WriteLine();
            Console.WriteLine($"The increase in price was {porcentaje:P} ");
            Console.ReadLine();

        }
    }
}

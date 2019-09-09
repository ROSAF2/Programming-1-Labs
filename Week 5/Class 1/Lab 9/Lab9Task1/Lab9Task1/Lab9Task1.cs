using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Task1
{
    class Lab9Task1
    {
        static void Main()
        {
            int number;

            do
            {
                Console.Write("Pick a number from 1 to 20: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number < 1 || 20 < number) Console.WriteLine("Please provide a number withn the range.\n");

            } while (number < 1 || 20 < number);

            Console.WriteLine("Your number is: {0}", number);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Task3
{
    class Lab18Task3
    {
        private static double width, height, length, litres;

        public static void Method1()
        {
            Console.Write("\nWidth: ");
            width = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nHeight: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nLength: ");
            length = Convert.ToDouble(Console.ReadLine());
        }

        public static void Method2()
        {
            double area = 2 * width * height + 2 * length * height + length + width;
            litres = area / 10;
        }

        public static void Method3()
        {
            Console.WriteLine("\n For those measurements {0} litre(s) are required", Math.Round(litres));
        }

        static void Main()
        {

            Console.WriteLine("Please enter the dimensions of the room in metres: ");

            Method1();
            Method2();
            Method3();

            Console.ReadLine();
        }
    }
}

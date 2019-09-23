using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19Task1
{
    class Lab19Task1
    {
        public static double Square(double num) => num * num;

        public static double Cube(double num) => num * num * num;

        public static double Double(double num) => 2 * num;

        public static double Half(double num) => num / 2;
        static void Main(string[] args)
        {

            Console.Write("Enter a real number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The square is: " + Square(number));
            Console.WriteLine("The cube is: " + Cube(number));
            Console.WriteLine("The double is: " + Double(number));
            Console.WriteLine("The half is: " + Half(number));

            Console.ReadLine();
        }
    }
}

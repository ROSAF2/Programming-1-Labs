using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19Task4
{
    class Lab19Task4
    {
        public static bool Method(int num1, int num2)
        {
            bool condition = false;
            if (num1 % num2 == 0) condition = true;
            return condition;
        }

        static void Main()
        {
            Console.WriteLine("Please enter two integer values");

            Console.Write("\nInteger 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInteger 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (Method(number1, number2)) Console.WriteLine("\n{0} is a multiple of {1}", number1, number2);
            else Console.WriteLine("\n{0} is not a multiple of {1}", number1, number2);

            Console.ReadLine();
        }
    }
}

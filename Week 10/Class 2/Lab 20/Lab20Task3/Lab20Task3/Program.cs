using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20Task3
{
    class Program
    {
        public static void SwapAlgorithm(ref int num1, ref int num2)
        {
            int swap;
            swap = num1;
            num1 = num2;
            num2 = swap;
        }


        static void Main()
        {
            Console.Write("Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNumber 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNumber 3: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                SwapAlgorithm(ref number1, ref number2);
            }
            if (number2 > number3)
            {
                SwapAlgorithm(ref number2, ref number3);
            }
            if (number1 > number2)
            {
                SwapAlgorithm(ref number1, ref number2);
            }

            Console.WriteLine("\n{0}, {1}, {2}", number1, number2, number3);


            Console.ReadLine();
        }
    }
}

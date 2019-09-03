using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Task_2
{
    class Program
    {
        static void Main()
        {
            string numberOne, numberTwo;
            int number1, number2, sum;

            Console.WriteLine("Please enter two numbers: ");
            numberOne = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Second one: ");
            numberTwo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Thanks!");
            Console.WriteLine();

            number1 = Convert.ToInt32(numberOne);
            number2 = Convert.ToInt32(numberTwo);

            sum = number1 + number2;

            Console.WriteLine(number1 + " + " + number2 + " = " +sum);

            Console.Read();
        }
    }
}

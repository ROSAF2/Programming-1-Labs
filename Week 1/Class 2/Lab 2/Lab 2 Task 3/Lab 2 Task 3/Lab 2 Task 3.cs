using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Task_3
{
    class Program
    {
        static void Main()
        {
            //Variables
            string average;
            int averageI, week, month, year;

            //
            Console.WriteLine("Welcome to this TV calculator!");
            Console.WriteLine();
            Console.WriteLine("How many hours do you usually spend watching TV at night? ");
            average = Console.ReadLine();

            averageI = Convert.ToInt32(average);

            week = 7 * averageI;
            month = 4 * week;
            year = 12 * month;

            Console.WriteLine("That means you spend approximately:");
            Console.WriteLine();
            Console.WriteLine(week + " hours per week");
            Console.WriteLine();
            Console.WriteLine(month + " hours per month");
            Console.WriteLine();
            Console.WriteLine(year + "hours per year");
            Console.Read();

        }
    }
}

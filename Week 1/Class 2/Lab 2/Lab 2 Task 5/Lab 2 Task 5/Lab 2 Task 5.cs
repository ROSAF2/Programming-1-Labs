using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Task_5
{
    class Program
    {
        static void Main()
        {
            string Age;
            int AgeInt, Days, Hours;

            Console.WriteLine("Hi, welcome to this age calculator");
            Console.WriteLine();
            Console.WriteLine("To know how many days or hours you have lived, please type your age:");
            Age = Console.ReadLine();
            AgeInt = Convert.ToInt32(Age);
            Console.WriteLine();

            Days = AgeInt * 365;
            Hours = Days * 24;

            Console.WriteLine("You have lived for " + Days + " days, and " + Hours + " hours");

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task2
{
    class Lab6Task2
    {
        static void Main()
        {
            Console.WriteLine("\tPlease input three numbers.\n");
            Console.Write("\tFirst: ");
            int nu1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tSecond: ");
            int nu2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tThird: ");
            int nu3 = Convert.ToInt32(Console.ReadLine());

            nu1= nu1 % 2;
            nu2 = nu2 % 2;
            nu3 = nu3 % 2;

            if (nu1 !=0 && nu2 != 0 && nu3 != 0) Console.WriteLine("They are all odd numbers");
            else Console.WriteLine("\nThey are not all odd numbers");

            Console.ReadLine();

        }
    }
}

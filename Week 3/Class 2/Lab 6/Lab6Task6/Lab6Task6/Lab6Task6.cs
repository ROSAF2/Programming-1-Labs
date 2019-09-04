using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task6
{
    class Lab6Task6
    {
        static void Main()
        {
            Console.Write("Input an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int even = number % 2;
            int even4 = number % 4;

            if (even == 0)
            {
                if(even4==0) Console.WriteLine("\n\t\tIt's a multiple of 4");
                else Console.WriteLine("\n\t\tIt is an even number");
            }
            else Console.WriteLine("\n\t\tThat's an odd number");
            Console.ReadLine();
        }
    }
}

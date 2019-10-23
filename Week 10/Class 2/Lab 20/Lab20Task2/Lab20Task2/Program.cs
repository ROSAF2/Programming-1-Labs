using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20Task2
{
    class Program
    {
        public static void Swap(ref int num1, ref int num2)
        {
            int swap = num1;
            num1 = num2;
            num2 = swap;
        }

        static void Main()
        {
            int num1 = 1, num2 = 2;

            Console.WriteLine("The original numbers were: {0} and {1}",num1, num2);
            Swap(ref num1,ref num2);
            Console.WriteLine("\nThey are now: {0} and {1}",num1,num2);
            Console.ReadLine();
        }
    }
}

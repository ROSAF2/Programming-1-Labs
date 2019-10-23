using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20Task1
{
    class Lab20Task1
    {
        public static void IncreaseBy15(ref double num)
        {
            num = num + num * 0.15;
        }
        static void Main()
        {
            Console.Write("Enter a number: ");
            double number = Convert.ToInt32(Console.ReadLine());

            IncreaseBy15(ref number);
            Console.WriteLine();
            Console.WriteLine("An increase of % 15 is: "+number);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinMethods
{
    class MaxMinMethods
    {
        public static int Minimum(int[] numbers)
        {
            int minimum = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minimum) minimum = numbers[i];
            }
            return minimum;
        }

        public static int Maximum(int[] numbers)
        {
            int maximum = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (maximum < numbers[i]) maximum = numbers[i];
            }
            return maximum;
        }

        static void Main()
        {
            int[] array = { 7, 2, 4, 2, 4, 8, 3, 1, 6, 9, -8, 5, 0 };

            Console.WriteLine("The minimum is: " + Minimum(array));
            Console.WriteLine("The maximum is: " + Maximum(array));

            Console.ReadLine();
        }
    }
}

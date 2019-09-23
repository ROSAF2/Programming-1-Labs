using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19Task2
{
    class Lab19Task2
    {
        public static int Min(int[] integers)
        {
            int minimum = integers[0];
            for (int i = 0; i < integers.Length; i++)
            {
                minimum = Math.Min(minimum, integers[i]);
            }
            return minimum;
        }

        public static int Max(int[] integers)
        {
            int maximum = integers[0];
            for (int i = 0; i < integers.Length; i++)
            {
                maximum = Math.Max(maximum, integers[i]);
            }
            return maximum;
        }

        static void Main()
        {
            //Creating a user array
            Console.Write("What's the length of your array?: ");
            int ArrayLenght = Convert.ToInt32(Console.ReadLine());
            int[] userArray = new int[ArrayLenght];

            //Filling the array
            Console.WriteLine("Enter the values of your array:");
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.Write("\nSlot {0}: ", i + 1);
                userArray[i] = Convert.ToInt32(Console.ReadLine());
            }


            //Output
            Console.WriteLine("\nThe minimum value of the array is: {0}", Min(userArray));
            Console.WriteLine("\nThe maximum value of the array is: {0}", Max(userArray));

            Console.ReadLine();

        }
    }
}

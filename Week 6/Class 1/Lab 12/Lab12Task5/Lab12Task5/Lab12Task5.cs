using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Task5
{
    class Lab12Task5
    {
        static void Main()
        {

            int[] result = new int[20];
            Console.Write("Please enter the number for the multiplication table you want to see: ");
            int user = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i <result.Length; i++)
            {
                result[i] = user * (i+1);
            }

            for (int i = 0; i < result.Length; i++)
            {
              Console.WriteLine("{0} * {1} = {2}", user, i+1, result[i]);
            }

            Console.ReadLine();

        }
    }
}

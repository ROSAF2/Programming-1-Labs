using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Task2
{
    class Lab12Task2
    {
        static void Main()
        {

            int[] arrayOne = new int[20];

            for (int j=arrayOne.Length-1; 0<=j ; j--)
            {
                arrayOne[j] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            foreach (int item in arrayOne)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}

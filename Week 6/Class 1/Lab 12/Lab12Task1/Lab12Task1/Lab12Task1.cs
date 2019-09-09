using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Task1
{
    class Lab12Task1
    {
        static void Main()
        {
            Random rand = new Random();
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(101);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("SLot {0} = {1}",i+1, array[i]);
            }


            Console.ReadLine();
        }
    }
}

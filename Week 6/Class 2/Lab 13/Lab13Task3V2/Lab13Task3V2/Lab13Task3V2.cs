using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Task3V2
{
    class Lab13Task3V2
    {
        static void Main(string[] args)
        {
            string[] array = new string[10];
            int counter = 0, i = -1;


            do
            {
                i++;
                Console.Write($"\nEnter song {counter + 1}: ");
                array[i] = Console.ReadLine();
                counter++;
            } while ((counter < array.Length) && (array[i] != ""));


            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(array[j]);
            }

            Console.ReadLine();
        }
    }
}

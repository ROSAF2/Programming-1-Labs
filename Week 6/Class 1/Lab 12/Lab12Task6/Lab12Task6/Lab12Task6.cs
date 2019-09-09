using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Task6
{
    class Lab12Task6
    {
        static void Main()
        {
            int[] array = new int[100];
            string input;

            Console.WriteLine("Enter your numbers:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Input {0}: ",i+1);
                input = Console.ReadLine();
                if (input != "stop")
                {
                    array[i] = Convert.ToInt32(input);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("List of numbers entered");
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine("Number {0}",array[j]);
                    }
                    break;
                }
            }
            
            

            Console.ReadLine();
        }
    }
}

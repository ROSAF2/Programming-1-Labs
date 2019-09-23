using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15Task6V3
{
    class Lab15Task6V3
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[6];
            int candidate;
            string answer = "y";


            while (answer[0] == 'y')
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = -1;
                }

                for (int i = 0; i < array.Length; i++)
                {
                    do
                    {
                        candidate = rand.Next(0, 6);
                    } while (array.Contains(candidate));

                    array[i] = candidate;
                }

                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\nKeep going?: ");
                answer = Console.ReadLine();
                Console.Clear();
            }

            Console.ReadLine();
        }
    }
}

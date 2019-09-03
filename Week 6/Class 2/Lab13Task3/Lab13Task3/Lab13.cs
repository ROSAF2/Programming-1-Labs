using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Task3
{
    class Lab13
    {
        static void Main()
        {

            string[] songArray = new string[7];

            Console.WriteLine("Please input your top 100 song titles\n");

            for (int i=0; i<7; i++)
            {
                Console.Write($"Title {i+1}: ");
                songArray[i] = Console.ReadLine();

                if (songArray[i] == "")
                    break;
                Console.WriteLine();
            }



            Console.WriteLine("\nList of songs\n");

            foreach (string j in songArray)
            {
                Console.WriteLine(j);
            }

            Console.ReadLine();

        }
    }
}

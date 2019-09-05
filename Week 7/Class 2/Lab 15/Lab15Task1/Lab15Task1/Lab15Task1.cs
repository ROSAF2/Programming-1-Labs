using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15Task1
{
    class Lab15Task1
    {
        static void Main()
        {

            Console.WriteLine("\t       Recantgle of Stars!");

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

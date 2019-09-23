using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15Task2
{
    class Lab15Task2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 21; i++)
            {
                for (char j = 'A'; j < 'L'; j++)
                {

                    Console.Write("{0}{1} ", j, i);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

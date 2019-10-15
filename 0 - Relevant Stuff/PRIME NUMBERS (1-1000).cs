using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter=0;
            Console.WriteLine("Prime numbers from 1 to 1000");

            for (int i = 1; i < 1000; i++)
            {
                bool check = true;

                for (int j = i - 1; 1 < j; j--)
                {
                    if (i % j == 0) check = false;
                }

                if (check == true)
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }

            Console.WriteLine("\n{0}",counter);
                Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Task1
{
    class Lab13Task1
    {
        static void Main()
        {
            string name;

            Console.Write("Please type your name: ");
            name = Console.ReadLine();

            Console.WriteLine();

            foreach (char i in name)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();


        }
    }
}

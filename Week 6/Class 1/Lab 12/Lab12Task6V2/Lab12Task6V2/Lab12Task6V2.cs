using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Task6V2
{
    class Lab12Task6V2
    {
        static void Main(string[] args)
        {
            string[] array = new string[100];
            bool condition = true;
            int counter = 0;
            string input;

            while (counter < 100 && condition == true)
            {
                Console.Write("\nNumber {0}: ", counter + 1);
                input = Console.ReadLine();
                if (input == "stop") condition = false;
                array[counter] = input;
                counter++;
            }

            for (int i = 0; i < counter - 1; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}

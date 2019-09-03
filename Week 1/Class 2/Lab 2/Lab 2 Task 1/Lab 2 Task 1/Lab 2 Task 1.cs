using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Task_1
{
    class Program
    {
        static void Main()
        {
            //Variable declaration
            int dunedinTime;
            string temp, name;

            //Reading user data
            Console.WriteLine("Who are you? ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("How many years have you lived in Dunedin for? ");
            temp = Console.ReadLine();

            //Converting strnigs into integers
            dunedinTime = Convert.ToInt32(temp);

            //Displaying data
            Console.WriteLine();
            Console.WriteLine("Hello "+name);
            Console.WriteLine();
            Console.WriteLine(dunedinTime+" years is long enough to get a feel for the place");
            Console.WriteLine();
            Console.WriteLine("I hope you like it!");

            Console.Read();
        }
    }
}

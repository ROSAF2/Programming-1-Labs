using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Task2
{
    class Program
    {
        static void Main()
        {

            string message;

            Console.Write("Please input a message: ");
            message = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"The message contains {message.Length} characters\n");


            foreach (char i in message)
            {
                if (i=='e') Console.WriteLine("The most common letter in the English language, 'e' is in your message");

            }

          

            Console.ReadLine();

        }
    }
}

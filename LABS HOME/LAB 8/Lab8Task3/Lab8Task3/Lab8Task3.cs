using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab8Task3
{
    class Lab8Task3
    {
        static void Main()
        {
            Random rand = new Random();
            string[] answerArray = {"Why What?","I don't know. Why?","Really, I don't know.","Please. I don't know","Please stop.","Please! I am begging you to stop.","Because..."};
            int i;

            Console.WriteLine("\t\tWelcome to the \"3-year-old\" simulator! Remastered Edition!\n");

            do
            {

                i = rand.Next(0, 7);
                Console.WriteLine("\nWhy?");
                Console.WriteLine(answerArray[i]);
                Thread.Sleep(1000);
            } while (answerArray[i] != "Because...");

            Console.WriteLine("\nAh, Okay.");

            Console.ReadLine();
        }
    }
}

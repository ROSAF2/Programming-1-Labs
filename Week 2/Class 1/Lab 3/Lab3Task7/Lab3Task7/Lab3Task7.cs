using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task7
{
    class Lab3Task7
    {
        static void Main()
        {
            int nSec,re,hours,min,sec;

            Console.WriteLine("Please enter a number of seconds\n");
            Console.Write("\t");
            nSec = Convert.ToInt32(Console.ReadLine());

            hours = nSec / 3600;
            re = nSec % 3600;
            min = re/60;
            sec = re % 60;

            Console.WriteLine($"\n That is {hours} hours, {min} minutes and {sec} seconds");
            Console.ReadLine();
            

        }
    }
}

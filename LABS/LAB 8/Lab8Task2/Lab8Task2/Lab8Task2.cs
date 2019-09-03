using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab8Task2
{
    class Lab8Task2
    {
        static void Main()
        {
            Random number = new Random();
            int variation = number.Next(1, 6);
            int temperature=13;
            Console.WriteLine($"The tmperature is now: {temperature} degrees");

            while (temperature<=24)
            {
                Thread.Sleep(2000);
                temperature = temperature + variation;
                if (temperature > 24) Console.WriteLine($"Warning the temperature is {temperature} degrees");
                else Console.WriteLine($"The tmperature reached {temperature} degrees");
                
            }



            Console.ReadLine();
        }
    }
}

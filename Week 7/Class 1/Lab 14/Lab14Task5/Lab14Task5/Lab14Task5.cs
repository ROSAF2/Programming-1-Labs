using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Task5
{
    class Lab14Task5
    {
        static void Main(string[] args)
        {
            string[] names = { "Krissi", "Dale", "Bo", "Christopher" };
            double[] wealth = {150000,1000000,5.66,10};

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i].PadRight(15));
                Console.WriteLine(wealth[i].ToString().PadLeft(15));
            }

            Console.ReadLine();
        }
    }
}

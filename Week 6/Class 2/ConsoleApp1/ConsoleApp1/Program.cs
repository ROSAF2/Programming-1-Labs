﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string name = "zebra";

            name = name.Replace('a', 'o');

            Console.WriteLine(name);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.Contains("bra"));
            Console.WriteLine(name.ElementAt(0));
            Console.WriteLine(name.Equals("Zebra"));
            Console.WriteLine(name.IndexOf('a'));
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());

            foreach (char i in name)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Task1
{
    class Lab18Task1
    {
        public static void Method1()
        {
            Console.WriteLine("This is Method 1");
        }
        public static void Method2()
        {
            Method1();
            Console.WriteLine("This is Method 2");
        }
        

        static void Main()
        {
            Method2();

            Console.ReadLine();
        }
    }
}

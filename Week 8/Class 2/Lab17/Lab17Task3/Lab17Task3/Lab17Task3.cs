using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17Task3
{
    class Lab17Task3
    {
        static void Main()
        {
            for (int i = 1990; i < 2051; i++)
            {
                if (i % 100 == 0 && i % 400 == 0) Console.WriteLine(i);
                if (i % 100 == 0) ;
                else if (i % 4 == 0) Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

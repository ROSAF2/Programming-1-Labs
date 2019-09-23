using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb15Task3
{
    class LAb15Task3
    {
        static void Main()
        {
            for (int round = 0; round < 10; round++)
            {
                Console.WriteLine("Round {0}", round+1);
                for (int count = 0; count <= round; count++)
                {
                    Console.Write("{0}  ",count+1);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

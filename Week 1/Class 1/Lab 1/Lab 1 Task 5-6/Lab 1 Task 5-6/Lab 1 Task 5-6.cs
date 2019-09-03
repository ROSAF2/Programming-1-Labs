using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Task_5_6
{
    class Program
    {
        static void Main()
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("********************************************");
            Console.WriteLine("* Francisco Rosas                          *");
            Console.WriteLine("* 203 North Rd, North East Valley, Dunedin *");
            Console.WriteLine("* My favourite subject is Programming 1    *");
            Console.WriteLine("*                                          *");
            Console.WriteLine("********************************************");

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine(2.3456 + 1);
            Console.WriteLine();
            Console.Write("What goes \nup \nmust come \tdown\n");
            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation
{
    class Program
    {
        //Origin (Starting Point)
        public static int x = 0, y = 0;
        public static void Navigation(string answer)
        {
                answer = answer.ToLower();
                switch (answer[0])
                {
                    case 'n':
                        y = y + 1;
                        break;
                    case 'w':
                        x = x - 1;
                        break;
                    case 'e':
                        x = x + 1;
                        break;
                    case 's':
                        y = y - 1;
                        break;
                    default:
                        break;
                }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"These are the current coordinates: ({x},{y})\n");
                Console.Write("Where do you want to go? (north/n, west/w, east/e, south/s): ");
                string answer = Console.ReadLine();
                Navigation(answer);

                if (x == 0 && y == 0)
                {
                    Console.WriteLine("Your are in the D block");
                }
                else if (x==0 && y==1)
                {
                    Console.WriteLine("Your are in the hub");
                }
                else if (x == 0 && y == -1)
                {
                    Console.WriteLine("You are in Manaki");
                }
            }

            Console.ReadLine();
        }
    }
}

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
        public static int x = 0, y = 0, z = 0;
        public static void Navigation(string answer)
        {
                answer = answer.ToLower();
                switch (answer)
                {
                    case "n":
                    case "north":
                    y = y + 1;
                        break;
                    case "w":
                    case "west":
                    x = x - 1;
                        break;
                    case "e":
                    case "east":
                    x = x + 1;
                        break;
                    case "s":
                    case "south":
                    y = y - 1;
                        break;
                case "up":
                 case "u":
                    z = z + 1;
                    break;
                case "down":
                case "d":
                    z = z - 1;
                    break;
            }
        }
        public static void Interaction(string answer)
        {
            answer = answer.ToLower();
            switch (answer)
            {
                case "enter":
                    Console.WriteLine("you enter");
                    break;
                case "inspect":
                case "examine":
                case "look":
                    Console.WriteLine("you are inspecting/looking/examining");
                    break;
                case "get":
                case "take":
                case "grab":
                    Console.WriteLine("now you have it");
                    break;
                case "drop":
                case "discard":
                    Console.WriteLine("now you don't have it");
                    break;
                case "wear":
                    Console.WriteLine("you are wearing...");
                    break;
                case "climb":
                    Console.WriteLine("you climb the wall...");
                    break;
                case "throw":
                    Console.WriteLine("you throw");
                    break;
                case "attack":
                    Console.WriteLine("You attack the zombie");
                    break;
                case "defend":
                    Console.WriteLine("you defend against the zombie...");
                    break;
            }
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine($"These are the current coordinates: ({x},{y},{z})\n");
                Console.Write("Where do you want to go? (north/n, west/w, east/e, south/s): ");
                string answer = Console.ReadLine();
                Navigation(answer);
                Interaction(answer);

                if (x == 0 && y == 0)
                {
                    Console.WriteLine("Your are in the D block");
                }
                else if (x == 0 && y == 1)
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

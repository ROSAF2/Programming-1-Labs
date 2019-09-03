using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task3
{
    class Lab7Task3
    {
        static void Main()
        {
            Char uChoice;
            int number;
            Console.WriteLine("\t\t\tWelcome to Rock Paper Scissors!");
            Console.Write("\n\t      Please input R for rock, P for paper or S for scissors: ");
            uChoice = Convert.ToChar(Console.ReadLine());

            Random rand = new Random();
            number = rand.Next(3);

            switch (number)
            {
                case 0:
                    Console.WriteLine("\n\t\t\t The computer has picked ROCK");
                    switch (uChoice)
                    {
                        case 'R':
                            Console.WriteLine("\n\t\t\t\tIt's a DRAW!");
                            break;
                        case 'P':
                            Console.WriteLine("\n\t\t\t\tYOU WON!");
                            break;
                        case 'S':
                            Console.WriteLine("\n\t\t\t\tYOU LOST!");
                            break;
                    }
                    break;
                ////////////////////////////////////////////////////////////////
                case 1:
                    Console.WriteLine("\n\t\t\t The computer has picked PAPER");
                    switch (uChoice)
                    {
                        case 'R':
                            Console.WriteLine("\n\t\t\t\tYOU LOST!");
                            break;
                        case 'P':
                            Console.WriteLine("\n\t\t\t\tIt's a DRAW!");
                            break;
                        case 'S':
                            Console.WriteLine("\n\t\t\t\tYOU WON!");
                            break;
                    }
                    break;
               ////////////////////////////////////////////////////////////////
                case 2:
                    Console.WriteLine("\n\t\t\t The computer has picked SCISSORS");
                    switch (uChoice)
                    {
                        case 'R':
                             Console.WriteLine("\n\t\t\t\tYOU WON!");
                    break;
                    case 'P':
                             Console.WriteLine("\n\t\t\t\tYOU LOST!");
                    break;
                    case 'S':
                             Console.WriteLine("\n\t\t\t\tIt's a DRAW!");
                    break;
            }
            break;

            }




            Console.ReadLine();
        }
    }
}

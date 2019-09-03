using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task2
{
    class Lab7Task2
    {
        static void Main()
        {
            Char uChoice, cChoice;
            int number;
            Console.WriteLine("\t\tWell come to Rock Paper Scissors!");
            Console.WriteLine("\n\t To play please input R for rock, P for paper or S for scissors");
            uChoice = Convert.ToChar(Console.ReadLine());

            Random rand = new Random();
            number = rand.Next(3);

            switch (number)
            {
                case 0: 
                    Console.WriteLine("\n\t The computer has picked ROCK");
                    switch (uChoice)
                        {
                        case 'R':
                            Console.WriteLine("\n\t\tIt's a DRAW");
                            break;
                        case 'P':
                            Console.WriteLine("\n\t\tYOU WON!");
                            break;
                        case 'S':
                            Console.WriteLine("\n\t\tYOU LOST");
                            break;
                    }
                    break;
                case 1:
                    Console.WriteLine("\n\t The computer has picked PAPER");
                    switch (uChoice)
                    {
                        case 'R':
                            Console.WriteLine("\n\t\tYOU WON");
                            break;
                        case 'P':
                            Console.WriteLine("\n\t\tIt's a DRAW!");
                            break;
                        case 'S':
                            Console.WriteLine("\n\t\tYOU LOST");
                            break;
                    }
                    break;
                case 2:
                    cChoice = 'S';
                    Console.WriteLine("\n\t The computer has picked SCISSORS");
                    break;
            }

            


            Console.ReadLine();
        }
    }
}

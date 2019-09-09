using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rugby_Game
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int team1 = rand.Next(8), team2 = rand.Next(8);

            Console.WriteLine("\nTeam 1 has the ball!");

            switch (team1)
            {
                case 0:
                case 1:
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("Tackled lost the ball");
                    team1 = 0;
                    break;
                case 3:
                    Console.WriteLine("Kicked a goal");
                    break;
                case 5:
                    Console.WriteLine("scored a try");
                    break;
                case 7:
                    Console.WriteLine("scored a try and converted");
                    break;
            }
            Console.WriteLine("\nTeam 2 has the ball!");
            switch (team2)
            {
                case 0:
                case 1:
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("Tackled lost the ball");
                    team2 = 0;
                    break;
                case 3:
                    Console.WriteLine("Kicked a goal");
                    break;
                case 5:
                    Console.WriteLine("scored a try");
                    break;
                case 7:
                    Console.WriteLine("scored a try and converted");
                    break;
            }

            Console.WriteLine("\nTeam one scored {0} points, and team two scored {1}",team1,team2);

            if (team1 > team2) Console.WriteLine("\nCongratulations to team one!");
            else if(team1<team2)Console.WriteLine("\nCongratulations to team two!");
            else Console.WriteLine("The match is a Draw");


            Console.ReadLine();

        }
    }
}

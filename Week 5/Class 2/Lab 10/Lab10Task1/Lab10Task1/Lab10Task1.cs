using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab10Task1
{
    class Lab10Task1
    {
        static void Main()
        {
            Random rand = new Random();
            int team1, team2, team1Total=0, team2Total=0, matchOne=0, matchTwo=0;

            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("\nTeam 1 has the ball");

                team1 = rand.Next(8);
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
                        Console.WriteLine("Scored a try");
                        break;

                    case 7:
                        Console.WriteLine("Scored a try and converted");
                        break;
                } //end of the switch

                team1Total = team1Total + team1;
                Thread.Sleep(500);

                team2 = rand.Next(8);
                Console.WriteLine();
                Console.WriteLine("\n\t\t\t\t\tTeam 2 has the ball");
                
                switch (team2)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 4:
                    case 6:
                        Console.WriteLine("\t\t\t\t\tTackled lost the ball");
                        team2 = 0;
                        break;

                    case 3:
                        Console.WriteLine("\t\t\t\t\tKicked a goal");
                        break;

                    case 5:
                        Console.WriteLine("\t\t\t\t\tScored a try");
                        break;

                    case 7:
                        Console.WriteLine("\t\t\t\t\tScored a try and converted");
                        break;
                } //end of the switch

                team2Total = team2Total + team2;

                

            }


          if (team1Total == team2Total)
            {
                Console.WriteLine("It's Draw");
                Console.WriteLine($"At the end of 10 plays the scores are {team1Total} : {team2Total}");
            }
            else
            {
                if (team1Total > team2Total)
                {
                    Console.WriteLine("Team 1 Won");
                    Console.WriteLine($"At the end of 10 plays the scores are {team1Total} : {team2Total}");
                }
                else 
                    {
                    Console.WriteLine("Team 1 Lost");
                    Console.WriteLine($"At the end of 10 plays the scores are {team1Total} : {team2Total}");
                }
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task4
{
    class Lab6Task4
    {
        static void Main()
        {
            
            Random rand= new Random();
            Console.WriteLine("\n\t\t    Match Results: \n");
            int team1=rand.Next(2), team2=rand.Next(2);
            //int team1 = int.Parse(Console.ReadLine()), team2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\t\t    The score was:\n");
            Console.WriteLine($"\t\t\t{team1} : {team2}");
            Console.WriteLine($"\t    Team you hate | Your Team");

            if (team2>=team1)
            {
                if(team2>team1) Console.WriteLine("\n\t\t    Your Team Won!");
                else Console.WriteLine("\n\t\t     It's a Draw");
            }

            else
            {
                Console.WriteLine("\n\t\t    Your Team Lost...");
            }

            Console.ReadLine();

        }
    }
}

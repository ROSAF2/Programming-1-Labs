using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab8Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string answer;
            int coastDistance, sharkDistance, UserToCoast, sharkToUser;

            do

            {
                UserToCoast = 60;
                sharkToUser = 60;


                do
                {
                    coastDistance = rand.Next(31);
                    sharkDistance = rand.Next(31);

                    UserToCoast = UserToCoast - coastDistance;
                    sharkToUser = sharkToUser - sharkDistance;

                    Console.WriteLine("\nThe User is {0} metres from the Shore", UserToCoast);
                    Console.WriteLine("The Shark is {0} metres from the User", sharkToUser);

                    Thread.Sleep(1000);

                } while ((UserToCoast > 0) && (sharkToUser > 0));

                if (UserToCoast <= 0) Console.WriteLine("\nThe User is safe");
                else Console.WriteLine("\nThe User was eaten");

                Console.WriteLine("Play again? Y/N: ");
                answer = Console.ReadLine();
                answer = answer.ToLower();
            } while (answer[0] == 'y');

            Console.ReadLine();
        }
    }
}

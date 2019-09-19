using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTestV2
{
    class PracticeTestV2
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int cardNumber, cardValue = 0;
            string answer;

            Console.WriteLine("Gambling Card Game");
            Console.Write("\n What is your age?: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (age > 18)
            {

                do
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        cardNumber = rand.Next(1, 14);
                        Console.WriteLine("Round {0}, card number {1}", i, cardNumber);
                        switch (cardNumber)
                        {
                            case 1:
                                cardValue += 20;
                                break;
                            case 11:
                            case 12:
                            case 13:
                                cardValue += 10;
                                break;
                            default:
                                cardValue -= cardNumber;
                                break;
                        }
                    }
                    Console.WriteLine("\n Your grand total is $ {0} dollars", cardValue);
                    Console.Write("\n Play again? (y/n): ");
                    answer = Console.ReadLine();
                    Console.WriteLine();
                    answer = answer.ToLower();
                } while (answer[0] == 'y');


            }
            else
            {
                Console.WriteLine("Bye bye, you are too young!");
            }

            Console.WriteLine("\nEnd of the game");
            Console.ReadLine();
        }
    }
}

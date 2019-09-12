using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranciscoRosas
{
    class FranciscoRosas
    {
        static void Main()
        {
             /* Francisco Rosas 
              * Practice Test
              * Card Game: 
              *   Create a one-player gambling game 
              *   using appropiate looping and conditional 
              *   structures.
             */
            Random rand = new Random();
            int age, randomNumber, cardValue, cardTotal=0;
            string answer;

            Console.Write("\t\tWelcome to this card game, please provide your age: ");
            age =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (age > 18)
            {
                do
                {
                    for (int i = 0; i < 5; i++)
                    {
                        randomNumber = rand.Next(1, 14);
                        cardValue = 0; //Resets Card Value

                        Console.WriteLine("Round {0}: Card Number {1}", i + 1, randomNumber); //Showing Card Number

                        switch (randomNumber)
                        {
                            case 1:
                                cardValue = 20;
                                break;
                            case 11:
                            case 12:
                            case 13:
                                cardValue = 10;
                                break;
                            default:
                                cardValue = -randomNumber;
                                break;
                        }
                        cardTotal = cardTotal + cardValue;  //Accumulate Total Card Value
                    }

                    Console.WriteLine($"\n\t\t\tYour grant Total is: ${cardTotal:F2}");

                    Console.Write("\n\t\t\tDo you want to play again?: ");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();  // Convert the answer to lower case to be able to use it as a constant whithin the condition.
                } while (answer[0]=='y'); // Making sure the answer is a word starting with the letter 'y'.

                Console.WriteLine("\n\t\t\tThanks for playing!");
            }

            else
            {
                Console.WriteLine("\nGood bye you are too young to play");
            }

            Console.ReadLine();
        }
    }
}

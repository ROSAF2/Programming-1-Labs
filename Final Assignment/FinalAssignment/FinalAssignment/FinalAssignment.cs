using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace FinalAssignment
{
    public struct ContestantDetails
    {
        public string lastName;
        public string firstName;
        public string interest;
        //Added Rank field to sort the names according to their ranking later
        public int rank;
    }
    class FinalAssignment
    {
        //Global Random instructions
        private static Random rand = new Random();
        public static void ReadingNamesFromFile(ref ContestantDetails[] array, string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            for (int i = 0; i < array.Length; i++)
            {
                array[i].firstName = sr.ReadLine();
                array[i].lastName = sr.ReadLine();
                array[i].interest = sr.ReadLine();
            }
            sr.Close();
        }
        public static void WritingToFile(ref ContestantDetails[] array, string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath);
            for (int i = 0; i < array.Length; i++)
            {
                sw.WriteLine(array[i].firstName);
                sw.WriteLine(array[i].lastName);
                sw.WriteLine(array[i].interest);
            }
            sw.Close();
        }
        public static void PlayerUpdate(ContestantDetails[] array, string filePath)
        {
            bool condition = true;
            while (condition)
            {
                Console.Clear();
                Console.Write("Write the name of the player or press 0 to return to the menu: ");
                string answer = Console.ReadLine();
                if (answer != "0")
                {
                    string[] answerSplit = answer.Split(' ');
                    ReadingNamesFromFile(ref array,filePath);
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Clear();
                        if (array[i].firstName.ToLower() == answerSplit[0].ToLower())
                        {
                            //This condition avoids going through the first "if" after this for-loop
                            condition = false;
                            Console.WriteLine($"Player found: {array[i].firstName} {array[i].lastName}");
                            Console.WriteLine($"Current interest: {array[i].interest}");

                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            Console.WriteLine("\nIs this the player you are looking for? (Y/N): ");
                            string answer2 = Console.ReadLine();
                            answer2 = answer2.ToLower();
                            //If the name is what the user is looking for
                            if (answer2[0] == 'y')
                            {
                                Console.Write("\nWrite the new interest: ");
                                array[i].interest = Console.ReadLine();
                                //Calling WritingToFile method to update the list
                                WritingToFile(array,filePath);
                                Console.WriteLine("\nInterest updated");
                                Console.ReadLine();
                                //This break, breaks the for loop to stop iterating through other people with the same name
                                break;
                            }
                            //If the name is not what the user is looking for
                            else
                            {
                                //The condition is set back to true in order to enter to the next conditional down below
                                condition = true;
                            }
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        }
                    }
                    // This condition is true when the name is not in the database
                    if (condition)
                    {
                        Console.Clear();
                        Console.WriteLine("The name is not in the database, do you want to try again? (Y/N): ");
                        string answer3 = Console.ReadLine();
                        answer3 = answer3.ToLower();
                        if (answer3[0] == 'n')
                        {
                            // This condition breaks the while-loop and makes it go back to the menu
                            condition = false;
                        }
                    }
                }
                else
                {
                    // This condition breaks the loop and makes it go back to the menu because answer == "0"
                    condition = false;
                }
            }
        }
        public static int[] LottoSelection()
        {
            int[] randomNumber = new int[10];
            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = rand.Next(0, 30);
                for (int j = 0; j < i; j++)
                {
                    if (randomNumber[j] == randomNumber[i])
                    {
                        randomNumber[i] = rand.Next(0, 30);
                        //This restarts the loop to evaluate all the previous numbers again
                        j = -1;
                    }
                }
            }
            return randomNumber;
        }

        static void Main()
        {
            //Creating an array of the type "ContestantDetails" with 30 slots
            ContestantDetails[] arrayOfContestants = new ContestantDetails[30];
            //Path where the file is
            string filePath = "millionaire.txt";
            int input;
            do
            {
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\t     Who Wants to Be a Millionaire?");
                Console.WriteLine("\n\n\n\t\t\t\t\t\t\tNew Game");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 1]");
                Console.WriteLine("\n\t\t\t\t\t\t\t Options");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 2]");
                Console.WriteLine("\n\t\t\t\t\t\t\t Credits");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 3]");
                Console.WriteLine("\n\t\t\t\t\t\t\tQuit Game");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 0]");
                Console.Write("\n\t\t\t\t\t\t\t:");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Clear();

                        //This method fills the previosuly created array with the information from the given file
                        ReadingNamesFromFile(ref arrayOfContestants,filePath);

                        //This is the bubble sort algorith to sort the names in alphabetical order
                        for (int i = 0; i < arrayOfContestants.Length - 1; i++)
                        {
                            for (int j = 0; j < arrayOfContestants.Length - 1; j++)
                            {
                                if (arrayOfContestants[j + 1].lastName.CompareTo(arrayOfContestants[j].lastName) < 0)
                                {
                                    ContestantDetails swap = arrayOfContestants[j];
                                    arrayOfContestants[j] = arrayOfContestants[j + 1];
                                    arrayOfContestants[j + 1] = swap;
                                }
                            }
                        }

                        //This loop displays the contents of the array
                        for (int i = 0; i < arrayOfContestants.Length; i++)
                        {
                            Console.WriteLine(arrayOfContestants[i].lastName.PadRight(25) + arrayOfContestants[i].firstName.PadRight(15) + arrayOfContestants[i].interest.PadRight(15));
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        //This method asks for a player in order to update their interest
                        PlayerUpdate(arrayOfContestants,filePath);
                        Console.Clear();
                        break;
                    case 3:
                        break;
                }

            } while (input != 0);

            Console.WriteLine("\nAre you sure you want to exit the game?");
            Console.WriteLine("Exiting the program");

            Console.ReadLine();
        }
    }
}


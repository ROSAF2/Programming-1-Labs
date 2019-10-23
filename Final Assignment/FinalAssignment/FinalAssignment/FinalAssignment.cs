using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalAssignment
{
    public struct ContestantInfo
    {
        public string lastName;
        public string firstName;
        public string interest;
    }
    class FinalAssignment
    {
        private static Random rand = new Random();
        public static void ReadingFromFile(ContestantInfo[] array)
        {
            StreamReader sr = new StreamReader("millionaire.txt");
            for (int i = 0; i < array.Length; i++)
            {
                array[i].firstName = sr.ReadLine();
                array[i].lastName = sr.ReadLine();
                array[i].interest = sr.ReadLine();
            }
            sr.Close();
        }
        public static void WritingToFile(ContestantInfo[] array)
        {
            StreamWriter sw = new StreamWriter("millionaire.txt");
            for (int i = 0; i < array.Length; i++)
            {
                sw.WriteLine(array[i].firstName);
                sw.WriteLine(array[i].lastName);
                sw.WriteLine(array[i].interest);
            }
            sw.Close();
        }
        public static void PlayerUpdate(ContestantInfo[] array)
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
                    ReadingFromFile(array);
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
                                WritingToFile(array);
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
                //Console.WriteLine($"{i + 1}.- {RandomNumber[i]}");
            }
            return randomNumber;
        }
        public static void Method4()
        {
            Console.Clear();
            Console.WriteLine("This is Method 4");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Invalid()
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid option.");
            Console.ReadLine();
            Console.Clear();
        }

        static void Main()
        {
            int input;
            do
            {
                ContestantInfo[] array = new ContestantInfo[30];

                Console.WriteLine("The menu options are: ");
                Console.Write("\n1".PadRight(10)); Console.Write("List all the contestants");
                Console.Write("\n2".PadRight(10)); Console.Write("Update player's interest");
                Console.Write("\n3".PadRight(10)); Console.Write("lotto problem");
                Console.Write("\n4".PadRight(10)); Console.Write("Randomly selesc");
                Console.Write("\n0".PadRight(10)); Console.Write("Exit menu system");

                Console.Write("\n\nSelect an option: ");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Clear();
                        ReadingFromFile(array);
                        //This loop displays the contents of the array
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.WriteLine(array[i].lastName.PadRight(20) + array[i].firstName.PadRight(15) + array[i].interest.PadRight(15));
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        //This method asks for a player in order to update their interest
                        PlayerUpdate(array);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        ReadingFromFile(array);
                        //Calling an array of random numbers between 0 to 29 without repetition
                        int[] randomNumber = LottoSelection();
                        //Displaying the participant whose index matches the random number previously generated
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"{i + 1}.-".PadRight(5) + $"{array[randomNumber[i]].firstName} {array[randomNumber[i]].lastName}");
                        }

                        //A random number from 0 to 9 in order to choose a random contestant
                        int playerNumber = rand.Next(0, 10);
                        //The name of the player is: 
                        Console.Write("\nThe player will be: ");
                        Console.WriteLine($"{array[randomNumber[playerNumber]].firstName} {array[randomNumber[playerNumber]].lastName}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Method4();


                        break;
                    default:
                        Invalid();
                        break;
                }

            } while (input != 0);

            Console.WriteLine("\nExiting the program");

            Console.ReadLine();
        }
    }
}


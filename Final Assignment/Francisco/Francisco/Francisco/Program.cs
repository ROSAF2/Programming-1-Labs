using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApp15
{
    public struct ContestantDetails
    {
        public string lastName;
        public string firstName;
        public string interest;
        //Added Rank field to sort the names according to their ranking later
        public int rank; //arrayOfContestants[randomNumber[indexOfTheLowestValue]].rank
    }
    public struct QuestionSctructure
    {
        public string questionPhrase;
        public string correctAnswer;
        public string incorrectAnswer1;
        public string incorrectAnswer2;
        public string incorrectAnswer3;
    }
    public struct AnswerStruct
    {
        public char letter;
        public string answer;
        public int percentage;
    }
    class Program
    {
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
        public static void ReadingQuestionsFromFile(ref QuestionSctructure[] set, string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            for (int i = 0; i < set.Length; i++)
            {
                set[i].questionPhrase = sr.ReadLine();
                set[i].correctAnswer = sr.ReadLine();
                set[i].incorrectAnswer1 = sr.ReadLine();
                set[i].incorrectAnswer2 = sr.ReadLine();
                set[i].incorrectAnswer3 = sr.ReadLine();
            }
            sr.Close();
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
        public static void SwapAlgorithmAnswerStruct(ref AnswerStruct[] array)
        {
            for (int j = 0; j < 10; j++)
            {
                int num1 = rand.Next(0, 4);
                int num2 = rand.Next(0, 4);

                AnswerStruct swap = array[num1];
                array[num1] = array[num2];
                array[num2] = swap;
            }
        }
        public static void SwapAlgorithmInt(ref int[] array)
        {
            if (array.Length == 4)
            {
                for (int j = 0; j < 10; j++)
                {
                    int num1 = rand.Next(0, 4);
                    int num2 = rand.Next(0, 4);

                    int swap = array[num1];
                    array[num1] = array[num2];
                    array[num2] = swap;
                }
            }
            else if (array.Length == 2)
            {
                for (int j = 0; j < 5; j++)
                {
                    int num1 = rand.Next(0, 2);
                    int num2 = rand.Next(0, 2);

                    int swap = array[num1];
                    array[num1] = array[num2];
                    array[num2] = swap;
                }
            }
        }
        public static void FillingWithABCD(ref AnswerStruct[] array)
        {
            char letters = 'A';
            for (int j = 0; j < array.Length; j++)
            {
                array[j].letter = letters;
                letters++;
            }
        }
        public static void AnsweredIncorrectly(int i, int[] moneyPrizes, string correctAnswer)
        {
            Console.WriteLine($"\n\t\t\t       You just lost ${moneyPrizes[i]:N0}, the correct answer was: \"{correctAnswer}\"");
            Console.Write("\n\t\t\t\t\t\t\t  ...");
            if (i <= 5)
            {
                Console.ReadLine();
                Console.WriteLine("\n\t\t\t   As you didn't reach a Safe Heaven, you're going home with empty hands");
                Console.Write("\n\t\t\t\t\t\t\t  ...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\t\t\t\t\t\tBetter luck next time!");
                Console.Write("\n\t\t\t\t\t\t\t  ...");
                Console.ReadLine();
            }
            else if (i <= 10)
            {
                Console.ReadLine();
                Console.WriteLine("\n\t\t\t\t\t    However you still have your $1,000!");
                Console.Write("\n\t\t\t\t\t\t\t  ...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\t\t\t\t\tThanks for playing, enjoy your $1,000!");
                Console.Write("\n\t\t\t\t\t\t\t  ...");
                Console.ReadLine();
            }
            else if (i <= 15)
            {
                Console.ReadLine();
                Console.WriteLine("\n\t\t\t\t\t  However you still have your $32,000!");
                Console.Write("\n\t\t\t\t\t\t\t  ...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\t\t\t\t\tThanks for playing, enjoy your $32,000!");
                Console.Write("\n\t\t\t\t\t\t\t  ...");
                Console.ReadLine();
            }
        } //This method is executed if the player has answered incorrectly
        public static void RefreshScreen(ref int i, ref bool whileCondition)
        {
            i--;
            whileCondition = false;
            Console.Clear();
        }
        public static void NewGame()
        {
            //Creating an array to store all the money prizes
            int[] moneyPrizes = new int[] { 0, 100, 200, 300, 500, 1000, 2000, 4000, 8000, 16000, 32000, 64000, 125000, 250000, 500000, 1000000 };
            //These variables are used throughout this Method
            bool fiftyBoolean = true, audienceBoolean = true, phoneBoolean = true, backToMenu = false, millionairePossibility;
            string fifty = "Available", audience = "Available", phone = "Available", input;
            ///////////////////////////////////////////////////////////////////////////////////////////////////

            //START OF THE GAME <=============================================================================================================================
            //Creating an array of the type "ContestantDetails" with 30 slots  
            ContestantDetails[] arrayOfContestants = new ContestantDetails[30]; //arrayOfContestants is used in list players method, and updatePlayer
            //Path where the file is
            string filePath = "millionaire.txt";  //This variable is used by other methods too
            ReadingNamesFromFile(ref arrayOfContestants, filePath);

            //SELECTION OF 10 DIFFERENT RANDOM PLAYERS
            //Creating an array to hold 10 random numbers between 0 to 29 without repetition using the LottoSelection() method
            int[] randomNumber = LottoSelection();
            Console.WriteLine("\n\n\n\n\t\t\t\t      And the ten finalists for today's show are:\n\n");
            //Displaying the participant whose index matches the number inside the randomNumber array previously filled with the lottoSelection() method
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\t\t\t\t\t\t{i + 1}.-".PadRight(5) + $"{arrayOfContestants[randomNumber[i]].firstName} {arrayOfContestants[randomNumber[i]].lastName}");
            }
            Console.Write("\n\n\t\t\t\t\t\t\t  ...");
            Console.ReadLine();
            Console.Write("\n\t       Now all we have to do is find out which of our ten contestants will be our player for today");
            Console.Write("\n\n\t\t\t\t\t\t\t  ...");
            Console.ReadLine();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //SELECTION OF THE SET OF QUESTIONS TO PLAY THROUGHOUT THE GAME
            //Creating an array of 16 slots that will be filled with questions from the text files
            QuestionSctructure[] set = new QuestionSctructure[16];
            //Creating an array that contains the name of 10 different text files
            string[] textFileNames = new string[10];
            for (int i = 0; i < textFileNames.Length; i++)
            {
                textFileNames[i] = "Set.txt".Insert(3, i.ToString());
            }
            //Filling the data from a random file into the "set" array
            ReadingQuestionsFromFile(ref set, textFileNames[rand.Next(0, 10)]);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //QUESTION 0
            //Creating an array of 4 slots of the type AnswerStruct to hold all the answers from question number 0
            AnswerStruct[] swappedABCD = new AnswerStruct[4];
            swappedABCD[0].answer = set[0].correctAnswer;
            swappedABCD[1].answer = set[0].incorrectAnswer1;
            swappedABCD[2].answer = set[0].incorrectAnswer2;
            swappedABCD[3].answer = set[0].incorrectAnswer3;

            //Applying the swap algorithm to swappedABC
            SwapAlgorithmAnswerStruct(ref swappedABCD);

            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t ...\n\n");
            Console.Write("\t\tWhoever answers the next question first, will have the chance to win $1,000,000 NZD!!");
            Console.Write("\n\n\t\t\t\t\t\t\t ...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\n\n      --------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"\n\tQuestion.-\n");
            Console.WriteLine($"\t" + set[0].questionPhrase);
            Console.WriteLine("\n");
            Console.WriteLine($"\t\t" + ("A: " + swappedABCD[0].answer.PadRight(40)) + ("B: " + swappedABCD[1].answer.PadRight(40)));
            Console.WriteLine($"\t\t" + ("C: " + swappedABCD[2].answer.PadRight(40)) + ("D: " + swappedABCD[3].answer.PadRight(40)));
            Console.WriteLine("\n");
            Console.Write("      --------------------------------------------------------------------------------------------------------");
            Console.Write("\n\t\t\t\t\t\t\t  ...");
            Thread.Sleep(1000);
            Console.WriteLine("\n\n\t\t\t\t\t    Time's up!, the right answer is:\n");

            //Filling the letter field of the Struct AnswerStruct with A, B, C, D in order (For question 0)
            FillingWithABCD(ref swappedABCD);

            //Creating an array of 4 slots that contains the answers in the right order
            string[] question0Ordered = new string[4];
            question0Ordered[0] = set[0].correctAnswer;
            question0Ordered[1] = set[0].incorrectAnswer1;
            question0Ordered[2] = set[0].incorrectAnswer2;
            question0Ordered[3] = set[0].incorrectAnswer3;
            //Displaying the concatenated strings in the correct order
            for (int j = 0; j < question0Ordered.Length; j++)
            {
                if (swappedABCD[0].answer == question0Ordered[j]) Console.WriteLine("\t\t\t\t\t    " + swappedABCD[0].letter + ": " + swappedABCD[0].answer);
                else if (swappedABCD[1].answer == question0Ordered[j]) Console.WriteLine("\t\t\t\t\t    " + swappedABCD[1].letter + ": " + swappedABCD[1].answer);
                else if (swappedABCD[2].answer == question0Ordered[j]) Console.WriteLine("\t\t\t\t\t    " + swappedABCD[2].letter + ": " + swappedABCD[2].answer);
                else if (swappedABCD[3].answer == question0Ordered[j]) Console.WriteLine("\t\t\t\t\t    " + swappedABCD[3].letter + ": " + swappedABCD[3].answer);
            }
            Console.WriteLine("\n\t\t\t\t  Now let's look at who answered the question correctly");
            Console.Write("\n\t\t\t\t\t\t\t  ...");
            Console.ReadLine();

            //SELECTING THE PLAYER
            Console.Clear();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t       Results:");
            Console.WriteLine("\n\n\t\t\t\t\t  " + "Name".PadRight(32) + "Time".PadLeft(5) + "\n");

            //This array will be filled with random reaction times
            double[] reactionTimes = new double[10];
            //Displays the participants who answered correctly (which is random) with their respective reaction time
            for (int i = 0; i < 10; i++)
            {
                //This random number is in charge to decide if the player whose index is randomNumber[i] is displayed or not
                int randomResult = rand.Next(2);

                if (randomResult == 1)
                {
                    //Reaction time interval from 1 to 8 seconds
                    int seconds = rand.Next(0, 8);
                    //Decimal fraction from 0 to 1
                    double decimalFraction = rand.NextDouble();
                    reactionTimes[i] = seconds + decimalFraction;
                    if (0.3 < reactionTimes[i]) //Human reaction time is around 0.3 seconds, hence, reaction times lower than that will not be displayed
                    {
                        Console.WriteLine("\t\t\t\t\t  " + arrayOfContestants[randomNumber[i]].firstName.PadRight(12) + arrayOfContestants[randomNumber[i]].lastName.PadRight(20) + $"{ reactionTimes[i]:F2}".PadLeft(5));
                    }
                }
            }
            //Selecting the index of the lowest reaction value
            double lowestReactionTime = 10;  //Set to 10 for convenience
            int indexOfTheLowestValue = 10; //Set to 10 for convenience
            for (int i = 0; i < reactionTimes.Length; i++)
            {
                if (0.3 < reactionTimes[i])
                {
                    //Calculating Lowest Reaction time
                    lowestReactionTime = Math.Min(lowestReactionTime, reactionTimes[i]);
                    if (lowestReactionTime == reactionTimes[i])
                    {
                        //Saving the index of the lowest reaction time
                        indexOfTheLowestValue = i;
                    }
                }
            }
            Console.Write("\n\t\t\t\t\t\t\t  ...");
            Console.ReadLine();
            //Hence displaying the player with lowest reaction time 
            Console.WriteLine($"\n\t\t\t\t\t    The lowest reaction time was: {reactionTimes[indexOfTheLowestValue]:F2}");
            Console.Write("\n\t\t\t\t\t\t\t  ...");
            Console.ReadLine();
            Console.Write("\n\t\t\t\t      Therefore our player will be: ");
            Console.WriteLine($"{arrayOfContestants[randomNumber[indexOfTheLowestValue]].firstName} {arrayOfContestants[randomNumber[indexOfTheLowestValue]].lastName}");
            Console.Write("\n\t\t\t\t\t\t\t  ...");
            Console.ReadLine();
            Console.Clear();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //REFRESH
            //Creating an array that will hold the first values of the current question. This is because when the for is reseted (Screen refresh) these values change
            AnswerStruct[] storedValues = new AnswerStruct[4];
            int storedRightIndex = 0, storedRandomIndex = 0;
            bool fiftyCheck = false, audienceCheck = false, phoneCheck = false; //These variables check if the lifelines have been executed
            bool firstFifty = true, firstAudience = true;


            //VARIABLES FORCAPTURING THE FINAL VALUES OF THE LIFELINES
            //Creating an array to hold the values from applying "50/50"
            string[] fiftyValues4Slots = new string[4];
            string[] fiftyValues2Slots = new string[2];
            int k = 0;
            //Creating an array to hold the values from applying "Ask the audience"
            string[] audienceValues4Slots = new string[4];
            string[] audienceValues2Slots = new string[2];
            //Creating an a string to hold the value from applying "Phone a Friend"
            string phoneValue = null;

            int auxiliarNumber = 0;
            int counter = 1; //This counter is incremented at the end of the for-loop
            //FOR LOOP Questions [1] to [15]
            for (int i = 1; i < 16; i++)
            {
                millionairePossibility = false;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //DISPLAYING THE QUESTIONS
                //Filling swappedABCD to hold all the answers for a given question
                swappedABCD[0].answer = set[i].correctAnswer;
                swappedABCD[1].answer = set[i].incorrectAnswer1;
                swappedABCD[2].answer = set[i].incorrectAnswer2;
                swappedABCD[3].answer = set[i].incorrectAnswer3;

                //Filling the percentage field of swappedAABCD with artifitial percentages (This for Ask the Audience)
                swappedABCD[0].percentage = rand.Next(51, 101);
                swappedABCD[1].percentage = rand.Next(0, 101 - swappedABCD[0].percentage);
                swappedABCD[2].percentage = rand.Next(0, 101 - swappedABCD[0].percentage - swappedABCD[1].percentage);
                swappedABCD[3].percentage = 100 - swappedABCD[0].percentage - swappedABCD[1].percentage - swappedABCD[2].percentage;

                //Applying the swap algorithm to swappedABC
                SwapAlgorithmAnswerStruct(ref swappedABCD);

                //Filling the letter field of the Struct AnswerStruct with A, B, C, D in order
                FillingWithABCD(ref swappedABCD);

                int TheRightIndex = 0, aRandomIndex = rand.Next(0, 4);
                //This for-loop searches for the index of the concatenated string that contains the right answer
                for (int j = 0; j < swappedABCD.Length; j++)
                {
                    if (swappedABCD[j].answer == set[i].correctAnswer) TheRightIndex = j;
                    //it is used in AnsweredIncorrectly() to display what the correct answer was after a failure from the player
                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //STORING
                if (i == counter)
                {
                    //Storing all necessary information to be used after the refresh
                    //Copying swappedABCD CHECK THIS ABOUT COPYING ARRAYS AND THE DIRECTION THEY POINT AT
                    storedValues[0] = swappedABCD[0];
                    storedValues[1] = swappedABCD[1];
                    storedValues[2] = swappedABCD[2];
                    storedValues[3] = swappedABCD[3];

                    storedRightIndex = TheRightIndex;
                    storedRandomIndex = aRandomIndex;

                    //This while-loop makes sure that storedRightIndex is always different to storedRandomIndex
                    while (storedRightIndex == storedRandomIndex)
                    {
                        //storedRandomIndex is used in "Phone a friend" as the index for wrong answer
                        storedRandomIndex = rand.Next(0, 4);
                    }
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                /*
                for (int j = 0; j < storedValues.Length; j++)
                {
                    Console.WriteLine(storedValues[j].letter + storedValues[j].answer + storedValues[j].percentage);
                }*/

                //Displaying on the screen
                Console.Write($"Current Money: ${moneyPrizes[i - 1]:N0}    Lifelines:  50/50: {fifty}      Ask the Audience: {audience}      Phone a Friend: {phone}\n");
                Console.WriteLine("   ------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Player: {arrayOfContestants[randomNumber[indexOfTheLowestValue]].firstName} {arrayOfContestants[randomNumber[indexOfTheLowestValue]].lastName}".PadLeft(110));
                Console.WriteLine($"\tQuestion {i} (worth ${moneyPrizes[i]:N0}).-\n");
                Console.WriteLine($"\t" + set[i].questionPhrase);
                Console.WriteLine("\n");
                Console.WriteLine($"\t\t" + ("A: " + storedValues[0].answer.PadRight(40)) + ("B: " + storedValues[1].answer.PadRight(40)));
                Console.WriteLine($"\t\t" + ("C: " + storedValues[2].answer.PadRight(40)) + ("D: " + storedValues[3].answer.PadRight(40)));
                Console.WriteLine("\n");
                Console.WriteLine("   ------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("  |   50/50   | |  Ask the Audience  | |  Phone a friend  | |  Leave the game  | |  Omnipotent Hint  | |  Main Menu  |");
                Console.WriteLine("  |  Press 1  | |      Press 2       | |      Press 3     | |      Press L     | |      Press H      | |   Press 0   |");
                Console.WriteLine("   ------------------------------------------------------------------------------------------------------------------");
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //EVALUATING PLAYER'S ANSWER
                bool whileCondition = true;

                while (whileCondition)
                {

                    if (fiftyCheck && audienceCheck && phoneCheck)
                    {
                        //50/50 and then audience (2)
                        if (firstFifty)
                        {
                            Console.Write("\n\n\t\t50/50".PadRight(39) + "Ask the Audience".PadRight(28) + "Phone a Friend".PadLeft(27)+"\n\n");
                            Console.WriteLine("        " + fiftyValues2Slots[0].PadRight(48) + audienceValues2Slots[0].PadRight(20) + "Your friend says that".PadLeft(35));
                            Console.WriteLine("        " + fiftyValues2Slots[1].PadRight(48) + audienceValues2Slots[1].PadRight(20) + phoneValue.PadLeft(35));
                            Console.WriteLine("\t\t\t\t\t\t\t\t\t    Is the right answer".PadLeft(50));
                        }
                        //Audience and then 50/50 (4)
                        else
                        {
                            Console.Write("\n\n\t\t50/50".PadRight(39) + "Ask the Audience".PadRight(28) + "Phone a Friend".PadLeft(27) + "\n\n");
                            Console.WriteLine("        " + fiftyValues2Slots[0].PadRight(48) + audienceValues4Slots[0].PadRight(20) + "Your friend says that".PadLeft(35));
                            Console.WriteLine("        " + fiftyValues2Slots[1].PadRight(48) + audienceValues4Slots[1].PadRight(20) + phoneValue.PadLeft(35));
                            Console.WriteLine("\t\t\t  " + "".PadRight(30) + audienceValues4Slots[2].PadRight(36) + "Is the right answer");
                            Console.WriteLine("\t\t\t  " + "".PadRight(30) + audienceValues4Slots[3]);
                        }
                    }
                    else if (fiftyCheck && audienceCheck)
                    {
                        //50/50 and then audience (2)
                        if (firstFifty)
                        {
                            Console.Write("\n\n\t\t\t\t50/50".PadRight(45) + "  Ask the Audience\n\n");
                            Console.WriteLine("\t\t\t  " + fiftyValues2Slots[0].PadRight(52) + audienceValues2Slots[0]);
                            Console.WriteLine("\t\t\t  " + fiftyValues2Slots[1].PadRight(52) + audienceValues2Slots[1]);
                        }
                        //Audience and then 50/50 (4)
                        else
                        {
                            Console.Write("\n\n\t\t\t\t50/50".PadRight(45) + "  Ask the Audience\n\n");
                            Console.WriteLine("\t\t\t  " + fiftyValues2Slots[0].PadRight(52) + audienceValues4Slots[0]);
                            Console.WriteLine("\t\t\t  " + fiftyValues2Slots[1].PadRight(52) + audienceValues4Slots[1]);
                            Console.WriteLine("\t\t\t  " + "".PadRight(52) + audienceValues4Slots[2]);
                            Console.WriteLine("\t\t\t  " + "".PadRight(52) + audienceValues4Slots[3]);
                        }

                    }
                    else if (fiftyCheck && phoneCheck)
                    {
                        Console.Write("\n\n\t\t\t\t50/50".PadRight(44) + "\t\t   Phone a Friend\n\n");
                        Console.WriteLine("\t\t\t  " + fiftyValues2Slots[0].PadRight(51) + "  Your friend says that");
                        Console.WriteLine("\t\t\t  " + fiftyValues2Slots[1].PadRight(51) + "  \"{0}\"", phoneValue);
                        Console.WriteLine("\t\t\t  " + "  ".PadRight(51) + "\tIs the right answer");
                    }
                    else if (audienceCheck && phoneCheck)
                    {
                        Console.Write("\n\t\t\t\t\t\t\t  ...");
                        Console.Write("\n\n\t\t\t\t    Ask the Audience".PadRight(30) + "\t\t  Phone a Friend\n\n");
                        Console.WriteLine("\t\t\t\t\t " + audienceValues4Slots[0].PadRight(30) + "Your friend says that");
                        Console.WriteLine("\t\t\t\t\t " + audienceValues4Slots[1].PadRight(30) + "\"{0}\"", phoneValue);
                        Console.WriteLine("\t\t\t\t\t " + audienceValues4Slots[2].PadRight(31) + "Is the right answer");
                        Console.WriteLine("\t\t\t\t\t " + audienceValues4Slots[3].PadRight(30));
                    }
                    else if (fiftyCheck)
                    {
                        Console.Write("\n\t\t\t\t\t\t\t  ...");
                        Console.Write("\n\n\t\t\t\t\t\t\t 50/50\n\n");
                        Console.WriteLine("\t\t\t\t\t\t   " + fiftyValues2Slots[0]);
                        Console.WriteLine("\t\t\t\t\t\t   " + fiftyValues2Slots[1]);
                    }
                    else if (audienceCheck)
                    {
                        Console.Write("\n\t\t\t\t\t\t\t  ...");
                        Console.Write("\n\n\t\t\t\t\t\t    Ask the Audience\n\n");
                        Console.WriteLine("\t\t\t\t\t\t\t " + audienceValues4Slots[0]);
                        Console.WriteLine("\t\t\t\t\t\t\t " + audienceValues4Slots[1]);
                        Console.WriteLine("\t\t\t\t\t\t\t " + audienceValues4Slots[2]);
                        Console.WriteLine("\t\t\t\t\t\t\t " + audienceValues4Slots[3]);
                    }
                    else if (phoneCheck)
                    {
                        Console.Write("\n\t\t\t\t\t\t\t  ...");
                        Console.WriteLine($"\n\n\t\t\t\t Your friend says that \"{phoneValue}\" is the rigfht answer");
                    }

                    Console.Write("\n\t\t\t\t\t\t\t  ...");
                    Console.Write("\n\n\t\t\t\t\t\t\t Answer");
                    Console.Write("\n\t\t\t\t\t\t\t  :");
                    string answer = Console.ReadLine();
                    switch (answer.ToLower())
                    {
                        case "a":
                            if (storedValues[0].answer == set[i].correctAnswer)
                            {
                                millionairePossibility = true; Console.WriteLine($"\n\t\t\t\t\t\tYou have won ${moneyPrizes[i]:N0} NZD"); Console.Write("\n\t\t\t\t\t\t\t  ..."); Console.ReadLine();
                                fiftyCheck = false;
                                audienceCheck = false;
                                phoneCheck = false;
                                counter = i;
                            }
                            else
                            { AnsweredIncorrectly(i, moneyPrizes, storedValues[storedRightIndex].letter + ": " + storedValues[storedRightIndex].answer); backToMenu = true; }

                            whileCondition = false;
                            break;
                        case "b":
                            if (storedValues[1].answer == set[i].correctAnswer)
                            {
                                millionairePossibility = true; Console.WriteLine($"\n\t\t\t\t\t\tYou have won ${moneyPrizes[i]:N0} NZD"); Console.Write("\n\t\t\t\t\t\t\t  ..."); Console.ReadLine();
                                fiftyCheck = false;
                                audienceCheck = false;
                                phoneCheck = false;
                                counter = i;
                            }
                            else
                            { AnsweredIncorrectly(i, moneyPrizes, storedValues[storedRightIndex].letter + ": " + storedValues[storedRightIndex].answer); backToMenu = true; }

                            whileCondition = false;
                            break;
                        case "c":
                            if (storedValues[2].answer == set[i].correctAnswer)
                            {
                                millionairePossibility = true; Console.WriteLine($"\n\t\t\t\t\t\tYou have won ${moneyPrizes[i]:N0} NZD"); Console.Write("\n\t\t\t\t\t\t\t  ..."); Console.ReadLine();
                                fiftyCheck = false;
                                audienceCheck = false;
                                phoneCheck = false;
                                counter = i;
                            }
                            else
                            { AnsweredIncorrectly(i, moneyPrizes, storedValues[storedRightIndex].letter + ": " + storedValues[storedRightIndex].answer); backToMenu = true; }

                            whileCondition = false;
                            break;
                        case "d":
                            if (storedValues[3].answer == set[i].correctAnswer)
                            {
                                millionairePossibility = true; Console.WriteLine($"\n\t\t\t\t\t\tYou have won ${moneyPrizes[i]:N0} NZD"); Console.Write("\n\t\t\t\t\t\t\t  ..."); Console.ReadLine();
                                fiftyCheck = false;
                                audienceCheck = false;
                                phoneCheck = false;
                                counter = i;
                            }
                            else
                            { AnsweredIncorrectly(i, moneyPrizes, storedValues[storedRightIndex].letter + ": " + storedValues[storedRightIndex].answer); backToMenu = true; }

                            whileCondition = false;
                            break;
                        case "1"://50/50
                            if (fiftyBoolean)
                            {
                                Console.WriteLine("\n\t\t\t\t\t\t   Applying 50/50...\n");
                                Thread.Sleep(1000);
                                //This for-loop displays the right answer plus another random one in alphabetical order
                                for (int j = 0; j < storedValues.Length; j++)
                                {
                                    if (j == storedRightIndex) fiftyValues4Slots[j] = storedValues[storedRightIndex].letter + ": " + storedValues[storedRightIndex].answer;
                                    else if (j == storedRandomIndex) fiftyValues4Slots[j] = storedValues[storedRandomIndex].letter + ": " + storedValues[storedRandomIndex].answer;
                                }
                                //This for-loop stores the right and random answers in alphabetical order in a two-slot array 
                                k = 0;
                                for (int j = 0; j < fiftyValues4Slots.Length; j++)
                                {
                                    if (fiftyValues4Slots[j] != null)
                                    {
                                        fiftyValues2Slots[k] = fiftyValues4Slots[j];
                                        k++;
                                    }
                                }
                                fifty = "Used";
                                fiftyBoolean = false;  //This condition stays the same for the rest of the game
                                fiftyCheck = true; //This condition helps "Ask the Audience" and "Phone a Friend", it resets to true with every for-loop
                                auxiliarNumber = i; //This condition helps "Ask the Audience" and "Phone a Friend"
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t\t  You cannot use this option anymore");
                                Console.ReadLine();
                            }
                            //This is for checking which lifetime was executed first
                            if (firstFifty && firstAudience)
                            {
                                firstAudience = false;
                            }
                            ////////////////////////
                            RefreshScreen(ref i, ref whileCondition);
                            /////////////////////////
                            break;
                        case "2"://Ask the audience
                            if (audienceBoolean)
                            {
                                Console.WriteLine("\n\t\t\t\t\t\t  Asking the audience...\n");
                                Thread.Sleep(1000);
                                if (fiftyBoolean || (i != auxiliarNumber)) //if this is true, that means "50/50" hasn't been executed yet or that "50/50" was executed in a previous question
                                {
                                    //4 QUESTION CASE (DIFFERENT QUESTION)
                                    //Audience 20% chance of failure
                                    int chanceOfFailure = rand.Next(5);
                                    //Console.WriteLine("If this value \"{0}\" is 0, then the audience is most likely wrong", chanceOfFailure);///////////////////////////////////////////////////////////////////////////////
                                    if (chanceOfFailure == 0)
                                    {
                                        int[] failPercentages = new int[4];
                                        failPercentages[0] = storedValues[0].percentage;
                                        failPercentages[1] = storedValues[1].percentage;
                                        failPercentages[2] = storedValues[2].percentage;
                                        failPercentages[3] = storedValues[3].percentage;

                                        //Swapping the position of the percentages randomly
                                        SwapAlgorithmInt(ref failPercentages);

                                        //Saves probably wrong percentages
                                        for (int j = 0; j < storedValues.Length; j++)
                                        {
                                            audienceValues4Slots[j] = storedValues[j].letter + ": %" + failPercentages[j];
                                        }
                                    }
                                    else
                                    {
                                        //Saves right percentages
                                        for (int j = 0; j < storedValues.Length; j++)
                                        {
                                            audienceValues4Slots[j] = storedValues[j].letter + ": %" + storedValues[j].percentage;
                                        }
                                    }
                                }
                                // 2 QUESTIONS CASE (SAME QUESTION)
                                else  //If the above is not true, that means that "50/50" has just been executed within the current question, hence storedRightIndex and storedRandomIndex are different
                                {
                                    //Defining new percentages for the remaining two answers
                                    storedValues[storedRightIndex].percentage = rand.Next(51, 101);
                                    storedValues[storedRandomIndex].percentage = 100 - storedValues[storedRightIndex].percentage;

                                    //Audience chance of failure
                                    int chanceOfFailure = rand.Next(3);
                                    //Console.WriteLine("If this value \"{0}\" is 0, then the audience may be wrong", chanceOfFailure);///////////////////////////////////////////////////////////////////////////////////////////////////////////
                                    if (chanceOfFailure == 0)
                                    {
                                        int[] failPercentages = new int[2];
                                        failPercentages[0] = storedValues[storedRightIndex].percentage;
                                        failPercentages[1] = storedValues[storedRandomIndex].percentage;

                                        //Swapping the position of the percentages randomly
                                        SwapAlgorithmInt(ref failPercentages);

                                        //This for-loop displays the right answer plus another random one in alphabetical order with their respective new percentages
                                        for (int j = 0; j < storedValues.Length; j++)
                                        {
                                            if (j == storedRightIndex) audienceValues4Slots[j] = storedValues[storedRightIndex].letter + ": %" + failPercentages[0];
                                            else if (j == storedRandomIndex) audienceValues4Slots[j] = storedValues[storedRandomIndex].letter + ": %" + failPercentages[1];
                                        }
                                    }
                                    else
                                    {
                                        //This for-loop displays the right answer plus another random one in alphabetical order with ther respective new percentages
                                        for (int j = 0; j < storedValues.Length; j++)
                                        {
                                            if (j == storedRightIndex) audienceValues4Slots[j] = storedValues[storedRightIndex].letter + ": %" + storedValues[storedRightIndex].percentage;
                                            else if (j == storedRandomIndex) audienceValues4Slots[j] = storedValues[storedRandomIndex].letter + ": %" + storedValues[storedRandomIndex].percentage;
                                        }
                                    }
                                    //This for-loop stores the right and random percentages in alphabetical order in a two-slot array 
                                    k = 0;
                                    for (int j = 0; j < audienceValues4Slots.Length; j++)
                                    {
                                        if (audienceValues4Slots[j] != null)
                                        {
                                            audienceValues2Slots[k] = audienceValues4Slots[j];
                                            k++;
                                        }
                                    }
                                }
                                audience = "Used";
                                audienceBoolean = false;
                                audienceCheck = true;
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t\t  You cannot use this option anymore");
                                Console.ReadLine();
                            }
                            //This is for checking which lifetime was executed first
                            if (firstFifty && firstAudience)
                            {
                                firstFifty = false;
                            }
                            ////////////////////////
                            RefreshScreen(ref i, ref whileCondition);
                            /////////////////////////
                            break;
                        case "3"://Phone a friend depends heavily on "50/50" because 50/50 reduces the amount of questions that the friend can choose from
                            if (phoneBoolean)
                            {
                                Console.WriteLine("\n\t\t\t\t\t\t  Calling a friend...");
                                Thread.Sleep(1000);
                                // 4 QUESTION CASE (DIFFERENT QUESTION)
                                if (fiftyBoolean || (i != auxiliarNumber)) //if this is true, that means "50/50" hasn't been executed yet or that "50/50" was executed in a previous question
                                {
                                    //Friend 20% chance of failure
                                    int chanceOfFailure = rand.Next(5);
                                    //Console.WriteLine("If this value \"{0}\" is 0, then the friend is most likely wrong", chanceOfFailure);//////////////////////////////////////////////////////////////////////////////////////

                                    int randomAnswerIndex = rand.Next(4);
                                    if (chanceOfFailure == 0) phoneValue = storedValues[randomAnswerIndex].letter + ": " + storedValues[randomAnswerIndex].answer;
                                    else phoneValue = storedValues[storedRightIndex].letter + ": " + storedValues[storedRightIndex].answer;
                                }
                                // 2 QUESTION CASE (SAME QUESTION)
                                else  //If the above is not true, that means that "50/50" has just been executed within the current question
                                {
                                    //Friend 33% chance of failure
                                    int chanceOfFailure = rand.Next(3);
                                    //Console.WriteLine("If this value \"{0}\" is 0, then the friend is wrong", chanceOfFailure);////////////////////////////////////////////////////////////////////////////////////////////

                                    if (chanceOfFailure == 0) phoneValue = storedValues[storedRandomIndex].letter + ": " + storedValues[storedRandomIndex].answer;
                                    else phoneValue = storedValues[storedRightIndex].letter + ": " + storedValues[storedRightIndex].answer;
                                }
                                phone = "Used";
                                phoneBoolean = false;
                                phoneCheck = true;
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t\t  You cannot use this option anymore");
                                Console.ReadLine();
                            }
                            ////////////////////////
                            RefreshScreen(ref i, ref whileCondition);
                            /////////////////////////
                            break;
                        case "l":
                            if (moneyPrizes[i - 1] == 0)
                            {
                                Console.WriteLine($"\n\t\t\t\tAre you sure you want to leave the game without even trying?");
                                Console.WriteLine("\t\t\t\t\t\t      [Press Y/N]");
                                Console.Write("\n\t\t\t\t\t\t\t  :");
                                input = Console.ReadLine();
                                //These conditionals follow the YesOrNoToMenuQuestion() method structure
                                if (input != "")
                                {
                                    input = input.ToLower();
                                    switch (input[0])
                                    {
                                        case 'y':
                                            Console.Clear();
                                            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t  ...");
                                            Console.ReadLine();
                                            backToMenu = true;
                                            whileCondition = false;
                                            break;
                                        case 'n':
                                            break;
                                        default:
                                            Console.Write("\n\t\t\t\t\t\tPlease enter a valid input");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.Write("\n\t\t\t\t\t\tPlease enter a valid input");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n\t\t\t\tAre you sure you want to leave the game and take the ${moneyPrizes[i - 1]:N0} NZD?");
                                Console.WriteLine("\t\t\t\t\t\t      [Press Y/N]");
                                Console.Write("\n\t\t\t\t\t\t\t  :");
                                input = Console.ReadLine();
                                //These conditionals follow the YesOrNoToMenuQuestion() method structure
                                if (input != "")
                                {
                                    input = input.ToLower();
                                    switch (input[0])
                                    {
                                        case 'y':
                                            Console.Clear();
                                            Console.Write($"\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t  Thanks for playing, enjoy your ${moneyPrizes[i - 1]:N0}!");
                                            Console.Write("\n\n\t\t\t\t\t\t\t  ...");
                                            Console.ReadLine();
                                            backToMenu = true;
                                            whileCondition = false;
                                            break;
                                        case 'n':
                                            break;
                                        default:
                                            Console.Write("\n\t\t\t\t\t\tPlease enter a valid input");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.Write("\n\t\t\t\t\t\tPlease enter a valid input");
                                }
                            }
                            ////////////////////////
                            RefreshScreen(ref i, ref whileCondition);
                            /////////////////////////
                            break;
                        case "h":
                            Console.WriteLine("\n\t\t\t\t     This feature is only available in the paid version");
                            Console.ReadLine();
                            Console.WriteLine("\n\t\t\t\t     Nah, just kidding. Here is the omnipotent hint: \"" + storedValues[storedRightIndex].letter + "\"");
                            break;
                        case "0":
                            Console.WriteLine("\n\t\t\t\t    Are you sure you want to go back to the main menu?");
                            Console.WriteLine("\t\t\t\t\t\t      [Press Y/N]");
                            Console.Write("\n\t\t\t\t\t\t\t  :");
                            input = Console.ReadLine();
                            YesOrNoToMenuQuestion(ref input, ref backToMenu, ref whileCondition);
                            ////////////////////////
                            RefreshScreen(ref i, ref whileCondition);
                            /////////////////////////
                            break;
                        default:
                            Console.WriteLine("\n\t\t\t\t\t   Invalid answer, please try again");
                            Console.ReadLine();
                            ////////////////////////
                            RefreshScreen(ref i, ref whileCondition);
                            /////////////////////////
                            break;
                    }
                }//while-loop

                Console.Clear();

                /* This can help with the rankings
                if (millionairePossibility) i;
                else i - 1;
                */

                //This condition congratulates the player if and only if they have answered tha last question correctly
                if (i == 15 && millionairePossibility)
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t    Congratulations!");
                    Console.WriteLine("\n\n\t\t\t\t\t\tYou are now a Millionaire");
                    Console.Write("\n\t\t\t\t\t\t\t  ...");
                    Console.ReadLine();
                }

                //Breaking the for-loop
                if (backToMenu) break;
                counter++;
            }//for-loop
        }
        public static void YesOrNoMenuQuestion(ref string input)
        {
            if (input != "")
            {
                input = input.ToLower();

                switch (input[0])
                {
                    case 'y':
                        input = "0";
                        Console.Clear();
                        break;
                    case 'n':
                        Console.Clear();
                        break;
                    default:
                        Console.Write("\n\t\t\t\t\t\tPlease enter a valid input");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            else
            {
                Console.Write("\n\t\t\t\t\t\tPlease enter a valid input");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static void YesOrNoToMenuQuestion(ref string input, ref bool backToMenu, ref bool whileCondition)
        {
            if (input != "")
            {
                input = input.ToLower();
                switch (input[0])
                {
                    case 'y':
                        backToMenu = true;
                        whileCondition = false;
                        break;
                    case 'n':
                        break;
                    default:
                        Console.Write("\n\t\t\t\t\t\tPlease enter a valid input");
                        break;
                }
            }
            else
            {
                Console.Write("\n\t\t\t\t\t\tPlease enter a valid input");
            }
        }
        public static void BubbleSort(ref ContestantDetails[] array) //This is the bubble sort algorithm to sort the names in alphabetical order
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j + 1].lastName.CompareTo(array[j].lastName) < 0)
                    {
                        ContestantDetails swap = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swap;
                    }
                }
            }
        }
        public static void PlayerUpdate(ContestantDetails[] array, string filePath)
        {
            ReadingNamesFromFile(ref array, filePath);
            bool backToMenu = false;
            bool condition = true;
            while (condition)
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t  ...");
                Console.WriteLine("\n\n\t\t\t\t\t\t     Player's Name");
                Console.Write("\n\t\t\t\t\t\t\t:");
                string input = Console.ReadLine();

                if (input != "")
                {
                    string[] inputSplit = input.Split(' ');
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Clear();
                        if (array[i].firstName.ToLower() == inputSplit[0].ToLower())
                        {
                            //This condition avoids going through the first "if" after this for-loop
                            condition = false;
                            bool condition2 = true;
                            while (condition2)
                            {
                                Console.Write("\n\n\n\n\n\n\n\t\t\t\t\t\t\t  ...\n\n");
                                Console.WriteLine($"\t\t\t\t\t   Player found: {array[i].firstName} {array[i].lastName}");
                                Console.WriteLine($"\t\t\t\t\t   Current interest: {array[i].interest}");

                                Console.WriteLine($"\n\t\t\t\t      Is this the player you are looking for? (Y/N)");
                                Console.Write("\n\t\t\t\t\t\t\t   :");
                                input = Console.ReadLine();

                                if (input != "")
                                {
                                    input = input.ToLower();
                                    if (input[0] == 'y')
                                    {
                                        Console.Write("\n\t\t\t\t\t\t\t  ...");
                                        Console.Write("\n\n\t\t\t\t\t\t  Write the new interest");
                                        Console.Write("\n\n\t\t\t\t\t\t  :");
                                        array[i].interest = Console.ReadLine();
                                        //Calling WritingToFile method to update the list
                                        WritingToFile(ref array, filePath);
                                        Console.Clear();
                                        Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t  ...");
                                        Console.WriteLine("\n\n\t\t\t\t\t\t    Interest updated");
                                        Console.Write("\n\t\t\t\t\t\t\t  ...");
                                        Console.ReadLine();
                                        condition2 = false;
                                        backToMenu = true;
                                    }
                                    //If the name is not what the user is looking for
                                    else if (input[0] == 'n') { condition2 = false; condition = true; } //The condition is set back to true in order to enter to the next conditional outside this for-loop
                                    else { Console.Write("\n\t\t\t\t\t\tPlease enter a valid input"); Console.ReadLine(); Console.Clear(); }
                                }
                                else { Console.Write("\n\t\t\t\t\t\tPlease enter a valid input"); Console.ReadLine(); Console.Clear(); }
                            }
                            if (backToMenu) break; //This break, breaks the for-loop to stop iterating through other people with the same name
                        }
                    }
                    // This condition is true when the name is not in the database
                    if (condition)
                    {
                        Console.Clear();
                        bool condition2 = true;
                        while (condition2)
                        {
                            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t  ...\n");
                            Console.WriteLine($"\n\t\t\t      The name is not in the database, do you want to try again? (Y/N): ");
                            Console.Write("\n\t\t\t\t\t\t\t   :");
                            input = Console.ReadLine();

                            if (input != "")
                            {
                                input = input.ToLower();
                                if (input[0] == 'y') condition2 = false;
                                else if (input[0] == 'n') { condition2 = false; condition = false; }  // "condition" breaks the while-loop and makes it go back to the menu
                                else { Console.Write("\n\t\t\t\t\t\tPlease enter a valid input"); Console.ReadLine(); Console.Clear(); }
                            }
                            else { Console.Write("\n\t\t\t\t\t\tPlease enter a valid input"); Console.ReadLine(); Console.Clear(); }
                        }
                    }
                }
                else
                {
                    Console.Write("\n\t\t\t\t\t\t\t  ...");
                    Console.Write("\n\n\t\t\t\t\t\tPlease enter a valid input");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        public static void Options()
        {
            //Creating an array of the type "ContestantDetails" with 30 slots
            ContestantDetails[] arrayOfContestants = new ContestantDetails[30];
            //Path where the file is
            string filePath = "millionaire.txt";

            string input;
            do
            {
                Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\tOptions");
                Console.WriteLine("\n\n\n\t\t\t\t\t\t       Player List");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 1]");
                Console.WriteLine("\n\t\t\t\t\t\t      Update a Player");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 2]");
                Console.WriteLine("\n\t\t\t\t\t\t\tRankings");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 3]");
                Console.WriteLine("\n\t\t\t\t\t\t\tMain Menu");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 0]");
                Console.Write("\n\t\t\t\t\t\t\t    :");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        //This method fills the previosuly created array with the information from the given file
                        ReadingNamesFromFile(ref arrayOfContestants, filePath);

                        //Sorting the names
                        BubbleSort(ref arrayOfContestants);

                        Console.Write("\n\t\t\t\t\t\t\t  ...\n\n");
                        //Displaying the names
                        for (int i = 0; i < arrayOfContestants.Length; i++)
                        {
                            Console.WriteLine("\t\t\t\t" + arrayOfContestants[i].lastName.PadRight(25) + arrayOfContestants[i].firstName.PadRight(15) + arrayOfContestants[i].interest.PadRight(15));
                        }
                        Console.Write("\n\t\t\t\t\t\t\t  ...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        //This method asks for a player in order to update their interest
                        PlayerUpdate(arrayOfContestants, filePath);
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Here go the rankings");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "0":
                        break;
                    default:
                        Console.Write("\n\t\t\t\t\t\tPlease enter a valid input");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (input != "0");
        }
        public static void Credits()
        {
            Console.Write("\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t  ...\n\n");
            Console.WriteLine("\t\t        This game was possible thanks to the knowledge and skills that I acquired");
            Console.WriteLine("\t\t\t   during my Programming classes in the first semester of my first year");
            Console.WriteLine("\t\t    in the Bachelor of Information Technology at the Otago Polytechnic (Dunedin Campus)");
            Console.WriteLine("\n\n\t\t\t\t\t\t    Francisco Rosas");
            Console.Write("\n\t\t\t\t\t\t\t  ...");
            Console.ReadLine();
        }
        static void Main()
        {
            string input;
            do
            {
                Console.WriteLine("\n\n\n\n\t\t\t\t\t      Who Wants to Be a Millionaire?");
                Console.WriteLine("\n\n\n\t\t\t\t\t\t\tNew Game");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 1]");
                Console.WriteLine("\n\t\t\t\t\t\t\t Options");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 2]");
                Console.WriteLine("\n\t\t\t\t\t\t\t Credits");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 3]");
                Console.WriteLine("\n\t\t\t\t\t\t\tQuit Game");
                Console.WriteLine("\t\t\t\t\t\t\t[Press 0]");
                Console.Write("\n\t\t\t\t\t\t\t    :");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        NewGame();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Options();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Credits();
                        Console.Clear();
                        break;
                    case "0":
                        Console.WriteLine("\n\t\t\t\t\t   Are you sure you want to quit the game?");
                        Console.WriteLine("\t\t\t\t\t\t\t[Press Y/N]");
                        Console.Write("\n\t\t\t\t\t\t\t    :");
                        input = Console.ReadLine();
                        YesOrNoMenuQuestion(ref input);
                        break;
                    default:
                        Console.Write("\n\t\t\t\t\t\tPlease enter a valid input");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (input != "0");
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t     Exiting the game");
            Thread.Sleep(2500);
        }
    }
}

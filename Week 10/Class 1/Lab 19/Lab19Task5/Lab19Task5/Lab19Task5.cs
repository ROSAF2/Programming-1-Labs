using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19Task5
{
    class Lab19Task5
    {
        public static string PickWord()
        {
            Random rand = new Random();
            string[] wordArray = { "word1", "word2", "word3", "word4", "word5", "word6", "word7", "word8", "word9", "word10" };
            return wordArray[rand.Next(0, wordArray.Length)];
        }

        public static string Jumbling(string word)
        {
            Random rand = new Random();
            int num1, num2;
            string jumbled;

            //Creating a character array from the entered word
            char[] characters = word.ToCharArray();
            //Supporting variable
            char swap;
            
            for (int i = 1; i <= 5; i++)
            {
                //Creating two random numbers from 0 to the length of the word

                    num1 = rand.Next(0, word.Length);
                    num2 = rand.Next(0, word.Length);

                //Swapping characters
                swap = characters[num1];
                characters[num1] = characters[num2];
                characters[num2] = swap;
            }
            return jumbled = new string(characters);
        }

        static void Main()
        {
            do
            {
                string picked = PickWord();
                string result = Jumbling(picked);
                Console.WriteLine("Randomly selected word: {0}", picked);
                Console.WriteLine("\nJumbled word: {0}", result);
                Console.WriteLine();
                Console.ReadLine();
            } while (true);
        }
    }
}

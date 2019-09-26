using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19Task5V2
{
    class Lab19Task5V2
    {
        public static string PickedWord()
        {
            Random rand = new Random();
            string[] array = {"wordOne","wordTwo","wordThree","wordFour","wordFive","wordSix","wordSeven","wordEight","wordNine","wordTen" };
            return array[rand.Next(0,array.Length)];
        }

        public static string Jumbling(string word)
        {
            Random rand = new Random();
            char[] characters = word.ToCharArray();
            int num1, num2;
            char swap;

            for (int i = 0; i < 10; i++)
            {
                num1 = rand.Next(0, characters.Length);
                num2 = rand.Next(0, characters.Length);

                swap = characters[num1];
                characters[num1] = characters[num2];
                characters[num2] = swap;
            }
            return new string(characters); 
        }

        static void Main()
        {
            string wordPicked, guess;
            Console.WriteLine("\t\tWord Jumbling Game");

            while (true)
            {
                wordPicked = PickedWord();
                Console.WriteLine("Find out what this jumbled word is: \"{0}\"", Jumbling(wordPicked));
                Console.Write("Guess: ");
                guess = Console.ReadLine();
                if (guess == wordPicked) Console.WriteLine("\nYou are correct!");
                else Console.WriteLine("\nNice try");
                Console.WriteLine("Your guess is {0} and the original word is {1}.", guess,wordPicked);
                Console.WriteLine("\n/////////////////////////////////////////////////");
                Console.ReadLine();
            }

        }
    }
}

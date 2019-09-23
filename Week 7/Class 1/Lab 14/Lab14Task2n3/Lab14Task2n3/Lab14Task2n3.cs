using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Task2n3
{
    class Lab14Task2n3
    {
        static void Main()
        {
            string phrase = "The quick brown fox jumps over the lazy dog  ";

            //Copying the sentence
            string newPhrase = string.Copy(phrase);

            //Adding the word hairy before brown
            newPhrase = phrase.Insert(phrase.IndexOf("brown"), "hairy ");

            //Replacing the word dog with chicken
            newPhrase = newPhrase.Replace("dog", "chicken");

            //Trimming the two spaces at the end
            newPhrase = newPhrase.TrimEnd();

            //Displaying sentences
            Console.WriteLine("Original sentence:".PadRight(25) + phrase);
            Console.WriteLine("New sentence:".PadRight(25) + newPhrase);

            //Converting to lower and upper
            Console.WriteLine("\n{0}", newPhrase.ToLower());
            Console.WriteLine("{0}", newPhrase.ToUpper());


            Console.ReadLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Task7
{
    class Lab14Task7
    {
        static void Main()
        {
            string sentence = "The quick fox jumps over the lazy dog  ";
            string copied = string.Copy(sentence);
            string inserted = copied.Insert(10, "hairy ");
            string replaced = inserted.Replace("dog", "chicken");


            Console.Write(replaced.TrimEnd());
            Console.WriteLine("\n");

            string[] splitArray = replaced.Split(' ');

            foreach (var slot in splitArray)
            {
                Console.WriteLine(slot);
            }

            string[] secArray = new string[9];
            string[] thirdArray = new string[9];
            string[] concat = new string[9];


            for (int i = 0; i < 9; i++)
            {
                secArray[i] = splitArray[i].Substring(1);
                thirdArray[i] = splitArray[i].Remove(1);
                thirdArray[i] = thirdArray[i].ToUpper();

                concat[i] = thirdArray[i] + secArray[i];
                replaced = replaced.Replace(splitArray[i], concat[i]);
            }

            Console.WriteLine("\n{0}", replaced);

            Console.ReadLine();
        }
    }
}

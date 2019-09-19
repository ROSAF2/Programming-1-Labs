﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp6
{
    class Program
    {
        //Main arrays
        private static string[] question = new string[8];
        private static string[] answer = new string[8];

        static void Test()
        {
            //Word arrays
            string[] positive = new string[] { "good", "fine", "nice" };
            string[] negative = new string[] { "tired", "exhausted", "angry", "bad" };
            bool loopCondition = true;
            bool nameCondition = true;
            string previousName = "";

            //Questions
            question[0] = "What is your name?"; // close-ended question
            question[1] = "Hi , nice to meet you"; // Response
            question[2] = "Ah, yes..., I remember..."; // Consistency response
            question[3] = "I thought your name was "; // Inconsistency response
            question[4] = "How are you feeling today?";//close-ended question
            question[5] = "Why do you feel ?";//Open-ended question
            question[6] = "Is it because ";
            question[7] = "Maybe it's time that you finish the technical report lmao.";

            do
            {
                //Question 0
                Console.WriteLine("\n" + question[0]);
                answer[0] = Console.ReadLine();

                if (nameCondition)
                {
                    //Question 1
                    Console.WriteLine(question[1].Insert(3, answer[0]));
                    previousName = answer[0];
                    nameCondition = false;
                }
                else if (answer[0] == previousName)
                {
                    //Question 2
                    Console.WriteLine(question[2]);

                }
                else if (answer[0] != previousName)
                {   //Question 3
                    Console.WriteLine(question[3] + previousName);
                    previousName = answer[0];
                }

                //Question 4
                Console.WriteLine("\n" + question[4]);
                answer[4] = Console.ReadLine();
                answer[4] = answer[4].ToLower();

                if (positive.Contains(answer[4]))
                {
                    Console.WriteLine("Awesome!, " + question[5].Insert(16, answer[4]));
                }
                else if (negative.Contains(answer[4]))
                {   //Question 5
                    Console.WriteLine("\n" + question[5].Insert(16, answer[4]));
                    answer[5] = Console.ReadLine();
                    //Question 6
                    Console.WriteLine("\n" + question[6] + answer[5].Replace("I ","you ").Remove(0, 8) + " that you feel "+ answer[4]+"?");
                    answer[6] = Console.ReadLine();
                    Console.WriteLine("\n" + question[7]);
                }
        } while (loopCondition);
                
        }

        static void Main()
        {
            bool someCondition=true;
            do
            {
                //Combine all questions and create 5 more based on the answers stored in the global variables
                Test();
                
            } while (someCondition);
            

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
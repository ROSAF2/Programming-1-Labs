using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Task2
{
    class Lab18Task2
    {
        private static int answer1, answer2, answer3;

        public static void Question1()
        {
            Console.WriteLine("Question 1");
            Console.Write("How much is 1+1?: ");
            answer1 = Convert.ToInt32(Console.ReadLine());
        }
        public static void Question2()
        {
            Console.WriteLine("\nQuestion 2");
            Console.Write("How much is 4+2?: ");
            answer2 = Convert.ToInt32(Console.ReadLine());
        }
        public static void Question3()
        {
            Console.WriteLine("\nQuestion 3");
            Console.Write("How much is 9+8?: ");
            answer3 = Convert.ToInt32(Console.ReadLine());
        }

        static void Main()
        {
            int counter = 0;

            Question1();
            if (answer1 == 2) counter++;
            Question2();
            if (answer2 == 6) counter++;
            Question3();
            if (answer3 == 17) counter++;

            Console.WriteLine("\nThere are {0} correct answers", counter);

            Console.ReadLine();
        }
    }
}

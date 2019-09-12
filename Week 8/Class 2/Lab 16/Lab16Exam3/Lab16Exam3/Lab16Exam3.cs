using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Exam3
{
    class Lab16Exam3
    {
        static void Main()
        {
            int marksNumber,sum,readNumber;
            double average;
            string answer;

            Console.WriteLine("Exam Program");

            do
            {
                Console.Write("\nHow many marks are you going to enter?: ");
                marksNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPlease enter the marks, one per line\n");
                sum = 0;

                for (int i = 1; i <= marksNumber; i++)
                {
                    readNumber = Convert.ToInt32(Console.ReadLine());
                    sum = sum + readNumber;
                }

                average = sum / (double)marksNumber;

                Console.WriteLine("\nThank you, here are the class results:");
                Console.WriteLine("Number of marks: {0}",marksNumber);
                Console.WriteLine($"Average mark: {average:F2}");

                Console.Write("\nWould you like to enter another class (Y or N)?: ");
                answer = Console.ReadLine();
                answer = answer.ToLower();

            } while (answer[0]=='y');

            Console.WriteLine("\nThank you for running the marks program");

            Console.ReadLine();
        }
    }
}

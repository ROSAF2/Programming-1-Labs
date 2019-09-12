using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Exam1
{
    class Lab16Exam1
    {
        static void Main()
        {
            int num1, num2, counter=0;
            string answer;
            Console.WriteLine("Mathematical Comparison Program");
            
            do
            {
                Console.Write("\nPlease enter a number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nPlease enter another number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2) Console.WriteLine("\nThe follwoing statement is true: \n\n\t{0}>{1}", num1,num2);
                else if (num1<num2) Console.WriteLine("\nThe follwoing statement is true: \n\n\t{0}<{1}", num1, num2);
                else Console.WriteLine("\nThe follwoing statement is true: \n\n\t{0}={1}", num1, num2);

                counter++;

                Console.Write("\nWould you like to run the program again? (YES/NO): ");
                answer = Console.ReadLine();
                answer = answer.ToLower();

            } while (answer[0]=='y');

            Console.WriteLine("\nThank you for running this program, you ran it {0} time(s).",counter);

            Console.ReadLine();
        }
    }
}

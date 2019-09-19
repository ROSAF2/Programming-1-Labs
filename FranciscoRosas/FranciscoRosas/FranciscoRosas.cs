using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranciscoRosas
{
    class FranciscoRosas
    {
        static void Main(string[] args)
        {
            /*Francisco Rosas
             * Exam
             * Program: An application designed to track the rainfall of each day
             *          indefinetely, providing information the rainy and non rainy days,
             *          the average rain throughout the period, and the maximum rain registered.
             */

            bool condition=true;
            int input,rainyDays=0,nonRainyDays=0,validDays=0,inputSum=0,newMax=0;
            double average;

            Console.WriteLine("Rain Tracker");
            Console.WriteLine();
            do
            {
                Console.Write("Rain status: ");
                input = Convert.ToInt32(Console.ReadLine());

                //Excluding 9999 and escaping the loop
                if (input == 9999)
                {
                    condition = false;
                    input = 0;
                }
                // excluding all negative numbers
                else if (input < 0) Console.WriteLine("That is not a valid rain measurement");

                // 0 and Positive numbers but 9999
                else
                {
                    if (input > 0) rainyDays++;
                    else nonRainyDays++;

                    validDays++;
                    inputSum += input;
                    newMax = Math.Max(newMax, input);
                }
                //Average Value
                average = inputSum / (double)validDays;

            } while (condition);

            Console.WriteLine("Total number of valid days: {0}",validDays);
            Console.WriteLine("Total number of rainy days: {0}",rainyDays);
            Console.WriteLine("Total number of not rainy days: {0}",nonRainyDays);
            Console.WriteLine($"Average rainfall: {average:F2}");
            Console.WriteLine("Maximum amount of rain in one day: {0}",newMax);


            Console.ReadLine();
        }
    }
}
